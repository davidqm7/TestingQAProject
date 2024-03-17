using System.Net.Sockets; 

namespace WebCalculator;

public class CalculatorEngine
{
    public float Add (float a, float b)
    {
        return  a +  b; 
    }
    
    public float Subtract (float a, float b)
    {
        return  a -  b; 
    }
    
    public float Multiplication (float a, float b)
    {
        return  a *  b; 
    }
    
    public float Division (float a, float b)
    {
        if (b == 0)
        {
            return float.NaN;
        }
        return  a /  b; 
    }

    public float Equals(float a, float b, int precision)
    {
        float epsilon = (float)Math.Pow(10, -precision);

        if (Math.Abs(a - b) < epsilon)
        {
            return 1;
        }
        else
        {
            return 0;
        }
    }

    public float RaiseToPower(float a, float b)
    {
        return (float)Math.Pow(a,b); 
    }

    public float LogarithmOfNumber(float a, float b)
    {
        if (b == 0)
        {
            return float.NaN;
        }

        float Result = (float)Math.Pow(b, 1.0 / a);
        return Result;
    }

    public float RootOfNumber(float a, float b)
    {
        if (b == 0)
        {
            return float.NaN;
        }
        return (float)Math.Pow(a, (1.0 / b));
    }

    public float FactorialOfNumber(float a)
    {
        if (a == 0)
                return 1;
        float result = 1;
        for (int i = 2; i <= a; i++)
            result *= i;
        return result;
        
    }

    public float SineOfA(float a)
    {
        return (float)Math.Sin(a); 

    }

    public float CosineOfA(float a)
    {
        return (float)Math.Cos(a);

    }

    public float TangentOfA(float a)
    {
        return (float)Math.Tan(a);
    }

    public float ReciprocalOfA(float a)
    {
        return 1 / a; 
    }
    

}