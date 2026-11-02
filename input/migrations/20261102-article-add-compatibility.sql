-- Hanouty / LOGICA: additive compatibility migration for the recovered TABLE_ARTICLES schema.
-- Back up the shop database before running. MariaDB supports IF NOT EXISTS.
-- Never drop or overwrite existing article data.
ALTER TABLE `TABLE_ARTICLES`
  ADD COLUMN IF NOT EXISTS `GROUPE` varchar(255) DEFAULT '',
  ADD COLUMN IF NOT EXISTS `PRIX_QTE` double DEFAULT 0,
  ADD COLUMN IF NOT EXISTS `PRIX_QTE_MIN` double DEFAULT 0,
  ADD COLUMN IF NOT EXISTS `Taille` varchar(255) DEFAULT '',
  ADD COLUMN IF NOT EXISTS `Couleur` varchar(255) DEFAULT '',
  ADD COLUMN IF NOT EXISTS `Emplacement` varchar(255) DEFAULT '';
