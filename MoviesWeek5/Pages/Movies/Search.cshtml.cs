using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using MoviesWeek5.Data;
using MoviesWeek5.Models;

namespace MoviesWeek5.Pages.Movies
{
    public class SearchModel : PageModel
    {
        private readonly MoviesWeek5.Data.MoviesWeek5Context _context;

        public SearchModel(MoviesWeek5.Data.MoviesWeek5Context context)
        {
            _context = context;
        }

        public IList<Movie> Movie { get;set; } = default!;

        public async Task OnGetAsync()
        {
            if (_context.Movie != null)
            {
                Movie = await _context.Movie.ToListAsync();
            }
        }
    }
}
