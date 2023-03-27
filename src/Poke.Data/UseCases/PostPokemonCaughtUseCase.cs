using Poke.Domain.Dto.Request;
using Poke.Domain.Models;
using Poke.Infra.Context;

namespace Poke.Data.UseCases
{
    public class PostPokemonCaughtUseCase : IPostPokemonCaught
    {
        private readonly PokeContext context;

        public PostPokemonCaughtUseCase(PokeContext context)
        {
            this.context = context;
        }

        public async Task Execute(PokemonCaughtRequest request)
        {
            PokemonCaught pokemonCaught = request;

            context.PokemonCaught.Add(pokemonCaught);

            await context.SaveChangesAsync();

        }
    }
}
