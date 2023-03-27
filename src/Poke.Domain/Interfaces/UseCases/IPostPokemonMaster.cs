using Poke.Domain.Dto.Request;

namespace Poke.Domain.Interfaces.UseCases
{
    public interface IPostPokemonMaster
    {
        Task<Guid> Execute(PokemonMasterRequest request);
    }
}
