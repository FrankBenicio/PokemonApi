using AutoFixture;
using Castle.Core.Resource;
using Microsoft.EntityFrameworkCore;
using Poke.Data.Tests.Context;
using Poke.Data.UseCases;
using Poke.Domain.Dto.Request;
using Poke.Domain.Models;

namespace Poke.Data.Tests.UseCases
{
    public class PostPokemonCaughtUseCaseTests
    {
        [Fact]
        public async Task ShouldCreatePokemonCaught()
        {
            var mockDatabase = await ContextFake.Gerar();
            var fixture = new Fixture();
            var pokemonMasterFixture = fixture.Create<PokemonCaughtRequest>();

            var useCase = new PostPokemonCaughtUseCase(mockDatabase);

            await useCase.Execute(pokemonMasterFixture);

            var master = await mockDatabase.PokemonCaught.FirstAsync();

            Assert.NotNull(master);
        }

    }
}
