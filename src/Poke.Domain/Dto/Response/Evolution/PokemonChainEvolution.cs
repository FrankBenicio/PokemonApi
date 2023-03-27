using System.Text.Json.Serialization;

namespace Poke.Domain.Dto.Response.Evolution
{
    public class PokemonChainEvolution
    {
        [JsonPropertyName("evolution_chain")]
        public PokemonEvolutionUrl EvolutionChain { get; set; }
    }
}
