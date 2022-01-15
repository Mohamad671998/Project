using Microsoft.EntityFrameworkCore;

namespace Project.Models
{
    public class ShopContext : DbContext
    {
        public ShopContext(DbContextOptions<ShopContext> options)
            : base(options)
        {
        }

        public DbSet<Product> Products { get; set; }
        public DbSet<Account> Accounts{get;set;}
       

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Account>().HasData(
                new Account
                {
                    AccountID=1,
                    AccountName="Master",
                    Password="Admin",
                    Phonenumber=78943952,
                    isAdmin=1
                }
            );
        }
    }
}