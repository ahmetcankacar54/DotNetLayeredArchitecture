using System.Reflection;
using Microsoft.Extensions.DependencyInjection;
using Repository.Repository.Concretes;
using Repository.Repository.Interfaces;

namespace Repository;

public static class ServiceRegistration
{
    public static IServiceCollection AddRepositoryServices(this IServiceCollection services)
    {
        services.AddScoped(typeof(IBaseRepository<>), typeof(BaseRepository<>));
        services.AddScoped(typeof(IProductRepository), typeof(ProductRepository));
        services.AddScoped(typeof(IUserRepository), typeof(UserRepository));
        services.AddScoped(typeof(ICategoryRepository), typeof(CategoryRepository));
        services.AddScoped(typeof(IBrandRepository), typeof(BrandRepository));
        services.AddScoped(typeof(IOrderRepository), typeof(OrderRepository));
        services.AddScoped<IUnitOfWork, UnitOfWork>();
        return services; 
    }
}