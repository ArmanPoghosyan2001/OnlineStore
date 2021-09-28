using Microsoft.EntityFrameworkCore;
using Models;

namespace OnlineStore
{
    public class MobileContext : DbContext
    {
        public DbSet<Phone> Phones { get; set; }
        public DbSet<Admin> Admins { get; set; }

        public MobileContext(DbContextOptions<MobileContext> options)
        : base(options)
        {
            Database.EnsureCreated();
        }
    }
}