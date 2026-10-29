using System;
using Microsoft.VisualBasic.CompilerServices;

namespace LOGICA.Domain
{
    internal static class CatalogueBarcodeChecksum
    {
        public static byte[] CompleteTwelveDigitPayload(string payload)
        {
            checked
            {
                int even = 0, odd = 0;
                byte[] digits = new byte[13];
                for (int index = 0; index <= 11; index++)
                {
                    digits[index] = (byte)Conversions.ToInteger(payload.Substring(index, 1));
                    if (index % 2 == 1) odd += digits[index];
                    else even += digits[index];
                }
                int remainder = (even + odd * 3) % 10;
                digits[12] = remainder == 0 ? (byte)0 : (byte)(10 - remainder);
                return digits;
            }
        }

        public static string GetElevenDigitPayloadSuffix(string payload)
        {
            checked
            {
                // Retain the original slicing and decimal-digit conversion boundaries.
                string text = payload.Substring(0, 1) + payload.Substring(1, 5) + payload.Substring(6, 5);
                int sum = 0;
                for (int position = 1; position <= text.Length; position++)
                {
                    int digit = Convert.ToInt32(text.Substring(position - 1, 1));
                    sum = position % 2 != 0 ? sum + digit * 3 : sum + digit;
                }
                return ((10 - sum % 10) % 10).ToString();
            }
        }
    }
}
