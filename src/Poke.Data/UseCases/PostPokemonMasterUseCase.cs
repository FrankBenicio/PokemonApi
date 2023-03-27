using Poke.Domain.Dto.Request;
using Poke.Domain.Models;
using Poke.Infra.Context;

namespace Poke.Data.UseCases
{
    public class PostPokemonMasterUseCase : IPostPokemonMaster
    {
        private readonly PokeContext context;

        public PostPokemonMasterUseCase(PokeContext context)
        {
            this.context = context;
        }

        public async Task<Guid> Execute(PokemonMasterRequest request)
        {
            PokemonMaster master = request;

            context.PokemonMaster.Add(master);

            await context.SaveChangesAsync();

            return master.Id;
        }
    }
}
