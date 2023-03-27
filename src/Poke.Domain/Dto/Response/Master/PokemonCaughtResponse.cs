using Poke.Domain.Dto.Response.Details;
using System.Text.Json.Serialization;

namespace Poke.Domain.Dto.Response.Master
{
    public class PokemonCaughtResponse
    {
        [JsonPropertyName("pokemon")]
        public PokemonDetails PokemonDetails { get; set; }
    }
}
