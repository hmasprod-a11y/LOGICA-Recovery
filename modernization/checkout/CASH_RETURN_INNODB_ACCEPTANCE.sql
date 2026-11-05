-- HANOUTY P0: executable preflight for a persisted original exact-cash sale.
-- Run only against a disposable MariaDB test database, never a shop database.
-- Required fixture: set @original_ticket and @article_id to an existing
-- single-line, full-cent cash sale. This does NOT post a refund.
-- A failing assertion intentionally aborts with a duplicate-key error.
START TRANSACTION;
SET @original_ticket = 'TEST-ORIGINAL-TICKET';
SET @article_id = 'TEST-ARTICLE';
CREATE TEMPORARY TABLE hanouty_return_assert (ok TINYINT NOT NULL PRIMARY KEY);
INSERT INTO hanouty_return_assert VALUES (1);
-- Lock the original sale to serialize concurrent return candidates.
SELECT ID_TICKET, Total_NET FROM TABLE_VENTES_ENTETE
 WHERE BINARY ID_TICKET=BINARY @original_ticket AND BINARY OPERATION=BINARY 'VENTE' FOR UPDATE;
-- Assert exactly one original header, journal line, and exact cash payment.
INSERT INTO hanouty_return_assert
SELECT IF(
 (SELECT COUNT(*) FROM TABLE_VENTES_ENTETE
   WHERE BINARY ID_TICKET=BINARY @original_ticket AND BINARY OPERATION=BINARY 'VENTE')=1
 AND (SELECT COUNT(*) FROM TABLE_VENTES_JOURNAL
   WHERE BINARY ID_TICKET=BINARY @original_ticket
     AND BINARY ID_ARTICLE=BINARY @article_id AND BINARY OPERATION=BINARY 'VENTE' AND `Qté` > 0 AND Remise=0 AND PRIX_V >= 0 AND Total_NET > 0 AND Total_NET = ROUND(PRIX_V * `Qté`,2) AND Total_NET = (SELECT Total_NET FROM TABLE_VENTES_ENTETE WHERE BINARY ID_TICKET=BINARY @original_ticket AND BINARY OPERATION=BINARY 'VENTE'))=1
 AND (SELECT COUNT(*) FROM TABLE_VENTES_JOURNAL
   WHERE BINARY ID_TICKET=BINARY @original_ticket)=1
 AND (SELECT COUNT(*) FROM TABLE_VENTES_REGLEMENTS
   WHERE BINARY ID_TICKET=BINARY @original_ticket
     AND BINARY MODE_P=BINARY 'ESPECES' AND BINARY OPERATION=BINARY 'VENTE')=1
 AND (SELECT COUNT(*) FROM TABLE_VENTES_REGLEMENTS
   WHERE BINARY ID_TICKET=BINARY @original_ticket)=1
 AND (SELECT Total_NET FROM TABLE_VENTES_ENTETE
   WHERE BINARY ID_TICKET=BINARY @original_ticket AND BINARY OPERATION=BINARY 'VENTE')
   = (SELECT MONTANT FROM TABLE_VENTES_REGLEMENTS
      WHERE BINARY ID_TICKET=BINARY @original_ticket
        AND BINARY MODE_P=BINARY 'ESPECES' AND BINARY OPERATION=BINARY 'VENTE')
 ,2,1);
ROLLBACK;
-- Negative fixture contract: changing the original line to a non-VENTE operation,
-- fractional/zero quantity, nonzero discount, or mismatched line total must
-- cause the duplicate-key assertion above to abort. Use disposable data only.
-- This preflight is not a substitute for a durable UNIQUE original-ticket
-- refund claim, signed return postings, or restart/Unknown integration tests.
