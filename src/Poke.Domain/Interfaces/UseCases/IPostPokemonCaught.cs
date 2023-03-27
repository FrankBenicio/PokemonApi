using Poke.Domain.Dto.Request;

namespace Poke.Domain.Interfaces.UseCases
{
    public interface IPostPokemonCaught
    {
        Task Execute(PokemonCaughtRequest request);
    }
}
