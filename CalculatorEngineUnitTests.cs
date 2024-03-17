using System.Diagnostics.CodeAnalysis;
using NUnit.Framework.Constraints; 


namespace WebCalculator;
using NUnit.Framework;


[TestFixture]
public class CalculatorEngineUnitTests
{
    private CalculatorEngine calculator;

    [SetUp]
    public void setUp()
    {
        calculator = new CalculatorEngine();
    }

    [Test]
    public void CalcualtorEngine_AddAandB_ReturnsSum()
    {
        //Arrange
        float a = 2;
        float b = 2;

        // Act
        float sum = calculator.Add(a, b);

        // Assert
        Assert.Equals(4, sum); 
     
    }

    [Test]
    public void CalculatorEngine_SubAandB_ReturnsResult()
    {
        //Arrange
        float a = 10;
        float b = 7;

        //Act
        float result = calculator.Subtract(a, b);

        //Assert
        Assert.Equals(4, result);
    }


    [Test]
    public void CalculatorEngine_MultiAndB_ReturnsResults()
    {
        //Arrange
        float a = 5;
        float b = 5; 
        //Act
        float result = calculator.Multiplication(a, b);
        //Assert
        Assert.Equals(25, result); 
    }

    [Test]
    public void CalculatorEngine_DivideAndB_ReturnResult()
    {
        //Arrange
        float a = 10;
        float b = 2; 
        //Act
        float result = calculator.Division(a, b);
        //Assert
        Assert.Equals(5, result);
    }
    
    
    [Test]
    public void CalculatorEngine_DividesAand0_ReturnsResult()
    {
        //Arrange
        float a = 5;
        float b = 0; 
        //Act
        float result = calculator.Division(a, b);
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
        float result = calculator.Division(a, b);
        //Assert
        Assert.Equals(0, result);
    }

    [Test]
    public void CalculatorEngine_EqualsAandB_ReturnsResult()
    {
        //Arrange
        float a = 0.333333f;
        float b = 0.333333f; 
        //Act
        float result = calculator.Equals(a,b,8);
        //Assert
        Assert.Equals(1, result);
    }
    
    [Test]
    public void CalculatorEngine_EqualsAandB2_ReturnsResult()
    {
        //Arrange
        float a = 0.333333f;
        float b = 0.333334f; 
        //Act
        float result = calculator.Equals(a,b,8);
        //Assert
        Assert.Equals(0, result);
    }
    
    [Test]
    public void CalculatorEngine_EqualsAandB3_ReturnsResult()
    {
        //Arrange
        float a = 0.333333331f;
        float b = 0.333333333f; 
        //Act
        float result = calculator.Equals(a,b,8);
        //Assert
        Assert.Equals(1, result);
    }

    [Test]
    public void CalculatorEngine_RaisetoPower_ReturnsResult()
    {
        //Arrange
        float a = 2;
        float b = 3; 
        //Act
        float result = calculator.RaiseToPower(a, b);
        //Assert
        Assert.Equals(8, result);
    }

    [Test]
    public void CalculatorEngine_LogOfNumberBaseIsZero_ReturnsResult()
    {
        //Arrange
        float a = 2;
        float b = 0; 
        //Act
        float result = calculator.LogarithmOfNumber(a, b); 
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
        float result = calculator.LogarithmOfNumber(a, b); 
        //Assert
        Assert.Equals(4, result);
    }

    [Test]
    public void CalculatorEngine_RootOfNumberBaseIs0_ReturnsResult()
    {
        //Arrange
        float a = 5;
        float b = 0; 
        //Act
        float result = calculator.RootOfNumber(a, b);
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
        float result = calculator.RootOfNumber(a, b);
        //Assert
        Assert.Equals(2, result);
    }

    [Test]
    public void CalculatorEngine_FactorialOfNumberWhen0_ReturnsOnet()
    {
        //Arrange
        float a = 0;
        //Act
        float result = calculator.FactorialOfNumber(a);
        //Assert
        Assert.Equals(1, result);
    }
    
    [Test]
    public void CalculatorEngine_FactorialOfNumberPositive_ReturnsOnet()
    {
        //Arrange
        float a = 5;
        //Act
        float result = calculator.FactorialOfNumber(a);
        //Assert
        Assert.Equals(120, result);
    }
    
    [Test]
    public void CalculatorEngine_FactorialOfNumberNegative_ReturnsOne()
    {
        //Arrange
        float a = -5;
        //Act
        float result = calculator.FactorialOfNumber(a);
        //Assert
        Assert.Equals(-120, result);
    }

    [Test]
    public void CalculatorEngine_SinOfAPositve_ReturnsResult()
    {
        //Arrange
        float a = 360; 
        //Act
        float result = calculator.SineOfA(a);
        //Assert
        Assert.Equals(0, result);
    }
    
    [Test]
    public void CalculatorEngine_SinOfANegative_ReturnsResult()
    {
        //Arrange
        float a = -360; 
        //Act
        float result = calculator.SineOfA(a);
        //Assert
        Assert.Equals(0, result);
    }
    
    [Test]
    public void CalculatorEngine_SinOfA1_ReturnsResult()
    {
        //Arrange
        float a = 1; 
        //Act
        float result = calculator.SineOfA(a);
        //Assert
        Assert.Equals(0.0174524, result);
    }
    
    [Test]
    public void CalculatorEngine_SinOfA0_ReturnsResult()
    {
        //Arrange
        float a = 0; 
        //Act
        float result = calculator.SineOfA(a);
        //Assert
        Assert.Equals(0, result);
    }

    [Test]
    public void CalculatorEngine_CosOfAPostive_ReturnResult()
    {
        //Arrange
        float a = 360; 
        //Act
        float result = calculator.CosineOfA(a);
        //Assert
        Assert.Equals(1, result);
    }
    
    [Test]
    public void CalculatorEngine_CosOfANegative_ReturnResult()
    {
        //Arrange
        float a = -360; 
        //Act
        float result = calculator.CosineOfA(a);
        //Assert
        Assert.Equals(1, result);
    }
    
    [Test]
    public void CalculatorEngine_CosOfA1_ReturnResult()
    {
        //Arrange
        float a = 1; 
        //Act
        float result = calculator.CosineOfA(a);
        //Assert
        Assert.Equals(0.99985, result);
    }
    
    [Test]
    public void CalculatorEngine_TangentOfAPositve_ReturnResult()
    {
        //Arrange
        float a = 360; 
        //Act
        float result = calculator.TangentOfA(a);
        //Assert
        Assert.Equals(0, result);
    }
    
    [Test]
    public void CalculatorEngine_TangentOfANegative_ReturnResult()
    {
        //Arrange
        float a = -360; 
        //Act
        float result = calculator.TangentOfA(a);
        //Assert
        Assert.Equals(0, result);
    }

    [Test]
    public void CalculatorEngine_TangentOfA1_ReturnResult()
    {
        //Arrange
        float a = 1; 
        //Act
        float result = calculator.TangentOfA(a);
        //Assert
        Assert.Equals(0.0174551, result);
    }

    [Test]
    public void CalculatorEngine_ReciprocalOfA0_ReturnsResult()
    {
        //Arrange
        float a = 0; 
        //Act
        float result = calculator.ReciprocalOfA(a);
        //Assert
        Assert.That(float.IsNaN(result),Is.True);
    }
    
    [Test]
    public void CalculatorEngine_ReciprocalOfAPositive_ReturnsResult()
    {
        //Arrange
        float a = 8; 
        //Act
        float result = calculator.ReciprocalOfA(a);
        //Assert
        Assert.Equals(0.125,result);
    }
    
    [Test]
    public void CalculatorEngine_ReciprocalOfANegative_ReturnsResult()
    {
        //Arrange
        float a = -4; 
        //Act
        float result = calculator.ReciprocalOfA(a);
        //Assert
        Assert.Equals(-0.25,result);
    }

    
}