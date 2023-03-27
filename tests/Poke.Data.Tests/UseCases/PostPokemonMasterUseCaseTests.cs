using AutoFixture;
using Castle.Core.Resource;
using Microsoft.EntityFrameworkCore;
using Poke.Data.Tests.Context;
using Poke.Data.UseCases;
using Poke.Domain.Dto.Request;
using Poke.Domain.Models;

namespace Poke.Data.Tests.UseCases
{
    public class PostPokemonMasterUseCaseTests
    {
        [Fact]
        public async Task ShouldCreatePokemonMaster()
        {
            var mockDatabase = await ContextFake.Gerar();
            var fixture = new Fixture();
            var pokemonMasterFixture = fixture.Create<PokemonMasterRequest>();

            var useCase = new PostPokemonMasterUseCase(mockDatabase);

            var result = await useCase.Execute(pokemonMasterFixture);

            var master = await mockDatabase.PokemonMaster.FirstAsync();

            Assert.Equal(master.Id, result);
        }

    }
}
