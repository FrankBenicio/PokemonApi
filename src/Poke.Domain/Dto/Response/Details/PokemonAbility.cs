using System.Text.Json.Serialization;

namespace Poke.Domain.Dto.Response.Details
{
    public class PokemonAbilities
    {
        [JsonPropertyName("ability")]
        public PokemonAbility Ability { get; set; }
    }

    public class PokemonAbility
    {
        [JsonPropertyName("name")]
        public string Name { get; set; }
    }
}
