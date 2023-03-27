namespace Poke.Domain.Models
{
    public class PokemonCaught
    {
        public Guid Id { get; set; } = Guid.NewGuid();
        public string Pokemon { get; set; }
        public Guid PokemonMasterId { get; set; }
        public PokemonMaster PokemonMaster { get; set; }
    }
}
