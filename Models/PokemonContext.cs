using Microsoft.EntityFrameworkCore;

// Step 3: Create the Data Model
namespace Pokemon.Models
{
	public class PokemonContext : DbContext
	{
		public PokemonContext (DbContextOptions<PokemonContext> options)
			: base(options)
		{
		}
		public DbSet<Pokemon> Professor {get; set;} = default!;
	}
}