using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Week3Exercise1.Data;
using Week3Exercise1.Models;

namespace Week3Exercise1.Pages.BankAccounts
{
    public class CreateModel : PageModel
    {
        private readonly Week3Exercise1.Data.Week3Exercise1Context _context;

        public CreateModel(Week3Exercise1.Data.Week3Exercise1Context context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
        ViewData["AccountHolderId"] = new SelectList(_context.AccountHolder, "Id", "FullName");
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
