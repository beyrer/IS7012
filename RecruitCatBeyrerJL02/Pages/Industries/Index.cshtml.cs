﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using RecruitCatBeyrerJL02.Data;
using RecruitCatBeyrerJL02.Models;

namespace RecruitCatBeyrerJL02.Pages.Industries
{
    public class IndexModel : PageModel
    {
        private readonly RecruitCatBeyrerJL02.Data.RecruitCatBeyrerJL02Context _context;

        public IndexModel(RecruitCatBeyrerJL02.Data.RecruitCatBeyrerJL02Context context)
        {
            _context = context;
        }

        public IList<Industry> Industry { get;set; } = default!;

        public async Task OnGetAsync()
        {
            if (_context.Industry != null)
            {
                Industry = await _context.Industry.ToListAsync();
            }
        }
    }
}
