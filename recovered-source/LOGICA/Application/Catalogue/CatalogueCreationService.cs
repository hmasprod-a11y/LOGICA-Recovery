namespace LOGICA.ApplicationLayer.Catalogue
{
    internal sealed class CatalogueCreationService
    {
        private readonly ICatalogueCreationStore store;
        public CatalogueCreationService(ICatalogueCreationStore store) { this.store = store; }

        // Called only after the form's original duplicate guard and normalization.
        public void Create(ICatalogueRowInput input)
        {
            int id = store.ReadNextNumericId();
            string articleId = store.ReadArticleId();
            var row = store.AppendNewRow();
            CatalogueRowMapper.PopulateNew(row, id, articleId, input);
            store.Persist();
            store.WriteMovement(articleId, input);
            store.AdvanceSequence();
        }
    }
}
