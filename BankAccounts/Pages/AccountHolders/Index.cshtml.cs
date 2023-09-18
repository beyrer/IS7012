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
    public class IndexModel : PageModel
    {
        private readonly BankAccounts.Data.BankAccountsContext _context;

        public IndexModel(BankAccounts.Data.BankAccountsContext context)
        {
            _context = context;
        }

        public IList<AccountHolder> AccountHolder { get;set; } = default!;

        public async Task OnGetAsync()
        {
            if (_context.AccountHolder != null)
            {
                AccountHolder = await _context.AccountHolder.ToListAsync();
            }
        }
    }
}
