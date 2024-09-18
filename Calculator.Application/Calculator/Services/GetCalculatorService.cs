using Crud.Application.Calculator.Commands;
using Crud.Application.Calculator.Contracts.Services;
using Crud.Domain.Enums;
using Crud.Domain.Utils;

namespace Crud.Application.Calculator.Services;

public class GetCalculatorService: IGetCalculatorService
{

    public double handleCommand(GetCalculatorCommand command)
    {
        int firstNumber = command.FirstNumber;
        int secondNumber = command.SecondNumber;
        switch (command.OperationType)
        {
            case OperationTypeEnum.Add:
                return CalculatorMachine.Add(firstNumber, secondNumber);
            case OperationTypeEnum.Subtract:
                return CalculatorMachine.Subtract(firstNumber, secondNumber);
            case OperationTypeEnum.Multiply:
                return CalculatorMachine.Multiply(firstNumber, secondNumber);
            default:
                throw new ArgumentOutOfRangeException(nameof(command.OperationType), command.OperationType, null);
        }
        
    }
}