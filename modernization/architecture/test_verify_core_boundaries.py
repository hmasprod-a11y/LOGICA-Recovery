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

    def test_case_variant_source_rejected_for_windows(self):
        (self.rule.parent / "rules.cs").write_text("namespace Hanouty {}")
        self.manifest("../recovered-source/LOGICA/Domain/Rules.cs",
                      "../recovered-source/LOGICA/Domain/rules.cs")
        self.assertTrue(any("duplicate production source" in e
                            for e in validate(self.root)["errors"]))

    def test_escape_rejected(self):
        self.manifest("../README.md")
        self.assertFalse(validate(self.root)["ok"])

    def test_missing_rejected(self):
        self.manifest("../recovered-source/LOGICA/Domain/Missing.cs")
        self.assertTrue(any("missing source" in e for e in validate(self.root)["errors"]))

    def test_ui_dependency_rejected(self):
        self.rule.write_text("using System.Windows.Forms;")
        self.assertTrue(any("platform dependency" in e for e in validate(self.root)["errors"]))

    def test_global_using_winforms_with_tab_rejected(self):
        self.rule.write_text("global using\tSystem.Windows.Forms;")
        self.assertTrue(any("platform dependency" in e for e in validate(self.root)["errors"]))

    def test_alias_import_mysql_rejected(self):
        self.rule.write_text("using Db = MySql.Data.MySqlClient;")
        self.assertTrue(any("platform dependency" in e for e in validate(self.root)["errors"]))

    def test_newline_import_winforms_rejected(self):
        self.rule.write_text("using\nSystem.Windows.Forms;")
        self.assertTrue(any("platform dependency" in e for e in validate(self.root)["errors"]))

    def test_fully_qualified_winforms_rejected(self):
        self.rule.write_text("namespace Hanouty { class X { global::System.Windows.Forms.Form form; } }")
        self.assertTrue(any("fully qualified platform dependency" in e for e in validate(self.root)["errors"]))

    def test_fully_qualified_mysql_rejected(self):
        self.rule.write_text("namespace Hanouty { class X { MySql.Data.MySqlClient.MySqlConnection db; } }")
        self.assertTrue(any("fully qualified platform dependency" in e for e in validate(self.root)["errors"]))

    def test_string_double_slash_cannot_hide_platform_type(self):
        self.rule.write_text('namespace Hanouty { class X { string url = "https://localhost"; global::System.Windows.Forms.Form form; } }')
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


    def test_compile_remove_rejected(self):
        p = self.root / "modernization/LOGICA.CorePortability.csproj"
        p.write_text(p.read_text().replace("</Project>",
            '<ItemGroup><Compile Remove="Domain/Rules.cs" /></ItemGroup></Project>'))
        self.assertTrue(any("direct Compile" in e for e in validate(self.root)["errors"]))

    def test_conditional_manifest_rejected(self):
        p = self.root / "modernization/CoreSources.props"
        p.write_text(p.read_text().replace('<Compile Include=',
            '<Compile Condition="\'$(Configuration)\' == \'Debug\'" Include='))
        self.assertTrue(any("conditional/indirect" in e for e in validate(self.root)["errors"]))

    def test_manifest_import_rejected(self):
        p = self.root / "modernization/CoreSources.props"
        p.write_text(p.read_text().replace("</Project>",
            '<Import Project="Injected.targets" /></Project>'))
        self.assertTrue(any("manifest unreviewed import" in e for e in validate(self.root)["errors"]))

    def test_manifest_project_reference_rejected(self):
        p = self.root / "modernization/CoreSources.props"
        p.write_text(p.read_text().replace("</Project>",
            '<ItemGroup><ProjectReference Include="../WinForms.csproj" />'
            '</ItemGroup></Project>'))
        self.assertTrue(any("manifest nonportable reference" in e for e in validate(self.root)["errors"]))

    def test_manifest_conditional_itemgroup_rejected(self):
        p = self.root / "modernization/CoreSources.props"
        p.write_text(p.read_text().replace("<ItemGroup>",
            '<ItemGroup Condition="\'$(Configuration)\' == \'Release\'">'))
        self.assertTrue(any("manifest conditional structure" in e for e in validate(self.root)["errors"]))

    def test_manifest_default_compile_reenable_rejected(self):
        p = self.root / "modernization/CoreSources.props"
        p.write_text(p.read_text().replace("</Project>",
            '<PropertyGroup><EnableDefaultCompileItems>true</EnableDefaultCompileItems>'
            '</PropertyGroup></Project>'))
        self.assertTrue(any("manifest cannot re-enable" in e for e in validate(self.root)["errors"]))

    def test_manifest_usingtask_rejected(self):
        p = self.root / "modernization/CoreSources.props"
        p.write_text(p.read_text().replace("</Project>",
            '<UsingTask TaskName="Inject" AssemblyFile="unreviewed.dll" /></Project>'))
        self.assertTrue(any("manifest executable/conditional" in e for e in validate(self.root)["errors"]))

    def test_project_target_rejected(self):
        p = self.root / "modernization/LOGICA.CorePortability.csproj"
        p.write_text(p.read_text().replace("</Project>",
            '<Target Name="BeforeBuild"><Exec Command="echo injected" /></Target></Project>'))
        self.assertTrue(any("executable/conditional MSBuild" in e for e in validate(self.root)["errors"]))

    def test_manifest_choose_rejected(self):
        p = self.root / "modernization/CoreSources.props"
        p.write_text(p.read_text().replace("</Project>",
            '<Choose><When Condition="true"><ItemGroup /></When></Choose></Project>'))
        self.assertTrue(any("manifest executable/conditional" in e for e in validate(self.root)["errors"]))

    def test_conditional_target_framework_property_rejected(self):
        p = self.root / "modernization/LOGICA.CorePortability.csproj"
        p.write_text(p.read_text().replace(
            "<TargetFramework>net10.0</TargetFramework>",
            '<TargetFramework Condition="\'$(Configuration)\' == \'Release\'">net10.0</TargetFramework>'))
        self.assertTrue(any("conditional MSBuild element" in e for e in validate(self.root)["errors"]))

    def test_manifest_compile_unreviewed_metadata_rejected(self):
        p = self.root / "modernization/CoreSources.props"
        p.write_text(p.read_text().replace("<Compile Include=",
            '<Compile Generator="UnreviewedTask" Include='))
        self.assertTrue(any("unreviewed metadata" in e for e in validate(self.root)["errors"]))

    def test_manifest_item_definition_cannot_override_compile_metadata(self):
        p = self.root / "modernization/CoreSources.props"
        p.write_text(p.read_text().replace("</Project>",
            '<ItemDefinitionGroup><Compile><Link>Injected.cs</Link></Compile>'
            '</ItemDefinitionGroup></Project>'))
        self.assertTrue(any("manifest unexpected MSBuild element" in e
                            for e in validate(self.root)["errors"]))

    def test_manifest_property_cannot_override_compiler_settings(self):
        p = self.root / "modernization/CoreSources.props"
        p.write_text(p.read_text().replace("</Project>",
            '<PropertyGroup><DefineConstants>INJECTED</DefineConstants>'
            '</PropertyGroup></Project>'))
        self.assertTrue(any("manifest unexpected MSBuild element" in e
                            for e in validate(self.root)["errors"]))

    def test_unreviewed_import_rejected(self):
        p = self.root / "modernization/LOGICA.CorePortability.csproj"
        p.write_text(p.read_text().replace("</Project>",
            '<Import Project="Injected.props" /></Project>'))
        self.assertTrue(any("unreviewed project import" in e for e in validate(self.root)["errors"]))

    def test_conditional_project_structure_rejected(self):
        p = self.root / "modernization/LOGICA.CorePortability.csproj"
        p.write_text(p.read_text().replace("</Project>",
            '<ItemGroup Condition="\'$(Configuration)\' == \'Debug\'" /></Project>'))
        self.assertTrue(any("conditional project structure" in e for e in validate(self.root)["errors"]))

if __name__ == "__main__":
    unittest.main()
