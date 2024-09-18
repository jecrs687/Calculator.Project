using Crud.Application.Calculator.Commands;
using Crud.Application.Calculator.Services;
using Crud.Domain.Enums;
using FluentAssertions;

namespace Calculator.Test.Integration.Application;

public class GetUserCalculatorTest
{
    [Fact]
    public void ShouldReturnAddition()
    {
        // Arrange
        var command = new GetCalculatorCommand
        {
            FirstNumber = 1,
            SecondNumber = 2,
            OperationType = OperationTypeEnum.Add
        };
        var service = new GetCalculatorService();
        
        // Act
        var result = service.handleCommand(command);
        
        // Assert
        Assert.Equal(3, result);
    }
    [Fact]
    public void ShouldReturnSubtraction()
    {
        // Arrange
        var command = new GetCalculatorCommand
        {
            FirstNumber = 2,
            SecondNumber = 1,
            OperationType = OperationTypeEnum.Subtract
        };
        var service = new GetCalculatorService();
        
        // Act
        var result = service.handleCommand(command);
        
        // Assert
        Assert.Equal(1, result);
    }
    [Fact]
    public void ShouldReturnMultiplication()
    {
        // Arrange
        var command = new GetCalculatorCommand
        {
            FirstNumber = 2,
            SecondNumber = 2,
            OperationType = OperationTypeEnum.Multiply
        };
        var service = new GetCalculatorService();
        
        // Act
        var result = service.handleCommand(command);
        
        // Assert
        Assert.Equal(4, result);
    }
    [Fact]
    public void ShouldThrowErrorWhenOperationTypeIsInvalid()
    {
        // Arrange
        var command = new GetCalculatorCommand
        {
            FirstNumber = 2,
            SecondNumber = 2,
            OperationType = (OperationTypeEnum) 4
        };
        var service = new GetCalculatorService();
        
        // Act
        Func<double> act = () => service.handleCommand(command);
        // Assert
        act.Should().Throw<ArgumentOutOfRangeException>();
    }
}