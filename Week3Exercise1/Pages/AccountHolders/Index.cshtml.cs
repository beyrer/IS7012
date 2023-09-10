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
    public class IndexModel : PageModel
    {
        private readonly Week3Exercise1.Data.Week3Exercise1Context _context;

        public IndexModel(Week3Exercise1.Data.Week3Exercise1Context context)
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
