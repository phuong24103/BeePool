<<<<<<< Updated upstream
﻿using Datn_Api.Extensions;
using Datn_Shared.Models;
=======
﻿using Datn_Shared.Models;
using Microsoft.AspNetCore.Identity;
>>>>>>> Stashed changes
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace Datn_Api.Data
{
<<<<<<< Updated upstream
    public class MyDbContext : IdentityDbContext<User, Role, Guid>
=======
    public class MyDbContext : IdentityDbContext<Employee, IdentityRole<Guid>, Guid>
>>>>>>> Stashed changes
    {
        public MyDbContext(DbContextOptions options) : base(options)
        {
        }

        protected MyDbContext()
        {
        }

        public DbSet<Bill> Bills { get; set; }
        public DbSet<BillDetail> BillDetails { get; set; }
        public DbSet<BillStatus> BillStatuses { get; set; }
        public DbSet<Cart> Carts { get; set; }
        public DbSet<CartDetail> CartDetails { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<CategoryDetail> CategoriesDetail { get; set; }
        public DbSet<Gripe> Gripes { get; set; }
        public DbSet<Handle> Handles { get; set; }
        public DbSet<Material> Materials { get; set; }
        public DbSet<Payment> Payments { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<Rank> Ranks { get; set; }
        public DbSet<Ren> Rens { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet <Role> Roles { get; set; }
        public DbSet <UserRole> UserRoles { get; set; }
        public DbSet<Tip> Tips { get; set; }
        public DbSet<Voucher> Vouchers { get; set; }
        public DbSet<UsedVoucher> UsedVouchers { get; set; }
        public DbSet<WishList> WishLists { get; set; }
<<<<<<< Updated upstream
        public DbSet<Post> Posts { get; set; }
=======
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Shaft> Shafts { get; set; }
        public DbSet<ProductDetail> ProductDetails { get; set; }
        public DbSet<Weight> Weights { get; set; }
        public DbSet<ProductImage> ProductImages { get; set; }
>>>>>>> Stashed changes

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=HUYAN;Database=BeePool;User Id=huyddph28122;Password=anhhung0122;");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Bill>()
            .HasOne(a => a.UsedVoucher)
            .WithOne(c => c.Bill)
            .HasForeignKey<UsedVoucher>(c => c.BillId);
            modelBuilder.Entity<User>()
            .HasOne(a => a.Cart)
            .WithOne(c => c.User)
            .HasForeignKey<Cart>(c => c.UserId);
            base.OnModelCreating(modelBuilder);
<<<<<<< Updated upstream
            modelBuilder.Seed();
=======
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
            //modelBuilder.Seed();
>>>>>>> Stashed changes
        }
    }
}