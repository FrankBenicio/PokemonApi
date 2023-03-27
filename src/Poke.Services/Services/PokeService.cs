using Poke.Domain.Dto.Response;
using Poke.Domain.Interfaces.Services;
using RestSharp.Authenticators;
using RestSharp;
using System.Threading;
using Poke.Domain.Dto.Response.Details;
using Poke.Domain.Dto.Response.Evolution;

namespace Poke.Services.Services
{
    public class PokeService : IPokeService
    {
        public async Task<PokemonResponse> GetPokers(string uri)
        {
            var client = new RestClient(uri);

            var request = new RestRequest();

            var response = await client.GetAsync<PokemonResponse>(request);

            return response;
        }

        public async Task<PokemonDetails> GetPokerDetails(string uri)
        {
            var client = new RestClient(uri);

            var request = new RestRequest();

            var response = await client.GetAsync<PokemonDetails>(request);

            return response;
        }

        public async Task<PokemonEvolution> GetPokerEvolution(string uri)
        {
            var evolutionUrl = await GetPokerEvolutionUrl(uri);

            var client = new RestClient(evolutionUrl.EvolutionChain.Url);

            var request = new RestRequest();

            var result = await client.GetAsync<PokemonEvolution>(request);

            return result;
        }
        private async Task<PokemonChainEvolution> GetPokerEvolutionUrl(string uri)
        {
            var client = new RestClient(uri);

            var request = new RestRequest();

            var result = await client.GetAsync<PokemonChainEvolution>(request);

            return result;
        }

        public async Task<Stream> DownloadImagePoker(string uri)
        {
            var client = new RestClient(uri);

            var request = new RestRequest();

            var result = await client.DownloadStreamAsync(request);

            return result;
        }
    }
}
