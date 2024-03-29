using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Project_1___Bakkerij.Models;

namespace Project_1___Bakkerij.Data
{
    public class ContosoBreadContext : IdentityDbContext<UserModel>
    {
        public ContosoBreadContext(DbContextOptions<ContosoBreadContext> options)
            : base(options)
        {
        }

        public DbSet<AdminModel> Admins { get; set; } = null!;
        public DbSet<OrderManagerModel> OrderManagers { get; set; } = null!;
        public DbSet<CustomerModel> Customers { get; set; } = null!;
        public DbSet<OrderModel> Orders { get; set; } = null!;
        public DbSet<OrderItemModel> OrderItems { get; set; } = null!;
        public DbSet<ProductModel> Products { get; set; } = null!;

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder); // This is needed to correctly set up the Identity model

            modelBuilder.Entity<UserModel>().ToTable("Users"); // This line changes the table name to 'Users'

            modelBuilder.Entity<OrderModel>()
                .HasOne(o => o.Customer)
                .WithMany(c => c.Order)
                .HasForeignKey(o => o.CustomerId);
        }
    }
}