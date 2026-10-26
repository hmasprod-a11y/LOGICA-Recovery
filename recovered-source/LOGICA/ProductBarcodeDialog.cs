using System;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace LOGICA;

// Code is the optional, shareable scanner value. ID_ARTICLE identifies stock and sales.
internal sealed class ProductBarcodeDialog : Form
{
    public DataRow SelectedProduct { get; private set; }
    public string SelectedAction { get; private set; }
    public decimal StockQuantity { get { return quantity.Value; } }
    private readonly DataGridView products;
    private readonly NumericUpDown quantity;

    public static string Normalize(string code) { code = (code ?? "").Trim(); return code == "0" ? "" : code; }

    public static DataTable Find(string code, string exceptId = "")
    {
        var result = new DataTable();
        code = Normalize(code);
        if (code.Length == 0) return result;
        using (var command = new MySqlCommand("SELECT * FROM TABLE_ARTICLES WHERE TRIM(Code)=@code AND (@except='' OR ID_ARTICLE<>@except) ORDER BY Article,ID", Module1.cn_SQL))
        using (var adapter = new MySqlDataAdapter(command))
        {
            command.Parameters.AddWithValue("@code", code);
            command.Parameters.AddWithValue("@except", exceptId);
            adapter.Fill(result);
        }
        return result;
    }

    public static DataTable Resolve(IWin32Window owner, string code)
    {
        var matches=Find(code);
        if(matches.Rows.Count<=1)return matches;
        using(var choice=new ProductBarcodeDialog(matches,false,code))
        {
            if(choice.ShowDialog(owner)!=DialogResult.OK)return null;
            var selected=matches.Clone();selected.ImportRow(choice.SelectedProduct);return selected;
        }
    }

    public ProductBarcodeDialog(DataTable rows, bool stockMode, string barcode)
    {
        Name = stockMode ? "DuplicateBarcodeStock" : "DuplicateBarcodeSale";
        Text = stockMode ? "Code-barres déjà utilisé : " + barcode : "Choisir le produit : " + barcode;
        StartPosition = FormStartPosition.CenterParent;
        Size = new Size(900, 550); MinimumSize = new Size(720, 430);
        Font = new Font("Segoe UI", 11); MinimizeBox = false; MaximizeBox = false;
        var title = new Label { Dock=DockStyle.Top, Height=58, Padding=new Padding(12), Text= stockMode ? "Choisissez un produit existant ou créez une nouvelle fiche." : "Plusieurs produits ont ce code-barres. Sélectionnez le produit vendu." };
        products = new DataGridView { Name="Products", Dock=DockStyle.Fill, ReadOnly=true, AllowUserToAddRows=false, AllowUserToDeleteRows=false, AutoGenerateColumns=false, MultiSelect=false, SelectionMode=DataGridViewSelectionMode.FullRowSelect, RowHeadersVisible=false, BackgroundColor=Color.White, AutoSizeColumnsMode=DataGridViewAutoSizeColumnsMode.Fill };
        products.RowTemplate.Height=68;
        products.Columns.Add(new DataGridViewImageColumn {Name="Photo",HeaderText="Photo",ImageLayout=DataGridViewImageCellLayout.Zoom,FillWeight=55});
        products.Columns.Add(new DataGridViewTextBoxColumn {Name="Article",HeaderText="Produit / taille / couleur",FillWeight=210});
        products.Columns.Add(new DataGridViewTextBoxColumn {Name="Price",HeaderText="Prix vente (DH)",FillWeight=80});
        products.Columns.Add(new DataGridViewTextBoxColumn {Name="Stock",HeaderText="Stock",FillWeight=65});
        products.Columns.Add(new DataGridViewTextBoxColumn {Name="Identity",HeaderText="Référence interne",FillWeight=85});
        products.Columns.Add(new DataGridViewTextBoxColumn {Name="Parent",HeaderText="Variante de",FillWeight=80});
        foreach(DataRow row in rows.Rows)
        {
            string label=Convert.ToString(row["Article"]);
            foreach(string column in new[]{"Taille","Couleur"}) if(rows.Columns.Contains(column) && !string.IsNullOrWhiteSpace(Convert.ToString(row[column]))) label += " / " + Convert.ToString(row[column]);
            var image=Module1.LoadAvailableProductPhoto(Convert.ToString(row["Images"]),80,60);
            int index=products.Rows.Add(image,label,Convert.ToDecimal(row["PRIX_V_1"]).ToString("0.00"),row["STOCK"],row["ID_ARTICLE"],rows.Columns.Contains("VARIANT_PARENT") ? Convert.ToString(row["VARIANT_PARENT"]) : "");
            products.Rows[index].Tag=row;
        }
        products.Columns["Photo"].DefaultCellStyle.NullValue=null;
        var actions = new FlowLayoutPanel { Dock=DockStyle.Bottom, Height= stockMode ? 114 : 65, Padding=new Padding(6), AutoScroll=true };
        quantity = new NumericUpDown { Name="StockQuantity", Minimum=0.001m, Maximum=100000000, DecimalPlaces=3, Value=1, Width=100 };
        if(stockMode)
        {
            actions.Controls.Add(new Label{Text="Quantité à ajouter :",AutoSize=true,Padding=new Padding(0,8,0,0)});
            actions.Controls.Add(quantity);
            actions.SetFlowBreak(quantity,true);
            AddAction(actions,"AddStock","Ajouter au stock existant","stock",true);
            AddAction(actions,"CreateVariant","Ajouter une taille / variante","variant",true);
            AddAction(actions,"CreateIndependent","Créer un produit indépendant","independent",false);
        }
        else
        {
            var choose=AddAction(actions,"ChooseProduct","Choisir ce produit","sale",true);
            AcceptButton=choose;
            products.CellDoubleClick += (s,e) => { if(e.RowIndex>=0) Choose("sale",true); };
        }
        var cancel=new Button{Name="CancelChoice",Text="Annuler",AutoSize=true,Height=42,DialogResult=DialogResult.Cancel};
        actions.Controls.Add(cancel);CancelButton=cancel;
        Controls.Add(products);Controls.Add(title);Controls.Add(actions);
        Shown += (s,e) => { products.ClearSelection(); products.CurrentCell=null; products.Focus(); };
        FormClosed += (s,e) => { foreach(DataGridViewRow row in products.Rows) (row.Cells["Photo"].Value as Image)?.Dispose(); };
    }

    private Button AddAction(FlowLayoutPanel panel,string name,string text,string action,bool needsProduct)
    {
        var button=new Button{Name=name,Text=text,AutoSize=true,Height=42};
        button.Click += (s,e) => Choose(action,needsProduct);
        panel.Controls.Add(button);return button;
    }
    private void Choose(string action,bool needsProduct)
    {
        if(needsProduct && products.SelectedRows.Count==0) return;
        SelectedProduct=products.SelectedRows.Count==0 ? null : (DataRow)products.SelectedRows[0].Tag;
        SelectedAction=action;DialogResult=DialogResult.OK;Close();
    }

    public static void AddStock(DataRow product,decimal amount)
    {
        if(amount<=0)throw new ArgumentOutOfRangeException("amount");
        bool opened=Module1.cn_SQL.State!=ConnectionState.Open;
        if(opened)Module1.cn_SQL.Open();
        try
        {
            using(var transaction=Module1.cn_SQL.BeginTransaction())
            using(var command=Module1.cn_SQL.CreateCommand())
            {
                command.Transaction=transaction;
                command.CommandText="UPDATE TABLE_ARTICLES SET STOCK=COALESCE(STOCK,0)+@quantity WHERE ID=@id AND ID_ARTICLE=@articleId";
                command.Parameters.AddWithValue("@quantity",amount);command.Parameters.AddWithValue("@id",product["ID"]);command.Parameters.AddWithValue("@articleId",product["ID_ARTICLE"]);
                if(command.ExecuteNonQuery()!=1)throw new InvalidOperationException("Le produit a été supprimé ou modifié. Actualisez la liste.");
                command.CommandText="INSERT INTO TABLE_MOUVEMENTS_STOCK (DATES,HEURE,LIBELLE,ID_ARTICLE,CODE_ARTICLE,ARTICLE,QUANTITE) VALUES (@date,@time,@label,@articleId,@code,@name,@quantity)";
                command.Parameters.AddWithValue("@date",DateTime.Today);command.Parameters.AddWithValue("@time",DateTime.Now.ToString("HH:mm:ss"));command.Parameters.AddWithValue("@label","Ajout de stock - code-barres partagé");command.Parameters.AddWithValue("@code",product["Code"]);command.Parameters.AddWithValue("@name",product["Article"]);
                command.ExecuteNonQuery();transaction.Commit();
            }
        }
        finally { if(opened)Module1.cn_SQL.Close(); }
    }
}
