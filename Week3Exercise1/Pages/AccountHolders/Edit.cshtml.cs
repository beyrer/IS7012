﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Week3Exercise1.Data;
using Week3Exercise1.Models;

namespace Week3Exercise1.Pages.AccountHolders
{
    public class EditModel : PageModel
    {
        private readonly Week3Exercise1.Data.Week3Exercise1Context _context;

        public EditModel(Week3Exercise1.Data.Week3Exercise1Context context)
        {
            _context = context;
        }

        [BindProperty]
        public AccountHolder AccountHolder { get; set; } = default!;

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null || _context.AccountHolder == null)
            {
                return NotFound();
            }

            var accountholder =  await _context.AccountHolder.FirstOrDefaultAsync(m => m.Id == id);
            if (accountholder == null)
            {
                return NotFound();
            }
            AccountHolder = accountholder;
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

            _context.Attach(AccountHolder).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!AccountHolderExists(AccountHolder.Id))
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

        private bool AccountHolderExists(int id)
        {
          return (_context.AccountHolder?.Any(e => e.Id == id)).GetValueOrDefault();
        }
    }
}
