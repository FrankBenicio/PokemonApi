using AutoFixture;
using Moq;
using Poke.Data.Tests.Context;
using Poke.Data.UseCases;
using Poke.Domain.Dto.Response;
using Poke.Domain.Dto.Response.Details;
using Poke.Domain.Dto.Response.Evolution;
using Poke.Domain.Interfaces.Services;
using Poke.Domain.Interfaces.UseCases;
using Poke.Domain.Models;

namespace Poke.Data.Tests.UseCases
{
    public class GetPokemonUseCaseTests
    {
        [Fact]
        public async Task ShouldReturnGetPokemon()
        {
            var mockGetPokemon = new Mock<IPokeService>();

            var fixture = new Fixture();
            var pokemons = new PokemonDetails()
            {
                Abilities = fixture.CreateMany<PokemonAbilities>().ToList(),
                Id = 1,
                Name = "name",
                Species = fixture.Create<PokemonSpecies>(),
                Sprites = fixture.Create<PokemonSprites>(),
            };
            var pokemonsEvolution = new PokemonEvolution
            {
                Chain = new PokemonChain
                {
                    Species = new PokemonSpeciesEvolution
                    {
                        Name = "name",
                    },
                    EvolvesTo = new List<PokemonEvolvesToEvolution>
                    { 
                        new PokemonEvolvesToEvolution
                        {
                            IsBaby= true,
                            Species = new PokemonSpeciesEvolution
                                {
                                    Name = "name",
                                }
                        }
                    }
                }
            };


            fixture.Register<byte[], Stream>((byte[] data) => new MemoryStream(data));
            var stream = fixture.Create<Stream>();

            mockGetPokemon.Setup(x => x.DownloadImagePoker(It.IsAny<string>())).ReturnsAsync(stream);

            mockGetPokemon.Setup(x => x.GetPokerDetails(It.IsAny<string>())).ReturnsAsync(pokemons);
            mockGetPokemon.Setup(x => x.GetPokerEvolution(It.IsAny<string>())).ReturnsAsync(pokemonsEvolution);

            var useCase = new GetPokemonUseCase(mockGetPokemon.Object);

            var result = await useCase.Get("url");

            Assert.NotNull(result);
        }

    }
}
