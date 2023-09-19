using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using RecruitCatBeyrerJL02.Data;
using RecruitCatBeyrerJL02.Models;

namespace RecruitCatBeyrerJL02.Pages.Candidates
{
    public class DetailsModel : PageModel
    {
        private readonly RecruitCatBeyrerJL02.Data.RecruitCatBeyrerJL02Context _context;

        public DetailsModel(RecruitCatBeyrerJL02.Data.RecruitCatBeyrerJL02Context context)
        {
            _context = context;
        }

      public Candidate Candidate { get; set; } = default!; 

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null || _context.Candidate == null)
            {
                return NotFound();
            }

            var candidate = await _context.Candidate.FirstOrDefaultAsync(m => m.Id == id);
            if (candidate == null)
            {
                return NotFound();
            }
            else 
            {
                Candidate = candidate;
            }
            return Page();
        }
    }
}
