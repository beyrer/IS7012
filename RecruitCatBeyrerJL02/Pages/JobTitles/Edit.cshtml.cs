﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using RecruitCatBeyrerJL02.Data;
using RecruitCatBeyrerJL02.Models;

namespace RecruitCatBeyrerJL02.Pages.JobTitles
{
    public class EditModel : PageModel
    {
        private readonly RecruitCatBeyrerJL02.Data.RecruitCatBeyrerJL02Context _context;

        public EditModel(RecruitCatBeyrerJL02.Data.RecruitCatBeyrerJL02Context context)
        {
            _context = context;
        }

        [BindProperty]
        public JobTitle JobTitle { get; set; } = default!;

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null || _context.JobTitle == null)
            {
                return NotFound();
            }

            var jobtitle =  await _context.JobTitle.FirstOrDefaultAsync(m => m.Id == id);
            if (jobtitle == null)
            {
                return NotFound();
            }
            JobTitle = jobtitle;
            return Page();
        }

        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Attach(JobTitle).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!JobTitleExists(JobTitle.Id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return RedirectToPage("./Index");
        }

        private bool JobTitleExists(int id)
        {
          return (_context.JobTitle?.Any(e => e.Id == id)).GetValueOrDefault();
        }
    }
}
