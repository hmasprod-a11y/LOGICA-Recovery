from pathlib import Path

source = Path("recovered-source/LOGICA/Form_2_ARTICLES.cs").read_text(encoding="utf-8")

def check(condition, message):
    if not condition:
        raise AssertionError(message)

check('Picture_IMAGE.Image = null;' in source, "New article must not require default image")
check('Image val = Image.FromFile(Module1._CHEMIN_FOLDER' not in source, "No image load of sentinel 0")
check('Text_LIEN_PICTURE.Text != "0" && File.Exists(articleImagePath)' in source, "Existing image must exist before load")
check('DT.Columns.Contains("GROUPE") ?' in source, "Legacy group field read must be optional")
check(source.count('if (DT.Columns.Contains("GROUPE"))') >= 2, "Create/update group field must be optional")
print("Article creation regression source guards passed")
