using AutoMapper;
using Microsoft.Extensions.DependencyInjection;
using Service.AutoMapper.Profiles;
using Service.Concretes;
using Service.Interfaces;

namespace Service;

public static class ServiceRegistration
{
    public static void AddServiceServices(this IServiceCollection services)
    {
        services.AddScoped(typeof(IUserService), typeof(UserService));
        services.AddScoped(typeof(IBrandService), typeof(BrandService));
        services.AddScoped(typeof(ICategoryService), typeof(CategoryService));
        services.AddScoped(typeof(IOrderService), typeof(OrderService));
        services.AddScoped(typeof(IProductService), typeof(ProductService));

        var mappingConfig = new MapperConfiguration(cfg =>
        {
            cfg.AddProfile(new MappingProfile());
        });

        IMapper mapper = mappingConfig.CreateMapper();
        services.AddSingleton(mapper);
    }
}