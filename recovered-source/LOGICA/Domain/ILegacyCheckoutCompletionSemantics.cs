namespace LOGICA.Domain
{
    // Preserve Visual Basic numeric coercion and picture formatting for TABLE_NUM.CL.
    internal interface ILegacyCheckoutCompletionSemantics
    {
        double ToDouble(string text);
        string FormatSequence(double next);
    }
}
