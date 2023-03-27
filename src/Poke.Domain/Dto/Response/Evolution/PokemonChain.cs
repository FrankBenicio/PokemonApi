using System.Text.Json.Serialization;

namespace Poke.Domain.Dto.Response.Evolution
{
    public class PokemonChain
    {
        [JsonPropertyName("evolves_to")]
        public List<PokemonEvolvesToEvolution> EvolvesTo { get; set; }

        [JsonPropertyName("species")]
        public PokemonSpeciesEvolution Species { get; set; }
    }
}
