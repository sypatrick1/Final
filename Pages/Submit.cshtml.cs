using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Final.Models;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace Final.Pages;

public class PokemonModel : PageModel
{
    private readonly PokemonContext _context;
    private readonly ILogger<PokemonContext> _logger;
    public List<Pokemon> Pokemon {get; set;} = default!;
    public SelectList PokemonDropDown {get; set;} = default!;

    // Extra Credit Step 1: We need a professor property
    // User will select which professor they want, so this must use BindProperty
    [BindProperty]
    public Pokemon Pokemon {get; set;} = default!;

    public PokemonModel(PokemonContext context, ILogger<PokemonModel> logger)
    {
        _context = context; // Read in DbContext here
        _logger = logger;
    }

    public void OnGet()
    {
        Pokemon = _context.Pokemon.ToList();
        PokemonDropDown = new SelectList(Pokemons, "PokemonSeries");
    }

    public void OnPost()
    {
    
        Pokemon = _context.Pokemon.Find(Pokemon.PokemonId)!;
        Pokemons = _context.Pokemon.ToList();
        PokemonDropDown = new SelectList(Pokemons, "Pokemon Series");
    }
}