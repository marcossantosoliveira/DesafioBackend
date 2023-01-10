using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.EntityFrameworkCore;

namespace DesafioBackend.Infra.Data
{
    public static class DependencyInjection
    {

        public static IServiceCollection AddInfrastructure(this IServiceCollection services,
                                                          IConfiguration configuration)
        {
            services.AddDbContext<ApplicationDbContext>(op =>
            op.UseSqlServer(
                configuration.GetConnectionString("ConexaoBD"),
                b => b.MigrationsAssembly(typeof(ApplicationDbContext).
                Assembly.FullName
                )));

            return services;
        }
    }
}
