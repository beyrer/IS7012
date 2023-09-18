using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using BankAccounts.Data;
using BankAccounts.Models;

namespace BankAccounts.Pages.AccountHolders
{
    public class CreateModel : PageModel
    {
        private readonly BankAccounts.Data.BankAccountsContext _context;

        public CreateModel(BankAccounts.Data.BankAccountsContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
            return Page();
        }

        [BindProperty]
        public AccountHolder AccountHolder { get; set; } = default!;
        

        // To protect from overposting attacks, see https://aka.ms/RazorPagesCRUD
        public async Task<IActionResult> OnPostAsync()
        {
          if (!ModelState.IsValid || _context.AccountHolder == null || AccountHolder == null)
            {
                return Page();
            }

            _context.AccountHolder.Add(AccountHolder);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
