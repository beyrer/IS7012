using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using MoviesExercise5._1.Data;
using MoviesExercise5._1.Models;

namespace MoviesExercise5._1.Pages.Movies
{
    public class IndexModel : PageModel
    {
        private readonly MoviesExercise5._1.Data.ApplicationDbContext _context;

        public IndexModel(MoviesExercise5._1.Data.ApplicationDbContext context)
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
