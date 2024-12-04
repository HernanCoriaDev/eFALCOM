
using Infrastructure.DataAccess;
using Infrastructure.DataAccess.Implementacion;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using TrabajoIntegradorSofftek.DataAccess.Repositories.Interfaces;


namespace Infrastructure
{
    public static class DependencyInjectionService
    {
        public static IServiceCollection AddInfrastructure(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddDbContext<AppDbContext>(options =>
            options.UseSqlServer(configuration.GetConnectionString("DefaultConnection")));

            services.AddScoped<IUnitOfWork, UnitOfWorkService>();
            services.AddScoped<IPalletRepository, PalletRepository>();

            return services;
        }
    }
}
