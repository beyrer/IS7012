using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using RecruitCatBeyrerJL.Data;
using RecruitCatBeyrerJL.Models;

namespace RecruitCatBeyrerJL.Pages.Directors
{
    public class CreateModel : PageModel
    {
        private readonly RecruitCatBeyrerJL.Data.RecruitCatBeyrerJLContext _context;

        public CreateModel(RecruitCatBeyrerJL.Data.RecruitCatBeyrerJLContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
            return Page();
        }

        [BindProperty]
        public Director Director { get; set; } = default!;
        

        // To protect from overposting attacks, see https://aka.ms/RazorPagesCRUD
        public async Task<IActionResult> OnPostAsync()
        {
          if (!ModelState.IsValid || _context.Director == null || Director == null)
            {
                return Page();
            }

            _context.Director.Add(Director);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
