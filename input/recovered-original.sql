SET NAMES utf8mb4;
SET SESSION sql_mode='NO_AUTO_VALUE_ON_ZERO';
-- ----------------------------------------------------------
-- MDB Tools - A library for reading MS Access database files
-- Copyright (C) 2000-2011 Brian Bruns and others.
-- Files in libmdb are licensed under LGPL and the utilities under
-- the GPL, see COPYING.LIB and COPYING files respectively.
-- Check out http://mdbtools.sourceforge.net
-- ----------------------------------------------------------

-- That file uses encoding UTF-8

CREATE TABLE `DIRECTE_01`
 (
	`ID`			int NOT NULL AUTO_INCREMENT UNIQUE, 
	`Ticket`			varchar (255), 
	`Dates`			datetime, 
	`Heure`			varchar (255), 
	`ID_ARTICLE`			varchar (255), 
	`Code`			varchar (255), 
	`Article`			varchar (255), 
	`Famille`			varchar (255), 
	`PRIX_A`			double, 
	`PRIX_MP`			double, 
	`PRIX_V`			double, 
	`Qté`			double, 
	`Remise`			double, 
	`TOTAL_NET`			double, 
	`Caissier`			varchar (255), 
	`Vendeur`			varchar (255), 
	`TAUX_TVA`			double, 
	`PRINTER`			varchar (255), 
	`PRINTER_DUPLICATA`			varchar (255), 
	`cuisine`			varchar (255)
);

-- CREATE INDEXES ...
ALTER TABLE `DIRECTE_01` ADD INDEX `Code` (`Code`);
ALTER TABLE `DIRECTE_01` ADD PRIMARY KEY (`ID`);



INSERT INTO `DIRECTE_01` (`ID`, `Ticket`, `Dates`, `Heure`, `ID_ARTICLE`, `Code`, `Article`, `Famille`, `PRIX_A`, `PRIX_MP`, `PRIX_V`, `Qté`, `Remise`, `TOTAL_NET`, `Caissier`, `Vendeur`, `TAUX_TVA`, `PRINTER`, `PRINTER_DUPLICATA`, `cuisine`) VALUES (1,NULL,"2024-01-29 00:00:00","00:14:11","ART48","70268","CROISSANT","VIENNOISERIE",0.0000,0.0000,10.0000,1,0,10.0000,NULL,NULL,0,"C1","0",NULL);

-- ----------------------------------------------------------
-- MDB Tools - A library for reading MS Access database files
-- Copyright (C) 2000-2011 Brian Bruns and others.
-- Files in libmdb are licensed under LGPL and the utilities under
-- the GPL, see COPYING.LIB and COPYING files respectively.
-- Check out http://mdbtools.sourceforge.net
-- ----------------------------------------------------------

-- That file uses encoding UTF-8

CREATE TABLE `DIRECTE_02`
 (
	`ID`			int NOT NULL AUTO_INCREMENT UNIQUE, 
	`Ticket`			varchar (255), 
	`Dates`			datetime, 
	`Heure`			varchar (255), 
	`ID_ARTICLE`			varchar (255), 
	`Code`			varchar (255), 
	`Article`			varchar (255), 
	`Famille`			varchar (255), 
	`PRIX_A`			double, 
	`PRIX_MP`			double, 
	`PRIX_V`			double, 
	`Qté`			double, 
	`Remise`			double, 
	`TOTAL_NET`			double, 
	`Caissier`			varchar (255), 
	`Vendeur`			varchar (255), 
	`TAUX_TVA`			double, 
	`PRINTER`			varchar (255), 
	`PRINTER_DUPLICATA`			varchar (255), 
	`cuisine`			varchar (255)
);

-- CREATE INDEXES ...
ALTER TABLE `DIRECTE_02` ADD INDEX `Code` (`Code`);
ALTER TABLE `DIRECTE_02` ADD PRIMARY KEY (`ID`);




-- ----------------------------------------------------------
-- MDB Tools - A library for reading MS Access database files
-- Copyright (C) 2000-2011 Brian Bruns and others.
-- Files in libmdb are licensed under LGPL and the utilities under
-- the GPL, see COPYING.LIB and COPYING files respectively.
-- Check out http://mdbtools.sourceforge.net
-- ----------------------------------------------------------

-- That file uses encoding UTF-8

CREATE TABLE `DIRECTE_04`
 (
	`ID`			int NOT NULL AUTO_INCREMENT UNIQUE, 
	`Ticket`			varchar (255), 
	`Dates`			datetime, 
	`Heure`			varchar (255), 
	`ID_ARTICLE`			varchar (255), 
	`Code`			varchar (255), 
	`Article`			varchar (255), 
	`Famille`			varchar (255), 
	`PRIX_A`			double, 
	`PRIX_MP`			double, 
	`PRIX_V`			double, 
	`Qté`			double, 
	`Remise`			double, 
	`TOTAL_NET`			double, 
	`Caissier`			varchar (255), 
	`Vendeur`			varchar (255), 
	`TAUX_TVA`			double, 
	`PRINTER`			varchar (255), 
	`PRINTER_DUPLICATA`			varchar (255), 
	`cuisine`			varchar (255)
);

-- CREATE INDEXES ...
ALTER TABLE `DIRECTE_04` ADD INDEX `Code` (`Code`);
ALTER TABLE `DIRECTE_04` ADD PRIMARY KEY (`ID`);




-- ----------------------------------------------------------
-- MDB Tools - A library for reading MS Access database files
-- Copyright (C) 2000-2011 Brian Bruns and others.
-- Files in libmdb are licensed under LGPL and the utilities under
-- the GPL, see COPYING.LIB and COPYING files respectively.
-- Check out http://mdbtools.sourceforge.net
-- ----------------------------------------------------------

-- That file uses encoding UTF-8

CREATE TABLE `DIRECTE_ATTENTE`
 (
	`ID`			int not null auto_increment unique, 
	`Ticket`			varchar (255), 
	`Dates`			datetime, 
	`Heure`			varchar (255), 
	`ID_ARTICLE`			varchar (255), 
	`Code`			varchar (255) NOT NULL, 
	`Article`			varchar (255), 
	`Famille`			varchar (255), 
	`PRIX_A`			double, 
	`PRIX_MP`			double, 
	`PRIX_V`			double, 
	`Qté`			double, 
	`Remise`			double, 
	`TOTAL_NET`			double, 
	`Caissier`			varchar (255), 
	`Vendeur`			varchar (255), 
	`TAUX_TVA`			double, 
	`PRINTER`			varchar (255), 
	`PRINTER_DUPLICATA`			varchar (255), 
	`cuisine`			varchar (255), 
	`V`			varchar (255), 
	`POSTE`			varchar (255), 
	`ID_CLIENT`			varchar (255), 
	`CODE_CLIENT`			varchar (255), 
	`CLIENT`			varchar (255)
);

-- CREATE INDEXES ...
ALTER TABLE `DIRECTE_ATTENTE` ADD INDEX `CODE_CLIENT` (`CODE_CLIENT`);

ALTER TABLE `DIRECTE_ATTENTE` ADD PRIMARY KEY (`ID`);



INSERT INTO `DIRECTE_ATTENTE` (`ID`, `Ticket`, `Dates`, `Heure`, `ID_ARTICLE`, `Code`, `Article`, `Famille`, `PRIX_A`, `PRIX_MP`, `PRIX_V`, `Qté`, `Remise`, `TOTAL_NET`, `Caissier`, `Vendeur`, `TAUX_TVA`, `PRINTER`, `PRINTER_DUPLICATA`, `cuisine`, `V`, `POSTE`, `ID_CLIENT`, `CODE_CLIENT`, `CLIENT`) VALUES (16,NULL,"2023-12-31 00:00:00","10:41:20","ART110","70330","PIZZA P THON","PIZZA",0.0000,0.0000,10.0000,1,0,10.0000,"LE PATRON",NULL,0,"C1","0",NULL,"1041223088011","1",NULL,NULL,NULL), (17,NULL,"2023-12-31 00:00:00","10:41:20","ART109","70329","PIZZA P VEGE","PIZZA",0.0000,0.0000,10.0000,1,0,10.0000,"LE PATRON",NULL,0,"C1","0",NULL,"1041223088011","1",NULL,NULL,NULL), (18,NULL,"2023-12-31 00:00:00","10:41:34","ART90","70310","TIRAMISU","DESSERT",0.0000,0.0000,10.0000,1,0,10.0000,"LE PATRON",NULL,0,"C1","0",NULL,"1041362774667","1",NULL,NULL,NULL), (19,NULL,"2023-12-31 00:00:00","10:41:34","ART89","70309","NOUGAT GLACE","DESSERT",0.0000,0.0000,10.0000,1,0,10.0000,"LE PATRON",NULL,0,"C1","0",NULL,"1041362774667","1",NULL,NULL,NULL), (20,NULL,"2023-12-31 00:00:00","10:41:37","ART29","70249","JUS POMME","JUS",0.0000,0.0000,44.0000,1,0,44.0000,"LE PATRON",NULL,0,"C1","0",NULL,"1041396791397","1",NULL,NULL,NULL), (21,NULL,"2023-12-31 00:00:00","10:41:37","ART28","70248","JUS CITRON","JUS",0.0000,0.0000,10.0000,1,0,10.0000,"LE PATRON",NULL,0,"C2","0",NULL,"1041396791397","1",NULL,NULL,NULL);

-- ----------------------------------------------------------
-- MDB Tools - A library for reading MS Access database files
-- Copyright (C) 2000-2011 Brian Bruns and others.
-- Files in libmdb are licensed under LGPL and the utilities under
-- the GPL, see COPYING.LIB and COPYING files respectively.
-- Check out http://mdbtools.sourceforge.net
-- ----------------------------------------------------------

-- That file uses encoding UTF-8

CREATE TABLE `EMPORTER`
 (
	`ID`			int NOT NULL AUTO_INCREMENT UNIQUE, 
	`Ticket`			varchar (255), 
	`Dates`			datetime, 
	`Heure`			varchar (255), 
	`ID_ARTICLE`			varchar (255), 
	`Code`			varchar (255), 
	`Article`			varchar (255), 
	`Famille`			varchar (255), 
	`PRIX_A`			double, 
	`PRIX_MP`			double, 
	`PRIX_V`			double, 
	`Qté`			double, 
	`Remise`			double, 
	`TOTAL_NET`			double, 
	`Caissier`			varchar (255), 
	`Vendeur`			varchar (255), 
	`TAUX_TVA`			double, 
	`PRINTER`			varchar (255), 
	`PRINTER_DUPLICATA`			varchar (255), 
	`cuisine`			varchar (255), 
	`V`			varchar (255)
);

-- CREATE INDEXES ...
ALTER TABLE `EMPORTER` ADD INDEX `Code` (`Code`);
ALTER TABLE `EMPORTER` ADD PRIMARY KEY (`ID`);




-- ----------------------------------------------------------
-- MDB Tools - A library for reading MS Access database files
-- Copyright (C) 2000-2011 Brian Bruns and others.
-- Files in libmdb are licensed under LGPL and the utilities under
-- the GPL, see COPYING.LIB and COPYING files respectively.
-- Check out http://mdbtools.sourceforge.net
-- ----------------------------------------------------------

-- That file uses encoding UTF-8

CREATE TABLE `LIVRAISON`
 (
	`ID`			int NOT NULL AUTO_INCREMENT UNIQUE, 
	`Ticket`			varchar (255), 
	`Dates`			datetime, 
	`Heure`			varchar (255), 
	`ID_ARTICLE`			varchar (255), 
	`Code`			varchar (255), 
	`Article`			varchar (255), 
	`Famille`			varchar (255), 
	`PRIX_A`			double, 
	`PRIX_MP`			double, 
	`PRIX_V`			double, 
	`Qté`			double, 
	`Remise`			double, 
	`TOTAL_NET`			double, 
	`Caissier`			varchar (255), 
	`Vendeur`			varchar (255), 
	`TAUX_TVA`			double, 
	`PRINTER`			varchar (255), 
	`PRINTER_DUPLICATA`			varchar (255), 
	`cuisine`			varchar (255), 
	`V`			varchar (255), 
	`CLIENT`			varchar (255)
);

-- CREATE INDEXES ...
ALTER TABLE `LIVRAISON` ADD INDEX `Code` (`Code`);
ALTER TABLE `LIVRAISON` ADD PRIMARY KEY (`ID`);




-- ----------------------------------------------------------
-- MDB Tools - A library for reading MS Access database files
-- Copyright (C) 2000-2011 Brian Bruns and others.
-- Files in libmdb are licensed under LGPL and the utilities under
-- the GPL, see COPYING.LIB and COPYING files respectively.
-- Check out http://mdbtools.sourceforge.net
-- ----------------------------------------------------------

-- That file uses encoding UTF-8

CREATE TABLE `TABLE_02`
 (
	`ID`			int NOT NULL AUTO_INCREMENT UNIQUE, 
	`Ticket`			varchar (255), 
	`Dates`			datetime, 
	`Heure`			varchar (255), 
	`ID_ARTICLE`			varchar (255), 
	`Code`			varchar (255), 
	`Article`			varchar (255), 
	`Famille`			varchar (255), 
	`PRIX_A`			double, 
	`PRIX_MP`			double, 
	`PRIX_V`			double, 
	`Qté`			double, 
	`Remise`			double, 
	`TOTAL_NET`			double, 
	`Caissier`			varchar (255), 
	`Vendeur`			varchar (255), 
	`TAUX_TVA`			double, 
	`PRINTER`			varchar (255), 
	`PRINTER_DUPLICATA`			varchar (255), 
	`cuisine`			varchar (255)
);

-- CREATE INDEXES ...
ALTER TABLE `TABLE_02` ADD INDEX `Code` (`Code`);
ALTER TABLE `TABLE_02` ADD PRIMARY KEY (`ID`);




-- ----------------------------------------------------------
-- MDB Tools - A library for reading MS Access database files
-- Copyright (C) 2000-2011 Brian Bruns and others.
-- Files in libmdb are licensed under LGPL and the utilities under
-- the GPL, see COPYING.LIB and COPYING files respectively.
-- Check out http://mdbtools.sourceforge.net
-- ----------------------------------------------------------

-- That file uses encoding UTF-8

CREATE TABLE `TABLE_03`
 (
	`ID`			int NOT NULL AUTO_INCREMENT UNIQUE, 
	`Ticket`			varchar (255), 
	`Dates`			datetime, 
	`Heure`			varchar (255), 
	`ID_ARTICLE`			varchar (255), 
	`Code`			varchar (255), 
	`Article`			varchar (255), 
	`Famille`			varchar (255), 
	`PRIX_A`			double, 
	`PRIX_MP`			double, 
	`PRIX_V`			double, 
	`Qté`			double, 
	`Remise`			double, 
	`TOTAL_NET`			double, 
	`Caissier`			varchar (255), 
	`Vendeur`			varchar (255), 
	`TAUX_TVA`			double, 
	`PRINTER`			varchar (255), 
	`PRINTER_DUPLICATA`			varchar (255), 
	`cuisine`			varchar (255)
);

-- CREATE INDEXES ...
ALTER TABLE `TABLE_03` ADD INDEX `Code` (`Code`);
ALTER TABLE `TABLE_03` ADD PRIMARY KEY (`ID`);



INSERT INTO `TABLE_03` (`ID`, `Ticket`, `Dates`, `Heure`, `ID_ARTICLE`, `Code`, `Article`, `Famille`, `PRIX_A`, `PRIX_MP`, `PRIX_V`, `Qté`, `Remise`, `TOTAL_NET`, `Caissier`, `Vendeur`, `TAUX_TVA`, `PRINTER`, `PRINTER_DUPLICATA`, `cuisine`) VALUES (1,NULL,"2023-12-21 00:00:00","11:34:07","ART15","70235","COCA LIGHT","SODA",0.0000,0.0000,10.0000,1,0,10.0000,"LE PATRON",NULL,0,"C1","0",NULL), (2,NULL,"2023-12-21 00:00:00","11:34:15","ART2","70222","CAFE CREME","BOISSONS CHAUDES",0.0000,0.0000,10.0000,1,0,10.0000,"LE PATRON",NULL,0,"C1","0",NULL), (3,NULL,"2023-12-21 00:00:00","11:34:16","ART4","70224","CAFE MOITIE","BOISSONS CHAUDES",0.0000,0.0000,10.0000,1,0,10.0000,"LE PATRON",NULL,0,"C1","0",NULL);

-- ----------------------------------------------------------
-- MDB Tools - A library for reading MS Access database files
-- Copyright (C) 2000-2011 Brian Bruns and others.
-- Files in libmdb are licensed under LGPL and the utilities under
-- the GPL, see COPYING.LIB and COPYING files respectively.
-- Check out http://mdbtools.sourceforge.net
-- ----------------------------------------------------------

-- That file uses encoding UTF-8

CREATE TABLE `TABLE_04`
 (
	`ID`			int NOT NULL AUTO_INCREMENT UNIQUE, 
	`Ticket`			varchar (255), 
	`Dates`			datetime, 
	`Heure`			varchar (255), 
	`ID_ARTICLE`			varchar (255), 
	`Code`			varchar (255), 
	`Article`			varchar (255), 
	`Famille`			varchar (255), 
	`PRIX_A`			double, 
	`PRIX_MP`			double, 
	`PRIX_V`			double, 
	`Qté`			double, 
	`Remise`			double, 
	`TOTAL_NET`			double, 
	`Caissier`			varchar (255), 
	`Vendeur`			varchar (255), 
	`TAUX_TVA`			double, 
	`PRINTER`			varchar (255), 
	`PRINTER_DUPLICATA`			varchar (255), 
	`cuisine`			varchar (255)
);

-- CREATE INDEXES ...
ALTER TABLE `TABLE_04` ADD INDEX `Code` (`Code`);
ALTER TABLE `TABLE_04` ADD PRIMARY KEY (`ID`);



INSERT INTO `TABLE_04` (`ID`, `Ticket`, `Dates`, `Heure`, `ID_ARTICLE`, `Code`, `Article`, `Famille`, `PRIX_A`, `PRIX_MP`, `PRIX_V`, `Qté`, `Remise`, `TOTAL_NET`, `Caissier`, `Vendeur`, `TAUX_TVA`, `PRINTER`, `PRINTER_DUPLICATA`, `cuisine`) VALUES (1,NULL,"2023-11-06 00:00:00","00:11:11","ART29","70249","JUS POMME","JUS",0.0000,0.0000,33.0000,1,0,33.0000,"LE PATRON",NULL,0,"C1","0",NULL), (2,NULL,"2023-11-06 00:00:00","00:11:14","ART000019","4840","test","BOISSONS CHAUDES",0.0000,0.0000,0.0000,1,0,0.0000,"LE PATRON",NULL,0,"C1","0",NULL), (3,NULL,"2024-01-20 00:00:00","18:30:27","ART29","70249","JUS POMME","JUS",0.0000,0.0000,44.0000,1,0,44.0000,"LE PATRON",NULL,0,"C1","0",NULL);

-- ----------------------------------------------------------
-- MDB Tools - A library for reading MS Access database files
-- Copyright (C) 2000-2011 Brian Bruns and others.
-- Files in libmdb are licensed under LGPL and the utilities under
-- the GPL, see COPYING.LIB and COPYING files respectively.
-- Check out http://mdbtools.sourceforge.net
-- ----------------------------------------------------------

-- That file uses encoding UTF-8

CREATE TABLE `TABLE_05`
 (
	`ID`			int NOT NULL AUTO_INCREMENT UNIQUE, 
	`Ticket`			varchar (255), 
	`Dates`			datetime, 
	`Heure`			varchar (255), 
	`ID_ARTICLE`			varchar (255), 
	`Code`			varchar (255), 
	`Article`			varchar (255), 
	`Famille`			varchar (255), 
	`PRIX_A`			double, 
	`PRIX_MP`			double, 
	`PRIX_V`			double, 
	`Qté`			double, 
	`Remise`			double, 
	`TOTAL_NET`			double, 
	`Caissier`			varchar (255), 
	`Vendeur`			varchar (255), 
	`TAUX_TVA`			double, 
	`PRINTER`			varchar (255), 
	`PRINTER_DUPLICATA`			varchar (255), 
	`cuisine`			varchar (255)
);

-- CREATE INDEXES ...
ALTER TABLE `TABLE_05` ADD INDEX `Code` (`Code`);
ALTER TABLE `TABLE_05` ADD PRIMARY KEY (`ID`);




-- ----------------------------------------------------------
-- MDB Tools - A library for reading MS Access database files
-- Copyright (C) 2000-2011 Brian Bruns and others.
-- Files in libmdb are licensed under LGPL and the utilities under
-- the GPL, see COPYING.LIB and COPYING files respectively.
-- Check out http://mdbtools.sourceforge.net
-- ----------------------------------------------------------

-- That file uses encoding UTF-8

CREATE TABLE `TABLE_06`
 (
	`ID`			int NOT NULL AUTO_INCREMENT UNIQUE, 
	`Ticket`			varchar (255), 
	`Dates`			datetime, 
	`Heure`			varchar (255), 
	`ID_ARTICLE`			varchar (255), 
	`Code`			varchar (255), 
	`Article`			varchar (255), 
	`Famille`			varchar (255), 
	`PRIX_A`			double, 
	`PRIX_MP`			double, 
	`PRIX_V`			double, 
	`Qté`			double, 
	`Remise`			double, 
	`TOTAL_NET`			double, 
	`Caissier`			varchar (255), 
	`Vendeur`			varchar (255), 
	`TAUX_TVA`			double, 
	`PRINTER`			varchar (255), 
	`PRINTER_DUPLICATA`			varchar (255), 
	`cuisine`			varchar (255)
);

-- CREATE INDEXES ...
ALTER TABLE `TABLE_06` ADD INDEX `Code` (`Code`);
ALTER TABLE `TABLE_06` ADD PRIMARY KEY (`ID`);



INSERT INTO `TABLE_06` (`ID`, `Ticket`, `Dates`, `Heure`, `ID_ARTICLE`, `Code`, `Article`, `Famille`, `PRIX_A`, `PRIX_MP`, `PRIX_V`, `Qté`, `Remise`, `TOTAL_NET`, `Caissier`, `Vendeur`, `TAUX_TVA`, `PRINTER`, `PRINTER_DUPLICATA`, `cuisine`) VALUES (1,NULL,"2023-11-06 00:00:00","00:07:26","ART2","70222","CAFE CREME","BOISSONS CHAUDES",0.0000,0.0000,10.0000,1,0,10.0000,"LE PATRON",NULL,0,"C1","0",NULL), (2,NULL,"2023-11-06 00:00:00","00:07:27","ART1","70221","CAFE NOIR","BOISSONS CHAUDES",0.0000,0.0000,10.0000,1,0,10.0000,"LE PATRON",NULL,0,"C1","0",NULL), (3,NULL,"2023-11-06 00:00:00","00:07:27","ART000019","4840","test","BOISSONS CHAUDES",0.0000,0.0000,0.0000,1,0,0.0000,"LE PATRON",NULL,0,"C1","0",NULL), (4,NULL,"2023-11-06 00:00:00","00:07:31","ART000019","4840","test","BOISSONS CHAUDES",0.0000,0.0000,0.0000,1,0,0.0000,"LE PATRON",NULL,0,"C1","0",NULL);

-- ----------------------------------------------------------
-- MDB Tools - A library for reading MS Access database files
-- Copyright (C) 2000-2011 Brian Bruns and others.
-- Files in libmdb are licensed under LGPL and the utilities under
-- the GPL, see COPYING.LIB and COPYING files respectively.
-- Check out http://mdbtools.sourceforge.net
-- ----------------------------------------------------------

-- That file uses encoding UTF-8

CREATE TABLE `TABLE_08`
 (
	`ID`			int NOT NULL AUTO_INCREMENT UNIQUE, 
	`Ticket`			varchar (255), 
	`Dates`			datetime, 
	`Heure`			varchar (255), 
	`ID_ARTICLE`			varchar (255), 
	`Code`			varchar (255), 
	`Article`			varchar (255), 
	`Famille`			varchar (255), 
	`PRIX_A`			double, 
	`PRIX_MP`			double, 
	`PRIX_V`			double, 
	`Qté`			double, 
	`Remise`			double, 
	`TOTAL_NET`			double, 
	`Caissier`			varchar (255), 
	`Vendeur`			varchar (255), 
	`TAUX_TVA`			double, 
	`PRINTER`			varchar (255), 
	`PRINTER_DUPLICATA`			varchar (255), 
	`cuisine`			varchar (255)
);

-- CREATE INDEXES ...
ALTER TABLE `TABLE_08` ADD INDEX `Code` (`Code`);
ALTER TABLE `TABLE_08` ADD PRIMARY KEY (`ID`);



INSERT INTO `TABLE_08` (`ID`, `Ticket`, `Dates`, `Heure`, `ID_ARTICLE`, `Code`, `Article`, `Famille`, `PRIX_A`, `PRIX_MP`, `PRIX_V`, `Qté`, `Remise`, `TOTAL_NET`, `Caissier`, `Vendeur`, `TAUX_TVA`, `PRINTER`, `PRINTER_DUPLICATA`, `cuisine`) VALUES (1,NULL,"2023-11-15 00:00:00","16:56:39","ART93","70313","TACOS MIXTE","TACOS",0.0000,0.0000,10.0000,1,0,10.0000,"LE PATRON",NULL,0,"C1","0",NULL), (2,NULL,"2023-11-15 00:00:00","16:56:41","ART94","70314","TACOS CORDON B","TACOS",0.0000,0.0000,10.0000,1,0,10.0000,"LE PATRON",NULL,0,"C1","0",NULL), (3,NULL,"2023-11-15 00:00:00","16:56:42","ART91","70311","TACOS POULET","TACOS",0.0000,0.0000,10.0000,1,0,10.0000,"LE PATRON",NULL,0,"C1","0",NULL);

-- ----------------------------------------------------------
-- MDB Tools - A library for reading MS Access database files
-- Copyright (C) 2000-2011 Brian Bruns and others.
-- Files in libmdb are licensed under LGPL and the utilities under
-- the GPL, see COPYING.LIB and COPYING files respectively.
-- Check out http://mdbtools.sourceforge.net
-- ----------------------------------------------------------

-- That file uses encoding UTF-8

CREATE TABLE `TABLE_09`
 (
	`ID`			int NOT NULL AUTO_INCREMENT UNIQUE, 
	`Ticket`			varchar (255), 
	`Dates`			datetime, 
	`Heure`			varchar (255), 
	`ID_ARTICLE`			varchar (255), 
	`Code`			varchar (255), 
	`Article`			varchar (255), 
	`Famille`			varchar (255), 
	`PRIX_A`			double, 
	`PRIX_MP`			double, 
	`PRIX_V`			double, 
	`Qté`			double, 
	`Remise`			double, 
	`TOTAL_NET`			double, 
	`Caissier`			varchar (255), 
	`Vendeur`			varchar (255), 
	`TAUX_TVA`			double, 
	`PRINTER`			varchar (255), 
	`PRINTER_DUPLICATA`			varchar (255), 
	`cuisine`			varchar (255)
);

-- CREATE INDEXES ...
ALTER TABLE `TABLE_09` ADD INDEX `Code` (`Code`);
ALTER TABLE `TABLE_09` ADD PRIMARY KEY (`ID`);




-- ----------------------------------------------------------
-- MDB Tools - A library for reading MS Access database files
-- Copyright (C) 2000-2011 Brian Bruns and others.
-- Files in libmdb are licensed under LGPL and the utilities under
-- the GPL, see COPYING.LIB and COPYING files respectively.
-- Check out http://mdbtools.sourceforge.net
-- ----------------------------------------------------------

-- That file uses encoding UTF-8

CREATE TABLE `TABLE_10`
 (
	`ID`			int NOT NULL AUTO_INCREMENT UNIQUE, 
	`Ticket`			varchar (255), 
	`Dates`			datetime, 
	`Heure`			varchar (255), 
	`ID_ARTICLE`			varchar (255), 
	`Code`			varchar (255), 
	`Article`			varchar (255), 
	`Famille`			varchar (255), 
	`PRIX_A`			double, 
	`PRIX_MP`			double, 
	`PRIX_V`			double, 
	`Qté`			double, 
	`Remise`			double, 
	`TOTAL_NET`			double, 
	`Caissier`			varchar (255), 
	`Vendeur`			varchar (255), 
	`TAUX_TVA`			double, 
	`PRINTER`			varchar (255), 
	`PRINTER_DUPLICATA`			varchar (255), 
	`cuisine`			varchar (255)
);

-- CREATE INDEXES ...
ALTER TABLE `TABLE_10` ADD INDEX `Code` (`Code`);
ALTER TABLE `TABLE_10` ADD PRIMARY KEY (`ID`);



INSERT INTO `TABLE_10` (`ID`, `Ticket`, `Dates`, `Heure`, `ID_ARTICLE`, `Code`, `Article`, `Famille`, `PRIX_A`, `PRIX_MP`, `PRIX_V`, `Qté`, `Remise`, `TOTAL_NET`, `Caissier`, `Vendeur`, `TAUX_TVA`, `PRINTER`, `PRINTER_DUPLICATA`, `cuisine`) VALUES (1,NULL,"2024-01-12 00:00:00","17:12:40","ART61","70281","TARTE FRUITS","GATEAUX",0.0000,0.0000,10.0000,1,0,10.0000,"LE PATRON",NULL,0,"C1","0","1");

-- ----------------------------------------------------------
-- MDB Tools - A library for reading MS Access database files
-- Copyright (C) 2000-2011 Brian Bruns and others.
-- Files in libmdb are licensed under LGPL and the utilities under
-- the GPL, see COPYING.LIB and COPYING files respectively.
-- Check out http://mdbtools.sourceforge.net
-- ----------------------------------------------------------

-- That file uses encoding UTF-8

CREATE TABLE `TABLE_11`
 (
	`ID`			int NOT NULL AUTO_INCREMENT UNIQUE, 
	`Ticket`			varchar (255), 
	`Dates`			datetime, 
	`Heure`			varchar (255), 
	`ID_ARTICLE`			varchar (255), 
	`Code`			varchar (255), 
	`Article`			varchar (255), 
	`Famille`			varchar (255), 
	`PRIX_A`			double, 
	`PRIX_MP`			double, 
	`PRIX_V`			double, 
	`Qté`			double, 
	`Remise`			double, 
	`TOTAL_NET`			double, 
	`Caissier`			varchar (255), 
	`Vendeur`			varchar (255), 
	`TAUX_TVA`			double, 
	`PRINTER`			varchar (255), 
	`PRINTER_DUPLICATA`			varchar (255), 
	`cuisine`			varchar (255)
);

-- CREATE INDEXES ...
ALTER TABLE `TABLE_11` ADD INDEX `Code` (`Code`);
ALTER TABLE `TABLE_11` ADD PRIMARY KEY (`ID`);




-- ----------------------------------------------------------
-- MDB Tools - A library for reading MS Access database files
-- Copyright (C) 2000-2011 Brian Bruns and others.
-- Files in libmdb are licensed under LGPL and the utilities under
-- the GPL, see COPYING.LIB and COPYING files respectively.
-- Check out http://mdbtools.sourceforge.net
-- ----------------------------------------------------------

-- That file uses encoding UTF-8

CREATE TABLE `TABLE_12`
 (
	`ID`			int NOT NULL AUTO_INCREMENT UNIQUE, 
	`Ticket`			varchar (255), 
	`Dates`			datetime, 
	`Heure`			varchar (255), 
	`ID_ARTICLE`			varchar (255), 
	`Code`			varchar (255), 
	`Article`			varchar (255), 
	`Famille`			varchar (255), 
	`PRIX_A`			double, 
	`PRIX_MP`			double, 
	`PRIX_V`			double, 
	`Qté`			double, 
	`Remise`			double, 
	`TOTAL_NET`			double, 
	`Caissier`			varchar (255), 
	`Vendeur`			varchar (255), 
	`TAUX_TVA`			double, 
	`PRINTER`			varchar (255), 
	`PRINTER_DUPLICATA`			varchar (255), 
	`cuisine`			varchar (255)
);

-- CREATE INDEXES ...
ALTER TABLE `TABLE_12` ADD INDEX `Code` (`Code`);
ALTER TABLE `TABLE_12` ADD PRIMARY KEY (`ID`);




-- ----------------------------------------------------------
-- MDB Tools - A library for reading MS Access database files
-- Copyright (C) 2000-2011 Brian Bruns and others.
-- Files in libmdb are licensed under LGPL and the utilities under
-- the GPL, see COPYING.LIB and COPYING files respectively.
-- Check out http://mdbtools.sourceforge.net
-- ----------------------------------------------------------

-- That file uses encoding UTF-8

CREATE TABLE `TABLE_14`
 (
	`ID`			int NOT NULL AUTO_INCREMENT UNIQUE, 
	`Ticket`			varchar (255), 
	`Dates`			datetime, 
	`Heure`			varchar (255), 
	`ID_ARTICLE`			varchar (255), 
	`Code`			varchar (255), 
	`Article`			varchar (255), 
	`Famille`			varchar (255), 
	`PRIX_A`			double, 
	`PRIX_MP`			double, 
	`PRIX_V`			double, 
	`Qté`			double, 
	`Remise`			double, 
	`TOTAL_NET`			double, 
	`Caissier`			varchar (255), 
	`Vendeur`			varchar (255), 
	`TAUX_TVA`			double, 
	`PRINTER`			varchar (255), 
	`PRINTER_DUPLICATA`			varchar (255), 
	`cuisine`			varchar (255)
);

-- CREATE INDEXES ...
ALTER TABLE `TABLE_14` ADD INDEX `Code` (`Code`);
ALTER TABLE `TABLE_14` ADD PRIMARY KEY (`ID`);




-- ----------------------------------------------------------
-- MDB Tools - A library for reading MS Access database files
-- Copyright (C) 2000-2011 Brian Bruns and others.
-- Files in libmdb are licensed under LGPL and the utilities under
-- the GPL, see COPYING.LIB and COPYING files respectively.
-- Check out http://mdbtools.sourceforge.net
-- ----------------------------------------------------------

-- That file uses encoding UTF-8

CREATE TABLE `TABLE_15`
 (
	`ID`			int NOT NULL AUTO_INCREMENT UNIQUE, 
	`Ticket`			varchar (255), 
	`Dates`			datetime, 
	`Heure`			varchar (255), 
	`ID_ARTICLE`			varchar (255), 
	`Code`			varchar (255), 
	`Article`			varchar (255), 
	`Famille`			varchar (255), 
	`PRIX_A`			double, 
	`PRIX_MP`			double, 
	`PRIX_V`			double, 
	`Qté`			double, 
	`Remise`			double, 
	`TOTAL_NET`			double, 
	`Caissier`			varchar (255), 
	`Vendeur`			varchar (255), 
	`TAUX_TVA`			double, 
	`PRINTER`			varchar (255), 
	`PRINTER_DUPLICATA`			varchar (255), 
	`cuisine`			varchar (255)
);

-- CREATE INDEXES ...
ALTER TABLE `TABLE_15` ADD INDEX `Code` (`Code`);
ALTER TABLE `TABLE_15` ADD PRIMARY KEY (`ID`);



INSERT INTO `TABLE_15` (`ID`, `Ticket`, `Dates`, `Heure`, `ID_ARTICLE`, `Code`, `Article`, `Famille`, `PRIX_A`, `PRIX_MP`, `PRIX_V`, `Qté`, `Remise`, `TOTAL_NET`, `Caissier`, `Vendeur`, `TAUX_TVA`, `PRINTER`, `PRINTER_DUPLICATA`, `cuisine`) VALUES (1,NULL,"2024-01-12 00:00:00","17:48:51","ART110","70330","PIZZA P THON","PIZZA",0.0000,0.0000,10.0000,1,0,10.0000,"LE PATRON",NULL,0,"C1","0",NULL);

-- ----------------------------------------------------------
-- MDB Tools - A library for reading MS Access database files
-- Copyright (C) 2000-2011 Brian Bruns and others.
-- Files in libmdb are licensed under LGPL and the utilities under
-- the GPL, see COPYING.LIB and COPYING files respectively.
-- Check out http://mdbtools.sourceforge.net
-- ----------------------------------------------------------

-- That file uses encoding UTF-8

CREATE TABLE `TABLE_16`
 (
	`ID`			int NOT NULL AUTO_INCREMENT UNIQUE, 
	`Ticket`			varchar (255), 
	`Dates`			datetime, 
	`Heure`			varchar (255), 
	`ID_ARTICLE`			varchar (255), 
	`Code`			varchar (255), 
	`Article`			varchar (255), 
	`Famille`			varchar (255), 
	`PRIX_A`			double, 
	`PRIX_MP`			double, 
	`PRIX_V`			double, 
	`Qté`			double, 
	`Remise`			double, 
	`TOTAL_NET`			double, 
	`Caissier`			varchar (255), 
	`Vendeur`			varchar (255), 
	`TAUX_TVA`			double, 
	`PRINTER`			varchar (255), 
	`PRINTER_DUPLICATA`			varchar (255), 
	`cuisine`			varchar (255)
);

-- CREATE INDEXES ...
ALTER TABLE `TABLE_16` ADD INDEX `Code` (`Code`);
ALTER TABLE `TABLE_16` ADD PRIMARY KEY (`ID`);



INSERT INTO `TABLE_16` (`ID`, `Ticket`, `Dates`, `Heure`, `ID_ARTICLE`, `Code`, `Article`, `Famille`, `PRIX_A`, `PRIX_MP`, `PRIX_V`, `Qté`, `Remise`, `TOTAL_NET`, `Caissier`, `Vendeur`, `TAUX_TVA`, `PRINTER`, `PRINTER_DUPLICATA`, `cuisine`) VALUES (1,NULL,"2023-10-27 00:00:00","20:43:45","ART62","70282","GATEAU SOIREE","GATEAUX",0.0000,0.0000,10.0000,1,5,9.5000,"LE PATRON",NULL,0,"C1","0",NULL), (2,NULL,"2023-10-27 00:00:00","20:43:45","ART61","70281","TARTE FRUITS","GATEAUX",0.0000,0.0000,10.0000,1,5,9.5000,"LE PATRON",NULL,0,"C1","0",NULL);

-- ----------------------------------------------------------
-- MDB Tools - A library for reading MS Access database files
-- Copyright (C) 2000-2011 Brian Bruns and others.
-- Files in libmdb are licensed under LGPL and the utilities under
-- the GPL, see COPYING.LIB and COPYING files respectively.
-- Check out http://mdbtools.sourceforge.net
-- ----------------------------------------------------------

-- That file uses encoding UTF-8

CREATE TABLE `TABLE_17`
 (
	`ID`			int NOT NULL AUTO_INCREMENT UNIQUE, 
	`Ticket`			varchar (255), 
	`Dates`			datetime, 
	`Heure`			varchar (255), 
	`ID_ARTICLE`			varchar (255), 
	`Code`			varchar (255), 
	`Article`			varchar (255), 
	`Famille`			varchar (255), 
	`PRIX_A`			double, 
	`PRIX_MP`			double, 
	`PRIX_V`			double, 
	`Qté`			double, 
	`Remise`			double, 
	`TOTAL_NET`			double, 
	`Caissier`			varchar (255), 
	`Vendeur`			varchar (255), 
	`TAUX_TVA`			double, 
	`PRINTER`			varchar (255), 
	`PRINTER_DUPLICATA`			varchar (255), 
	`cuisine`			varchar (255)
);

-- CREATE INDEXES ...
ALTER TABLE `TABLE_17` ADD INDEX `Code` (`Code`);
ALTER TABLE `TABLE_17` ADD PRIMARY KEY (`ID`);



INSERT INTO `TABLE_17` (`ID`, `Ticket`, `Dates`, `Heure`, `ID_ARTICLE`, `Code`, `Article`, `Famille`, `PRIX_A`, `PRIX_MP`, `PRIX_V`, `Qté`, `Remise`, `TOTAL_NET`, `Caissier`, `Vendeur`, `TAUX_TVA`, `PRINTER`, `PRINTER_DUPLICATA`, `cuisine`) VALUES (1,NULL,"2023-11-08 00:00:00","23:00:10","ART62","70282","GATEAU SOIREE","GATEAUX",0.0000,0.0000,10.0000,1,0,10.0000,"LE PATRON",NULL,0,"C1","0",NULL), (2,NULL,"2023-11-08 00:00:00","23:00:14","ID_ARTICLE_COMM","CODE_COMM","--> vcvvvvvvvvvv","GATEAUX",0.0000,0.0000,0.0000,0,0,0.0000,"LE PATRON",NULL,0,"C1","0",NULL), (3,NULL,"2023-11-08 00:00:00","23:00:15","ID_ARTICLE_COMM","CODE_COMM","--> VGFdddd","GATEAUX",0.0000,0.0000,0.0000,0,0,0.0000,"LE PATRON",NULL,0,"C1","0",NULL), (4,NULL,"2023-12-21 00:00:00","12:52:49","ID_ARTICLE_COMM","CODE_COMM","--> test","GATEAUX",0.0000,0.0000,0.0000,0,0,0.0000,"LE PATRON",NULL,0,"C1","0",NULL), (5,NULL,"2023-12-21 00:00:00","12:52:50","ID_ARTICLE_COMM","CODE_COMM","--> test 2","GATEAUX",0.0000,0.0000,0.0000,0,0,0.0000,"LE PATRON",NULL,0,"C1","0",NULL);

-- ----------------------------------------------------------
-- MDB Tools - A library for reading MS Access database files
-- Copyright (C) 2000-2011 Brian Bruns and others.
-- Files in libmdb are licensed under LGPL and the utilities under
-- the GPL, see COPYING.LIB and COPYING files respectively.
-- Check out http://mdbtools.sourceforge.net
-- ----------------------------------------------------------

-- That file uses encoding UTF-8

CREATE TABLE `TABLE_18`
 (
	`ID`			int NOT NULL AUTO_INCREMENT UNIQUE, 
	`Ticket`			varchar (255), 
	`Dates`			datetime, 
	`Heure`			varchar (255), 
	`ID_ARTICLE`			varchar (255), 
	`Code`			varchar (255), 
	`Article`			varchar (255), 
	`Famille`			varchar (255), 
	`PRIX_A`			double, 
	`PRIX_MP`			double, 
	`PRIX_V`			double, 
	`Qté`			double, 
	`Remise`			double, 
	`TOTAL_NET`			double, 
	`Caissier`			varchar (255), 
	`Vendeur`			varchar (255), 
	`TAUX_TVA`			double, 
	`PRINTER`			varchar (255), 
	`PRINTER_DUPLICATA`			varchar (255), 
	`cuisine`			varchar (255)
);

-- CREATE INDEXES ...
ALTER TABLE `TABLE_18` ADD INDEX `Code` (`Code`);
ALTER TABLE `TABLE_18` ADD PRIMARY KEY (`ID`);




-- ----------------------------------------------------------
-- MDB Tools - A library for reading MS Access database files
-- Copyright (C) 2000-2011 Brian Bruns and others.
-- Files in libmdb are licensed under LGPL and the utilities under
-- the GPL, see COPYING.LIB and COPYING files respectively.
-- Check out http://mdbtools.sourceforge.net
-- ----------------------------------------------------------

-- That file uses encoding UTF-8

CREATE TABLE `TABLE_19`
 (
	`ID`			int NOT NULL AUTO_INCREMENT UNIQUE, 
	`Ticket`			varchar (255), 
	`Dates`			datetime, 
	`Heure`			varchar (255), 
	`ID_ARTICLE`			varchar (255), 
	`Code`			varchar (255), 
	`Article`			varchar (255), 
	`Famille`			varchar (255), 
	`PRIX_A`			double, 
	`PRIX_MP`			double, 
	`PRIX_V`			double, 
	`Qté`			double, 
	`Remise`			double, 
	`TOTAL_NET`			double, 
	`Caissier`			varchar (255), 
	`Vendeur`			varchar (255), 
	`TAUX_TVA`			double, 
	`PRINTER`			varchar (255), 
	`PRINTER_DUPLICATA`			varchar (255), 
	`cuisine`			varchar (255)
);

-- CREATE INDEXES ...
ALTER TABLE `TABLE_19` ADD INDEX `Code` (`Code`);
ALTER TABLE `TABLE_19` ADD PRIMARY KEY (`ID`);




-- ----------------------------------------------------------
-- MDB Tools - A library for reading MS Access database files
-- Copyright (C) 2000-2011 Brian Bruns and others.
-- Files in libmdb are licensed under LGPL and the utilities under
-- the GPL, see COPYING.LIB and COPYING files respectively.
-- Check out http://mdbtools.sourceforge.net
-- ----------------------------------------------------------

-- That file uses encoding UTF-8

CREATE TABLE `TABLE_21`
 (
	`ID`			int NOT NULL AUTO_INCREMENT UNIQUE, 
	`Ticket`			varchar (255), 
	`Dates`			datetime, 
	`Heure`			varchar (255), 
	`ID_ARTICLE`			varchar (255), 
	`Code`			varchar (255), 
	`Article`			varchar (255), 
	`Famille`			varchar (255), 
	`PRIX_A`			double, 
	`PRIX_MP`			double, 
	`PRIX_V`			double, 
	`Qté`			double, 
	`Remise`			double, 
	`TOTAL_NET`			double, 
	`Caissier`			varchar (255), 
	`Vendeur`			varchar (255), 
	`TAUX_TVA`			double, 
	`PRINTER`			varchar (255), 
	`PRINTER_DUPLICATA`			varchar (255), 
	`cuisine`			varchar (255)
);

-- CREATE INDEXES ...
ALTER TABLE `TABLE_21` ADD INDEX `Code` (`Code`);
ALTER TABLE `TABLE_21` ADD PRIMARY KEY (`ID`);




-- ----------------------------------------------------------
-- MDB Tools - A library for reading MS Access database files
-- Copyright (C) 2000-2011 Brian Bruns and others.
-- Files in libmdb are licensed under LGPL and the utilities under
-- the GPL, see COPYING.LIB and COPYING files respectively.
-- Check out http://mdbtools.sourceforge.net
-- ----------------------------------------------------------

-- That file uses encoding UTF-8

CREATE TABLE `TABLE_22`
 (
	`ID`			int NOT NULL AUTO_INCREMENT UNIQUE, 
	`Ticket`			varchar (255), 
	`Dates`			datetime, 
	`Heure`			varchar (255), 
	`ID_ARTICLE`			varchar (255), 
	`Code`			varchar (255), 
	`Article`			varchar (255), 
	`Famille`			varchar (255), 
	`PRIX_A`			double, 
	`PRIX_MP`			double, 
	`PRIX_V`			double, 
	`Qté`			double, 
	`Remise`			double, 
	`TOTAL_NET`			double, 
	`Caissier`			varchar (255), 
	`Vendeur`			varchar (255), 
	`TAUX_TVA`			double, 
	`PRINTER`			varchar (255), 
	`PRINTER_DUPLICATA`			varchar (255), 
	`cuisine`			varchar (255)
);

-- CREATE INDEXES ...
ALTER TABLE `TABLE_22` ADD INDEX `Code` (`Code`);
ALTER TABLE `TABLE_22` ADD PRIMARY KEY (`ID`);




-- ----------------------------------------------------------
-- MDB Tools - A library for reading MS Access database files
-- Copyright (C) 2000-2011 Brian Bruns and others.
-- Files in libmdb are licensed under LGPL and the utilities under
-- the GPL, see COPYING.LIB and COPYING files respectively.
-- Check out http://mdbtools.sourceforge.net
-- ----------------------------------------------------------

-- That file uses encoding UTF-8

CREATE TABLE `TABLE_23`
 (
	`ID`			int NOT NULL AUTO_INCREMENT UNIQUE, 
	`Ticket`			varchar (255), 
	`Dates`			datetime, 
	`Heure`			varchar (255), 
	`ID_ARTICLE`			varchar (255), 
	`Code`			varchar (255), 
	`Article`			varchar (255), 
	`Famille`			varchar (255), 
	`PRIX_A`			double, 
	`PRIX_MP`			double, 
	`PRIX_V`			double, 
	`Qté`			double, 
	`Remise`			double, 
	`TOTAL_NET`			double, 
	`Caissier`			varchar (255), 
	`Vendeur`			varchar (255), 
	`TAUX_TVA`			double, 
	`PRINTER`			varchar (255), 
	`PRINTER_DUPLICATA`			varchar (255), 
	`cuisine`			varchar (255)
);

-- CREATE INDEXES ...
ALTER TABLE `TABLE_23` ADD INDEX `Code` (`Code`);
ALTER TABLE `TABLE_23` ADD PRIMARY KEY (`ID`);




-- ----------------------------------------------------------
-- MDB Tools - A library for reading MS Access database files
-- Copyright (C) 2000-2011 Brian Bruns and others.
-- Files in libmdb are licensed under LGPL and the utilities under
-- the GPL, see COPYING.LIB and COPYING files respectively.
-- Check out http://mdbtools.sourceforge.net
-- ----------------------------------------------------------

-- That file uses encoding UTF-8

CREATE TABLE `TABLE_24`
 (
	`ID`			int NOT NULL AUTO_INCREMENT UNIQUE, 
	`Ticket`			varchar (255), 
	`Dates`			datetime, 
	`Heure`			varchar (255), 
	`ID_ARTICLE`			varchar (255), 
	`Code`			varchar (255), 
	`Article`			varchar (255), 
	`Famille`			varchar (255), 
	`PRIX_A`			double, 
	`PRIX_MP`			double, 
	`PRIX_V`			double, 
	`Qté`			double, 
	`Remise`			double, 
	`TOTAL_NET`			double, 
	`Caissier`			varchar (255), 
	`Vendeur`			varchar (255), 
	`TAUX_TVA`			double, 
	`PRINTER`			varchar (255), 
	`PRINTER_DUPLICATA`			varchar (255), 
	`cuisine`			varchar (255)
);

-- CREATE INDEXES ...
ALTER TABLE `TABLE_24` ADD INDEX `Code` (`Code`);
ALTER TABLE `TABLE_24` ADD PRIMARY KEY (`ID`);




-- ----------------------------------------------------------
-- MDB Tools - A library for reading MS Access database files
-- Copyright (C) 2000-2011 Brian Bruns and others.
-- Files in libmdb are licensed under LGPL and the utilities under
-- the GPL, see COPYING.LIB and COPYING files respectively.
-- Check out http://mdbtools.sourceforge.net
-- ----------------------------------------------------------

-- That file uses encoding UTF-8

CREATE TABLE `TABLE_25`
 (
	`ID`			int NOT NULL AUTO_INCREMENT UNIQUE, 
	`Ticket`			varchar (255), 
	`Dates`			datetime, 
	`Heure`			varchar (255), 
	`ID_ARTICLE`			varchar (255), 
	`Code`			varchar (255), 
	`Article`			varchar (255), 
	`Famille`			varchar (255), 
	`PRIX_A`			double, 
	`PRIX_MP`			double, 
	`PRIX_V`			double, 
	`Qté`			double, 
	`Remise`			double, 
	`TOTAL_NET`			double, 
	`Caissier`			varchar (255), 
	`Vendeur`			varchar (255), 
	`TAUX_TVA`			double, 
	`PRINTER`			varchar (255), 
	`PRINTER_DUPLICATA`			varchar (255), 
	`cuisine`			varchar (255)
);

-- CREATE INDEXES ...
ALTER TABLE `TABLE_25` ADD INDEX `Code` (`Code`);
ALTER TABLE `TABLE_25` ADD PRIMARY KEY (`ID`);




-- ----------------------------------------------------------
-- MDB Tools - A library for reading MS Access database files
-- Copyright (C) 2000-2011 Brian Bruns and others.
-- Files in libmdb are licensed under LGPL and the utilities under
-- the GPL, see COPYING.LIB and COPYING files respectively.
-- Check out http://mdbtools.sourceforge.net
-- ----------------------------------------------------------

-- That file uses encoding UTF-8

CREATE TABLE `TABLE_26`
 (
	`ID`			int NOT NULL AUTO_INCREMENT UNIQUE, 
	`Ticket`			varchar (255), 
	`Dates`			datetime, 
	`Heure`			varchar (255), 
	`ID_ARTICLE`			varchar (255), 
	`Code`			varchar (255), 
	`Article`			varchar (255), 
	`Famille`			varchar (255), 
	`PRIX_A`			double, 
	`PRIX_MP`			double, 
	`PRIX_V`			double, 
	`Qté`			double, 
	`Remise`			double, 
	`TOTAL_NET`			double, 
	`Caissier`			varchar (255), 
	`Vendeur`			varchar (255), 
	`TAUX_TVA`			double, 
	`PRINTER`			varchar (255), 
	`PRINTER_DUPLICATA`			varchar (255), 
	`cuisine`			varchar (255)
);

-- CREATE INDEXES ...
ALTER TABLE `TABLE_26` ADD INDEX `Code` (`Code`);
ALTER TABLE `TABLE_26` ADD PRIMARY KEY (`ID`);




-- ----------------------------------------------------------
-- MDB Tools - A library for reading MS Access database files
-- Copyright (C) 2000-2011 Brian Bruns and others.
-- Files in libmdb are licensed under LGPL and the utilities under
-- the GPL, see COPYING.LIB and COPYING files respectively.
-- Check out http://mdbtools.sourceforge.net
-- ----------------------------------------------------------

-- That file uses encoding UTF-8

CREATE TABLE `TABLE_28`
 (
	`ID`			int NOT NULL AUTO_INCREMENT UNIQUE, 
	`Ticket`			varchar (255), 
	`Dates`			datetime, 
	`Heure`			varchar (255), 
	`ID_ARTICLE`			varchar (255), 
	`Code`			varchar (255), 
	`Article`			varchar (255), 
	`Famille`			varchar (255), 
	`PRIX_A`			double, 
	`PRIX_MP`			double, 
	`PRIX_V`			double, 
	`Qté`			double, 
	`Remise`			double, 
	`TOTAL_NET`			double, 
	`Caissier`			varchar (255), 
	`Vendeur`			varchar (255), 
	`TAUX_TVA`			double, 
	`PRINTER`			varchar (255), 
	`PRINTER_DUPLICATA`			varchar (255), 
	`cuisine`			varchar (255)
);

-- CREATE INDEXES ...
ALTER TABLE `TABLE_28` ADD INDEX `Code` (`Code`);
ALTER TABLE `TABLE_28` ADD PRIMARY KEY (`ID`);




-- ----------------------------------------------------------
-- MDB Tools - A library for reading MS Access database files
-- Copyright (C) 2000-2011 Brian Bruns and others.
-- Files in libmdb are licensed under LGPL and the utilities under
-- the GPL, see COPYING.LIB and COPYING files respectively.
-- Check out http://mdbtools.sourceforge.net
-- ----------------------------------------------------------

-- That file uses encoding UTF-8

CREATE TABLE `TABLE_29`
 (
	`ID`			int NOT NULL AUTO_INCREMENT UNIQUE, 
	`Ticket`			varchar (255), 
	`Dates`			datetime, 
	`Heure`			varchar (255), 
	`ID_ARTICLE`			varchar (255), 
	`Code`			varchar (255), 
	`Article`			varchar (255), 
	`Famille`			varchar (255), 
	`PRIX_A`			double, 
	`PRIX_MP`			double, 
	`PRIX_V`			double, 
	`Qté`			double, 
	`Remise`			double, 
	`TOTAL_NET`			double, 
	`Caissier`			varchar (255), 
	`Vendeur`			varchar (255), 
	`TAUX_TVA`			double, 
	`PRINTER`			varchar (255), 
	`PRINTER_DUPLICATA`			varchar (255), 
	`cuisine`			varchar (255)
);

-- CREATE INDEXES ...
ALTER TABLE `TABLE_29` ADD INDEX `Code` (`Code`);
ALTER TABLE `TABLE_29` ADD PRIMARY KEY (`ID`);




-- ----------------------------------------------------------
-- MDB Tools - A library for reading MS Access database files
-- Copyright (C) 2000-2011 Brian Bruns and others.
-- Files in libmdb are licensed under LGPL and the utilities under
-- the GPL, see COPYING.LIB and COPYING files respectively.
-- Check out http://mdbtools.sourceforge.net
-- ----------------------------------------------------------

-- That file uses encoding UTF-8

CREATE TABLE `TABLE_30`
 (
	`ID`			int NOT NULL AUTO_INCREMENT UNIQUE, 
	`Ticket`			varchar (255), 
	`Dates`			datetime, 
	`Heure`			varchar (255), 
	`ID_ARTICLE`			varchar (255), 
	`Code`			varchar (255), 
	`Article`			varchar (255), 
	`Famille`			varchar (255), 
	`PRIX_A`			double, 
	`PRIX_MP`			double, 
	`PRIX_V`			double, 
	`Qté`			double, 
	`Remise`			double, 
	`TOTAL_NET`			double, 
	`Caissier`			varchar (255), 
	`Vendeur`			varchar (255), 
	`TAUX_TVA`			double, 
	`PRINTER`			varchar (255), 
	`PRINTER_DUPLICATA`			varchar (255), 
	`cuisine`			varchar (255)
);

-- CREATE INDEXES ...
ALTER TABLE `TABLE_30` ADD INDEX `Code` (`Code`);
ALTER TABLE `TABLE_30` ADD PRIMARY KEY (`ID`);




-- ----------------------------------------------------------
-- MDB Tools - A library for reading MS Access database files
-- Copyright (C) 2000-2011 Brian Bruns and others.
-- Files in libmdb are licensed under LGPL and the utilities under
-- the GPL, see COPYING.LIB and COPYING files respectively.
-- Check out http://mdbtools.sourceforge.net
-- ----------------------------------------------------------

-- That file uses encoding UTF-8

CREATE TABLE `TABLE_31`
 (
	`ID`			int NOT NULL AUTO_INCREMENT UNIQUE, 
	`Ticket`			varchar (255), 
	`Dates`			datetime, 
	`Heure`			varchar (255), 
	`ID_ARTICLE`			varchar (255), 
	`Code`			varchar (255), 
	`Article`			varchar (255), 
	`Famille`			varchar (255), 
	`PRIX_A`			double, 
	`PRIX_MP`			double, 
	`PRIX_V`			double, 
	`Qté`			double, 
	`Remise`			double, 
	`TOTAL_NET`			double, 
	`Caissier`			varchar (255), 
	`Vendeur`			varchar (255), 
	`TAUX_TVA`			double, 
	`PRINTER`			varchar (255), 
	`PRINTER_DUPLICATA`			varchar (255), 
	`cuisine`			varchar (255)
);

-- CREATE INDEXES ...
ALTER TABLE `TABLE_31` ADD INDEX `Code` (`Code`);
ALTER TABLE `TABLE_31` ADD PRIMARY KEY (`ID`);




-- ----------------------------------------------------------
-- MDB Tools - A library for reading MS Access database files
-- Copyright (C) 2000-2011 Brian Bruns and others.
-- Files in libmdb are licensed under LGPL and the utilities under
-- the GPL, see COPYING.LIB and COPYING files respectively.
-- Check out http://mdbtools.sourceforge.net
-- ----------------------------------------------------------

-- That file uses encoding UTF-8

CREATE TABLE `TABLE_32`
 (
	`ID`			int NOT NULL AUTO_INCREMENT UNIQUE, 
	`Ticket`			varchar (255), 
	`Dates`			datetime, 
	`Heure`			varchar (255), 
	`ID_ARTICLE`			varchar (255), 
	`Code`			varchar (255), 
	`Article`			varchar (255), 
	`Famille`			varchar (255), 
	`PRIX_A`			double, 
	`PRIX_MP`			double, 
	`PRIX_V`			double, 
	`Qté`			double, 
	`Remise`			double, 
	`TOTAL_NET`			double, 
	`Caissier`			varchar (255), 
	`Vendeur`			varchar (255), 
	`TAUX_TVA`			double, 
	`PRINTER`			varchar (255), 
	`PRINTER_DUPLICATA`			varchar (255), 
	`cuisine`			varchar (255)
);

-- CREATE INDEXES ...
ALTER TABLE `TABLE_32` ADD INDEX `Code` (`Code`);
ALTER TABLE `TABLE_32` ADD PRIMARY KEY (`ID`);




-- ----------------------------------------------------------
-- MDB Tools - A library for reading MS Access database files
-- Copyright (C) 2000-2011 Brian Bruns and others.
-- Files in libmdb are licensed under LGPL and the utilities under
-- the GPL, see COPYING.LIB and COPYING files respectively.
-- Check out http://mdbtools.sourceforge.net
-- ----------------------------------------------------------

-- That file uses encoding UTF-8

CREATE TABLE `TABLE_34`
 (
	`ID`			int NOT NULL AUTO_INCREMENT UNIQUE, 
	`Ticket`			varchar (255), 
	`Dates`			datetime, 
	`Heure`			varchar (255), 
	`ID_ARTICLE`			varchar (255), 
	`Code`			varchar (255), 
	`Article`			varchar (255), 
	`Famille`			varchar (255), 
	`PRIX_A`			double, 
	`PRIX_MP`			double, 
	`PRIX_V`			double, 
	`Qté`			double, 
	`Remise`			double, 
	`TOTAL_NET`			double, 
	`Caissier`			varchar (255), 
	`Vendeur`			varchar (255), 
	`TAUX_TVA`			double, 
	`PRINTER`			varchar (255), 
	`PRINTER_DUPLICATA`			varchar (255), 
	`cuisine`			varchar (255)
);

-- CREATE INDEXES ...
ALTER TABLE `TABLE_34` ADD INDEX `Code` (`Code`);
ALTER TABLE `TABLE_34` ADD PRIMARY KEY (`ID`);




-- ----------------------------------------------------------
-- MDB Tools - A library for reading MS Access database files
-- Copyright (C) 2000-2011 Brian Bruns and others.
-- Files in libmdb are licensed under LGPL and the utilities under
-- the GPL, see COPYING.LIB and COPYING files respectively.
-- Check out http://mdbtools.sourceforge.net
-- ----------------------------------------------------------

-- That file uses encoding UTF-8

CREATE TABLE `TABLE_35`
 (
	`ID`			int NOT NULL AUTO_INCREMENT UNIQUE, 
	`Ticket`			varchar (255), 
	`Dates`			datetime, 
	`Heure`			varchar (255), 
	`ID_ARTICLE`			varchar (255), 
	`Code`			varchar (255), 
	`Article`			varchar (255), 
	`Famille`			varchar (255), 
	`PRIX_A`			double, 
	`PRIX_MP`			double, 
	`PRIX_V`			double, 
	`Qté`			double, 
	`Remise`			double, 
	`TOTAL_NET`			double, 
	`Caissier`			varchar (255), 
	`Vendeur`			varchar (255), 
	`TAUX_TVA`			double, 
	`PRINTER`			varchar (255), 
	`PRINTER_DUPLICATA`			varchar (255), 
	`cuisine`			varchar (255)
);

-- CREATE INDEXES ...
ALTER TABLE `TABLE_35` ADD INDEX `Code` (`Code`);
ALTER TABLE `TABLE_35` ADD PRIMARY KEY (`ID`);




-- ----------------------------------------------------------
-- MDB Tools - A library for reading MS Access database files
-- Copyright (C) 2000-2011 Brian Bruns and others.
-- Files in libmdb are licensed under LGPL and the utilities under
-- the GPL, see COPYING.LIB and COPYING files respectively.
-- Check out http://mdbtools.sourceforge.net
-- ----------------------------------------------------------

-- That file uses encoding UTF-8

CREATE TABLE `TABLE_36`
 (
	`ID`			int NOT NULL AUTO_INCREMENT UNIQUE, 
	`Ticket`			varchar (255), 
	`Dates`			datetime, 
	`Heure`			varchar (255), 
	`ID_ARTICLE`			varchar (255), 
	`Code`			varchar (255), 
	`Article`			varchar (255), 
	`Famille`			varchar (255), 
	`PRIX_A`			double, 
	`PRIX_MP`			double, 
	`PRIX_V`			double, 
	`Qté`			double, 
	`Remise`			double, 
	`TOTAL_NET`			double, 
	`Caissier`			varchar (255), 
	`Vendeur`			varchar (255), 
	`TAUX_TVA`			double, 
	`PRINTER`			varchar (255), 
	`PRINTER_DUPLICATA`			varchar (255), 
	`cuisine`			varchar (255)
);

-- CREATE INDEXES ...
ALTER TABLE `TABLE_36` ADD INDEX `Code` (`Code`);
ALTER TABLE `TABLE_36` ADD PRIMARY KEY (`ID`);




-- ----------------------------------------------------------
-- MDB Tools - A library for reading MS Access database files
-- Copyright (C) 2000-2011 Brian Bruns and others.
-- Files in libmdb are licensed under LGPL and the utilities under
-- the GPL, see COPYING.LIB and COPYING files respectively.
-- Check out http://mdbtools.sourceforge.net
-- ----------------------------------------------------------

-- That file uses encoding UTF-8

CREATE TABLE `TABLE_37`
 (
	`ID`			int NOT NULL AUTO_INCREMENT UNIQUE, 
	`Ticket`			varchar (255), 
	`Dates`			datetime, 
	`Heure`			varchar (255), 
	`ID_ARTICLE`			varchar (255), 
	`Code`			varchar (255), 
	`Article`			varchar (255), 
	`Famille`			varchar (255), 
	`PRIX_A`			double, 
	`PRIX_MP`			double, 
	`PRIX_V`			double, 
	`Qté`			double, 
	`Remise`			double, 
	`TOTAL_NET`			double, 
	`Caissier`			varchar (255), 
	`Vendeur`			varchar (255), 
	`TAUX_TVA`			double, 
	`PRINTER`			varchar (255), 
	`PRINTER_DUPLICATA`			varchar (255), 
	`cuisine`			varchar (255)
);

-- CREATE INDEXES ...
ALTER TABLE `TABLE_37` ADD INDEX `Code` (`Code`);
ALTER TABLE `TABLE_37` ADD PRIMARY KEY (`ID`);




-- ----------------------------------------------------------
-- MDB Tools - A library for reading MS Access database files
-- Copyright (C) 2000-2011 Brian Bruns and others.
-- Files in libmdb are licensed under LGPL and the utilities under
-- the GPL, see COPYING.LIB and COPYING files respectively.
-- Check out http://mdbtools.sourceforge.net
-- ----------------------------------------------------------

-- That file uses encoding UTF-8

CREATE TABLE `TABLE_38`
 (
	`ID`			int NOT NULL AUTO_INCREMENT UNIQUE, 
	`Ticket`			varchar (255), 
	`Dates`			datetime, 
	`Heure`			varchar (255), 
	`ID_ARTICLE`			varchar (255), 
	`Code`			varchar (255), 
	`Article`			varchar (255), 
	`Famille`			varchar (255), 
	`PRIX_A`			double, 
	`PRIX_MP`			double, 
	`PRIX_V`			double, 
	`Qté`			double, 
	`Remise`			double, 
	`TOTAL_NET`			double, 
	`Caissier`			varchar (255), 
	`Vendeur`			varchar (255), 
	`TAUX_TVA`			double, 
	`PRINTER`			varchar (255), 
	`PRINTER_DUPLICATA`			varchar (255), 
	`cuisine`			varchar (255)
);

-- CREATE INDEXES ...
ALTER TABLE `TABLE_38` ADD INDEX `Code` (`Code`);

ALTER TABLE `TABLE_38` ADD PRIMARY KEY (`ID`);




-- ----------------------------------------------------------
-- MDB Tools - A library for reading MS Access database files
-- Copyright (C) 2000-2011 Brian Bruns and others.
-- Files in libmdb are licensed under LGPL and the utilities under
-- the GPL, see COPYING.LIB and COPYING files respectively.
-- Check out http://mdbtools.sourceforge.net
-- ----------------------------------------------------------

-- That file uses encoding UTF-8

CREATE TABLE `TABLE_40`
 (
	`ID`			int NOT NULL AUTO_INCREMENT UNIQUE, 
	`Ticket`			varchar (255), 
	`Dates`			datetime, 
	`Heure`			varchar (255), 
	`ID_ARTICLE`			varchar (255), 
	`Code`			varchar (255), 
	`Article`			varchar (255), 
	`Famille`			varchar (255), 
	`PRIX_A`			double, 
	`PRIX_MP`			double, 
	`PRIX_V`			double, 
	`Qté`			double, 
	`Remise`			double, 
	`TOTAL_NET`			double, 
	`Caissier`			varchar (255), 
	`Vendeur`			varchar (255), 
	`TAUX_TVA`			double, 
	`PRINTER`			varchar (255), 
	`PRINTER_DUPLICATA`			varchar (255), 
	`cuisine`			varchar (255)
);

-- CREATE INDEXES ...
ALTER TABLE `TABLE_40` ADD INDEX `Code` (`Code`);
ALTER TABLE `TABLE_40` ADD PRIMARY KEY (`ID`);




-- ----------------------------------------------------------
-- MDB Tools - A library for reading MS Access database files
-- Copyright (C) 2000-2011 Brian Bruns and others.
-- Files in libmdb are licensed under LGPL and the utilities under
-- the GPL, see COPYING.LIB and COPYING files respectively.
-- Check out http://mdbtools.sourceforge.net
-- ----------------------------------------------------------

-- That file uses encoding UTF-8

CREATE TABLE `TABLE_41`
 (
	`ID`			int NOT NULL AUTO_INCREMENT UNIQUE, 
	`Ticket`			varchar (255), 
	`Dates`			datetime, 
	`Heure`			varchar (255), 
	`ID_ARTICLE`			varchar (255), 
	`Code`			varchar (255), 
	`Article`			varchar (255), 
	`Famille`			varchar (255), 
	`PRIX_A`			double, 
	`PRIX_MP`			double, 
	`PRIX_V`			double, 
	`Qté`			double, 
	`Remise`			double, 
	`TOTAL_NET`			double, 
	`Caissier`			varchar (255), 
	`Vendeur`			varchar (255), 
	`TAUX_TVA`			double, 
	`PRINTER`			varchar (255), 
	`PRINTER_DUPLICATA`			varchar (255), 
	`cuisine`			varchar (255)
);

-- CREATE INDEXES ...
ALTER TABLE `TABLE_41` ADD INDEX `Code` (`Code`);
ALTER TABLE `TABLE_41` ADD PRIMARY KEY (`ID`);




-- ----------------------------------------------------------
-- MDB Tools - A library for reading MS Access database files
-- Copyright (C) 2000-2011 Brian Bruns and others.
-- Files in libmdb are licensed under LGPL and the utilities under
-- the GPL, see COPYING.LIB and COPYING files respectively.
-- Check out http://mdbtools.sourceforge.net
-- ----------------------------------------------------------

-- That file uses encoding UTF-8

CREATE TABLE `TABLE_42`
 (
	`ID`			int NOT NULL AUTO_INCREMENT UNIQUE, 
	`Ticket`			varchar (255), 
	`Dates`			datetime, 
	`Heure`			varchar (255), 
	`ID_ARTICLE`			varchar (255), 
	`Code`			varchar (255), 
	`Article`			varchar (255), 
	`Famille`			varchar (255), 
	`PRIX_A`			double, 
	`PRIX_MP`			double, 
	`PRIX_V`			double, 
	`Qté`			double, 
	`Remise`			double, 
	`TOTAL_NET`			double, 
	`Caissier`			varchar (255), 
	`Vendeur`			varchar (255), 
	`TAUX_TVA`			double, 
	`PRINTER`			varchar (255), 
	`PRINTER_DUPLICATA`			varchar (255), 
	`cuisine`			varchar (255)
);

-- CREATE INDEXES ...
ALTER TABLE `TABLE_42` ADD INDEX `Code` (`Code`);
ALTER TABLE `TABLE_42` ADD PRIMARY KEY (`ID`);




-- ----------------------------------------------------------
-- MDB Tools - A library for reading MS Access database files
-- Copyright (C) 2000-2011 Brian Bruns and others.
-- Files in libmdb are licensed under LGPL and the utilities under
-- the GPL, see COPYING.LIB and COPYING files respectively.
-- Check out http://mdbtools.sourceforge.net
-- ----------------------------------------------------------

-- That file uses encoding UTF-8

CREATE TABLE `TABLE_43`
 (
	`ID`			int NOT NULL AUTO_INCREMENT UNIQUE, 
	`Ticket`			varchar (255), 
	`Dates`			datetime, 
	`Heure`			varchar (255), 
	`ID_ARTICLE`			varchar (255), 
	`Code`			varchar (255), 
	`Article`			varchar (255), 
	`Famille`			varchar (255), 
	`PRIX_A`			double, 
	`PRIX_MP`			double, 
	`PRIX_V`			double, 
	`Qté`			double, 
	`Remise`			double, 
	`TOTAL_NET`			double, 
	`Caissier`			varchar (255), 
	`Vendeur`			varchar (255), 
	`TAUX_TVA`			double, 
	`PRINTER`			varchar (255), 
	`PRINTER_DUPLICATA`			varchar (255), 
	`cuisine`			varchar (255)
);

-- CREATE INDEXES ...
ALTER TABLE `TABLE_43` ADD INDEX `Code` (`Code`);
ALTER TABLE `TABLE_43` ADD PRIMARY KEY (`ID`);




-- ----------------------------------------------------------
-- MDB Tools - A library for reading MS Access database files
-- Copyright (C) 2000-2011 Brian Bruns and others.
-- Files in libmdb are licensed under LGPL and the utilities under
-- the GPL, see COPYING.LIB and COPYING files respectively.
-- Check out http://mdbtools.sourceforge.net
-- ----------------------------------------------------------

-- That file uses encoding UTF-8

CREATE TABLE `TABLE_44`
 (
	`ID`			int NOT NULL AUTO_INCREMENT UNIQUE, 
	`Ticket`			varchar (255), 
	`Dates`			datetime, 
	`Heure`			varchar (255), 
	`ID_ARTICLE`			varchar (255), 
	`Code`			varchar (255), 
	`Article`			varchar (255), 
	`Famille`			varchar (255), 
	`PRIX_A`			double, 
	`PRIX_MP`			double, 
	`PRIX_V`			double, 
	`Qté`			double, 
	`Remise`			double, 
	`TOTAL_NET`			double, 
	`Caissier`			varchar (255), 
	`Vendeur`			varchar (255), 
	`TAUX_TVA`			double, 
	`PRINTER`			varchar (255), 
	`PRINTER_DUPLICATA`			varchar (255), 
	`cuisine`			varchar (255)
);

-- CREATE INDEXES ...
ALTER TABLE `TABLE_44` ADD INDEX `Code` (`Code`);
ALTER TABLE `TABLE_44` ADD PRIMARY KEY (`ID`);




-- ----------------------------------------------------------
-- MDB Tools - A library for reading MS Access database files
-- Copyright (C) 2000-2011 Brian Bruns and others.
-- Files in libmdb are licensed under LGPL and the utilities under
-- the GPL, see COPYING.LIB and COPYING files respectively.
-- Check out http://mdbtools.sourceforge.net
-- ----------------------------------------------------------

-- That file uses encoding UTF-8

CREATE TABLE `TABLE_46`
 (
	`ID`			int NOT NULL AUTO_INCREMENT UNIQUE, 
	`Ticket`			varchar (255), 
	`Dates`			datetime, 
	`Heure`			varchar (255), 
	`ID_ARTICLE`			varchar (255), 
	`Code`			varchar (255), 
	`Article`			varchar (255), 
	`Famille`			varchar (255), 
	`PRIX_A`			double, 
	`PRIX_MP`			double, 
	`PRIX_V`			double, 
	`Qté`			double, 
	`Remise`			double, 
	`TOTAL_NET`			double, 
	`Caissier`			varchar (255), 
	`Vendeur`			varchar (255), 
	`TAUX_TVA`			double, 
	`PRINTER`			varchar (255), 
	`PRINTER_DUPLICATA`			varchar (255), 
	`cuisine`			varchar (255)
);

-- CREATE INDEXES ...
ALTER TABLE `TABLE_46` ADD INDEX `Code` (`Code`);
ALTER TABLE `TABLE_46` ADD PRIMARY KEY (`ID`);




-- ----------------------------------------------------------
-- MDB Tools - A library for reading MS Access database files
-- Copyright (C) 2000-2011 Brian Bruns and others.
-- Files in libmdb are licensed under LGPL and the utilities under
-- the GPL, see COPYING.LIB and COPYING files respectively.
-- Check out http://mdbtools.sourceforge.net
-- ----------------------------------------------------------

-- That file uses encoding UTF-8

CREATE TABLE `TABLE_47`
 (
	`ID`			int NOT NULL AUTO_INCREMENT UNIQUE, 
	`Ticket`			varchar (255), 
	`Dates`			datetime, 
	`Heure`			varchar (255), 
	`ID_ARTICLE`			varchar (255), 
	`Code`			varchar (255), 
	`Article`			varchar (255), 
	`Famille`			varchar (255), 
	`PRIX_A`			double, 
	`PRIX_MP`			double, 
	`PRIX_V`			double, 
	`Qté`			double, 
	`Remise`			double, 
	`TOTAL_NET`			double, 
	`Caissier`			varchar (255), 
	`Vendeur`			varchar (255), 
	`TAUX_TVA`			double, 
	`PRINTER`			varchar (255), 
	`PRINTER_DUPLICATA`			varchar (255), 
	`cuisine`			varchar (255)
);

-- CREATE INDEXES ...
ALTER TABLE `TABLE_47` ADD INDEX `Code` (`Code`);
ALTER TABLE `TABLE_47` ADD PRIMARY KEY (`ID`);




-- ----------------------------------------------------------
-- MDB Tools - A library for reading MS Access database files
-- Copyright (C) 2000-2011 Brian Bruns and others.
-- Files in libmdb are licensed under LGPL and the utilities under
-- the GPL, see COPYING.LIB and COPYING files respectively.
-- Check out http://mdbtools.sourceforge.net
-- ----------------------------------------------------------

-- That file uses encoding UTF-8

CREATE TABLE `TABLE_48`
 (
	`ID`			int NOT NULL AUTO_INCREMENT UNIQUE, 
	`Ticket`			varchar (255), 
	`Dates`			datetime, 
	`Heure`			varchar (255), 
	`ID_ARTICLE`			varchar (255), 
	`Code`			varchar (255), 
	`Article`			varchar (255), 
	`Famille`			varchar (255), 
	`PRIX_A`			double, 
	`PRIX_MP`			double, 
	`PRIX_V`			double, 
	`Qté`			double, 
	`Remise`			double, 
	`TOTAL_NET`			double, 
	`Caissier`			varchar (255), 
	`Vendeur`			varchar (255), 
	`TAUX_TVA`			double, 
	`PRINTER`			varchar (255), 
	`PRINTER_DUPLICATA`			varchar (255), 
	`cuisine`			varchar (255)
);

-- CREATE INDEXES ...
ALTER TABLE `TABLE_48` ADD INDEX `Code` (`Code`);
ALTER TABLE `TABLE_48` ADD PRIMARY KEY (`ID`);




-- ----------------------------------------------------------
-- MDB Tools - A library for reading MS Access database files
-- Copyright (C) 2000-2011 Brian Bruns and others.
-- Files in libmdb are licensed under LGPL and the utilities under
-- the GPL, see COPYING.LIB and COPYING files respectively.
-- Check out http://mdbtools.sourceforge.net
-- ----------------------------------------------------------

-- That file uses encoding UTF-8

CREATE TABLE `TABLE_49`
 (
	`ID`			int NOT NULL AUTO_INCREMENT UNIQUE, 
	`Ticket`			varchar (255), 
	`Dates`			datetime, 
	`Heure`			varchar (255), 
	`ID_ARTICLE`			varchar (255), 
	`Code`			varchar (255), 
	`Article`			varchar (255), 
	`Famille`			varchar (255), 
	`PRIX_A`			double, 
	`PRIX_MP`			double, 
	`PRIX_V`			double, 
	`Qté`			double, 
	`Remise`			double, 
	`TOTAL_NET`			double, 
	`Caissier`			varchar (255), 
	`Vendeur`			varchar (255), 
	`TAUX_TVA`			double, 
	`PRINTER`			varchar (255), 
	`PRINTER_DUPLICATA`			varchar (255), 
	`cuisine`			varchar (255)
);

-- CREATE INDEXES ...
ALTER TABLE `TABLE_49` ADD INDEX `Code` (`Code`);
ALTER TABLE `TABLE_49` ADD PRIMARY KEY (`ID`);




-- ----------------------------------------------------------
-- MDB Tools - A library for reading MS Access database files
-- Copyright (C) 2000-2011 Brian Bruns and others.
-- Files in libmdb are licensed under LGPL and the utilities under
-- the GPL, see COPYING.LIB and COPYING files respectively.
-- Check out http://mdbtools.sourceforge.net
-- ----------------------------------------------------------

-- That file uses encoding UTF-8

CREATE TABLE `TABLE_50`
 (
	`ID`			int NOT NULL AUTO_INCREMENT UNIQUE, 
	`Ticket`			varchar (255), 
	`Dates`			datetime, 
	`Heure`			varchar (255), 
	`ID_ARTICLE`			varchar (255), 
	`Code`			varchar (255), 
	`Article`			varchar (255), 
	`Famille`			varchar (255), 
	`PRIX_A`			double, 
	`PRIX_MP`			double, 
	`PRIX_V`			double, 
	`Qté`			double, 
	`Remise`			double, 
	`TOTAL_NET`			double, 
	`Caissier`			varchar (255), 
	`Vendeur`			varchar (255), 
	`TAUX_TVA`			double, 
	`PRINTER`			varchar (255), 
	`PRINTER_DUPLICATA`			varchar (255), 
	`cuisine`			varchar (255)
);

-- CREATE INDEXES ...
ALTER TABLE `TABLE_50` ADD INDEX `Code` (`Code`);
ALTER TABLE `TABLE_50` ADD PRIMARY KEY (`ID`);




-- ----------------------------------------------------------
-- MDB Tools - A library for reading MS Access database files
-- Copyright (C) 2000-2011 Brian Bruns and others.
-- Files in libmdb are licensed under LGPL and the utilities under
-- the GPL, see COPYING.LIB and COPYING files respectively.
-- Check out http://mdbtools.sourceforge.net
-- ----------------------------------------------------------

-- That file uses encoding UTF-8

CREATE TABLE `TABLE_52`
 (
	`ID`			int NOT NULL AUTO_INCREMENT UNIQUE, 
	`Ticket`			varchar (255), 
	`Dates`			datetime, 
	`Heure`			varchar (255), 
	`ID_ARTICLE`			varchar (255), 
	`Code`			varchar (255), 
	`Article`			varchar (255), 
	`Famille`			varchar (255), 
	`PRIX_A`			double, 
	`PRIX_MP`			double, 
	`PRIX_V`			double, 
	`Qté`			double, 
	`Remise`			double, 
	`TOTAL_NET`			double, 
	`Caissier`			varchar (255), 
	`Vendeur`			varchar (255), 
	`TAUX_TVA`			double, 
	`PRINTER`			varchar (255), 
	`PRINTER_DUPLICATA`			varchar (255), 
	`cuisine`			varchar (255)
);

-- CREATE INDEXES ...
ALTER TABLE `TABLE_52` ADD INDEX `Code` (`Code`);
ALTER TABLE `TABLE_52` ADD PRIMARY KEY (`ID`);




-- ----------------------------------------------------------
-- MDB Tools - A library for reading MS Access database files
-- Copyright (C) 2000-2011 Brian Bruns and others.
-- Files in libmdb are licensed under LGPL and the utilities under
-- the GPL, see COPYING.LIB and COPYING files respectively.
-- Check out http://mdbtools.sourceforge.net
-- ----------------------------------------------------------

-- That file uses encoding UTF-8

CREATE TABLE `TABLE_53`
 (
	`ID`			int NOT NULL AUTO_INCREMENT UNIQUE, 
	`Ticket`			varchar (255), 
	`Dates`			datetime, 
	`Heure`			varchar (255), 
	`ID_ARTICLE`			varchar (255), 
	`Code`			varchar (255), 
	`Article`			varchar (255), 
	`Famille`			varchar (255), 
	`PRIX_A`			double, 
	`PRIX_MP`			double, 
	`PRIX_V`			double, 
	`Qté`			double, 
	`Remise`			double, 
	`TOTAL_NET`			double, 
	`Caissier`			varchar (255), 
	`Vendeur`			varchar (255), 
	`TAUX_TVA`			double, 
	`PRINTER`			varchar (255), 
	`PRINTER_DUPLICATA`			varchar (255), 
	`cuisine`			varchar (255)
);

-- CREATE INDEXES ...
ALTER TABLE `TABLE_53` ADD INDEX `Code` (`Code`);
ALTER TABLE `TABLE_53` ADD PRIMARY KEY (`ID`);




-- ----------------------------------------------------------
-- MDB Tools - A library for reading MS Access database files
-- Copyright (C) 2000-2011 Brian Bruns and others.
-- Files in libmdb are licensed under LGPL and the utilities under
-- the GPL, see COPYING.LIB and COPYING files respectively.
-- Check out http://mdbtools.sourceforge.net
-- ----------------------------------------------------------

-- That file uses encoding UTF-8

CREATE TABLE `TABLE_54`
 (
	`ID`			int NOT NULL AUTO_INCREMENT UNIQUE, 
	`Ticket`			varchar (255), 
	`Dates`			datetime, 
	`Heure`			varchar (255), 
	`ID_ARTICLE`			varchar (255), 
	`Code`			varchar (255), 
	`Article`			varchar (255), 
	`Famille`			varchar (255), 
	`PRIX_A`			double, 
	`PRIX_MP`			double, 
	`PRIX_V`			double, 
	`Qté`			double, 
	`Remise`			double, 
	`TOTAL_NET`			double, 
	`Caissier`			varchar (255), 
	`Vendeur`			varchar (255), 
	`TAUX_TVA`			double, 
	`PRINTER`			varchar (255), 
	`PRINTER_DUPLICATA`			varchar (255), 
	`cuisine`			varchar (255)
);

-- CREATE INDEXES ...
ALTER TABLE `TABLE_54` ADD INDEX `Code` (`Code`);
ALTER TABLE `TABLE_54` ADD PRIMARY KEY (`ID`);




-- ----------------------------------------------------------
-- MDB Tools - A library for reading MS Access database files
-- Copyright (C) 2000-2011 Brian Bruns and others.
-- Files in libmdb are licensed under LGPL and the utilities under
-- the GPL, see COPYING.LIB and COPYING files respectively.
-- Check out http://mdbtools.sourceforge.net
-- ----------------------------------------------------------

-- That file uses encoding UTF-8

CREATE TABLE `TABLE_55`
 (
	`ID`			int NOT NULL AUTO_INCREMENT UNIQUE, 
	`Ticket`			varchar (255), 
	`Dates`			datetime, 
	`Heure`			varchar (255), 
	`ID_ARTICLE`			varchar (255), 
	`Code`			varchar (255), 
	`Article`			varchar (255), 
	`Famille`			varchar (255), 
	`PRIX_A`			double, 
	`PRIX_MP`			double, 
	`PRIX_V`			double, 
	`Qté`			double, 
	`Remise`			double, 
	`TOTAL_NET`			double, 
	`Caissier`			varchar (255), 
	`Vendeur`			varchar (255), 
	`TAUX_TVA`			double, 
	`PRINTER`			varchar (255), 
	`PRINTER_DUPLICATA`			varchar (255), 
	`cuisine`			varchar (255)
);

-- CREATE INDEXES ...
ALTER TABLE `TABLE_55` ADD INDEX `Code` (`Code`);
ALTER TABLE `TABLE_55` ADD PRIMARY KEY (`ID`);




-- ----------------------------------------------------------
-- MDB Tools - A library for reading MS Access database files
-- Copyright (C) 2000-2011 Brian Bruns and others.
-- Files in libmdb are licensed under LGPL and the utilities under
-- the GPL, see COPYING.LIB and COPYING files respectively.
-- Check out http://mdbtools.sourceforge.net
-- ----------------------------------------------------------

-- That file uses encoding UTF-8

CREATE TABLE `TABLE_56`
 (
	`ID`			int NOT NULL AUTO_INCREMENT UNIQUE, 
	`Ticket`			varchar (255), 
	`Dates`			datetime, 
	`Heure`			varchar (255), 
	`ID_ARTICLE`			varchar (255), 
	`Code`			varchar (255), 
	`Article`			varchar (255), 
	`Famille`			varchar (255), 
	`PRIX_A`			double, 
	`PRIX_MP`			double, 
	`PRIX_V`			double, 
	`Qté`			double, 
	`Remise`			double, 
	`TOTAL_NET`			double, 
	`Caissier`			varchar (255), 
	`Vendeur`			varchar (255), 
	`TAUX_TVA`			double, 
	`PRINTER`			varchar (255), 
	`PRINTER_DUPLICATA`			varchar (255), 
	`cuisine`			varchar (255)
);

-- CREATE INDEXES ...
ALTER TABLE `TABLE_56` ADD INDEX `Code` (`Code`);
ALTER TABLE `TABLE_56` ADD PRIMARY KEY (`ID`);




-- ----------------------------------------------------------
-- MDB Tools - A library for reading MS Access database files
-- Copyright (C) 2000-2011 Brian Bruns and others.
-- Files in libmdb are licensed under LGPL and the utilities under
-- the GPL, see COPYING.LIB and COPYING files respectively.
-- Check out http://mdbtools.sourceforge.net
-- ----------------------------------------------------------

-- That file uses encoding UTF-8

CREATE TABLE `TABLE_57`
 (
	`ID`			int NOT NULL AUTO_INCREMENT UNIQUE, 
	`Ticket`			varchar (255), 
	`Dates`			datetime, 
	`Heure`			varchar (255), 
	`ID_ARTICLE`			varchar (255), 
	`Code`			varchar (255), 
	`Article`			varchar (255), 
	`Famille`			varchar (255), 
	`PRIX_A`			double, 
	`PRIX_MP`			double, 
	`PRIX_V`			double, 
	`Qté`			double, 
	`Remise`			double, 
	`TOTAL_NET`			double, 
	`Caissier`			varchar (255), 
	`Vendeur`			varchar (255), 
	`TAUX_TVA`			double, 
	`PRINTER`			varchar (255), 
	`PRINTER_DUPLICATA`			varchar (255), 
	`cuisine`			varchar (255)
);

-- CREATE INDEXES ...
ALTER TABLE `TABLE_57` ADD INDEX `Code` (`Code`);
ALTER TABLE `TABLE_57` ADD PRIMARY KEY (`ID`);




-- ----------------------------------------------------------
-- MDB Tools - A library for reading MS Access database files
-- Copyright (C) 2000-2011 Brian Bruns and others.
-- Files in libmdb are licensed under LGPL and the utilities under
-- the GPL, see COPYING.LIB and COPYING files respectively.
-- Check out http://mdbtools.sourceforge.net
-- ----------------------------------------------------------

-- That file uses encoding UTF-8

CREATE TABLE `TABLE_59`
 (
	`ID`			int NOT NULL AUTO_INCREMENT UNIQUE, 
	`Ticket`			varchar (255), 
	`Dates`			datetime, 
	`Heure`			varchar (255), 
	`ID_ARTICLE`			varchar (255), 
	`Code`			varchar (255), 
	`Article`			varchar (255), 
	`Famille`			varchar (255), 
	`PRIX_A`			double, 
	`PRIX_MP`			double, 
	`PRIX_V`			double, 
	`Qté`			double, 
	`Remise`			double, 
	`TOTAL_NET`			double, 
	`Caissier`			varchar (255), 
	`Vendeur`			varchar (255), 
	`TAUX_TVA`			double, 
	`PRINTER`			varchar (255), 
	`PRINTER_DUPLICATA`			varchar (255), 
	`cuisine`			varchar (255)
);

-- CREATE INDEXES ...
ALTER TABLE `TABLE_59` ADD INDEX `Code` (`Code`);
ALTER TABLE `TABLE_59` ADD PRIMARY KEY (`ID`);




-- ----------------------------------------------------------
-- MDB Tools - A library for reading MS Access database files
-- Copyright (C) 2000-2011 Brian Bruns and others.
-- Files in libmdb are licensed under LGPL and the utilities under
-- the GPL, see COPYING.LIB and COPYING files respectively.
-- Check out http://mdbtools.sourceforge.net
-- ----------------------------------------------------------

-- That file uses encoding UTF-8

CREATE TABLE `TABLE_60`
 (
	`ID`			int NOT NULL AUTO_INCREMENT UNIQUE, 
	`Ticket`			varchar (255), 
	`Dates`			datetime, 
	`Heure`			varchar (255), 
	`ID_ARTICLE`			varchar (255), 
	`Code`			varchar (255), 
	`Article`			varchar (255), 
	`Famille`			varchar (255), 
	`PRIX_A`			double, 
	`PRIX_MP`			double, 
	`PRIX_V`			double, 
	`Qté`			double, 
	`Remise`			double, 
	`TOTAL_NET`			double, 
	`Caissier`			varchar (255), 
	`Vendeur`			varchar (255), 
	`TAUX_TVA`			double, 
	`PRINTER`			varchar (255), 
	`PRINTER_DUPLICATA`			varchar (255), 
	`cuisine`			varchar (255)
);

-- CREATE INDEXES ...
ALTER TABLE `TABLE_60` ADD INDEX `Code` (`Code`);
ALTER TABLE `TABLE_60` ADD PRIMARY KEY (`ID`);




-- ----------------------------------------------------------
-- MDB Tools - A library for reading MS Access database files
-- Copyright (C) 2000-2011 Brian Bruns and others.
-- Files in libmdb are licensed under LGPL and the utilities under
-- the GPL, see COPYING.LIB and COPYING files respectively.
-- Check out http://mdbtools.sourceforge.net
-- ----------------------------------------------------------

-- That file uses encoding UTF-8

CREATE TABLE `TABLE_61`
 (
	`ID`			int NOT NULL AUTO_INCREMENT UNIQUE, 
	`Ticket`			varchar (255), 
	`Dates`			datetime, 
	`Heure`			varchar (255), 
	`ID_ARTICLE`			varchar (255), 
	`Code`			varchar (255), 
	`Article`			varchar (255), 
	`Famille`			varchar (255), 
	`PRIX_A`			double, 
	`PRIX_MP`			double, 
	`PRIX_V`			double, 
	`Qté`			double, 
	`Remise`			double, 
	`TOTAL_NET`			double, 
	`Caissier`			varchar (255), 
	`Vendeur`			varchar (255), 
	`TAUX_TVA`			double, 
	`PRINTER`			varchar (255), 
	`PRINTER_DUPLICATA`			varchar (255), 
	`cuisine`			varchar (255)
);

-- CREATE INDEXES ...
ALTER TABLE `TABLE_61` ADD INDEX `Code` (`Code`);
ALTER TABLE `TABLE_61` ADD PRIMARY KEY (`ID`);




-- ----------------------------------------------------------
-- MDB Tools - A library for reading MS Access database files
-- Copyright (C) 2000-2011 Brian Bruns and others.
-- Files in libmdb are licensed under LGPL and the utilities under
-- the GPL, see COPYING.LIB and COPYING files respectively.
-- Check out http://mdbtools.sourceforge.net
-- ----------------------------------------------------------

-- That file uses encoding UTF-8

CREATE TABLE `TABLE_62`
 (
	`ID`			int NOT NULL AUTO_INCREMENT UNIQUE, 
	`Ticket`			varchar (255), 
	`Dates`			datetime, 
	`Heure`			varchar (255), 
	`ID_ARTICLE`			varchar (255), 
	`Code`			varchar (255), 
	`Article`			varchar (255), 
	`Famille`			varchar (255), 
	`PRIX_A`			double, 
	`PRIX_MP`			double, 
	`PRIX_V`			double, 
	`Qté`			double, 
	`Remise`			double, 
	`TOTAL_NET`			double, 
	`Caissier`			varchar (255), 
	`Vendeur`			varchar (255), 
	`TAUX_TVA`			double, 
	`PRINTER`			varchar (255), 
	`PRINTER_DUPLICATA`			varchar (255), 
	`cuisine`			varchar (255)
);

-- CREATE INDEXES ...
ALTER TABLE `TABLE_62` ADD INDEX `Code` (`Code`);
ALTER TABLE `TABLE_62` ADD PRIMARY KEY (`ID`);




-- ----------------------------------------------------------
-- MDB Tools - A library for reading MS Access database files
-- Copyright (C) 2000-2011 Brian Bruns and others.
-- Files in libmdb are licensed under LGPL and the utilities under
-- the GPL, see COPYING.LIB and COPYING files respectively.
-- Check out http://mdbtools.sourceforge.net
-- ----------------------------------------------------------

-- That file uses encoding UTF-8

CREATE TABLE `TABLE_63`
 (
	`ID`			int NOT NULL AUTO_INCREMENT UNIQUE, 
	`Ticket`			varchar (255), 
	`Dates`			datetime, 
	`Heure`			varchar (255), 
	`ID_ARTICLE`			varchar (255), 
	`Code`			varchar (255), 
	`Article`			varchar (255), 
	`Famille`			varchar (255), 
	`PRIX_A`			double, 
	`PRIX_MP`			double, 
	`PRIX_V`			double, 
	`Qté`			double, 
	`Remise`			double, 
	`TOTAL_NET`			double, 
	`Caissier`			varchar (255), 
	`Vendeur`			varchar (255), 
	`TAUX_TVA`			double, 
	`PRINTER`			varchar (255), 
	`PRINTER_DUPLICATA`			varchar (255), 
	`cuisine`			varchar (255)
);

-- CREATE INDEXES ...
ALTER TABLE `TABLE_63` ADD INDEX `Code` (`Code`);
ALTER TABLE `TABLE_63` ADD PRIMARY KEY (`ID`);




-- ----------------------------------------------------------
-- MDB Tools - A library for reading MS Access database files
-- Copyright (C) 2000-2011 Brian Bruns and others.
-- Files in libmdb are licensed under LGPL and the utilities under
-- the GPL, see COPYING.LIB and COPYING files respectively.
-- Check out http://mdbtools.sourceforge.net
-- ----------------------------------------------------------

-- That file uses encoding UTF-8

CREATE TABLE `TABLE_65`
 (
	`ID`			int NOT NULL AUTO_INCREMENT UNIQUE, 
	`Ticket`			varchar (255), 
	`Dates`			datetime, 
	`Heure`			varchar (255), 
	`ID_ARTICLE`			varchar (255), 
	`Code`			varchar (255), 
	`Article`			varchar (255), 
	`Famille`			varchar (255), 
	`PRIX_A`			double, 
	`PRIX_MP`			double, 
	`PRIX_V`			double, 
	`Qté`			double, 
	`Remise`			double, 
	`TOTAL_NET`			double, 
	`Caissier`			varchar (255), 
	`Vendeur`			varchar (255), 
	`TAUX_TVA`			double, 
	`PRINTER`			varchar (255), 
	`PRINTER_DUPLICATA`			varchar (255), 
	`cuisine`			varchar (255)
);

-- CREATE INDEXES ...
ALTER TABLE `TABLE_65` ADD INDEX `Code` (`Code`);
ALTER TABLE `TABLE_65` ADD PRIMARY KEY (`ID`);




-- ----------------------------------------------------------
-- MDB Tools - A library for reading MS Access database files
-- Copyright (C) 2000-2011 Brian Bruns and others.
-- Files in libmdb are licensed under LGPL and the utilities under
-- the GPL, see COPYING.LIB and COPYING files respectively.
-- Check out http://mdbtools.sourceforge.net
-- ----------------------------------------------------------

-- That file uses encoding UTF-8

CREATE TABLE `TABLE_66`
 (
	`ID`			int NOT NULL AUTO_INCREMENT UNIQUE, 
	`Ticket`			varchar (255), 
	`Dates`			datetime, 
	`Heure`			varchar (255), 
	`ID_ARTICLE`			varchar (255), 
	`Code`			varchar (255), 
	`Article`			varchar (255), 
	`Famille`			varchar (255), 
	`PRIX_A`			double, 
	`PRIX_MP`			double, 
	`PRIX_V`			double, 
	`Qté`			double, 
	`Remise`			double, 
	`TOTAL_NET`			double, 
	`Caissier`			varchar (255), 
	`Vendeur`			varchar (255), 
	`TAUX_TVA`			double, 
	`PRINTER`			varchar (255), 
	`PRINTER_DUPLICATA`			varchar (255), 
	`cuisine`			varchar (255)
);

-- CREATE INDEXES ...
ALTER TABLE `TABLE_66` ADD INDEX `Code` (`Code`);
ALTER TABLE `TABLE_66` ADD PRIMARY KEY (`ID`);




-- ----------------------------------------------------------
-- MDB Tools - A library for reading MS Access database files
-- Copyright (C) 2000-2011 Brian Bruns and others.
-- Files in libmdb are licensed under LGPL and the utilities under
-- the GPL, see COPYING.LIB and COPYING files respectively.
-- Check out http://mdbtools.sourceforge.net
-- ----------------------------------------------------------

-- That file uses encoding UTF-8

CREATE TABLE `TABLE_67`
 (
	`ID`			int NOT NULL AUTO_INCREMENT UNIQUE, 
	`Ticket`			varchar (255), 
	`Dates`			datetime, 
	`Heure`			varchar (255), 
	`ID_ARTICLE`			varchar (255), 
	`Code`			varchar (255), 
	`Article`			varchar (255), 
	`Famille`			varchar (255), 
	`PRIX_A`			double, 
	`PRIX_MP`			double, 
	`PRIX_V`			double, 
	`Qté`			double, 
	`Remise`			double, 
	`TOTAL_NET`			double, 
	`Caissier`			varchar (255), 
	`Vendeur`			varchar (255), 
	`TAUX_TVA`			double, 
	`PRINTER`			varchar (255), 
	`PRINTER_DUPLICATA`			varchar (255), 
	`cuisine`			varchar (255)
);

-- CREATE INDEXES ...
ALTER TABLE `TABLE_67` ADD INDEX `Code` (`Code`);
ALTER TABLE `TABLE_67` ADD PRIMARY KEY (`ID`);




-- ----------------------------------------------------------
-- MDB Tools - A library for reading MS Access database files
-- Copyright (C) 2000-2011 Brian Bruns and others.
-- Files in libmdb are licensed under LGPL and the utilities under
-- the GPL, see COPYING.LIB and COPYING files respectively.
-- Check out http://mdbtools.sourceforge.net
-- ----------------------------------------------------------

-- That file uses encoding UTF-8

CREATE TABLE `TABLE_68`
 (
	`ID`			int NOT NULL AUTO_INCREMENT UNIQUE, 
	`Ticket`			varchar (255), 
	`Dates`			datetime, 
	`Heure`			varchar (255), 
	`ID_ARTICLE`			varchar (255), 
	`Code`			varchar (255), 
	`Article`			varchar (255), 
	`Famille`			varchar (255), 
	`PRIX_A`			double, 
	`PRIX_MP`			double, 
	`PRIX_V`			double, 
	`Qté`			double, 
	`Remise`			double, 
	`TOTAL_NET`			double, 
	`Caissier`			varchar (255), 
	`Vendeur`			varchar (255), 
	`TAUX_TVA`			double, 
	`PRINTER`			varchar (255), 
	`PRINTER_DUPLICATA`			varchar (255), 
	`cuisine`			varchar (255)
);

-- CREATE INDEXES ...
ALTER TABLE `TABLE_68` ADD INDEX `Code` (`Code`);
ALTER TABLE `TABLE_68` ADD PRIMARY KEY (`ID`);




-- ----------------------------------------------------------
-- MDB Tools - A library for reading MS Access database files
-- Copyright (C) 2000-2011 Brian Bruns and others.
-- Files in libmdb are licensed under LGPL and the utilities under
-- the GPL, see COPYING.LIB and COPYING files respectively.
-- Check out http://mdbtools.sourceforge.net
-- ----------------------------------------------------------

-- That file uses encoding UTF-8

CREATE TABLE `TABLE_69`
 (
	`ID`			int NOT NULL AUTO_INCREMENT UNIQUE, 
	`Ticket`			varchar (255), 
	`Dates`			datetime, 
	`Heure`			varchar (255), 
	`ID_ARTICLE`			varchar (255), 
	`Code`			varchar (255), 
	`Article`			varchar (255), 
	`Famille`			varchar (255), 
	`PRIX_A`			double, 
	`PRIX_MP`			double, 
	`PRIX_V`			double, 
	`Qté`			double, 
	`Remise`			double, 
	`TOTAL_NET`			double, 
	`Caissier`			varchar (255), 
	`Vendeur`			varchar (255), 
	`TAUX_TVA`			double, 
	`PRINTER`			varchar (255), 
	`PRINTER_DUPLICATA`			varchar (255), 
	`cuisine`			varchar (255)
);

-- CREATE INDEXES ...
ALTER TABLE `TABLE_69` ADD INDEX `Code` (`Code`);
ALTER TABLE `TABLE_69` ADD PRIMARY KEY (`ID`);




-- ----------------------------------------------------------
-- MDB Tools - A library for reading MS Access database files
-- Copyright (C) 2000-2011 Brian Bruns and others.
-- Files in libmdb are licensed under LGPL and the utilities under
-- the GPL, see COPYING.LIB and COPYING files respectively.
-- Check out http://mdbtools.sourceforge.net
-- ----------------------------------------------------------

-- That file uses encoding UTF-8

CREATE TABLE `TABLE_70`
 (
	`ID`			int NOT NULL AUTO_INCREMENT UNIQUE, 
	`Ticket`			varchar (255), 
	`Dates`			datetime, 
	`Heure`			varchar (255), 
	`ID_ARTICLE`			varchar (255), 
	`Code`			varchar (255), 
	`Article`			varchar (255), 
	`Famille`			varchar (255), 
	`PRIX_A`			double, 
	`PRIX_MP`			double, 
	`PRIX_V`			double, 
	`Qté`			double, 
	`Remise`			double, 
	`TOTAL_NET`			double, 
	`Caissier`			varchar (255), 
	`Vendeur`			varchar (255), 
	`TAUX_TVA`			double, 
	`PRINTER`			varchar (255), 
	`PRINTER_DUPLICATA`			varchar (255), 
	`cuisine`			varchar (255)
);

-- CREATE INDEXES ...
ALTER TABLE `TABLE_70` ADD INDEX `Code` (`Code`);
ALTER TABLE `TABLE_70` ADD PRIMARY KEY (`ID`);




-- ----------------------------------------------------------
-- MDB Tools - A library for reading MS Access database files
-- Copyright (C) 2000-2011 Brian Bruns and others.
-- Files in libmdb are licensed under LGPL and the utilities under
-- the GPL, see COPYING.LIB and COPYING files respectively.
-- Check out http://mdbtools.sourceforge.net
-- ----------------------------------------------------------

-- That file uses encoding UTF-8

CREATE TABLE `TABLE_71`
 (
	`ID`			int NOT NULL AUTO_INCREMENT UNIQUE, 
	`Ticket`			varchar (255), 
	`Dates`			datetime, 
	`Heure`			varchar (255), 
	`ID_ARTICLE`			varchar (255), 
	`Code`			varchar (255), 
	`Article`			varchar (255), 
	`Famille`			varchar (255), 
	`PRIX_A`			double, 
	`PRIX_MP`			double, 
	`PRIX_V`			double, 
	`Qté`			double, 
	`Remise`			double, 
	`TOTAL_NET`			double, 
	`Caissier`			varchar (255), 
	`Vendeur`			varchar (255), 
	`TAUX_TVA`			double, 
	`PRINTER`			varchar (255), 
	`PRINTER_DUPLICATA`			varchar (255), 
	`cuisine`			varchar (255)
);

-- CREATE INDEXES ...
ALTER TABLE `TABLE_71` ADD INDEX `Code` (`Code`);
ALTER TABLE `TABLE_71` ADD PRIMARY KEY (`ID`);




-- ----------------------------------------------------------
-- MDB Tools - A library for reading MS Access database files
-- Copyright (C) 2000-2011 Brian Bruns and others.
-- Files in libmdb are licensed under LGPL and the utilities under
-- the GPL, see COPYING.LIB and COPYING files respectively.
-- Check out http://mdbtools.sourceforge.net
-- ----------------------------------------------------------

-- That file uses encoding UTF-8

CREATE TABLE `TABLE_72`
 (
	`ID`			int NOT NULL AUTO_INCREMENT UNIQUE, 
	`Ticket`			varchar (255), 
	`Dates`			datetime, 
	`Heure`			varchar (255), 
	`ID_ARTICLE`			varchar (255), 
	`Code`			varchar (255), 
	`Article`			varchar (255), 
	`Famille`			varchar (255), 
	`PRIX_A`			double, 
	`PRIX_MP`			double, 
	`PRIX_V`			double, 
	`Qté`			double, 
	`Remise`			double, 
	`TOTAL_NET`			double, 
	`Caissier`			varchar (255), 
	`Vendeur`			varchar (255), 
	`TAUX_TVA`			double, 
	`PRINTER`			varchar (255), 
	`PRINTER_DUPLICATA`			varchar (255), 
	`cuisine`			varchar (255)
);

-- CREATE INDEXES ...
ALTER TABLE `TABLE_72` ADD INDEX `Code` (`Code`);
ALTER TABLE `TABLE_72` ADD PRIMARY KEY (`ID`);




-- ----------------------------------------------------------
-- MDB Tools - A library for reading MS Access database files
-- Copyright (C) 2000-2011 Brian Bruns and others.
-- Files in libmdb are licensed under LGPL and the utilities under
-- the GPL, see COPYING.LIB and COPYING files respectively.
-- Check out http://mdbtools.sourceforge.net
-- ----------------------------------------------------------

-- That file uses encoding UTF-8

CREATE TABLE `TABLE_73`
 (
	`ID`			int NOT NULL AUTO_INCREMENT UNIQUE, 
	`Ticket`			varchar (255), 
	`Dates`			datetime, 
	`Heure`			varchar (255), 
	`ID_ARTICLE`			varchar (255), 
	`Code`			varchar (255), 
	`Article`			varchar (255), 
	`Famille`			varchar (255), 
	`PRIX_A`			double, 
	`PRIX_MP`			double, 
	`PRIX_V`			double, 
	`Qté`			double, 
	`Remise`			double, 
	`TOTAL_NET`			double, 
	`Caissier`			varchar (255), 
	`Vendeur`			varchar (255), 
	`TAUX_TVA`			double, 
	`PRINTER`			varchar (255), 
	`PRINTER_DUPLICATA`			varchar (255), 
	`cuisine`			varchar (255)
);

-- CREATE INDEXES ...
ALTER TABLE `TABLE_73` ADD INDEX `Code` (`Code`);
ALTER TABLE `TABLE_73` ADD PRIMARY KEY (`ID`);




-- ----------------------------------------------------------
-- MDB Tools - A library for reading MS Access database files
-- Copyright (C) 2000-2011 Brian Bruns and others.
-- Files in libmdb are licensed under LGPL and the utilities under
-- the GPL, see COPYING.LIB and COPYING files respectively.
-- Check out http://mdbtools.sourceforge.net
-- ----------------------------------------------------------

-- That file uses encoding UTF-8

CREATE TABLE `TABLE_75`
 (
	`ID`			int NOT NULL AUTO_INCREMENT UNIQUE, 
	`Ticket`			varchar (255), 
	`Dates`			datetime, 
	`Heure`			varchar (255), 
	`ID_ARTICLE`			varchar (255), 
	`Code`			varchar (255), 
	`Article`			varchar (255), 
	`Famille`			varchar (255), 
	`PRIX_A`			double, 
	`PRIX_MP`			double, 
	`PRIX_V`			double, 
	`Qté`			double, 
	`Remise`			double, 
	`TOTAL_NET`			double, 
	`Caissier`			varchar (255), 
	`Vendeur`			varchar (255), 
	`TAUX_TVA`			double, 
	`PRINTER`			varchar (255), 
	`PRINTER_DUPLICATA`			varchar (255), 
	`cuisine`			varchar (255)
);

-- CREATE INDEXES ...
ALTER TABLE `TABLE_75` ADD INDEX `Code` (`Code`);
ALTER TABLE `TABLE_75` ADD PRIMARY KEY (`ID`);




-- ----------------------------------------------------------
-- MDB Tools - A library for reading MS Access database files
-- Copyright (C) 2000-2011 Brian Bruns and others.
-- Files in libmdb are licensed under LGPL and the utilities under
-- the GPL, see COPYING.LIB and COPYING files respectively.
-- Check out http://mdbtools.sourceforge.net
-- ----------------------------------------------------------

-- That file uses encoding UTF-8

CREATE TABLE `TABLE_76`
 (
	`ID`			int NOT NULL AUTO_INCREMENT UNIQUE, 
	`Ticket`			varchar (255), 
	`Dates`			datetime, 
	`Heure`			varchar (255), 
	`ID_ARTICLE`			varchar (255), 
	`Code`			varchar (255), 
	`Article`			varchar (255), 
	`Famille`			varchar (255), 
	`PRIX_A`			double, 
	`PRIX_MP`			double, 
	`PRIX_V`			double, 
	`Qté`			double, 
	`Remise`			double, 
	`TOTAL_NET`			double, 
	`Caissier`			varchar (255), 
	`Vendeur`			varchar (255), 
	`TAUX_TVA`			double, 
	`PRINTER`			varchar (255), 
	`PRINTER_DUPLICATA`			varchar (255), 
	`cuisine`			varchar (255)
);

-- CREATE INDEXES ...
ALTER TABLE `TABLE_76` ADD INDEX `Code` (`Code`);
ALTER TABLE `TABLE_76` ADD PRIMARY KEY (`ID`);




-- ----------------------------------------------------------
-- MDB Tools - A library for reading MS Access database files
-- Copyright (C) 2000-2011 Brian Bruns and others.
-- Files in libmdb are licensed under LGPL and the utilities under
-- the GPL, see COPYING.LIB and COPYING files respectively.
-- Check out http://mdbtools.sourceforge.net
-- ----------------------------------------------------------

-- That file uses encoding UTF-8

CREATE TABLE `TABLE_77`
 (
	`ID`			int NOT NULL AUTO_INCREMENT UNIQUE, 
	`Ticket`			varchar (255), 
	`Dates`			datetime, 
	`Heure`			varchar (255), 
	`ID_ARTICLE`			varchar (255), 
	`Code`			varchar (255), 
	`Article`			varchar (255), 
	`Famille`			varchar (255), 
	`PRIX_A`			double, 
	`PRIX_MP`			double, 
	`PRIX_V`			double, 
	`Qté`			double, 
	`Remise`			double, 
	`TOTAL_NET`			double, 
	`Caissier`			varchar (255), 
	`Vendeur`			varchar (255), 
	`TAUX_TVA`			double, 
	`PRINTER`			varchar (255), 
	`PRINTER_DUPLICATA`			varchar (255), 
	`cuisine`			varchar (255)
);

-- CREATE INDEXES ...
ALTER TABLE `TABLE_77` ADD INDEX `Code` (`Code`);
ALTER TABLE `TABLE_77` ADD PRIMARY KEY (`ID`);




-- ----------------------------------------------------------
-- MDB Tools - A library for reading MS Access database files
-- Copyright (C) 2000-2011 Brian Bruns and others.
-- Files in libmdb are licensed under LGPL and the utilities under
-- the GPL, see COPYING.LIB and COPYING files respectively.
-- Check out http://mdbtools.sourceforge.net
-- ----------------------------------------------------------

-- That file uses encoding UTF-8

CREATE TABLE `TABLE_78`
 (
	`ID`			int NOT NULL AUTO_INCREMENT UNIQUE, 
	`Ticket`			varchar (255), 
	`Dates`			datetime, 
	`Heure`			varchar (255), 
	`ID_ARTICLE`			varchar (255), 
	`Code`			varchar (255), 
	`Article`			varchar (255), 
	`Famille`			varchar (255), 
	`PRIX_A`			double, 
	`PRIX_MP`			double, 
	`PRIX_V`			double, 
	`Qté`			double, 
	`Remise`			double, 
	`TOTAL_NET`			double, 
	`Caissier`			varchar (255), 
	`Vendeur`			varchar (255), 
	`TAUX_TVA`			double, 
	`PRINTER`			varchar (255), 
	`PRINTER_DUPLICATA`			varchar (255), 
	`cuisine`			varchar (255)
);

-- CREATE INDEXES ...
ALTER TABLE `TABLE_78` ADD INDEX `Code` (`Code`);

ALTER TABLE `TABLE_78` ADD PRIMARY KEY (`ID`);




-- ----------------------------------------------------------
-- MDB Tools - A library for reading MS Access database files
-- Copyright (C) 2000-2011 Brian Bruns and others.
-- Files in libmdb are licensed under LGPL and the utilities under
-- the GPL, see COPYING.LIB and COPYING files respectively.
-- Check out http://mdbtools.sourceforge.net
-- ----------------------------------------------------------

-- That file uses encoding UTF-8

CREATE TABLE `TABLE_79`
 (
	`ID`			int NOT NULL AUTO_INCREMENT UNIQUE, 
	`Ticket`			varchar (255), 
	`Dates`			datetime, 
	`Heure`			varchar (255), 
	`ID_ARTICLE`			varchar (255), 
	`Code`			varchar (255), 
	`Article`			varchar (255), 
	`Famille`			varchar (255), 
	`PRIX_A`			double, 
	`PRIX_MP`			double, 
	`PRIX_V`			double, 
	`Qté`			double, 
	`Remise`			double, 
	`TOTAL_NET`			double, 
	`Caissier`			varchar (255), 
	`Vendeur`			varchar (255), 
	`TAUX_TVA`			double, 
	`PRINTER`			varchar (255), 
	`PRINTER_DUPLICATA`			varchar (255), 
	`cuisine`			varchar (255)
);

-- CREATE INDEXES ...
ALTER TABLE `TABLE_79` ADD INDEX `Code` (`Code`);

ALTER TABLE `TABLE_79` ADD PRIMARY KEY (`ID`);




-- ----------------------------------------------------------
-- MDB Tools - A library for reading MS Access database files
-- Copyright (C) 2000-2011 Brian Bruns and others.
-- Files in libmdb are licensed under LGPL and the utilities under
-- the GPL, see COPYING.LIB and COPYING files respectively.
-- Check out http://mdbtools.sourceforge.net
-- ----------------------------------------------------------

-- That file uses encoding UTF-8

CREATE TABLE `TABLE_ARTICLES`
 (
	`ID`			int NOT NULL AUTO_INCREMENT UNIQUE, 
	`ID_ARTICLE`			varchar (255), 
	`Code`			varchar (255), 
	`Article`			varchar (255), 
	`Famille`			varchar (255), 
	`Sous_Famille`			varchar (255), 
	`Description`			varchar (255), 
	`Prix_A`			double, 
	`PRIX_MP`			double, 
	`PRIX_V_1`			double, 
	`PRIX_V_2`			double, 
	`STOCK`			double, 
	`Alert`			double, 
	`DATES`			datetime, 
	`DATE_INVENTAIRE`			datetime, 
	`STOCK_INITIAL`			varchar (255), 
	`TAUX_TVA`			double, 
	`UNITE`			varchar (255), 
	`REFERENCE`			varchar (255), 
	`FOURNISSEUR`			varchar (255), 
	`MODE_STOCK`			varchar (255), 
	`PRINTER`			varchar (255), 
	`PRINTER_DUPLICATA`			varchar (255), 
	`Images`			varchar (255), 
	`TYPE`			varchar (255), 
	`COMPOSITIONS`			varchar (255), 
	`VISIBLE`			varchar (255), 
	`Ordre`			double, 
	`FENETRE_PESAGE`			varchar (255), 
	`PROMOTION`			double, 
	`BALANCE`			varchar (255)
);

-- CREATE INDEXES ...
ALTER TABLE `TABLE_ARTICLES` ADD INDEX `Code` (`Code`);

ALTER TABLE `TABLE_ARTICLES` ADD PRIMARY KEY (`ID`);



INSERT INTO `TABLE_ARTICLES` (`ID`, `ID_ARTICLE`, `Code`, `Article`, `Famille`, `Sous_Famille`, `Description`, `Prix_A`, `PRIX_MP`, `PRIX_V_1`, `PRIX_V_2`, `STOCK`, `Alert`, `DATES`, `DATE_INVENTAIRE`, `STOCK_INITIAL`, `TAUX_TVA`, `UNITE`, `REFERENCE`, `FOURNISSEUR`, `MODE_STOCK`, `PRINTER`, `PRINTER_DUPLICATA`, `Images`, `TYPE`, `COMPOSITIONS`, `VISIBLE`, `Ordre`, `FENETRE_PESAGE`, `PROMOTION`, `BALANCE`) VALUES (1,"ART1","70221","CAFE NOIR","BOISSONS CHAUDES",NULL,NULL,0,0,10,12,-8,0,"1900-01-00 00:00:00","1900-01-00 00:00:00","0",0,NULL,NULL,NULL,"FINI","C1","0","22-08-2023 00-02-13-5615703.png","ARTICLE",NULL,"OUI",1,NULL,0,NULL), (2,"ART2","70222","CAFE CREME","BOISSONS CHAUDES",NULL,NULL,0,0,10,10,50,0,"2022-02-08 00:00:00","2022-02-08 00:00:00","0",0,NULL,NULL,NULL,"0","C1","0","22-08-2023 00-02-26-9633176.png","ARTICLE",NULL,"OUI",2,NULL,0,NULL), (3,"ART3","70223","CAFE CASSE","BOISSONS CHAUDES",NULL,NULL,0,0,10,10,25,0,"2022-02-08 00:00:00","2023-12-14 00:00:00","3",0,NULL,NULL,NULL,"0","C1","0","22-08-2023 00-02-30-4437589.png","ARTICLE",NULL,"OUI",3,NULL,0,NULL), (4,"ART4","70224","CAFE MOITIE","BOISSONS CHAUDES",NULL,NULL,0,0,10,10,15,0,"2022-02-08 00:00:00","2023-12-14 00:00:00","15",0,NULL,NULL,NULL,"0","C1","0","22-08-2023 00-02-35-7603533.png","ARTICLE",NULL,"OUI",4,NULL,0,NULL), (5,"ART5","70225","CHOCOLAT CHAUD","BOISSONS CHAUDES",NULL,NULL,0,0,10,10,0,0,"2022-02-08 00:00:00","2022-02-08 00:00:00","0",0,NULL,NULL,NULL,"0","C1","0","22-08-2023 00-02-42-1113386.png","ARTICLE",NULL,"OUI",5,NULL,0,NULL), (6,"ART6","70226","THE NOIR","BOISSONS CHAUDES",NULL,NULL,0,0,10,10,132,0,"2022-02-08 00:00:00","2022-02-08 00:00:00","0",0,NULL,NULL,NULL,"0","C1","0","22-08-2023 00-02-46-1769071.png","ARTICLE",NULL,"OUI",6,NULL,0,NULL), (7,"ART7","70227","VERVEINE","BOISSONS CHAUDES",NULL,NULL,0,0,10,10,0,0,"2022-02-08 00:00:00","2022-02-08 00:00:00","0",0,NULL,NULL,NULL,"0","C1","0","22-08-2023 00-02-49-9312628.png","ARTICLE",NULL,"OUI",7,NULL,0,NULL), (8,"ART8","70228","THE MENTHE","BOISSONS CHAUDES",NULL,NULL,0,0,10,10,0,0,"2022-02-08 00:00:00","2022-02-08 00:00:00","0",0,NULL,NULL,NULL,"0","C1","0","22-08-2023 00-02-54-7408402.png","ARTICLE",NULL,"OUI",8,NULL,0,NULL), (9,"ART9","70229","LAIT VERVEINE","BOISSONS CHAUDES",NULL,NULL,0,0,10,10,0,0,"2022-02-08 00:00:00","2022-02-08 00:00:00","0",0,NULL,NULL,NULL,"0","C1","0","22-08-2023 00-03-00-5821693.png","ARTICLE",NULL,"OUI",9,NULL,0,NULL), (10,"ART10","70230","LAIT LIPTON","BOISSONS CHAUDES",NULL,NULL,0,0,10,10,0,0,"2022-02-08 00:00:00","2022-02-08 00:00:00","0",0,NULL,NULL,NULL,"0","C1","0","22-08-2023 00-03-06-7403123.png","ARTICLE",NULL,"OUI",10,NULL,0,NULL), (11,"ART11","70231","LAIT CHAUD","BOISSONS CHAUDES",NULL,NULL,0,0,10,10,0,0,"2022-02-08 00:00:00","2022-02-08 00:00:00","0",0,NULL,NULL,NULL,"0","C1","0","22-08-2023 00-03-10-8358310.png","ARTICLE",NULL,"OUI",11,NULL,0,NULL), (12,"ART12","70232","LAIT FROID","BOISSONS CHAUDES",NULL,NULL,0,0,10,10,0,0,"2022-02-08 00:00:00","2022-02-08 00:00:00","0",0,NULL,NULL,NULL,"0","C1","0","22-08-2023 00-03-14-5695908.png","ARTICLE",NULL,"OUI",12,NULL,0,NULL), (14,"ART14","70234","COCA COLA","SODA",NULL,NULL,0,0,11,11,18,0,"2022-02-08 00:00:00","2022-02-08 00:00:00","0",0,NULL,NULL,NULL,"0","C1","0","21-08-2023 23-59-40-4780081.png","ARTICLE",NULL,"OUI",14,NULL,0,NULL), (15,"ART15","70235","COCA LIGHT","SODA",NULL,NULL,0,0,10,10,0,0,"2022-02-08 00:00:00","2022-02-08 00:00:00","0",0,NULL,NULL,NULL,"0","C1","0","21-08-2023 23-59-46-1722501.png","ARTICLE",NULL,"OUI",15,NULL,0,NULL), (16,"ART16","70236","FANTA CITRON","SODA",NULL,NULL,0,0,10,10,6,0,"2022-02-08 00:00:00","2022-02-08 00:00:00","0",0,NULL,NULL,NULL,"0","C1","0","22-08-2023 00-00-20-8488271.png","ARTICLE",NULL,"OUI",16,NULL,0,NULL), (17,"ART17","70237","FANTA ORANGE","SODA",NULL,NULL,0,0,10,10,0,0,"2022-02-08 00:00:00","2022-02-08 00:00:00","0",0,NULL,NULL,NULL,"0","C1","0","22-08-2023 00-00-24-1216146.png","ARTICLE",NULL,"OUI",17,NULL,0,NULL), (18,"ART18","70238","SPRITE","SODA",NULL,NULL,0,0,10,10,0,0,"2022-02-08 00:00:00","2022-02-08 00:00:00","0",0,NULL,NULL,NULL,"0","C1","0","22-08-2023 00-00-29-6998177.png","ARTICLE",NULL,"OUI",18,NULL,0,NULL), (19,"ART19","70239","HAWAI","SODA",NULL,NULL,0,0,10,10,24,0,"2022-02-08 00:00:00","2022-02-08 00:00:00","0",0,NULL,NULL,NULL,"0","C1","0","22-08-2023 00-00-33-4478082.png","ARTICLE",NULL,"OUI",19,NULL,0,NULL), (20,"ART20","70240","POMS","SODA",NULL,NULL,0,0,10,10,0,0,"2022-02-08 00:00:00","2022-02-08 00:00:00","0",0,NULL,NULL,NULL,"0","C1","0","22-08-2023 00-00-38-2598500.png","ARTICLE",NULL,"OUI",20,NULL,0,NULL), (21,"ART21","70241","SCHWEPPES TONIC","SODA",NULL,NULL,0,0,10,10,0,0,"2022-02-08 00:00:00","2022-02-08 00:00:00","0",0,NULL,NULL,NULL,"0","C1","0","22-08-2023 00-00-56-1222411.png","ARTICLE",NULL,"OUI",21,NULL,0,NULL), (22,"ART22","70242","SCHWEPPES CITRON","SODA",NULL,NULL,0,0,10,10,0,0,"2022-02-08 00:00:00","2022-02-08 00:00:00","0",0,NULL,NULL,NULL,"0","C1","0","22-08-2023 00-00-51-3215953.png","ARTICLE",NULL,"OUI",22,NULL,0,NULL), (23,"ART23","70243","OULMES","SODA",NULL,NULL,0,0,10,10,0,0,"2022-02-08 00:00:00","2022-02-08 00:00:00","0",0,NULL,NULL,NULL,"0","C1","0","22-08-2023 00-01-00-3976026.png","ARTICLE",NULL,"OUI",23,NULL,0,NULL), (24,"ART24","70244","SIDI ALI","SODA",NULL,NULL,0,0,10,10,0,0,"2022-02-08 00:00:00","2022-02-08 00:00:00","0",0,NULL,NULL,NULL,"0","C1","0","22-08-2023 00-01-05-3748253.png","ARTICLE",NULL,"OUI",24,NULL,0,NULL), (25,"ART25","70245","EAU MINERALE","SODA",NULL,NULL,0,0,10,10,0,0,"2022-02-08 00:00:00","2022-02-08 00:00:00","0",0,NULL,NULL,NULL,"0","C1","0","22-08-2023 00-01-25-3460421.png","ARTICLE",NULL,"OUI",25,NULL,0,NULL), (27,"ART27","70247","JUS ORANGE","JUS",NULL,NULL,0,0,10,10,0,0,"2022-02-08 00:00:00","2022-02-08 00:00:00","0",0,NULL,NULL,NULL,"0","C1","0","22-08-2023 00-40-54-2968299.png","ARTICLE",NULL,"OUI",27,NULL,0,NULL), (28,"ART28","70248","JUS CITRON","JUS",NULL,NULL,0,0,10,10,0,0,"2022-02-08 00:00:00","2022-02-08 00:00:00","0",0,NULL,NULL,NULL,"0","C2","0","22-08-2023 00-40-59-4606014.png","ARTICLE",NULL,"OUI",28,NULL,0,NULL), (29,"ART29","70249","JUS POMME","JUS",NULL,NULL,0,0,44,44,0,0,"2022-02-08 00:00:00","2022-02-08 00:00:00","0",0,NULL,NULL,NULL,"0","C1","0","22-08-2023 00-41-03-4738503.png","ARTICLE",NULL,"OUI",29,NULL,0,NULL), (30,"ART30","70250","JUS BANANE","JUS",NULL,NULL,0,0,10,10,0,0,"2022-02-08 00:00:00","2022-02-08 00:00:00","0",0,NULL,NULL,NULL,"0","C1","0","22-08-2023 00-41-09-0939135.png","ARTICLE",NULL,"OUI",30,NULL,0,NULL), (31,"ART31","70251","JUS AVOCAT","JUS",NULL,NULL,0,0,10,10,0,0,"2022-02-08 00:00:00","2022-02-08 00:00:00","0",0,NULL,NULL,NULL,"0","C1","0","22-08-2023 00-41-14-6131874.png","ARTICLE",NULL,"OUI",31,NULL,0,NULL), (32,"ART32","70252","JUS AMANDE","JUS",NULL,NULL,0,0,10,10,0,0,"2022-02-08 00:00:00","2022-02-08 00:00:00","0",0,NULL,NULL,NULL,"0","C1","0","22-08-2023 00-41-19-3037560.png","ARTICLE",NULL,"OUI",32,NULL,0,NULL), (34,"ART34","70254","JUS FRAISE","JUS",NULL,NULL,0,0,10,10,0,0,"2022-02-08 00:00:00","2022-02-08 00:00:00","0",0,NULL,NULL,NULL,"0","C1","0","22-08-2023 00-41-23-8920679.png","ARTICLE",NULL,"OUI",34,NULL,0,NULL), (36,"ART36","70256","JUS PECHE","JUS",NULL,NULL,0,0,14,14,0,0,"2022-02-08 00:00:00","2022-02-08 00:00:00","0",0,NULL,NULL,NULL,"0","C1","0","22-08-2023 00-41-29-0065635.png","ARTICLE",NULL,"OUI",36,NULL,0,NULL), (37,"ART37","70257","JUS ANANAS","JUS",NULL,NULL,0,0,10,10,0,0,"2022-02-08 00:00:00","2022-02-08 00:00:00","0",0,NULL,NULL,NULL,"0","C1","0","22-08-2023 00-41-36-4776265.png","ARTICLE",NULL,"OUI",37,NULL,0,NULL), (38,"ART38","70258","P.J COMPLET","PETITS DEJ",NULL,NULL,0,0,10,10,0,0,"2022-02-08 00:00:00","2022-02-08 00:00:00","0",0,NULL,NULL,NULL,"0","C1","0","22-08-2023 00-45-50-0812531.png","ARTICLE",NULL,"OUI",38,NULL,0,NULL), (39,"ART39","70259","P.J NORMAL","PETITS DEJ",NULL,NULL,0,0,10,10,0,0,"2022-02-08 00:00:00","2022-02-08 00:00:00","0",0,NULL,NULL,NULL,"0","C1","0","22-08-2023 00-45-58-2155825.png","ARTICLE",NULL,"OUI",39,NULL,0,NULL), (40,"ART40","70260","P.J SPECIAL","PETITS DEJ",NULL,NULL,0,0,10,10,0,0,"2022-02-08 00:00:00","2022-02-08 00:00:00","0",0,NULL,NULL,NULL,"0","C1","0","22-08-2023 00-46-02-9915961.png","ARTICLE",NULL,"OUI",40,NULL,0,NULL), (41,"ART41","70261","P.J KHLII","PETITS DEJ",NULL,NULL,0,0,10,10,0,0,"2022-02-08 00:00:00","2022-02-08 00:00:00","0",0,NULL,NULL,NULL,"0","C1","0","22-08-2023 00-47-01-7955050.png","ARTICLE",NULL,"OUI",41,NULL,0,NULL), (42,"ART42","70262","OMELETTE NATURE","PETITS DEJ",NULL,NULL,0,0,10,10,0,0,"2022-02-08 00:00:00","2022-02-08 00:00:00","0",0,NULL,NULL,NULL,"0","C1","0","22-08-2023 00-46-32-2058957.png","ARTICLE",NULL,"OUI",42,NULL,0,NULL), (43,"ART43","70263","OMELETTE FROMAGE","PETITS DEJ",NULL,NULL,0,0,10,10,0,0,"2022-02-08 00:00:00","2022-02-08 00:00:00","0",0,NULL,NULL,NULL,"0","C1","0","22-08-2023 00-46-38-6104867.png","ARTICLE",NULL,"OUI",43,NULL,0,NULL), (44,"ART44","70264","OMELETTE KHLII","PETITS DEJ",NULL,NULL,0,0,10,10,0,0,"2022-02-08 00:00:00","2022-02-08 00:00:00","0",0,NULL,NULL,NULL,"0","C1","0","22-08-2023 00-46-43-8381269.png","ARTICLE",NULL,"OUI",44,NULL,0,NULL), (45,"ART45","70265","CAKE","VIENNOISERIE",NULL,NULL,0,0,10,10,0,0,"2022-02-08 00:00:00","2022-02-08 00:00:00","0",0,NULL,NULL,NULL,"0","C1","0","22-08-2023 00-47-37-9135553.png","ARTICLE",NULL,"OUI",45,NULL,0,NULL), (46,"ART46","70266","PETIT PAIN CHOCOLAT","VIENNOISERIE",NULL,NULL,0,0,10,10,0,0,"2022-02-08 00:00:00","2022-02-08 00:00:00","0",0,NULL,NULL,NULL,"0","C1","0","22-08-2023 00-48-08-7298186.png","ARTICLE",NULL,"OUI",46,NULL,0,NULL), (47,"ART47","70267","FOUREE AMANDE","VIENNOISERIE",NULL,NULL,0,0,10,10,0,0,"2022-02-08 00:00:00","2022-02-08 00:00:00","0",0,NULL,NULL,NULL,"0","C1","0","22-08-2023 00-48-23-5950791.png","ARTICLE",NULL,"OUI",47,NULL,0,NULL), (48,"ART48","70268","CROISSANT","VIENNOISERIE",NULL,NULL,0,0,10,10,0,0,"2022-02-08 00:00:00","2022-02-08 00:00:00","0",0,NULL,NULL,NULL,"0","C1","0","22-08-2023 00-48-47-8125416.png","ARTICLE",NULL,"OUI",48,NULL,0,NULL), (50,"ART50","70270","CHAUSSON FROMAGE","VIENNOISERIE",NULL,NULL,0,0,10,10,0,0,"2022-02-08 00:00:00","2022-02-08 00:00:00","0",0,NULL,NULL,NULL,"0","C1","0","22-08-2023 00-48-59-3540165.png","ARTICLE",NULL,"OUI",50,NULL,0,NULL), (51,"ART51","70271","CHAUSSON AMANDE","VIENNOISERIE",NULL,NULL,0,0,10,10,0,0,"2022-02-08 00:00:00","2022-02-08 00:00:00","0",0,NULL,NULL,NULL,"0","C1","0","22-08-2023 00-49-07-9226554.png","ARTICLE",NULL,"OUI",51,NULL,0,NULL), (52,"ART52","70272","PAIN RAISIN","VIENNOISERIE",NULL,NULL,0,0,10,10,0,0,"2022-02-08 00:00:00","2022-02-08 00:00:00","0",0,NULL,NULL,NULL,"0","C1","0","22-08-2023 00-49-18-1481179.png","ARTICLE",NULL,"OUI",52,NULL,0,NULL), (53,"ART53","70273","PAIN GRILLE","VIENNOISERIE",NULL,NULL,0,0,10,10,0,0,"2022-02-08 00:00:00","2022-02-08 00:00:00","0",0,NULL,NULL,NULL,"0","C1","0","22-08-2023 00-49-26-8022525.png","ARTICLE",NULL,"OUI",53,NULL,0,NULL), (54,"ART54","70274","MINI PETIT PAIN","VIENNOISERIE",NULL,NULL,0,0,10,10,0,0,"2022-02-08 00:00:00","2022-02-08 00:00:00","0",0,NULL,NULL,NULL,"0","C1","0","22-08-2023 00-49-32-6606750.png","ARTICLE",NULL,"OUI",54,NULL,0,NULL), (55,"ART55","70275","BRIOCHE NATURE","VIENNOISERIE",NULL,NULL,0,0,10,10,0,0,"2022-02-08 00:00:00","2022-02-08 00:00:00","0",0,NULL,NULL,NULL,"0","C1","0","22-08-2023 00-50-01-5899611.png","ARTICLE",NULL,"OUI",55,NULL,0,NULL), (57,"ART57","70277","BEIGNET","VIENNOISERIE",NULL,NULL,0,0,10,10,0,0,"2022-02-08 00:00:00","2022-02-08 00:00:00","0",0,NULL,NULL,NULL,"0","C1","0","22-08-2023 00-50-19-7722179.png","ARTICLE",NULL,"OUI",57,NULL,0,NULL), (58,"ART58","70278","GATEAU MAROCAIN","GATEAUX",NULL,NULL,0,0,10,10,0,0,"2022-02-08 00:00:00","2022-02-08 00:00:00","0",0,NULL,NULL,NULL,"0","C1","0","22-08-2023 00-51-38-5390190.png","ARTICLE",NULL,"OUI",58,NULL,0,NULL), (59,"ART59","70279","MILLE FEUILLES","GATEAUX",NULL,NULL,0,0,10,10,0,0,"2022-02-08 00:00:00","2022-02-08 00:00:00","0",0,NULL,NULL,NULL,"0","C1","0","22-08-2023 00-52-07-7858152.png","ARTICLE",NULL,"OUI",59,NULL,0,NULL), (60,"ART60","70280","GATEAU GLACE","GATEAUX",NULL,NULL,0,0,10,10,0,0,"2022-02-08 00:00:00","2022-02-08 00:00:00","0",0,NULL,NULL,NULL,"0","C1","0","22-08-2023 00-52-23-9622045.png","ARTICLE",NULL,"OUI",60,NULL,0,NULL), (61,"ART61","70281","TARTE FRUITS","GATEAUX",NULL,NULL,0,0,10,10,0,0,"2022-02-08 00:00:00","2022-02-08 00:00:00","0",0,NULL,NULL,NULL,"0","C1","0","22-08-2023 00-52-51-2196938.png","ARTICLE",NULL,"OUI",61,NULL,0,NULL), (62,"ART62","70282","GATEAU SOIREE","GATEAUX",NULL,NULL,0,0,10,10,0,0,"2022-02-08 00:00:00","2022-02-08 00:00:00","0",0,NULL,NULL,NULL,"0","C1","0","22-08-2023 00-53-05-0322627.png","ARTICLE",NULL,"OUI",62,NULL,0,NULL), (63,"ART63","70283","PIZZA","GATEAUX",NULL,NULL,0,0,10,10,0,0,"2022-02-08 00:00:00","2022-02-08 00:00:00","0",0,NULL,NULL,NULL,"0","C1","0","22-08-2023 00-53-12-5135873.png","ARTICLE",NULL,"OUI",63,NULL,0,NULL), (64,"ART64","70284","QUICHE","GATEAUX",NULL,NULL,0,0,10,10,0,0,"2022-02-08 00:00:00","2022-02-08 00:00:00","0",0,NULL,NULL,NULL,"0","C1","0","22-08-2023 00-53-17-7629408.png","ARTICLE",NULL,"OUI",64,NULL,0,NULL), (65,"ART65","70285","TARTE","GATEAUX",NULL,NULL,0,0,10,10,0,0,"2022-02-08 00:00:00","2022-02-08 00:00:00","0",0,NULL,NULL,NULL,"0","C1","0","22-08-2023 00-53-40-4590401.png","ARTICLE",NULL,"OUI",65,NULL,0,NULL), (66,"ART66","70286","FLAN","GATEAUX",NULL,NULL,0,0,10,10,0,0,"2022-02-08 00:00:00","2022-02-08 00:00:00","0",0,NULL,NULL,NULL,"0","C1","0","22-08-2023 00-53-32-4662566.png","ARTICLE",NULL,"OUI",66,NULL,0,NULL), (67,"ART67","70287","MADELEINE","GATEAUX",NULL,NULL,0,0,10,10,0,0,"2022-02-08 00:00:00","2022-02-08 00:00:00","0",0,NULL,NULL,NULL,"0","C1","0","22-08-2023 00-53-55-1474747.png","ARTICLE",NULL,"OUI",67,NULL,0,NULL), (69,"ART69","70289","BROWNIES","GATEAUX",NULL,NULL,0,0,10,10,0,0,"2022-02-08 00:00:00","2022-02-08 00:00:00","0",0,NULL,NULL,NULL,"0","C1","0","22-08-2023 00-54-11-0116201.png","ARTICLE",NULL,"OUI",69,NULL,0,NULL), (70,"ART70","70290","GLACE 1 BOULE","GLACES",NULL,NULL,0,0,10,10,0,0,"2022-02-08 00:00:00","2022-02-08 00:00:00","0",0,NULL,NULL,NULL,"0","C1","0","22-08-2023 00-54-20-1198037.png","ARTICLE",NULL,"OUI",70,NULL,0,NULL), (71,"ART71","70291","GLACE 2 BOULES","GLACES",NULL,NULL,0,0,10,10,0,0,"2022-02-08 00:00:00","2022-02-08 00:00:00","0",0,NULL,NULL,NULL,"0","C1","0","22-08-2023 00-54-24-6799793.png","ARTICLE",NULL,"OUI",71,NULL,0,NULL), (72,"ART72","70292","GLACE 3 BOULES","GLACES",NULL,NULL,0,0,10,10,0,0,"2022-02-08 00:00:00","2022-02-08 00:00:00","0",0,NULL,NULL,NULL,"0","C1","0","22-08-2023 00-54-28-0010151.png","ARTICLE",NULL,"OUI",72,NULL,0,NULL), (73,"ART73","70293","GLACE 4 BOULES","GLACES",NULL,NULL,0,0,10,10,0,0,"2022-02-08 00:00:00","2022-02-08 00:00:00","0",0,NULL,NULL,NULL,"0","C1","0","22-08-2023 00-54-32-3276624.png","ARTICLE",NULL,"OUI",73,NULL,0,NULL), (74,"ART74","70294","GLACE 5 BOULES","GLACES",NULL,NULL,0,0,10,10,0,0,"2022-02-08 00:00:00","2022-02-08 00:00:00","0",0,NULL,NULL,NULL,"0","C1","0","22-08-2023 00-54-34-9243722.png","ARTICLE",NULL,"OUI",74,NULL,0,NULL), (76,"ART76","70296","SALADE MEXICAINE","SALADE",NULL,NULL,0,0,10,10,0,0,"2022-02-08 00:00:00","2022-02-08 00:00:00","0",0,NULL,NULL,NULL,"0","C1","0","22-08-2023 00-55-03-9159663.png","ARTICLE",NULL,"OUI",76,NULL,0,NULL), (77,"ART77","70297","SALADE NICOISE","SALADE",NULL,NULL,0,0,10,10,0,0,"2022-02-08 00:00:00","2022-02-08 00:00:00","0",0,NULL,NULL,NULL,"0","C1","0","22-08-2023 00-55-09-6510834.png","ARTICLE",NULL,"OUI",77,NULL,0,NULL), (78,"ART78","70298","SALADE ITALIENNE","SALADE",NULL,NULL,0,0,10,10,0,0,"2022-02-08 00:00:00","2022-02-08 00:00:00","0",0,NULL,NULL,NULL,"0","C1","0","22-08-2023 00-55-14-1861257.png","ARTICLE",NULL,"OUI",78,NULL,0,NULL), (79,"ART79","70299","SALADE LATINO","SALADE",NULL,NULL,0,0,10,10,0,0,"2022-02-08 00:00:00","2022-02-08 00:00:00","0",0,NULL,NULL,NULL,"0","C1","0","22-08-2023 00-55-42-7852167.png","ARTICLE",NULL,"OUI",79,NULL,0,NULL), (80,"ART80","70300","SALADE CESAR","SALADE",NULL,NULL,0,0,10,10,0,0,"2022-02-08 00:00:00","2022-02-08 00:00:00","0",0,NULL,NULL,NULL,"0","C1","0","22-08-2023 00-55-52-5781132.png","ARTICLE",NULL,"OUI",80,NULL,0,NULL), (82,"ART82","70302","SALADE GOURMET","SALADE",NULL,NULL,0,0,10,10,0,0,"2022-02-08 00:00:00","2022-02-08 00:00:00","0",0,NULL,NULL,NULL,"0","C1","0","22-08-2023 00-56-10-0584530.png","ARTICLE",NULL,"OUI",82,NULL,0,NULL), (83,"ART83","70303","SALADE PECHEUR","SALADE",NULL,NULL,0,0,10,10,0,0,"2022-02-08 00:00:00","2022-02-08 00:00:00","0",0,NULL,NULL,NULL,"0","C1","0","22-08-2023 00-56-36-4681410.png","ARTICLE",NULL,"OUI",83,NULL,0,NULL), (84,"ART84","70304","SOUPE CREME LEGUMES","SALADE",NULL,NULL,0,0,10,10,0,0,"2022-02-08 00:00:00","2022-02-08 00:00:00","0",0,NULL,NULL,NULL,"0","C1","0","22-08-2023 00-56-49-0149614.png","ARTICLE",NULL,"OUI",84,NULL,0,NULL), (85,"ART85","70305","SOUPE POISSON","SALADE",NULL,NULL,0,0,10,10,0,0,"2022-02-08 00:00:00","2022-02-08 00:00:00","0",0,NULL,NULL,NULL,"0","C1","0","22-08-2023 00-56-55-2052217.png","ARTICLE",NULL,"OUI",85,NULL,0,NULL), (86,"ART86","70306","CREME CARAMEL","DESSERT",NULL,NULL,0,0,10,10,0,0,"2022-02-08 00:00:00","2022-02-08 00:00:00","0",0,NULL,NULL,NULL,"0","C1","0","22-08-2023 00-57-04-4500679.png","ARTICLE",NULL,"OUI",86,NULL,0,NULL), (88,"ART88","70308","PANNA COTTA","DESSERT",NULL,NULL,0,0,10,10,0,0,"2022-02-08 00:00:00","2022-02-08 00:00:00","0",0,NULL,NULL,NULL,"0","C1","0","22-08-2023 00-57-14-8211673.png","ARTICLE",NULL,"OUI",88,NULL,0,NULL), (89,"ART89","70309","NOUGAT GLACE","DESSERT",NULL,NULL,0,0,10,10,0,0,"2022-02-08 00:00:00","2022-02-08 00:00:00","0",0,NULL,NULL,NULL,"0","C1","0","22-08-2023 00-57-24-7548684.png","ARTICLE",NULL,"OUI",89,NULL,0,NULL), (90,"ART90","70310","TIRAMISU","DESSERT",NULL,NULL,0,0,10,10,0,0,"2022-02-08 00:00:00","2022-02-08 00:00:00","0",0,NULL,NULL,NULL,"0","C1","0","22-08-2023 00-57-33-7223206.png","ARTICLE",NULL,"OUI",90,NULL,0,NULL), (91,"ART91","70311","TACOS POULET","TACOS",NULL,NULL,0,0,10,10,0,0,"2022-02-08 00:00:00","2022-02-08 00:00:00","0",0,NULL,NULL,NULL,"0","C1","0","22-08-2023 00-57-45-7600528.png","ARTICLE","SAUCE CHOIX;FRITE CHOIX;BOISSONS CHOIX;","OUI",91,NULL,0,NULL), (92,"ART92","70312","TACOS V.H","TACOS",NULL,NULL,0,0,10,10,0,0,"2022-02-08 00:00:00","2022-02-08 00:00:00","0",0,NULL,NULL,NULL,"0","C1","0","22-08-2023 00-57-48-7430639.png","ARTICLE",NULL,"OUI",92,NULL,0,NULL), (93,"ART93","70313","TACOS MIXTE","TACOS",NULL,NULL,0,0,10,10,0,0,"2022-02-08 00:00:00","2022-02-08 00:00:00","0",0,NULL,NULL,NULL,"0","C1","0","22-08-2023 00-57-53-1085646.png","ARTICLE",NULL,"OUI",93,NULL,0,NULL), (94,"ART94","70314","TACOS CORDON B","TACOS",NULL,NULL,0,0,10,10,0,0,"2022-02-08 00:00:00","2022-02-08 00:00:00","0",0,NULL,NULL,NULL,"0","C1","0","22-08-2023 00-57-56-1342152.png","ARTICLE",NULL,"OUI",94,NULL,0,NULL), (96,"ART96","70316","TACOS NUGETTE","TACOS",NULL,NULL,0,0,10,10,0,0,"2022-02-08 00:00:00","2022-02-08 00:00:00","0",0,NULL,NULL,NULL,"0","C1","0","22-08-2023 00-58-03-3074371.png","ARTICLE",NULL,"OUI",96,NULL,0,NULL), (97,"ART97","70317","TACOS FRUITS MER","TACOS",NULL,NULL,0,0,10,10,0,0,"2022-02-08 00:00:00","2022-02-08 00:00:00","0",0,NULL,NULL,NULL,"0","C1","0","22-08-2023 00-58-08-3742051.png","ARTICLE",NULL,"OUI",97,NULL,0,NULL), (99,"ART99","70319","HAMBURER","BURGER",NULL,NULL,0,0,10,10,0,0,"2022-02-08 00:00:00","2022-02-08 00:00:00","0",0,NULL,NULL,NULL,"0","C1","0","22-08-2023 00-59-01-0188614.png","ARTICLE",NULL,"OUI",99,NULL,0,NULL), (100,"ART100","70320","CHICKEN BURGER","BURGER",NULL,NULL,0,0,10,10,0,0,"2022-02-08 00:00:00","2022-02-08 00:00:00","0",0,NULL,NULL,NULL,"0","C1","0","22-08-2023 00-59-06-2518691.png","ARTICLE",NULL,"OUI",100,NULL,0,NULL), (101,"ART101","70321","KING BURGER","BURGER",NULL,NULL,0,0,25,25,0,0,"2022-02-08 00:00:00","2022-02-08 00:00:00","0",0,NULL,NULL,NULL,"0","C1","0","22-08-2023 00-59-32-0863999.png","ARTICLE",NULL,"OUI",101,NULL,0,NULL), (102,"ART102","70322","ONION BURGER","BURGER",NULL,NULL,0,0,10,10,0,0,"2022-02-08 00:00:00","2022-02-08 00:00:00","0",0,NULL,NULL,NULL,"0","C1","0","22-08-2023 00-59-41-9954359.png","ARTICLE",NULL,"OUI",102,NULL,0,NULL), (103,"ART103","70323","CHEESE BURGER","BURGER",NULL,NULL,0,0,10,10,0,0,"2022-02-08 00:00:00","2022-02-08 00:00:00","0",0,NULL,NULL,NULL,"0","C1","0","22-08-2023 01-00-19-7458227.png","ARTICLE",NULL,"OUI",103,NULL,0,NULL), (104,"ART104","70324","EGG BURGER","BURGER",NULL,NULL,0,0,10,10,0,0,"2022-02-08 00:00:00","2022-02-08 00:00:00","0",0,NULL,NULL,NULL,"0","C1","0","22-08-2023 01-00-44-5855566.png","ARTICLE",NULL,"OUI",104,NULL,0,NULL), (106,"ART106","70326","FISH BURGER","BURGER",NULL,NULL,0,0,10,10,0,0,"2022-02-08 00:00:00","2022-02-08 00:00:00","0",0,NULL,NULL,NULL,"0","C1","0","22-08-2023 01-01-01-0109377.png","ARTICLE",NULL,"OUI",106,NULL,0,NULL), (108,"ART108","70328","PIZZA P MARGARITA","PIZZA",NULL,NULL,0,0,10,10,0,0,"2022-02-08 00:00:00","2022-02-08 00:00:00","0",0,NULL,NULL,NULL,"0","C1","0","22-08-2023 01-01-15-9133814.png","ARTICLE",NULL,"OUI",108,NULL,0,NULL), (109,"ART109","70329","PIZZA P VEGE","PIZZA",NULL,NULL,0,0,10,10,0,0,"2022-02-08 00:00:00","2022-02-08 00:00:00","0",0,NULL,NULL,NULL,"0","C1","0","22-08-2023 01-01-19-4731690.png","ARTICLE",NULL,"OUI",109,NULL,0,NULL), (110,"ART110","70330","PIZZA P THON","PIZZA",NULL,NULL,0,0,10,10,0,0,"2022-02-08 00:00:00","2022-02-08 00:00:00","0",0,NULL,NULL,NULL,"0","C1","0","22-08-2023 01-01-23-2667706.png","ARTICLE",NULL,"OUI",110,NULL,0,NULL), (111,"ART111","70331","PIZZA P POULET","PIZZA",NULL,NULL,0,0,10,10,0,0,"2022-02-08 00:00:00","2022-02-08 00:00:00","0",0,NULL,NULL,NULL,"0","C1","0","22-08-2023 01-01-29-1880901.png","ARTICLE",NULL,"OUI",111,NULL,0,NULL), (112,"ART112","70332","PIZZA P V.H","PIZZA",NULL,NULL,0,0,10,10,0,0,"2022-02-08 00:00:00","2022-02-08 00:00:00","0",0,NULL,NULL,NULL,"0","C1","0","22-08-2023 01-01-32-7828734.png","ARTICLE",NULL,"OUI",112,NULL,0,NULL), (113,"ART113","70333","PIZZA P 4 FROMAGES","PIZZA",NULL,NULL,0,0,10,10,0,0,"2022-02-08 00:00:00","2022-02-08 00:00:00","0",0,NULL,NULL,NULL,"0","C1","0","22-08-2023 01-01-39-3238231.png","ARTICLE",NULL,"OUI",113,NULL,0,NULL), (115,"ART115","70335","PIZZA P FRUIT MER","PIZZA",NULL,NULL,0,0,10,10,0,0,"2022-02-08 00:00:00","2022-02-08 00:00:00","0",0,NULL,NULL,NULL,"0","C1","0","22-08-2023 01-01-49-3511122.png","ARTICLE",NULL,"OUI",115,NULL,0,NULL), (116,"ART116","70336","PIZZA P 4 SAISONS","PIZZA",NULL,NULL,0,0,10,10,0,0,"2022-02-08 00:00:00","2022-02-08 00:00:00","0",0,NULL,NULL,NULL,"0","C1","0","22-08-2023 01-01-56-8761692.png","ARTICLE",NULL,"OUI",116,NULL,0,NULL), (118,"ART118","70338","PIZZA P HAWAI","PIZZA",NULL,NULL,0,0,10,10,0,0,"2022-02-08 00:00:00","2022-02-08 00:00:00","0",0,NULL,NULL,NULL,"0","C1","0","22-08-2023 01-02-09-1393310.png","ARTICLE",NULL,"OUI",118,NULL,0,NULL), (120,"ART120","70340","PIZZA P ROYALE","PIZZA",NULL,NULL,0,0,10,10,0,0,"2022-02-08 00:00:00","2022-02-08 00:00:00","0",0,NULL,NULL,NULL,"0","C1","0","22-08-2023 01-02-44-5660131.png","ARTICLE",NULL,"OUI",120,NULL,0,NULL), (121,"ART121","8509","JUS CAROTTE","JUS",NULL,NULL,0,0,10,10,0,0,"2022-05-25 00:00:00","2022-05-25 00:00:00","0",0,NULL,NULL,NULL,"0","C1","0","22-08-2023 00-43-52-9969975.png","ARTICLE",NULL,"OUI",121,NULL,0,NULL), (122,"ART122","6362","JUS CONCOMBRE","JUS",NULL,NULL,0,0,10,10,0,0,"2022-05-25 00:00:00","2022-05-25 00:00:00","0",0,NULL,NULL,NULL,"0","C1","0","22-08-2023 00-45-05-2109146.png","ARTICLE",NULL,"OUI",122,NULL,0,NULL), (123,"ART123","6601","SAUCE ALGERIENNE","SAUCE CHOIX",NULL,NULL,0,0,0,0,0,0,"2022-05-25 00:00:00","2022-05-25 00:00:00","0",0,NULL,NULL,NULL,"0","C1","0","25-05-2022 12-18-58-2640028.png","COMPOSITION",NULL,"OUI",123,NULL,0,NULL), (124,"ART124","3150","SAUCE BIGGY","SAUCE CHOIX",NULL,NULL,0,0,0,0,0,0,"2022-05-25 00:00:00","2022-05-25 00:00:00","0",0,NULL,NULL,NULL,"0","C1","0","25-05-2022 12-19-06-6074800.png","COMPOSITION",NULL,"OUI",124,NULL,0,NULL), (125,"ART125","1967","SAUCE SAMOURAY","SAUCE CHOIX",NULL,NULL,0,0,0,0,0,0,"2022-05-25 00:00:00","2022-05-25 00:00:00","0",0,NULL,NULL,NULL,"0","C1","0","25-05-2022 12-19-10-7037143.png","COMPOSITION",NULL,"OUI",125,NULL,0,NULL), (126,"ART126","2079","SAUCE BARBECUE","SAUCE CHOIX",NULL,NULL,0,0,0,0,0,0,"2022-05-25 00:00:00","2022-05-25 00:00:00","0",0,NULL,NULL,NULL,"0","C1","0","25-05-2022 12-19-18-6591694.png","COMPOSITION",NULL,"OUI",126,NULL,0,NULL), (127,"ART127","7778","SAUCE ANDALOUS","SAUCE CHOIX",NULL,NULL,0,0,0,0,0,0,"2022-05-25 00:00:00","2022-05-25 00:00:00","0",0,NULL,NULL,NULL,"0","C1","0","25-05-2022 12-19-34-9791028.png","COMPOSITION",NULL,"OUI",127,NULL,0,NULL), (128,"ART128","1165","SAUCE BRAZIL","SAUCE CHOIX",NULL,NULL,0,0,0,0,0,0,"2022-05-25 00:00:00","2022-05-25 00:00:00","0",0,NULL,NULL,NULL,"0","C1","0","25-05-2022 12-19-39-4503585.png","COMPOSITION",NULL,"OUI",128,NULL,0,NULL), (129,"ART129","3912","SAUCE POIVRE","SAUCE CHOIX",NULL,NULL,0,0,0,0,0,0,"2022-05-25 00:00:00","2022-05-25 00:00:00","0",0,NULL,NULL,NULL,"0","C1","0","25-05-2022 12-19-56-3603257.png","COMPOSITION",NULL,"OUI",129,NULL,0,NULL), (130,"ART130","1875","SAUCE FISH TO FISH","SAUCE CHOIX",NULL,NULL,0,0,0,0,0,0,"2022-05-25 00:00:00","2022-05-25 00:00:00","0",0,NULL,NULL,NULL,"0","C1","0","25-05-2022 12-20-04-2547773.png","COMPOSITION",NULL,"OUI",130,NULL,0,NULL), (132,"ART132","2895","FRITE MAISON","FRITE CHOIX",NULL,NULL,0,0,0,0,0,0,"2022-05-25 00:00:00","2022-05-25 00:00:00","0",0,NULL,NULL,NULL,"0","C1","0","0.png","COMPOSITION",NULL,"OUI",132,NULL,0,NULL), (133,"ART133","6079","CAFE SEPARE","BOISSONS CHAUDES",NULL,NULL,0,0,0,0,0,0,"2022-06-01 00:00:00","2022-06-01 00:00:00","0",0,NULL,NULL,NULL,"0","C1","0","22-08-2023 00-03-30-7986244.png","ARTICLE",NULL,"OUI",133,NULL,0,NULL), (134,"ART134","5031","CAFE NOIR","BOISSONS CHOIX",NULL,NULL,0,0,0,0,0,0,"2023-02-16 00:00:00","2023-02-16 00:00:00","0",0,NULL,NULL,NULL,"0","C1","0","0.png","COMPOSITION",NULL,"OUI",134,NULL,0,NULL), (135,"ART135","0692","JUS ORANGE","BOISSONS CHOIX",NULL,NULL,0,0,0,0,0,0,"2023-02-16 00:00:00","2023-02-16 00:00:00","0",0,NULL,NULL,NULL,"0","C1","0","0.png","COMPOSITION",NULL,"OUI",135,NULL,0,NULL), (136,"ART000015","1809","TACOS CHARCUTERIE","TACOS",NULL,NULL,0,0,10,10,0,0,"2023-05-03 00:00:00","2023-05-03 00:00:00","0",0,NULL,NULL,NULL,"0","C1","0","22-08-2023 00-58-27-6807060.png","ARTICLE",NULL,"OUI",136,NULL,0,NULL), (138,"ART000017","6915","COCA ZERO","SODA",NULL,NULL,0,0,10,10,0,0,"2023-08-21 00:00:00","2023-08-21 00:00:00","0.00",0,NULL,NULL,NULL,"0","C1","0","22-08-2023 00-00-00-3592111.png","ARTICLE",NULL,"OUI",15,NULL,0,NULL), (139,"ART000019","4840","test","BOISSONS CHAUDES",NULL,NULL,0,0,0,0,0,0,"2023-11-06 00:00:00","2023-11-06 00:00:00","0.00",0,NULL,NULL,NULL,"0","C1","0","0.png","ARTICLE",NULL,"OUI",137,NULL,0,NULL);

-- ----------------------------------------------------------
-- MDB Tools - A library for reading MS Access database files
-- Copyright (C) 2000-2011 Brian Bruns and others.
-- Files in libmdb are licensed under LGPL and the utilities under
-- the GPL, see COPYING.LIB and COPYING files respectively.
-- Check out http://mdbtools.sourceforge.net
-- ----------------------------------------------------------

-- That file uses encoding UTF-8

CREATE TABLE `TABLE_BL_DETAILS`
 (
	`ID`			int not null auto_increment unique
);

-- CREATE INDEXES ...
ALTER TABLE `TABLE_BL_DETAILS` ADD PRIMARY KEY (`ID`);




-- ----------------------------------------------------------
-- MDB Tools - A library for reading MS Access database files
-- Copyright (C) 2000-2011 Brian Bruns and others.
-- Files in libmdb are licensed under LGPL and the utilities under
-- the GPL, see COPYING.LIB and COPYING files respectively.
-- Check out http://mdbtools.sourceforge.net
-- ----------------------------------------------------------

-- That file uses encoding UTF-8

CREATE TABLE `TABLE_BL_ENTETE`
 (
	`ID`			int not null auto_increment unique
);

-- CREATE INDEXES ...
ALTER TABLE `TABLE_BL_ENTETE` ADD PRIMARY KEY (`ID`);




-- ----------------------------------------------------------
-- MDB Tools - A library for reading MS Access database files
-- Copyright (C) 2000-2011 Brian Bruns and others.
-- Files in libmdb are licensed under LGPL and the utilities under
-- the GPL, see COPYING.LIB and COPYING files respectively.
-- Check out http://mdbtools.sourceforge.net
-- ----------------------------------------------------------

-- That file uses encoding UTF-8

CREATE TABLE `TABLE_CLIENTS`
 (
	`ID`			int NOT NULL AUTO_INCREMENT UNIQUE, 
	`DATES`			datetime, 
	`ID_CLIENT`			varchar (255), 
	`CODE_CLIENT`			varchar (255), 
	`CLIENT`			varchar (255), 
	`PAYS`			varchar (255), 
	`ICE`			varchar (255), 
	`ADRESSE`			varchar (255), 
	`VILLE`			varchar (255), 
	`TELEPHONE`			varchar (255), 
	`NOTES`			varchar (255), 
	`ETAT`			varchar (255), 
	`CREDIT_INITIAL`			decimal(19,4), 
	`VENDEUR`			varchar (255)
);

-- CREATE INDEXES ...
ALTER TABLE `TABLE_CLIENTS` ADD INDEX `CODE_CLIENT` (`CODE_CLIENT`);

ALTER TABLE `TABLE_CLIENTS` ADD PRIMARY KEY (`ID`);




-- ----------------------------------------------------------
-- MDB Tools - A library for reading MS Access database files
-- Copyright (C) 2000-2011 Brian Bruns and others.
-- Files in libmdb are licensed under LGPL and the utilities under
-- the GPL, see COPYING.LIB and COPYING files respectively.
-- Check out http://mdbtools.sourceforge.net
-- ----------------------------------------------------------

-- That file uses encoding UTF-8

CREATE TABLE `TABLE_CLIENTS_HISTORIQUE_CREDIT_INITIAL`
 (
	`ID`			int not null auto_increment unique, 
	`Dates`			datetime, 
	`HEURE`			varchar (255), 
	`UTILISATEUR`			varchar (255), 
	`ID_CLIENT`			varchar (255), 
	`CLIENT`			varchar (255), 
	`VALEUR_ANCIENNE`			double, 
	`VALEUR_NOUVELLE`			double
);

-- CREATE INDEXES ...
ALTER TABLE `TABLE_CLIENTS_HISTORIQUE_CREDIT_INITIAL` ADD PRIMARY KEY (`ID`);



INSERT INTO `TABLE_CLIENTS_HISTORIQUE_CREDIT_INITIAL` (`ID`, `Dates`, `HEURE`, `UTILISATEUR`, `ID_CLIENT`, `CLIENT`, `VALEUR_ANCIENNE`, `VALEUR_NOUVELLE`) VALUES (1,"2023-09-29 00:00:00","20:21:45","LE PATRON","CL000012","test",1000,222);

-- ----------------------------------------------------------
-- MDB Tools - A library for reading MS Access database files
-- Copyright (C) 2000-2011 Brian Bruns and others.
-- Files in libmdb are licensed under LGPL and the utilities under
-- the GPL, see COPYING.LIB and COPYING files respectively.
-- Check out http://mdbtools.sourceforge.net
-- ----------------------------------------------------------

-- That file uses encoding UTF-8

CREATE TABLE `TABLE_CLIENTS_REGLE`
 (
	`ID`			int NOT NULL AUTO_INCREMENT UNIQUE, 
	`DATES`			datetime, 
	`ID_REGLE`			varchar (255), 
	`ID_CLIENT`			varchar (255), 
	`CODE_CLIENT`			varchar (255), 
	`CLIENT`			varchar (255), 
	`MONTANT`			double, 
	`MODE_P`			varchar (255), 
	`NOTES`			varchar (255), 
	`CLOTURE_CAISSIER`			varchar (255), 
	`CLOTURE_GLOBALE`			varchar (255), 
	`ETAT`			varchar (255), 
	`UTILISATEUR`			varchar (255)
);

-- CREATE INDEXES ...
ALTER TABLE `TABLE_CLIENTS_REGLE` ADD INDEX `CODE_CLIENT` (`CODE_CLIENT`);
ALTER TABLE `TABLE_CLIENTS_REGLE` ADD INDEX `ID_REGLE` (`ID_REGLE`);
ALTER TABLE `TABLE_CLIENTS_REGLE` ADD PRIMARY KEY (`ID`);




-- ----------------------------------------------------------
-- MDB Tools - A library for reading MS Access database files
-- Copyright (C) 2000-2011 Brian Bruns and others.
-- Files in libmdb are licensed under LGPL and the utilities under
-- the GPL, see COPYING.LIB and COPYING files respectively.
-- Check out http://mdbtools.sourceforge.net
-- ----------------------------------------------------------

-- That file uses encoding UTF-8

CREATE TABLE `TABLE_CMD_SPECIALE_DETAILS`
 (
	`ID`			int not null auto_increment unique, 
	`ID_CMD_SP`			varchar (255), 
	`N_CMD_SP`			varchar (255), 
	`Ticket`			varchar (255), 
	`Dates`			datetime, 
	`Heure`			varchar (255), 
	`Code`			varchar (255), 
	`ID_ARTICLE`			varchar (255), 
	`Article`			varchar (255), 
	`Famille`			varchar (255), 
	`PRIX_A`			double, 
	`PRIX_MP`			double, 
	`PRIX_V`			double, 
	`Qté`			double, 
	`Remise`			double, 
	`TOTAL_NET`			double, 
	`Caissier`			varchar (255), 
	`Vendeur`			varchar (255), 
	`TAUX_TVA`			double, 
	`PRINTER`			varchar (255), 
	`PRINTER_DUPLICATA`			varchar (255)
);

-- CREATE INDEXES ...
ALTER TABLE `TABLE_CMD_SPECIALE_DETAILS` ADD INDEX `Code` (`Code`);
ALTER TABLE `TABLE_CMD_SPECIALE_DETAILS` ADD PRIMARY KEY (`ID`);




-- ----------------------------------------------------------
-- MDB Tools - A library for reading MS Access database files
-- Copyright (C) 2000-2011 Brian Bruns and others.
-- Files in libmdb are licensed under LGPL and the utilities under
-- the GPL, see COPYING.LIB and COPYING files respectively.
-- Check out http://mdbtools.sourceforge.net
-- ----------------------------------------------------------

-- That file uses encoding UTF-8

CREATE TABLE `TABLE_CMD_SPECIALE_ENTETE`
 (
	`ID`			int NOT NULL AUTO_INCREMENT UNIQUE, 
	`ID_CMD_SP`			varchar (255), 
	`N_CMD_SP`			varchar (255), 
	`DATES`			datetime, 
	`DATES_LIVRAISON`			datetime, 
	`HEURE`			varchar (255), 
	`UTILISATEUR`			varchar (255), 
	`CLIENT`			varchar (255), 
	`TELEPHONE`			varchar (255), 
	`DESCRIPTION`			varchar (255), 
	`MONTANT_TOTAL`			double, 
	`AVANCE_1`			double, 
	`AVANCE_2`			double, 
	`AVANCE_3`			double, 
	`COMPLEMENT`			double, 
	`ETAT`			varchar (255), 
	`MODE_P_1`			varchar (255), 
	`MODE_P_2`			varchar (255), 
	`MODE_P_3`			varchar (255)
);

-- CREATE INDEXES ...
ALTER TABLE `TABLE_CMD_SPECIALE_ENTETE` ADD PRIMARY KEY (`ID`);




-- ----------------------------------------------------------
-- MDB Tools - A library for reading MS Access database files
-- Copyright (C) 2000-2011 Brian Bruns and others.
-- Files in libmdb are licensed under LGPL and the utilities under
-- the GPL, see COPYING.LIB and COPYING files respectively.
-- Check out http://mdbtools.sourceforge.net
-- ----------------------------------------------------------

-- That file uses encoding UTF-8

CREATE TABLE `TABLE_COMMANDES_DETAILS`
 (
	`ID`			int not null auto_increment unique, 
	`Dates`			datetime, 
	`ID_BC`			varchar (255), 
	`ID_FOURNISSEUR`			varchar (255), 
	`CODE_FOURNISSEUR`			varchar (255), 
	`FOURNISSEUR`			varchar (255), 
	`N_BON_FOURNISSEUR`			varchar (255), 
	`ID_ARTICLE`			varchar (255), 
	`Code`			varchar (255), 
	`Article`			varchar (255), 
	`Prix_A`			double, 
	`Prix_V`			double, 
	`Qté`			double, 
	`TOTAL_NET_ACHATS`			double, 
	`TOTAL_NET_VENTES`			double, 
	`DATE_PEREMPTION`			datetime, 
	`ETAT`			varchar (255)
);

-- CREATE INDEXES ...
ALTER TABLE `TABLE_COMMANDES_DETAILS` ADD INDEX `Code` (`Code`);
ALTER TABLE `TABLE_COMMANDES_DETAILS` ADD INDEX `CODE_FOURNISSEUR` (`CODE_FOURNISSEUR`);
ALTER TABLE `TABLE_COMMANDES_DETAILS` ADD INDEX `ID_BL` (`ID_BC`);
ALTER TABLE `TABLE_COMMANDES_DETAILS` ADD PRIMARY KEY (`ID`);




-- ----------------------------------------------------------
-- MDB Tools - A library for reading MS Access database files
-- Copyright (C) 2000-2011 Brian Bruns and others.
-- Files in libmdb are licensed under LGPL and the utilities under
-- the GPL, see COPYING.LIB and COPYING files respectively.
-- Check out http://mdbtools.sourceforge.net
-- ----------------------------------------------------------

-- That file uses encoding UTF-8

CREATE TABLE `TABLE_COMMANDES_ENTETE`
 (
	`ID`			int NOT NULL AUTO_INCREMENT UNIQUE, 
	`Dates`			datetime, 
	`ID_BC`			varchar (255), 
	`UTILISATEUR`			varchar (255), 
	`ID_FOURNISSEUR`			varchar (255), 
	`CODE_FOURNISSEUR`			varchar (255), 
	`FOURNISSEUR`			varchar (255), 
	`N_BON_FOURNISSEUR`			varchar (255), 
	`TOTAL_NET_ACHATS`			double, 
	`TOTAL_NET_VENTES`			double, 
	`NOTES`			varchar (255), 
	`ETAT`			varchar (255)
);

-- CREATE INDEXES ...
ALTER TABLE `TABLE_COMMANDES_ENTETE` ADD INDEX `Code` (`UTILISATEUR`);
ALTER TABLE `TABLE_COMMANDES_ENTETE` ADD INDEX `CODE_FOURNISSEUR` (`CODE_FOURNISSEUR`);
ALTER TABLE `TABLE_COMMANDES_ENTETE` ADD INDEX `ID_BL` (`ID_BC`);
ALTER TABLE `TABLE_COMMANDES_ENTETE` ADD PRIMARY KEY (`ID`);




-- ----------------------------------------------------------
-- MDB Tools - A library for reading MS Access database files
-- Copyright (C) 2000-2011 Brian Bruns and others.
-- Files in libmdb are licensed under LGPL and the utilities under
-- the GPL, see COPYING.LIB and COPYING files respectively.
-- Check out http://mdbtools.sourceforge.net
-- ----------------------------------------------------------

-- That file uses encoding UTF-8

CREATE TABLE `TABLE_DEPENSES`
 (
	`ID`			int NOT NULL AUTO_INCREMENT UNIQUE, 
	`DATES`			datetime, 
	`HEURE`			varchar (255), 
	`UTILISATEUR`			varchar (255), 
	`DEPENSE`			varchar (255), 
	`MONTANT`			double, 
	`CLOTURE_CAISSIER`			varchar (255), 
	`CLOTURE_GLOBALE`			varchar (255)
);

-- CREATE INDEXES ...
ALTER TABLE `TABLE_DEPENSES` ADD PRIMARY KEY (`ID`);




-- ----------------------------------------------------------
-- MDB Tools - A library for reading MS Access database files
-- Copyright (C) 2000-2011 Brian Bruns and others.
-- Files in libmdb are licensed under LGPL and the utilities under
-- the GPL, see COPYING.LIB and COPYING files respectively.
-- Check out http://mdbtools.sourceforge.net
-- ----------------------------------------------------------

-- That file uses encoding UTF-8

CREATE TABLE `TABLE_DEVIS_DETAILS`
 (
	`ID`			int not null auto_increment unique
);

-- CREATE INDEXES ...
ALTER TABLE `TABLE_DEVIS_DETAILS` ADD PRIMARY KEY (`ID`);




-- ----------------------------------------------------------
-- MDB Tools - A library for reading MS Access database files
-- Copyright (C) 2000-2011 Brian Bruns and others.
-- Files in libmdb are licensed under LGPL and the utilities under
-- the GPL, see COPYING.LIB and COPYING files respectively.
-- Check out http://mdbtools.sourceforge.net
-- ----------------------------------------------------------

-- That file uses encoding UTF-8

CREATE TABLE `TABLE_FACTURE_DETAILS`
 (
	`ID`			int not null auto_increment unique
);

-- CREATE INDEXES ...
ALTER TABLE `TABLE_FACTURE_DETAILS` ADD PRIMARY KEY (`ID`);




-- ----------------------------------------------------------
-- MDB Tools - A library for reading MS Access database files
-- Copyright (C) 2000-2011 Brian Bruns and others.
-- Files in libmdb are licensed under LGPL and the utilities under
-- the GPL, see COPYING.LIB and COPYING files respectively.
-- Check out http://mdbtools.sourceforge.net
-- ----------------------------------------------------------

-- That file uses encoding UTF-8

CREATE TABLE `TABLE_FACTURE_ENTETE`
 (
	`ID`			int not null auto_increment unique
);

-- CREATE INDEXES ...
ALTER TABLE `TABLE_FACTURE_ENTETE` ADD PRIMARY KEY (`ID`);




-- ----------------------------------------------------------
-- MDB Tools - A library for reading MS Access database files
-- Copyright (C) 2000-2011 Brian Bruns and others.
-- Files in libmdb are licensed under LGPL and the utilities under
-- the GPL, see COPYING.LIB and COPYING files respectively.
-- Check out http://mdbtools.sourceforge.net
-- ----------------------------------------------------------

-- That file uses encoding UTF-8

CREATE TABLE `TABLE_FAMILLES`
 (
	`ID`			int NOT NULL AUTO_INCREMENT UNIQUE, 
	`Ordre`			int, 
	`Famille`			varchar (255), 
	`VISIBLE`			varchar (255), 
	`TYPE`			varchar (255), 
	`Images`			varchar (255)
);

-- CREATE INDEXES ...
ALTER TABLE `TABLE_FAMILLES` ADD PRIMARY KEY (`ID`);



INSERT INTO `TABLE_FAMILLES` (`ID`, `Ordre`, `Famille`, `VISIBLE`, `TYPE`, `Images`) VALUES (1,1,"BOISSONS CHAUDES","OUI","FAMILLE","22-08-2023 00-18-55-7608194.Png"), (2,2,"SODA","OUI","FAMILLE","22-08-2023 00-18-59-7115913.Png"), (3,3,"JUS","OUI","FAMILLE","22-08-2023 00-19-03-1682101.Png"), (4,4,"PETITS DEJ","OUI","FAMILLE","22-08-2023 00-19-06-9650271.Png"), (5,5,"VIENNOISERIE","OUI","FAMILLE","22-08-2023 00-19-10-6677206.Png"), (6,6,"GATEAUX","OUI","FAMILLE","22-08-2023 00-19-15-3277757.Png"), (7,7,"GLACES","OUI","FAMILLE","22-08-2023 00-19-19-7504493.Png"), (8,8,"SALADE","OUI","FAMILLE","22-08-2023 00-19-23-1718221.Png"), (9,9,"DESSERT","OUI","FAMILLE","22-08-2023 00-19-26-9742131.Png"), (10,10,"TACOS","OUI","FAMILLE","22-08-2023 00-19-30-3880401.Png"), (11,11,"BURGER","OUI","FAMILLE","22-08-2023 00-19-34-8419212.Png"), (12,12,"PIZZA","OUI","FAMILLE","22-08-2023 00-19-38-6785196.Png"), (13,13,"SAUCE CHOIX","OUI","PAGE","0.png"), (14,14,"FRITE CHOIX","OUI","PAGE","0.png"), (15,15,"BOISSONS CHOIX","OUI","PAGE","0.png");

-- ----------------------------------------------------------
-- MDB Tools - A library for reading MS Access database files
-- Copyright (C) 2000-2011 Brian Bruns and others.
-- Files in libmdb are licensed under LGPL and the utilities under
-- the GPL, see COPYING.LIB and COPYING files respectively.
-- Check out http://mdbtools.sourceforge.net
-- ----------------------------------------------------------

-- That file uses encoding UTF-8

CREATE TABLE `TABLE_FOURNISSEURS`
 (
	`ID`			int NOT NULL AUTO_INCREMENT UNIQUE, 
	`DATES`			datetime, 
	`ID_FOURNISSEUR`			varchar (255), 
	`CODE_FOURNISSEUR`			varchar (255), 
	`FOURNISSEUR`			varchar (255), 
	`ICE`			varchar (255), 
	`ADRESSE`			varchar (255), 
	`VILLE`			varchar (255), 
	`PAYS`			varchar (255), 
	`TELEPHONE`			varchar (255), 
	`NOTES`			varchar (255), 
	`ETAT`			varchar (255), 
	`CREDIT_INITIAL`			decimal(19,4)
);

-- CREATE INDEXES ...
ALTER TABLE `TABLE_FOURNISSEURS` ADD INDEX `CODE_FOURNISSEUR` (`CODE_FOURNISSEUR`);

ALTER TABLE `TABLE_FOURNISSEURS` ADD PRIMARY KEY (`ID`);




-- ----------------------------------------------------------
-- MDB Tools - A library for reading MS Access database files
-- Copyright (C) 2000-2011 Brian Bruns and others.
-- Files in libmdb are licensed under LGPL and the utilities under
-- the GPL, see COPYING.LIB and COPYING files respectively.
-- Check out http://mdbtools.sourceforge.net
-- ----------------------------------------------------------

-- That file uses encoding UTF-8

CREATE TABLE `TABLE_FOURNISSEURS_HISTORIQUE_CREDIT_INITIAL`
 (
	`ID`			int not null auto_increment unique, 
	`Dates`			datetime, 
	`HEURE`			varchar (255), 
	`UTILISATEUR`			varchar (255), 
	`ID_FOURNISSEUR`			varchar (255), 
	`FOURNISSEUR`			varchar (255), 
	`VALEUR_ANCIENNE`			double, 
	`VALEUR_NOUVELLE`			double
);

-- CREATE INDEXES ...
ALTER TABLE `TABLE_FOURNISSEURS_HISTORIQUE_CREDIT_INITIAL` ADD PRIMARY KEY (`ID`);



INSERT INTO `TABLE_FOURNISSEURS_HISTORIQUE_CREDIT_INITIAL` (`ID`, `Dates`, `HEURE`, `UTILISATEUR`, `ID_FOURNISSEUR`, `FOURNISSEUR`, `VALEUR_ANCIENNE`, `VALEUR_NOUVELLE`) VALUES (1,"2023-09-29 00:00:00","20:22:17","LE PATRON","FR000003","ddd",0,222), (2,"2023-10-29 00:00:00","11:13:05","LE PATRON","FR000003","ddd",222,122), (3,"2023-10-29 00:00:00","11:13:13","LE PATRON","FR000003","ddd",122,33), (4,"2023-10-29 00:00:00","11:40:15","LE PATRON","FR000003","ddd",33,100);

-- ----------------------------------------------------------
-- MDB Tools - A library for reading MS Access database files
-- Copyright (C) 2000-2011 Brian Bruns and others.
-- Files in libmdb are licensed under LGPL and the utilities under
-- the GPL, see COPYING.LIB and COPYING files respectively.
-- Check out http://mdbtools.sourceforge.net
-- ----------------------------------------------------------

-- That file uses encoding UTF-8

CREATE TABLE `TABLE_FOURNISSEURS_REGLE`
 (
	`ID`			int NOT NULL AUTO_INCREMENT UNIQUE, 
	`DATES`			datetime, 
	`ID_REGLE`			varchar (255), 
	`ID_FOURNISSEUR`			varchar (255), 
	`CODE_FOURNISSEUR`			varchar (255), 
	`FOURNISSEUR`			varchar (255), 
	`MONTANT`			double, 
	`MODE_P`			varchar (255), 
	`NOTES`			varchar (255), 
	`CLOTURE_CAISSIER`			varchar (255), 
	`CLOTURE_GLOBALE`			varchar (255), 
	`ETAT`			varchar (255), 
	`UTILISATEUR`			varchar (255)
);

-- CREATE INDEXES ...
ALTER TABLE `TABLE_FOURNISSEURS_REGLE` ADD INDEX `CODE_CLIENT` (`CODE_FOURNISSEUR`);
ALTER TABLE `TABLE_FOURNISSEURS_REGLE` ADD INDEX `ID_REGLE` (`ID_REGLE`);
ALTER TABLE `TABLE_FOURNISSEURS_REGLE` ADD PRIMARY KEY (`ID`);




-- ----------------------------------------------------------
-- MDB Tools - A library for reading MS Access database files
-- Copyright (C) 2000-2011 Brian Bruns and others.
-- Files in libmdb are licensed under LGPL and the utilities under
-- the GPL, see COPYING.LIB and COPYING files respectively.
-- Check out http://mdbtools.sourceforge.net
-- ----------------------------------------------------------

-- That file uses encoding UTF-8

CREATE TABLE `TABLE_INVENTAIRES_ENTETE`
 (
	`ID`			int NOT NULL AUTO_INCREMENT UNIQUE, 
	`Dates`			datetime, 
	`ID_INV`			varchar (255), 
	`UTILISATEUR`			varchar (255), 
	`NOTES`			varchar (255), 
	`TOTAL_VALEUR`			double, 
	`ETAT`			varchar (255), 
	`DETAILS`			varchar (255)
);

-- CREATE INDEXES ...

ALTER TABLE `TABLE_INVENTAIRES_ENTETE` ADD INDEX `ID_BR` (`ID_INV`);
ALTER TABLE `TABLE_INVENTAIRES_ENTETE` ADD PRIMARY KEY (`ID`);
ALTER TABLE `TABLE_INVENTAIRES_ENTETE` ADD INDEX `UTILISATEUR` (`UTILISATEUR`);




-- ----------------------------------------------------------
-- MDB Tools - A library for reading MS Access database files
-- Copyright (C) 2000-2011 Brian Bruns and others.
-- Files in libmdb are licensed under LGPL and the utilities under
-- the GPL, see COPYING.LIB and COPYING files respectively.
-- Check out http://mdbtools.sourceforge.net
-- ----------------------------------------------------------

-- That file uses encoding UTF-8

CREATE TABLE `TABLE_LICENCE`
 (
	`ID`			int not null auto_increment unique, 
	`USER`			varchar (255), 
	`PASS`			varchar (255), 
	`PASS_ENTREE`			varchar (255), 
	`IMPACT`			varchar (255), 
	`DATES`			datetime, 
	`SOLUTION`			varchar (255)
);

-- CREATE INDEXES ...
ALTER TABLE `TABLE_LICENCE` ADD INDEX `ID_USER` (`USER`);
ALTER TABLE `TABLE_LICENCE` ADD PRIMARY KEY (`ID`);




-- ----------------------------------------------------------
-- MDB Tools - A library for reading MS Access database files
-- Copyright (C) 2000-2011 Brian Bruns and others.
-- Files in libmdb are licensed under LGPL and the utilities under
-- the GPL, see COPYING.LIB and COPYING files respectively.
-- Check out http://mdbtools.sourceforge.net
-- ----------------------------------------------------------

-- That file uses encoding UTF-8

CREATE TABLE `TABLE_MODE_P`
 (
	`ID`			int NOT NULL AUTO_INCREMENT UNIQUE, 
	`MODE_P`			varchar (255), 
	`Images`			varchar (255)
);

-- CREATE INDEXES ...
ALTER TABLE `TABLE_MODE_P` ADD PRIMARY KEY (`ID`);



INSERT INTO `TABLE_MODE_P` (`ID`, `MODE_P`, `Images`) VALUES (1,"ESPECES","ESPECES.png"), (2,"CARTE","CARTE.png");

-- ----------------------------------------------------------
-- MDB Tools - A library for reading MS Access database files
-- Copyright (C) 2000-2011 Brian Bruns and others.
-- Files in libmdb are licensed under LGPL and the utilities under
-- the GPL, see COPYING.LIB and COPYING files respectively.
-- Check out http://mdbtools.sourceforge.net
-- ----------------------------------------------------------

-- That file uses encoding UTF-8

CREATE TABLE `TABLE_MOUVEMENTS_STOCK`
 (
	`ID`			int not null auto_increment unique, 
	`DATES`			datetime, 
	`HEURE`			varchar (255), 
	`LIBELLE`			varchar (255), 
	`ID_ARTICLE`			varchar (255), 
	`CODE_ARTICLE`			varchar (255), 
	`ARTICLE`			varchar (255), 
	`QUANTITE`			varchar (255)
);

-- CREATE INDEXES ...
ALTER TABLE `TABLE_MOUVEMENTS_STOCK` ADD INDEX `CODE_ARTICLE` (`CODE_ARTICLE`);
ALTER TABLE `TABLE_MOUVEMENTS_STOCK` ADD PRIMARY KEY (`ID`);




-- ----------------------------------------------------------
-- MDB Tools - A library for reading MS Access database files
-- Copyright (C) 2000-2011 Brian Bruns and others.
-- Files in libmdb are licensed under LGPL and the utilities under
-- the GPL, see COPYING.LIB and COPYING files respectively.
-- Check out http://mdbtools.sourceforge.net
-- ----------------------------------------------------------

-- That file uses encoding UTF-8

CREATE TABLE `TABLE_NOMENCLATURE`
 (
	`ID`			int NOT NULL AUTO_INCREMENT UNIQUE, 
	`ID_ARTICLE`			varchar (255), 
	`CODE_ARTICLE`			varchar (255), 
	`ARTICLE`			varchar (255), 
	`ID_MP`			varchar (255), 
	`CODE_MP`			varchar (255), 
	`MP`			varchar (255), 
	`QTE`			varchar (255), 
	`UNITE`			varchar (255), 
	`PRIX_A`			varchar (255)
);

-- CREATE INDEXES ...

ALTER TABLE `TABLE_NOMENCLATURE` ADD PRIMARY KEY (`ID`);




-- ----------------------------------------------------------
-- MDB Tools - A library for reading MS Access database files
-- Copyright (C) 2000-2011 Brian Bruns and others.
-- Files in libmdb are licensed under LGPL and the utilities under
-- the GPL, see COPYING.LIB and COPYING files respectively.
-- Check out http://mdbtools.sourceforge.net
-- ----------------------------------------------------------

-- That file uses encoding UTF-8

CREATE TABLE `TABLE_NUM`
 (
	`ID`			int NOT NULL AUTO_INCREMENT UNIQUE, 
	`CL`			int, 
	`C1`			int, 
	`ADDI`			int, 
	`ARTICLE`			int, 
	`CLIENT`			int, 
	`FOURNISSEUR`			int, 
	`BC`			int, 
	`BR`			int, 
	`BS`			int, 
	`INV`			int, 
	`DEVIS`			int, 
	`BL`			int, 
	`FACTURE`			int
);

-- CREATE INDEXES ...
ALTER TABLE `TABLE_NUM` ADD PRIMARY KEY (`ID`);



INSERT INTO `TABLE_NUM` (`ID`, `CL`, `C1`, `ADDI`, `ARTICLE`, `CLIENT`, `FOURNISSEUR`, `BC`, `BR`, `BS`, `INV`, `DEVIS`, `BL`, `FACTURE`) VALUES (0,51,5,4,20,15,4,6,10,4,3,1,1,1);

-- ----------------------------------------------------------
-- MDB Tools - A library for reading MS Access database files
-- Copyright (C) 2000-2011 Brian Bruns and others.
-- Files in libmdb are licensed under LGPL and the utilities under
-- the GPL, see COPYING.LIB and COPYING files respectively.
-- Check out http://mdbtools.sourceforge.net
-- ----------------------------------------------------------

-- That file uses encoding UTF-8

CREATE TABLE `TABLE_PARAMETRES`
 (
	`ID`			int not null auto_increment unique, 
	`OBJET`			varchar (255), 
	`VALEUR`			text
);

-- CREATE INDEXES ...
ALTER TABLE `TABLE_PARAMETRES` ADD PRIMARY KEY (`ID`);



INSERT INTO `TABLE_PARAMETRES` (`ID`, `OBJET`, `VALEUR`) VALUES (1,"FENETRE_MODE_P","True"), (2,"GESTION_STOCK","False"), (3,"MODIF_STOCK_MANUEL","False"), (4,"AJOUT_STOCK_MANUEL","False"), (5,"VENTE_CODE_BARRE","False"), (6,"ENVOIE_ANNULATION","False"), (7,"COMPOSITIONS_AUTO","False"), (8,"PRIX_TALON","False"), (9,"SOLDER_SANS_TICKET","False"), (10,"GESTION_TABLE","False"), (11,"GESTION_CLOTURE","False"), (12,"CLOTURE_CAISSIER_OBLIGER","False"), (13,"BRANCHEMENT","USB"), (14,"MODELE_TICKET","FR_3C"), (15,NULL,NULL), (16,NULL,NULL), (17,NULL,NULL), (18,NULL,NULL), (19,NULL,NULL), (20,NULL,NULL), (21,"CODE_WIFI",NULL), (22,"AFFICHER_MODE_P","False"), (23,"AFFICHER_N_TICKET","True"), (24,"AFFICHER_MODE_V","False"), (25,"PIED_TICKET","-------------------------------------------
           MERCI DE VOTRE VISITE
                 A BIENTOT
-------------------------------------------
dcdc
dcdc
dcd
cdcd
cdcdcccccccccccc
"), (26,"AFFICHER_CODE_BARRE","False"), (27,"AFFICHEUR_PORT",NULL), (28,"AFFICHEUR_BAUDRATE",NULL), (29,"BALANCE_PORT",NULL), (30,"MAIL_ADRESSE",NULL), (31,"MAIL_TITRE",NULL), (32,"THEME","22; 106; 238"), (33,NULL,NULL), (34,NULL,NULL), (35,NULL,NULL), (36,NULL,NULL), (37,NULL,NULL), (38,NULL,NULL), (39,NULL,NULL), (40,NULL,NULL), (41,"NBR_CODE_ARTICLE","4"), (42,"NBR_CODE_BALANCE","4"), (43,"HEURE_RETARD","0"), (44,"LANGUE","fr"), (45,"PIED_DOC",NULL), (46,"DEPENSES",NULL), (47,NULL,NULL), (48,NULL,NULL), (49,NULL,NULL), (50,NULL,NULL), (51,"MESSAGE_CUISINE","test
test2
"), (52,"COMMENTAIRES_A","test
test 2
wwww
xxx
edede
"), (53,"COMMENTAIRES_B",NULL), (54,"COMMENTAIRES_C",NULL), (55,NULL,NULL), (56,NULL,NULL), (57,NULL,NULL), (58,NULL,NULL), (59,NULL,NULL), (60,NULL,NULL), (61,NULL,NULL);

-- ----------------------------------------------------------
-- MDB Tools - A library for reading MS Access database files
-- Copyright (C) 2000-2011 Brian Bruns and others.
-- Files in libmdb are licensed under LGPL and the utilities under
-- the GPL, see COPYING.LIB and COPYING files respectively.
-- Check out http://mdbtools.sourceforge.net
-- ----------------------------------------------------------

-- That file uses encoding UTF-8

CREATE TABLE `TABLE_PASS`
 (
	`ID`			int NOT NULL AUTO_INCREMENT UNIQUE, 
	`ID_USER`			varchar (255), 
	`ListUser`			varchar (255), 
	`ListPass`			varchar (255), 
	`Catégorie`			varchar (255), 
	`RETOUR`			varchar (255), 
	`REMISE`			varchar (255), 
	`MODIF_PRIX`			varchar (255), 
	`MODIF_QTE`			varchar (255), 
	`PRIX`			varchar (255), 
	`DIVERS`			varchar (255), 
	`DUPLICATA`			varchar (255), 
	`FLASH`			varchar (255), 
	`TIROIR`			varchar (255), 
	`ANNULATION`			varchar (255), 
	`RAPPORT`			varchar (255), 
	`DEPENSES`			varchar (255), 
	`RECEPTIONS`			varchar (255), 
	`SORTIES`			varchar (255), 
	`CLIENTS`			varchar (255), 
	`CLIENTS_REGLEMENTS`			varchar (255), 
	`ARTICLES`			varchar (255), 
	`ADDITION`			varchar (255), 
	`SOLDER`			varchar (255), 
	`DIRECTE`			varchar (255), 
	`CLOTURE`			varchar (255), 
	`TRANSFERT`			varchar (255), 
	`SEPARATION`			varchar (255)
);

-- CREATE INDEXES ...
ALTER TABLE `TABLE_PASS` ADD INDEX `ID_USER` (`ID_USER`);
ALTER TABLE `TABLE_PASS` ADD PRIMARY KEY (`ID`);



INSERT INTO `TABLE_PASS` (`ID`, `ID_USER`, `ListUser`, `ListPass`, `Catégorie`, `RETOUR`, `REMISE`, `MODIF_PRIX`, `MODIF_QTE`, `PRIX`, `DIVERS`, `DUPLICATA`, `FLASH`, `TIROIR`, `ANNULATION`, `RAPPORT`, `DEPENSES`, `RECEPTIONS`, `SORTIES`, `CLIENTS`, `CLIENTS_REGLEMENTS`, `ARTICLES`, `ADDITION`, `SOLDER`, `DIRECTE`, `CLOTURE`, `TRANSFERT`, `SEPARATION`) VALUES (5,"982739872397333","LE PATRON","0000","ADMIN","VISIBLE","VISIBLE","VISIBLE","VISIBLE","VISIBLE","VISIBLE","VISIBLE","VISIBLE","VISIBLE","VISIBLE","VISIBLE","VISIBLE","VISIBLE","VISIBLE","VISIBLE","VISIBLE","VISIBLE","VISIBLE","VISIBLE","VISIBLE","VISIBLE","VISIBLE","VISIBLE"), (6,"150723161739054","CAISSIER","1","UTILISATEUR","VISIBLE","INVISIBLE","INVISIBLE","INVISIBLE","INVISIBLE","INVISIBLE","INVISIBLE","INVISIBLE","INVISIBLE","VISIBLE","VISIBLE","INVISIBLE","INVISIBLE","INVISIBLE","INVISIBLE","INVISIBLE","INVISIBLE","VISIBLE","VISIBLE","VISIBLE","INVISIBLE","VISIBLE","VISIBLE");

-- ----------------------------------------------------------
-- MDB Tools - A library for reading MS Access database files
-- Copyright (C) 2000-2011 Brian Bruns and others.
-- Files in libmdb are licensed under LGPL and the utilities under
-- the GPL, see COPYING.LIB and COPYING files respectively.
-- Check out http://mdbtools.sourceforge.net
-- ----------------------------------------------------------

-- That file uses encoding UTF-8

CREATE TABLE `TABLE_POUBELLE`
 (
	`ID`			int not null auto_increment unique, 
	`Dates`			datetime, 
	`Heure`			varchar (255), 
	`Article`			varchar (255), 
	`Qté`			double, 
	`Caissier`			varchar (255), 
	`TOTAL_NET`			double, 
	`CLOTURE_CAISSIER`			varchar (255), 
	`CLOTURE_GLOBALE`			varchar (255)
);

-- CREATE INDEXES ...
ALTER TABLE `TABLE_POUBELLE` ADD PRIMARY KEY (`ID`);




-- ----------------------------------------------------------
-- MDB Tools - A library for reading MS Access database files
-- Copyright (C) 2000-2011 Brian Bruns and others.
-- Files in libmdb are licensed under LGPL and the utilities under
-- the GPL, see COPYING.LIB and COPYING files respectively.
-- Check out http://mdbtools.sourceforge.net
-- ----------------------------------------------------------

-- That file uses encoding UTF-8

CREATE TABLE `TABLE_RECEPTIONS_DETAILS`
 (
	`ID`			int not null auto_increment unique, 
	`Dates`			datetime, 
	`ID_BR`			varchar (255), 
	`ID_FOURNISSEUR`			varchar (255), 
	`CODE_FOURNISSEUR`			varchar (255), 
	`FOURNISSEUR`			varchar (255), 
	`N_BON_FOURNISSEUR`			varchar (255), 
	`ID_ARTICLE`			varchar (255), 
	`Code`			varchar (255), 
	`Article`			varchar (255), 
	`Prix_A`			double, 
	`Prix_V`			double, 
	`Qté`			double, 
	`TOTAL_NET_ACHATS`			double, 
	`TOTAL_NET_VENTES`			double, 
	`DATE_PEREMPTION`			datetime, 
	`ETAT`			varchar (255)
);

-- CREATE INDEXES ...
ALTER TABLE `TABLE_RECEPTIONS_DETAILS` ADD INDEX `Code` (`Code`);
ALTER TABLE `TABLE_RECEPTIONS_DETAILS` ADD INDEX `CODE_FOURNISSEUR` (`CODE_FOURNISSEUR`);
ALTER TABLE `TABLE_RECEPTIONS_DETAILS` ADD INDEX `ID_BL` (`ID_BR`);
ALTER TABLE `TABLE_RECEPTIONS_DETAILS` ADD PRIMARY KEY (`ID`);




-- ----------------------------------------------------------
-- MDB Tools - A library for reading MS Access database files
-- Copyright (C) 2000-2011 Brian Bruns and others.
-- Files in libmdb are licensed under LGPL and the utilities under
-- the GPL, see COPYING.LIB and COPYING files respectively.
-- Check out http://mdbtools.sourceforge.net
-- ----------------------------------------------------------

-- That file uses encoding UTF-8

CREATE TABLE `TABLE_RECEPTIONS_ENTETE`
 (
	`ID`			int NOT NULL AUTO_INCREMENT UNIQUE, 
	`Dates`			datetime, 
	`ID_BR`			varchar (255), 
	`UTILISATEUR`			varchar (255), 
	`ID_FOURNISSEUR`			varchar (255), 
	`CODE_FOURNISSEUR`			varchar (255), 
	`FOURNISSEUR`			varchar (255), 
	`N_BON_FOURNISSEUR`			varchar (255), 
	`TOTAL_NET_ACHATS`			double, 
	`TOTAL_NET_VENTES`			double, 
	`NOTES`			varchar (255), 
	`ETAT`			varchar (255)
);

-- CREATE INDEXES ...
ALTER TABLE `TABLE_RECEPTIONS_ENTETE` ADD INDEX `Code` (`UTILISATEUR`);
ALTER TABLE `TABLE_RECEPTIONS_ENTETE` ADD INDEX `CODE_FOURNISSEUR` (`CODE_FOURNISSEUR`);
ALTER TABLE `TABLE_RECEPTIONS_ENTETE` ADD INDEX `ID_BL` (`ID_BR`);
ALTER TABLE `TABLE_RECEPTIONS_ENTETE` ADD PRIMARY KEY (`ID`);




-- ----------------------------------------------------------
-- MDB Tools - A library for reading MS Access database files
-- Copyright (C) 2000-2011 Brian Bruns and others.
-- Files in libmdb are licensed under LGPL and the utilities under
-- the GPL, see COPYING.LIB and COPYING files respectively.
-- Check out http://mdbtools.sourceforge.net
-- ----------------------------------------------------------

-- That file uses encoding UTF-8

CREATE TABLE `TABLE_SEPARATION`
 (
	`ID`			int NOT NULL AUTO_INCREMENT UNIQUE, 
	`Ticket`			varchar (255), 
	`Dates`			datetime, 
	`Heure`			varchar (255), 
	`ID_ARTICLE`			varchar (255), 
	`Code`			varchar (255), 
	`Article`			varchar (255), 
	`Famille`			varchar (255), 
	`PRIX_A`			double, 
	`PRIX_MP`			double, 
	`PRIX_V`			double, 
	`Qté`			double, 
	`Remise`			double, 
	`TOTAL_NET`			double, 
	`Caissier`			varchar (255), 
	`Vendeur`			varchar (255), 
	`TAUX_TVA`			double, 
	`PRINTER`			varchar (255), 
	`PRINTER_DUPLICATA`			varchar (255), 
	`cuisine`			varchar (255)
);

-- CREATE INDEXES ...
ALTER TABLE `TABLE_SEPARATION` ADD INDEX `Code` (`Code`);
ALTER TABLE `TABLE_SEPARATION` ADD PRIMARY KEY (`ID`);




-- ----------------------------------------------------------
-- MDB Tools - A library for reading MS Access database files
-- Copyright (C) 2000-2011 Brian Bruns and others.
-- Files in libmdb are licensed under LGPL and the utilities under
-- the GPL, see COPYING.LIB and COPYING files respectively.
-- Check out http://mdbtools.sourceforge.net
-- ----------------------------------------------------------

-- That file uses encoding UTF-8

CREATE TABLE `TABLE_SORTIES_DETAILS`
 (
	`ID`			int not null auto_increment unique, 
	`Dates`			datetime, 
	`ID_BS`			varchar (255), 
	`ID_FOURNISSEUR`			varchar (255), 
	`CODE_FOURNISSEUR`			varchar (255), 
	`FOURNISSEUR`			varchar (255), 
	`TYPE`			varchar (255), 
	`ID_ARTICLE`			varchar (255), 
	`Code`			varchar (255), 
	`Article`			varchar (255), 
	`Prix_A`			double, 
	`Prix_V`			double, 
	`Qté`			double, 
	`TOTAL_NET_ACHATS`			double, 
	`TOTAL_NET_VENTES`			double, 
	`ETAT`			varchar (255)
);

-- CREATE INDEXES ...
ALTER TABLE `TABLE_SORTIES_DETAILS` ADD INDEX `Code` (`Code`);
ALTER TABLE `TABLE_SORTIES_DETAILS` ADD INDEX `CODE_FOURNISSEUR` (`CODE_FOURNISSEUR`);

ALTER TABLE `TABLE_SORTIES_DETAILS` ADD INDEX `ID_BS` (`ID_BS`);
ALTER TABLE `TABLE_SORTIES_DETAILS` ADD PRIMARY KEY (`ID`);




-- ----------------------------------------------------------
-- MDB Tools - A library for reading MS Access database files
-- Copyright (C) 2000-2011 Brian Bruns and others.
-- Files in libmdb are licensed under LGPL and the utilities under
-- the GPL, see COPYING.LIB and COPYING files respectively.
-- Check out http://mdbtools.sourceforge.net
-- ----------------------------------------------------------

-- That file uses encoding UTF-8

CREATE TABLE `TABLE_SORTIES_ENTETE`
 (
	`ID`			int NOT NULL AUTO_INCREMENT UNIQUE, 
	`Dates`			datetime, 
	`ID_BS`			varchar (255), 
	`UTILISATEUR`			varchar (255), 
	`ID_FOURNISSEUR`			varchar (255), 
	`CODE_FOURNISSEUR`			varchar (255), 
	`FOURNISSEUR`			varchar (255), 
	`TYPE`			varchar (255), 
	`TOTAL_NET_ACHATS`			double, 
	`TOTAL_NET_VENTES`			double, 
	`NOTES`			varchar (255), 
	`ETAT`			varchar (255)
);

-- CREATE INDEXES ...
ALTER TABLE `TABLE_SORTIES_ENTETE` ADD INDEX `CODE_FOURNISSEUR` (`CODE_FOURNISSEUR`);

ALTER TABLE `TABLE_SORTIES_ENTETE` ADD INDEX `ID_BR` (`ID_BS`);
ALTER TABLE `TABLE_SORTIES_ENTETE` ADD PRIMARY KEY (`ID`);
ALTER TABLE `TABLE_SORTIES_ENTETE` ADD INDEX `UTILISATEUR` (`UTILISATEUR`);




-- ----------------------------------------------------------
-- MDB Tools - A library for reading MS Access database files
-- Copyright (C) 2000-2011 Brian Bruns and others.
-- Files in libmdb are licensed under LGPL and the utilities under
-- the GPL, see COPYING.LIB and COPYING files respectively.
-- Check out http://mdbtools.sourceforge.net
-- ----------------------------------------------------------

-- That file uses encoding UTF-8

CREATE TABLE `TABLE_VENTES_ENTETE`
 (
	`ID`			int not null auto_increment unique, 
	`ID_TICKET`			varchar (255), 
	`DATES`			datetime, 
	`TICKET`			varchar (255), 
	`CAISSIER`			varchar (255), 
	`ID_CLIENT`			varchar (255), 
	`CODE_CLIENT`			varchar (255), 
	`CLIENT`			varchar (255), 
	`POSTE`			varchar (255), 
	`TOTAL_NET`			double, 
	`OPERATION`			varchar (255), 
	`CLOTURE_CAISSIER`			varchar (255), 
	`CLOTURE_GLOBALE`			varchar (255), 
	`NOTES`			varchar (255)
);

-- CREATE INDEXES ...
ALTER TABLE `TABLE_VENTES_ENTETE` ADD INDEX `CODE_CLIENT` (`CODE_CLIENT`);

ALTER TABLE `TABLE_VENTES_ENTETE` ADD INDEX `ID_TICKET` (`ID_TICKET`);
ALTER TABLE `TABLE_VENTES_ENTETE` ADD PRIMARY KEY (`ID`);



INSERT INTO `TABLE_VENTES_ENTETE` (`ID`, `ID_TICKET`, `DATES`, `TICKET`, `CAISSIER`, `ID_CLIENT`, `CODE_CLIENT`, `CLIENT`, `POSTE`, `TOTAL_NET`, `OPERATION`, `CLOTURE_CAISSIER`, `CLOTURE_GLOBALE`, `NOTES`) VALUES (1,"23012423330351801","2024-01-23 00:00:00","000039","LE PATRON",NULL,NULL,NULL,"01",70,"VENTE",NULL,NULL,NULL), (2,"23012423331009701","2024-01-23 00:00:00","000040","LE PATRON",NULL,NULL,NULL,"01",30,"VENTE",NULL,NULL,NULL), (3,"24012400251714101","2024-01-24 00:00:00","000041","LE PATRON",NULL,NULL,NULL,"01",80,"VENTE",NULL,NULL,NULL), (5,"24012401084528001","2024-01-24 00:00:00","000043","LE PATRON",NULL,NULL,NULL,"01",20,"VENTE",NULL,NULL,NULL), (6,"24012401085908401","2024-01-24 00:00:00","000044","LE PATRON",NULL,NULL,NULL,"01",60,"VENTE",NULL,NULL,NULL), (7,"24012401121112601","2024-01-24 00:00:00","000045","LE PATRON",NULL,NULL,NULL,"01",10,"VENTE",NULL,NULL,NULL), (8,"24012401125948801","2024-01-24 00:00:00","000046","LE PATRON",NULL,NULL,NULL,"01",44,"VENTE",NULL,NULL,NULL), (9,"24012401131325001","2024-01-24 00:00:00","000047","LE PATRON",NULL,NULL,NULL,"01",20,"VENTE",NULL,NULL,NULL), (10,"24012401133358401","2024-01-24 00:00:00","000048","LE PATRON",NULL,NULL,NULL,"01",184,"VENTE",NULL,NULL,NULL), (11,"24012401140580201","2024-01-24 00:00:00","000049","LE PATRON",NULL,NULL,NULL,"01",10,"VENTE",NULL,NULL,NULL), (12,"24012401141334901","2024-01-24 00:00:00","000050","LE PATRON",NULL,NULL,NULL,"01",80,"VENTE",NULL,NULL,NULL);

-- ----------------------------------------------------------
-- MDB Tools - A library for reading MS Access database files
-- Copyright (C) 2000-2011 Brian Bruns and others.
-- Files in libmdb are licensed under LGPL and the utilities under
-- the GPL, see COPYING.LIB and COPYING files respectively.
-- Check out http://mdbtools.sourceforge.net
-- ----------------------------------------------------------

-- That file uses encoding UTF-8

CREATE TABLE `TABLE_VENTES_JOURNAL`
 (
	`ID`			int not null auto_increment unique, 
	`ID_TICKET`			varchar (255), 
	`Ticket`			varchar (255), 
	`Dates`			datetime, 
	`Heure`			varchar (255), 
	`ID_ARTICLE`			varchar (255), 
	`Code`			varchar (255), 
	`Article`			varchar (255), 
	`Famille`			varchar (255), 
	`PRIX_A`			double, 
	`PRIX_MP`			double, 
	`PRIX_V`			double, 
	`Qté`			double, 
	`Remise`			double, 
	`TOTAL_NET`			double, 
	`TAUX_TVA`			double, 
	`Caissier`			varchar (255), 
	`Vendeur`			varchar (255), 
	`ID_CLIENT`			varchar (255), 
	`CODE_CLIENT`			varchar (255), 
	`CLIENT`			varchar (255), 
	`POSTE`			varchar (255), 
	`OPERATION`			varchar (255), 
	`CLOTURE_CAISSIER`			varchar (255), 
	`CLOTURE_GLOBALE`			varchar (255), 
	`NOTES`			varchar (255)
);

-- CREATE INDEXES ...
ALTER TABLE `TABLE_VENTES_JOURNAL` ADD INDEX `Code` (`Code`);
ALTER TABLE `TABLE_VENTES_JOURNAL` ADD INDEX `CODE_CLIENT` (`CODE_CLIENT`);

ALTER TABLE `TABLE_VENTES_JOURNAL` ADD INDEX `ID_TICKET` (`ID_TICKET`);
ALTER TABLE `TABLE_VENTES_JOURNAL` ADD PRIMARY KEY (`ID`);



INSERT INTO `TABLE_VENTES_JOURNAL` (`ID`, `ID_TICKET`, `Ticket`, `Dates`, `Heure`, `ID_ARTICLE`, `Code`, `Article`, `Famille`, `PRIX_A`, `PRIX_MP`, `PRIX_V`, `Qté`, `Remise`, `TOTAL_NET`, `TAUX_TVA`, `Caissier`, `Vendeur`, `ID_CLIENT`, `CODE_CLIENT`, `CLIENT`, `POSTE`, `OPERATION`, `CLOTURE_CAISSIER`, `CLOTURE_GLOBALE`, `NOTES`) VALUES (1,"23012423330351801","000039","2024-01-23 00:00:00","23:33:04","ART15","70235","COCA LIGHT","SODA",0,0,10,1,0,10,0,"LE PATRON",NULL,NULL,NULL,NULL,"01","VENTE",NULL,NULL,"TABLE_02"), (2,"23012423330351801","000039","2024-01-23 00:00:00","23:33:04","ART000017","6915","COCA ZERO","SODA",0,0,10,1,0,10,0,"LE PATRON",NULL,NULL,NULL,NULL,"01","VENTE",NULL,NULL,"TABLE_02"), (3,"23012423330351801","000039","2024-01-23 00:00:00","23:33:04","ART17","70237","FANTA ORANGE","SODA",0,0,10,1,0,10,0,"LE PATRON",NULL,NULL,NULL,NULL,"01","VENTE",NULL,NULL,"TABLE_02"), (4,"23012423330351801","000039","2024-01-23 00:00:00","23:33:04","ART18","70238","SPRITE","SODA",0,0,10,1,0,10,0,"LE PATRON",NULL,NULL,NULL,NULL,"01","VENTE",NULL,NULL,"TABLE_02"), (5,"23012423330351801","000039","2024-01-23 00:00:00","23:33:04","ART25","70245","EAU MINERALE","SODA",0,0,10,1,0,10,0,"LE PATRON",NULL,NULL,NULL,NULL,"01","VENTE",NULL,NULL,"TABLE_02"), (6,"23012423330351801","000039","2024-01-23 00:00:00","23:33:04","ART24","70244","SIDI ALI","SODA",0,0,10,1,0,10,0,"LE PATRON",NULL,NULL,NULL,NULL,"01","VENTE",NULL,NULL,"TABLE_02"), (7,"23012423330351801","000039","2024-01-23 00:00:00","23:33:04","ART000017","6915","COCA ZERO","SODA",0,0,10,1,0,10,0,"LE PATRON",NULL,NULL,NULL,NULL,"01","VENTE",NULL,NULL,"TABLE_02"), (8,"23012423331009701","000040","2024-01-23 00:00:00","23:33:11","ART74","70294","GLACE 5 BOULES","GLACES",0,0,10,1,0,10,0,"LE PATRON",NULL,NULL,NULL,NULL,"01","VENTE",NULL,NULL,"TABLE_19"), (9,"23012423331009701","000040","2024-01-23 00:00:00","23:33:11","ART73","70293","GLACE 4 BOULES","GLACES",0,0,10,1,0,10,0,"LE PATRON",NULL,NULL,NULL,NULL,"01","VENTE",NULL,NULL,"TABLE_19"), (10,"23012423331009701","000040","2024-01-23 00:00:00","23:33:11","ART72","70292","GLACE 3 BOULES","GLACES",0,0,10,1,0,10,0,"LE PATRON",NULL,NULL,NULL,NULL,"01","VENTE",NULL,NULL,"TABLE_19"), (11,"24012400251714101","000041","2024-01-24 00:00:00","00:25:18","ART15","70235","COCA LIGHT","SODA",0,0,10,1,0,10,0,"LE PATRON",NULL,NULL,NULL,NULL,"01","VENTE",NULL,NULL,"TABLE_02"), (12,"24012400251714101","000041","2024-01-24 00:00:00","00:25:18","ART000017","6915","COCA ZERO","SODA",0,0,10,1,0,10,0,"LE PATRON",NULL,NULL,NULL,NULL,"01","VENTE",NULL,NULL,"TABLE_02"), (13,"24012400251714101","000041","2024-01-24 00:00:00","00:25:18","ART22","70242","SCHWEPPES CITRON","SODA",0,0,10,1,0,10,0,"LE PATRON",NULL,NULL,NULL,NULL,"01","VENTE",NULL,NULL,"TABLE_02"), (14,"24012400251714101","000041","2024-01-24 00:00:00","00:25:18","ART21","70241","SCHWEPPES TONIC","SODA",0,0,10,1,0,10,0,"LE PATRON",NULL,NULL,NULL,NULL,"01","VENTE",NULL,NULL,"TABLE_02"), (15,"24012400251714101","000041","2024-01-24 00:00:00","00:25:18","ART23","70243","OULMES","SODA",0,0,10,1,0,10,0,"LE PATRON",NULL,NULL,NULL,NULL,"01","VENTE",NULL,NULL,"TABLE_02"), (16,"24012400251714101","000041","2024-01-24 00:00:00","00:25:18","ART16","70236","FANTA CITRON","SODA",0,0,10,1,0,10,0,"LE PATRON",NULL,NULL,NULL,NULL,"01","VENTE",NULL,NULL,"TABLE_02"), (17,"24012400251714101","000041","2024-01-24 00:00:00","00:25:18","ART24","70244","SIDI ALI","SODA",0,0,10,1,0,10,0,"LE PATRON",NULL,NULL,NULL,NULL,"01","VENTE",NULL,NULL,"TABLE_02"), (18,"24012400251714101","000041","2024-01-24 00:00:00","00:25:18","ART17","70237","FANTA ORANGE","SODA",0,0,10,1,0,10,0,"LE PATRON",NULL,NULL,NULL,NULL,"01","VENTE",NULL,NULL,"TABLE_02"), (21,"24012401084528001","000043","2024-01-24 00:00:00","01:08:55","ART15","70235","COCA LIGHT","SODA",0,0,10,1,0,10,0,"LE PATRON",NULL,NULL,NULL,NULL,"01","VENTE",NULL,NULL,"SUR PLACE"), (22,"24012401084528001","000043","2024-01-24 00:00:00","01:08:55","ART000017","6915","COCA ZERO","SODA",0,0,10,1,0,10,0,"LE PATRON",NULL,NULL,NULL,NULL,"01","VENTE",NULL,NULL,"SUR PLACE"), (23,"24012401085908401","000044","2024-01-24 00:00:00","01:09:04","ART25","70245","EAU MINERALE","SODA",0,0,10,1,0,10,0,"LE PATRON",NULL,NULL,NULL,NULL,"01","VENTE",NULL,NULL,"SUR PLACE"), (24,"24012401085908401","000044","2024-01-24 00:00:00","01:09:04","ART24","70244","SIDI ALI","SODA",0,0,10,1,0,10,0,"LE PATRON",NULL,NULL,NULL,NULL,"01","VENTE",NULL,NULL,"SUR PLACE"), (25,"24012401085908401","000044","2024-01-24 00:00:00","01:09:04","ART23","70243","OULMES","SODA",0,0,10,1,0,10,0,"LE PATRON",NULL,NULL,NULL,NULL,"01","VENTE",NULL,NULL,"SUR PLACE"), (26,"24012401085908401","000044","2024-01-24 00:00:00","01:09:04","ART23","70243","OULMES","SODA",0,0,10,1,0,10,0,"LE PATRON",NULL,NULL,NULL,NULL,"01","VENTE",NULL,NULL,"SUR PLACE"), (27,"24012401085908401","000044","2024-01-24 00:00:00","01:09:04","ART22","70242","SCHWEPPES CITRON","SODA",0,0,10,1,0,10,0,"LE PATRON",NULL,NULL,NULL,NULL,"01","VENTE",NULL,NULL,"SUR PLACE"), (28,"24012401085908401","000044","2024-01-24 00:00:00","01:09:04","ART22","70242","SCHWEPPES CITRON","SODA",0,0,10,1,0,10,0,"LE PATRON",NULL,NULL,NULL,NULL,"01","VENTE",NULL,NULL,"SUR PLACE"), (29,"24012401121112601","000045","2024-01-24 00:00:00","01:12:16","ART41","70261","P.J KHLII","PETITS DEJ",0,0,10,1,0,10,0,"LE PATRON",NULL,NULL,NULL,NULL,"01","VENTE",NULL,NULL,"SUR PLACE"), (30,"24012401125948801","000046","2024-01-24 00:00:00","01:13:03","ART29","70249","JUS POMME","JUS",0,0,44,1,0,44,0,"LE PATRON",NULL,NULL,NULL,NULL,"01","VENTE",NULL,NULL,"SUR PLACE"), (31,"24012401131325001","000047","2024-01-24 00:00:00","01:13:17","ART30","70250","JUS BANANE","JUS",0,0,10,1,0,10,0,"LE PATRON",NULL,NULL,NULL,NULL,"01","VENTE",NULL,NULL,"SUR PLACE"), (32,"24012401131325001","000047","2024-01-24 00:00:00","01:13:17","ART122","6362","JUS CONCOMBRE","JUS",0,0,10,1,0,10,0,"LE PATRON",NULL,NULL,NULL,NULL,"01","VENTE",NULL,NULL,"SUR PLACE"), (33,"24012401133358401","000048","2024-01-24 00:00:00","01:13:46","ART31","70251","JUS AVOCAT","JUS",0,0,10,1,0,10,0,"LE PATRON",NULL,NULL,NULL,NULL,"01","VENTE",NULL,NULL,"SUR PLACE"), (34,"24012401133358401","000048","2024-01-24 00:00:00","01:13:46","ART30","70250","JUS BANANE","JUS",0,0,10,1,0,10,0,"LE PATRON",NULL,NULL,NULL,NULL,"01","VENTE",NULL,NULL,"SUR PLACE"), (35,"24012401133358401","000048","2024-01-24 00:00:00","01:13:46","ART31","70251","JUS AVOCAT","JUS",0,0,10,1,0,10,0,"LE PATRON",NULL,NULL,NULL,NULL,"01","VENTE",NULL,NULL,"SUR PLACE"), (36,"24012401133358401","000048","2024-01-24 00:00:00","01:13:46","ART122","6362","JUS CONCOMBRE","JUS",0,0,10,1,0,10,0,"LE PATRON",NULL,NULL,NULL,NULL,"01","VENTE",NULL,NULL,"SUR PLACE"), (37,"24012401133358401","000048","2024-01-24 00:00:00","01:13:46","ART121","8509","JUS CAROTTE","JUS",0,0,10,1,0,10,0,"LE PATRON",NULL,NULL,NULL,NULL,"01","VENTE",NULL,NULL,"SUR PLACE"), (38,"24012401133358401","000048","2024-01-24 00:00:00","01:13:46","ART121","8509","JUS CAROTTE","JUS",0,0,10,1,0,10,0,"LE PATRON",NULL,NULL,NULL,NULL,"01","VENTE",NULL,NULL,"SUR PLACE"), (39,"24012401133358401","000048","2024-01-24 00:00:00","01:13:46","ART29","70249","JUS POMME","JUS",0,0,44,1,0,44,0,"LE PATRON",NULL,NULL,NULL,NULL,"01","VENTE",NULL,NULL,"SUR PLACE"), (40,"24012401133358401","000048","2024-01-24 00:00:00","01:13:46","ART28","70248","JUS CITRON","JUS",0,0,10,1,0,10,0,"LE PATRON",NULL,NULL,NULL,NULL,"01","VENTE",NULL,NULL,"SUR PLACE"), (41,"24012401133358401","000048","2024-01-24 00:00:00","01:13:46","ART37","70257","JUS ANANAS","JUS",0,0,10,1,0,10,0,"LE PATRON",NULL,NULL,NULL,NULL,"01","VENTE",NULL,NULL,"SUR PLACE"), (42,"24012401133358401","000048","2024-01-24 00:00:00","01:13:46","ART37","70257","JUS ANANAS","JUS",0,0,10,1,0,10,0,"LE PATRON",NULL,NULL,NULL,NULL,"01","VENTE",NULL,NULL,"SUR PLACE"), (43,"24012401133358401","000048","2024-01-24 00:00:00","01:13:46","ART37","70257","JUS ANANAS","JUS",0,0,10,1,0,10,0,"LE PATRON",NULL,NULL,NULL,NULL,"01","VENTE",NULL,NULL,"SUR PLACE"), (44,"24012401133358401","000048","2024-01-24 00:00:00","01:13:46","ART121","8509","JUS CAROTTE","JUS",0,0,10,1,0,10,0,"LE PATRON",NULL,NULL,NULL,NULL,"01","VENTE",NULL,NULL,"SUR PLACE"), (45,"24012401133358401","000048","2024-01-24 00:00:00","01:13:46","ART121","8509","JUS CAROTTE","JUS",0,0,10,1,0,10,0,"LE PATRON",NULL,NULL,NULL,NULL,"01","VENTE",NULL,NULL,"SUR PLACE"), (46,"24012401133358401","000048","2024-01-24 00:00:00","01:13:46","ART121","8509","JUS CAROTTE","JUS",0,0,10,1,0,10,0,"LE PATRON",NULL,NULL,NULL,NULL,"01","VENTE",NULL,NULL,"SUR PLACE"), (47,"24012401133358401","000048","2024-01-24 00:00:00","01:13:46","ART37","70257","JUS ANANAS","JUS",0,0,10,1,0,10,0,"LE PATRON",NULL,NULL,NULL,NULL,"01","VENTE",NULL,NULL,"SUR PLACE"), (48,"24012401140580201","000049","2024-01-24 00:00:00","01:14:10","ART110","70330","PIZZA P THON","PIZZA",0,0,10,1,0,10,0,"LE PATRON",NULL,NULL,NULL,NULL,"01","VENTE",NULL,NULL,"SUR PLACE"), (49,"24012401141334901","000050","2024-01-24 00:00:00","01:14:17","ART115","70335","PIZZA P FRUIT MER","PIZZA",0,0,10,1,0,10,0,"LE PATRON",NULL,NULL,NULL,NULL,"01","VENTE",NULL,NULL,"SUR PLACE"), (50,"24012401141334901","000050","2024-01-24 00:00:00","01:14:17","ART113","70333","PIZZA P 4 FROMAGES","PIZZA",0,0,10,1,0,10,0,"LE PATRON",NULL,NULL,NULL,NULL,"01","VENTE",NULL,NULL,"SUR PLACE"), (51,"24012401141334901","000050","2024-01-24 00:00:00","01:14:17","ART113","70333","PIZZA P 4 FROMAGES","PIZZA",0,0,10,1,0,10,0,"LE PATRON",NULL,NULL,NULL,NULL,"01","VENTE",NULL,NULL,"SUR PLACE"), (52,"24012401141334901","000050","2024-01-24 00:00:00","01:14:17","ART112","70332","PIZZA P V.H","PIZZA",0,0,10,1,0,10,0,"LE PATRON",NULL,NULL,NULL,NULL,"01","VENTE",NULL,NULL,"SUR PLACE"), (53,"24012401141334901","000050","2024-01-24 00:00:00","01:14:17","ART112","70332","PIZZA P V.H","PIZZA",0,0,10,1,0,10,0,"LE PATRON",NULL,NULL,NULL,NULL,"01","VENTE",NULL,NULL,"SUR PLACE"), (54,"24012401141334901","000050","2024-01-24 00:00:00","01:14:17","ART115","70335","PIZZA P FRUIT MER","PIZZA",0,0,10,1,0,10,0,"LE PATRON",NULL,NULL,NULL,NULL,"01","VENTE",NULL,NULL,"SUR PLACE"), (55,"24012401141334901","000050","2024-01-24 00:00:00","01:14:17","ART115","70335","PIZZA P FRUIT MER","PIZZA",0,0,10,1,0,10,0,"LE PATRON",NULL,NULL,NULL,NULL,"01","VENTE",NULL,NULL,"SUR PLACE"), (56,"24012401141334901","000050","2024-01-24 00:00:00","01:14:17","ART115","70335","PIZZA P FRUIT MER","PIZZA",0,0,10,1,0,10,0,"LE PATRON",NULL,NULL,NULL,NULL,"01","VENTE",NULL,NULL,"SUR PLACE");

-- ----------------------------------------------------------
-- MDB Tools - A library for reading MS Access database files
-- Copyright (C) 2000-2011 Brian Bruns and others.
-- Files in libmdb are licensed under LGPL and the utilities under
-- the GPL, see COPYING.LIB and COPYING files respectively.
-- Check out http://mdbtools.sourceforge.net
-- ----------------------------------------------------------

-- That file uses encoding UTF-8

CREATE TABLE `TABLE_VENTES_REGLEMENTS`
 (
	`ID`			int not null auto_increment unique, 
	`ID_TICKET`			varchar (255), 
	`DATES`			datetime, 
	`TICKET`			varchar (255), 
	`CAISSIER`			varchar (255), 
	`ID_CLIENT`			varchar (255), 
	`CODE_CLIENT`			varchar (255), 
	`CLIENT`			varchar (255), 
	`POSTE`			varchar (255), 
	`MONTANT`			double, 
	`MODE_P`			varchar (255), 
	`OPERATION`			varchar (255), 
	`CLOTURE_CAISSIER`			varchar (255), 
	`CLOTURE_GLOBALE`			varchar (255), 
	`NOTES`			varchar (255)
);

-- CREATE INDEXES ...
ALTER TABLE `TABLE_VENTES_REGLEMENTS` ADD INDEX `CODE_CLIENT` (`CODE_CLIENT`);
ALTER TABLE `TABLE_VENTES_REGLEMENTS` ADD INDEX `ID_TICKET` (`ID_TICKET`);
ALTER TABLE `TABLE_VENTES_REGLEMENTS` ADD PRIMARY KEY (`ID`);



INSERT INTO `TABLE_VENTES_REGLEMENTS` (`ID`, `ID_TICKET`, `DATES`, `TICKET`, `CAISSIER`, `ID_CLIENT`, `CODE_CLIENT`, `CLIENT`, `POSTE`, `MONTANT`, `MODE_P`, `OPERATION`, `CLOTURE_CAISSIER`, `CLOTURE_GLOBALE`, `NOTES`) VALUES (1,"23012423330351801","2024-01-23 00:00:00","000039","LE PATRON",NULL,NULL,NULL,"01",70,"CARTE","VENTE",NULL,NULL,NULL), (2,"23012423331009701","2024-01-23 00:00:00","000040","LE PATRON",NULL,NULL,NULL,"01",30,"ESPECES","VENTE",NULL,NULL,NULL), (3,"24012400251714101","2024-01-24 00:00:00","000041","LE PATRON",NULL,NULL,NULL,"01",80,"CARTE","VENTE",NULL,NULL,NULL), (5,"24012401084528001","2024-01-24 00:00:00","000043","LE PATRON",NULL,NULL,NULL,"01",20,"ESPECES","VENTE",NULL,NULL,NULL), (6,"24012401085908401","2024-01-24 00:00:00","000044","LE PATRON",NULL,NULL,NULL,"01",60,"ESPECES","VENTE",NULL,NULL,NULL), (7,"24012401121112601","2024-01-24 00:00:00","000045","LE PATRON",NULL,NULL,NULL,"01",10,"ESPECES","VENTE",NULL,NULL,NULL), (8,"24012401125948801","2024-01-24 00:00:00","000046","LE PATRON",NULL,NULL,NULL,"01",44,"ESPECES","VENTE",NULL,NULL,NULL), (9,"24012401131325001","2024-01-24 00:00:00","000047","LE PATRON",NULL,NULL,NULL,"01",20,"ESPECES","VENTE",NULL,NULL,NULL), (10,"24012401133358401","2024-01-24 00:00:00","000048","LE PATRON",NULL,NULL,NULL,"01",184,"ESPECES","VENTE",NULL,NULL,NULL), (11,"24012401140580201","2024-01-24 00:00:00","000049","LE PATRON",NULL,NULL,NULL,"01",10,"ESPECES","VENTE",NULL,NULL,NULL), (12,"24012401141334901","2024-01-24 00:00:00","000050","LE PATRON",NULL,NULL,NULL,"01",80,"ESPECES","VENTE",NULL,NULL,NULL);

-- ----------------------------------------------------------
-- MDB Tools - A library for reading MS Access database files
-- Copyright (C) 2000-2011 Brian Bruns and others.
-- Files in libmdb are licensed under LGPL and the utilities under
-- the GPL, see COPYING.LIB and COPYING files respectively.
-- Check out http://mdbtools.sourceforge.net
-- ----------------------------------------------------------

-- That file uses encoding UTF-8

CREATE TABLE `DIRECTE_03`
 (
	`ID`			int NOT NULL AUTO_INCREMENT UNIQUE, 
	`Ticket`			varchar (255), 
	`Dates`			datetime, 
	`Heure`			varchar (255), 
	`ID_ARTICLE`			varchar (255), 
	`Code`			varchar (255), 
	`Article`			varchar (255), 
	`Famille`			varchar (255), 
	`PRIX_A`			double, 
	`PRIX_MP`			double, 
	`PRIX_V`			double, 
	`Qté`			double, 
	`Remise`			double, 
	`TOTAL_NET`			double, 
	`Caissier`			varchar (255), 
	`Vendeur`			varchar (255), 
	`TAUX_TVA`			double, 
	`PRINTER`			varchar (255), 
	`PRINTER_DUPLICATA`			varchar (255), 
	`cuisine`			varchar (255)
);

-- CREATE INDEXES ...
ALTER TABLE `DIRECTE_03` ADD INDEX `Code` (`Code`);
ALTER TABLE `DIRECTE_03` ADD PRIMARY KEY (`ID`);




-- ----------------------------------------------------------
-- MDB Tools - A library for reading MS Access database files
-- Copyright (C) 2000-2011 Brian Bruns and others.
-- Files in libmdb are licensed under LGPL and the utilities under
-- the GPL, see COPYING.LIB and COPYING files respectively.
-- Check out http://mdbtools.sourceforge.net
-- ----------------------------------------------------------

-- That file uses encoding UTF-8

CREATE TABLE `TABLE_01`
 (
	`ID`			int NOT NULL AUTO_INCREMENT UNIQUE, 
	`Ticket`			varchar (255), 
	`Dates`			datetime, 
	`Heure`			varchar (255), 
	`ID_ARTICLE`			varchar (255), 
	`Code`			varchar (255), 
	`Article`			varchar (255), 
	`Famille`			varchar (255), 
	`PRIX_A`			double, 
	`PRIX_MP`			double, 
	`PRIX_V`			double, 
	`Qté`			double, 
	`Remise`			double, 
	`TOTAL_NET`			double, 
	`Caissier`			varchar (255), 
	`Vendeur`			varchar (255), 
	`TAUX_TVA`			double, 
	`PRINTER`			varchar (255), 
	`PRINTER_DUPLICATA`			varchar (255), 
	`cuisine`			varchar (255)
);

-- CREATE INDEXES ...
ALTER TABLE `TABLE_01` ADD INDEX `Code` (`Code`);
ALTER TABLE `TABLE_01` ADD PRIMARY KEY (`ID`);



INSERT INTO `TABLE_01` (`ID`, `Ticket`, `Dates`, `Heure`, `ID_ARTICLE`, `Code`, `Article`, `Famille`, `PRIX_A`, `PRIX_MP`, `PRIX_V`, `Qté`, `Remise`, `TOTAL_NET`, `Caissier`, `Vendeur`, `TAUX_TVA`, `PRINTER`, `PRINTER_DUPLICATA`, `cuisine`) VALUES (1,NULL,"2024-01-10 00:00:00","22:45:23","ART100","70320","CHICKEN BURGER","BURGER",0.0000,0.0000,10.0000,1,0,10.0000,"LE PATRON",NULL,0,"C1","0",NULL), (2,NULL,"2024-01-10 00:00:00","22:45:23","ART101","70321","KING BURGER","BURGER",0.0000,0.0000,25.0000,1,0,25.0000,"LE PATRON",NULL,0,"C1","0",NULL), (3,NULL,"2024-01-10 00:00:00","22:45:25","ART29","70249","JUS POMME","JUS",0.0000,0.0000,44.0000,1,0,44.0000,"LE PATRON",NULL,0,"C1","0",NULL), (4,NULL,"2024-01-10 00:00:00","22:45:26","ART28","70248","JUS CITRON","JUS",0.0000,0.0000,10.0000,1,0,10.0000,"LE PATRON",NULL,0,"C2","0",NULL);

-- ----------------------------------------------------------
-- MDB Tools - A library for reading MS Access database files
-- Copyright (C) 2000-2011 Brian Bruns and others.
-- Files in libmdb are licensed under LGPL and the utilities under
-- the GPL, see COPYING.LIB and COPYING files respectively.
-- Check out http://mdbtools.sourceforge.net
-- ----------------------------------------------------------

-- That file uses encoding UTF-8

CREATE TABLE `TABLE_07`
 (
	`ID`			int NOT NULL AUTO_INCREMENT UNIQUE, 
	`Ticket`			varchar (255), 
	`Dates`			datetime, 
	`Heure`			varchar (255), 
	`ID_ARTICLE`			varchar (255), 
	`Code`			varchar (255), 
	`Article`			varchar (255), 
	`Famille`			varchar (255), 
	`PRIX_A`			double, 
	`PRIX_MP`			double, 
	`PRIX_V`			double, 
	`Qté`			double, 
	`Remise`			double, 
	`TOTAL_NET`			double, 
	`Caissier`			varchar (255), 
	`Vendeur`			varchar (255), 
	`TAUX_TVA`			double, 
	`PRINTER`			varchar (255), 
	`PRINTER_DUPLICATA`			varchar (255), 
	`cuisine`			varchar (255)
);

-- CREATE INDEXES ...
ALTER TABLE `TABLE_07` ADD INDEX `Code` (`Code`);
ALTER TABLE `TABLE_07` ADD PRIMARY KEY (`ID`);



INSERT INTO `TABLE_07` (`ID`, `Ticket`, `Dates`, `Heure`, `ID_ARTICLE`, `Code`, `Article`, `Famille`, `PRIX_A`, `PRIX_MP`, `PRIX_V`, `Qté`, `Remise`, `TOTAL_NET`, `Caissier`, `Vendeur`, `TAUX_TVA`, `PRINTER`, `PRINTER_DUPLICATA`, `cuisine`) VALUES (1,NULL,"2024-01-10 00:00:00","22:44:35","ART41","70261","P.J KHLII","PETITS DEJ",0.0000,0.0000,10.0000,1,0,10.0000,"LE PATRON",NULL,0,"C1","0",NULL), (2,NULL,"2024-01-10 00:00:00","22:44:35","ART40","70260","P.J SPECIAL","PETITS DEJ",0.0000,0.0000,10.0000,1,0,10.0000,"LE PATRON",NULL,0,"C1","0",NULL);

-- ----------------------------------------------------------
-- MDB Tools - A library for reading MS Access database files
-- Copyright (C) 2000-2011 Brian Bruns and others.
-- Files in libmdb are licensed under LGPL and the utilities under
-- the GPL, see COPYING.LIB and COPYING files respectively.
-- Check out http://mdbtools.sourceforge.net
-- ----------------------------------------------------------

-- That file uses encoding UTF-8

CREATE TABLE `TABLE_13`
 (
	`ID`			int NOT NULL AUTO_INCREMENT UNIQUE, 
	`Ticket`			varchar (255), 
	`Dates`			datetime, 
	`Heure`			varchar (255), 
	`ID_ARTICLE`			varchar (255), 
	`Code`			varchar (255), 
	`Article`			varchar (255), 
	`Famille`			varchar (255), 
	`PRIX_A`			double, 
	`PRIX_MP`			double, 
	`PRIX_V`			double, 
	`Qté`			double, 
	`Remise`			double, 
	`TOTAL_NET`			double, 
	`Caissier`			varchar (255), 
	`Vendeur`			varchar (255), 
	`TAUX_TVA`			double, 
	`PRINTER`			varchar (255), 
	`PRINTER_DUPLICATA`			varchar (255), 
	`cuisine`			varchar (255)
);

-- CREATE INDEXES ...
ALTER TABLE `TABLE_13` ADD INDEX `Code` (`Code`);
ALTER TABLE `TABLE_13` ADD PRIMARY KEY (`ID`);




-- ----------------------------------------------------------
-- MDB Tools - A library for reading MS Access database files
-- Copyright (C) 2000-2011 Brian Bruns and others.
-- Files in libmdb are licensed under LGPL and the utilities under
-- the GPL, see COPYING.LIB and COPYING files respectively.
-- Check out http://mdbtools.sourceforge.net
-- ----------------------------------------------------------

-- That file uses encoding UTF-8

CREATE TABLE `TABLE_20`
 (
	`ID`			int NOT NULL AUTO_INCREMENT UNIQUE, 
	`Ticket`			varchar (255), 
	`Dates`			datetime, 
	`Heure`			varchar (255), 
	`ID_ARTICLE`			varchar (255), 
	`Code`			varchar (255), 
	`Article`			varchar (255), 
	`Famille`			varchar (255), 
	`PRIX_A`			double, 
	`PRIX_MP`			double, 
	`PRIX_V`			double, 
	`Qté`			double, 
	`Remise`			double, 
	`TOTAL_NET`			double, 
	`Caissier`			varchar (255), 
	`Vendeur`			varchar (255), 
	`TAUX_TVA`			double, 
	`PRINTER`			varchar (255), 
	`PRINTER_DUPLICATA`			varchar (255), 
	`cuisine`			varchar (255)
);

-- CREATE INDEXES ...
ALTER TABLE `TABLE_20` ADD INDEX `Code` (`Code`);
ALTER TABLE `TABLE_20` ADD PRIMARY KEY (`ID`);




-- ----------------------------------------------------------
-- MDB Tools - A library for reading MS Access database files
-- Copyright (C) 2000-2011 Brian Bruns and others.
-- Files in libmdb are licensed under LGPL and the utilities under
-- the GPL, see COPYING.LIB and COPYING files respectively.
-- Check out http://mdbtools.sourceforge.net
-- ----------------------------------------------------------

-- That file uses encoding UTF-8

CREATE TABLE `TABLE_27`
 (
	`ID`			int NOT NULL AUTO_INCREMENT UNIQUE, 
	`Ticket`			varchar (255), 
	`Dates`			datetime, 
	`Heure`			varchar (255), 
	`ID_ARTICLE`			varchar (255), 
	`Code`			varchar (255), 
	`Article`			varchar (255), 
	`Famille`			varchar (255), 
	`PRIX_A`			double, 
	`PRIX_MP`			double, 
	`PRIX_V`			double, 
	`Qté`			double, 
	`Remise`			double, 
	`TOTAL_NET`			double, 
	`Caissier`			varchar (255), 
	`Vendeur`			varchar (255), 
	`TAUX_TVA`			double, 
	`PRINTER`			varchar (255), 
	`PRINTER_DUPLICATA`			varchar (255), 
	`cuisine`			varchar (255)
);

-- CREATE INDEXES ...
ALTER TABLE `TABLE_27` ADD INDEX `Code` (`Code`);
ALTER TABLE `TABLE_27` ADD PRIMARY KEY (`ID`);




-- ----------------------------------------------------------
-- MDB Tools - A library for reading MS Access database files
-- Copyright (C) 2000-2011 Brian Bruns and others.
-- Files in libmdb are licensed under LGPL and the utilities under
-- the GPL, see COPYING.LIB and COPYING files respectively.
-- Check out http://mdbtools.sourceforge.net
-- ----------------------------------------------------------

-- That file uses encoding UTF-8

CREATE TABLE `TABLE_33`
 (
	`ID`			int NOT NULL AUTO_INCREMENT UNIQUE, 
	`Ticket`			varchar (255), 
	`Dates`			datetime, 
	`Heure`			varchar (255), 
	`ID_ARTICLE`			varchar (255), 
	`Code`			varchar (255), 
	`Article`			varchar (255), 
	`Famille`			varchar (255), 
	`PRIX_A`			double, 
	`PRIX_MP`			double, 
	`PRIX_V`			double, 
	`Qté`			double, 
	`Remise`			double, 
	`TOTAL_NET`			double, 
	`Caissier`			varchar (255), 
	`Vendeur`			varchar (255), 
	`TAUX_TVA`			double, 
	`PRINTER`			varchar (255), 
	`PRINTER_DUPLICATA`			varchar (255), 
	`cuisine`			varchar (255)
);

-- CREATE INDEXES ...
ALTER TABLE `TABLE_33` ADD INDEX `Code` (`Code`);
ALTER TABLE `TABLE_33` ADD PRIMARY KEY (`ID`);




-- ----------------------------------------------------------
-- MDB Tools - A library for reading MS Access database files
-- Copyright (C) 2000-2011 Brian Bruns and others.
-- Files in libmdb are licensed under LGPL and the utilities under
-- the GPL, see COPYING.LIB and COPYING files respectively.
-- Check out http://mdbtools.sourceforge.net
-- ----------------------------------------------------------

-- That file uses encoding UTF-8

CREATE TABLE `TABLE_39`
 (
	`ID`			int NOT NULL AUTO_INCREMENT UNIQUE, 
	`Ticket`			varchar (255), 
	`Dates`			datetime, 
	`Heure`			varchar (255), 
	`ID_ARTICLE`			varchar (255), 
	`Code`			varchar (255), 
	`Article`			varchar (255), 
	`Famille`			varchar (255), 
	`PRIX_A`			double, 
	`PRIX_MP`			double, 
	`PRIX_V`			double, 
	`Qté`			double, 
	`Remise`			double, 
	`TOTAL_NET`			double, 
	`Caissier`			varchar (255), 
	`Vendeur`			varchar (255), 
	`TAUX_TVA`			double, 
	`PRINTER`			varchar (255), 
	`PRINTER_DUPLICATA`			varchar (255), 
	`cuisine`			varchar (255)
);

-- CREATE INDEXES ...
ALTER TABLE `TABLE_39` ADD INDEX `Code` (`Code`);

ALTER TABLE `TABLE_39` ADD PRIMARY KEY (`ID`);




-- ----------------------------------------------------------
-- MDB Tools - A library for reading MS Access database files
-- Copyright (C) 2000-2011 Brian Bruns and others.
-- Files in libmdb are licensed under LGPL and the utilities under
-- the GPL, see COPYING.LIB and COPYING files respectively.
-- Check out http://mdbtools.sourceforge.net
-- ----------------------------------------------------------

-- That file uses encoding UTF-8

CREATE TABLE `TABLE_45`
 (
	`ID`			int NOT NULL AUTO_INCREMENT UNIQUE, 
	`Ticket`			varchar (255), 
	`Dates`			datetime, 
	`Heure`			varchar (255), 
	`ID_ARTICLE`			varchar (255), 
	`Code`			varchar (255), 
	`Article`			varchar (255), 
	`Famille`			varchar (255), 
	`PRIX_A`			double, 
	`PRIX_MP`			double, 
	`PRIX_V`			double, 
	`Qté`			double, 
	`Remise`			double, 
	`TOTAL_NET`			double, 
	`Caissier`			varchar (255), 
	`Vendeur`			varchar (255), 
	`TAUX_TVA`			double, 
	`PRINTER`			varchar (255), 
	`PRINTER_DUPLICATA`			varchar (255), 
	`cuisine`			varchar (255)
);

-- CREATE INDEXES ...
ALTER TABLE `TABLE_45` ADD INDEX `Code` (`Code`);
ALTER TABLE `TABLE_45` ADD PRIMARY KEY (`ID`);




-- ----------------------------------------------------------
-- MDB Tools - A library for reading MS Access database files
-- Copyright (C) 2000-2011 Brian Bruns and others.
-- Files in libmdb are licensed under LGPL and the utilities under
-- the GPL, see COPYING.LIB and COPYING files respectively.
-- Check out http://mdbtools.sourceforge.net
-- ----------------------------------------------------------

-- That file uses encoding UTF-8

CREATE TABLE `TABLE_51`
 (
	`ID`			int NOT NULL AUTO_INCREMENT UNIQUE, 
	`Ticket`			varchar (255), 
	`Dates`			datetime, 
	`Heure`			varchar (255), 
	`ID_ARTICLE`			varchar (255), 
	`Code`			varchar (255), 
	`Article`			varchar (255), 
	`Famille`			varchar (255), 
	`PRIX_A`			double, 
	`PRIX_MP`			double, 
	`PRIX_V`			double, 
	`Qté`			double, 
	`Remise`			double, 
	`TOTAL_NET`			double, 
	`Caissier`			varchar (255), 
	`Vendeur`			varchar (255), 
	`TAUX_TVA`			double, 
	`PRINTER`			varchar (255), 
	`PRINTER_DUPLICATA`			varchar (255), 
	`cuisine`			varchar (255)
);

-- CREATE INDEXES ...
ALTER TABLE `TABLE_51` ADD INDEX `Code` (`Code`);
ALTER TABLE `TABLE_51` ADD PRIMARY KEY (`ID`);




-- ----------------------------------------------------------
-- MDB Tools - A library for reading MS Access database files
-- Copyright (C) 2000-2011 Brian Bruns and others.
-- Files in libmdb are licensed under LGPL and the utilities under
-- the GPL, see COPYING.LIB and COPYING files respectively.
-- Check out http://mdbtools.sourceforge.net
-- ----------------------------------------------------------

-- That file uses encoding UTF-8

CREATE TABLE `TABLE_58`
 (
	`ID`			int NOT NULL AUTO_INCREMENT UNIQUE, 
	`Ticket`			varchar (255), 
	`Dates`			datetime, 
	`Heure`			varchar (255), 
	`ID_ARTICLE`			varchar (255), 
	`Code`			varchar (255), 
	`Article`			varchar (255), 
	`Famille`			varchar (255), 
	`PRIX_A`			double, 
	`PRIX_MP`			double, 
	`PRIX_V`			double, 
	`Qté`			double, 
	`Remise`			double, 
	`TOTAL_NET`			double, 
	`Caissier`			varchar (255), 
	`Vendeur`			varchar (255), 
	`TAUX_TVA`			double, 
	`PRINTER`			varchar (255), 
	`PRINTER_DUPLICATA`			varchar (255), 
	`cuisine`			varchar (255)
);

-- CREATE INDEXES ...
ALTER TABLE `TABLE_58` ADD INDEX `Code` (`Code`);
ALTER TABLE `TABLE_58` ADD PRIMARY KEY (`ID`);




-- ----------------------------------------------------------
-- MDB Tools - A library for reading MS Access database files
-- Copyright (C) 2000-2011 Brian Bruns and others.
-- Files in libmdb are licensed under LGPL and the utilities under
-- the GPL, see COPYING.LIB and COPYING files respectively.
-- Check out http://mdbtools.sourceforge.net
-- ----------------------------------------------------------

-- That file uses encoding UTF-8

CREATE TABLE `TABLE_64`
 (
	`ID`			int NOT NULL AUTO_INCREMENT UNIQUE, 
	`Ticket`			varchar (255), 
	`Dates`			datetime, 
	`Heure`			varchar (255), 
	`ID_ARTICLE`			varchar (255), 
	`Code`			varchar (255), 
	`Article`			varchar (255), 
	`Famille`			varchar (255), 
	`PRIX_A`			double, 
	`PRIX_MP`			double, 
	`PRIX_V`			double, 
	`Qté`			double, 
	`Remise`			double, 
	`TOTAL_NET`			double, 
	`Caissier`			varchar (255), 
	`Vendeur`			varchar (255), 
	`TAUX_TVA`			double, 
	`PRINTER`			varchar (255), 
	`PRINTER_DUPLICATA`			varchar (255), 
	`cuisine`			varchar (255)
);

-- CREATE INDEXES ...
ALTER TABLE `TABLE_64` ADD INDEX `Code` (`Code`);
ALTER TABLE `TABLE_64` ADD PRIMARY KEY (`ID`);




-- ----------------------------------------------------------
-- MDB Tools - A library for reading MS Access database files
-- Copyright (C) 2000-2011 Brian Bruns and others.
-- Files in libmdb are licensed under LGPL and the utilities under
-- the GPL, see COPYING.LIB and COPYING files respectively.
-- Check out http://mdbtools.sourceforge.net
-- ----------------------------------------------------------

-- That file uses encoding UTF-8

CREATE TABLE `TABLE_74`
 (
	`ID`			int NOT NULL AUTO_INCREMENT UNIQUE, 
	`Ticket`			varchar (255), 
	`Dates`			datetime, 
	`Heure`			varchar (255), 
	`ID_ARTICLE`			varchar (255), 
	`Code`			varchar (255), 
	`Article`			varchar (255), 
	`Famille`			varchar (255), 
	`PRIX_A`			double, 
	`PRIX_MP`			double, 
	`PRIX_V`			double, 
	`Qté`			double, 
	`Remise`			double, 
	`TOTAL_NET`			double, 
	`Caissier`			varchar (255), 
	`Vendeur`			varchar (255), 
	`TAUX_TVA`			double, 
	`PRINTER`			varchar (255), 
	`PRINTER_DUPLICATA`			varchar (255), 
	`cuisine`			varchar (255)
);

-- CREATE INDEXES ...
ALTER TABLE `TABLE_74` ADD INDEX `Code` (`Code`);
ALTER TABLE `TABLE_74` ADD PRIMARY KEY (`ID`);




-- ----------------------------------------------------------
-- MDB Tools - A library for reading MS Access database files
-- Copyright (C) 2000-2011 Brian Bruns and others.
-- Files in libmdb are licensed under LGPL and the utilities under
-- the GPL, see COPYING.LIB and COPYING files respectively.
-- Check out http://mdbtools.sourceforge.net
-- ----------------------------------------------------------

-- That file uses encoding UTF-8

CREATE TABLE `TABLE_80`
 (
	`ID`			int NOT NULL AUTO_INCREMENT UNIQUE, 
	`Ticket`			varchar (255), 
	`Dates`			datetime, 
	`Heure`			varchar (255), 
	`ID_ARTICLE`			varchar (255), 
	`Code`			varchar (255), 
	`Article`			varchar (255), 
	`Famille`			varchar (255), 
	`PRIX_A`			double, 
	`PRIX_MP`			double, 
	`PRIX_V`			double, 
	`Qté`			double, 
	`Remise`			double, 
	`TOTAL_NET`			double, 
	`Caissier`			varchar (255), 
	`Vendeur`			varchar (255), 
	`TAUX_TVA`			double, 
	`PRINTER`			varchar (255), 
	`PRINTER_DUPLICATA`			varchar (255), 
	`cuisine`			varchar (255)
);

-- CREATE INDEXES ...
ALTER TABLE `TABLE_80` ADD INDEX `Code` (`Code`);
ALTER TABLE `TABLE_80` ADD PRIMARY KEY (`ID`);




-- ----------------------------------------------------------
-- MDB Tools - A library for reading MS Access database files
-- Copyright (C) 2000-2011 Brian Bruns and others.
-- Files in libmdb are licensed under LGPL and the utilities under
-- the GPL, see COPYING.LIB and COPYING files respectively.
-- Check out http://mdbtools.sourceforge.net
-- ----------------------------------------------------------

-- That file uses encoding UTF-8

CREATE TABLE `TABLE_CLIENTS_RDV`
 (
	`ID`			int NOT NULL AUTO_INCREMENT UNIQUE, 
	`Dates`			datetime, 
	`HEURE`			varchar (255), 
	`CLIENT`			varchar (255), 
	`TELEPHONE`			varchar (255), 
	`NOTES`			varchar (255)
);

-- CREATE INDEXES ...
ALTER TABLE `TABLE_CLIENTS_RDV` ADD PRIMARY KEY (`ID`);




-- ----------------------------------------------------------
-- MDB Tools - A library for reading MS Access database files
-- Copyright (C) 2000-2011 Brian Bruns and others.
-- Files in libmdb are licensed under LGPL and the utilities under
-- the GPL, see COPYING.LIB and COPYING files respectively.
-- Check out http://mdbtools.sourceforge.net
-- ----------------------------------------------------------

-- That file uses encoding UTF-8

CREATE TABLE `TABLE_DEVIS_ENTETE`
 (
	`ID`			int not null auto_increment unique
);

-- CREATE INDEXES ...
ALTER TABLE `TABLE_DEVIS_ENTETE` ADD PRIMARY KEY (`ID`);




-- ----------------------------------------------------------
-- MDB Tools - A library for reading MS Access database files
-- Copyright (C) 2000-2011 Brian Bruns and others.
-- Files in libmdb are licensed under LGPL and the utilities under
-- the GPL, see COPYING.LIB and COPYING files respectively.
-- Check out http://mdbtools.sourceforge.net
-- ----------------------------------------------------------

-- That file uses encoding UTF-8

CREATE TABLE `TABLE_INVENTAIRES_DETAILS`
 (
	`ID`			int not null auto_increment unique, 
	`Dates`			datetime, 
	`ID_INV`			varchar (255), 
	`N_INV`			varchar (255), 
	`ID_ARTICLE`			varchar (255), 
	`Code`			varchar (255), 
	`Article`			varchar (255), 
	`Prix_A`			double, 
	`STOCK_LOGIQUE`			double, 
	`STOCK_PHYSIQUE`			double, 
	`ECART`			double, 
	`VALEUR`			double, 
	`ETAT`			varchar (255)
);

-- CREATE INDEXES ...
ALTER TABLE `TABLE_INVENTAIRES_DETAILS` ADD INDEX `Code` (`Code`);

ALTER TABLE `TABLE_INVENTAIRES_DETAILS` ADD INDEX `ID_BR` (`ID_INV`);
ALTER TABLE `TABLE_INVENTAIRES_DETAILS` ADD PRIMARY KEY (`ID`);



