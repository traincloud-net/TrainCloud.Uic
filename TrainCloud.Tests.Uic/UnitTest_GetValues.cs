using TrainCloud.Uic.Services;

namespace TrainCloud.Tests.Uic;

[TestClass]
public class UnitTest_GetValues
{
    protected IUicNumberService UicNumberService { get; } = new UicNumberService();

    [TestMethod()]
    public void Test_GetCarTypeCode_ValidUic()
    {
        // Arrange
        string validUicNumber = "378478415805";

        // Act
        string carTypeCode = UicNumberService.GetCarTypeCode(validUicNumber);

        // Assert
        Assert.AreEqual("37", carTypeCode);
    }

    [TestMethod()]
    public void Test_GetCarTypeCode_InvalidUic()
    {
        // Arrange
        string invalidUicNumber = "37AÜ841599";

        // Assert
        Assert.ThrowsException<ArgumentException>(() =>
        {
            // Act
            _ = UicNumberService.GetCarTypeCode(invalidUicNumber);
        });
    }

    [TestMethod()]
    public void Test_GetCountyCode_ValidUic()
    {
        // Arrange
        string validUicNumber = "378478415995";

        // Act
        string countryCode = UicNumberService.GetCountryCode(validUicNumber);

        // Assert
        Assert.AreEqual("84", countryCode);
    }

    [TestMethod()]
    public void Test_GetCountyCode_InvalidUic()
    {
        // Arrange
        string invalidUicNumber = "37§7841599";

        // Assert
        Assert.ThrowsException<ArgumentException>(() =>
        {
            // Act
            _ = UicNumberService.GetCountryCode(invalidUicNumber);
        });
    }

    [TestMethod()]
    public void Test_GetCarClassCode_ValidUic()
    {
        // Arrange
        string validUicNumber = "118739386456";

        // Act
        string carClassCode = UicNumberService.GetCarClassCode(validUicNumber);

        // Assert
        Assert.AreEqual("3938", carClassCode);
    }

    [TestMethod()]
    public void Test_GetCarClassCode_InvalidUic()
    {
        // Arrange
        string invalidUicNumber = "XXX";

        // Assert
        Assert.ThrowsException<ArgumentException>(() =>
        {
            // Act
            _ = UicNumberService.GetCarClassCode(invalidUicNumber);
        });
    }

    [TestMethod()]
    public void Test_GetCarClassSerialNr_ValidUic()
    {
        // Arrange
        string validUicNumber = "218007206467";

        // Act
        string carClassSerialNr = UicNumberService.GetCarClassSerialNr(validUicNumber);

        // Assert
        Assert.AreEqual("646", carClassSerialNr);
    }

    [TestMethod()]
    public void Test_GetCarClassSerialNr_InvalidUic()
    {
        // Arrange
        string invalidUicNumber = "2180§$206467";

        // Assert
        Assert.ThrowsException<ArgumentException>(() =>
        {
            // Act
            _ = UicNumberService.GetCarClassSerialNr(invalidUicNumber);
        });
    }

    [TestMethod()]
    public void Test_GetChecksum_ValidUic()
    {
        // Arrange
        string validUicNumber = "378478415805";

        // Act
        string checksum = UicNumberService.GetChecksum(validUicNumber);

        // Assert
        Assert.AreEqual("5", checksum);
    }

    [TestMethod()]
    public void Test_GetChecksum_InvalidUic()
    {
        // Arrange
        string invalidUicNumber = "37AÜ841599";

        // Assert
        Assert.ThrowsException<ArgumentException>(() =>
        {
            // Act
            _ = UicNumberService.GetChecksum(invalidUicNumber);
        });
    }
}