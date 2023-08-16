using System.Reflection;
using Mediator.Queries.Product.GetAllProduct;
using Mediator.Queries.Product.GetByIdProduct;
using MediatR;
using Microsoft.Extensions.DependencyInjection;

namespace Mediator;

public static class ServiceRegistration
{
    public static void AddApplicationServices(this IServiceCollection services)
    {
        var assembly = AppDomain.CurrentDomain.GetAssemblies();
        services.AddMediatR(cfg => cfg.RegisterServicesFromAssembly(Assembly.GetExecutingAssembly()));
    }
}