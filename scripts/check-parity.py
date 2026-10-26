"""Run public ToDo services and compare real LOGICA checkout ledger snapshots.

No GUI, printer, or broader business equivalence is implied by this contract.
"""
import argparse
import json
import sys
import tempfile
from pathlib import Path


def compare(expected, actual, label):
    if actual != expected:
        raise AssertionError(f'{label}: expected {expected!r}, observed {actual!r}')


def run(todo_root, fixture):
    sys.path.insert(0, str(todo_root / 'todo'))
    import database as db
    from services.bootstrap import ensure_defaults
    from services.security import current_user
    from services.cash import open_session
    from services.sales import complete_sale, create_return

    previous = db.DB_PATH
    with tempfile.TemporaryDirectory() as td:
        db.DB_PATH = Path(td) / 'parity.db'
        token = None
        try:
            db.init_db()
            ensure_defaults()
            with db.connect() as conn:
                uid = conn.execute('SELECT id FROM users ORDER BY id LIMIT 1').fetchone()[0]
                pid = conn.execute('INSERT INTO products(name,sale_price_cents,stock_qty) VALUES(?,?,?)',
                                   ('Parity fixture', fixture['unit_price_cents'], fixture['initial_stock'])).lastrowid
            token = current_user.set(uid)
            sid = open_session(uid, 0)
            result = complete_sale(sid, uid, [dict(product_id=pid, qty=fixture['sold_quantity'],
                                   unit_price_cents=fixture['unit_price_cents'])], 'CASH',
                                   fixture['sold_quantity'] * fixture['unit_price_cents'])
            snapshots = []
            for step in ('sale', 'return'):
                if step == 'return':
                    with db.connect() as conn:
                        item = conn.execute('SELECT id FROM sale_items WHERE sale_id=?', (result['id'],)).fetchone()[0]
                    create_return(result['id'], sid, uid, [(item, fixture['returned_quantity'])])
                with db.connect() as conn:
                    scalar = lambda sql: conn.execute(sql).fetchone()[0]
                    snapshots.append(dict(step=step,
                        stock_quantity=scalar(f'SELECT stock_qty FROM products WHERE id={pid}'),
                        net_collected_cents=scalar('SELECT COALESCE(SUM(amount_cents),0) FROM sale_payments') - scalar('SELECT COALESCE(SUM(amount_cents),0) FROM return_payments'),
                        stock_movement_quantity=scalar(f'SELECT SUM(qty_delta) FROM stock_movements WHERE product_id={pid}'),
                        document_count=scalar('SELECT COUNT(*) FROM sales') + scalar('SELECT COUNT(*) FROM returns')))
                    compare('ok', scalar('PRAGMA integrity_check'), 'SQLite integrity')
                    compare([], conn.execute('PRAGMA foreign_key_check').fetchall(), 'foreign keys')
            compare(fixture['snapshots'], snapshots, 'ToDo contract')
            return snapshots
        finally:
            if token is not None:
                current_user.reset(token)
            db.DB_PATH = previous


def main():
    parser = argparse.ArgumentParser()
    parser.add_argument('--todo-root', type=Path, required=True)
    parser.add_argument('--fixture', type=Path, default=Path(__file__).resolve().parents[1] / 'validation/cash-sale-return.json')
    parser.add_argument('--logica-log', type=Path)
    parser.add_argument('--output', type=Path, required=True)
    args = parser.parse_args()
    fixture = json.loads(args.fixture.read_text(encoding='utf-8-sig'))
    snapshots = run(args.todo_root.resolve(), fixture)
    logica = None
    if args.logica_log:
        logica = [json.loads(line.partition('CONTRACT ')[2]) for line in args.logica_log.read_text(encoding='utf-8-sig').splitlines() if line.startswith('CONTRACT ')]
        compare(fixture['snapshots'], logica, 'LOGICA contract')
        compare(logica, snapshots, 'cross-program ledger equivalence')
    report = dict(scenario=fixture['scenario'], todo='passed', logica='passed' if logica is not None else 'not_run',
                  cross_program_parity='passed' if logica is not None else 'not_run', snapshots=snapshots,
                  limitations=['cash sale and partial return only', 'synthetic isolated schemas', 'no physical peripherals', 'no full UI or performance parity'])
    args.output.parent.mkdir(parents=True, exist_ok=True)
    args.output.write_text(json.dumps(report, indent=2) + '\n', encoding='utf-8')
    print(json.dumps(report, indent=2))


if __name__ == '__main__':
    main()
