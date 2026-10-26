"""Reject false parity and verify extraction excludes SQL row values."""
import importlib.util
import tempfile
import unittest
from pathlib import Path


def load(name, filename):
    spec = importlib.util.spec_from_file_location(name, Path(__file__).with_name(filename))
    module = importlib.util.module_from_spec(spec)
    spec.loader.exec_module(module)
    return module


parity = load('parity', 'check-parity.py')
inventory = load('inventory', 'inventory-business.py')


class ValidationTests(unittest.TestCase):
    def test_parity_rejects_missing_step_and_financial_drift(self):
        expected = [{'step': 'sale', 'net_collected_cents': 2500}, {'step': 'return', 'net_collected_cents': 1250}]
        for actual in ([], expected[:1], [expected[0], dict(step='return', net_collected_cents=1251)]):
            with self.assertRaises(AssertionError):
                parity.compare(expected, actual, 'mutated ledger')

    def test_inventory_extracts_methods_tables_and_captions_without_rows(self):
        with tempfile.TemporaryDirectory() as td:
            root = Path(td)
            (root / 'form.cs').write_text('class Form {\n private void Save_Click(object s) { string sql="INSERT INTO TABLE_SALES VALUES (12345)"; Button.Text="Sale"; }\n}', encoding='utf-8')
            (root / 'service.py').write_text('def sell():\n    return "SELECT id FROM sales"\n', encoding='utf-8')
            (root / 'schema.sql').write_text("CREATE TABLE `TABLE_SALES` (id INT);\nINSERT INTO TABLE_SALES VALUES ('PRIVATE-ROW');", encoding='utf-8')
            result = inventory.inventory(root)
            self.assertEqual(result['summary']['functions'], 2)
            self.assertEqual(result['summary']['schema_tables'], ['TABLE_SALES'])
            self.assertEqual(result['summary']['ui_captions'], 1)
            self.assertIn('TABLE_SALES', result['summary']['sql_table_candidates'])
            self.assertNotIn('PRIVATE-ROW', str(result))


if __name__ == '__main__':
    unittest.main()
