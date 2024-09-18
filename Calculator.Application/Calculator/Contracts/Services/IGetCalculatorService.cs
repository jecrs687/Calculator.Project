using Calculator.Application.Calculator.Commands;

namespace Calculator.Application.Calculator.Contracts.Services;


public interface IGetCalculatorService
{
    double handleCommand(GetCalculatorCommand command);
}