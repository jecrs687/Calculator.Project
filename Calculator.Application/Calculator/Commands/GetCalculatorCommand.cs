using Crud.Application.Calculator.QueryParams;
using Crud.Domain.Enums;

namespace Crud.Application.Calculator.Commands;

public class GetCalculatorCommand
{
    
    public OperationTypeEnum OperationType { get; set; }
    public int FirstNumber;
    public int SecondNumber;
    
    public GetCalculatorCommand WithOperation(OperationTypeEnum operationType)
    {
        OperationType = operationType;
        return this;
    }
    
    public GetCalculatorCommand WithNumbers(int firstOperand, int secondOperand)
    {
        FirstNumber = firstOperand;
        SecondNumber = secondOperand;
        return this;
    }
}