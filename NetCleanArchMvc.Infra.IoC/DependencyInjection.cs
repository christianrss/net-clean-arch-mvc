using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using NetCleanArchMvc.Application.Interfaces;
using NetCleanArchMvc.Application.Mappings;
using NetCleanArchMvc.Application.Services;
using NetCleanArchMvc.Domain.Interfaces;
using NetCleanArchMvc.Infra.Data.Context;
using NetCleanArchMvc.Infra.Data.Repositories;

namespace NetCleanArchMvc.Infra.IoC;

public static class DependencyInjection
{
    public static IServiceCollection AddInfrastructure(this IServiceCollection services,
        IConfiguration configuration)
    {
        services.AddDbContext<ApplicationDbContext>(options =>
            options.UseSqlServer(configuration.GetConnectionString("DefaultConnection"),
                b => b.MigrationsAssembly(typeof(ApplicationDbContext).Assembly.FullName)
            )
        );

        services.AddScoped<ICategoryRepository, CategoryRepository>();
        services.AddScoped<IProductRepository, ProductRepository>();

        services.AddScoped<IProductService, ProductService>();
        services.AddScoped<ICategoryService, CategoryService>();
        services.AddAutoMapper(cfg => {}, typeof(DomainToDTOMappingProfile).Assembly);

        services.AddMediatR(cfg => cfg.RegisterServicesFromAssembly(typeof(DomainToDTOMappingProfile).Assembly));

        return services;
    }
}
