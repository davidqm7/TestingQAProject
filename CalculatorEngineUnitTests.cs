using System.Diagnostics.CodeAnalysis;
using NUnit.Framework.Constraints;
using NUnit.Framework.Legacy;


namespace WebCalculator;
using NUnit.Framework;


[TestFixture]
public class CalculatorEngineUnitTests
{
    private CalculatorEngine _calculator;

    [SetUp]
    public void SetUp()
    {
        _calculator = new CalculatorEngine();
    }

    [Test]
    public void CalculatorEngine_AddAandB_ReturnsSum()
    {
        //Arrange
        float a = 2;
        float b = 2;

        // Act
        float sum = _calculator.Add(a, b);

        // Assert
        Assert.That(4, Is.EqualTo(sum));
     
    }

    [Test]
    public void CalculatorEngine_SubAandB_ReturnsResult()
    {
        //Arrange
        float a = 10;
        float b = 7;

        //Act
        float result = _calculator.Subtract(a, b);

        //Assert
        Assert.That(3, Is.EqualTo(result));
    }


    [Test]
    public void CalculatorEngine_MultiAndB_ReturnsResults()
    {
        //Arrange
        float a = 5;
        float b = 5; 
        //Act
        float result = _calculator.Multiplication(a, b);
        //Assert
        Assert.That(25, Is.EqualTo(result));
    }

    [Test]
    public void CalculatorEngine_DivideAndB_ReturnResult()
    {
        //Arrange
        float a = 10;
        float b = 2; 
        //Act
        float result = _calculator.Division(a, b);
        //Assert
        Assert.That(5, Is.EqualTo(result));
    }
    
    
    [Test]
    public void CalculatorEngine_DividesAand0_ReturnsResult()
    {
        //Arrange
        float a = 5;
        float b = 0; 
        //Act
        float result = _calculator.Division(a, b);
        //Assert
        Assert.That(float.IsNaN(result),Is.True);
    }
    
    [Test]
    public void CalculatorEngine_Divides0andB_ReturnsResult()
    {
        //Arrange
        float a = 0;
        float b = 5; 
        //Act
        float result = _calculator.Division(a, b);
        //Assert
        Assert.That(0, Is.EqualTo(result));
    }

    [Test]
    public void CalculatorEngine_EqualsAandB_ReturnsResult()
    {
        //Arrange
        float a = 0.333333f;
        float b = 0.333333f; 
        //Act
        float result = _calculator.Equals(a,b,8);
        //Assert
        Assert.That(1, Is.EqualTo(result));
    }
    
    [Test]
    public void CalculatorEngine_EqualsAandB2_ReturnsResult()
    {
        //Arrange
        float a = 0.333333f;
        float b = 0.333334f; 
        //Act
        float result = _calculator.Equals(a,b,8);
        //Assert
        Assert.That(0, Is.EqualTo(result));
    }
    
    [Test]
    public void CalculatorEngine_EqualsAandB3_ReturnsResult()
    {
        //Arrange
        float a = 0.333333331f;
        float b = 0.333333333f; 
        //Act
        float result = _calculator.Equals(a,b,8);
        //Assert
        Assert.That(1, Is.EqualTo(result));
    }

    [Test]
    public void CalculatorEngine_RaisetoPower_ReturnsResult()
    {
        //Arrange
        float a = 2;
        float b = 3; 
        //Act
        float result = _calculator.RaiseToPower(a, b);
        //Assert
        Assert.That(8, Is.EqualTo(result));
    }

    [Test]
    public void CalculatorEngine_LogOfNumberBaseIsZero_ReturnsResult()
    {
        //Arrange
        float a = 2;
        float b = 0; 
        //Act
        float result = _calculator.LogarithmOfNumber(a, b); 
        //Assert
        Assert.That(float.IsNaN(result),Is.True);

    }
    
    [Test]
    public void CalculatorEngine_LogOfNumber_ReturnsResult()
    {
        //Arrange
        float a = 2;
        float b = 16; 
        //Act
        float result = _calculator.LogarithmOfNumber(a, b); 
        //Assert
       Assert.That(4, Is.EqualTo(result));
    }

    [Test]
    public void CalculatorEngine_RootOfNumberBaseIs0_ReturnsResult()
    {
        //Arrange
        float a = 5;
        float b = 0; 
        //Act
        float result = _calculator.RootOfNumber(a, b);
        //Assert
        Assert.That(float.IsNaN(result),Is.True);
    }

    [Test]
    public void CalculatorEngine_RootOfNumber_ReturnsResult()
    {
        //Arrange
        float a = 8;
        float b = 3; 
        //Act
        float result = _calculator.RootOfNumber(a, b);
        //Assert
        Assert.That(2, Is.EqualTo(result));
    }

    [Test]
    public void CalculatorEngine_FactorialOfNumberWhen0_ReturnsOnet()
    {
        //Arrange
        float a = 0;
        //Act
        float result = _calculator.FactorialOfNumber(a);
        //Assert
        Assert.That(1, Is.EqualTo(result));
    }
    
    [Test]
    public void CalculatorEngine_FactorialOfNumberPositive_ReturnsOnet()
    {
        //Arrange
        float a = 5;
        //Act
        float result = _calculator.FactorialOfNumber(a);
        //Assert
        Assert.That(120, Is.EqualTo(result));
    }
    
    [Test]
    public void CalculatorEngine_FactorialOfNumberNegative_ReturnsOne()
    {
        //Arrange
        float a = -5;
        //Act
        float result = _calculator.FactorialOfNumber(a);
        //Assert
        Assert.That(1, Is.EqualTo(result));
    }

    [Test]
    public void CalculatorEngine_SinOfAPositve_ReturnsResult()
    {
        //Arrange
        float a = 360; 
        //Act
        float result = _calculator.SineOfA(a);
        //Assert
        Assert.That(0, Is.EqualTo(result));
    }
    
    [Test]
    public void CalculatorEngine_SinOfANegative_ReturnsResult()
    {
        //Arrange
        float a = -600; 
        //Act
        float result = _calculator.SineOfA(a);
        //Assert
        Assert.That(0.866025388f, Is.EqualTo(result));
    }
    
    [Test]
    public void CalculatorEngine_SinOfA1_ReturnsResult()
    {
        //Arrange
        float a = 1; 
        //Act
        float result = _calculator.SineOfA(a);
        //Assert
        Assert.That(0.0174524058f, Is.EqualTo(result));
    }
    
    [Test]
    public void CalculatorEngine_SinOfA0_ReturnsResult()
    {
        //Arrange
        float a = 0; 
        //Act
        float result = _calculator.SineOfA(a);
        //Assert
      Assert.That(0, Is.EqualTo(result));
    }

   
    [Test]
    public void CalculatorEngine_CosOfAPostive_ReturnResult()
    {
        //Arrange
        float a = 600; 
        //Act
        float result = _calculator.CosineOfA(a);
        //Assert
        Assert.That(-0.499999911f, Is.EqualTo(result));
    }
    
    [Test]
    public void CalculatorEngine_CosOfANegative_ReturnResult()
    {
        //Arrange
        float a = -600; 
        //Act
        float result = _calculator.CosineOfA(a);
        //Assert
        Assert.That(-0.50000006f, Is.EqualTo(result));
    }
    
    [Test]
    public void CalculatorEngine_CosOfA1_ReturnResult()
    {
        //Arrange
        float a = 1; 
        //Act
        float result = _calculator.CosineOfA(a);
        //Assert
        Assert.That(0.99984771f, Is.EqualTo(result));
    }
    
    [Test]
    public void CalculatorEngine_TangentOfAPositve_ReturnResult()
    {
        //Arrange
        float a = 360; 
        //Act
        float result = _calculator.TangentOfA(a);
        //Assert
        Assert.That(0, Is.EqualTo(result));
    }
    
    [Test]
    public void CalculatorEngine_TangentOfANegative_ReturnResult()
    {
        //Arrange
        float a = -600; 
        //Act
        float result = _calculator.TangentOfA(a);
        //Assert
        Assert.That(-1.73205054f, Is.EqualTo(result));
    }

    [Test]
    public void CalculatorEngine_TangentOfA1_ReturnResult()
    {
        //Arrange
        float a = 1; 
        //Act
        float result = _calculator.TangentOfA(a);
        //Assert
        Assert.That(0.0174550656f, Is.EqualTo(result));
    }

    [Test]
    public void CalculatorEngine_ReciprocalOfA0_ReturnsResult()
    {
        //Arrange
        float a = 0; 
        //Act
        float result = _calculator.ReciprocalOfA(a);
        //Assert
        Assert.That(float.IsNaN(result),Is.True);
    }
    
    [Test]
    public void CalculatorEngine_ReciprocalOfAPositive_ReturnsResult()
    {
        //Arrange
        float a = 8; 
        //Act
        float result = _calculator.ReciprocalOfA(a);
        //Assert
        Assert.That(0.125, Is.EqualTo(result));
    }
    
    [Test]
    public void CalculatorEngine_ReciprocalOfANegative_ReturnsResult()
    {
        //Arrange
        float a = -4; 
        //Act
        float result = _calculator.ReciprocalOfA(a);
        //Assert
        Assert.That(-0.25, Is.EqualTo(result));
    }

    
}