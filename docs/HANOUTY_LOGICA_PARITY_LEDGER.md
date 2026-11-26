# HANOUTY — Registre de reprise fonctionnelle LOGICA

Référence de code examinée `aa836f0f58782f0a18fd256545647af2503d901c`, branche d’intégration QA [#93](https://github.com/hmasprod-a11y/LOGICA-Recovery/pull/93). Le cahier fonctionnel V1 et les [contrats V2](HANOUTY_MASTER_MODERNIZATION_V2.md) et [V3](HANOUTY_EXECUTION_CONTRACT_V3_2026-11-04.md) gouvernent la livraison. LOGICA sert de référence pour les règles métier, les parcours et les résultats sur les données. La cible reste WPF/.NET 10 et MariaDB locale.

## Règle de reprise validée par le propriétaire

Pour chaque section, écran, point d’entrée et fonction, partir de l’implémentation LOGICA et du cahier des charges. Avant de modifier HANOUTY, identifier l’écran et ses ressources, l’action qui l’ouvre, ses commandes, les droits, les règles de calcul et les écritures ou sorties concernées. Reprendre les composants existants et conserver le parcours, l’ordre des actions et les résultats observables. Vérifier le parcours depuis son vrai point d’entrée avec un scénario commun à LOGICA et HANOUTY.

Une conception nouvelle est réservée à une fonction réellement absente de LOGICA. Une fonction dont la référence reste à retrouver demeure à examiner. Pour une fonction absente, consigner l’exigence du cahier et la décision de conception. Une recette technique réussie ne suffit pas à accepter une différence dans le parcours ou l’interface.

## État des parcours

Une preuve de code indique où se trouve le comportement. L’acceptation exige son exécution sur le parcours et la version identifiés. Le terme « à tracer » signale un audit incomplet.

| Parcours | Point d’entrée LOGICA et règle observée | Réutilisation et état côté HANOUTY | Preuve à produire |
| --- | --- | --- | --- |
| Caisse — fonds, comptage, clôture | [Fonds](../recovered-source/LOGICA/FormDialog_FONDS_CAISSE.cs#L1485), [comptage](../recovered-source/LOGICA/FormDialog_COMPTER_CAISSE.cs), [clôture](../recovered-source/LOGICA/FormDialog_CLOTURE.cs#L3324). La clôture globale attribue un même numéro aux ventes, paiements, dépenses, règlements et annulations dans une transaction. | `CashRecountService` réutilisable. Parcours de caisse complet WPF à relier. Tracer aussi la clôture par poste et les autres variantes du formulaire avant portage. | Sur données fictives, ouvrir, vendre, régler, dépenser, compter et clôturer. Comparer l’écart et les écritures à LOGICA. Simuler une erreur intermédiaire puis vérifier l’absence de clôture partielle ou doublée. |
| Catalogue et prix | [Édition](../recovered-source/LOGICA/Form_2_ARTICLES.cs#L15945), [création groupée](../recovered-source/LOGICA/Form_2_ARTICLES.cs#L17629), familles, photos et import d’articles. | Lecteur MariaDB et services de création/validation existants. Écriture depuis WPF à relier et à vérifier pour chaque opération. | Créer, modifier, relire depuis la vente. Vérifier tarifs, variantes avec code-barres partagé, import et annulation d’une création groupée en erreur. |
| Inventaire, ajustements, sorties | [Inventaire](../recovered-source/LOGICA/Form_6_INVENTAIRES.cs#L9339), [sortie](../recovered-source/LOGICA/Form_6_SORTIES.cs#L8891), [mouvements](../recovered-source/LOGICA/Form_6_MOUVEMENTS_STOCK.cs). La validation d’inventaire met à jour le stock et les états du document dans une transaction. | Prévisualisation des écarts, couverture et fraîcheur disponibles. Refus de l’acteur non vérifié déjà testé. Écriture de l’acteur autorisé et audit complet à vérifier. | Inventaire complet et incomplet, article modifié entre comptage et validation, deux validations concurrentes, annulation et traçabilité du mouvement. |
| Achats, réceptions, fournisseurs | [Commandes](../recovered-source/LOGICA/Form_6_COMMANDES.cs#L9092), [réceptions](../recovered-source/LOGICA/Form_6_RECEPTIONS.cs#L10300), [règlements](../recovered-source/LOGICA/Form_6_FOURNISSEURS_REGLE.cs). La réception validée modifie le stock, le coût et l’état du document. | Services de [prévisualisation et rapprochement](../business/README.md) disponibles. Écriture transactionnelle et lien avec le compte fournisseur à tracer. | Commander, recevoir partiellement puis solder, rapprocher quantités, coût et compte fournisseur selon le type de document. Tester doublon et échec après une première ligne. |
| Clients, crédit, règlements | [Règlement](../recovered-source/LOGICA/Form_5_CLIENTS_REGLE.cs#L3458), [état des crédits](../recovered-source/LOGICA/Form_5_CLIENTS_ETAT_CREDITS.cs), [historique](../recovered-source/LOGICA/Form_5_CLIENTS_HISTORIQUE_CREDIT_INITIAL.cs). | Validation, recherche et mappage du règlement déjà extraits. Parcours WPF et règles d’imputation à relier et vérifier. | Vente à crédit, règlement partiel, solde restant, historique et rapprochement avec la clôture. |
| Vente, retour, tickets | [SOLDER et garde de soumission](../recovered-source/LOGICA/Form_3_VENTE.cs#L12891), [récapitulatif](../recovered-source/LOGICA/Form_3_VENTE.cs#L13188), [routage de l’impression](../recovered-source/LOGICA/Form_3_VENTE.cs#L11810). | [Run Windows/MariaDB](https://github.com/hmasprod-a11y/LOGICA-Recovery/actions/runs/43371131511) sur `aa836f0f58782f0a18fd256545647af2503d901c` : vente espèces à deux articles, édition du panier, retour espèces complet et persistance. | Recette utilisateur, ticket visible et impression sur périphérique réel. Tracer et vérifier retours partiels, paiements mixtes, remises, crédit, vente en attente et variantes de prix. |
| Documents, statistiques, exploitation | [Factures](../recovered-source/LOGICA/Form_90000_FACTURE.cs#L10125), [devis](../recovered-source/LOGICA/Form_900_DEVIS.cs), [BL](../recovered-source/LOGICA/Form_9000_BL.cs), [statistiques](../recovered-source/LOGICA/Form_9_STATISTIQUES.cs), [outil base](../recovered-source/LOGICA/FormDialog_8_BASE_DONNEE.cs). | Règles et sorties détaillées à tracer. Licences et outils de distribution existent séparément. Recette Windows hors ligne, migration, sauvegarde et restauration à prouver. | Comparer totaux, dates et sorties sur un jeu commun. Vérifier périphériques, licence locale, installation, restauration et retour arrière sur Windows propre. Traiter les données de récupération exposées avant tout essai avec des données réelles. |

## Caisse — état de validation

La recette [Windows et MariaDB](https://github.com/hmasprod-a11y/LOGICA-Recovery/actions/runs/43378748269) sur `9ad428cf70b46084b9d9369fe5effec276b847fc` a actionné les contrôles WPF de comptage, enregistré le fonds de caisse, authentifié le caissier, confirmé la clôture globale et affiché son rapport avec la commande d’impression. Les assertions MariaDB couvrent aussi l’isolation de la clôture par caissier, l’autorisation manager/admin, le rollback et le refus du rejeu. Le parcours est validé sur la base jetable. L’essai d’impression sur le matériel du magasin reste au programme de la recette matérielle.

Prochain parcours à livrer en entier : inventaire, du comptage à l’écriture de stock et à l’audit, à partir de [la validation LOGICA](../recovered-source/LOGICA/Form_6_INVENTAIRES.cs#L9339).

## Inventaire — démarrage

La [validation LOGICA](../recovered-source/LOGICA/Form_6_INVENTAIRES.cs#L9302) refuse un document déjà `VALIDER`, applique le stock physique et inscrit les mouvements et les états du document dans une transaction. [Les accès LOGICA](../recovered-source/LOGICA/Form_6_INVENTAIRES.cs#L8055) autorisent les catégories authentifiées ADMIN et MANAGER et désactivent la validation pour UTILISATEUR. Ce droit de valider un document est distinct de l’ajustement manuel.

Inventory possède l’écriture transactionnelle; WPF possède l’écran et le ViewModel; QA possède l’intégration et la recette sur #93. Architecture trace les règles et Checkout vérifie la coexistence avec la vente. Vérifier l’état de brouillon exact, le refus des inventaires incomplets, du stock périmé et des doublons, puis le rollback et l’audit sur une base jetable.

## Inventaire — recette de création et de validation

La [recette Windows/MariaDB](https://github.com/hmasprod-a11y/LOGICA-Recovery/actions/runs/43384733768) sur `33e89590bab4a5d64eee3f0fbe49ced0426ccec2` crée un document par l’interface WPF pour une liste d’articles, réserve `INV000001` avec le compteur LOGICA, saisit le stock physique, affiche l’écart et valide avec le PIN du manager. La base confirme la mise à jour du stock et l’état `VALIDER`. La recette couvre aussi l’ouverture d’un document existant, le refus du stock périmé, le rollback et le refus d’une double validation. La sélection initiale se fait actuellement par identifiants d’article; les autres variantes de l’écran LOGICA et la recette magasin restent à examiner.

## Achats — réception partielle depuis une commande

La [recette Windows/MariaDB](https://github.com/hmasprod-a11y/LOGICA-Recovery/actions/runs/43500365368) sur `c433b93146c4563db63a0ba1297c45df14adaa17` ouvre l’écran WPF, crée puis valide un premier bon de 2 unités à partir d’une ligne commandée de 5. Le stock reste inchangé à l’enregistrement et augmente à la validation. Un essai à 4 unités est refusé. Un second bon de 3 unités solde la quantité commandée. La transaction de validation applique la moyenne pondérée de LOGICA et écrit le mouvement. Le test couvre aussi le rollback et la validation en double.

La [recette Windows/MariaDB](https://github.com/hmasprod-a11y/LOGICA-Recovery/actions/runs/43531510980) sur `b79733f415eeb2efdab8d94b1722dae281d10d37` valide aussi depuis WPF la création d’une commande et d’un bon avec deux articles, l’affichage du solde fournisseur, les quantités réservées et le stock final. Le rapprochement suit le calcul LOGICA : crédit initial + réceptions + sorties signées − règlements. Les tests couvrent l’annulation d’un bon enregistré et la restitution de sa réservation sans mouvement de stock.

Statut : parcours achats livré en recette logicielle sur base jetable. Le lien commande-bon est une extension HANOUTY qui demande les migrations [liaison](../input/migrations/20261113-purchase-receipt-order.sql) puis [lignes multiples](../input/migrations/20261114-purchase-receipt-multiple-lines.sql) avant recette sur une copie protégée. La consultation du solde utilise les règlements présents. La saisie de règlements et la recette magasin restent à couvrir avec les parcours financiers.

Prochaine section : catalogue et prix, à partir de `Form_2_ARTICLES.cs`.

## Catalogue et prix — recette du parcours de base

La [recette Windows/MariaDB](https://github.com/hmasprod-a11y/LOGICA-Recovery/actions/runs/43541214050) sur `5b7123f1f87c039b0951fbae31875ab5824c1268` couvre la création de fiche de base et sa modification depuis WPF, la sélection d’une famille LOGICA, la modification du prix avec audit, puis la sélection explicite d’une variante par code-barres partagé. Le test d’import lit un vrai fichier .xlsx (`Feuil1`, `Code`, `Article`, `Famille`, `PRIX_A`, `PRIX_V`, `STOCK`), conserve les zéros des codes texte et prouve le rollback de l’ensemble des articles, mouvements et numéros à l’échec de la deuxième ligne.

La [recette WPF et MariaDB](https://github.com/hmasprod-a11y/LOGICA-Recovery/actions/runs/43542233968) sur `b4ced22b750e3ac9e329591b53483d6d01b2d805` a utilisé le bouton d’import et un vrai fichier Excel fourni au point de sélection, puis vérifié la grille d’aperçu, l’annulation sans écriture, la confirmation et le PIN avant l’enregistrement. Le dialogue Windows natif de sélection du fichier reste à vérifier manuellement. Les familles doivent déjà exister. Les champs avancés de la fiche LOGICA restent à couvrir. Les droits d’administration et le [schéma d’audit des prix](../input/migrations/20261114-catalogue-price-audit.sql) s’appliquent à la copie de recette.

## Ordre d’exécution

1. **Caisse** — partir du fond de caisse, du comptage et des variantes de clôture du code LOGICA. Extraire les sélections et règles de rapprochement qui déterminent le contenu d’une clôture. Réutiliser le service de comptage, puis raccorder les écritures et le parcours WPF. Vérifier clôture et rollback sur la même version.
2. **Inventaire et réceptions** — tracer les deux transactions et les droits depuis les écrans LOGICA. Réutiliser les services de contrôle existants. Prouver l’écriture réelle et la résistance au doublon pour chaque opération. Ces travaux peuvent avancer en parallèle de la caisse.
3. **Catalogue, crédit, règlements et documents** — combler les écarts de chaque parcours à partir de ses appels LOGICA. Valider les écritures puis le passage vers caisse, stock ou rapports.
4. **Recette intégrée** — une version Windows issue de QA, un jeu de données fictives, un parcours complet. Pour chaque preuve, inscrire SHA, jeu de données, résultat attendu et observé, lien du test et propriétaire du prochain écart. Vérifier impression et restauration sur matériel représentatif avant livraison.

Ce registre est un point de départ vérifié dans le code, avec les limites indiquées dans chaque ligne. Compléter les variantes encore à tracer au fur et à mesure de leur mise en œuvre. Référencer les résultats nouveaux ici pour éviter la dispersion entre rapports et branches.


## Règlements clients et fournisseurs — 19 novembre 2026

Les parcours ont été raccordés par le superviseur et intégrés, sans écriture sur une base magasin.
- Client : PR #123, source `ecf72367d643fc06d8f8006ab6e16f32f3c6e01f`, [Windows/WPF/MariaDB et lancement/restauration](https://github.com/hmasprod-a11y/LOGICA-Recovery/actions/runs/44396971031) réussis. Le bouton réel, la sélection, le pavé et le PIN enregistrent 30 puis 50 ; reliquat 80 → 50 → 0 ; caisse +80. Refus PIN/identité/mode/précision, rollback et reprise sans doublon avant/après clôture couverts. La période inclut désormais tout le dernier jour, même pour les règlements horodatés.
- Fournisseur : PR #126, source `3ae8c77f56ec927c301bd16eb148a9b1a548139c`, [même recette intégrée et restauration](https://github.com/hmasprod-a11y/LOGICA-Recovery/actions/runs/44416513717) réussies. Calcul existant LOGICA : crédit initial + réceptions enregistrées + sorties signées − règlements. Parcours WPF/PIN 30 puis50 ; solde80 →50 →0 ; caisse−80. Refus/rollback/reprise/clôture couverts. Une vente persistée synthétique ouvre la portée de clôture de ce scénario.
- Migrations explicites : `20261118-client-settlement-operations.sql` et `20261118-supplier-settlement-operations.sql`. Elles ne sont pas appliquées automatiquement au magasin.
- Limites : ces preuves portent sur les versements positifs à la date courante, pas sur toute la gestion historique/modification/suppression LOGICA. La reprise commerciale d'une issue inconnue après fermeture de la fenêtre et le matériel restent à valider. La création AVOIR fournisseur reste ouverte.

## Checkout et tickets — intégration du 19 novembre 2026

PR #125 intègre les protections de #119 sur la base courante, après correction personnelle de deux blocages : conserver une prévisualisation vide pour ouvrir la session avant le premier scan, et masquer les entêtes originaux ambigus tout en refusant leur remboursement. [Checkout/MariaDB](https://github.com/hmasprod-a11y/LOGICA-Recovery/actions/runs/44415110236) et [WPF/vente/retour/règlements/paquet/restauration](https://github.com/hmasprod-a11y/LOGICA-Recovery/actions/runs/44415110446) réussis sur `0c7588d7edea95d5054dcb1995086f989de2931e`. #119 est fermé comme remplacé, son code n'est pas perdu. Carte, mixte, remises autorisées et retours partiels restent ouverts.

PR #124 restaure le nombre d'unités (quantités fractionnaires comprises) et les économies calculées du brut et du net persistés sur FR_3C. Le dessin de production est partagé avec la prévisualisation. Le superviseur ajoute la recette de rendu à W2 afin qu'elle soit exécutée en CI et archivée. Les preuves utilisent des données synthétiques ; aucun essai d'imprimante physique n'est revendiqué. QR, autres modèles, liaisons série et papier long restent ouverts.


## Encaissement quotidien et retour — 19 novembre 2026

Les jalons suivants remplacent les anciennes mentions « carte/mixte ouverts » pour les seuls parcours explicitement prouvés :
- #128 : CARTE unique au montant exact, activation `FENETRE_MODE_P` et mode canonique `CARTE`, validation transactionnelle, PIN, rollback et exclusion de la caisse physique. [W2 réussi](https://github.com/hmasprod-a11y/LOGICA-Recovery/actions/runs/44425782594), source `07bec5b53bc79aec0896c38a6e101c8d37b8b83e`.
- #129 : espèces + CARTE et rendu signé, pavé et billets LOGICA, reçu et clôture au net espèces. [W2 réussi](https://github.com/hmasprod-a11y/LOGICA-Recovery/actions/runs/44428529581), source `09fb3bb9c019c2339a390a197b878e7c81c234ec`. Aucun terminal bancaire n'est commandé : la carte est confirmée comme payée extérieurement.
- #130 : un seul login, espèces → carte → espèces, PIN neuf pour chaque écriture, comptage tactile entier, confirmation de clôture et rapport persisté. [W2 réussi](https://github.com/hmasprod-a11y/LOGICA-Recovery/actions/runs/44432433421), source `d21d8c345e7ae145646ed22090775c9622ff1957`.
- #131 : la recherche utilisateur accepte le numéro imprimé du ticket, puis conserve l'identité persistée canonique pour le contrôle intégral et le remboursement. Le contexte de paiement consommé n'empêche plus le retour dans la session. La recette `VerifyInteractiveReturnCycle` provoque une perte d'accusé après le véritable commit SQL et vérifie réconciliation, mauvais/bon PIN, absence de doublon puis client suivant.
- Suite : le total affiché utilise l'identité de session encore active, indépendamment de l'autorisation monétaire consommée. L'évidence d'un original espèces accepte un reçu positif unique et au plus un rendu négatif, tous en centimes et de somme exactement égale au net original. Un retour rembourse ce net, jamais le montant brut reçu. Les règles de lignes complètes, prix persistés, absence de remise, verrou et consommation unique restent appliquées. Les tests MariaDB refusent rendu incohérent, fraction de centime, carte et mouvements surnuméraires même de somme correcte.

Retours partiels, remboursements carte/mixte, remises autorisées, ventes à crédit, autres documents et recette matérielle restent des écarts distincts. Une CI verte sur ces scénarios ne vaut pas recette commerciale complète.


## Catalogue : recherche et prix au toucher — 19 novembre 2026

Le parcours de gestion reprend la recherche exacte ou partielle de `Form_2_ARTICLES.Picture_FIND_Click` : nom ou code-barres, résultats visibles et sélection explicite d'une variante. L'identifiant interne reste une clé cachée et non éditable. Toute modification du texte ou du mode de recherche révoque le résultat sélectionné et désactive son prix. La recherche est paramétrée ; les caractères % et _ restent littéraux. Les identités ambiguës sont exclues, et au-delà de 50 résultats l'utilisateur doit préciser la recherche.

Les prix de création et de modification utilisent le pavé numérique existant, zéro et annulation compris. Le service conserve le PIN administrateur, la comparaison du prix relu sous transaction et l'audit atomique. La recette WPF/MariaDB exécute création tactile, recherche d'un code avec apostrophe, sélection, annulation/application du pavé et écriture par PIN ; elle vérifie aussi variantes partagées sans présélection, révocation après édition de recherche, refus des droits insuffisants, rollback d'audit et prix effectivement repris par la vente.

La preuve de cette livraison et son SHA sont consignés dans PR #133 et le tableau #94. La capture `catalogue-search-touch-price.png` documente le parcours automatisé. Cette tranche ne clôt pas les champs avancés, suppressions/historique, promotions, autres tarifs ou la recette magasin du catalogue LOGICA complet.


## Démarrage de la recette sans téléchargement à l'ouverture

L'archive MariaDB officielle déjà vérifiée par W2 et son fichier de sommes SHA-256 sont livrés avec le paquet d'essai. Le lanceur exige ces deux fichiers locaux et vérifie l'archive avant de lancer un serveur. Il n'effectue plus de requête réseau, même si un ancien cache existe. La CI vérifie un profil réellement neuf, sans archive préchargée dans son cache, avec les commandes HTTP bloquées et le port 3307 occupé ; elle doit aussi refuser une somme altérée avant démarrage. Les diagnostics d'échec sont conservés dans le dossier de preuve. La préparation CI peut télécharger le composant officiel avec tentatives bornées et contrôle de longueur puis SHA-256 ; cela ne devient pas une dépendance réseau du poste d'essai.


## Tarifs quantité, promotion catalogue et remboursement du net

Le parcours financier réutilise `SalesLinePricing.SelectQuantityPrice`, `CalculateNetAmount` et `VisualBasicCheckoutSemantics` existants : prix standard sous le seuil, prix quantité à partir du seuil, puis pourcentage PROMOTION et arrondi monétaire de la ligne. Le panier affiche prix retenu, remise et net issus de la lecture SQL autorisée. L'écriture recalcule la même politique sous transaction ; aucun prix ni taux libre n'est déduit du texte WPF.

L'attente conserve le prix, la remise et le net. Sa lecture et son enregistrement utilisent un même verrou transactionnel sur les articles ; une modification des conditions doit refuser la reprise ou le paiement. Le remboursement cash complet utilise le journal original, y compris ses remises et lignes offertes, sans recalculer les prix catalogue actuels. Entête et règlement originaux doivent toujours prouver un montant net positif, et la consommation unique reste obligatoire.

La recette dédiée `w2-logica-pricing.json` couvre seuils 1/2/3/4, cultures fr/en, arrondi, politique invalide, attente, modification concurrente, vente WPF cash et CARTE, mixte SQL et rendu, reçu, remboursement après changement catalogue, ligne à net zéro, doublon et rapprochement stock/caisse. La CI exige cette preuve exécutée. Cela ne donne pas accès à la remise manuelle, aux tarifs client ni à une nouvelle politique de remboursement carte/mixte ; ces variantes restent à raccorder depuis LOGICA.

## Remises manuelles autorisées et panier visible — 19 novembre 2026

Références : `Form_3_VENTE.CREATION_ACCES`, `Button_REMISE_Click`, `FormDialog_REMISE`, `FormDialog_PASS_MANAGER` et `FormDialog_PASS_ADMIN`. L'accès vient de `TABLE_PASS.REMISE` : VISIBLE, INVISIBLE, ACCES MANAGER ou ACCES ADMIN. Le PIN est demandé avant la boîte de remise pour le rôle exact ; un administrateur ne remplace pas le MANAGER dans le parcours original. Le paiement demande toujours séparément le PIN du caissier. Les secrets ne figurent ni dans l'autorisation retournée ni dans le panier WPF.

Le dialogue reprend ticket entier/article sélectionné, pourcentage/DH et remise globale à zéro. Le taux remplace la promotion des lignes concernées. En DH, l'article utilise d'abord le brut arrondi à deux décimales et la conversion VB d'origine ; le ticket entier divise par le net courant avant de remplacer les taux. Le net et le taux réellement retenus sont affichés avant confirmation. Le pourcentage brut supérieur à 100 est refusé avant arrondi. Le ticket doit garder un net strictement positif dans le périmètre financier actuellement accepté.

Les autorisations sont immuables, liées à la base, au poste, au caissier et à une seule opération. Les droits et le rôle de l'approbateur sont relus sous transaction avant écriture. Une modification de prix après la prévisualisation impose une nouvelle confirmation. L'attente conserve ses conditions sans nouvelle colonne ; sa reprise réautorise les taux manuels avec les droits actuels et refuse une modification durant la demande de PIN. Le paiement consomme l'attente atomiquement. Le remboursement cash complet reprend les prix/remises/net originaux, et la remise ne passe jamais au client suivant.

La grille du panier dispose désormais de sa propre zone défilante au-dessus d'un panneau de paiement fixe. Les quantités et la suppression agissent sur leur ligne, sans dépendre d'une ancienne sélection. Le total, les trois modes et ENCAISSER restent visibles ; la zone de rapprochement apparaît lorsqu'un résultat est incertain. Un test STA mesure le panier, le total et le bouton dans les fenêtres 760×480 et 1280×760. La monnaie affichée après vente provient du ticket enregistré.

La recette complète WPF/MariaDB produit `w2-manual-discounts.json` et `manual-discount-cashier-basket.png`. La CI exige chaque assertion dédiée : calculs fr/en, arrondi brut, rôles exacts/révocation, isolation de base, prix modifié après revue, attente réautorisée, rollback, doublon et opération étrangère, reçu/rendu, remboursement original, pavé tactile, PIN manager et absence de remise au client suivant. La preuve de livraison doit identifier le SHA et le run ; les ventes à crédit, tarifs client et retours partiels/carte restent distincts.

L'empreinte de prévisualisation couvre les prix effectifs de toutes les lignes : deux prix qui changent en sens inverse ne peuvent pas contourner la revue en conservant le même total. Le test STA impose une deuxième confirmation dans cette situation. Les vingt assertions dédiées incluent aussi la vente remisée CARTE depuis le vrai dialogue WPF avec un nouveau PIN caissier et la ventilation mixte cash/CARTE/rendu relue en SQL.

## Vente à crédit — client, dette, règlement et caisse

Références : `Form_5_CLIENTS_LISTE.Button15_Click`, `Text_FIND`, `Form_3_VENTE.Button_ClickCore` appelé par `Button_SOLDER_CREDIT`, `CheckoutPaymentReadService` et `ReceiptPrintRouting`. Le commutateur local d'origine est `gestion_credit.sni`. Sans valeur LOGICA valide et activée, la nouvelle vente à crédit est refusée, même par un appel direct à l'adaptateur. Le lanceur de test active ce fichier uniquement dans son extraction jetable vérifiée ; aucun réglage d'un magasin n'est modifié.

Le parcours choisit un client existant par nom, téléphone ou code puis demande une confirmation explicite du nom et du net. L'identité interne n'est pas saisie. Éditer la recherche révoque le résultat précédent. Le même panier, les prix quantité/promotions et les remises autorisées passent par le même `CheckoutSession` et le même journal durable. Le PIN caissier est demandé à nouveau pour poster. Identité/code/nom du client sont comparés aux données relues et verrouillées dans cette transaction ; le texte WPF ne devient jamais une identité financière autonome.

L'opération CREDIT écrit l'entête et les lignes nominatifs ainsi que le mouvement de stock, sans aucune ligne de paiement. La dette provient de ces lignes dans le lecteur de relevé existant. Le cash et les totaux de ventes payées restent inchangés jusqu'à un règlement client. Les règlements partiel puis complet réutilisent le service livré en #123 et son audit d'idempotence. Le reçu porte le marqueur CREDIT et le client ; la route FR_3C originale demande deux exemplaires. Les retours de crédit et les ventes payées nominatives ne sont pas activés implicitement par cette tranche.

La preuve `w2-credit-sales.json` exige la sélection/recherche, la deuxième confirmation, le PIN, l'absence d'encaissement, les dettes/stock/reçu, le doublon, le client suivant anonyme, la désactivation/changement de client pendant le PIN, un rollback injecté après entête, la perte d'accusé suivie d'une revue sans nouvelle dette, les règlements partiel/complet et la clôture. Scénario : crédits21.60+9, règlements5+25.60, vente payée9 ; dette finale0, cash+39.60 et stock20→15. La capture `credit-customer-confirmation.png` documente le vrai dialogue WPF. Cela ne vaut pas une recette matérielle d'imprimante.

Les règlements5 et25.60 sont exécutés depuis le relevé réel puis le dialogue tactile existant, avec un nouveau PIN à chaque règlement. Un crédit supplémentaire avec remise manuelle20% est enregistré à19.20 puis soldé par CARTE : aucune entrée cash, aucune deuxième sortie de stock lors du règlement, stock final12. Le reçu CREDIT issu de la vraie base est aussi rendu dans `credit-original-receipt.png`. Les seize assertions dédiées sont exigées par la CI.

## Fichiers clients, crédit initial et historique — 20 novembre 2026

Le menu de caisse ouvre le répertoire clients : recherche littérale nom/téléphone/code, création CL selon TABLE_NUM.CLIENT, informations complètes et vendeur existant, modification des informations, crédit initial séparé au pavé signé à quatre décimales, historique original en lecture seule. TABLE_PASS.CLIENTS conserve ses droits et son rôle exact. Chaque écriture redemande le PIN et compare le fichier relu au fichier revu.

Les écritures et leur journal durable sont atomiques. Une perte d’accusé conserve la même demande au redémarrage ; un mauvais PIN de reprise ne l’efface pas. Le client réellement créé est sélectionné dans la vente CREDIT existante puis retrouvé avec son crédit initial exact dans le relevé. La recette WPF/MariaDB exige 17 assertions, dont rollback historique/journal, droits révoqués, doublons, reprise et absence d’effets caisse/stock de l’administration. Le lanceur compare aussi les métadonnées, l’historique et le journal complet après sauvegarde/restauration.

Référence et limites : `docs/qa/HANOUTY_CUSTOMER_FILES_ACCEPTANCE_2026-11-20.md`. Suppression client, réécriture d’identité et autres documents/historiques/export restent ouverts ; le numéro généré est volontairement immuable pour préserver les références financières. Migration additive explicite, jamais appliquée automatiquement au magasin.
