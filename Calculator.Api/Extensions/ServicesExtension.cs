using Crud.Application.Calculator.Contracts.Services;
using Crud.Application.Calculator.Services;

namespace Crud.Api.Extensions;

public static class ServicesExtension
{
    public static IServiceCollection AddServices(this IServiceCollection services)
    {
        services.AddSingleton<IGetCalculatorService, GetCalculatorService>();
        return services;
    }
}