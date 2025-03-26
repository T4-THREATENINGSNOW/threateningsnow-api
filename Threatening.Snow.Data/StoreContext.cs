using Microsoft.EntityFrameworkCore;
using Threatening.Snow.Domain.Catalog;

namespace Threatening.Snow.Data
{
    public class StoreContext : DbContext
    {
        public StoreContext(DbContextOptions<StoreContext> options) : base(options)
        {
        }

        public DbSet<Item> Items { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            DbInitializer.Initialize(modelBuilder);
        }
    }
}
