using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using BankAccounts.Data;
using BankAccounts.Models;

namespace BankAccounts.Pages.AccountHolders
{
    public class DeleteModel : PageModel
    {
        private readonly BankAccounts.Data.BankAccountsContext _context;

        public DeleteModel(BankAccounts.Data.BankAccountsContext context)
        {
            _context = context;
        }

        [BindProperty]
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

        public async Task<IActionResult> OnPostAsync(int? id)
        {
            if (id == null || _context.AccountHolder == null)
            {
                return NotFound();
            }
            var accountholder = await _context.AccountHolder.FindAsync(id);

            if (accountholder != null)
            {
                AccountHolder = accountholder;
                _context.AccountHolder.Remove(AccountHolder);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
