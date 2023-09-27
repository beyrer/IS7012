using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using BearcatSportsBuyback.Data;
using BearcatSportsBuyback.Models;

namespace BearcatSportsBuyback.Pages.Leagues
{
    public class CreateModel : PageModel
    {
        private readonly BearcatSportsBuyback.Data.BearcatSportsBuybackContext _context;

        public CreateModel(BearcatSportsBuyback.Data.BearcatSportsBuybackContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
        ViewData["SportId"] = new SelectList(_context.Set<Sport>(), "Id", "SportName");
            return Page();
        }

        [BindProperty]
        public League League { get; set; } = default!;
        

        // To protect from overposting attacks, see https://aka.ms/RazorPagesCRUD
        public async Task<IActionResult> OnPostAsync()
        {
          if (!ModelState.IsValid || _context.League == null || League == null)
            {
                return Page();
            }

            _context.League.Add(League);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
