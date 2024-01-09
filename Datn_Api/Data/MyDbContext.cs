using Datn_Api.Extensions;
using Datn_Shared.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace Datn_Api.Data
{
    public class MyDbContext : IdentityDbContext<Employee, IdentityRole<Guid>, Guid>
    {
        public MyDbContext(DbContextOptions options) : base(options)
        {
        }

        protected MyDbContext()
        {
        }

        public DbSet<Brand> Brands { get; set; }
        public DbSet<Bill> Bills { get; set; }
        public DbSet<BillDetail> BillDetails { get; set; }
        public DbSet<BillStatus> BillStatuses { get; set; }
        public DbSet<Cart> Carts { get; set; }
        public DbSet<CartDetail> CartDetails { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Payment> Payments { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<Rank> Ranks { get; set; }
        public DbSet<Employee> Employees { get; set; }
        public DbSet<Tip> Tips { get; set; }
        public DbSet<Voucher> Vouchers { get; set; }
        public DbSet<UsedVoucher> UsedVouchers { get; set; }
        public DbSet<WishList> WishLists { get; set; }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Shaft> Shafts { get; set; }
        public DbSet<ProductDetail> ProductDetails { get; set; }
        public DbSet<Weight> Weights { get; set; }
        public DbSet<ProductImage> ProductImages { get; set; }
        public DbSet<Post> Posts { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source=.;Initial Catalog=BeePool;Integrated Security=True;TrustServerCertificate=True;");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<CartDetail>()
            .HasOne(a => a.Cart)
            .WithMany(c => c.CartDetails)
            .HasForeignKey(c => c.CustomerId);
            modelBuilder.Entity<Bill>()
            .HasOne(a => a.UsedVoucher)
            .WithOne(c => c.Bill)
            .HasForeignKey<UsedVoucher>(c => c.BillId);
            modelBuilder.Entity<Customer>()
            .HasOne(a => a.Cart)
            .WithOne(c => c.Customer)
            .HasForeignKey<Cart>(c => c.CustomerId);
            base.OnModelCreating(modelBuilder);

            modelBuilder.Seed();

            foreach (var entityType in modelBuilder.Model.GetEntityTypes())
            {
                var tableName = entityType.GetTableName();
                if (tableName.StartsWith("AspNet"))
                {
                    entityType.SetTableName(tableName.Substring(6));
                }
                if (tableName.StartsWith("AspNetUser"))
                {
                    entityType.SetTableName(String.Concat("Employee", tableName.Substring(10)));
                }
            }
        }
    }
}