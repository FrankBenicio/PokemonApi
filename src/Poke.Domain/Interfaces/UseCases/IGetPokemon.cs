using Poke.Domain.Dto.Response.Details;

namespace Poke.Domain.Interfaces.UseCases
{
    public interface IGetPokemon
    {
        Task<PokemonDetails> Get(string name);
    }
}
