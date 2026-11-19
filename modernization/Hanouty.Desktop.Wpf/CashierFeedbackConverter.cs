using System.Globalization;
using System.Windows.Data;

namespace Hanouty.Desktop.Wpf;

// Presentation only: operation outcomes and authorization remain owned by the Host.
public sealed class CashierFeedbackConverter : IValueConverter
{
    public object Convert(object value, Type targetType, object parameter, CultureInfo culture) => (value as string) switch
    {
        "Selection accepted" => "Article ajouté.",
        "Product not found" => "Article introuvable.",
        "Ambiguous barcode" => "Choisissez la variante de cet article.",
        "Empty barcode" => "Scannez un article.",
        "Cashier session required" => "Ouvrez une session caissier.",
        "Local catalogue unavailable" => "Catalogue indisponible. Rechargez le catalogue.",
        "No product selected" => "Choisissez un article.",
        "Selection rejected" => "Article non ajouté. Vérifiez le panier.",
        "Selection already in progress" => "Ajout en cours…",
        "Checkout status unknown — reconcile before retry" => "Résultat à vérifier avant une nouvelle opération.",
        "Checkout committed" => "Vente enregistrée.",
        "Cart is empty" => "Le panier est vide.",
        "Cart invalidated — cashier must review" => "Panier à vérifier avant de poursuivre.",
        "Cashier review failed — checkout remains locked" => "Confirmation refusée. Vérifiez le résultat avant de poursuivre.",
        "Checkout submission unavailable" => "Choisissez le moyen de paiement.",
        "Cashier and positive cash tender required" => "Vérifiez le caissier et le montant reçu.",
        "Sale persisted — cashier review required before a new checkout" => "Vente enregistrée. Confirmez le résultat pour continuer.",
        "Sale absent — cashier review required before a new checkout" => "Vente non enregistrée. Confirmez le résultat pour continuer.",
        var message => message ?? ""
    };

    public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture) => throw new NotSupportedException();
}
