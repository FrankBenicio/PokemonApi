using Poke.Domain.Dto.Response;

namespace Poke.Domain.Interfaces.UseCases
{
    public interface IGetPokemons
    {
        Task<PokemonResponse> Get(int offset);
    }
}
