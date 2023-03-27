using System.Text.Json.Serialization;

namespace Poke.Domain.Dto.Response.Master
{
    public class PokemonMasterResponse
    {
        [JsonPropertyName("id")]
        public Guid Id { get; set; }

        [JsonPropertyName("name")]
        public string Name { get; set; }

        [JsonPropertyName("age")]
        public int Age { get; set; }

        [JsonPropertyName("cpf")]
        public string Cpf { get; set; }

        [JsonPropertyName("pokemons")]
        public List<PokemonCaughtResponse> PokemonsCaught { get; set; }
    }
}
