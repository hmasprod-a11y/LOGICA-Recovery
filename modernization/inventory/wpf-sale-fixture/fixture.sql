-- HANOUTY fictitious sale fixture. ONLY a newly created, disposable local DB.
-- Select database hanouty_wpf_fixture explicitly before running this script.
-- Refuse to overwrite any existing TABLE_ARTICLES.
DELIMITER //
CREATE PROCEDURE hanouty_install_wpf_fixture()
BEGIN
  IF DATABASE() <> 'hanouty_wpf_fixture' THEN
    SIGNAL SQLSTATE '45000' SET MESSAGE_TEXT = 'Wrong database: disposable hanouty_wpf_fixture required';
  END IF;
  IF EXISTS (SELECT 1 FROM information_schema.TABLES
             WHERE TABLE_SCHEMA = DATABASE() AND TABLE_NAME = 'TABLE_ARTICLES') THEN
    SIGNAL SQLSTATE '45000' SET MESSAGE_TEXT = 'Existing TABLE_ARTICLES: refusing overwrite';
  END IF;
  CREATE TABLE TABLE_ARTICLES (
    ID_ARTICLE VARCHAR(128) NOT NULL PRIMARY KEY,
    Code VARCHAR(128) NULL,
    Article VARCHAR(255) NOT NULL,
    Images VARCHAR(255) NULL,
    STOCK DECIMAL(18,3) NOT NULL,
    PRIX_V_1 DECIMAL(18,3) NOT NULL,
    Prix_A DECIMAL(18,3) NOT NULL
  ) ENGINE=InnoDB;
  INSERT INTO TABLE_ARTICLES (ID_ARTICLE, Code, Article, Images, STOCK, PRIX_V_1, Prix_A) VALUES
    ('DEMO-SOAP','6900000000011','Fictitious soap','fixture-soap.png',12,18.50,11.25),
    ('DEMO-RED','6900000000028','Fictitious T-shirt red',NULL,5,45.00,25.00),
    ('DEMO-BLUE','6900000000028','Fictitious T-shirt blue',NULL,7,45.00,25.00),
    ('DEMO-OOS','6900000000035','Fictitious unavailable item',NULL,0,9.99,5.00),
    ('DEMO-QUOTED','6900000000042','Fictitious baker''s item',NULL,3,6.50,3.25);
END//
DELIMITER ;
CALL hanouty_install_wpf_fixture();
DROP PROCEDURE hanouty_install_wpf_fixture;
