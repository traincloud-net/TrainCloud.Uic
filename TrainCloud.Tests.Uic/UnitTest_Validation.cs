
namespace TrainCloud.Tests.Uic;

[TestClass]
public class UnitTest_Validation
{
    protected IUicNumberService UicNumberService { get; } = new UicNumberService();

    [TestMethod()]
    public void Test_ValidUic()
    {
        // Arrange
        string validUicNumber = "378478413198";

        // Act
        bool isValid = UicNumberService.ValidateUic(validUicNumber);

        // Assert
        Assert.IsTrue(isValid);
    }

    [TestMethod]
    public void Test_InvalidUic_Empty()
    {
        // Arrange
        string invalidUicNumber = string.Empty;

        // Act
        bool isValid = UicNumberService.ValidateUic(invalidUicNumber);

        // Assert
        Assert.IsFalse(isValid);
    }

    [TestMethod]
    public void Test_InvalidUic_TooShort()
    {
        // Arrange
        string invalidUicNumber = "1234567890";

        // Act
        bool isValid = UicNumberService.ValidateUic(invalidUicNumber);

        // Assert
        Assert.IsFalse(isValid);
    }

    [TestMethod]
    public void Test_InvalidUic_TooLong()
    {
        // Arrange
        string invalidUicNumber = "123456789012345";

        // Act
        bool isValid = UicNumberService.ValidateUic(invalidUicNumber);

        // Assert
        Assert.IsFalse(isValid);
    }

    [TestMethod]
    public void Test_InvalidUic_NotNumeric()
    {
        // Arrange
        string invalidUicNumber = "X12💩4567890$";

        // Act
        bool isValid = UicNumberService.ValidateUic(invalidUicNumber);

        // Assert
        Assert.IsFalse(isValid);
    }
}