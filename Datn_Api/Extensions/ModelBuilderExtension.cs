using Datn_Shared.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;

namespace Datn_Api.Extensions
{
    public static class ModelBuilderExtension
    {
        public static void Seed(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<IdentityRole<Guid>>().HasData(
                new IdentityRole<Guid>() { Name = "Quản lý", NormalizedName = "MANAGE", Id = new Guid("b108d866-eb13-46e3-b3d2-ecae4fbfe872") },
                new IdentityRole<Guid>() { Name = "Nhân viên", NormalizedName = "STAFF", Id = new Guid("b108d866-eb13-46e3-b3d2-ecae4fbfe873") }
            );

            modelBuilder.Entity<Rank>().HasData(
            new Rank()
            {
                Id = new Guid("a77f8ae9-af3d-4288-bbf3-8f77776f9232"),
                Name = "Đồng",
                NecessaryPoints = 1000,
                Status = 0,
            },
            new Rank()
            {
                Id = new Guid("a77f8ae9-af3d-4288-bbf3-8f77776f9233"),
                Name = "Bạc",
                NecessaryPoints = 2000,
                Status = 0,
            },
            new Rank()
            {
                Id = new Guid("a77f8ae9-af3d-4288-bbf3-8f77776f9234"),
                Name = "Vàng",
                NecessaryPoints = 5000,
                Status = 0,
            },
            new Rank()
            {
                Id = new Guid("a77f8ae9-af3d-4288-bbf3-8f77776f9235"),
                Name = "Bạch kim",
                NecessaryPoints = 8000,
                Status = 0,
            },
            new Rank()
            {
                Id = new Guid("a77f8ae9-af3d-4288-bbf3-8f77776f9236"),
                Name = "Kim cương",
                NecessaryPoints = 12000,
                Status = 0,
            });

            modelBuilder.Entity<Employee>().HasData(
            new Employee()
            {
                Id = new Guid("40b601c0-2c08-449f-a41e-7564648f2c87"),
                Gender = 0,
                DateOfBirth = new DateTime(2003, 8, 20),
                Address = "Hoa Thanh Quế",
                CreateDate = new DateTime(2020, 10, 23),
                Status = 0,
                UserName = "QuocPhuong",
                NormalizedUserName = "QUOCPHUONG",
                Email = "quocphuong@gmail.com",
                NormalizedEmail = "QUOCPHUONG@GMAIL.COM",
                PasswordHash = "AQAAAAEAACcQAAAAEDnw9/bad7RVII19Bn9Zetmhe4D2/RUELI0q65G6PgafUeSuvXTxEHTAC/hp5s372A==",
                SecurityStamp = "4GK7QXS2ZVKDV4BO2GGNSUH5SIGOGCMZ",
                ConcurrencyStamp = "e4bf7cff-6b1d-4814-801c-02470855c7e5",
                PhoneNumber = "06969433323",
                LockoutEnabled = true,
            },
            new Employee()
            {
                Id = new Guid("dbca0788-4fb0-4986-8928-4df593da3f5e"),
                Gender = 0,
                DateOfBirth = new DateTime(2000, 10, 26),
                Address = "Hoa Thanh Quế",
                CreateDate = new DateTime(2020, 12, 23),
                Status = 0,
                UserName = "VanPhuong",
                NormalizedUserName = "VANPHUONG",
                Email = "vanphuong@gmail.com",
                NormalizedEmail = "VANPHUONG@GMAIL.COM",
                PasswordHash = "AQAAAAEAACcQAAAAEDnw9/bad7RVII19Bn9Zetmhe4D2/RUELI0q65G6PgafUeSuvXTxEHTAC/hp5s372A==",
                SecurityStamp = "4GK7QXS2ZVKDV4BO2GGNSUH5SIGOGCMZ",
                ConcurrencyStamp = "e4bf7cff-6b1d-4814-801c-02470855c7e5",
                PhoneNumber = "0386753434",
                LockoutEnabled = true,
            });

            modelBuilder.Entity<IdentityUserRole<Guid>>().HasData(
                new IdentityUserRole<Guid>()
                {
                    UserId = new Guid("40b601c0-2c08-449f-a41e-7564648f2c87"),
                    RoleId = new Guid("b108d866-eb13-46e3-b3d2-ecae4fbfe872")
                },
                new IdentityUserRole<Guid>()
                {
                    UserId = new Guid("dbca0788-4fb0-4986-8928-4df593da3f5e"),
                    RoleId = new Guid("b108d866-eb13-46e3-b3d2-ecae4fbfe873")
                });

            modelBuilder.Entity<Customer>().HasData(
            new Customer()
            {
                Id = new Guid("a77f8ae9-af3d-4288-bbf3-8f77776f9231"),
                RankId = new Guid("a77f8ae9-af3d-4288-bbf3-8f77776f9236"),
                Gender = 0,
                DateOfBirth = new DateTime(2003, 10, 20),
                Address = "Hoa Thanh Quế",
                Point = 12000,
                Status = 0,
                UserName = "ThanhTung",
                NormalizedUserName = "THANHTUNG",
                Email = "thanhtung@gmail.com",
                NormalizedEmail = "THANHTUNG@GMAIL.COM",
                PasswordHash = "AQAAAAEAACcQAAAAEDnw9/bad7RVII19Bn9Zetmhe4D2/RUELI0q65G6PgafUeSuvXTxEHTAC/hp5s372A==",
                SecurityStamp = "4GK7QXS2ZVKDV4BO2GGNSUH5SIGOGCMZ",
                ConcurrencyStamp = "e4bf7cff-6b1d-4814-801c-02470855c7e5",
                PhoneNumber = "0696969696",
                LockoutEnabled = true,
            },
            new Customer()
            {
                Id = new Guid("a77f8ae9-af3d-4288-bbf3-8f77776f9230"),
                RankId = new Guid("a77f8ae9-af3d-4288-bbf3-8f77776f9236"),
                Gender = 1,
                DateOfBirth = new DateTime(2003, 11, 11),
                Address = "Hoa Thanh Quế",
                Point = 12000,
                Status = 0,
                UserName = "QuynhAnh",
                NormalizedUserName = "QUYNHANH",
                Email = "quynhanh@gmail.com",
                NormalizedEmail = "QUYNHANH@GMAIL.COM",
                PasswordHash = "AQAAAAEAACcQAAAAEDnw9/bad7RVII19Bn9Zetmhe4D2/RUELI0q65G6PgafUeSuvXTxEHTAC/hp5s372A==",
                SecurityStamp = "4GK7QXS2ZVKDV4BO2GGNSUH5SIGOGCMZ",
                ConcurrencyStamp = "e4bf7cff-6b1d-4814-801c-02470855c7e5",
                PhoneNumber = "0363636363",
                LockoutEnabled = true,
            });

            modelBuilder.Entity<Shaft>().HasData(
            new Shaft()
            {
                Id = new Guid("cc37720a-7e89-463a-9510-1936e6761d83"),
                Name = "Cuốn chỉ",
                Price = 100,
                Size = 1,
                Length = 1,
                Material = "Gỗ",
                Color = "Đen",
                Status = 0,
            },
            new Shaft()
            {
                Id = new Guid("cc37720a-7e89-463a-9510-1936e6761d73"),
                Name = "Bọc da",
                Price = 120,
                Size = 2,
                Length = 1,
                Material = "Gỗ",
                Color = "Xanh",
                Status = 0,
            },
            new Shaft()
            {
                Id = new Guid("cc37720a-7e89-463a-9510-1936e6761d63"),
                Name = "Bọc cao su",
                Price = 90,
                Size = 1,
                Length = 2,
                Material = "Nhôm",
                Color = "Đen",
                Status = 0,
            },
            new Shaft()
            {
                Id = new Guid("cc37720a-7e89-463a-9510-1936e6761d53"),
                Name = "Trơn",
                Price = 140,
                Size = 2,
                Length = 2,
                Material = "Sắt",
                Color = "Đen",
                Status = 0,
            });

            modelBuilder.Entity<Tip>().HasData(
            new Tip()
            {
                Id = new Guid("cc37720a-7e89-463a-9510-1936e6761d84"),
                Name = "F1 CLEAR",
                Price = 100,
                Size = 1,
                Length = 1,
                Material = "Gỗ",
                Color = "Đen",
                Status = 0,
            },
            new Tip()
            {
                Id = new Guid("cc37720a-7e89-463a-9510-1936e6761d74"),
                Name = "F1 france",
                Price = 140,
                Size = 2,
                Length = 2,
                Material = "Gỗ",
                Color = "Xanh",
                Status = 0,
            });

            modelBuilder.Entity<Weight>().HasData(
            new Weight()
            {
                Id = new Guid("cc37720a-7e89-463a-9510-1936e6761d85"),
                Name = "CW4",
                Price = 100,
                Status = 0,
            },
            new Weight()
            {
                Id = new Guid("cc37720a-7e89-463a-9510-1936e6761d75"),
                Name = "CW3",
                Price = 120,
                Status = 0,
            });

            modelBuilder.Entity<Category>().HasData(
                new Category()
                {
                    Id = new Guid("357267e8-d162-4844-a660-661f46933d03"),
                    Name = "BK",
                    Status = 0
                },
                new Category()
                {
                    Id = new Guid("357267e8-d162-4844-a660-661f46933d04"),
                    Name = "Cuetec",
                    Status = 0
                },
                new Category()
                {
                    Id = new Guid("357267e8-d162-4844-a660-661f46933d05"),
                    Name = "Demon",
                    Status = 0
                },
                new Category()
                {
                    Id = new Guid("357267e8-d162-4844-a660-661f46933d06"),
                    Name = "EXCEED",
                    Status = 0
                },
                new Category()
                {
                    Id = new Guid("357267e8-d162-4844-a660-661f46933d07"),
                    Name = "Fury",
                    Status = 0
                },
                new Category()
                {
                    Id = new Guid("357267e8-d162-4844-a660-661f46933d08"),
                    Name = "Peri Pool",
                    Status = 0
                },
                new Category()
                {
                    Id = new Guid("357267e8-d162-4844-a660-661f46933d09"),
                    Name = "Predator",
                    Status = 0
                },
                new Category()
                {
                    Id = new Guid("357267e8-d162-4844-a660-661f46933d00"),
                    Name = "HOW",
                    Status = 0
                },
                new Category()
                {
                    Id = new Guid("357267e8-d162-4844-a660-661f46933d10"),
                    Name = "Mezz",
                    Status = 0
                },
                new Category()
                {
                    Id = new Guid("357267e8-d162-4844-a660-661f46933d11"),
                    Name = "Mit",
                    Status = 0
                },
                new Category()
                {
                    Id = new Guid("357267e8-d162-4844-a660-661f46933d12"),
                    Name = "Cơ Lỗ Cho Người Mới",
                    Status = 0
                },
                new Category()
                {
                    Id = new Guid("357267e8-d162-4844-a660-661f46933d13"),
                    Name = "Rhino",
                    Status = 0
                },
                new Category()
                {
                    Id = new Guid("357267e8-d162-4844-a660-661f46933d14"),
                    Name = "The Rack",
                    Status = 0
                });

            modelBuilder.Entity<Product>().HasData(
                new Product()
                {
                    Id = new Guid("cc37720a-7e89-463a-9510-1936e6761d8a"),
                    CategoryID = new Guid("357267e8-d162-4844-a660-661f46933d03"),
                    Name = "Gậy bida sành điệu 1",
                    Pin = "pin1",
                    Wrap = "wrap1",
                    Rings = "ring1",
                    AvailableQuantity = 1000,
                    Sold = 500,
                    Likes = 1000,
                    CreateDate = new DateTime(2023, 09, 11),
                    Producer = "Lucasi",
                    Status = 0,
                    Description = "Description",
                },
                new Product()
                {
                    Id = new Guid("cc37720a-7e89-463a-9510-1936e6761d8b"),
                    CategoryID = new Guid("357267e8-d162-4844-a660-661f46933d04"),
                    Name = "Gậy bida sành điệu 2",
                    Pin = "pin2",
                    Wrap = "wrap2",
                    Rings = "ring2",
                    AvailableQuantity = 2000,
                    Sold = 500,
                    Likes = 1000,
                    CreateDate = new DateTime(2023, 09, 11),
                    Producer = "Lucasi",
                    Status = 0,
                    Description = "Description",
                },
                new Product()
                {
                    Id = new Guid("cc37720a-7e89-463a-9510-1936e6761d8c"),
                    CategoryID = new Guid("357267e8-d162-4844-a660-661f46933d05"),
                    Name = "Gậy bida sành điệu 3",
                    Pin = "pin3",
                    Wrap = "wrap3",
                    Rings = "ring3",
                    AvailableQuantity = 2000,
                    Sold = 500,
                    Likes = 1000,
                    CreateDate = new DateTime(2023, 09, 11),
                    Producer = "Lucasi",
                    Status = 0,
                    Description = "Description",
                });

            modelBuilder.Entity<ProductDetail>().HasData(
                new ProductDetail()
                {
                    Id = new Guid("1eaaba04-80ff-43a6-a746-a74a91c4c0e3"),
                    ProductID = new Guid("cc37720a-7e89-463a-9510-1936e6761d8a"),
                    TipId = new Guid("cc37720a-7e89-463a-9510-1936e6761d84"),
                    ShaftId = new Guid("cc37720a-7e89-463a-9510-1936e6761d83"),
                    WeightId = new Guid("cc37720a-7e89-463a-9510-1936e6761d85"),
                    Quantity = 1,
                    ImportPrice = 1500,
                    Price = 2000,
                    CreateDate = new DateTime(2023, 09, 12),
                    Status = 0,
                    Description = "Description",
                },
                new ProductDetail()
                {
                    Id = new Guid("979a227c-41b7-4644-8ab1-e1c8d092f79f"),
                    ProductID = new Guid("cc37720a-7e89-463a-9510-1936e6761d8b"),
                    TipId = new Guid("cc37720a-7e89-463a-9510-1936e6761d74"),
                    ShaftId = new Guid("cc37720a-7e89-463a-9510-1936e6761d73"),
                    WeightId = new Guid("cc37720a-7e89-463a-9510-1936e6761d75"),
                    Quantity = 1,
                    ImportPrice = 1500,
                    Price = 2000,
                    CreateDate = new DateTime(2023, 09, 12),
                    Status = 0,
                    Description = "Description",
                },
                new ProductDetail()
                {
                    Id = new Guid("84a7b7bd-0490-4cf1-9499-1d9fe88580c3"),
                    ProductID = new Guid("cc37720a-7e89-463a-9510-1936e6761d8c"),
                    TipId = new Guid("cc37720a-7e89-463a-9510-1936e6761d74"),
                    ShaftId = new Guid("cc37720a-7e89-463a-9510-1936e6761d73"),
                    WeightId = new Guid("cc37720a-7e89-463a-9510-1936e6761d75"),
                    Quantity = 1,
                    ImportPrice = 1500,
                    Price = 2000,
                    CreateDate = new DateTime(2023, 09, 12),
                    Status = 0,
                    Description = "Description",
                });

            modelBuilder.Entity<Cart>().HasData(
                new Cart()
                {
                    CustomerId = new Guid("a77f8ae9-af3d-4288-bbf3-8f77776f9230"),
                    Quantity = 0,
                    TotalMoney = 0,
                    Status = 1
                },
                new Cart()
                {
                    CustomerId = new Guid("a77f8ae9-af3d-4288-bbf3-8f77776f9231"),
                    Quantity = 1,
                    TotalMoney = 2000,
                    Status = 0
                });

            modelBuilder.Entity<CartDetail>().HasData(
                new CartDetail()
                {
                    Id = new Guid("357267e8-d162-4844-a660-661f46933d02"),
                    CustomerId = new Guid("a77f8ae9-af3d-4288-bbf3-8f77776f9231"),
                    ProductDetailId = new Guid("979a227c-41b7-4644-8ab1-e1c8d092f79f"),
                    Quantity = 1,
                    Price = 2000
                });

            modelBuilder.Entity<BillStatus>().HasData(
            new BillStatus()
            {
                Id = new Guid("a51f7c3c-a8e7-4c0a-aeea-b6fc70492bf5"),
                Name = "Đã xác nhận"
            },
            new BillStatus()
            {
                Id = new Guid("a51f7c3c-a8e7-4c0a-aeea-b6fc70492b15"),
                Name = "Chờ xác nhận"
            });

            modelBuilder.Entity<Payment>().HasData(
            new Payment()
            {
                Id = new Guid("a51f7c3c-a8e7-4c0a-aeea-b6fc70492bf6"),
                Name = "Offline",
            },
            new Payment()
            {
                Id = new Guid("a51f7c3c-a8e7-4c0a-aeea-b6fc70492b16"),
                Name = "Online",
            });

            modelBuilder.Entity<Voucher>().HasData(
            new Voucher()
            {
                Id = new Guid("a51f7c3c-a8e7-4c0a-aeea-b6fc70492bf4"),
                EmPloyeeId = new Guid("40b601c0-2c08-449f-a41e-7564648f2c87"),
                Code = "DEMACIA",
                Value = 30,
                TimeStart = new DateTime(2023, 09, 11),
                TimeEnd = new DateTime(2023, 10, 11),
                Status = 0,
            },
            new Voucher()
            {
                Id = new Guid("a51f7c3c-a8e7-4c0a-aeea-b6fc70492b14"),
                EmPloyeeId = new Guid("dbca0788-4fb0-4986-8928-4df593da3f5e"),
                Code = "Pitover",
                Value = 50,
                TimeStart = new DateTime(2023, 09, 11),
                TimeEnd = new DateTime(2023, 09, 18),
                Status = 1,
            });

            modelBuilder.Entity<Bill>().HasData(
            new Bill()
            {
                Id = new Guid("a51f7c3c-a8e7-4c0a-aeea-b6fc70492bf3"),
                CustomerId = new Guid("a77f8ae9-af3d-4288-bbf3-8f77776f9230"),
                BillStatusId = new Guid("a51f7c3c-a8e7-4c0a-aeea-b6fc70492b15"),
                PaymentId = new Guid("a51f7c3c-a8e7-4c0a-aeea-b6fc70492bf6"),
                Price = 1500,
                CreateDate = new DateTime(2023, 09, 11),
                Address = "Bình nguyên vô tận",
            },
            new Bill()
            {
                Id = new Guid("a51f7c3c-a8e7-4c0a-aeea-b6fc70492b13"),
                CustomerId = new Guid("a77f8ae9-af3d-4288-bbf3-8f77776f9230"),
                BillStatusId = new Guid("a51f7c3c-a8e7-4c0a-aeea-b6fc70492bf5"),
                PaymentId = new Guid("a51f7c3c-a8e7-4c0a-aeea-b6fc70492b16"),
                Price = 1450,
                CreateDate = new DateTime(2023, 09, 11),
                Address = "phi phai",
            });

            modelBuilder.Entity<UsedVoucher>().HasData(
                new UsedVoucher()
                {
                    BillId = new Guid("a51f7c3c-a8e7-4c0a-aeea-b6fc70492b13"),
                    VoucherId = new Guid("a51f7c3c-a8e7-4c0a-aeea-b6fc70492b14")
                });

            modelBuilder.Entity<BillDetail>().HasData(
            new BillDetail()
            {
                Id = new Guid("8f95d2d6-c3d3-4749-be89-97e220d62e79"),
                BillId = new Guid("a51f7c3c-a8e7-4c0a-aeea-b6fc70492bf3"),
                ProductDetailId = new Guid("1eaaba04-80ff-43a6-a746-a74a91c4c0e3"),
                Quantity = 1,
                Price = 1500,
            },
            new BillDetail()
            {
                Id = new Guid("8f95d2d6-c3d3-4749-be89-97e220d62e78"),
                BillId = new Guid("a51f7c3c-a8e7-4c0a-aeea-b6fc70492b13"),
                ProductDetailId = new Guid("979a227c-41b7-4644-8ab1-e1c8d092f79f"),
                Quantity = 1,
                Price = 1450,
            });

            modelBuilder.Entity<WishList>().HasData(
            new WishList()
            {
                Id = new Guid("37c66a8d-acb9-41a1-af73-f46e83a578dc"),
                CustomerId = new Guid("a77f8ae9-af3d-4288-bbf3-8f77776f9231"),
                ProductId = new Guid("cc37720a-7e89-463a-9510-1936e6761d8a")
            });

            modelBuilder.Entity<ProductImage>().HasData(
            new ProductImage()
            {
                Id = new Guid("d5c65161-7591-48c1-9198-daca151bce7c"),
                ProductDetailId = new Guid("1eaaba04-80ff-43a6-a746-a74a91c4c0e3"),
                Name = "image1",
                Status = 0,
            },
            new ProductImage()
            {
                Id = new Guid("e666f8b0-0d76-400e-bdb0-ca85a9ba65d1"),
                ProductDetailId = new Guid("979a227c-41b7-4644-8ab1-e1c8d092f79f"),
                Name = "image2",
                Status = 0,
            },
            new ProductImage()
            {
                Id = new Guid("a9e47c8b-4af6-4ccd-b259-7367eb8f6423"),
                ProductDetailId = new Guid("84a7b7bd-0490-4cf1-9499-1d9fe88580c3"),
                Name = "image3",
                Status = 0,
            });
        }
    }
}