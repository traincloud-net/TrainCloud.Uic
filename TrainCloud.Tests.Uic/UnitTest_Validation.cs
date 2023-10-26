using TrainCloud.Uic;

namespace TrainCloud.Tests.Uic;

[TestClass]
public class UnitTest_Validation
{
    protected IUicNumberService UicNumberService { get; init; }

    public UnitTest_Validation() 
    {
        UicNumberService = new UicNumberService();
    }

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
        string invalidUicNumber = "012345678912";

        // Act
        bool isValid = UicNumberService.ValidateUic(invalidUicNumber);

        // Assert
        Assert.IsFalse(isValid);
    }

    [TestMethod]
    public void Test_InvalidUic_Short()
    {
        // Arrange
        string invalidUicNumber = "1234567890";

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