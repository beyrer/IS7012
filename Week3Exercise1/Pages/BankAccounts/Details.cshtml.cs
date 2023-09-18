using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Week3Exercise1.Data;
using Week3Exercise1.Models;

namespace Week3Exercise1.Pages.BankAccounts
{
    public class DetailsModel : PageModel
    {
        private readonly Week3Exercise1.Data.Week3Exercise1Context _context;

        public DetailsModel(Week3Exercise1.Data.Week3Exercise1Context context)
        {
            _context = context;
        }

      public BankAccount BankAccount { get; set; } = default!; 

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null || _context.BankAccount == null)
            {
                return NotFound();
            }

            var bankaccount = await _context.BankAccount.FirstOrDefaultAsync(m => m.Id == id);
            if (bankaccount == null)
            {
                return NotFound();
            }
            else 
            {
                BankAccount = bankaccount;
            }
            return Page();
        }
    }
}
