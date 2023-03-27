using Poke.Domain.Models;
using System.ComponentModel.DataAnnotations;

namespace Poke.Domain.Dto.Request
{
    public class PokemonCaughtRequest
    {
        [Required]
        public string Pokemon { get; set; }
        [Required]
        public Guid PokemonMasterId { get; set; }

        public static implicit operator PokemonCaught(PokemonCaughtRequest request)
        {
            return new PokemonCaught
            {
                Pokemon = request.Pokemon,
                PokemonMasterId = request.PokemonMasterId,
            };
        }
    }
}
