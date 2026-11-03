from pathlib import Path

f=Path("recovered-source/LOGICA/Form_2_ARTICLES.cs").read_text(encoding="utf-8")
# PR82 compatibility must survive later checkout/UI modernization.
# Both sale tiles and the article editor must use the same real-file fallback
# loader. Never switch back to direct Image.FromFile or a single-path preview.
loader = Path("recovered-source/LOGICA/Infrastructure/Checkout/CheckoutArticleImageLoader.cs").read_text(encoding="utf-8")
assert 'internal static Bitmap LoadWithFallback(' in loader
assert 'Path.Combine(root, "bd", "images")' in loader
assert 'Path.Combine(root, "images")' in loader
assert 'FileShare.ReadWrite' in loader
assert 'new Bitmap(source)' in loader
assert 'Image selectedImage = LOGICA.Infrastructure.Checkout.CheckoutArticleImageLoader.LoadWithFallback(' in f
assert 'ReplaceArticlePreview(selectedImage);' in f
assert 'string articleImagePath = Path.Combine(Module1._CHEMIN_FOLDER' not in f
assert 'using (Image articleImage = Image.FromFile(articleImagePath))' not in f


m=Path("recovered-source/LOGICA/Application/Catalogue/CatalogueRowMapper.cs").read_text(encoding="utf-8")
sql=Path("input/migrations/20261102-article-add-compatibility.sql").read_text(encoding="utf-8")
assert 'Text_LIEN_PICTURE.Text != "0" && File.Exists(articleImagePath)' in f
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
# Quantity-tier pricing is optional on article create and edit. An empty field
# must not open a blocking dialog; zero disables the tier without altering
# normal sale price, barcode, stock, or product identity.
for field in ("Text_PRIX_QTE", "Text_PRIX_QTE_MIN"):
    assert 'if (string.IsNullOrWhiteSpace(' + field + '.Text))' in f, field
    assert field + '.Text = "0";' in f, field
assert 'MessageBox.Show("Veuillez remplir le champ -PRIX_QTE- "' not in f
assert 'MessageBox.Show("Veuillez remplir le champ -PRIX_QTE_MIN- "' not in f

print("PR82 article editor static regression checks passed")

# Editing an existing row must tolerate every missing column from the recovered schema.
for field in ("GROUPE","PRIX_QTE","PRIX_QTE_MIN","Taille","Couleur","Emplacement"):
    assert 'DT.Columns.Contains("'+field+'") ? editRow["'+field+'"]' in f,field

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

# Checkout must accept legacy quantity labels in the loaded DataTable without
# writing or migrating real store database tables at cashier startup.
assert "EnsureCheckoutQuantityColumn();" in sales
assert 'NormalizeLoadedCheckoutQuantityColumn();' in sales
assert 'IsLegacyCheckoutQuantityColumn(column.ColumnName)' in sales
assert 'legacy.ColumnName = "Qté";' in sales
# The cart DataTable is loaded with physical SQL column names and then
# normalized in memory. Adapter TableMappings previously caused a missing
# SourceColumn exception during real INSERT/UPDATE.
assert 'private static MySqlDataAdapter CreateCheckoutCartAdapter()' in sales
assert 'adapter.TableMappings.Add("Table", "Table")' not in sales
assert 'mapping.ColumnMappings.Add(' not in sales
for physical in ("QtÃ©", "QtÃƒÂ©", "Qte", "Quantite"):
    assert 'string.Equals(name, "' + physical + '"' in sales
assert 'IsLegacyCheckoutQuantityColumn(parameter.SourceColumn)' in sales
assert 'IsLegacyCheckoutQuantityColumn(column.ColumnName)' in sales
assert sales.count('AssertCheckoutCartColumns();') >= 4
assert sales.count('Module1.da1 = CreateCheckoutCartAdapter();') == 4
assert 'using (MySqlCommandBuilder builder = new MySqlCommandBuilder(Module1.da1))' in sales
assert 'parameter.SourceColumn = "Qté";' in sales
# Clone the generated commands so their SourceColumn normalization cannot be
# undone by CommandBuilder RowUpdating, and they survive builder disposal.
for kind in ("Insert", "Update", "Delete"):
    assert f'(MySqlCommand)((ICloneable)builder.Get{kind}Command()).Clone()' in sales
for name in ("insert", "update", "delete"):
    assert f'RemapCheckoutCommandSourceColumns({name});' in sales
    assert f'{name}.Dispose();' in sales
assert sales.index('((DbDataAdapter)(object)Module1.da1).Update(Module1.dt1);') > sales.index('RemapCheckoutCommandSourceColumns(delete);')
assert sales.count('UpdateCheckoutCart();') == 8
assert 'row.Cells["Qté"].Value != DBNull.Value' in sales
assert '!row.IsNewRow' in sales

assert sales.index("NormalizeLoadedCheckoutQuantityColumn();") < sales.index('foreach (string required in new[]')
startup = sales.split("private static void EnsureCheckoutQuantityColumn()", 1)[1].split("private static string ExactImageArticleSql()", 1)[0]
assert "ALTER TABLE" not in startup and "CREATE TABLE" not in startup and "UPDATE `" not in startup
assert sales.index("EnsureCheckoutQuantityColumn();") < sales.index('Module1.dt1 = new DataTable();')


# Catalogue duplicate lookup is part of real create/edit/collection paths.
# Exercise the exact SQL literals with a parameter-binding SQL engine so
# apostrophes and injection-shaped input remain literal values.
import re
import sqlite3

lookup = Path("recovered-source/LOGICA/Infrastructure/Catalogue/CatalogueDuplicateLookup.cs").read_text(encoding="utf-8")
queries = re.findall(r'new MySqlDataAdapter\(\s*"([^"]+)"', lookup)
assert len(queries) == 4, "all four legacy duplicate lookup paths must be parameterized"
assert lookup.count('Parameters.AddWithValue("@code"') == 3
assert lookup.count('Parameters.AddWithValue("@excludedId"') == 2
assert 'Parameters.AddWithValue("@articleId"' in lookup
assert lookup.count('ParseExcludedId(excludedId)') == 2
assert 'long.TryParse(excludedId, NumberStyles.Integer, CultureInfo.InvariantCulture' in lookup
assert all("@" in query and "{" not in query and "+" not in query for query in queries), "no user input may be interpolated"

db = sqlite3.connect(":memory:")
db.execute("CREATE TABLE TABLE_ARTICLES (ID INTEGER, Code TEXT, Article TEXT, ID_ARTICLE TEXT)")
db.executemany("INSERT INTO TABLE_ARTICLES VALUES (?, ?, ?, ?)", [
    (1, "ABC'123", "First", "A'1"),
    (2, "ABC'123", "Second", "B"),
    (3, "NORMAL", "Third", "C"),
    (4, "", "No barcode A", "IMG-A"),
    (5, "", "No barcode B", "IMG-B"),
])
def ids(sql, **params):
    return [row[0] for row in db.execute(sql, params)]

assert ids(queries[0], code="ABC'123") == [1, 2], "new-product duplicate barcode detects both variants"
assert ids(queries[1], code="ABC'123", excludedId=1) == [2], "editing excludes only the current row"
assert ids(queries[1], code="ABC'123", excludedId=2) == [1]
assert ids(queries[2], articleId="A'1", excludedId=2) == [1], "quoted article identity is literal"
assert ids(queries[2], articleId="A'1", excludedId=1) == []
assert ids(queries[3], code="ABC'123") == [1, 2], "collection duplicate check preserves variants"
for query, params in (
    (queries[0], {"code": "' OR 1=1 --"}),
    (queries[1], {"code": "' OR 1=1 --", "excludedId": 1}),
    (queries[2], {"articleId": "' OR 1=1 --", "excludedId": 1}),
    (queries[3], {"code": "' OR 1=1 --"}),
):
    assert ids(query, **params) == [], "malformed input must not widen the predicate"
assert ids(queries[0], code="NORMAL") == [3], "ordinary barcodes unchanged"
# The real create/edit mapper trims Code before persistence. Prechecks must
# normalize to the same value; otherwise a user-entered trailing space could
# bypass duplicate detection and save an already-used barcode.
assert 'Strings.Trim(code ?? "")' in lookup
assert lookup.count('NormalizeCode(code)') == 2
assert 'NormalizeCode(code == null || code == DBNull.Value ? "" : Conversions.ToString(code))' in lookup
assert lookup.count("AND @code <> ''") == 3, "empty barcodes are not unique keys"
normalize = lambda code: (code or "").strip(" ")
assert ids(queries[0], code=normalize(" NORMAL ")) == [3]
assert ids(queries[1], code=normalize(" NORMAL "), excludedId=1) == [3]
assert ids(queries[3], code=normalize(" NORMAL ")) == [3]
assert ids(queries[0], code=normalize("")) == [], "image-only products can coexist"
assert ids(queries[0], code=normalize("   ")) == [], "space-only barcode is blank"
assert ids(queries[1], code=normalize(""), excludedId=4) == [], "edit without barcode allowed"
assert ids(queries[1], code=normalize("  "), excludedId=5) == []
assert ids(queries[3], code=normalize("")) == [], "collection blank barcode allowed"
assert ids(queries[2], articleId="IMG-A", excludedId=5) == [4], "article ID uniqueness still enforced"
assert ids(queries[2], articleId="IMG-B", excludedId=4) == [5]
assert ids(queries[0], code=normalize("ABC'123")) == [1, 2], "nonempty duplicate behavior retained"
# A malformed imported legacy row can have a missing database ID. SQL's
# three-valued logic makes "ID <> @excludedId" UNKNOWN for NULL and silently
# hides that collision. Editing must detect it rather than permit duplicates.
db.execute("INSERT INTO TABLE_ARTICLES VALUES (?, ?, ?, ?)", (None, "NULL-ID", "Legacy orphan", "NULL-ARTICLE"))
assert ids(queries[1], code="NULL-ID", excludedId=1) == [None], "null database ID must not hide duplicate barcode"
assert ids(queries[2], articleId="NULL-ARTICLE", excludedId=1) == [None], "null database ID must not hide duplicate article identity"
assert lookup.count("ID IS NULL OR ID <> @excludedId") == 2
db.close()
print("Catalogue parameterized duplicate-lookup regression: 24 SQL cases passed")


# The actual article-create path persists TABLE_ARTICLES before writing its
# initial TABLE_MOUVEMENTS_STOCK entry. A quoted barcode or article name must
# not break that second SQL write (and leave a partially created article).
movement = Path("recovered-source/LOGICA/Infrastructure/Catalogue/CatalogueCreationMovementWriter.cs").read_text(encoding="utf-8")
movement_sql = re.search(r'command\.CommandText = "([^"]+)" \+\s*"([^"]+)";', movement)
assert movement_sql, "movement INSERT must use fixed SQL with no form values concatenated"
insert_sql = movement_sql.group(1) + movement_sql.group(2)
assert insert_sql.startswith("INSERT INTO TABLE_MOUVEMENTS_STOCK")
for parameter in ("@dates", "@heure", "@articleId", "@code", "@article", "@quantity"):
    assert re.findall(r"@[A-Za-z][A-Za-z0-9]*", insert_sql).count(parameter) == 1, parameter
    assert 'Parameters.AddWithValue("' + parameter + '"' in movement, parameter
assert movement.count("Parameters.AddWithValue(") == 6
assert movement.count("DateTime.Now.ToString(") == 2, "preserve the legacy date/time read sequence"
assert movement.count("command.ExecuteNonQuery();") == 1
assert movement.index("command.ExecuteNonQuery();") < movement.index("connection.Close();")
assert "readCode() + " not in movement and "readArticle() + " not in movement
assert "readStock() + " not in movement

stock_db = sqlite3.connect(":memory:")
stock_db.execute("""CREATE TABLE TABLE_MOUVEMENTS_STOCK (
    DATES TEXT, HEURE TEXT, LIBELLE TEXT, ID_ARTICLE TEXT,
    CODE_ARTICLE TEXT, ARTICLE TEXT, QUANTITE TEXT)""")
movement_rows = (
    ("ART000001", "ABC'123", "L'eau d'orange", "1"),
    ("ART000002", "' OR 1=1 --", "x'); DROP TABLE TABLE_MOUVEMENTS_STOCK; --", "0"),
    ("ART000003", "باركود-١", "منتوج مغربي", "-2,5"),
    ("ART000004", "", "Image-only article", "0"),
)
for article_id, barcode, article, quantity in movement_rows:
    stock_db.execute(insert_sql, {
        "dates": "2026-11-02", "heure": "12:00:00", "articleId": article_id,
        "code": barcode, "article": article, "quantity": quantity,
    })
actual = stock_db.execute(
    "SELECT ID_ARTICLE, CODE_ARTICLE, ARTICLE, QUANTITE FROM TABLE_MOUVEMENTS_STOCK ORDER BY ID_ARTICLE"
).fetchall()
assert actual == list(movement_rows), "quotes, Unicode, empty barcode and signed legacy stock must round-trip"
assert stock_db.execute("SELECT COUNT(*) FROM TABLE_MOUVEMENTS_STOCK").fetchone()[0] == 4
assert stock_db.execute("SELECT DISTINCT LIBELLE FROM TABLE_MOUVEMENTS_STOCK").fetchall() == [("Création d'article",)]
stock_db.close()
print("Catalogue creation stock movement parameter-binding regression: 4 SQL cases passed")

# QA resolution of conflicting Desktop #90 and Inventory #86/#88: the
# deletion movement must use the identity-validated bound row, never a
# potentially different CurrentRow after sorting/filtering.
click = f.split("private void DataGridView1_CellClick(", 1)[1].split("\n\tprivate void ", 1)[0]
helper = f.split("private static void InsertDeletionStockMovement(", 1)[1].split("\n\tprivate void ", 1)[0]
assert "InsertDeletionStockMovement(Module1.cn_SQL, deleteRow);" in click
assert "ResolveUniqueExistingRow(" in click
assert "DataGridView1.CurrentRow" not in click, "delete path must not use CurrentRow"
assert 'MySqlCommand command = new MySqlCommand(' in helper
assert 'command.Parameters.AddWithValue("@code"' in helper
assert 'command.Parameters.AddWithValue("@article"' in helper
assert 'command.Parameters.AddWithValue("@stock"' in helper
assert "DataRow selected" in f
assert "ReplaceArticlePreview(selectedImage);" in f
assert "TryPersistArticleImage()" in f
print("QA Desktop/Inventory article identity + photo + deletion SQL integration checks passed")
