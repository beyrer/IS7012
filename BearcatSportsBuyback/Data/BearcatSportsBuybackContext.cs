using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using BearcatSportsBuyback.Models;

namespace BearcatSportsBuyback.Data
{
    public class BearcatSportsBuybackContext : DbContext
    {
        public BearcatSportsBuybackContext (DbContextOptions<BearcatSportsBuybackContext> options)
            : base(options)
        {
        }

        public DbSet<BearcatSportsBuyback.Models.League> League { get; set; } = default!;

        public DbSet<BearcatSportsBuyback.Models.Member>? Member { get; set; }

        public DbSet<BearcatSportsBuyback.Models.SportingGood>? SportingGood { get; set; }

        public DbSet<BearcatSportsBuyback.Models.Sport>? Sport { get; set; }
    }
}
