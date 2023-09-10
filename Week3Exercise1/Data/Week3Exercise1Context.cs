using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Week3Exercise1.Models;

namespace Week3Exercise1.Data
{
    public class Week3Exercise1Context : DbContext
    {
        public Week3Exercise1Context (DbContextOptions<Week3Exercise1Context> options)
            : base(options)
        {
        }

        public DbSet<Week3Exercise1.Models.AccountHolder> AccountHolder { get; set; } = default!;
    }
}
