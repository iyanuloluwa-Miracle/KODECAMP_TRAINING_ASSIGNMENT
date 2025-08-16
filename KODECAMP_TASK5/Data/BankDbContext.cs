using Microsoft.EntityFrameworkCore;
using KODECAMP_TASK5.Models;

namespace KODECAMP_TASK5.Data
{
    // Database context for the banking app
    public class BankDbContext : DbContext
    {
        public DbSet<Customer> Customers { get; set; }
        public DbSet<BankAccount> BankAccounts { get; set; }
        public DbSet<Transaction> Transactions { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            // Use SQLite for simplicity (change as needed)
            optionsBuilder.UseSqlite("Data Source=bank.db");
        }
    }
}
