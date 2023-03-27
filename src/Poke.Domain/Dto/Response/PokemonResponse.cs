using Poke.Domain.Dto.Response.Details;
using System.Text.Json.Serialization;

namespace Poke.Domain.Dto.Response
{
    public class PokemonResponse
    {
        [JsonPropertyName("results")]
        public List<PokemonItem> Pokemons { get; set; }
    }

    public class PokemonItem
    {
        [JsonPropertyName("name")]
        public string Name { get; set; }
    }
}
