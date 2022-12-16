using Hashing2.Models;
using Microsoft.EntityFrameworkCore;

namespace Hashing2.DbContextWithEF
{
    public class SubscriptionContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=(localdb)\mssqllocaldb;Database=Hashing;Trusted_Connection=true");
        }
        DbSet<User> Users { get; set; }
    }
}
