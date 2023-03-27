using Poke.Domain.Dto.Response;

namespace Poke.Data.UseCases
{
    public class GetPokemonsUseCase : IGetPokemons
    {
        private readonly IPokeService service;

        public GetPokemonsUseCase(IPokeService service)
        {
            this.service = service;
        }

        public async Task<PokemonResponse> Get(int offset)
        {
            var uri = $"https://pokeapi.co/api/v2/pokemon?limit=10&offset={offset}";

            var result = await service.GetPokers(uri);

            return result;
        }
    }
}
