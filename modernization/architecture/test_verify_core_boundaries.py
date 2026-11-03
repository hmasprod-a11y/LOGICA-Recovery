#!/usr/bin/env python3
"""Six isolated positive/negative structural regression fixtures."""
import sys
from pathlib import Path
import tempfile
import unittest
sys.path.insert(0, str(Path(__file__).resolve().parent))
from verify_core_boundaries import validate

class BoundaryTests(unittest.TestCase):
    def setUp(self):
        t = tempfile.TemporaryDirectory()
        self.addCleanup(t.cleanup)
        self.root = Path(t.name)
        (self.root / "modernization").mkdir()
        (self.root / "recovered-source/LOGICA/Domain").mkdir(parents=True)
        self.rule = self.root / "recovered-source/LOGICA/Domain/Rules.cs"
        self.rule.write_text("namespace Hanouty {}")
        for name, target in (("LOGICA.CoreCompatibility.csproj", "netstandard2.0;net10.0"),
                             ("LOGICA.CorePortability.csproj", "net10.0")):
            tag = "TargetFrameworks" if ";" in target else "TargetFramework"
            (self.root / "modernization" / name).write_text(
                f'<Project><PropertyGroup><{tag}>{target}</{tag}>'
                '<EnableDefaultCompileItems>false</EnableDefaultCompileItems></PropertyGroup>'
                '<Import Project="CoreSources.props" /></Project>')
        self.manifest("../recovered-source/LOGICA/Domain/Rules.cs")

    def manifest(self, *paths):
        body = "".join(f'<Compile Include="{p}" />' for p in paths)
        (self.root / "modernization/CoreSources.props").write_text(
            f"<Project><ItemGroup>{body}</ItemGroup></Project>")

    def test_valid_shared_source(self):
        result = validate(self.root)
        self.assertTrue(result["ok"], result["errors"])
        self.assertEqual(1, result["source_count"])

    def test_duplicate_rejected(self):
        p = "../recovered-source/LOGICA/Domain/Rules.cs"
        self.manifest(p, p)
        self.assertIn("duplicate production source", validate(self.root)["errors"])

    def test_escape_rejected(self):
        self.manifest("../README.md")
        self.assertFalse(validate(self.root)["ok"])

    def test_missing_rejected(self):
        self.manifest("../recovered-source/LOGICA/Domain/Missing.cs")
        self.assertTrue(any("missing source" in e for e in validate(self.root)["errors"]))

    def test_ui_dependency_rejected(self):
        self.rule.write_text("using System.Windows.Forms;")
        self.assertTrue(any("platform dependency" in e for e in validate(self.root)["errors"]))

    def test_fully_qualified_winforms_rejected(self):
        self.rule.write_text("namespace Hanouty { class X { global::System.Windows.Forms.Form form; } }")
        self.assertTrue(any("fully qualified platform dependency" in e for e in validate(self.root)["errors"]))

    def test_fully_qualified_mysql_rejected(self):
        self.rule.write_text("namespace Hanouty { class X { MySql.Data.MySqlClient.MySqlConnection db; } }")
        self.assertTrue(any("fully qualified platform dependency" in e for e in validate(self.root)["errors"]))

    def test_missing_default_compile_opt_out_rejected(self):
        p = self.root / "modernization/LOGICA.CorePortability.csproj"
        p.write_text(p.read_text().replace(
            "<EnableDefaultCompileItems>false</EnableDefaultCompileItems>", ""))
        self.assertTrue(any("default compile items" in e for e in validate(self.root)["errors"]))

    def test_nonportable_package_reference_rejected(self):
        p = self.root / "modernization/LOGICA.CorePortability.csproj"
        p.write_text(p.read_text().replace("</Project>",
            '<ItemGroup><PackageReference Include="MySql.Data" Version="8.0.0" />'
            '</ItemGroup></Project>'))
        self.assertTrue(any("nonportable reference" in e for e in validate(self.root)["errors"]))

    def test_project_reference_rejected(self):
        p = self.root / "modernization/LOGICA.CorePortability.csproj"
        p.write_text(p.read_text().replace("</Project>",
            '<ItemGroup><ProjectReference Include="../WinForms.csproj" />'
            '</ItemGroup></Project>'))
        self.assertTrue(any("nonportable reference" in e for e in validate(self.root)["errors"]))

    def test_namespaced_direct_compile_rejected(self):
        p = self.root / "modernization/LOGICA.CorePortability.csproj"
        p.write_text(p.read_text().replace(
            "<Project>", '<Project xmlns="urn:msbuild">').replace(
            "</Project>", '<ItemGroup><Compile Include="other.cs" />'
            '</ItemGroup></Project>'))
        self.assertTrue(any("direct Compile" in e for e in validate(self.root)["errors"]))

    def test_direct_compile_rejected(self):
        p = self.root / "modernization/LOGICA.CorePortability.csproj"
        p.write_text(p.read_text().replace("</Project>",
            '<ItemGroup><Compile Include="other.cs" /></ItemGroup></Project>'))
        self.assertTrue(any("direct Compile" in e for e in validate(self.root)["errors"]))

if __name__ == "__main__":
    unittest.main()
