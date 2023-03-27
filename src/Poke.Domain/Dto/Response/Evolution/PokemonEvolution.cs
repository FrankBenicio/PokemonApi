using System.Text.Json.Serialization;

namespace Poke.Domain.Dto.Response.Evolution
{
    public class PokemonEvolution
    {
        [JsonPropertyName("chain")]
        public PokemonChain Chain { get; set; }
    }
}
