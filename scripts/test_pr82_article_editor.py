from pathlib import Path
f=Path("recovered-source/LOGICA/Form_2_ARTICLES.cs").read_text(encoding="utf-8")
m=Path("recovered-source/LOGICA/Application/Catalogue/CatalogueRowMapper.cs").read_text(encoding="utf-8")
sql=Path("input/migrations/20261102-article-add-compatibility.sql").read_text(encoding="utf-8")
assert 'articleImageName != "0"' in f
assert 'File.Exists(articleImagePath)' in f
assert 'catch (ArgumentException)' in f
assert 'catch (IOException)' in f
assert 'catch (UnauthorizedAccessException)' in f
assert 'Path.GetFileName(articleImageName)' in f
assert 'previousArticleImage.Dispose()' in f
assert 'DataGridView1.Rows[e.RowIndex].DataBoundItem as DataRowView' in f
assert 'CatalogueRowMapper.ResolveUniqueExistingRow(' in f
assert 'CatalogueRowMapper.PopulateEdited(editTarget,' in f
assert 'deleteRow.Delete();' in f
assert 'DT.Rows[position].Delete();' not in f
assert 'DT.Rows[position2]' not in f
assert 'DataGridView1.Rows[Conversions.ToInteger(Label_INDEX.Text)].Selected = true;' not in f
assert 'Image val = Image.FromFile(Module1._CHEMIN_FOLDER' not in f
for field in ("GROUPE","PRIX_QTE","PRIX_QTE_MIN","Taille","Couleur","Emplacement"):
    assert 'row.Table.Columns.Contains("'+field+'")' in m,field
    assert 'ADD COLUMN IF NOT EXISTS `'+field+'`' in sql,field
print("PR82 article editor static regression checks passed")

# Editing an existing row must tolerate every missing column from the recovered schema.
for field in ("GROUPE","PRIX_QTE","PRIX_QTE_MIN","Taille","Couleur","Emplacement"):
    assert 'DT.Columns.Contains("'+field+'") ? DT.Rows[position2]["'+field+'"]' in f,field

# Sales-list and barcode selection must tolerate legacy TABLE_ARTICLES columns too.
sales = Path("recovered-source/LOGICA/Form_3_VENTE.cs").read_text(encoding="utf-8")
for field in ("GROUPE", "PRIX_QTE", "PRIX_QTE_MIN"):
    assert 'selectedArticle.Table.Columns.Contains("'+field+'")' in sales,field
assert 'Module1.dt1.Columns.Contains("GROUPE")' in sales

# Image mode preserves actual on-disk photos and old family classifications.
loader=Path("recovered-source/LOGICA/Infrastructure/Checkout/CheckoutArticleImageLoader.cs").read_text(encoding="utf-8")
assert "LoadWithFallback" in loader
assert 'Path.Combine(root, "bd", "images")' in loader
assert "Bitmap image = Load(candidate, fileName)" in loader
assert sales.count("CheckoutArticleImageLoader.LoadWithFallback(") == 2
assert "inner join TABLE_ARTICLES a on a.Famille = f.Famille" in sales

# Checkout must repair legacy station quantity schema BEFORE binding the cart.
assert "EnsureCheckoutQuantityColumn();" in sales
assert "CREATE TABLE `" in sales and "_BACKUP_" in sales
assert "ADD COLUMN `Qté` DOUBLE NOT NULL DEFAULT 0" in sales
assert sales.index("EnsureCheckoutQuantityColumn();") < sales.index('Module1.dt1 = new DataTable();')
