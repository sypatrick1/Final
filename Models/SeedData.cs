using Microsoft.EntityFrameworkCore;

namespace Final.Models
{
    public static class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new PokemonContext(
                serviceProvider.GetRequiredService<
                    DbContextOptions<PokemonContext>>()))
            {
                if (context == null || context.Pokemon == null)
                {
                    throw new ArgumentNullException("Null RazorPagesMovieContext");
                }

                //series.
                if (context.Pokemon.Any())
                {
                    return;   // DB has been seeded
                }

                context.Pokemon.AddRange(
                    new Pokemon {
                       PokemonSeries = "Diamond and Pearl"
                    },
                    new Pokemon {
                        PokemonSeries = "Black and White"
                    },
                    new Pokemon { PokemonSeries = "Sun and Moon" }
                );

                context.SaveChanges();
            }
        }
    }
}