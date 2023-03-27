using System.Text.Json.Serialization;

namespace Poke.Domain.Dto.Response.Evolution
{
    public class PokemonSpeciesEvolution
    {
        [JsonPropertyName("name")]
        public string Name { get; set; }
    }
}
