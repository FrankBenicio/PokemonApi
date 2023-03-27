
using Microsoft.EntityFrameworkCore;
using Poke.Domain.Models;

namespace Poke.Infra.Context
{
    public class PokeContext : DbContext
    {
        public PokeContext(DbContextOptions options) : base(options)
        {
            //
        }

        public DbSet<PokemonCaught> PokemonCaught { get; set; }
        public DbSet<PokemonMaster> PokemonMaster { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            foreach (var relationship in modelBuilder.Model.GetEntityTypes().SelectMany(e => e.GetForeignKeys()))
                relationship.DeleteBehavior = DeleteBehavior.Restrict;

            foreach (var property in modelBuilder.Model.GetEntityTypes().SelectMany(t => t.GetProperties()).Where(p => p.ClrType == typeof(string)))
            {
                property.SetColumnType("varchar(1000)");
            }

            base.OnModelCreating(modelBuilder);
        }
    }
}
