using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using MRGGameTek.Storage.Entities;

namespace MRGGameTek.Storage
{
    public class ApplicationDbContext: IdentityDbContext
    {
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }
        public DbSet<MrGreenCustomer> MrGreenCustomers { get; set; }
        public DbSet<RedbetCustomer> RedbetCustomers { get; set; }
    }
}
