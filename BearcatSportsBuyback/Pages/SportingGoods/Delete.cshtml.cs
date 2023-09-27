using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using BearcatSportsBuyback.Data;
using BearcatSportsBuyback.Models;

namespace BearcatSportsBuyback.Pages.SportingGoods
{
    public class DeleteModel : PageModel
    {
        private readonly BearcatSportsBuyback.Data.BearcatSportsBuybackContext _context;

        public DeleteModel(BearcatSportsBuyback.Data.BearcatSportsBuybackContext context)
        {
            _context = context;
        }

        [BindProperty]
      public SportingGood SportingGood { get; set; } = default!;

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null || _context.SportingGood == null)
            {
                return NotFound();
            }

            var sportinggood = await _context.SportingGood.FirstOrDefaultAsync(m => m.Id == id);

            if (sportinggood == null)
            {
                return NotFound();
            }
            else 
            {
                SportingGood = sportinggood;
            }
            return Page();
        }

        public async Task<IActionResult> OnPostAsync(int? id)
        {
            if (id == null || _context.SportingGood == null)
            {
                return NotFound();
            }
            var sportinggood = await _context.SportingGood.FindAsync(id);

            if (sportinggood != null)
            {
                SportingGood = sportinggood;
                _context.SportingGood.Remove(SportingGood);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
