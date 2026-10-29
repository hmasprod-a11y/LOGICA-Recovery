using System;
using System.Globalization;
using LOGICA.Domain;

internal static class CatalogueBarcodeChecksumTests
{
    private static int Oracle(string payload)
    {
        int sum = 0, weight = 3;
        for (int index = payload.Length - 1; index >= 0; index--)
        {
            sum += (payload[index] - '0') * weight;
            weight = 4 - weight;
        }
        return (10 - sum % 10) % 10;
    }

    public static int Main()
    {
        CultureInfo original = CultureInfo.CurrentCulture;
        int assertions = 0;
        try
        {
            foreach (string culture in new[] { "fr-MA", "fr-FR", "en-US" })
            {
                CultureInfo.CurrentCulture = CultureInfo.GetCultureInfo(culture);
                var random = new Random(71023);
                foreach (int length in new[] { 11, 12 })
                {
                    for (int sample = 0; sample < 200; sample++)
                    {
                        string payload = "";
                        for (int index = 0; index < length; index++)
                            payload += sample == 0 ? "0" : sample == 1 ? "9" : random.Next(10).ToString();
                        int expected = Oracle(payload);
                        if (length == 12)
                        {
                            byte[] digits = CatalogueBarcodeChecksum.CompleteTwelveDigitPayload(payload);
                            assertions++;
                            if (digits.Length != 13 || digits[12] != expected) throw new Exception("Twelve-digit checksum changed");
                            for (int index = 0; index < length; index++)
                            {
                                assertions++;
                                if (digits[index] != payload[index] - '0') throw new Exception("Payload for getBits changed");
                            }
                        }
                        else
                        {
                            assertions++;
                            if (CatalogueBarcodeChecksum.GetElevenDigitPayloadSuffix(payload) != expected.ToString())
                                throw new Exception("Eleven-digit checksum changed");
                        }
                    }
                }
                assertions += 2;
                if (CatalogueBarcodeChecksum.GetElevenDigitPayloadSuffix("03600029145") != "2" ||
                    CatalogueBarcodeChecksum.CompleteTwelveDigitPayload("400638133393")[12] != 1)
                    throw new Exception("Known barcode vectors changed");
            }
            Console.WriteLine("PASS catalogue barcode checksum: " + assertions + " assertions; vectors, payload preservation, zero/nine and seeded inputs");
            return 0;
        }
        catch (Exception error) { Console.Error.WriteLine(error); return 1; }
        finally { CultureInfo.CurrentCulture = original; }
    }
}
