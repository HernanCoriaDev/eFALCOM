using Microsoft.OpenApi.Models;

namespace API
{
    public static class DependencyInjectionService
    {
        public static IServiceCollection AddWebApi(this IServiceCollection services)
        {
            services.AddSwaggerGen(option =>
            {
                option.SwaggerDoc("v1", new OpenApiInfo
                {
                    Version = "v1",
                    Title = "eFALCOM",
                    Description = "Gestión de Pallets en un Centro de Distribución"
                });
            });

            return services;
        }
    }
}
