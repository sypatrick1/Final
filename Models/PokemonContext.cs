using Microsoft.EntityFrameworkCore;

// Step 3: Create the Data Model
namespace Final.Models
{
	public class PokemonContext : DbContext
	{
		public PokemonContext (DbContextOptions<PokemonContext> options)
			: base(options)
		{ protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<CharacterSeries>().HasKey(s => new {s.PokemonID, s.CharacterID});
        }
		}
		public DbSet<Pokemon> Pokemon {get; set;} = default!;
	}
}