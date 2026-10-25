"""Migrate and repair the recovered project in-place; never patch a disposable build copy."""
import pathlib,re,tarfile,shutil,xml.etree.ElementTree as ET
root=pathlib.Path('recovered-source')
if not root.exists():
 root.mkdir()
 with tarfile.open('input/LOGICA-source-complete.tar.gz') as archive: archive.extractall(root,filter='data')
for generated in (root/"obj",root/"bin"):
 if generated.exists(): shutil.rmtree(generated)
for backup in root.glob("*.bak"): backup.unlink()
# Reconstruct omitted nested type names from their original control owners.
types={
 'Directions':'Bunifu.UI.WinForms.BunifuDropdown.Directions',
 'BorderThickness':'Bunifu.UI.WinForms.BunifuDropdown.BorderThickness',
 'TextAlign':'Bunifu.UI.WinForms.BunifuDropdown.TextAlign',
 'Indicator':'Bunifu.UI.WinForms.BunifuDropdown.Indicator',
 'BindingControlPositions':'Bunifu.UI.WinForms.BunifuCheckBox.BindingControlPositions',
 'CheckStates':'Bunifu.UI.WinForms.BunifuCheckBox.CheckStates',
 'CheckBoxStyles':'Bunifu.UI.WinForms.BunifuCheckBox.CheckBoxStyles',
 'BorderEdges':'Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges',
 'BorderStyles':'Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles',
 'ButtonStates':'Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates',
 'Types':'Bunifu.UI.WinForms.BunifuPictureBox.Types',
 'CapStyles':'Bunifu.UI.WinForms.BunifuCircleProgress.CapStyles',
 'FillStyles':'Bunifu.UI.WinForms.BunifuCircleProgress.FillStyles',
 'ENCODE_MODE':'ThoughtWorks.QRCode.Codec.QRCodeEncoder.ENCODE_MODE',
 'ERROR_CORRECTION':'ThoughtWorks.QRCode.Codec.QRCodeEncoder.ERROR_CORRECTION',
 'ObjectCollection':'System.Windows.Forms.CheckedListBox.ObjectCollection',
 'State':'System.Windows.Forms.AxHost.State',
 'CheckedChangedEventArgs':'Bunifu.UI.WinForms.BunifuCheckBox.CheckedChangedEventArgs',
 '_003F':'Microsoft.Reporting.WinForms.LocalReport',
}
for p in root.rglob('*.cs'):
 body=p.read_text(encoding='utf-8-sig'); before=body
 # Decompiler emitted protected base calls through casts, which C# forbids.
 body=re.sub(r'\(\((?:[\w.]+)\)this\)\.(Dispose|SetStyle|OnPaint|OnPaintBackground|OnHandleCreated|OnCreateControl|OnResize|OnMouseEnter|OnMouseLeave|OnMouseDown|OnMouseUp|OnMouseMove|OnMouseClick|OnRenderMenuItemBackground)\(',r'base.\1(',body)
 body=body.replace('((Form)this).CreateParams','base.CreateParams')
 for prop in ('IsSingleInstance','EnableVisualStyles','ShutdownStyle','MainForm'):
  body=body.replace('((WindowsFormsApplicationBase)this).'+prop,'base.'+prop)
 body=re.sub(r'\bprivate\s+(?=(?:(?:new|unsafe)\s+)*(?:virtual|abstract)\b)','protected ',body)
 body=re.sub(r'\bsealed\s+(?=class\s+FormAnimator\b)','',body)
 if 'System.Windows.Forms' in body:
  body=re.sub(r'(?<![.\w])Timer\b','System.Windows.Forms.Timer',body)
 for short,full in types.items(): body=re.sub(r'(?<![.\w])'+short+r'\b',full,body)
 if p.name=='Form_9_PARAMETRE.cs':
  body=re.sub(r'(?<![.\w])BunifuGradientPanel\b','Bunifu.UI.WinForms.BunifuGradientPanel',body)
 if p.name=='Form_5_CLIENTS_RDV.cs':
  body=re.sub(r'\(\(ControlCollection\)(\w+\.Controls)\)',r'\1',body)
 if p.name=='Form_3_VENTE.cs':
  body=re.sub(r'(\.State\s*&\s*)(\d+)',r'\1(DrawItemState)\2',body)
 if body!=before: p.write_text(body,encoding='utf-8')
# Keep project paths portable and preserve all shipped runtime DLLs.
p=root/'LOGICA.csproj'; tree=ET.parse(p); project=tree.getroot()
for group in project.findall('ItemGroup'):
 for ref in list(group.findall('Reference')): group.remove(ref)
group=ET.SubElement(project,'ItemGroup')
for name in ['Microsoft.VisualBasic','System.Xml.Linq','System.Data','System.Windows.Forms.DataVisualization','System.Xml','System.Data.DataSetExtensions','System.Core','System.Management']:
 ET.SubElement(group,'Reference',Include=name)
r=ET.SubElement(group,'Reference',Include='$(MSBuildThisFileDirectory)..\\dependencies\\**\\*.dll')
ET.SubElement(r,'Private').text='true'
if not project.findall('.//PackageReference[@Include="System.Resources.Extensions"]'):
 ET.SubElement(group,'PackageReference',Include='System.Resources.Extensions',Version='4.7.1')
props=project.find('PropertyGroup')

for name in ('GenerateResourceUsePreserializedResources','AutoGenerateBindingRedirects','GenerateBindingRedirectsOutputType'):
 node=props.find(name)
 if node is None: node=ET.SubElement(props,name)
 node.text='true'

ET.indent(tree);tree.write(p,encoding='unicode')
print('Repaired original source in recovered-source; project references dependencies relative to repository.')
