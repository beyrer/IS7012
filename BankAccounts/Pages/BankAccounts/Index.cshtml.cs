using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using BankAccounts.Data;
using BankAccounts.Models;

namespace BankAccounts.Pages.BankAccounts
{
    public class IndexModel : PageModel
    {
        private readonly BankAccounts.Data.BankAccountsContext _context;

        public IndexModel(BankAccounts.Data.BankAccountsContext context)
        {
            _context = context;
        }

        public IList<BankAccount> BankAccount { get;set; } = default!;

        public async Task OnGetAsync()
        {
            if (_context.BankAccount != null)
            {
                BankAccount = await _context.BankAccount
                .Include(b => b.AccountHolder).ToListAsync();
            }
        }
    }
}
