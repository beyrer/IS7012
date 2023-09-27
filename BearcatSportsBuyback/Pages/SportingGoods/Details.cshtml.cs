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
    public class DetailsModel : PageModel
    {
        private readonly BearcatSportsBuyback.Data.BearcatSportsBuybackContext _context;

        public DetailsModel(BearcatSportsBuyback.Data.BearcatSportsBuybackContext context)
        {
            _context = context;
        }

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
    }
}
