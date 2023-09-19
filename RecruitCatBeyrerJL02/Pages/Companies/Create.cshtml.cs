using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using RecruitCatBeyrerJL02.Data;
using RecruitCatBeyrerJL02.Models;

namespace RecruitCatBeyrerJL02.Pages.Companies
{
    public class CreateModel : PageModel
    {
        private readonly RecruitCatBeyrerJL02.Data.RecruitCatBeyrerJL02Context _context;

        public CreateModel(RecruitCatBeyrerJL02.Data.RecruitCatBeyrerJL02Context context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
        ViewData["IndustryId"] = new SelectList(_context.Set<Industry>(), "Id", "Id");
            return Page();
        }

        [BindProperty]
        public Company Company { get; set; } = default!;
        

        // To protect from overposting attacks, see https://aka.ms/RazorPagesCRUD
        public async Task<IActionResult> OnPostAsync()
        {
          if (!ModelState.IsValid || _context.Company == null || Company == null)
            {
                return Page();
            }

            _context.Company.Add(Company);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
