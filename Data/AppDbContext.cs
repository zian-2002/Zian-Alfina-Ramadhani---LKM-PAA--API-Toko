using Microsoft.EntityFrameworkCore;
using TugasTM1.Models;

namespace TugasTM1.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        public DbSet<Product> Products { get; set; }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Order> Orders { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Product>().ToTable("products");
            modelBuilder.Entity<Customer>().ToTable("customers");
            modelBuilder.Entity<Order>().ToTable("orders");
        }
    }
}