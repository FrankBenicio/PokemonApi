using AutoFixture;
using Moq;
using Poke.Data.Tests.Context;
using Poke.Data.UseCases;
using Poke.Domain.Dto.Response;
using Poke.Domain.Interfaces.Services;
using Poke.Domain.Interfaces.UseCases;
using Poke.Domain.Models;

namespace Poke.Data.Tests.UseCases
{
    public class GetPokemonsUseCaseTests
    {
        [Fact]
        public async Task ShouldReturnGetPokemons()
        {
            var mockGetPokemons = new Mock<IPokeService>();

            var fixture = new Fixture();
            var pokemons = fixture.Create<PokemonResponse>();

            mockGetPokemons.Setup(x => x.GetPokers(It.IsAny<string>())).ReturnsAsync(pokemons);

            var useCase = new GetPokemonsUseCase(mockGetPokemons.Object);

            var result = await useCase.Get(10);

            Assert.NotNull(result);
        }

    }
}
