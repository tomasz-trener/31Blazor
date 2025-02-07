using Microsoft.EntityFrameworkCore;
using Shop.DataSeeder;
using Shop.Shared.Auth;
using Shop.Shared.Entity;

namespace Shop.API.Models
{
    //dotnet add package Microsoft.EntityFrameworkCore
    //Microsoft.EntityFrameworkCore.Design
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {

        }

        public DbSet<Product> Products { get; set; }

        public DbSet<User> Users { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Product>()
             .Property(p => p.Barcode)
             .IsRequired()
             .HasMaxLength(12);


            modelBuilder.Entity<Product>()
                .HasData(ProductDataSeeder.GenerateProductData());
        }
    }
}
