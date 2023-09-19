using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using RecruitCatBeyrerJL02.Models;

namespace RecruitCatBeyrerJL02.Data
{
    public class RecruitCatBeyrerJL02Context : DbContext
    {
        public RecruitCatBeyrerJL02Context (DbContextOptions<RecruitCatBeyrerJL02Context> options)
            : base(options)
        {
        }

        public DbSet<RecruitCatBeyrerJL02.Models.Candidate> Candidate { get; set; } = default!;

        public DbSet<RecruitCatBeyrerJL02.Models.Company>? Company { get; set; }

        public DbSet<RecruitCatBeyrerJL02.Models.Industry>? Industry { get; set; }

        public DbSet<RecruitCatBeyrerJL02.Models.JobTitle>? JobTitle { get; set; }
    }
}
