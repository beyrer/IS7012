using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using RecruitCatBeyrerJL.Data;
using RecruitCatBeyrerJL.Models;

namespace RecruitCatBeyrerJL.Pages.Directors
{
    public class IndexModel : PageModel
    {
        private readonly RecruitCatBeyrerJL.Data.RecruitCatBeyrerJLContext _context;

        public IndexModel(RecruitCatBeyrerJL.Data.RecruitCatBeyrerJLContext context)
        {
            _context = context;
        }

        public IList<Director> Director { get;set; } = default!;

        public async Task OnGetAsync()
        {
            if (_context.Director != null)
            {
                Director = await _context.Director.ToListAsync();
            }
        }
    }
}
