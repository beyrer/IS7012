using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using RecruitCatBeyrerJL.Models;

namespace RecruitCatBeyrerJL.Data
{
    public class RecruitCatBeyrerJLContext : DbContext
    {
        public RecruitCatBeyrerJLContext (DbContextOptions<RecruitCatBeyrerJLContext> options)
            : base(options)
        {
        }

        public DbSet<RecruitCatBeyrerJL.Models.Director> Director { get; set; } = default!;
    }
}
