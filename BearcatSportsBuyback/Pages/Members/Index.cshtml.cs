﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using BearcatSportsBuyback.Data;
using BearcatSportsBuyback.Models;

namespace BearcatSportsBuyback.Pages.Members
{
    public class IndexModel : PageModel
    {
        private readonly BearcatSportsBuyback.Data.BearcatSportsBuybackContext _context;

        public IndexModel(BearcatSportsBuyback.Data.BearcatSportsBuybackContext context)
        {
            _context = context;
        }

        public IList<Member> Member { get;set; } = default!;

        public async Task OnGetAsync()
        {
            if (_context.Member != null)
            {
                Member = await _context.Member
                .Include(m => m.LeagueName)
                .Include(m => m.Sport).ToListAsync();
            }
        }
    }
}
