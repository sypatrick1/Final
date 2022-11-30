using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using CharacterSeries.Models;

namespace CharacterSeries.Pages.Character
{
    public class IndexModel : PageModel
    {
        private readonly CharacterSeries.Models.Context _context;

        public IndexModel(CharacterSeries.Models.Context context)
        {
            _context = context;
        }

        public IList<Character> Character { get;set; } = default!;

        public async Task OnGetAsync()
        {
            if (_context.Character != null)
            {
                Character = await _context.Character.Include(s => s.PokemonID!).ThenInclude(sc => sc.CharacterID).ToListAsync();
            }
        }
    }
}