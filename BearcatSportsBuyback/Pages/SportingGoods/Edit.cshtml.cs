using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using BearcatSportsBuyback.Data;
using BearcatSportsBuyback.Models;

namespace BearcatSportsBuyback.Pages.SportingGoods
{
    public class EditModel : PageModel
    {
        private readonly BearcatSportsBuyback.Data.BearcatSportsBuybackContext _context;

        public EditModel(BearcatSportsBuyback.Data.BearcatSportsBuybackContext context)
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

            var sportinggood =  await _context.SportingGood.FirstOrDefaultAsync(m => m.Id == id);
            if (sportinggood == null)
            {
                return NotFound();
            }
            SportingGood = sportinggood;
           ViewData["SportId"] = new SelectList(_context.Set<Sport>(), "Id", "SportName");
            return Page();
        }

        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Attach(SportingGood).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!SportingGoodExists(SportingGood.Id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return RedirectToPage("./Index");
        }

        private bool SportingGoodExists(int id)
        {
          return (_context.SportingGood?.Any(e => e.Id == id)).GetValueOrDefault();
        }
    }
}
