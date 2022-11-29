using Microsoft.EntityFrameworkCore;

namespace Pokemon.Models
{
    public static class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new PokemonContext(
                serviceProvider.GetRequiredService<
                    DbContextOptions<PokemonrContext>>()))
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
                    new PokemonSeries {
                       PokemonSeries = "Diamond and Pearl"
                    },
                    new PokemonSeries {
                        PokemonSeries = "Black and White"
                    },
                    new PokemonSeries { PokemonSeries = "Sun and Moon" }
                );

                context.SaveChanges();
            }
        }
    }
}