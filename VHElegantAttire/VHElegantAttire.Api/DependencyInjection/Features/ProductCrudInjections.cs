using VHElegantAttire.Application.Abstractions.Features.ProductCrud.Repository;

namespace VHElegantAttire.Api.DependencyInjection.Features
{
    public static class ProductCrudInjections
    {
        public static IServiceCollection AddProductCrudInjections(this IServiceCollection services)
        {
            services.AddScoped<IProductRepository, ProductRepository>();
           

            return services;
        }
    }
}
