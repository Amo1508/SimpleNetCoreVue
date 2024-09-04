using MediatR;
using SimpleNetCoreVue.Application;
using System.Reflection;

namespace SimpleNetCoreVue.DiExtension;

public static class ApCommandExtension
{
    public static IServiceCollection AddApCommands(this IServiceCollection service)
    {
        service.AddMediatR(cf => cf.RegisterServicesFromAssembly(Assembly.GetExecutingAssembly()));
        service.AddScoped<IRequestHandler<GetTestDataRequest, GetTestDataResponse>, GetTestDataCommandHandler>();
        service.AddScoped<IRequestHandler<NumberAddRequest, NumberAddResponse>, NumberAddCommandHandler>();
        return service;
    }
}