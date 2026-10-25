LOGICA - RECUPERATION DES FICHIERS ORIGINAUX ET DE LA BASE

DEMARRAGE
1. Fermer les anciennes fenetres LOGICA. Extraire le dossier Debug complet dans un nouveau dossier local accessible en ecriture.
2. Double-cliquer sur Start-LOGICA.cmd. Garder tous les fichiers ensemble.
3. Au premier lancement, une connexion Internet est necessaire pour telecharger MariaDB 10.11.14 depuis son archive officielle (environ 91 Mo). Son empreinte SHA256 est verifiee avant extraction.
4. Le lanceur cree un serveur local sur 127.0.0.1:3308 et importe la copie de recuperation une seule fois, puis ouvre LOGICA. Il arrete proprement le serveur quand LOGICA se ferme.

DONNEES CONSERVEES
La base Access originale est bd/config/configue.sni. Malgre son extension .sni, elle contient les tables et des donnees du logiciel. Ce fichier est conserve sans modification.
La copie SQL est recovery/recovered-original.sql ; mysql-compatibility.sql ajoute des colonnes de compatibilite, sans supprimer les anciennes.
Le fichier original contient notamment 120 produits, 15 familles et 11 tickets (54 lignes de vente). La date du fichier dans le ZIP est le 29 janvier 2024 : cette copie ne garantit pas les derniers mouvements du magasin.
Les autres fichiers originaux du ZIP sont conserves. L'EXE corrige et ses bibliotheques resolues remplacent les anciennes versions dans cette nouvelle copie uniquement.

APRES LE PREMIER LANCEMENT
La base locale modifiable se trouve dans bd/mysql-data. Ne pas supprimer ce dossier ou les identifiants bd/mysql-credential.xml : ils servent aux prochains lancements et sont lies au compte Windows.
Le lanceur refuse de remplacer une base deja existante sans marqueur d'importation. Il ne touche pas aux bases MySQL existantes sur le port 3306.
Le programme necessite .NET Framework 4.8. Les parametres d'imprimantes et les mecanismes d'activation du logiciel d'origine sont conserves.

SAUVEGARDE
Conserver Debug(1).zip intact et sauvegarder regulierement la nouvelle base locale. Ne pas remplacer une installation en service sans en sauvegarder la base et les parametres.
