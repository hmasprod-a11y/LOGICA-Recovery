namespace LOGICA.Domain
{
    // Retains the original order and checked decimal arithmetic in Form_5_CLIENTS_REGLE._credit.
    internal static class ClientCreditBalance
    {
        internal static decimal Calculate(decimal creditSales, decimal creditReturns, decimal openingCredit, decimal payments)
        {
            return decimal.Subtract(decimal.Add(decimal.Add(creditSales, creditReturns), openingCredit), payments);
        }
    }
}
