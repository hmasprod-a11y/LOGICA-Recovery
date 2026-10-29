using System.Data;
using LOGICA.ApplicationLayer.Catalogue;
using MySql.Data.MySqlClient;

namespace LOGICA.Infrastructure.Catalogue
{
    internal sealed class MySqlCatalogueCreationStore : ICatalogueCreationStore
    {
        private readonly MySqlConnection connection;
        private readonly MySqlDataAdapter adapter;
        private readonly DataTable table;
        private readonly MySqlCommand command;

        public MySqlCatalogueCreationStore(MySqlConnection connection, MySqlDataAdapter adapter, DataTable table)
        {
            this.connection = connection;
            this.adapter = adapter;
            this.table = table;
            command = new MySqlCommand();
        }

        public int ReadNextNumericId() { return CatalogueCreationIdentityReader.ReadNextNumericId(command, connection); }
        public string ReadArticleId() { return CatalogueCreationIdentityReader.ReadArticleId(command, connection); }
        public DataRow AppendNewRow()
        {
            table.Rows.Add();
            return table.Rows[table.Rows.Count - 1];
        }
        public void Persist() { CatalogueRowPersistence.UpdateAndAccept(adapter, table); }
        public void WriteMovement(string articleId, ICatalogueRowInput input)
        {
            CatalogueCreationMovementWriter.Write(articleId, () => input.Code, () => input.Article, () => input.Stock, connection);
        }
        public void AdvanceSequence() { CatalogueSequenceWriter.AdvanceArticle(command, connection); }
    }
}
