namespace TrainCloud.Uic;

/// <summary>
/// Functions to work with UIC numbers
/// </summary>
public interface IUicNumberService
{
    /// <summary>
    /// Gets the 2 digit car type code of the provided UIC number
    /// </summary>
    /// <param name="fullUic">12 digit UIC number (e. g. 378478413297)</param>
    /// <returns>The 2 digit car type code of the provided UIC number (e. g. 37)</returns>
    /// <exception cref="ArgumentException">Thrown when the provided UIC number is invalid</exception>
    public string GetCarTypeCode(string fullUic);

    /// <summary>
    /// Gets the 2 digit country code of the provided UIC number
    /// </summary>
    /// <param name="fullUic">12 digit UIC number (e. g. 848047332772)</param>
    /// <returns>The 2 digit country code of the provided UIC number (e. g. 80)</returns>
    /// <exception cref="ArgumentException">Thrown when the provided UIC number is invalid</exception>
    public string GetCountryCode(string fullUic);

    /// <summary>
    /// Gets the 4 digit car class code of the provided UIC number
    /// </summary>
    /// <param name="fullUic">12 digit UIC number (e. g. 898075500014)</param>
    /// <returns>The 4 digit car class code of the provided UIC number (e. g. 7550)</returns>
    /// <exception cref="ArgumentException">Thrown when the provided UIC number is invalid</exception>
    public string GetCarClassCode(string fullUic);

    /// <summary>
    /// Gets the 3 digit car class serial number of the provided UIC number
    /// </summary>
    /// <param name="fullUic">12 digit UIC number (e. g. 238064501006)</param>
    /// <returns>The 3 digit car class serial number of the provided UIC number (e. g. 100)</returns>
    /// <exception cref="ArgumentException">Thrown when the provided UIC number is invalid</exception>
    public string GetCarClassSerialNr(string fullUic);

    /// <summary>
    /// Gets the 1 digit checksum of the provided valid UIC number
    /// </summary>
    /// <param name="fullUic">12 digit UIC number (e. g. 235608390052)</param>
    /// <returns>The 1 digit checksum of the provided UIC number (e. g. 2)</returns>
    /// <exception cref="ArgumentException">Thrown when the provided UIC number is invalid</exception>
    public string GetChecksum(string fullUic);

    /// <summary>
    /// Checks if the provided UIC number is valid by calculating the checksum
    /// </summary>
    /// <param name="fullUic">12 digit UIC number (e. g. 238064500941)</param>
    /// <returns>True if the provided UIC is valid, false if invalid</returns>
    bool ValidateUic(string fullUic);
}