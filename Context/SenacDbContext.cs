using Microsoft.EntityFrameworkCore;
using senac_api.Dtos;

namespace senac_api.Context
{
    public class SenacDbContext : DbContext
    {
        public SenacDbContext(DbContextOptions<SenacDbContext> options)
       : base(options)
        {
            
        }
        public DbSet<Product> Products { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Product>().ToTable("Products");
            modelBuilder.Entity<Product>().Property(x => x.Id);
            modelBuilder.Entity<Product>().Property(x => x.Sku);
            modelBuilder.Entity<Product>().Property(x => x.Name);
            modelBuilder.Entity<Product>().Property(x => x.Description);
            modelBuilder.Entity<Product>().Property(x => x.Price);
            modelBuilder.Entity<Product>().Property(x => x.Quantity);
            modelBuilder.Entity<Product>().Property(x => x.Url);
            modelBuilder.Entity<Product>().HasKey(x => x.Id);

        }

    }
}
