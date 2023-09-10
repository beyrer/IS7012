using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Week3Exercise1.Data;
using Week3Exercise1.Models;

namespace Week3Exercise1.Pages.AccountHolders
{
    public class DetailsModel : PageModel
    {
        private readonly Week3Exercise1.Data.Week3Exercise1Context _context;

        public DetailsModel(Week3Exercise1.Data.Week3Exercise1Context context)
        {
            _context = context;
        }

      public AccountHolder AccountHolder { get; set; } = default!; 

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null || _context.AccountHolder == null)
            {
                return NotFound();
            }

            var accountholder = await _context.AccountHolder.FirstOrDefaultAsync(m => m.Id == id);
            if (accountholder == null)
            {
                return NotFound();
            }
            else 
            {
                AccountHolder = accountholder;
            }
            return Page();
        }
    }
}
