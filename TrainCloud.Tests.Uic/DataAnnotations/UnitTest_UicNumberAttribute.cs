using System.ComponentModel.DataAnnotations;
using TrainCloud.Uic.DataAnnotations;
using TrainCloud.Uic.Services;

namespace TrainCloud.Tests.DataAnnotations;

public class TestModel
{
    public Guid Id { get; set; } = Guid.NewGuid();

    [UicNumber]
    public string FullUic { get; set; } = string.Empty;

    public string? OtherStringProperty { get; set; }

    public int OtherIntegerProperty { get; set; }
}


[TestClass]
public class UnitTest_UicNumberAttribute
{
    protected IUicNumberService UicNumberService { get; } = new UicNumberService();

    [TestMethod()]
    public void Test_ValidateModel_ValidUic()
    {
        // Arrange
        string validUicNumber = "378478415805";

        TestModel tm = new()
        {
            FullUic = validUicNumber
        };

        var context = new ValidationContext(tm, serviceProvider: null, items: null)
        {
            MemberName = "FullUic"
        };

        List<ValidationResult> validationResults = new();

        // Act
        bool success = Validator.TryValidateProperty(tm.FullUic, context, validationResults);

        // Assert
        Assert.IsTrue(success);
    }

    [TestMethod()]
    public void Test_ValidateModel_InvalidUic()
    {
        // Arrange
        string validUicNumber = "555";

        TestModel tm = new()
        {
            FullUic = validUicNumber
        };

        var context = new ValidationContext(tm, serviceProvider: null, items: null)
        {
            MemberName = "FullUic"
        };

        List<ValidationResult> validationResults = new();

        // Act
        bool success = Validator.TryValidateProperty(tm.FullUic, context, validationResults);


        // Assert
        Assert.IsFalse(success);
    }
}