
namespace TrainCloud.Uic;

/// <summary>
/// Functions to work with UIC numbers
/// </summary>
public class UicNumberService : IUicNumberService
{
    /// <summary>
    /// Gets the 2 digit car type code of the provided UIC number
    /// </summary>
    /// <param name="fullUic">12 digit UIC number (e. g. 378478413297)</param>
    /// <returns>The 2 digit car type code of the provided UIC number (e. g. 37)</returns>
    /// <exception cref="ArgumentException">Thrown when the provided UIC number is invalid</exception>
    public string GetCarTypeCode(string fullUic)
    {
        if (!ValidateUic(fullUic))
        {
            throw new ArgumentException("The provided UIC number is invalid");
        }

        return fullUic.Substring(0, 2);
    }

    /// <summary>
    /// Gets the 2 digit country code of the provided UIC number
    /// </summary>
    /// <param name="fullUic">12 digit UIC number (e. g. 848047332772)</param>
    /// <returns>The 2 digit country code of the provided UIC number (e. g. 80)</returns>
    /// <exception cref="ArgumentException">Thrown when the provided UIC number is invalid</exception>
    public string GetCountryCode(string fullUic)
    {
        if (!ValidateUic(fullUic))
        {
            throw new ArgumentException("The provided UIC number is invalid");
        }

        return fullUic.Substring(2, 2);
    }

    /// <summary>
    /// Gets the 4 digit car class code of the provided UIC number
    /// </summary>
    /// <param name="fullUic">12 digit UIC number (e. g. 898075500014)</param>
    /// <returns>The 4 digit car class code of the provided UIC number (e. g. 7550)</returns>
    /// <exception cref="ArgumentException">Thrown when the provided UIC number is invalid</exception>
    public string GetCarClassCode(string fullUic)
    {
        if (!ValidateUic(fullUic))
        {
            throw new ArgumentException("The provided UIC number is invalid");
        }

        return fullUic.Substring(4, 4);
    }

    /// <summary>
    /// Gets the 3 digit car class serial number of the provided UIC number
    /// </summary>
    /// <param name="fullUic">12 digit UIC number (e. g. 238064501006)</param>
    /// <returns>The 3 digit car class serial number of the provided UIC number (e. g. 100)</returns>
    /// <exception cref="ArgumentException">Thrown when the provided UIC number is invalid</exception>
    public string GetCarClassSerialNr(string fullUic)
    {
        if (!ValidateUic(fullUic))
        {
            throw new ArgumentException("The provided UIC number is invalid");
        }

        return fullUic.Substring(8, 3);
    }

    /// <summary>
    /// Gets the 1 digit checksum of the provided valid UIC number
    /// </summary>
    /// <param name="fullUic">12 digit UIC number (e. g. 235608390052)</param>
    /// <returns>The 1 digit checksum of the provided UIC number (e. g. 2)</returns>
    /// <exception cref="ArgumentException">Thrown when the provided UIC number is invalid</exception>
    public string GetChecksum(string fullUic)
    {
        if(!ValidateUic(fullUic))
        {
            throw new ArgumentException("The provided UIC number is invalid");
        }

        return fullUic.Substring(11, 1);
    }

    /// <summary>
    /// Checks if the provided UIC number is valid by calculating the checksum
    /// </summary>
    /// <param name="fullUic">12 digit UIC number (e. g. 238064500941)</param>
    /// <returns>True if the provided UIC is valid, false if invalid</returns>
    public bool ValidateUic(string fullUic)
    {
        // If the provided UIC is empty, shorter/longer than 12 digits or not numeric it can't be valid -> return false
        if (string.IsNullOrEmpty(fullUic) ||
            fullUic.Length != 12 ||
            !long.TryParse(fullUic, out _))
        {
            return false;
        }

        int sum = 0;
        for (int i = 0; i < fullUic.Length - 1; i++)
        {
            int digit = fullUic[^(i + 2)] - '0';
            sum += (i % 2 == 0) ? Luhn(digit) : digit;
        }
        long checkDigit = fullUic[^1] - '0';
        bool isValid = (10 - (sum % 10)) % 10 == checkDigit;

        return isValid;
    }

    private static int Luhn(int digit)
    {
        if ((digit *= 2) > 9)
        {
            return digit -9;
        }
        return digit;
    }
}
