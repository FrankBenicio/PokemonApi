using Poke.Domain.Dto.Response.Master;

namespace Poke.Domain.Interfaces.UseCases
{
    public interface IGetPokemonMaster
    {
        Task<PokemonMasterResponse> Get(Guid id);
    }
}
