using Poke.Domain.Dto.Response.Evolution;
using System.Text.Json.Serialization;

namespace Poke.Domain.Dto.Response.Details
{
    public class PokemonDetails
    {
        [JsonPropertyName("abilities")]
        public List<PokemonAbilities> Abilities { get; set; }

        [JsonPropertyName("id")]
        public int Id { get; set; }

        [JsonPropertyName("name")]
        public string Name { get; set; }

        [JsonPropertyName("species")]
        public PokemonSpecies Species { get; set; }

        [JsonPropertyName("sprites")]
        public PokemonSprites Sprites { get; set; }

        [JsonPropertyName("evolution")]
        public PokemonEvolution Evolution { get; set; }

    }
}
