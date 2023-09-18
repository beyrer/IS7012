using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using BankAccounts.Models;

namespace BankAccounts.Data
{
    public class BankAccountsContext : DbContext
    {
        public BankAccountsContext (DbContextOptions<BankAccountsContext> options)
            : base(options)
        {
        }

        public DbSet<BankAccounts.Models.AccountHolder> AccountHolder { get; set; } = default!;

        public DbSet<BankAccounts.Models.BankAccount>? BankAccount { get; set; }
    }
}
