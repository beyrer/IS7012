using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using MoviesWeek5.Models;

namespace MoviesWeek5.Data
{
    public class MoviesWeek5Context : DbContext
    {
        public MoviesWeek5Context (DbContextOptions<MoviesWeek5Context> options)
            : base(options)
        {
        }

        public DbSet<MoviesWeek5.Models.Movie> Movie { get; set; } = default!;
    }
}
