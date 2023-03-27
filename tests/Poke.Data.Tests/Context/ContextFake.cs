using Poke.Infra.Context;
using Microsoft.EntityFrameworkCore;

namespace Poke.Data.Tests.Context
{
    public static class ContextFake
    {
        public static async Task<PokeContext> Gerar()
        {
            var options = new DbContextOptionsBuilder<PokeContext>()
                .UseInMemoryDatabase(databaseName: Guid.NewGuid().ToString())
                .Options;

            var context = new PokeContext(options);

            return await Task.FromResult(context);
        }
    }
}
