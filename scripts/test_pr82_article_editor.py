from pathlib import Path
f=Path("recovered-source/LOGICA/Form_2_ARTICLES.cs").read_text(encoding="utf-8")
m=Path("recovered-source/LOGICA/Application/Catalogue/CatalogueRowMapper.cs").read_text(encoding="utf-8")
sql=Path("input/migrations/20261102-article-add-compatibility.sql").read_text(encoding="utf-8")
assert 'Text_LIEN_PICTURE.Text != "0" && File.Exists(articleImagePath)' in f
assert 'Image val = Image.FromFile(Module1._CHEMIN_FOLDER' not in f
for field in ("GROUPE","PRIX_QTE","PRIX_QTE_MIN","Taille","Couleur","Emplacement"):
    assert 'row.Table.Columns.Contains("'+field+'")' in m,field
    assert 'ADD COLUMN IF NOT EXISTS `'+field+'`' in sql,field
print("PR82 article editor static regression checks passed")

# Editing an existing row must tolerate every missing column from the recovered schema.
for field in ("GROUPE","PRIX_QTE","PRIX_QTE_MIN","Taille","Couleur","Emplacement"):
    assert 'DT.Columns.Contains("'+field+'") ? DT.Rows[position2]["'+field+'"]' in f,field
