using System.Text.Json.Serialization;
using System;

namespace Poke.Domain.Dto.Response.Details
{
    public class PokemonSprites
    {
        [JsonPropertyName("front_default")]
        public string FrontDefault { get; set; }

        [JsonPropertyName("front_default_base64")]
        public string FrontDefaultBase64 { get; set; }

    }
}
