#!/usr/bin/env python3
"""Isolated fixtures for the read-only Windows host migration inventory."""
import sys
import tempfile
from pathlib import Path
import unittest

sys.path.insert(0, str(Path(__file__).resolve().parent))
from audit_windows_host import audit


class WindowsHostAuditTests(unittest.TestCase):
    def setUp(self):
        temp = tempfile.TemporaryDirectory()
        self.addCleanup(temp.cleanup)
        self.root = Path(temp.name)
        (self.root / "recovered-source").mkdir()
        (self.root / "recovered-source/LOGICA.csproj").write_text(
            '<Project><PropertyGroup><TargetFramework>net48</TargetFramework>'
            '<PlatformTarget>x86</PlatformTarget><UseWindowsForms>True</UseWindowsForms>'
            '</PropertyGroup><ItemGroup>'
            '<Reference Include="Microsoft.VisualBasic"/>'
            '<Reference Include="../dependencies/**/*.dll"/>'
            '<EmbeddedResource Include="LOGICA.Report_0_TICKET_80_ARABE.rdlc"/>'
            '</ItemGroup></Project>', encoding="utf-8")

    def test_real_host_blockers_are_reported_not_hidden(self):
        result = audit(self.root)
        self.assertEqual(["net48"], result["target_frameworks"])
        self.assertEqual(["x86"], result["platform_targets"])
        self.assertEqual(1, result["rdlc_count"])
        self.assertIn("wildcard_binary_references", result["blockers"])
        self.assertIn("visual_basic_runtime", result["blockers"])
        self.assertFalse(result["net10_windows_host_verified"])

    def test_bundled_dlls_enumerated_without_running_them(self):
        folder = self.root / "dependencies/vendor"
        folder.mkdir(parents=True)
        (folder / "printer.dll").write_bytes(b"fixture")
        result = audit(self.root)
        self.assertEqual(["dependencies/vendor/printer.dll"], result["bundled_dll_paths"])
        self.assertIn("binary_compatibility_validation_required", result["blockers"])

    def test_modern_host_is_not_misclassified_as_legacy(self):
        p = self.root / "recovered-source/LOGICA.csproj"
        p.write_text('<Project><PropertyGroup><TargetFramework>net10.0-windows</TargetFramework>'
                     '<PlatformTarget>AnyCPU</PlatformTarget></PropertyGroup></Project>')
        result = audit(self.root)
        self.assertNotIn("legacy_net48_host", result["blockers"])
        self.assertNotIn("x86_host", result["blockers"])
        self.assertFalse(result["peripheral_compatibility_verified"])


if __name__ == "__main__":
    unittest.main()
