namespace Crud.Domain.Utils;

public class CalculatorMachine
{
    public static double Add(double a, double b)
    {
        return a + b;
    }
    public static double Subtract(double a, double b)
    {
        return a - b;
    }
    
    public static double Multiply(double a, double b)
    {
        return a * b;
    }
    
    public static double Divide(double a, double b)
    {
        return a / b;
    }
    
}