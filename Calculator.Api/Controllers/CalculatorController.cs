using Calculator.Application.Calculator.Commands;
using Calculator.Application.Calculator.Contracts.Services;
using Calculator.Application.Calculator.QueryParams;
using Microsoft.AspNetCore.Mvc;

namespace Calculator.Api.Controllers;

[ApiController]
[Route("")]
public class CalculatorController(IGetCalculatorService calculatorService) : ControllerBase
{
    [HttpGet()]
    public double Get([FromQuery] GetCalculatorQueryParams queryParams)
    {
        var command = new  GetCalculatorCommand()
            .WithOperation(queryParams.OperationType)
            .WithNumbers(queryParams.FirstOperand, queryParams.SecondOperand);
        return calculatorService.handleCommand(command);
    }
}
