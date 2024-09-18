using Crud.Domain.Utils;

namespace Crud.Test.Unit.Utils;

public class CalculatorMachineTest
{
    [Fact]
    public void ShouldReturnAddition()
    {
        var result3 = CalculatorMachine.Add(1, 2);
        var result10 = CalculatorMachine.Add(5, 5);
        var result50 = CalculatorMachine.Add(25, 25);
        Assert.Equal(3, result3);
        Assert.Equal(10, result10);
        Assert.Equal(50, result50);
    }
    
    [Fact]
    public void ShouldReturnSubtraction()
    {
        var result3 = CalculatorMachine.Subtract(2, 1);
        var result10 = CalculatorMachine.Subtract(15, 5);
        var result50 = CalculatorMachine.Subtract(75, 25);
        Assert.Equal(1, result3);
        Assert.Equal(10, result10);
        Assert.Equal(50, result50);
    }
    
    [Fact]
    public void ShouldReturnMultiplication()
    {
        var result4 = CalculatorMachine.Multiply(2, 2);
        var result10 = CalculatorMachine.Multiply(5, 2);
        var result50 = CalculatorMachine.Multiply(5, 10);
        Assert.Equal(4, result4);
        Assert.Equal(10, result10);
        Assert.Equal(50, result50);
    }
    [Fact]
    public void ShouldReturnDivision()
    {
        var result2 = CalculatorMachine.Divide(4, 2);  
        var result5 = CalculatorMachine.Divide(10, 2);
        var result10 = CalculatorMachine.Divide(100, 10);
        Assert.Equal(2, result2);
        Assert.Equal(5, result5);
        Assert.Equal(10, result10);
        
    }
}