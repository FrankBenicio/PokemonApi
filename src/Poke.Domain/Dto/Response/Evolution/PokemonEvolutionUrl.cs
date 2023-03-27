using System.Text.Json.Serialization;

namespace Poke.Domain.Dto.Response.Evolution
{
    public class PokemonEvolutionUrl
    {
        [JsonPropertyName("url")]
        public string Url { get; set; }
    }
}
