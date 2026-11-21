# Protected first setup and source-backed daily payment

Base: daily integration141 `95f05730516662659b1238bc225dd5cdc754e233`. The application now prepares a separate working copy when the selected original LOGICA database is not ready for HANOUTY, rather than accepting a connection that will fail at the first transaction.

## Real first-setup path

The setup dialog checks local connection and original catalogue folder. Existing prepared profiles remain usable; an unprepared profile opens the protected-copy wizard. The operator closes LOGICA, reviews the original and newly generated destination, selects installed MariaDB tools (auto-detected when available) and explicitly starts preparation. Destination is a new local `hanouty_*` schema and a new private application-data job folder. Existing destinations and linked/overlapping folders are refused.

Source database access uses SELECT/SHOW and session read-only settings; the official dump uses a private ACL-protected defaults file as its first argument. No credentials appear in process arguments, progress, journal or public error text. The original source is never migrated or deleted. Backup SHA256, original table/row fingerprints and the fresh-source comparison must match. Eleven exact, SHA-pinned migrations run only on the new copy, with before/after DDL journal entries; partial destinations remain quarantined rather than being dropped or reused.

Testing the actual recovered CREATE statements exposed missing modern-writer columns in TABLE_01, TABLE_VENTES_JOURNAL and TABLE_VENTES_REGLEMENTS. The eleventh additive migration supplies those columns and the two canonical checkout/full-return journals. It preserves the real original AUTO_INCREMENT singleton ID0 in TABLE_NUM; the original article/customer/receiving/stock handlers also read ID0. An ID1 layout is refused rather than silently rewritten.

After the database passes validation, the wizard copies the selected catalogue directory with verified file hashes, unchanged source-file set and refusal of links/path overlap. Images retain their original `bd/images` layout. Local printer and credit files are read from the copied data before immutable-version fallbacks, so application updates preserve them. Only then is the connection/profile encrypted with current-user DPAPI and replaced atomically. Error/cancel leaves the existing profile intact. A failed attempt requires a fresh destination on reopening.

This first preparation supports register01 and canonical InnoDB LOGICA tables without unsupported SQL executable objects, generated columns or cross-database relationships. Other layouts are refused explicitly. A MariaDB instance and its installed client tools are prerequisites; this batch does not silently install a database service or access a shop that has not been selected by its operator.

## Daily cashier behavior

The fixed ENCAISSER button now opens the existing touch money calculator and posts after the amount and fresh PIN are accepted, following Form_3_VENTE.Button_ClickCore12940 opening FormDialog_calc before posting. It is available for an authenticated, valid displayed basket before receiving cash. The existing posting gate still decides price, stock, amount and authorization. Canceling the calculator does not post. Previously prepared cash remains valid only under the existing guarded context. After an acknowledged operation, the still-authenticated Host restores the authoritative empty-basket total immediately.

## Executed evidence

`Test-HanoutyProtectedCopy.ps1` creates only an owned disposable local server on an explicit free port and runs the original-schema database acceptance and actual first-setup GUI acceptance. Positive evidence includes SELECT-only source account, Arabic/accent bytes, all11 migrations, backup hash, ID0 preservation, first real production checkout/replay and original source unchanged. Unsafe/existing destinations, post-import failure, changed source and invalid counter are refused; temporary credentials are removed.

The actual GUI first refuses missing tools without replacing a previous profile, then prepares the real original-schema fixture, copies a valid photo and original printer/credit files, encrypts and reloads the profile, logs in its original Unicode cashier, scans an article and clicks ENCAISSER. Coins5+1 and fresh PIN post6MAD, stock12→11 and CL0→1 only in the copied database. Its original remains stock12/CL0. The empty basket total returns0.00. Images and JSON evidence were reviewed. Financial Release and WPF STA regressions passed; the full disposable financial regression runs alongside independent source/package gates.

No real shop database or physical printer was used. The verified customer installer remains the five-file installation delivery from141; CI rebuilds it from the new accepted financial payload. Advanced documents, other receipt templates/peripherals and full commercial field acceptance are not asserted here.
