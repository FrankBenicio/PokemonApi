using Microsoft.EntityFrameworkCore;
using Poke.Domain.Dto.Response.Details;
using Poke.Domain.Dto.Response.Master;
using Poke.Infra.Context;

namespace Poke.Data.UseCases
{
    public class GetPokemonMasterUseCase : IGetPokemonMaster
    {
        private readonly PokeContext context;
        private readonly IGetPokemon pokemonDetail;

        public GetPokemonMasterUseCase(PokeContext context, IGetPokemon pokemonDetail)
        {
            this.context = context;
            this.pokemonDetail = pokemonDetail;
        }

        public async Task<PokemonMasterResponse> Get(Guid id)
        {
            var master = await context.PokemonMaster.Include(x => x.PokemonCaught).FirstOrDefaultAsync(x => x.Id == id);

            if (master == null)
                return null;

            var pokemons = new List<PokemonDetails>();

            foreach (var pokemonCaught in master.PokemonCaught)
            {
                var pokemon = await pokemonDetail.Get(pokemonCaught.Pokemon);

                pokemons.Add(pokemon);
            }

            var response = new PokemonMasterResponse
            {
                Age = master.Age,
                Cpf = master.Cpf,
                Id = id,
                Name = master.Name,
                PokemonsCaught = pokemons.Select(x => new PokemonCaughtResponse { PokemonDetails = x }).ToList()
            };

            return response;

        }
    }
}
