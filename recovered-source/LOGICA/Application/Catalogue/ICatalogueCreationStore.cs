using System.Data;

namespace LOGICA.ApplicationLayer.Catalogue
{
    internal interface ICatalogueCreationStore
    {
        int ReadNextNumericId();
        string ReadArticleId();
        DataRow AppendNewRow();
        void Persist();
        void WriteMovement(string articleId, ICatalogueRowInput input);
        void AdvanceSequence();
    }
}
