using Poke.Data.Extensions;
using Poke.Domain.Dto.Response.Details;

namespace Poke.Data.UseCases
{
    public class GetPokemonUseCase : IGetPokemon
    {
        private readonly IPokeService service;

        public GetPokemonUseCase(IPokeService service)
        {
            this.service = service;
        }

        public async Task<PokemonDetails> Get(string name)
        {

            var uri = $"https://pokeapi.co/api/v2/pokemon/{name.Trim().ToLower()}";

            var result = await service.GetPokerDetails(uri);

            var imgStream = await service.DownloadImagePoker(result.Sprites.FrontDefault);

            result.Sprites.FrontDefaultBase64 = imgStream.ConvertToBase64();

            var evolution = await service.GetPokerEvolution(result.Species.Url);

            result.Evolution = evolution;

            return result;
        }
    }
}
