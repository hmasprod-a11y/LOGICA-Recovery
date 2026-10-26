# Codes-barres partagés et produits sans code-barres

Version de développement : 1.1.1.0.

## Saisie du stock

Dans la fiche produit, le champ Code est facultatif. Une valeur vide (ou 0) représente un produit sans code-barres. Chaque fiche conserve son propre ID_ARTICLE interne, y compris sans code-barres.

Lors de l'enregistrement d'une nouvelle fiche avec un code déjà utilisé, la fenêtre propose :

- **Ajouter au stock existant** : sélectionner la fiche exacte, saisir la quantité dans la fenêtre, puis confirmer. Le nom et les prix de cette fiche restent inchangés. La quantité et son mouvement de stock sont enregistrés ensemble dans une transaction.
- **Ajouter une taille / variante** : sélectionner la fiche d'origine. La nouvelle fiche utilise le nom, les prix, la quantité et la photo saisis dans l'éditeur. Son stock est indépendant. VARIANT_PARENT mémorise la référence d'origine pour distinguer cette relation d'une simple collision de code.
- **Créer un produit indépendant** : enregistrer une nouvelle fiche sans parent, avec ses propres informations et stock.
- **Annuler** : ne rien enregistrer.

Deux produits sans code-barres ne déclenchent pas de fenêtre de doublon.

## Vente

Un scan avec un seul résultat conserve le fonctionnement direct. Avec plusieurs résultats, la fenêtre affiche uniquement la photo, le nom (avec taille/couleur) et le prix du tarif actif. Le caissier peut conserver la quantité, ou la modifier dans le champ × à l'aide du pavé numérique (chiffres, décimale, effacement et C). Un simple clic sur la ligne du produit l'ajoute directement au panier avec cette quantité, sans bouton de confirmation. Une quantité vide, nulle ou invalide ne peut pas valider le produit. Annuler ou fermer la fenêtre n'ajoute rien et ne change pas la quantité de la vente. Chaque nouveau scan redemande le choix.

Cliquer sur une photo identifie directement sa fiche, avec ou sans code-barres. La liste des photos continue à exclure les photos absentes ou invalides. La liste des articles reste l'onglet affiché au démarrage de la vente.

Le regroupement des lignes du panier et la vérification du stock utilisent ID_ARTICLE. La validation, l'historique et les mouvements de stock conservent cette référence afin de distinguer les fiches partageant un code.

Les recherches exactes par code dans les réceptions, sorties, inventaires, commandes, devis, bons de livraison et factures utilisent également la fenêtre de choix. Le rapprochement des lignes d'inventaire utilise ID_ARTICLE.

## Mise à jour

Fermer l'application et sa console de lancement, puis remplacer les fichiers du ZIP dans le dossier Debug existant. Conserver le dossier bd et ses données. Démarrer Start-LOGICA.cmd. Le démarrage ajoute uniquement la colonne VARIANT_PARENT manquante ; il ne réimporte pas la base et ne modifie pas les codes ou les ventes historiques.

