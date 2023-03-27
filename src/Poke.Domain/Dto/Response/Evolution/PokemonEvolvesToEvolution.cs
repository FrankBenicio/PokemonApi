using System.Text.Json.Serialization;

namespace Poke.Domain.Dto.Response.Evolution
{
    public class PokemonEvolvesToEvolution
    {
        [JsonPropertyName("evolves_to")]
        public List<PokemonEvolvesToEvolution> EvolvesTo { get; set; }

        [JsonPropertyName("is_baby")]
        public bool IsBaby { get; set; }

        [JsonPropertyName("species")]
        public PokemonSpeciesEvolution Species { get; set; }
    }
}
