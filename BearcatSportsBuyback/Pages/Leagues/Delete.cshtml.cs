using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using BearcatSportsBuyback.Data;
using BearcatSportsBuyback.Models;

namespace BearcatSportsBuyback.Pages.Leagues
{
    public class DeleteModel : PageModel
    {
        private readonly BearcatSportsBuyback.Data.BearcatSportsBuybackContext _context;

        public DeleteModel(BearcatSportsBuyback.Data.BearcatSportsBuybackContext context)
        {
            _context = context;
        }

        [BindProperty]
      public League League { get; set; } = default!;

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null || _context.League == null)
            {
                return NotFound();
            }

            var league = await _context.League.FirstOrDefaultAsync(m => m.Id == id);

            if (league == null)
            {
                return NotFound();
            }
            else 
            {
                League = league;
            }
            return Page();
        }

        public async Task<IActionResult> OnPostAsync(int? id)
        {
            if (id == null || _context.League == null)
            {
                return NotFound();
            }
            var league = await _context.League.FindAsync(id);

            if (league != null)
            {
                League = league;
                _context.League.Remove(League);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
