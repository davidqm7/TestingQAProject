using System.Data;
using Microsoft.AspNetCore.Components.Web;

namespace WebCalculator.Components.Pages;
using Microsoft.AspNetCore.Components; 
public partial class Home
{
    private string InputA { get; set; } = "";
    private string InputB { get; set; } = "";

    private float GetInputBFloat() => float.Parse(InputB);
    private float GetInputAFloat() => float.Parse(InputA);

    private string ErrorMessage = "";
    private bool hasError = false;
    private float? Result { get; set; } 

    
    
   
    private void Clear()
    {
        InputA = "0";
        InputB = "0";
        ErrorMessage = "";
        hasError = false;
        Result = null; 
        
    }

     private static bool IsValidInput(string input)
     {
         var result = float.TryParse(input.ToString(), out _);
         return result;
     }
     
    private void SetErrorState(string message)
    {
        ErrorMessage = message;
        hasError = true;
    }

    private void ClearErrorState()
    {
        hasError = false;
    }
    
    private void Add()
    {
        if (!IsValidInput(InputA) || !IsValidInput(InputB))
        {
            SetErrorState("Invalid Input, Numbers Only");
            return;
        }

        ClearErrorState();
        
        var calc = new CalculatorEngine();
        Result = calc.Add(GetInputAFloat(), GetInputBFloat());
    }

    private void Subtract()
    {
        var calc = new CalculatorEngine();
        Result = calc.Subtract(GetInputAFloat(), GetInputBFloat());
    }

    private void Multiplication()
    {
        var calc = new CalculatorEngine();
        Result = calc.Multiplication(GetInputAFloat(),GetInputBFloat());
    }
    
    private void Division()
    {
        if (GetInputBFloat() == 0)
        {
            SetErrorState("Not a Number");
            return;
        }

        var calc = new CalculatorEngine();
        Result = calc.Division(GetInputAFloat(), GetInputBFloat());
    }
    
    private void Equals()
    {
        var calc = new CalculatorEngine();
        Result = calc.Equals(GetInputAFloat(), GetInputBFloat(), 8);
    }
    
    private void RaiseToPower()
    {
        var calc = new CalculatorEngine();
        Result = calc.RaiseToPower(GetInputAFloat(), GetInputBFloat());
    }
    
    private void LogarithmOfNumber()
    {
        var calc = new CalculatorEngine();
        Result = calc.LogarithmOfNumber(GetInputAFloat(), GetInputBFloat());
    }
    
    private void RootOfNumber()
    {
        var calc = new CalculatorEngine();
        Result = calc.RootOfNumber(GetInputAFloat(), GetInputBFloat());
    }
    
    private void FactorialOfNumber()
    {
        var calc = new CalculatorEngine();
        Result = calc.FactorialOfNumber(GetInputAFloat());
    }
    
    private void SineOfA()
    {
        var calc = new CalculatorEngine();
        Result = calc.SineOfA(GetInputAFloat());
    }
    
    private void CosineOfA()
    {
        var calc = new CalculatorEngine();
        Result = calc.CosineOfA(GetInputAFloat());
    }
    
    private void TangentOfA()
    {
        var calc = new CalculatorEngine();
        Result = calc.TangentOfA(GetInputAFloat());
    }
    
    private void ReciprocalOfA()
    {
        var calc = new CalculatorEngine();
        Result = calc.ReciprocalOfA(GetInputAFloat());
    }
    
  
}  
