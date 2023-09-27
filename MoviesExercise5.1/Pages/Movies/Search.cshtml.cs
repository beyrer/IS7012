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
    public class SearchModel : PageModel
    {
        private readonly MoviesExercise5._1.Data.ApplicationDbContext _context;

        public SearchModel(MoviesExercise5._1.Data.ApplicationDbContext context)
        {
            _context = context;
        }

        public IList<Movie> Movie { get;set; } = default!;
        public bool SearchCompleted { get; set; }   
        public string Query { get; set; }   
        public async Task OnGetAsync(string query)
        {
            Query = query;
            if (string.IsNullOrWhiteSpace(query))
            {
                SearchCompleted = true;
                Movie = await _context.Movie
                    .Where(x => x.Title.StartsWith(query))
                    .ToListAsync();
            }
            else
            {
                SearchCompleted = false;
                Movie = new List<Movie>();
            }
        }
    }
}
