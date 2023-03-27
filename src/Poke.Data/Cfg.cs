using Microsoft.Extensions.DependencyInjection;
using Poke.Data.UseCases;

namespace Poke.Data
{
    public static class Cfg
    {
        public static void AddCfgDataLayer(this IServiceCollection services)
        {
            services.AddTransient<IGetPokemons, GetPokemonsUseCase>();
            services.AddTransient<IGetPokemon, GetPokemonUseCase>();

            services.AddTransient<IPostPokemonMaster, PostPokemonMasterUseCase>();
            services.AddTransient<IPostPokemonCaught, PostPokemonCaughtUseCase>();
            services.AddTransient<IGetPokemonMaster, GetPokemonMasterUseCase>();
        }
    }
}
