using Poke.Domain.Dto.Response;
using Poke.Domain.Dto.Response.Details;
using Poke.Domain.Dto.Response.Evolution;

namespace Poke.Domain.Interfaces.Services
{
    public interface IPokeService
    {
        Task<PokemonResponse> GetPokers(string uri);
        Task<PokemonDetails> GetPokerDetails(string uri);
        Task<PokemonEvolution> GetPokerEvolution(string uri);
        Task<Stream> DownloadImagePoker(string uri);
    }
}
