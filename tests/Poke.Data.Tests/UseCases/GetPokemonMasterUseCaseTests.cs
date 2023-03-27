using Moq;
using Poke.Data.Tests.Context;
using Poke.Data.UseCases;
using Poke.Domain.Interfaces.UseCases;
using Poke.Domain.Models;

namespace Poke.Data.Tests.UseCases
{
    public class GetPokemonMasterUseCaseTests
    {
        [Fact]
        public async Task ShouldReturnPokemonMaster()
        {
            var mockDatabase = await ContextFake.Gerar();
            var mockGetPokemon = new Mock<IGetPokemon>();

            var pokemonMasterFixture = new PokemonMaster
            {
                Id = Guid.NewGuid(),
                Age= 18,
                Cpf = "00100200304",
                Name= "Name",                
            };

            mockDatabase.PokemonMaster.Add(pokemonMasterFixture);
            await mockDatabase.SaveChangesAsync();

            var useCase = new GetPokemonMasterUseCase(mockDatabase, mockGetPokemon.Object);

            var result = await useCase.Get(pokemonMasterFixture.Id);

            Assert.NotNull(result);
        }

    }
}
