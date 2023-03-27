
namespace Poke.Domain.Models
{
    public class PokemonMaster
    {
        public Guid Id { get; set; } = Guid.NewGuid();
        public string Name { get; set; }
        public int Age { get; set; }
        public string Cpf { get; set; }
        public List<PokemonCaught> PokemonCaught { get; set; }

    }
}
