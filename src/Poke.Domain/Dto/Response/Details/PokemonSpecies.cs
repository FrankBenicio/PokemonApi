using System.Text.Json.Serialization;

namespace Poke.Domain.Dto.Response.Details
{
    public class PokemonSpecies
    {
        [JsonPropertyName("name")]
        public string Name { get; set; }

        [JsonPropertyName("url")]
        public string Url { get; set; }
    }
}
