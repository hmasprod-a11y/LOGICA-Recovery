# Developing the recovered POS

Use the branch `development/recovered-pos` for code, UI, name and branding changes. The recovered baseline is retained in `main`.

## Development startup

The `Debug` configuration enters the original user login without requiring the old machine activation. It does not generate activation keys, modify registration records, or sign a user in. User authentication and permissions still apply.

`Release` continues to use the existing activation behavior. Windows CI builds both configurations, verifies Release behavior, then verifies Debug reaches the visible user login with the restored database.

## Build and run

Run `scripts/Start-Development.cmd` from a local checkout with a .NET SDK capable of building the project installed. It restores the original DLLs, builds the C# project in Debug, prepares a separate runtime and starts the local database launcher. Existing runtime configuration and database files are retained. The launcher downloads MariaDB on first use.

For code editing, open `recovered-source/LOGICA.csproj` in Visual Studio. Use Debug. The local runtime lives in `.development/runtime`; the database is inside its `bd/mysql-data` folder.

The `LOGICA-Development-Windows` Actions artifact is a compiled development runtime for review. Start it using `Start-LOGICA.cmd`. Development work should be committed to this branch so the project remains editable.
