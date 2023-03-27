
using Microsoft.Extensions.DependencyInjection;
using Poke.Domain.Interfaces.Services;
using Poke.Services.Services;

namespace Poke.Services
{
    public static class Cfg
    {
        public static void AddCfgServices(this IServiceCollection services)
        {

            services.AddScoped<IPokeService, PokeService>();
        }
    }
}
