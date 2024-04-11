using System.Data;
using Microsoft.AspNetCore.Components.Web;

namespace WebCalculator.Components.Pages;
using Microsoft.AspNetCore.Components; 
public partial class Home
{
    private float InputA { get; set; }
    private float InputB { get; set; }

    private string errorMessage = "";
    private bool hasError = false;
    private float? Result { get; set; } 

    private void Add()
    {
        var calc = new CalculatorEngine();
        Result = calc.Add(InputA, InputB);
    }

    private void Subtract()
    {
        var calc = new CalculatorEngine();
        Result = calc.Subtract(InputA, InputB);
    }

    private void Multiplication()
    {
        var calc = new CalculatorEngine();
        Result = calc.Multiplication(InputA, InputB);
    }
    
    private void Division()
    {
        var calc = new CalculatorEngine();
        Result = calc.Division(InputA, InputB);
    }
    
    private void Equals()
    {
        var calc = new CalculatorEngine();
        Result = calc.Equals(InputA, InputB, 8);
    }
    
    private void RaiseToPower()
    {
        var calc = new CalculatorEngine();
        Result = calc.RaiseToPower(InputA, InputB);
    }
    
    private void LogarithmOfNumber()
    {
        var calc = new CalculatorEngine();
        Result = calc.LogarithmOfNumber(InputA, InputB);
    }
    
    private void RootOfNumber()
    {
        var calc = new CalculatorEngine();
        Result = calc.RootOfNumber(InputA, InputB);
    }
    
    private void FactorialOfNumber()
    {
        var calc = new CalculatorEngine();
        Result = calc.FactorialOfNumber(InputA);
    }
    
    private void SineOfA()
    {
        var calc = new CalculatorEngine();
        Result = calc.SineOfA(InputA);
    }
    
    private void CosineOfA()
    {
        var calc = new CalculatorEngine();
        Result = calc.CosineOfA(InputA);
    }
    
    private void TangentOfA()
    {
        var calc = new CalculatorEngine();
        Result = calc.TangentOfA(InputA);
    }
    
    private void ReciprocalOfA()
    {
        var calc = new CalculatorEngine();
        Result = calc.ReciprocalOfA(InputA);
    }
    
    private void Clear()
    {
        InputA = 0;
        InputB = 0;
        errorMessage = "";
        hasError = false;
        Result = null; 
    }

}  
