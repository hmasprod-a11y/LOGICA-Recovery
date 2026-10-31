using System;

namespace LOGICA.Domain
{
    // Original Form_5_CLIENTS_REGLE.Button12_Click behavior, including the second
    // ExecuteScalar only when the first read is not DBNull. Not an ID allocator redesign.
    internal static class ClientSettlementSequence
    {
        internal static int NextId(Func<object> readMaximum, ILegacySettlementSemantics legacy)
        {
            if (readMaximum() == DBNull.Value) return 1;
            return checked((int)Math.Round(legacy.ToDouble(readMaximum()) + 1.0));
        }
    }
}
