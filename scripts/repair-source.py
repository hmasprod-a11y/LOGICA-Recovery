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
 # Choose enum owner from the declared DatePicker instead of a same-named Dropdown enum.
 date_vars=set(re.findall(r'\bBunifuDatePicker\s+(\w+)',body))
 lines=body.splitlines(keepends=True)
 for i,line in enumerate(lines):
  if any(re.search(r'\b'+re.escape(v)+r'\.',line) for v in date_vars):
   for enum in ('BorderThickness','TextAlign','Indicator'):
    line=line.replace('Bunifu.UI.WinForms.BunifuDropdown.'+enum,'Bunifu.UI.WinForms.BunifuDatePicker.'+enum)
   lines[i]=line
 body=''.join(lines)
 body=re.sub(r'System\.Windows\.Forms\.CheckedListBox\.ObjectCollection(\s+\w+\s*=\s*Combo_\w+\.Items)',r'System.Windows.Forms.ComboBox.ObjectCollection\1',body)
 body=body.replace('(e.State & (DrawItemState)1) == 1','(e.State & DrawItemState.Selected) == DrawItemState.Selected')
 if p.name=='Module1.cs':
  # MySQL uses a separate Port key. An environment override allows isolated testing.
  old=next((line for line in body.splitlines() if 'cn_SQL = new MySqlConnection("Data Source="' in line),None)
  if old:
   body=body.replace(old,'\t\tcn_SQL = new MySqlConnection(Environment.GetEnvironmentVariable("LOGICA_DB_CONNECTION_STRING") ?? new MySqlConnectionStringBuilder { Server = _CHEMIN_DB, Port = uint.Parse(_PORT_DB), Database = _NAME_DB, UserID = _USER_ID, Password = _PASS_ID, CharacterSet = "utf8", ConnectionTimeout = 10 }.ConnectionString);')
 if p.name=='Form_3_VENTE.cs':
  # A return has a negative basket quantity; string-prefixing '-' produced '--1'.
  # Store the arithmetic negation as a typed SQL parameter in the original transaction.
  repaired=[]
  movement=False
  for line in body.splitlines(keepends=True):
   if 'val4.CommandText = ' in line and 'INSERT  INTO   TABLE_MOUVEMENTS_STOCK' in line:
    indent=line[:len(line)-len(line.lstrip())]
    commands=[
     'val4.CommandText = "INSERT INTO TABLE_MOUVEMENTS_STOCK (DATES, HEURE, LIBELLE, ID_ARTICLE, CODE_ARTICLE, ARTICLE, QUANTITE) VALUES (@movementDate, @movementTime, @movementLabel, @movementId, @movementCode, @movementArticle, @movementQuantity)";',
     'val4.Parameters.Clear();',
     'val4.Parameters.AddWithValue("@movementDate", DateTime.Now.ToString("yyyy-MM-dd"));',
     'val4.Parameters.AddWithValue("@movementTime", DateTime.Now.ToString("HH:mm:ss"));',
     'val4.Parameters.AddWithValue("@movementLabel", "TICKET | " + _N_TICKET_SOLDER);',
     'val4.Parameters.AddWithValue("@movementId", DataGridView1.Rows[num6].Cells["ID_ARTICLE"].Value);',
     'val4.Parameters.AddWithValue("@movementCode", DataGridView1.Rows[num6].Cells["Code"].Value);',
     'val4.Parameters.AddWithValue("@movementArticle", DataGridView1.Rows[num6].Cells["Article"].Value);',
     'val4.Parameters.AddWithValue("@movementQuantity", -Conversions.ToDecimal(DataGridView1.Rows[num6].Cells["Qté"].Value));',
    ]
    repaired.extend(indent+c+'\n' for c in commands)
    movement=True
   else:
    repaired.append(line)
    if movement and 'val4.ExecuteNonQuery();' in line:
     repaired.append(line[:len(line)-len(line.lstrip())]+'val4.Parameters.Clear();\n')
     movement=False
  body=''.join(repaired)
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
