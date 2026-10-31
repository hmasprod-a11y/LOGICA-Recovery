using LOGICA.Domain;

namespace LOGICA.ApplicationLayer.Catalogue
{
    internal sealed class CatalogueCreationService
    {
        private readonly ICatalogueCreationStore store;
        private readonly ILegacyCatalogueSemantics semantics;
        public CatalogueCreationService(ICatalogueCreationStore store, ILegacyCatalogueSemantics semantics)
        {
            this.store = store;
            this.semantics = semantics;
        }

        // Called only after the form's original duplicate guard and normalization.
        public void Create(ICatalogueRowInput input)
        {
            int id = store.ReadNextNumericId();
            string articleId = store.ReadArticleId();
            var row = store.AppendNewRow();
            CatalogueRowMapper.PopulateNew(row, id, articleId, input, semantics);
            store.Persist();
            store.WriteMovement(articleId, input);
            store.AdvanceSequence();
        }
    }
}
