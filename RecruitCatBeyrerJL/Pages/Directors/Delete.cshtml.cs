﻿using System;
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
    public class DeleteModel : PageModel
    {
        private readonly RecruitCatBeyrerJL.Data.RecruitCatBeyrerJLContext _context;

        public DeleteModel(RecruitCatBeyrerJL.Data.RecruitCatBeyrerJLContext context)
        {
            _context = context;
        }

        [BindProperty]
      public Director Director { get; set; } = default!;

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null || _context.Director == null)
            {
                return NotFound();
            }

            var director = await _context.Director.FirstOrDefaultAsync(m => m.Id == id);

            if (director == null)
            {
                return NotFound();
            }
            else 
            {
                Director = director;
            }
            return Page();
        }

        public async Task<IActionResult> OnPostAsync(int? id)
        {
            if (id == null || _context.Director == null)
            {
                return NotFound();
            }
            var director = await _context.Director.FindAsync(id);

            if (director != null)
            {
                Director = director;
                _context.Director.Remove(Director);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
