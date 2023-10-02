using Microsoft.VisualBasic;

namespace TrainCloud.Uic;

public class UicNumberService : IUicNumberService
{
    public string GetCarTypeCode(string fullUIC)
    {
        return fullUIC.Substring(0, 2);
    }
    public string GetCountryCode(string fullUIC)
    {
        return fullUIC.Substring(2, 2);
    }
    public string GetCarClassCode(string fullUIC)
    {
        return fullUIC.Substring(4, 4);
    }
    public string GetCarClassSerialNr(string fullUIC)
    {
        return fullUIC.Substring(8, 3);
    }
    public string GetChecksum(string fullUIC)
    {
        return fullUIC.Substring(11, 1);
    }

    public bool ValidateUic(string fullUic)
    {
        if (string.IsNullOrEmpty(fullUic))
        {
            return false;
        }
        if (fullUic.Length != 12)
        {
            return false;
        }
        if (!long.TryParse(fullUic, out long value))
        {
            return false;
        }

        long sum = 0;
        for (int i = 0; i < fullUic.Length - 1; i++)
        {
            int digit = fullUic[^(i + 2)] - '0';
            sum += (i % 2 == 0) ? Luhn(digit) : digit;
        }
        int checkDigit = fullUic[^1] - '0';
        bool isValid = (10 - (sum % 10)) % 10 == checkDigit;

        return isValid;
    }
    private int Luhn(int digit) => (digit *= 2) > 9 ? digit - 9 : digit;
}
