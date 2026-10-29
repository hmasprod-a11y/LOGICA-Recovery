namespace LOGICA.ApplicationLayer.Cash
{
    internal interface ICashRecountContext
    {
        void ResetBackground();
        object ReadSenderText();
        void ResetSender();
        string ReadDenomination(int index);
        void DisplayTotal(decimal total);
        int LastPaymentIndex { get; }
        object ReadPaymentMode(int index);
        void DisplayCashRow(int index, decimal total);
    }
}
