using System.ComponentModel.DataAnnotations;
using Crud.Domain.Enums;

namespace Calculator.Application.Calculator.QueryParams;

public class GetCalculatorQueryParams
{

    [Required]
    public OperationTypeEnum OperationType { get; set; }
    
    [Required]
    [Range(int.MinValue, int.MaxValue)]
    public int FirstOperand { get; set; }
    
    [Required]
    [Range(int.MinValue, int.MaxValue)]
    public int SecondOperand { get; set; }
    
}