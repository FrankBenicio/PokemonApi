using Microsoft.Extensions.Configuration;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Poke.Infra.Context;

namespace Poke.Infra
{
    public static class Cfg
    {
        public static void AddCfgDatabase(this IServiceCollection services, IConfiguration Configuration)
        {
            services.AddDbContext<PokeContext>(x =>
                   x.EnableSensitiveDataLogging()
                    .UseSqlite(connectionString: Configuration.GetConnectionString("Context"))
               );
        }
    }
}
