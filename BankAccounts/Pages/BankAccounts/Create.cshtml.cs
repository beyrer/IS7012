using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using BankAccounts.Data;
using BankAccounts.Models;

namespace BankAccounts.Pages.BankAccounts
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
        ViewData["AccountHolderId"] = new SelectList(_context.AccountHolder, "Id", "Id");
            return Page();
        }

        [BindProperty]
        public BankAccount BankAccount { get; set; } = default!;
        

        // To protect from overposting attacks, see https://aka.ms/RazorPagesCRUD
        public async Task<IActionResult> OnPostAsync()
        {
          if (!ModelState.IsValid || _context.BankAccount == null || BankAccount == null)
            {
                return Page();
            }

            _context.BankAccount.Add(BankAccount);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
