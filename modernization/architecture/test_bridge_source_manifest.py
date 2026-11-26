"""The .NET 10 public bridge compiles the same recovered production sources as the core."""
import unittest
import xml.etree.ElementTree as ET
from pathlib import Path

ROOT = Path(__file__).resolve().parents[2]
CORE = ROOT / "modernization" / "CoreSources.props"
BRIDGE = ROOT / "modernization" / "architecture" / "Hanouty.ArchitectureBridge"

class ProductionBridgeManifestTests(unittest.TestCase):
    def test_manifest_matches_production_core(self):
        source = ET.parse(CORE).getroot()
        actual = ET.parse(BRIDGE / "CoreSources.ArchitectureBridge.props").getroot()
        originals = [x.attrib["Include"].replace("../recovered-source/", "")
                     for x in source.iter("Compile")]
        mapped = [x.attrib["Include"].replace("../../../recovered-source/", "")
                  for x in actual.iter("Compile")]
        self.assertEqual(originals, mapped)
        self.assertTrue(originals)

    def test_bridge_is_net10_and_exposes_public_gateway(self):
        project = ET.parse(BRIDGE / "Hanouty.ArchitectureBridge.csproj").getroot()
        self.assertEqual(project.findtext(".//TargetFramework"), "net10.0")
        imports = [n.attrib["Project"] for n in project.iter("Import")]
        self.assertEqual(imports, ["CoreSources.ArchitectureBridge.props"])
        gateway = (BRIDGE / "CheckoutSelectionGateway.cs").read_text(encoding="utf-8")
        self.assertIn("public static class CheckoutSelectionGateway", gateway)
        self.assertIn("CheckoutSelectionFlowService.ChooseBarcodeWithRefresh", gateway)
        self.assertIn("CheckoutSelectionFlowService.ChooseImageWithRefresh", gateway)

if __name__ == "__main__":
    unittest.main()
