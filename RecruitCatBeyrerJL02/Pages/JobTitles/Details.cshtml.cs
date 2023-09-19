using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using RecruitCatBeyrerJL02.Data;
using RecruitCatBeyrerJL02.Models;

namespace RecruitCatBeyrerJL02.Pages.JobTitles
{
    public class DetailsModel : PageModel
    {
        private readonly RecruitCatBeyrerJL02.Data.RecruitCatBeyrerJL02Context _context;

        public DetailsModel(RecruitCatBeyrerJL02.Data.RecruitCatBeyrerJL02Context context)
        {
            _context = context;
        }

      public JobTitle JobTitle { get; set; } = default!; 

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null || _context.JobTitle == null)
            {
                return NotFound();
            }

            var jobtitle = await _context.JobTitle.FirstOrDefaultAsync(m => m.Id == id);
            if (jobtitle == null)
            {
                return NotFound();
            }
            else 
            {
                JobTitle = jobtitle;
            }
            return Page();
        }
    }
}
