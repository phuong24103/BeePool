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
                new IdentityRole<Guid>() { Name = "Quản lý", NormalizedName = "QUẢN LÝ", Id = new Guid("b108d866-eb13-46e3-b3d2-ecae4fbfe872") },
                new IdentityRole<Guid>() { Name = "Nhân viên", NormalizedName = "NHÂN VIÊN", Id = new Guid("b108d866-eb13-46e3-b3d2-ecae4fbfe873") }
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
                FullName = "Phạm Nguyễn Quốc Phương",
                Gender = 0,
                DateOfBirth = new DateTime(2003, 8, 20),
                Address = "Hoa Thanh Quế",
                Image = "phuongpnq.png",
                Twitter = "https://twitter.com/#",
                Facebook = "https://facebook.com/#",
                Instagram = "https://instagram.com/#",
                Linkedin = "https://linkedin.com/#",
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
                FullName = "Mai Văn Phương",
                Gender = 0,
                DateOfBirth = new DateTime(2000, 10, 26),
                Address = "Hoa Thanh Quế",
                Image = "phuongmv.png",
                Twitter = "https://twitter.com/#",
                Facebook = "https://facebook.com/#",
                Instagram = "https://instagram.com/#",
                Linkedin = "https://linkedin.com/#",
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
                FullName = "Hoàng Thanh Tùng",
                Gender = 0,
                DateOfBirth = new DateTime(2003, 10, 20),
                Address = "Hoa Thanh Quế",
                Image = "tunght.png",
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
                FullName = "Quỳnh Anh",
                Gender = 1,
                DateOfBirth = new DateTime(2003, 11, 11),
                Address = "Hoa Thanh Quế",
                Image = "anhq.png",
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
                Id = new Guid("cc37720a-7e89-463a-9510-1936e6761d04"),
                Name = "Kamui Clear Black - Super Soft",
                Price = 28.3,
                Size = 1,
                Length = 1,
                Material = "Gỗ",
                Color = "Đen",
                Status = 0,
            },
            new Tip()
            {
                Id = new Guid("cc37720a-7e89-463a-9510-1936e6761d14"),
                Name = "Kamui Clear Black - Soft",
                Price = 28.3,
                Size = 2,
                Length = 2,
                Material = "Gỗ",
                Color = "Xanh",
                Status = 0,
            },
            new Tip()
            {
                Id = new Guid("cc37720a-7e89-463a-9510-1936e6761d24"),
                Name = "Kamui Clear Black - Medium",
                Price = 28.3,
                Size = 2,
                Length = 2,
                Material = "Gỗ",
                Color = "Xanh",
                Status = 0,
            },
            new Tip()
            {
                Id = new Guid("cc37720a-7e89-463a-9510-1936e6761d34"),
                Name = "Kamui Clear Black - Hard",
                Price = 28.3,
                Size = 2,
                Length = 2,
                Material = "Gỗ",
                Color = "Xanh",
                Status = 0,
            },
            new Tip()
            {
                Id = new Guid("cc37720a-7e89-463a-9510-1936e6761d44"),
                Name = "Kamui Black - Hard",
                Price = 26.8,
                Size = 2,
                Length = 2,
                Material = "Gỗ",
                Color = "Xanh",
                Status = 0,
            },
            new Tip()
            {
                Id = new Guid("cc37720a-7e89-463a-9510-1936e6761d54"),
                Name = "Kamui Black - Medium",
                Price = 26.8,
                Size = 2,
                Length = 2,
                Material = "Gỗ",
                Color = "Xanh",
                Status = 0,
            },
            new Tip()
            {
                Id = new Guid("cc37720a-7e89-463a-9510-1936e6761d64"),
                Name = "Kamui Black - Soft",
                Price = 26.8,
                Size = 2,
                Length = 2,
                Material = "Gỗ",
                Color = "Xanh",
                Status = 0,
            },
            new Tip()
            {
                Id = new Guid("cc37720a-7e89-463a-9510-1936e6761d74"),
                Name = "Kamui Black  - Super Soft",
                Price = 26.8,
                Size = 2,
                Length = 2,
                Material = "Gỗ",
                Color = "Xanh",
                Status = 0,
            },
            new Tip()
            {
                Id = new Guid("cc37720a-7e89-463a-9510-1936e6761d84"),
                Name = "Kamui Original Clear Super Soft",
                Price = 24.8,
                Size = 2,
                Length = 2,
                Material = "Gỗ",
                Color = "Xanh",
                Status = 0,
            },
            new Tip()
            {
                Id = new Guid("cc37720a-7e89-463a-9510-1936e6761d94"),
                Name = "Kamui Original Clear Soft",
                Price = 24.8,
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
                Name = "18oz",
                Price = 0,
                Status = 0,
            },
            new Weight()
            {
                Id = new Guid("cc37720a-7e89-463a-9510-1936e6761d75"),
                Name = "19oz",
                Price = 0,
                Status = 0,
            },
            new Weight()
            {
                Id = new Guid("cc37720a-7e89-463a-9510-1936e6761d65"),
                Name = "20oz",
                Price = 0,
                Status = 0,
            },
            new Weight()
            {
                Id = new Guid("cc37720a-7e89-463a-9510-1936e6761d55"),
                Name = "21oz",
                Price = 0,
                Status = 0,
            });

            modelBuilder.Entity<Category>().HasData(
                new Category()
                {
                    Id = new Guid("357267e8-d162-4844-a660-661f46933d03"),
                    Name = "Cơ Đánh",
                    CreatedDate = new DateTime(2022, 09, 11),
                    UpdatedDate = new DateTime(2022, 09, 11),
                    Status = 0
                },
                new Category()
                {
                    Id = new Guid("357267e8-d162-4844-a660-661f46933d04"),
                    Name = "Cơ Nhảy",
                    CreatedDate = new DateTime(2023, 09, 11),
                    UpdatedDate = new DateTime(2023, 09, 11),
                    Status = 0
                },
                new Category()
                {
                    Id = new Guid("357267e8-d162-4844-a660-661f46933d05"),
                    Name = "Cơ Phá",
                    CreatedDate = new DateTime(2023, 10, 10),
                    UpdatedDate = new DateTime(2023, 09, 10),
                    Status = 0
                },
                new Category()
                {
                    Id = new Guid("357267e8-d162-4844-a660-661f46933d06"),
                    Name = "Cơ Phá + Nhảy",
                    CreatedDate = new DateTime(2023, 11, 05),
                    UpdatedDate = new DateTime(2023, 11, 05),
                    Status = 0
                },
                new Category()
                {
                    Id = new Guid("357267e8-d162-4844-a660-661f46933d07"),
                    Name = "Cơ ba băng",
                    CreatedDate = DateTime.Now,
                    UpdatedDate = DateTime.Now,
                    Status = 0
                });

            modelBuilder.Entity<Product>().HasData(
                new Product()
                {
                    Id = new Guid("cc37720a-7e89-463a-9510-1936e6761d8a"),
                    CategoryID = new Guid("357267e8-d162-4844-a660-661f46933d03"),
                    Name = "Predator Purpleheart 8-Point Sneaky Pete With Wrap",
                    Pin = "Uniloc Quick Release",
                    Wrap = "Blue and White Irish Linen",
                    Rings = "None",
                    AvailableQuantity = 1000,
                    Sold = 500,
                    Likes = 1000,
                    CreateDate = new DateTime(2023, 09, 11),
                    Producer = "PRESP8PW_",
                    Status = 0,
                    Description = "Giới thiệu Cue Predator Sneaky Pete, nơi sự khéo léo kết hợp sự sang trọng. Lớp hoàn thiện mờ Purpleheart thể hiện phong cách đặc biệt của nó, với tám điểm màu xanh lam, vàng và đen quyến rũ. Màu xanh bóng mượt với lớp bọc vải lanh Ailen màu trắng tạo thêm nét đẳng cấp và tăng cường khả năng cầm nắm của bạn. Nâng cao trò chơi của bạn với độ chính xác và sự khéo léo của tín hiệu Predator Sneaky Pete.",
                },
                new Product()
                {
                    Id = new Guid("cc37720a-7e89-463a-9510-1936e6761d8b"),
                    CategoryID = new Guid("357267e8-d162-4844-a660-661f46933d04"),
                    Name = "Mezz ZZ37 Pool Cue",
                    Pin = "Mezz United Joint",
                    Wrap = "Black Irish Linen",
                    Rings = "Silver Rings",
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
                    Name = "Summit SUML17 Pool Cue",
                    Pin = "Mezz United Joint",
                    Wrap = "Black Irish Linen",
                    Rings = "Silver Rings",
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
                    Id = new Guid("cc37720a-7e89-463a-9510-2936e6761d8a"),
                    CategoryID = new Guid("357267e8-d162-4844-a660-661f46933d06"),
                    Name = "Katana KAT19 Pool Cue",
                    Pin = "Mezz United Joint",
                    Wrap = "Black Irish Linen",
                    Rings = "Silver Rings",
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
                    Id = new Guid("cc37720a-7e89-463a-9510-3936e6761d8b"),
                    CategoryID = new Guid("357267e8-d162-4844-a660-661f46933d07"),
                    Name = "Summit SUML13 Pool Cue",
                    Pin = "Mezz United Joint",
                    Wrap = "Black Irish Linen",
                    Rings = "Silver Rings",
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
                    Id = new Guid("cc37720a-7e89-463a-9510-4936e6761d8c"),
                    CategoryID = new Guid("357267e8-d162-4844-a660-661f46933d03"),
                    Name = "Cuetec AVID Proof CT326NW Pool Cue",
                    Pin = "Uniloc Quick Release",
                    Wrap = "Blue and White Irish Linen",
                    Rings = "None",
                    AvailableQuantity = 1000,
                    Sold = 500,
                    Likes = 1000,
                    CreateDate = new DateTime(2023, 09, 11),
                    Producer = "PRESP8PW_",
                    Status = 0,
                    Description = "Giới thiệu Cue Predator Sneaky Pete, nơi sự khéo léo kết hợp sự sang trọng. Lớp hoàn thiện mờ Purpleheart thể hiện phong cách đặc biệt của nó, với tám điểm màu xanh lam, vàng và đen quyến rũ. Màu xanh bóng mượt với lớp bọc vải lanh Ailen màu trắng tạo thêm nét đẳng cấp và tăng cường khả năng cầm nắm của bạn. Nâng cao trò chơi của bạn với độ chính xác và sự khéo léo của tín hiệu Predator Sneaky Pete.",
                },
                new Product()
                {
                    Id = new Guid("cc37720a-7e89-463a-9510-5936e6761d8a"),
                    CategoryID = new Guid("357267e8-d162-4844-a660-661f46933d04"),
                    Name = "Cuetec AVID Proof CT326LTC Pool Cue",
                    Pin = "Mezz United Joint",
                    Wrap = "Black Irish Linen",
                    Rings = "Silver Rings",
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
                    Id = new Guid("cc37720a-7e89-463a-9510-6936e6761d8b"),
                    CategoryID = new Guid("357267e8-d162-4844-a660-661f46933d05"),
                    Name = "Meucci Casino MECAS10 Pool Cue",
                    Pin = "Mezz United Joint",
                    Wrap = "Black Irish Linen",
                    Rings = "Silver Rings",
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
                    Id = new Guid("cc37720a-7e89-463a-9510-7936e6761d8c"),
                    CategoryID = new Guid("357267e8-d162-4844-a660-661f46933d03"),
                    Name = "Bull Carbon BCSP2 Silver Split Cue W/",
                    Pin = "Mezz United Joint",
                    Wrap = "Black Irish Linen",
                    Rings = "Silver Rings",
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
                    Id = new Guid("cc37720a-7e89-463a-9510-8936e6761d8a"),
                    CategoryID = new Guid("357267e8-d162-4844-a660-661f46933d04"),
                    Name = "Balabushka GBT Era Cue",
                    Pin = "Mezz United Joint",
                    Wrap = "Black Irish Linen",
                    Rings = "Silver Rings",
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
                    Id = new Guid("1eaaba04-80ff-43a6-a746-a74a91c4c0e0"),
                    ProductID = new Guid("cc37720a-7e89-463a-9510-1936e6761d8a"),
                    TipId = new Guid("cc37720a-7e89-463a-9510-1936e6761d04"),
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
                    Id = new Guid("1eaaba04-80ff-43a6-a746-a74a91c4c0e1"),
                    ProductID = new Guid("cc37720a-7e89-463a-9510-1936e6761d8a"),
                    TipId = new Guid("cc37720a-7e89-463a-9510-1936e6761d14"),
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
                    Id = new Guid("1eaaba04-80ff-43a6-a746-a74a91c4c0e2"),
                    ProductID = new Guid("cc37720a-7e89-463a-9510-1936e6761d8a"),
                    TipId = new Guid("cc37720a-7e89-463a-9510-1936e6761d24"),
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
                    Id = new Guid("1eaaba04-80ff-43a6-a746-a74a91c4c0e3"),
                    ProductID = new Guid("cc37720a-7e89-463a-9510-1936e6761d8a"),
                    TipId = new Guid("cc37720a-7e89-463a-9510-1936e6761d34"),
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
                    Id = new Guid("1eaaba04-80ff-43a6-a746-a74a91c4c0e4"),
                    ProductID = new Guid("cc37720a-7e89-463a-9510-1936e6761d8a"),
                    TipId = new Guid("cc37720a-7e89-463a-9510-1936e6761d44"),
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
                    Id = new Guid("1eaaba04-80ff-43a6-a746-a74a91c4c0e5"),
                    ProductID = new Guid("cc37720a-7e89-463a-9510-1936e6761d8a"),
                    TipId = new Guid("cc37720a-7e89-463a-9510-1936e6761d54"),
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
                    Id = new Guid("1eaaba04-80ff-43a6-a746-a74a91c4c0e6"),
                    ProductID = new Guid("cc37720a-7e89-463a-9510-1936e6761d8a"),
                    TipId = new Guid("cc37720a-7e89-463a-9510-1936e6761d64"),
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
                    Id = new Guid("1eaaba04-80ff-43a6-a746-a74a91c4c0e7"),
                    ProductID = new Guid("cc37720a-7e89-463a-9510-1936e6761d8a"),
                    TipId = new Guid("cc37720a-7e89-463a-9510-1936e6761d74"),
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
                    Id = new Guid("1eaaba04-80ff-43a6-a746-a74a91c4c0e8"),
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
                    Id = new Guid("1eaaba04-80ff-43a6-a746-a74a91c4c0e9"),
                    ProductID = new Guid("cc37720a-7e89-463a-9510-1936e6761d8a"),
                    TipId = new Guid("cc37720a-7e89-463a-9510-1936e6761d94"),
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
                    Id = new Guid("1eaaba04-80ff-43a6-a746-a74a91c4c1e0"),
                    ProductID = new Guid("cc37720a-7e89-463a-9510-1936e6761d8a"),
                    TipId = new Guid("cc37720a-7e89-463a-9510-1936e6761d04"),
                    ShaftId = new Guid("cc37720a-7e89-463a-9510-1936e6761d73"),
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
                    Id = new Guid("1eaaba04-80ff-43a6-a746-a74a91c4c1e1"),
                    ProductID = new Guid("cc37720a-7e89-463a-9510-1936e6761d8a"),
                    TipId = new Guid("cc37720a-7e89-463a-9510-1936e6761d14"),
                    ShaftId = new Guid("cc37720a-7e89-463a-9510-1936e6761d73"),
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
                    Id = new Guid("1eaaba04-80ff-43a6-a746-a74a91c4c1e2"),
                    ProductID = new Guid("cc37720a-7e89-463a-9510-1936e6761d8a"),
                    TipId = new Guid("cc37720a-7e89-463a-9510-1936e6761d24"),
                    ShaftId = new Guid("cc37720a-7e89-463a-9510-1936e6761d73"),
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
                    Id = new Guid("1eaaba04-80ff-43a6-a746-a74a91c4c1e3"),
                    ProductID = new Guid("cc37720a-7e89-463a-9510-1936e6761d8a"),
                    TipId = new Guid("cc37720a-7e89-463a-9510-1936e6761d34"),
                    ShaftId = new Guid("cc37720a-7e89-463a-9510-1936e6761d73"),
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
                    Id = new Guid("1eaaba04-80ff-43a6-a746-a74a91c4c1e4"),
                    ProductID = new Guid("cc37720a-7e89-463a-9510-1936e6761d8a"),
                    TipId = new Guid("cc37720a-7e89-463a-9510-1936e6761d44"),
                    ShaftId = new Guid("cc37720a-7e89-463a-9510-1936e6761d73"),
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
                    Id = new Guid("1eaaba04-80ff-43a6-a746-a74a91c4c1e5"),
                    ProductID = new Guid("cc37720a-7e89-463a-9510-1936e6761d8a"),
                    TipId = new Guid("cc37720a-7e89-463a-9510-1936e6761d54"),
                    ShaftId = new Guid("cc37720a-7e89-463a-9510-1936e6761d73"),
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
                    Id = new Guid("1eaaba04-80ff-43a6-a746-a74a91c4c1e6"),
                    ProductID = new Guid("cc37720a-7e89-463a-9510-1936e6761d8a"),
                    TipId = new Guid("cc37720a-7e89-463a-9510-1936e6761d64"),
                    ShaftId = new Guid("cc37720a-7e89-463a-9510-1936e6761d73"),
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
                    Id = new Guid("1eaaba04-80ff-43a6-a746-a74a91c4c1e7"),
                    ProductID = new Guid("cc37720a-7e89-463a-9510-1936e6761d8a"),
                    TipId = new Guid("cc37720a-7e89-463a-9510-1936e6761d74"),
                    ShaftId = new Guid("cc37720a-7e89-463a-9510-1936e6761d73"),
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
                    Id = new Guid("1eaaba04-80ff-43a6-a746-a74a91c4c1e8"),
                    ProductID = new Guid("cc37720a-7e89-463a-9510-1936e6761d8a"),
                    TipId = new Guid("cc37720a-7e89-463a-9510-1936e6761d84"),
                    ShaftId = new Guid("cc37720a-7e89-463a-9510-1936e6761d73"),
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
                    Id = new Guid("1eaaba04-80ff-43a6-a746-a74a91c4c1e9"),
                    ProductID = new Guid("cc37720a-7e89-463a-9510-1936e6761d8a"),
                    TipId = new Guid("cc37720a-7e89-463a-9510-1936e6761d94"),
                    ShaftId = new Guid("cc37720a-7e89-463a-9510-1936e6761d73"),
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
                    Id = new Guid("1eaaba04-80ff-43a6-a746-a74a91c4c2e0"),
                    ProductID = new Guid("cc37720a-7e89-463a-9510-1936e6761d8a"),
                    TipId = new Guid("cc37720a-7e89-463a-9510-1936e6761d04"),
                    ShaftId = new Guid("cc37720a-7e89-463a-9510-1936e6761d63"),
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
                    Id = new Guid("1eaaba04-80ff-43a6-a746-a74a91c4c2e1"),
                    ProductID = new Guid("cc37720a-7e89-463a-9510-1936e6761d8a"),
                    TipId = new Guid("cc37720a-7e89-463a-9510-1936e6761d14"),
                    ShaftId = new Guid("cc37720a-7e89-463a-9510-1936e6761d63"),
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
                    Id = new Guid("1eaaba04-80ff-43a6-a746-a74a91c4c2e2"),
                    ProductID = new Guid("cc37720a-7e89-463a-9510-1936e6761d8a"),
                    TipId = new Guid("cc37720a-7e89-463a-9510-1936e6761d24"),
                    ShaftId = new Guid("cc37720a-7e89-463a-9510-1936e6761d63"),
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
                    Id = new Guid("1eaaba04-80ff-43a6-a746-a74a91c4c2e3"),
                    ProductID = new Guid("cc37720a-7e89-463a-9510-1936e6761d8a"),
                    TipId = new Guid("cc37720a-7e89-463a-9510-1936e6761d34"),
                    ShaftId = new Guid("cc37720a-7e89-463a-9510-1936e6761d63"),
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
                    Id = new Guid("1eaaba04-80ff-43a6-a746-a74a91c4c2e4"),
                    ProductID = new Guid("cc37720a-7e89-463a-9510-1936e6761d8a"),
                    TipId = new Guid("cc37720a-7e89-463a-9510-1936e6761d44"),
                    ShaftId = new Guid("cc37720a-7e89-463a-9510-1936e6761d63"),
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
                    Id = new Guid("1eaaba04-80ff-43a6-a746-a74a91c4c2e5"),
                    ProductID = new Guid("cc37720a-7e89-463a-9510-1936e6761d8a"),
                    TipId = new Guid("cc37720a-7e89-463a-9510-1936e6761d54"),
                    ShaftId = new Guid("cc37720a-7e89-463a-9510-1936e6761d63"),
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
                    Id = new Guid("1eaaba04-80ff-43a6-a746-a74a91c4c2e6"),
                    ProductID = new Guid("cc37720a-7e89-463a-9510-1936e6761d8a"),
                    TipId = new Guid("cc37720a-7e89-463a-9510-1936e6761d64"),
                    ShaftId = new Guid("cc37720a-7e89-463a-9510-1936e6761d63"),
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
                    Id = new Guid("1eaaba04-80ff-43a6-a746-a74a91c4c2e7"),
                    ProductID = new Guid("cc37720a-7e89-463a-9510-1936e6761d8a"),
                    TipId = new Guid("cc37720a-7e89-463a-9510-1936e6761d74"),
                    ShaftId = new Guid("cc37720a-7e89-463a-9510-1936e6761d63"),
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
                    Id = new Guid("1eaaba04-80ff-43a6-a746-a74a91c4c2e8"),
                    ProductID = new Guid("cc37720a-7e89-463a-9510-1936e6761d8a"),
                    TipId = new Guid("cc37720a-7e89-463a-9510-1936e6761d84"),
                    ShaftId = new Guid("cc37720a-7e89-463a-9510-1936e6761d63"),
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
                    Id = new Guid("1eaaba04-80ff-43a6-a746-a74a91c4c2e9"),
                    ProductID = new Guid("cc37720a-7e89-463a-9510-1936e6761d8a"),
                    TipId = new Guid("cc37720a-7e89-463a-9510-1936e6761d94"),
                    ShaftId = new Guid("cc37720a-7e89-463a-9510-1936e6761d63"),
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
                    Id = new Guid("1eaaba04-80ff-43a6-a746-a74a91c4c3e0"),
                    ProductID = new Guid("cc37720a-7e89-463a-9510-1936e6761d8a"),
                    TipId = new Guid("cc37720a-7e89-463a-9510-1936e6761d04"),
                    ShaftId = new Guid("cc37720a-7e89-463a-9510-1936e6761d53"),
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
                    Id = new Guid("1eaaba04-80ff-43a6-a746-a74a91c4c3e1"),
                    ProductID = new Guid("cc37720a-7e89-463a-9510-1936e6761d8a"),
                    TipId = new Guid("cc37720a-7e89-463a-9510-1936e6761d14"),
                    ShaftId = new Guid("cc37720a-7e89-463a-9510-1936e6761d53"),
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
                    Id = new Guid("1eaaba04-80ff-43a6-a746-a74a91c4c3e2"),
                    ProductID = new Guid("cc37720a-7e89-463a-9510-1936e6761d8a"),
                    TipId = new Guid("cc37720a-7e89-463a-9510-1936e6761d24"),
                    ShaftId = new Guid("cc37720a-7e89-463a-9510-1936e6761d53"),
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
                    Id = new Guid("1eaaba04-80ff-43a6-a746-a74a91c4c3e3"),
                    ProductID = new Guid("cc37720a-7e89-463a-9510-1936e6761d8a"),
                    TipId = new Guid("cc37720a-7e89-463a-9510-1936e6761d34"),
                    ShaftId = new Guid("cc37720a-7e89-463a-9510-1936e6761d53"),
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
                    Id = new Guid("1eaaba04-80ff-43a6-a746-a74a91c4c3e4"),
                    ProductID = new Guid("cc37720a-7e89-463a-9510-1936e6761d8a"),
                    TipId = new Guid("cc37720a-7e89-463a-9510-1936e6761d44"),
                    ShaftId = new Guid("cc37720a-7e89-463a-9510-1936e6761d53"),
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
                    Id = new Guid("1eaaba04-80ff-43a6-a746-a74a91c4c3e5"),
                    ProductID = new Guid("cc37720a-7e89-463a-9510-1936e6761d8a"),
                    TipId = new Guid("cc37720a-7e89-463a-9510-1936e6761d54"),
                    ShaftId = new Guid("cc37720a-7e89-463a-9510-1936e6761d53"),
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
                    Id = new Guid("1eaaba04-80ff-43a6-a746-a74a91c4c3e6"),
                    ProductID = new Guid("cc37720a-7e89-463a-9510-1936e6761d8a"),
                    TipId = new Guid("cc37720a-7e89-463a-9510-1936e6761d64"),
                    ShaftId = new Guid("cc37720a-7e89-463a-9510-1936e6761d53"),
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
                    Id = new Guid("1eaaba04-80ff-43a6-a746-a74a91c4c3e7"),
                    ProductID = new Guid("cc37720a-7e89-463a-9510-1936e6761d8a"),
                    TipId = new Guid("cc37720a-7e89-463a-9510-1936e6761d74"),
                    ShaftId = new Guid("cc37720a-7e89-463a-9510-1936e6761d53"),
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
                    Id = new Guid("1eaaba04-80ff-43a6-a746-a74a91c4c3e8"),
                    ProductID = new Guid("cc37720a-7e89-463a-9510-1936e6761d8a"),
                    TipId = new Guid("cc37720a-7e89-463a-9510-1936e6761d84"),
                    ShaftId = new Guid("cc37720a-7e89-463a-9510-1936e6761d53"),
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
                    Id = new Guid("1eaaba04-80ff-43a6-a746-a74a91c4c3e9"),
                    ProductID = new Guid("cc37720a-7e89-463a-9510-1936e6761d8a"),
                    TipId = new Guid("cc37720a-7e89-463a-9510-1936e6761d94"),
                    ShaftId = new Guid("cc37720a-7e89-463a-9510-1936e6761d53"),
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
                    Id = new Guid("1eaaba04-80ff-43a6-a746-a74a91c5c0e0"),
                    ProductID = new Guid("cc37720a-7e89-463a-9510-1936e6761d8a"),
                    TipId = new Guid("cc37720a-7e89-463a-9510-1936e6761d04"),
                    ShaftId = new Guid("cc37720a-7e89-463a-9510-1936e6761d83"),
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
                    Id = new Guid("1eaaba04-80ff-43a6-a746-a74a91c5c0e1"),
                    ProductID = new Guid("cc37720a-7e89-463a-9510-1936e6761d8a"),
                    TipId = new Guid("cc37720a-7e89-463a-9510-1936e6761d14"),
                    ShaftId = new Guid("cc37720a-7e89-463a-9510-1936e6761d83"),
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
                    Id = new Guid("1eaaba04-80ff-43a6-a746-a74a91c5c0e2"),
                    ProductID = new Guid("cc37720a-7e89-463a-9510-1936e6761d8a"),
                    TipId = new Guid("cc37720a-7e89-463a-9510-1936e6761d24"),
                    ShaftId = new Guid("cc37720a-7e89-463a-9510-1936e6761d83"),
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
                    Id = new Guid("1eaaba04-80ff-43a6-a746-a74a91c5c0e3"),
                    ProductID = new Guid("cc37720a-7e89-463a-9510-1936e6761d8a"),
                    TipId = new Guid("cc37720a-7e89-463a-9510-1936e6761d34"),
                    ShaftId = new Guid("cc37720a-7e89-463a-9510-1936e6761d83"),
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
                    Id = new Guid("1eaaba04-80ff-43a6-a746-a74a91c5c0e4"),
                    ProductID = new Guid("cc37720a-7e89-463a-9510-1936e6761d8a"),
                    TipId = new Guid("cc37720a-7e89-463a-9510-1936e6761d44"),
                    ShaftId = new Guid("cc37720a-7e89-463a-9510-1936e6761d83"),
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
                    Id = new Guid("1eaaba04-80ff-43a6-a746-a74a91c5c0e5"),
                    ProductID = new Guid("cc37720a-7e89-463a-9510-1936e6761d8a"),
                    TipId = new Guid("cc37720a-7e89-463a-9510-1936e6761d54"),
                    ShaftId = new Guid("cc37720a-7e89-463a-9510-1936e6761d83"),
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
                    Id = new Guid("1eaaba04-80ff-43a6-a746-a74a91c5c0e6"),
                    ProductID = new Guid("cc37720a-7e89-463a-9510-1936e6761d8a"),
                    TipId = new Guid("cc37720a-7e89-463a-9510-1936e6761d64"),
                    ShaftId = new Guid("cc37720a-7e89-463a-9510-1936e6761d83"),
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
                    Id = new Guid("1eaaba04-80ff-43a6-a746-a74a91c5c0e7"),
                    ProductID = new Guid("cc37720a-7e89-463a-9510-1936e6761d8a"),
                    TipId = new Guid("cc37720a-7e89-463a-9510-1936e6761d74"),
                    ShaftId = new Guid("cc37720a-7e89-463a-9510-1936e6761d83"),
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
                    Id = new Guid("1eaaba04-80ff-43a6-a746-a74a91c5c0e8"),
                    ProductID = new Guid("cc37720a-7e89-463a-9510-1936e6761d8a"),
                    TipId = new Guid("cc37720a-7e89-463a-9510-1936e6761d84"),
                    ShaftId = new Guid("cc37720a-7e89-463a-9510-1936e6761d83"),
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
                    Id = new Guid("1eaaba04-80ff-43a6-a746-a74a91c5c0e9"),
                    ProductID = new Guid("cc37720a-7e89-463a-9510-1936e6761d8a"),
                    TipId = new Guid("cc37720a-7e89-463a-9510-1936e6761d94"),
                    ShaftId = new Guid("cc37720a-7e89-463a-9510-1936e6761d83"),
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
                    Id = new Guid("1eaaba04-80ff-43a6-a746-a74a91c5c1e0"),
                    ProductID = new Guid("cc37720a-7e89-463a-9510-1936e6761d8a"),
                    TipId = new Guid("cc37720a-7e89-463a-9510-1936e6761d04"),
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
                    Id = new Guid("1eaaba04-80ff-43a6-a746-a74a91c5c1e1"),
                    ProductID = new Guid("cc37720a-7e89-463a-9510-1936e6761d8a"),
                    TipId = new Guid("cc37720a-7e89-463a-9510-1936e6761d14"),
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
                    Id = new Guid("1eaaba04-80ff-43a6-a746-a74a91c5c1e2"),
                    ProductID = new Guid("cc37720a-7e89-463a-9510-1936e6761d8a"),
                    TipId = new Guid("cc37720a-7e89-463a-9510-1936e6761d24"),
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
                    Id = new Guid("1eaaba04-80ff-43a6-a746-a74a91c5c1e3"),
                    ProductID = new Guid("cc37720a-7e89-463a-9510-1936e6761d8a"),
                    TipId = new Guid("cc37720a-7e89-463a-9510-1936e6761d34"),
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
                    Id = new Guid("1eaaba04-80ff-43a6-a746-a74a91c5c1e4"),
                    ProductID = new Guid("cc37720a-7e89-463a-9510-1936e6761d8a"),
                    TipId = new Guid("cc37720a-7e89-463a-9510-1936e6761d44"),
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
                    Id = new Guid("1eaaba04-80ff-43a6-a746-a74a91c5c1e5"),
                    ProductID = new Guid("cc37720a-7e89-463a-9510-1936e6761d8a"),
                    TipId = new Guid("cc37720a-7e89-463a-9510-1936e6761d54"),
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
                    Id = new Guid("1eaaba04-80ff-43a6-a746-a74a91c5c1e6"),
                    ProductID = new Guid("cc37720a-7e89-463a-9510-1936e6761d8a"),
                    TipId = new Guid("cc37720a-7e89-463a-9510-1936e6761d64"),
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
                    Id = new Guid("1eaaba04-80ff-43a6-a746-a74a91c5c1e7"),
                    ProductID = new Guid("cc37720a-7e89-463a-9510-1936e6761d8a"),
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
                    Id = new Guid("1eaaba04-80ff-43a6-a746-a74a91c5c1e8"),
                    ProductID = new Guid("cc37720a-7e89-463a-9510-1936e6761d8a"),
                    TipId = new Guid("cc37720a-7e89-463a-9510-1936e6761d84"),
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
                    Id = new Guid("1eaaba04-80ff-43a6-a746-a74a91c5c1e9"),
                    ProductID = new Guid("cc37720a-7e89-463a-9510-1936e6761d8a"),
                    TipId = new Guid("cc37720a-7e89-463a-9510-1936e6761d94"),
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
                    Id = new Guid("1eaaba04-80ff-43a6-a746-a74a91c5c2e0"),
                    ProductID = new Guid("cc37720a-7e89-463a-9510-1936e6761d8a"),
                    TipId = new Guid("cc37720a-7e89-463a-9510-1936e6761d04"),
                    ShaftId = new Guid("cc37720a-7e89-463a-9510-1936e6761d63"),
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
                    Id = new Guid("1eaaba04-80ff-43a6-a746-a74a91c5c2e1"),
                    ProductID = new Guid("cc37720a-7e89-463a-9510-1936e6761d8a"),
                    TipId = new Guid("cc37720a-7e89-463a-9510-1936e6761d14"),
                    ShaftId = new Guid("cc37720a-7e89-463a-9510-1936e6761d63"),
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
                    Id = new Guid("1eaaba04-80ff-43a6-a746-a74a91c5c2e2"),
                    ProductID = new Guid("cc37720a-7e89-463a-9510-1936e6761d8a"),
                    TipId = new Guid("cc37720a-7e89-463a-9510-1936e6761d24"),
                    ShaftId = new Guid("cc37720a-7e89-463a-9510-1936e6761d63"),
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
                    Id = new Guid("1eaaba04-80ff-43a6-a746-a74a91c5c2e3"),
                    ProductID = new Guid("cc37720a-7e89-463a-9510-1936e6761d8a"),
                    TipId = new Guid("cc37720a-7e89-463a-9510-1936e6761d34"),
                    ShaftId = new Guid("cc37720a-7e89-463a-9510-1936e6761d63"),
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
                    Id = new Guid("1eaaba04-80ff-43a6-a746-a74a91c5c2e4"),
                    ProductID = new Guid("cc37720a-7e89-463a-9510-1936e6761d8a"),
                    TipId = new Guid("cc37720a-7e89-463a-9510-1936e6761d44"),
                    ShaftId = new Guid("cc37720a-7e89-463a-9510-1936e6761d63"),
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
                    Id = new Guid("1eaaba04-80ff-43a6-a746-a74a91c5c2e5"),
                    ProductID = new Guid("cc37720a-7e89-463a-9510-1936e6761d8a"),
                    TipId = new Guid("cc37720a-7e89-463a-9510-1936e6761d54"),
                    ShaftId = new Guid("cc37720a-7e89-463a-9510-1936e6761d63"),
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
                    Id = new Guid("1eaaba04-80ff-43a6-a746-a74a91c5c2e6"),
                    ProductID = new Guid("cc37720a-7e89-463a-9510-1936e6761d8a"),
                    TipId = new Guid("cc37720a-7e89-463a-9510-1936e6761d64"),
                    ShaftId = new Guid("cc37720a-7e89-463a-9510-1936e6761d63"),
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
                    Id = new Guid("1eaaba04-80ff-43a6-a746-a74a91c5c2e7"),
                    ProductID = new Guid("cc37720a-7e89-463a-9510-1936e6761d8a"),
                    TipId = new Guid("cc37720a-7e89-463a-9510-1936e6761d74"),
                    ShaftId = new Guid("cc37720a-7e89-463a-9510-1936e6761d63"),
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
                    Id = new Guid("1eaaba04-80ff-43a6-a746-a74a91c5c2e8"),
                    ProductID = new Guid("cc37720a-7e89-463a-9510-1936e6761d8a"),
                    TipId = new Guid("cc37720a-7e89-463a-9510-1936e6761d84"),
                    ShaftId = new Guid("cc37720a-7e89-463a-9510-1936e6761d63"),
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
                    Id = new Guid("1eaaba04-80ff-43a6-a746-a74a91c5c2e9"),
                    ProductID = new Guid("cc37720a-7e89-463a-9510-1936e6761d8a"),
                    TipId = new Guid("cc37720a-7e89-463a-9510-1936e6761d94"),
                    ShaftId = new Guid("cc37720a-7e89-463a-9510-1936e6761d63"),
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
                    Id = new Guid("1eaaba04-80ff-43a6-a746-a74a91c5c3e0"),
                    ProductID = new Guid("cc37720a-7e89-463a-9510-1936e6761d8a"),
                    TipId = new Guid("cc37720a-7e89-463a-9510-1936e6761d04"),
                    ShaftId = new Guid("cc37720a-7e89-463a-9510-1936e6761d53"),
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
                    Id = new Guid("1eaaba04-80ff-43a6-a746-a74a91c5c3e1"),
                    ProductID = new Guid("cc37720a-7e89-463a-9510-1936e6761d8a"),
                    TipId = new Guid("cc37720a-7e89-463a-9510-1936e6761d14"),
                    ShaftId = new Guid("cc37720a-7e89-463a-9510-1936e6761d53"),
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
                    Id = new Guid("1eaaba04-80ff-43a6-a746-a74a91c5c3e2"),
                    ProductID = new Guid("cc37720a-7e89-463a-9510-1936e6761d8a"),
                    TipId = new Guid("cc37720a-7e89-463a-9510-1936e6761d24"),
                    ShaftId = new Guid("cc37720a-7e89-463a-9510-1936e6761d53"),
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
                    Id = new Guid("1eaaba04-80ff-43a6-a746-a74a91c5c3e3"),
                    ProductID = new Guid("cc37720a-7e89-463a-9510-1936e6761d8a"),
                    TipId = new Guid("cc37720a-7e89-463a-9510-1936e6761d34"),
                    ShaftId = new Guid("cc37720a-7e89-463a-9510-1936e6761d53"),
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
                    Id = new Guid("1eaaba04-80ff-43a6-a746-a74a91c5c3e4"),
                    ProductID = new Guid("cc37720a-7e89-463a-9510-1936e6761d8a"),
                    TipId = new Guid("cc37720a-7e89-463a-9510-1936e6761d44"),
                    ShaftId = new Guid("cc37720a-7e89-463a-9510-1936e6761d53"),
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
                    Id = new Guid("1eaaba04-80ff-43a6-a746-a74a91c5c3e5"),
                    ProductID = new Guid("cc37720a-7e89-463a-9510-1936e6761d8a"),
                    TipId = new Guid("cc37720a-7e89-463a-9510-1936e6761d54"),
                    ShaftId = new Guid("cc37720a-7e89-463a-9510-1936e6761d53"),
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
                    Id = new Guid("1eaaba04-80ff-43a6-a746-a74a91c5c3e6"),
                    ProductID = new Guid("cc37720a-7e89-463a-9510-1936e6761d8a"),
                    TipId = new Guid("cc37720a-7e89-463a-9510-1936e6761d64"),
                    ShaftId = new Guid("cc37720a-7e89-463a-9510-1936e6761d53"),
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
                    Id = new Guid("1eaaba04-80ff-43a6-a746-a74a91c5c3e7"),
                    ProductID = new Guid("cc37720a-7e89-463a-9510-1936e6761d8a"),
                    TipId = new Guid("cc37720a-7e89-463a-9510-1936e6761d74"),
                    ShaftId = new Guid("cc37720a-7e89-463a-9510-1936e6761d53"),
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
                    Id = new Guid("1eaaba04-80ff-43a6-a746-a74a91c5c3e8"),
                    ProductID = new Guid("cc37720a-7e89-463a-9510-1936e6761d8a"),
                    TipId = new Guid("cc37720a-7e89-463a-9510-1936e6761d84"),
                    ShaftId = new Guid("cc37720a-7e89-463a-9510-1936e6761d53"),
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
                    Id = new Guid("1eaaba04-80ff-43a6-a746-a74a91c5c3e9"),
                    ProductID = new Guid("cc37720a-7e89-463a-9510-1936e6761d8a"),
                    TipId = new Guid("cc37720a-7e89-463a-9510-1936e6761d94"),
                    ShaftId = new Guid("cc37720a-7e89-463a-9510-1936e6761d53"),
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
                    Id = new Guid("1eaaba04-80ff-43a6-a746-a74a91c6c0e0"),
                    ProductID = new Guid("cc37720a-7e89-463a-9510-1936e6761d8a"),
                    TipId = new Guid("cc37720a-7e89-463a-9510-1936e6761d04"),
                    ShaftId = new Guid("cc37720a-7e89-463a-9510-1936e6761d83"),
                    WeightId = new Guid("cc37720a-7e89-463a-9510-1936e6761d65"),
                    Quantity = 1,
                    ImportPrice = 1500,
                    Price = 2000,
                    CreateDate = new DateTime(2023, 09, 12),
                    Status = 0,
                    Description = "Description",
                },
                new ProductDetail()
                {
                    Id = new Guid("1eaaba04-80ff-43a6-a746-a74a91c6c0e1"),
                    ProductID = new Guid("cc37720a-7e89-463a-9510-1936e6761d8a"),
                    TipId = new Guid("cc37720a-7e89-463a-9510-1936e6761d14"),
                    ShaftId = new Guid("cc37720a-7e89-463a-9510-1936e6761d83"),
                    WeightId = new Guid("cc37720a-7e89-463a-9510-1936e6761d65"),
                    Quantity = 1,
                    ImportPrice = 1500,
                    Price = 2000,
                    CreateDate = new DateTime(2023, 09, 12),
                    Status = 0,
                    Description = "Description",
                },
                new ProductDetail()
                {
                    Id = new Guid("1eaaba04-80ff-43a6-a746-a74a91c6c0e2"),
                    ProductID = new Guid("cc37720a-7e89-463a-9510-1936e6761d8a"),
                    TipId = new Guid("cc37720a-7e89-463a-9510-1936e6761d24"),
                    ShaftId = new Guid("cc37720a-7e89-463a-9510-1936e6761d83"),
                    WeightId = new Guid("cc37720a-7e89-463a-9510-1936e6761d65"),
                    Quantity = 1,
                    ImportPrice = 1500,
                    Price = 2000,
                    CreateDate = new DateTime(2023, 09, 12),
                    Status = 0,
                    Description = "Description",
                },
                new ProductDetail()
                {
                    Id = new Guid("1eaaba04-80ff-43a6-a746-a74a91c6c0e3"),
                    ProductID = new Guid("cc37720a-7e89-463a-9510-1936e6761d8a"),
                    TipId = new Guid("cc37720a-7e89-463a-9510-1936e6761d34"),
                    ShaftId = new Guid("cc37720a-7e89-463a-9510-1936e6761d83"),
                    WeightId = new Guid("cc37720a-7e89-463a-9510-1936e6761d65"),
                    Quantity = 1,
                    ImportPrice = 1500,
                    Price = 2000,
                    CreateDate = new DateTime(2023, 09, 12),
                    Status = 0,
                    Description = "Description",
                },
                new ProductDetail()
                {
                    Id = new Guid("1eaaba04-80ff-43a6-a746-a74a91c6c0e4"),
                    ProductID = new Guid("cc37720a-7e89-463a-9510-1936e6761d8a"),
                    TipId = new Guid("cc37720a-7e89-463a-9510-1936e6761d44"),
                    ShaftId = new Guid("cc37720a-7e89-463a-9510-1936e6761d83"),
                    WeightId = new Guid("cc37720a-7e89-463a-9510-1936e6761d65"),
                    Quantity = 1,
                    ImportPrice = 1500,
                    Price = 2000,
                    CreateDate = new DateTime(2023, 09, 12),
                    Status = 0,
                    Description = "Description",
                },
                new ProductDetail()
                {
                    Id = new Guid("1eaaba04-80ff-43a6-a746-a74a91c6c0e5"),
                    ProductID = new Guid("cc37720a-7e89-463a-9510-1936e6761d8a"),
                    TipId = new Guid("cc37720a-7e89-463a-9510-1936e6761d54"),
                    ShaftId = new Guid("cc37720a-7e89-463a-9510-1936e6761d83"),
                    WeightId = new Guid("cc37720a-7e89-463a-9510-1936e6761d65"),
                    Quantity = 1,
                    ImportPrice = 1500,
                    Price = 2000,
                    CreateDate = new DateTime(2023, 09, 12),
                    Status = 0,
                    Description = "Description",
                },
                new ProductDetail()
                {
                    Id = new Guid("1eaaba04-80ff-43a6-a746-a74a91c6c0e6"),
                    ProductID = new Guid("cc37720a-7e89-463a-9510-1936e6761d8a"),
                    TipId = new Guid("cc37720a-7e89-463a-9510-1936e6761d64"),
                    ShaftId = new Guid("cc37720a-7e89-463a-9510-1936e6761d83"),
                    WeightId = new Guid("cc37720a-7e89-463a-9510-1936e6761d65"),
                    Quantity = 1,
                    ImportPrice = 1500,
                    Price = 2000,
                    CreateDate = new DateTime(2023, 09, 12),
                    Status = 0,
                    Description = "Description",
                },
                new ProductDetail()
                {
                    Id = new Guid("1eaaba04-80ff-43a6-a746-a74a91c6c0e7"),
                    ProductID = new Guid("cc37720a-7e89-463a-9510-1936e6761d8a"),
                    TipId = new Guid("cc37720a-7e89-463a-9510-1936e6761d74"),
                    ShaftId = new Guid("cc37720a-7e89-463a-9510-1936e6761d83"),
                    WeightId = new Guid("cc37720a-7e89-463a-9510-1936e6761d65"),
                    Quantity = 1,
                    ImportPrice = 1500,
                    Price = 2000,
                    CreateDate = new DateTime(2023, 09, 12),
                    Status = 0,
                    Description = "Description",
                },
                new ProductDetail()
                {
                    Id = new Guid("1eaaba04-80ff-43a6-a746-a74a91c6c0e8"),
                    ProductID = new Guid("cc37720a-7e89-463a-9510-1936e6761d8a"),
                    TipId = new Guid("cc37720a-7e89-463a-9510-1936e6761d84"),
                    ShaftId = new Guid("cc37720a-7e89-463a-9510-1936e6761d83"),
                    WeightId = new Guid("cc37720a-7e89-463a-9510-1936e6761d65"),
                    Quantity = 1,
                    ImportPrice = 1500,
                    Price = 2000,
                    CreateDate = new DateTime(2023, 09, 12),
                    Status = 0,
                    Description = "Description",
                },
                new ProductDetail()
                {
                    Id = new Guid("1eaaba04-80ff-43a6-a746-a74a91c6c0e9"),
                    ProductID = new Guid("cc37720a-7e89-463a-9510-1936e6761d8a"),
                    TipId = new Guid("cc37720a-7e89-463a-9510-1936e6761d94"),
                    ShaftId = new Guid("cc37720a-7e89-463a-9510-1936e6761d83"),
                    WeightId = new Guid("cc37720a-7e89-463a-9510-1936e6761d65"),
                    Quantity = 1,
                    ImportPrice = 1500,
                    Price = 2000,
                    CreateDate = new DateTime(2023, 09, 12),
                    Status = 0,
                    Description = "Description",
                },
                new ProductDetail()
                {
                    Id = new Guid("1eaaba04-80ff-43a6-a746-a74a91c6c1e0"),
                    ProductID = new Guid("cc37720a-7e89-463a-9510-1936e6761d8a"),
                    TipId = new Guid("cc37720a-7e89-463a-9510-1936e6761d04"),
                    ShaftId = new Guid("cc37720a-7e89-463a-9510-1936e6761d73"),
                    WeightId = new Guid("cc37720a-7e89-463a-9510-1936e6761d65"),
                    Quantity = 1,
                    ImportPrice = 1500,
                    Price = 2000,
                    CreateDate = new DateTime(2023, 09, 12),
                    Status = 0,
                    Description = "Description",
                },
                new ProductDetail()
                {
                    Id = new Guid("1eaaba04-80ff-43a6-a746-a74a91c6c1e1"),
                    ProductID = new Guid("cc37720a-7e89-463a-9510-1936e6761d8a"),
                    TipId = new Guid("cc37720a-7e89-463a-9510-1936e6761d14"),
                    ShaftId = new Guid("cc37720a-7e89-463a-9510-1936e6761d73"),
                    WeightId = new Guid("cc37720a-7e89-463a-9510-1936e6761d65"),
                    Quantity = 1,
                    ImportPrice = 1500,
                    Price = 2000,
                    CreateDate = new DateTime(2023, 09, 12),
                    Status = 0,
                    Description = "Description",
                },
                new ProductDetail()
                {
                    Id = new Guid("1eaaba04-80ff-43a6-a746-a74a91c6c1e2"),
                    ProductID = new Guid("cc37720a-7e89-463a-9510-1936e6761d8a"),
                    TipId = new Guid("cc37720a-7e89-463a-9510-1936e6761d24"),
                    ShaftId = new Guid("cc37720a-7e89-463a-9510-1936e6761d73"),
                    WeightId = new Guid("cc37720a-7e89-463a-9510-1936e6761d65"),
                    Quantity = 1,
                    ImportPrice = 1500,
                    Price = 2000,
                    CreateDate = new DateTime(2023, 09, 12),
                    Status = 0,
                    Description = "Description",
                },
                new ProductDetail()
                {
                    Id = new Guid("1eaaba04-80ff-43a6-a746-a74a91c6c1e3"),
                    ProductID = new Guid("cc37720a-7e89-463a-9510-1936e6761d8a"),
                    TipId = new Guid("cc37720a-7e89-463a-9510-1936e6761d34"),
                    ShaftId = new Guid("cc37720a-7e89-463a-9510-1936e6761d73"),
                    WeightId = new Guid("cc37720a-7e89-463a-9510-1936e6761d65"),
                    Quantity = 1,
                    ImportPrice = 1500,
                    Price = 2000,
                    CreateDate = new DateTime(2023, 09, 12),
                    Status = 0,
                    Description = "Description",
                },
                new ProductDetail()
                {
                    Id = new Guid("1eaaba04-80ff-43a6-a746-a74a91c6c1e4"),
                    ProductID = new Guid("cc37720a-7e89-463a-9510-1936e6761d8a"),
                    TipId = new Guid("cc37720a-7e89-463a-9510-1936e6761d44"),
                    ShaftId = new Guid("cc37720a-7e89-463a-9510-1936e6761d73"),
                    WeightId = new Guid("cc37720a-7e89-463a-9510-1936e6761d65"),
                    Quantity = 1,
                    ImportPrice = 1500,
                    Price = 2000,
                    CreateDate = new DateTime(2023, 09, 12),
                    Status = 0,
                    Description = "Description",
                },
                new ProductDetail()
                {
                    Id = new Guid("1eaaba04-80ff-43a6-a746-a74a91c6c1e5"),
                    ProductID = new Guid("cc37720a-7e89-463a-9510-1936e6761d8a"),
                    TipId = new Guid("cc37720a-7e89-463a-9510-1936e6761d54"),
                    ShaftId = new Guid("cc37720a-7e89-463a-9510-1936e6761d73"),
                    WeightId = new Guid("cc37720a-7e89-463a-9510-1936e6761d65"),
                    Quantity = 1,
                    ImportPrice = 1500,
                    Price = 2000,
                    CreateDate = new DateTime(2023, 09, 12),
                    Status = 0,
                    Description = "Description",
                },
                new ProductDetail()
                {
                    Id = new Guid("1eaaba04-80ff-43a6-a746-a74a91c6c1e6"),
                    ProductID = new Guid("cc37720a-7e89-463a-9510-1936e6761d8a"),
                    TipId = new Guid("cc37720a-7e89-463a-9510-1936e6761d64"),
                    ShaftId = new Guid("cc37720a-7e89-463a-9510-1936e6761d73"),
                    WeightId = new Guid("cc37720a-7e89-463a-9510-1936e6761d65"),
                    Quantity = 1,
                    ImportPrice = 1500,
                    Price = 2000,
                    CreateDate = new DateTime(2023, 09, 12),
                    Status = 0,
                    Description = "Description",
                },
                new ProductDetail()
                {
                    Id = new Guid("1eaaba04-80ff-43a6-a746-a74a91c6c1e7"),
                    ProductID = new Guid("cc37720a-7e89-463a-9510-1936e6761d8a"),
                    TipId = new Guid("cc37720a-7e89-463a-9510-1936e6761d74"),
                    ShaftId = new Guid("cc37720a-7e89-463a-9510-1936e6761d73"),
                    WeightId = new Guid("cc37720a-7e89-463a-9510-1936e6761d65"),
                    Quantity = 1,
                    ImportPrice = 1500,
                    Price = 2000,
                    CreateDate = new DateTime(2023, 09, 12),
                    Status = 0,
                    Description = "Description",
                },
                new ProductDetail()
                {
                    Id = new Guid("1eaaba04-80ff-43a6-a746-a74a91c6c1e8"),
                    ProductID = new Guid("cc37720a-7e89-463a-9510-1936e6761d8a"),
                    TipId = new Guid("cc37720a-7e89-463a-9510-1936e6761d84"),
                    ShaftId = new Guid("cc37720a-7e89-463a-9510-1936e6761d73"),
                    WeightId = new Guid("cc37720a-7e89-463a-9510-1936e6761d65"),
                    Quantity = 1,
                    ImportPrice = 1500,
                    Price = 2000,
                    CreateDate = new DateTime(2023, 09, 12),
                    Status = 0,
                    Description = "Description",
                },
                new ProductDetail()
                {
                    Id = new Guid("1eaaba04-80ff-43a6-a746-a74a91c6c1e9"),
                    ProductID = new Guid("cc37720a-7e89-463a-9510-1936e6761d8a"),
                    TipId = new Guid("cc37720a-7e89-463a-9510-1936e6761d94"),
                    ShaftId = new Guid("cc37720a-7e89-463a-9510-1936e6761d73"),
                    WeightId = new Guid("cc37720a-7e89-463a-9510-1936e6761d65"),
                    Quantity = 1,
                    ImportPrice = 1500,
                    Price = 2000,
                    CreateDate = new DateTime(2023, 09, 12),
                    Status = 0,
                    Description = "Description",
                },
                new ProductDetail()
                {
                    Id = new Guid("1eaaba04-80ff-43a6-a746-a74a91c6c2e0"),
                    ProductID = new Guid("cc37720a-7e89-463a-9510-1936e6761d8a"),
                    TipId = new Guid("cc37720a-7e89-463a-9510-1936e6761d04"),
                    ShaftId = new Guid("cc37720a-7e89-463a-9510-1936e6761d63"),
                    WeightId = new Guid("cc37720a-7e89-463a-9510-1936e6761d65"),
                    Quantity = 1,
                    ImportPrice = 1500,
                    Price = 2000,
                    CreateDate = new DateTime(2023, 09, 12),
                    Status = 0,
                    Description = "Description",
                },
                new ProductDetail()
                {
                    Id = new Guid("1eaaba04-80ff-43a6-a746-a74a91c6c2e1"),
                    ProductID = new Guid("cc37720a-7e89-463a-9510-1936e6761d8a"),
                    TipId = new Guid("cc37720a-7e89-463a-9510-1936e6761d14"),
                    ShaftId = new Guid("cc37720a-7e89-463a-9510-1936e6761d63"),
                    WeightId = new Guid("cc37720a-7e89-463a-9510-1936e6761d65"),
                    Quantity = 1,
                    ImportPrice = 1500,
                    Price = 2000,
                    CreateDate = new DateTime(2023, 09, 12),
                    Status = 0,
                    Description = "Description",
                },
                new ProductDetail()
                {
                    Id = new Guid("1eaaba04-80ff-43a6-a746-a74a91c6c2e2"),
                    ProductID = new Guid("cc37720a-7e89-463a-9510-1936e6761d8a"),
                    TipId = new Guid("cc37720a-7e89-463a-9510-1936e6761d24"),
                    ShaftId = new Guid("cc37720a-7e89-463a-9510-1936e6761d63"),
                    WeightId = new Guid("cc37720a-7e89-463a-9510-1936e6761d65"),
                    Quantity = 1,
                    ImportPrice = 1500,
                    Price = 2000,
                    CreateDate = new DateTime(2023, 09, 12),
                    Status = 0,
                    Description = "Description",
                },
                new ProductDetail()
                {
                    Id = new Guid("1eaaba04-80ff-43a6-a746-a74a91c6c2e3"),
                    ProductID = new Guid("cc37720a-7e89-463a-9510-1936e6761d8a"),
                    TipId = new Guid("cc37720a-7e89-463a-9510-1936e6761d34"),
                    ShaftId = new Guid("cc37720a-7e89-463a-9510-1936e6761d63"),
                    WeightId = new Guid("cc37720a-7e89-463a-9510-1936e6761d65"),
                    Quantity = 1,
                    ImportPrice = 1500,
                    Price = 2000,
                    CreateDate = new DateTime(2023, 09, 12),
                    Status = 0,
                    Description = "Description",
                },
                new ProductDetail()
                {
                    Id = new Guid("1eaaba04-80ff-43a6-a746-a74a91c6c2e4"),
                    ProductID = new Guid("cc37720a-7e89-463a-9510-1936e6761d8a"),
                    TipId = new Guid("cc37720a-7e89-463a-9510-1936e6761d44"),
                    ShaftId = new Guid("cc37720a-7e89-463a-9510-1936e6761d63"),
                    WeightId = new Guid("cc37720a-7e89-463a-9510-1936e6761d65"),
                    Quantity = 1,
                    ImportPrice = 1500,
                    Price = 2000,
                    CreateDate = new DateTime(2023, 09, 12),
                    Status = 0,
                    Description = "Description",
                },
                new ProductDetail()
                {
                    Id = new Guid("1eaaba04-80ff-43a6-a746-a74a91c6c2e5"),
                    ProductID = new Guid("cc37720a-7e89-463a-9510-1936e6761d8a"),
                    TipId = new Guid("cc37720a-7e89-463a-9510-1936e6761d54"),
                    ShaftId = new Guid("cc37720a-7e89-463a-9510-1936e6761d63"),
                    WeightId = new Guid("cc37720a-7e89-463a-9510-1936e6761d65"),
                    Quantity = 1,
                    ImportPrice = 1500,
                    Price = 2000,
                    CreateDate = new DateTime(2023, 09, 12),
                    Status = 0,
                    Description = "Description",
                },
                new ProductDetail()
                {
                    Id = new Guid("1eaaba04-80ff-43a6-a746-a74a91c6c2e6"),
                    ProductID = new Guid("cc37720a-7e89-463a-9510-1936e6761d8a"),
                    TipId = new Guid("cc37720a-7e89-463a-9510-1936e6761d64"),
                    ShaftId = new Guid("cc37720a-7e89-463a-9510-1936e6761d63"),
                    WeightId = new Guid("cc37720a-7e89-463a-9510-1936e6761d65"),
                    Quantity = 1,
                    ImportPrice = 1500,
                    Price = 2000,
                    CreateDate = new DateTime(2023, 09, 12),
                    Status = 0,
                    Description = "Description",
                },
                new ProductDetail()
                {
                    Id = new Guid("1eaaba04-80ff-43a6-a746-a74a91c6c2e7"),
                    ProductID = new Guid("cc37720a-7e89-463a-9510-1936e6761d8a"),
                    TipId = new Guid("cc37720a-7e89-463a-9510-1936e6761d74"),
                    ShaftId = new Guid("cc37720a-7e89-463a-9510-1936e6761d63"),
                    WeightId = new Guid("cc37720a-7e89-463a-9510-1936e6761d65"),
                    Quantity = 1,
                    ImportPrice = 1500,
                    Price = 2000,
                    CreateDate = new DateTime(2023, 09, 12),
                    Status = 0,
                    Description = "Description",
                },
                new ProductDetail()
                {
                    Id = new Guid("1eaaba04-80ff-43a6-a746-a74a91c6c2e8"),
                    ProductID = new Guid("cc37720a-7e89-463a-9510-1936e6761d8a"),
                    TipId = new Guid("cc37720a-7e89-463a-9510-1936e6761d84"),
                    ShaftId = new Guid("cc37720a-7e89-463a-9510-1936e6761d63"),
                    WeightId = new Guid("cc37720a-7e89-463a-9510-1936e6761d65"),
                    Quantity = 1,
                    ImportPrice = 1500,
                    Price = 2000,
                    CreateDate = new DateTime(2023, 09, 12),
                    Status = 0,
                    Description = "Description",
                },
                new ProductDetail()
                {
                    Id = new Guid("1eaaba04-80ff-43a6-a746-a74a91c6c2e9"),
                    ProductID = new Guid("cc37720a-7e89-463a-9510-1936e6761d8a"),
                    TipId = new Guid("cc37720a-7e89-463a-9510-1936e6761d94"),
                    ShaftId = new Guid("cc37720a-7e89-463a-9510-1936e6761d63"),
                    WeightId = new Guid("cc37720a-7e89-463a-9510-1936e6761d65"),
                    Quantity = 1,
                    ImportPrice = 1500,
                    Price = 2000,
                    CreateDate = new DateTime(2023, 09, 12),
                    Status = 0,
                    Description = "Description",
                },
                new ProductDetail()
                {
                    Id = new Guid("1eaaba04-80ff-43a6-a746-a74a91c6c3e0"),
                    ProductID = new Guid("cc37720a-7e89-463a-9510-1936e6761d8a"),
                    TipId = new Guid("cc37720a-7e89-463a-9510-1936e6761d04"),
                    ShaftId = new Guid("cc37720a-7e89-463a-9510-1936e6761d53"),
                    WeightId = new Guid("cc37720a-7e89-463a-9510-1936e6761d65"),
                    Quantity = 1,
                    ImportPrice = 1500,
                    Price = 2000,
                    CreateDate = new DateTime(2023, 09, 12),
                    Status = 0,
                    Description = "Description",
                },
                new ProductDetail()
                {
                    Id = new Guid("1eaaba04-80ff-43a6-a746-a74a91c6c3e1"),
                    ProductID = new Guid("cc37720a-7e89-463a-9510-1936e6761d8a"),
                    TipId = new Guid("cc37720a-7e89-463a-9510-1936e6761d14"),
                    ShaftId = new Guid("cc37720a-7e89-463a-9510-1936e6761d53"),
                    WeightId = new Guid("cc37720a-7e89-463a-9510-1936e6761d65"),
                    Quantity = 1,
                    ImportPrice = 1500,
                    Price = 2000,
                    CreateDate = new DateTime(2023, 09, 12),
                    Status = 0,
                    Description = "Description",
                },
                new ProductDetail()
                {
                    Id = new Guid("1eaaba04-80ff-43a6-a746-a74a91c6c3e2"),
                    ProductID = new Guid("cc37720a-7e89-463a-9510-1936e6761d8a"),
                    TipId = new Guid("cc37720a-7e89-463a-9510-1936e6761d24"),
                    ShaftId = new Guid("cc37720a-7e89-463a-9510-1936e6761d53"),
                    WeightId = new Guid("cc37720a-7e89-463a-9510-1936e6761d65"),
                    Quantity = 1,
                    ImportPrice = 1500,
                    Price = 2000,
                    CreateDate = new DateTime(2023, 09, 12),
                    Status = 0,
                    Description = "Description",
                },
                new ProductDetail()
                {
                    Id = new Guid("1eaaba04-80ff-43a6-a746-a74a91c6c3e3"),
                    ProductID = new Guid("cc37720a-7e89-463a-9510-1936e6761d8a"),
                    TipId = new Guid("cc37720a-7e89-463a-9510-1936e6761d34"),
                    ShaftId = new Guid("cc37720a-7e89-463a-9510-1936e6761d53"),
                    WeightId = new Guid("cc37720a-7e89-463a-9510-1936e6761d65"),
                    Quantity = 1,
                    ImportPrice = 1500,
                    Price = 2000,
                    CreateDate = new DateTime(2023, 09, 12),
                    Status = 0,
                    Description = "Description",
                },
                new ProductDetail()
                {
                    Id = new Guid("1eaaba04-80ff-43a6-a746-a74a91c6c3e4"),
                    ProductID = new Guid("cc37720a-7e89-463a-9510-1936e6761d8a"),
                    TipId = new Guid("cc37720a-7e89-463a-9510-1936e6761d44"),
                    ShaftId = new Guid("cc37720a-7e89-463a-9510-1936e6761d53"),
                    WeightId = new Guid("cc37720a-7e89-463a-9510-1936e6761d65"),
                    Quantity = 1,
                    ImportPrice = 1500,
                    Price = 2000,
                    CreateDate = new DateTime(2023, 09, 12),
                    Status = 0,
                    Description = "Description",
                },
                new ProductDetail()
                {
                    Id = new Guid("1eaaba04-80ff-43a6-a746-a74a91c6c3e5"),
                    ProductID = new Guid("cc37720a-7e89-463a-9510-1936e6761d8a"),
                    TipId = new Guid("cc37720a-7e89-463a-9510-1936e6761d54"),
                    ShaftId = new Guid("cc37720a-7e89-463a-9510-1936e6761d53"),
                    WeightId = new Guid("cc37720a-7e89-463a-9510-1936e6761d65"),
                    Quantity = 1,
                    ImportPrice = 1500,
                    Price = 2000,
                    CreateDate = new DateTime(2023, 09, 12),
                    Status = 0,
                    Description = "Description",
                },
                new ProductDetail()
                {
                    Id = new Guid("1eaaba04-80ff-43a6-a746-a74a91c6c3e6"),
                    ProductID = new Guid("cc37720a-7e89-463a-9510-1936e6761d8a"),
                    TipId = new Guid("cc37720a-7e89-463a-9510-1936e6761d64"),
                    ShaftId = new Guid("cc37720a-7e89-463a-9510-1936e6761d53"),
                    WeightId = new Guid("cc37720a-7e89-463a-9510-1936e6761d65"),
                    Quantity = 1,
                    ImportPrice = 1500,
                    Price = 2000,
                    CreateDate = new DateTime(2023, 09, 12),
                    Status = 0,
                    Description = "Description",
                },
                new ProductDetail()
                {
                    Id = new Guid("1eaaba04-80ff-43a6-a746-a74a91c6c3e7"),
                    ProductID = new Guid("cc37720a-7e89-463a-9510-1936e6761d8a"),
                    TipId = new Guid("cc37720a-7e89-463a-9510-1936e6761d74"),
                    ShaftId = new Guid("cc37720a-7e89-463a-9510-1936e6761d53"),
                    WeightId = new Guid("cc37720a-7e89-463a-9510-1936e6761d65"),
                    Quantity = 1,
                    ImportPrice = 1500,
                    Price = 2000,
                    CreateDate = new DateTime(2023, 09, 12),
                    Status = 0,
                    Description = "Description",
                },
                new ProductDetail()
                {
                    Id = new Guid("1eaaba04-80ff-43a6-a746-a74a91c6c3e8"),
                    ProductID = new Guid("cc37720a-7e89-463a-9510-1936e6761d8a"),
                    TipId = new Guid("cc37720a-7e89-463a-9510-1936e6761d84"),
                    ShaftId = new Guid("cc37720a-7e89-463a-9510-1936e6761d53"),
                    WeightId = new Guid("cc37720a-7e89-463a-9510-1936e6761d65"),
                    Quantity = 1,
                    ImportPrice = 1500,
                    Price = 2000,
                    CreateDate = new DateTime(2023, 09, 12),
                    Status = 0,
                    Description = "Description",
                },
                new ProductDetail()
                {
                    Id = new Guid("1eaaba04-80ff-43a6-a746-a74a91c6c3e9"),
                    ProductID = new Guid("cc37720a-7e89-463a-9510-1936e6761d8a"),
                    TipId = new Guid("cc37720a-7e89-463a-9510-1936e6761d94"),
                    ShaftId = new Guid("cc37720a-7e89-463a-9510-1936e6761d53"),
                    WeightId = new Guid("cc37720a-7e89-463a-9510-1936e6761d65"),
                    Quantity = 1,
                    ImportPrice = 1500,
                    Price = 2000,
                    CreateDate = new DateTime(2023, 09, 12),
                    Status = 0,
                    Description = "Description",
                },
                new ProductDetail()
                {
                    Id = new Guid("1eaaba04-80ff-43a6-a746-a74a91c7c0e0"),
                    ProductID = new Guid("cc37720a-7e89-463a-9510-1936e6761d8a"),
                    TipId = new Guid("cc37720a-7e89-463a-9510-1936e6761d04"),
                    ShaftId = new Guid("cc37720a-7e89-463a-9510-1936e6761d83"),
                    WeightId = new Guid("cc37720a-7e89-463a-9510-1936e6761d55"),
                    Quantity = 1,
                    ImportPrice = 1500,
                    Price = 2000,
                    CreateDate = new DateTime(2023, 09, 12),
                    Status = 0,
                    Description = "Description",
                },
                new ProductDetail()
                {
                    Id = new Guid("1eaaba04-80ff-43a6-a746-a74a91c7c0e1"),
                    ProductID = new Guid("cc37720a-7e89-463a-9510-1936e6761d8a"),
                    TipId = new Guid("cc37720a-7e89-463a-9510-1936e6761d14"),
                    ShaftId = new Guid("cc37720a-7e89-463a-9510-1936e6761d83"),
                    WeightId = new Guid("cc37720a-7e89-463a-9510-1936e6761d55"),
                    Quantity = 1,
                    ImportPrice = 1500,
                    Price = 2000,
                    CreateDate = new DateTime(2023, 09, 12),
                    Status = 0,
                    Description = "Description",
                },
                new ProductDetail()
                {
                    Id = new Guid("1eaaba04-80ff-43a6-a746-a74a91c7c0e2"),
                    ProductID = new Guid("cc37720a-7e89-463a-9510-1936e6761d8a"),
                    TipId = new Guid("cc37720a-7e89-463a-9510-1936e6761d24"),
                    ShaftId = new Guid("cc37720a-7e89-463a-9510-1936e6761d83"),
                    WeightId = new Guid("cc37720a-7e89-463a-9510-1936e6761d55"),
                    Quantity = 1,
                    ImportPrice = 1500,
                    Price = 2000,
                    CreateDate = new DateTime(2023, 09, 12),
                    Status = 0,
                    Description = "Description",
                },
                new ProductDetail()
                {
                    Id = new Guid("1eaaba04-80ff-43a6-a746-a74a91c7c0e3"),
                    ProductID = new Guid("cc37720a-7e89-463a-9510-1936e6761d8a"),
                    TipId = new Guid("cc37720a-7e89-463a-9510-1936e6761d34"),
                    ShaftId = new Guid("cc37720a-7e89-463a-9510-1936e6761d83"),
                    WeightId = new Guid("cc37720a-7e89-463a-9510-1936e6761d55"),
                    Quantity = 1,
                    ImportPrice = 1500,
                    Price = 2000,
                    CreateDate = new DateTime(2023, 09, 12),
                    Status = 0,
                    Description = "Description",
                },
                new ProductDetail()
                {
                    Id = new Guid("1eaaba04-80ff-43a6-a746-a74a91c7c0e4"),
                    ProductID = new Guid("cc37720a-7e89-463a-9510-1936e6761d8a"),
                    TipId = new Guid("cc37720a-7e89-463a-9510-1936e6761d44"),
                    ShaftId = new Guid("cc37720a-7e89-463a-9510-1936e6761d83"),
                    WeightId = new Guid("cc37720a-7e89-463a-9510-1936e6761d55"),
                    Quantity = 1,
                    ImportPrice = 1500,
                    Price = 2000,
                    CreateDate = new DateTime(2023, 09, 12),
                    Status = 0,
                    Description = "Description",
                },
                new ProductDetail()
                {
                    Id = new Guid("1eaaba04-80ff-43a6-a746-a74a91c7c0e5"),
                    ProductID = new Guid("cc37720a-7e89-463a-9510-1936e6761d8a"),
                    TipId = new Guid("cc37720a-7e89-463a-9510-1936e6761d54"),
                    ShaftId = new Guid("cc37720a-7e89-463a-9510-1936e6761d83"),
                    WeightId = new Guid("cc37720a-7e89-463a-9510-1936e6761d55"),
                    Quantity = 1,
                    ImportPrice = 1500,
                    Price = 2000,
                    CreateDate = new DateTime(2023, 09, 12),
                    Status = 0,
                    Description = "Description",
                },
                new ProductDetail()
                {
                    Id = new Guid("1eaaba04-80ff-43a6-a746-a74a91c7c0e6"),
                    ProductID = new Guid("cc37720a-7e89-463a-9510-1936e6761d8a"),
                    TipId = new Guid("cc37720a-7e89-463a-9510-1936e6761d64"),
                    ShaftId = new Guid("cc37720a-7e89-463a-9510-1936e6761d83"),
                    WeightId = new Guid("cc37720a-7e89-463a-9510-1936e6761d55"),
                    Quantity = 1,
                    ImportPrice = 1500,
                    Price = 2000,
                    CreateDate = new DateTime(2023, 09, 12),
                    Status = 0,
                    Description = "Description",
                },
                new ProductDetail()
                {
                    Id = new Guid("1eaaba04-80ff-43a6-a746-a74a91c7c0e7"),
                    ProductID = new Guid("cc37720a-7e89-463a-9510-1936e6761d8a"),
                    TipId = new Guid("cc37720a-7e89-463a-9510-1936e6761d74"),
                    ShaftId = new Guid("cc37720a-7e89-463a-9510-1936e6761d83"),
                    WeightId = new Guid("cc37720a-7e89-463a-9510-1936e6761d55"),
                    Quantity = 1,
                    ImportPrice = 1500,
                    Price = 2000,
                    CreateDate = new DateTime(2023, 09, 12),
                    Status = 0,
                    Description = "Description",
                },
                new ProductDetail()
                {
                    Id = new Guid("1eaaba04-80ff-43a6-a746-a74a91c7c0e8"),
                    ProductID = new Guid("cc37720a-7e89-463a-9510-1936e6761d8a"),
                    TipId = new Guid("cc37720a-7e89-463a-9510-1936e6761d84"),
                    ShaftId = new Guid("cc37720a-7e89-463a-9510-1936e6761d83"),
                    WeightId = new Guid("cc37720a-7e89-463a-9510-1936e6761d55"),
                    Quantity = 1,
                    ImportPrice = 1500,
                    Price = 2000,
                    CreateDate = new DateTime(2023, 09, 12),
                    Status = 0,
                    Description = "Description",
                },
                new ProductDetail()
                {
                    Id = new Guid("1eaaba04-80ff-43a6-a746-a74a91c7c0e9"),
                    ProductID = new Guid("cc37720a-7e89-463a-9510-1936e6761d8a"),
                    TipId = new Guid("cc37720a-7e89-463a-9510-1936e6761d94"),
                    ShaftId = new Guid("cc37720a-7e89-463a-9510-1936e6761d83"),
                    WeightId = new Guid("cc37720a-7e89-463a-9510-1936e6761d55"),
                    Quantity = 1,
                    ImportPrice = 1500,
                    Price = 2000,
                    CreateDate = new DateTime(2023, 09, 12),
                    Status = 0,
                    Description = "Description",
                },
                new ProductDetail()
                {
                    Id = new Guid("1eaaba04-80ff-43a6-a746-a74a91c7c1e0"),
                    ProductID = new Guid("cc37720a-7e89-463a-9510-1936e6761d8a"),
                    TipId = new Guid("cc37720a-7e89-463a-9510-1936e6761d04"),
                    ShaftId = new Guid("cc37720a-7e89-463a-9510-1936e6761d73"),
                    WeightId = new Guid("cc37720a-7e89-463a-9510-1936e6761d55"),
                    Quantity = 1,
                    ImportPrice = 1500,
                    Price = 2000,
                    CreateDate = new DateTime(2023, 09, 12),
                    Status = 0,
                    Description = "Description",
                },
                new ProductDetail()
                {
                    Id = new Guid("1eaaba04-80ff-43a6-a746-a74a91c7c1e1"),
                    ProductID = new Guid("cc37720a-7e89-463a-9510-1936e6761d8a"),
                    TipId = new Guid("cc37720a-7e89-463a-9510-1936e6761d14"),
                    ShaftId = new Guid("cc37720a-7e89-463a-9510-1936e6761d73"),
                    WeightId = new Guid("cc37720a-7e89-463a-9510-1936e6761d55"),
                    Quantity = 1,
                    ImportPrice = 1500,
                    Price = 2000,
                    CreateDate = new DateTime(2023, 09, 12),
                    Status = 0,
                    Description = "Description",
                },
                new ProductDetail()
                {
                    Id = new Guid("1eaaba04-80ff-43a6-a746-a74a91c7c1e2"),
                    ProductID = new Guid("cc37720a-7e89-463a-9510-1936e6761d8a"),
                    TipId = new Guid("cc37720a-7e89-463a-9510-1936e6761d24"),
                    ShaftId = new Guid("cc37720a-7e89-463a-9510-1936e6761d73"),
                    WeightId = new Guid("cc37720a-7e89-463a-9510-1936e6761d55"),
                    Quantity = 1,
                    ImportPrice = 1500,
                    Price = 2000,
                    CreateDate = new DateTime(2023, 09, 12),
                    Status = 0,
                    Description = "Description",
                },
                new ProductDetail()
                {
                    Id = new Guid("1eaaba04-80ff-43a6-a746-a74a91c7c1e3"),
                    ProductID = new Guid("cc37720a-7e89-463a-9510-1936e6761d8a"),
                    TipId = new Guid("cc37720a-7e89-463a-9510-1936e6761d34"),
                    ShaftId = new Guid("cc37720a-7e89-463a-9510-1936e6761d73"),
                    WeightId = new Guid("cc37720a-7e89-463a-9510-1936e6761d55"),
                    Quantity = 1,
                    ImportPrice = 1500,
                    Price = 2000,
                    CreateDate = new DateTime(2023, 09, 12),
                    Status = 0,
                    Description = "Description",
                },
                new ProductDetail()
                {
                    Id = new Guid("1eaaba04-80ff-43a6-a746-a74a91c7c1e4"),
                    ProductID = new Guid("cc37720a-7e89-463a-9510-1936e6761d8a"),
                    TipId = new Guid("cc37720a-7e89-463a-9510-1936e6761d44"),
                    ShaftId = new Guid("cc37720a-7e89-463a-9510-1936e6761d73"),
                    WeightId = new Guid("cc37720a-7e89-463a-9510-1936e6761d55"),
                    Quantity = 1,
                    ImportPrice = 1500,
                    Price = 2000,
                    CreateDate = new DateTime(2023, 09, 12),
                    Status = 0,
                    Description = "Description",
                },
                new ProductDetail()
                {
                    Id = new Guid("1eaaba04-80ff-43a6-a746-a74a91c7c1e5"),
                    ProductID = new Guid("cc37720a-7e89-463a-9510-1936e6761d8a"),
                    TipId = new Guid("cc37720a-7e89-463a-9510-1936e6761d54"),
                    ShaftId = new Guid("cc37720a-7e89-463a-9510-1936e6761d73"),
                    WeightId = new Guid("cc37720a-7e89-463a-9510-1936e6761d55"),
                    Quantity = 1,
                    ImportPrice = 1500,
                    Price = 2000,
                    CreateDate = new DateTime(2023, 09, 12),
                    Status = 0,
                    Description = "Description",
                },
                new ProductDetail()
                {
                    Id = new Guid("1eaaba04-80ff-43a6-a746-a74a91c7c1e6"),
                    ProductID = new Guid("cc37720a-7e89-463a-9510-1936e6761d8a"),
                    TipId = new Guid("cc37720a-7e89-463a-9510-1936e6761d64"),
                    ShaftId = new Guid("cc37720a-7e89-463a-9510-1936e6761d73"),
                    WeightId = new Guid("cc37720a-7e89-463a-9510-1936e6761d55"),
                    Quantity = 1,
                    ImportPrice = 1500,
                    Price = 2000,
                    CreateDate = new DateTime(2023, 09, 12),
                    Status = 0,
                    Description = "Description",
                },
                new ProductDetail()
                {
                    Id = new Guid("1eaaba04-80ff-43a6-a746-a74a91c7c1e7"),
                    ProductID = new Guid("cc37720a-7e89-463a-9510-1936e6761d8a"),
                    TipId = new Guid("cc37720a-7e89-463a-9510-1936e6761d74"),
                    ShaftId = new Guid("cc37720a-7e89-463a-9510-1936e6761d73"),
                    WeightId = new Guid("cc37720a-7e89-463a-9510-1936e6761d55"),
                    Quantity = 1,
                    ImportPrice = 1500,
                    Price = 2000,
                    CreateDate = new DateTime(2023, 09, 12),
                    Status = 0,
                    Description = "Description",
                },
                new ProductDetail()
                {
                    Id = new Guid("1eaaba04-80ff-43a6-a746-a74a91c7c1e8"),
                    ProductID = new Guid("cc37720a-7e89-463a-9510-1936e6761d8a"),
                    TipId = new Guid("cc37720a-7e89-463a-9510-1936e6761d84"),
                    ShaftId = new Guid("cc37720a-7e89-463a-9510-1936e6761d73"),
                    WeightId = new Guid("cc37720a-7e89-463a-9510-1936e6761d55"),
                    Quantity = 1,
                    ImportPrice = 1500,
                    Price = 2000,
                    CreateDate = new DateTime(2023, 09, 12),
                    Status = 0,
                    Description = "Description",
                },
                new ProductDetail()
                {
                    Id = new Guid("1eaaba04-80ff-43a6-a746-a74a91c7c1e9"),
                    ProductID = new Guid("cc37720a-7e89-463a-9510-1936e6761d8a"),
                    TipId = new Guid("cc37720a-7e89-463a-9510-1936e6761d94"),
                    ShaftId = new Guid("cc37720a-7e89-463a-9510-1936e6761d73"),
                    WeightId = new Guid("cc37720a-7e89-463a-9510-1936e6761d55"),
                    Quantity = 1,
                    ImportPrice = 1500,
                    Price = 2000,
                    CreateDate = new DateTime(2023, 09, 12),
                    Status = 0,
                    Description = "Description",
                },
                new ProductDetail()
                {
                    Id = new Guid("1eaaba04-80ff-43a6-a746-a74a91c7c2e0"),
                    ProductID = new Guid("cc37720a-7e89-463a-9510-1936e6761d8a"),
                    TipId = new Guid("cc37720a-7e89-463a-9510-1936e6761d04"),
                    ShaftId = new Guid("cc37720a-7e89-463a-9510-1936e6761d63"),
                    WeightId = new Guid("cc37720a-7e89-463a-9510-1936e6761d55"),
                    Quantity = 1,
                    ImportPrice = 1500,
                    Price = 2000,
                    CreateDate = new DateTime(2023, 09, 12),
                    Status = 0,
                    Description = "Description",
                },
                new ProductDetail()
                {
                    Id = new Guid("1eaaba04-80ff-43a6-a746-a74a91c7c2e1"),
                    ProductID = new Guid("cc37720a-7e89-463a-9510-1936e6761d8a"),
                    TipId = new Guid("cc37720a-7e89-463a-9510-1936e6761d14"),
                    ShaftId = new Guid("cc37720a-7e89-463a-9510-1936e6761d63"),
                    WeightId = new Guid("cc37720a-7e89-463a-9510-1936e6761d55"),
                    Quantity = 1,
                    ImportPrice = 1500,
                    Price = 2000,
                    CreateDate = new DateTime(2023, 09, 12),
                    Status = 0,
                    Description = "Description",
                },
                new ProductDetail()
                {
                    Id = new Guid("1eaaba04-80ff-43a6-a746-a74a91c7c2e2"),
                    ProductID = new Guid("cc37720a-7e89-463a-9510-1936e6761d8a"),
                    TipId = new Guid("cc37720a-7e89-463a-9510-1936e6761d24"),
                    ShaftId = new Guid("cc37720a-7e89-463a-9510-1936e6761d63"),
                    WeightId = new Guid("cc37720a-7e89-463a-9510-1936e6761d55"),
                    Quantity = 1,
                    ImportPrice = 1500,
                    Price = 2000,
                    CreateDate = new DateTime(2023, 09, 12),
                    Status = 0,
                    Description = "Description",
                },
                new ProductDetail()
                {
                    Id = new Guid("1eaaba04-80ff-43a6-a746-a74a91c7c2e3"),
                    ProductID = new Guid("cc37720a-7e89-463a-9510-1936e6761d8a"),
                    TipId = new Guid("cc37720a-7e89-463a-9510-1936e6761d34"),
                    ShaftId = new Guid("cc37720a-7e89-463a-9510-1936e6761d63"),
                    WeightId = new Guid("cc37720a-7e89-463a-9510-1936e6761d55"),
                    Quantity = 1,
                    ImportPrice = 1500,
                    Price = 2000,
                    CreateDate = new DateTime(2023, 09, 12),
                    Status = 0,
                    Description = "Description",
                },
                new ProductDetail()
                {
                    Id = new Guid("1eaaba04-80ff-43a6-a746-a74a91c7c2e4"),
                    ProductID = new Guid("cc37720a-7e89-463a-9510-1936e6761d8a"),
                    TipId = new Guid("cc37720a-7e89-463a-9510-1936e6761d44"),
                    ShaftId = new Guid("cc37720a-7e89-463a-9510-1936e6761d63"),
                    WeightId = new Guid("cc37720a-7e89-463a-9510-1936e6761d55"),
                    Quantity = 1,
                    ImportPrice = 1500,
                    Price = 2000,
                    CreateDate = new DateTime(2023, 09, 12),
                    Status = 0,
                    Description = "Description",
                },
                new ProductDetail()
                {
                    Id = new Guid("1eaaba04-80ff-43a6-a746-a74a91c7c2e5"),
                    ProductID = new Guid("cc37720a-7e89-463a-9510-1936e6761d8a"),
                    TipId = new Guid("cc37720a-7e89-463a-9510-1936e6761d54"),
                    ShaftId = new Guid("cc37720a-7e89-463a-9510-1936e6761d63"),
                    WeightId = new Guid("cc37720a-7e89-463a-9510-1936e6761d55"),
                    Quantity = 1,
                    ImportPrice = 1500,
                    Price = 2000,
                    CreateDate = new DateTime(2023, 09, 12),
                    Status = 0,
                    Description = "Description",
                },
                new ProductDetail()
                {
                    Id = new Guid("1eaaba04-80ff-43a6-a746-a74a91c7c2e6"),
                    ProductID = new Guid("cc37720a-7e89-463a-9510-1936e6761d8a"),
                    TipId = new Guid("cc37720a-7e89-463a-9510-1936e6761d64"),
                    ShaftId = new Guid("cc37720a-7e89-463a-9510-1936e6761d63"),
                    WeightId = new Guid("cc37720a-7e89-463a-9510-1936e6761d55"),
                    Quantity = 1,
                    ImportPrice = 1500,
                    Price = 2000,
                    CreateDate = new DateTime(2023, 09, 12),
                    Status = 0,
                    Description = "Description",
                },
                new ProductDetail()
                {
                    Id = new Guid("1eaaba04-80ff-43a6-a746-a74a91c7c2e7"),
                    ProductID = new Guid("cc37720a-7e89-463a-9510-1936e6761d8a"),
                    TipId = new Guid("cc37720a-7e89-463a-9510-1936e6761d74"),
                    ShaftId = new Guid("cc37720a-7e89-463a-9510-1936e6761d63"),
                    WeightId = new Guid("cc37720a-7e89-463a-9510-1936e6761d55"),
                    Quantity = 1,
                    ImportPrice = 1500,
                    Price = 2000,
                    CreateDate = new DateTime(2023, 09, 12),
                    Status = 0,
                    Description = "Description",
                },
                new ProductDetail()
                {
                    Id = new Guid("1eaaba04-80ff-43a6-a746-a74a91c7c2e8"),
                    ProductID = new Guid("cc37720a-7e89-463a-9510-1936e6761d8a"),
                    TipId = new Guid("cc37720a-7e89-463a-9510-1936e6761d84"),
                    ShaftId = new Guid("cc37720a-7e89-463a-9510-1936e6761d63"),
                    WeightId = new Guid("cc37720a-7e89-463a-9510-1936e6761d55"),
                    Quantity = 1,
                    ImportPrice = 1500,
                    Price = 2000,
                    CreateDate = new DateTime(2023, 09, 12),
                    Status = 0,
                    Description = "Description",
                },
                new ProductDetail()
                {
                    Id = new Guid("1eaaba04-80ff-43a6-a746-a74a91c7c2e9"),
                    ProductID = new Guid("cc37720a-7e89-463a-9510-1936e6761d8a"),
                    TipId = new Guid("cc37720a-7e89-463a-9510-1936e6761d94"),
                    ShaftId = new Guid("cc37720a-7e89-463a-9510-1936e6761d63"),
                    WeightId = new Guid("cc37720a-7e89-463a-9510-1936e6761d55"),
                    Quantity = 1,
                    ImportPrice = 1500,
                    Price = 2000,
                    CreateDate = new DateTime(2023, 09, 12),
                    Status = 0,
                    Description = "Description",
                },
                new ProductDetail()
                {
                    Id = new Guid("1eaaba04-80ff-43a6-a746-a74a91c7c3e0"),
                    ProductID = new Guid("cc37720a-7e89-463a-9510-1936e6761d8a"),
                    TipId = new Guid("cc37720a-7e89-463a-9510-1936e6761d04"),
                    ShaftId = new Guid("cc37720a-7e89-463a-9510-1936e6761d53"),
                    WeightId = new Guid("cc37720a-7e89-463a-9510-1936e6761d55"),
                    Quantity = 1,
                    ImportPrice = 1500,
                    Price = 2000,
                    CreateDate = new DateTime(2023, 09, 12),
                    Status = 0,
                    Description = "Description",
                },
                new ProductDetail()
                {
                    Id = new Guid("1eaaba04-80ff-43a6-a746-a74a91c7c3e1"),
                    ProductID = new Guid("cc37720a-7e89-463a-9510-1936e6761d8a"),
                    TipId = new Guid("cc37720a-7e89-463a-9510-1936e6761d14"),
                    ShaftId = new Guid("cc37720a-7e89-463a-9510-1936e6761d53"),
                    WeightId = new Guid("cc37720a-7e89-463a-9510-1936e6761d55"),
                    Quantity = 1,
                    ImportPrice = 1500,
                    Price = 2000,
                    CreateDate = new DateTime(2023, 09, 12),
                    Status = 0,
                    Description = "Description",
                },
                new ProductDetail()
                {
                    Id = new Guid("1eaaba04-80ff-43a6-a746-a74a91c7c3e2"),
                    ProductID = new Guid("cc37720a-7e89-463a-9510-1936e6761d8a"),
                    TipId = new Guid("cc37720a-7e89-463a-9510-1936e6761d24"),
                    ShaftId = new Guid("cc37720a-7e89-463a-9510-1936e6761d53"),
                    WeightId = new Guid("cc37720a-7e89-463a-9510-1936e6761d55"),
                    Quantity = 1,
                    ImportPrice = 1500,
                    Price = 2000,
                    CreateDate = new DateTime(2023, 09, 12),
                    Status = 0,
                    Description = "Description",
                },
                new ProductDetail()
                {
                    Id = new Guid("1eaaba04-80ff-43a6-a746-a74a91c7c3e3"),
                    ProductID = new Guid("cc37720a-7e89-463a-9510-1936e6761d8a"),
                    TipId = new Guid("cc37720a-7e89-463a-9510-1936e6761d34"),
                    ShaftId = new Guid("cc37720a-7e89-463a-9510-1936e6761d53"),
                    WeightId = new Guid("cc37720a-7e89-463a-9510-1936e6761d55"),
                    Quantity = 1,
                    ImportPrice = 1500,
                    Price = 2000,
                    CreateDate = new DateTime(2023, 09, 12),
                    Status = 0,
                    Description = "Description",
                },
                new ProductDetail()
                {
                    Id = new Guid("1eaaba04-80ff-43a6-a746-a74a91c7c3e4"),
                    ProductID = new Guid("cc37720a-7e89-463a-9510-1936e6761d8a"),
                    TipId = new Guid("cc37720a-7e89-463a-9510-1936e6761d44"),
                    ShaftId = new Guid("cc37720a-7e89-463a-9510-1936e6761d53"),
                    WeightId = new Guid("cc37720a-7e89-463a-9510-1936e6761d55"),
                    Quantity = 1,
                    ImportPrice = 1500,
                    Price = 2000,
                    CreateDate = new DateTime(2023, 09, 12),
                    Status = 0,
                    Description = "Description",
                },
                new ProductDetail()
                {
                    Id = new Guid("1eaaba04-80ff-43a6-a746-a74a91c7c3e5"),
                    ProductID = new Guid("cc37720a-7e89-463a-9510-1936e6761d8a"),
                    TipId = new Guid("cc37720a-7e89-463a-9510-1936e6761d54"),
                    ShaftId = new Guid("cc37720a-7e89-463a-9510-1936e6761d53"),
                    WeightId = new Guid("cc37720a-7e89-463a-9510-1936e6761d55"),
                    Quantity = 1,
                    ImportPrice = 1500,
                    Price = 2000,
                    CreateDate = new DateTime(2023, 09, 12),
                    Status = 0,
                    Description = "Description",
                },
                new ProductDetail()
                {
                    Id = new Guid("1eaaba04-80ff-43a6-a746-a74a91c7c3e6"),
                    ProductID = new Guid("cc37720a-7e89-463a-9510-1936e6761d8a"),
                    TipId = new Guid("cc37720a-7e89-463a-9510-1936e6761d64"),
                    ShaftId = new Guid("cc37720a-7e89-463a-9510-1936e6761d53"),
                    WeightId = new Guid("cc37720a-7e89-463a-9510-1936e6761d55"),
                    Quantity = 1,
                    ImportPrice = 1500,
                    Price = 2000,
                    CreateDate = new DateTime(2023, 09, 12),
                    Status = 0,
                    Description = "Description",
                },
                new ProductDetail()
                {
                    Id = new Guid("1eaaba04-80ff-43a6-a746-a74a91c7c3e7"),
                    ProductID = new Guid("cc37720a-7e89-463a-9510-1936e6761d8a"),
                    TipId = new Guid("cc37720a-7e89-463a-9510-1936e6761d74"),
                    ShaftId = new Guid("cc37720a-7e89-463a-9510-1936e6761d53"),
                    WeightId = new Guid("cc37720a-7e89-463a-9510-1936e6761d55"),
                    Quantity = 1,
                    ImportPrice = 1500,
                    Price = 2000,
                    CreateDate = new DateTime(2023, 09, 12),
                    Status = 0,
                    Description = "Description",
                },
                new ProductDetail()
                {
                    Id = new Guid("1eaaba04-80ff-43a6-a746-a74a91c7c3e8"),
                    ProductID = new Guid("cc37720a-7e89-463a-9510-1936e6761d8a"),
                    TipId = new Guid("cc37720a-7e89-463a-9510-1936e6761d84"),
                    ShaftId = new Guid("cc37720a-7e89-463a-9510-1936e6761d53"),
                    WeightId = new Guid("cc37720a-7e89-463a-9510-1936e6761d55"),
                    Quantity = 1,
                    ImportPrice = 1500,
                    Price = 2000,
                    CreateDate = new DateTime(2023, 09, 12),
                    Status = 0,
                    Description = "Description",
                },
                new ProductDetail()
                {
                    Id = new Guid("1eaaba04-80ff-43a6-a746-a74a91c7c3e9"),
                    ProductID = new Guid("cc37720a-7e89-463a-9510-1936e6761d8a"),
                    TipId = new Guid("cc37720a-7e89-463a-9510-1936e6761d94"),
                    ShaftId = new Guid("cc37720a-7e89-463a-9510-1936e6761d53"),
                    WeightId = new Guid("cc37720a-7e89-463a-9510-1936e6761d55"),
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
                },
                new ProductDetail()
                {
                    Id = new Guid("84a7b7bd-0490-4cf1-9499-1d9fe88580c4"),
                    ProductID = new Guid("cc37720a-7e89-463a-9510-2936e6761d8a"),
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
                    Id = new Guid("84a7b7bd-0490-4cf1-9499-1d9fe88580c5"),
                    ProductID = new Guid("cc37720a-7e89-463a-9510-3936e6761d8b"),
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
                    Id = new Guid("84a7b7bd-0490-4cf1-9499-1d9fe88580c6"),
                    ProductID = new Guid("cc37720a-7e89-463a-9510-4936e6761d8c"),
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
                    Id = new Guid("84a7b7bd-0490-4cf1-9499-1d9fe88580c7"),
                    ProductID = new Guid("cc37720a-7e89-463a-9510-5936e6761d8a"),
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
                    Id = new Guid("84a7b7bd-0490-4cf1-9499-1d9fe88580c8"),
                    ProductID = new Guid("cc37720a-7e89-463a-9510-6936e6761d8b"),
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
                    Id = new Guid("84a7b7bd-0490-4cf1-9499-1d9fe88580c9"),
                    ProductID = new Guid("cc37720a-7e89-463a-9510-7936e6761d8c"),
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
                    Id = new Guid("84a7b7bd-0490-4cf1-9499-1d9fe88580c0"),
                    ProductID = new Guid("cc37720a-7e89-463a-9510-8936e6761d8a"),
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
            },
            new BillStatus()
            {
                Id = new Guid("b392b872-712a-41a7-8542-83fb58249c23"),
                Name = "Đang lấy hàng"
            },
            new BillStatus()
            {
                Id = new Guid("00357f21-9356-468b-8c0c-b590e3d1bc0a"),
                Name = "Đang giao hàng"
            });

            modelBuilder.Entity<Payment>().HasData(
            new Payment()
            {
                Id = new Guid("a51f7c3c-a8e7-4c0a-aeea-b6fc70492bf6"),
                Name = "Ship COD (Thanh toán khi nhận hàng)",
            },
            new Payment()
            {
                Id = new Guid("a51f7c3c-a8e7-4c0a-aeea-b6fc70492b16"),
                Name = "Chuyển khoản ngân hàng",
            });

            modelBuilder.Entity<Voucher>().HasData(
            new Voucher()
            {
                Id = new Guid("a51f7c3c-a8e7-4c0a-aeea-b6fc70492bf4"),
                EmPloyeeId = new Guid("40b601c0-2c08-449f-a41e-7564648f2c87"),
                Code = "DEMACIA",
                Value = 30,
                PointCustomer = 2000,
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
                PointCustomer = 1000,
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
                CustomerName = "Hoàng Xuân",
                CustomerPhone = "0364838484",
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
                CustomerName = "Hoàng Xuân",
                CustomerPhone = "0364838484",
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
                Id = new Guid("d5c65161-7591-48c1-9198-daca150bce0c"),
                ProductDetailId = new Guid("1eaaba04-80ff-43a6-a746-a74a91c4c0e0"),
                Name = "presp8pw_01.jpg",
                Status = 0,
            },
            new ProductImage()
            {
                Id = new Guid("d5c65161-7591-48c1-9198-daca150bce1c"),
                ProductDetailId = new Guid("1eaaba04-80ff-43a6-a746-a74a91c4c0e0"),
                Name = "presp8pw_cat.jpg",
                Status = 0,
            },
            new ProductImage()
            {
                Id = new Guid("d5c65161-7591-48c1-9198-daca150bce2c"),
                ProductDetailId = new Guid("1eaaba04-80ff-43a6-a746-a74a91c4c0e1"),
                Name = "presp8pw_01.jpg",
                Status = 0,
            },
            new ProductImage()
            {
                Id = new Guid("d5c65161-7591-48c1-9198-daca150bce3c"),
                ProductDetailId = new Guid("1eaaba04-80ff-43a6-a746-a74a91c4c0e1"),
                Name = "presp8pw_cat.jpg",
                Status = 0,
            },
            new ProductImage()
            {
                Id = new Guid("d5c65161-7591-48c1-9198-daca150bce4c"),
                ProductDetailId = new Guid("1eaaba04-80ff-43a6-a746-a74a91c4c0e2"),
                Name = "presp8pw_01.jpg",
                Status = 0,
            },
            new ProductImage()
            {
                Id = new Guid("d5c65161-7591-48c1-9198-daca150bce5c"),
                ProductDetailId = new Guid("1eaaba04-80ff-43a6-a746-a74a91c4c0e2"),
                Name = "presp8pw_cat.jpg",
                Status = 0,
            },
            new ProductImage()
            {
                Id = new Guid("d5c65161-7591-48c1-9198-daca150bce6c"),
                ProductDetailId = new Guid("1eaaba04-80ff-43a6-a746-a74a91c4c0e3"),
                Name = "presp8pw_01.jpg",
                Status = 0,
            },
            new ProductImage()
            {
                Id = new Guid("d5c65161-7591-48c1-9198-daca150bce7c"),
                ProductDetailId = new Guid("1eaaba04-80ff-43a6-a746-a74a91c4c0e3"),
                Name = "presp8pw_cat.jpg",
                Status = 0,
            },
            new ProductImage()
            {
                Id = new Guid("d5c65161-7591-48c1-9198-daca150bce8c"),
                ProductDetailId = new Guid("1eaaba04-80ff-43a6-a746-a74a91c4c0e4"),
                Name = "presp8pw_01.jpg",
                Status = 0,
            },
            new ProductImage()
            {
                Id = new Guid("d5c65161-7591-48c1-9198-daca150bce9c"),
                ProductDetailId = new Guid("1eaaba04-80ff-43a6-a746-a74a91c4c0e4"),
                Name = "presp8pw_cat.jpg",
                Status = 0,
            },
            new ProductImage()
            {
                Id = new Guid("d5c65161-7591-48c1-9198-daca151bce0c"),
                ProductDetailId = new Guid("1eaaba04-80ff-43a6-a746-a74a91c4c0e5"),
                Name = "presp8pw_01.jpg",
                Status = 0,
            },
            new ProductImage()
            {
                Id = new Guid("d5c65161-7591-48c1-9198-daca151bce1c"),
                ProductDetailId = new Guid("1eaaba04-80ff-43a6-a746-a74a91c4c0e5"),
                Name = "presp8pw_cat.jpg",
                Status = 0,
            },
            new ProductImage()
            {
                Id = new Guid("d5c65161-7591-48c1-9198-daca151bce2c"),
                ProductDetailId = new Guid("1eaaba04-80ff-43a6-a746-a74a91c4c0e6"),
                Name = "presp8pw_01.jpg",
                Status = 0,
            },
            new ProductImage()
            {
                Id = new Guid("d5c65161-7591-48c1-9198-daca151bce3c"),
                ProductDetailId = new Guid("1eaaba04-80ff-43a6-a746-a74a91c4c0e6"),
                Name = "presp8pw_cat.jpg",
                Status = 0,
            },
            new ProductImage()
            {
                Id = new Guid("d5c65161-7591-48c1-9198-daca151bce4c"),
                ProductDetailId = new Guid("1eaaba04-80ff-43a6-a746-a74a91c4c0e7"),
                Name = "presp8pw_01.jpg",
                Status = 0,
            },
            new ProductImage()
            {
                Id = new Guid("d5c65161-7591-48c1-9198-daca151bce5c"),
                ProductDetailId = new Guid("1eaaba04-80ff-43a6-a746-a74a91c4c0e7"),
                Name = "presp8pw_cat.jpg",
                Status = 0,
            },
            new ProductImage()
            {
                Id = new Guid("d5c65161-7591-48c1-9198-daca151bce6c"),
                ProductDetailId = new Guid("1eaaba04-80ff-43a6-a746-a74a91c4c0e8"),
                Name = "presp8pw_01.jpg",
                Status = 0,
            },
            new ProductImage()
            {
                Id = new Guid("d5c65161-7591-48c1-9198-daca151bce7c"),
                ProductDetailId = new Guid("1eaaba04-80ff-43a6-a746-a74a91c4c0e8"),
                Name = "presp8pw_cat.jpg",
                Status = 0,
            },
            new ProductImage()
            {
                Id = new Guid("d5c65161-7591-48c1-9198-daca151bce8c"),
                ProductDetailId = new Guid("1eaaba04-80ff-43a6-a746-a74a91c4c0e9"),
                Name = "presp8pw_01.jpg",
                Status = 0,
            },
            new ProductImage()
            {
                Id = new Guid("d5c65161-7591-48c1-9198-daca151bce9c"),
                ProductDetailId = new Guid("1eaaba04-80ff-43a6-a746-a74a91c4c0e9"),
                Name = "presp8pw_cat.jpg",
                Status = 0,
            },
            new ProductImage()
            {
                Id = new Guid("d5c65161-7591-48c1-9198-daca152bce0c"),
                ProductDetailId = new Guid("1eaaba04-80ff-43a6-a746-a74a91c4c1e0"),
                Name = "presp8pw_01.jpg",
                Status = 0,
            },
            new ProductImage()
            {
                Id = new Guid("d5c65161-7591-48c1-9198-daca152bce1c"),
                ProductDetailId = new Guid("1eaaba04-80ff-43a6-a746-a74a91c4c1e0"),
                Name = "presp8pw_cat.jpg",
                Status = 0,
            },
            new ProductImage()
            {
                Id = new Guid("d5c65161-7591-48c1-9198-daca152bce2c"),
                ProductDetailId = new Guid("1eaaba04-80ff-43a6-a746-a74a91c4c1e1"),
                Name = "presp8pw_01.jpg",
                Status = 0,
            },
            new ProductImage()
            {
                Id = new Guid("d5c65161-7591-48c1-9198-daca152bce3c"),
                ProductDetailId = new Guid("1eaaba04-80ff-43a6-a746-a74a91c4c1e1"),
                Name = "presp8pw_cat.jpg",
                Status = 0,
            },
            new ProductImage()
            {
                Id = new Guid("d5c65161-7591-48c1-9198-daca152bce4c"),
                ProductDetailId = new Guid("1eaaba04-80ff-43a6-a746-a74a91c4c1e2"),
                Name = "presp8pw_01.jpg",
                Status = 0,
            },
            new ProductImage()
            {
                Id = new Guid("d5c65161-7591-48c1-9198-daca152bce5c"),
                ProductDetailId = new Guid("1eaaba04-80ff-43a6-a746-a74a91c4c1e2"),
                Name = "presp8pw_cat.jpg",
                Status = 0,
            },
            new ProductImage()
            {
                Id = new Guid("d5c65161-7591-48c1-9198-daca152bce6c"),
                ProductDetailId = new Guid("1eaaba04-80ff-43a6-a746-a74a91c4c1e3"),
                Name = "presp8pw_01.jpg",
                Status = 0,
            },
            new ProductImage()
            {
                Id = new Guid("d5c65161-7591-48c1-9198-daca152bce7c"),
                ProductDetailId = new Guid("1eaaba04-80ff-43a6-a746-a74a91c4c1e3"),
                Name = "presp8pw_cat.jpg",
                Status = 0,
            },
            new ProductImage()
            {
                Id = new Guid("d5c65161-7591-48c1-9198-daca152bce8c"),
                ProductDetailId = new Guid("1eaaba04-80ff-43a6-a746-a74a91c4c1e4"),
                Name = "presp8pw_01.jpg",
                Status = 0,
            },
            new ProductImage()
            {
                Id = new Guid("d5c65161-7591-48c1-9198-daca152bce9c"),
                ProductDetailId = new Guid("1eaaba04-80ff-43a6-a746-a74a91c4c1e4"),
                Name = "presp8pw_cat.jpg",
                Status = 0,
            },
            new ProductImage()
            {
                Id = new Guid("d5c65161-7591-48c1-9198-daca153bce0c"),
                ProductDetailId = new Guid("1eaaba04-80ff-43a6-a746-a74a91c4c1e5"),
                Name = "presp8pw_01.jpg",
                Status = 0,
            },
            new ProductImage()
            {
                Id = new Guid("d5c65161-7591-48c1-9198-daca153bce1c"),
                ProductDetailId = new Guid("1eaaba04-80ff-43a6-a746-a74a91c4c1e5"),
                Name = "presp8pw_cat.jpg",
                Status = 0,
            },
            new ProductImage()
            {
                Id = new Guid("d5c65161-7591-48c1-9198-daca153bce2c"),
                ProductDetailId = new Guid("1eaaba04-80ff-43a6-a746-a74a91c4c1e6"),
                Name = "presp8pw_01.jpg",
                Status = 0,
            },
            new ProductImage()
            {
                Id = new Guid("d5c65161-7591-48c1-9198-daca153bce3c"),
                ProductDetailId = new Guid("1eaaba04-80ff-43a6-a746-a74a91c4c1e6"),
                Name = "presp8pw_cat.jpg",
                Status = 0,
            },
            new ProductImage()
            {
                Id = new Guid("d5c65161-7591-48c1-9198-daca153bce4c"),
                ProductDetailId = new Guid("1eaaba04-80ff-43a6-a746-a74a91c4c1e7"),
                Name = "presp8pw_01.jpg",
                Status = 0,
            },
            new ProductImage()
            {
                Id = new Guid("d5c65161-7591-48c1-9198-daca153bce5c"),
                ProductDetailId = new Guid("1eaaba04-80ff-43a6-a746-a74a91c4c1e7"),
                Name = "presp8pw_cat.jpg",
                Status = 0,
            },
            new ProductImage()
            {
                Id = new Guid("d5c65161-7591-48c1-9198-daca153bce6c"),
                ProductDetailId = new Guid("1eaaba04-80ff-43a6-a746-a74a91c4c1e8"),
                Name = "presp8pw_01.jpg",
                Status = 0,
            },
            new ProductImage()
            {
                Id = new Guid("d5c65161-7591-48c1-9198-daca153bce7c"),
                ProductDetailId = new Guid("1eaaba04-80ff-43a6-a746-a74a91c4c1e8"),
                Name = "presp8pw_cat.jpg",
                Status = 0,
            },
            new ProductImage()
            {
                Id = new Guid("d5c65161-7591-48c1-9198-daca153bce8c"),
                ProductDetailId = new Guid("1eaaba04-80ff-43a6-a746-a74a91c4c1e9"),
                Name = "presp8pw_01.jpg",
                Status = 0,
            },
            new ProductImage()
            {
                Id = new Guid("d5c65161-7591-48c1-9198-daca153bce9c"),
                ProductDetailId = new Guid("1eaaba04-80ff-43a6-a746-a74a91c4c1e9"),
                Name = "presp8pw_cat.jpg",
                Status = 0,
            },
            new ProductImage()
            {
                Id = new Guid("d5c65161-7591-48c1-9198-daca154bce0c"),
                ProductDetailId = new Guid("1eaaba04-80ff-43a6-a746-a74a91c4c2e0"),
                Name = "presp8pw_01.jpg",
                Status = 0,
            },
            new ProductImage()
            {
                Id = new Guid("d5c65161-7591-48c1-9198-daca154bce1c"),
                ProductDetailId = new Guid("1eaaba04-80ff-43a6-a746-a74a91c4c2e0"),
                Name = "presp8pw_cat.jpg",
                Status = 0,
            },
            new ProductImage()
            {
                Id = new Guid("d5c65161-7591-48c1-9198-daca154bce2c"),
                ProductDetailId = new Guid("1eaaba04-80ff-43a6-a746-a74a91c4c2e1"),
                Name = "presp8pw_01.jpg",
                Status = 0,
            },
            new ProductImage()
            {
                Id = new Guid("d5c65161-7591-48c1-9198-daca154bce3c"),
                ProductDetailId = new Guid("1eaaba04-80ff-43a6-a746-a74a91c4c2e1"),
                Name = "presp8pw_cat.jpg",
                Status = 0,
            },
            new ProductImage()
            {
                Id = new Guid("d5c65161-7591-48c1-9198-daca154bce4c"),
                ProductDetailId = new Guid("1eaaba04-80ff-43a6-a746-a74a91c4c2e2"),
                Name = "presp8pw_01.jpg",
                Status = 0,
            },
            new ProductImage()
            {
                Id = new Guid("d5c65161-7591-48c1-9198-daca154bce5c"),
                ProductDetailId = new Guid("1eaaba04-80ff-43a6-a746-a74a91c4c2e2"),
                Name = "presp8pw_cat.jpg",
                Status = 0,
            },
            new ProductImage()
            {
                Id = new Guid("d5c65161-7591-48c1-9198-daca154bce6c"),
                ProductDetailId = new Guid("1eaaba04-80ff-43a6-a746-a74a91c4c2e3"),
                Name = "presp8pw_01.jpg",
                Status = 0,
            },
            new ProductImage()
            {
                Id = new Guid("d5c65161-7591-48c1-9198-daca154bce7c"),
                ProductDetailId = new Guid("1eaaba04-80ff-43a6-a746-a74a91c4c2e3"),
                Name = "presp8pw_cat.jpg",
                Status = 0,
            },
            new ProductImage()
            {
                Id = new Guid("d5c65161-7591-48c1-9198-daca154bce8c"),
                ProductDetailId = new Guid("1eaaba04-80ff-43a6-a746-a74a91c4c2e4"),
                Name = "presp8pw_01.jpg",
                Status = 0,
            },
            new ProductImage()
            {
                Id = new Guid("d5c65161-7591-48c1-9198-daca154bce9c"),
                ProductDetailId = new Guid("1eaaba04-80ff-43a6-a746-a74a91c4c2e4"),
                Name = "presp8pw_cat.jpg",
                Status = 0,
            },
            new ProductImage()
            {
                Id = new Guid("d5c65161-7591-48c1-9198-daca155bce0c"),
                ProductDetailId = new Guid("1eaaba04-80ff-43a6-a746-a74a91c4c2e5"),
                Name = "presp8pw_01.jpg",
                Status = 0,
            },
            new ProductImage()
            {
                Id = new Guid("d5c65161-7591-48c1-9198-daca155bce1c"),
                ProductDetailId = new Guid("1eaaba04-80ff-43a6-a746-a74a91c4c2e5"),
                Name = "presp8pw_cat.jpg",
                Status = 0,
            },
            new ProductImage()
            {
                Id = new Guid("d5c65161-7591-48c1-9198-daca155bce2c"),
                ProductDetailId = new Guid("1eaaba04-80ff-43a6-a746-a74a91c4c2e6"),
                Name = "presp8pw_01.jpg",
                Status = 0,
            },
            new ProductImage()
            {
                Id = new Guid("d5c65161-7591-48c1-9198-daca155bce3c"),
                ProductDetailId = new Guid("1eaaba04-80ff-43a6-a746-a74a91c4c2e6"),
                Name = "presp8pw_cat.jpg",
                Status = 0,
            },
            new ProductImage()
            {
                Id = new Guid("d5c65161-7591-48c1-9198-daca155bce4c"),
                ProductDetailId = new Guid("1eaaba04-80ff-43a6-a746-a74a91c4c2e7"),
                Name = "presp8pw_01.jpg",
                Status = 0,
            },
            new ProductImage()
            {
                Id = new Guid("d5c65161-7591-48c1-9198-daca155bce5c"),
                ProductDetailId = new Guid("1eaaba04-80ff-43a6-a746-a74a91c4c2e7"),
                Name = "presp8pw_cat.jpg",
                Status = 0,
            },
            new ProductImage()
            {
                Id = new Guid("d5c65161-7591-48c1-9198-daca155bce6c"),
                ProductDetailId = new Guid("1eaaba04-80ff-43a6-a746-a74a91c4c2e8"),
                Name = "presp8pw_01.jpg",
                Status = 0,
            },
            new ProductImage()
            {
                Id = new Guid("d5c65161-7591-48c1-9198-daca155bce7c"),
                ProductDetailId = new Guid("1eaaba04-80ff-43a6-a746-a74a91c4c2e8"),
                Name = "presp8pw_cat.jpg",
                Status = 0,
            },
            new ProductImage()
            {
                Id = new Guid("d5c65161-7591-48c1-9198-daca155bce8c"),
                ProductDetailId = new Guid("1eaaba04-80ff-43a6-a746-a74a91c4c2e9"),
                Name = "presp8pw_01.jpg",
                Status = 0,
            },
            new ProductImage()
            {
                Id = new Guid("d5c65161-7591-48c1-9198-daca155bce9c"),
                ProductDetailId = new Guid("1eaaba04-80ff-43a6-a746-a74a91c4c2e9"),
                Name = "presp8pw_cat.jpg",
                Status = 0,
            },
            new ProductImage()
            {
                Id = new Guid("d5c65161-7591-48c1-9198-daca156bce0c"),
                ProductDetailId = new Guid("1eaaba04-80ff-43a6-a746-a74a91c4c3e0"),
                Name = "presp8pw_01.jpg",
                Status = 0,
            },
            new ProductImage()
            {
                Id = new Guid("d5c65161-7591-48c1-9198-daca156bce1c"),
                ProductDetailId = new Guid("1eaaba04-80ff-43a6-a746-a74a91c4c3e0"),
                Name = "presp8pw_cat.jpg",
                Status = 0,
            },
            new ProductImage()
            {
                Id = new Guid("d5c65161-7591-48c1-9198-daca156bce2c"),
                ProductDetailId = new Guid("1eaaba04-80ff-43a6-a746-a74a91c4c3e1"),
                Name = "presp8pw_01.jpg",
                Status = 0,
            },
            new ProductImage()
            {
                Id = new Guid("d5c65161-7591-48c1-9198-daca156bce3c"),
                ProductDetailId = new Guid("1eaaba04-80ff-43a6-a746-a74a91c4c3e1"),
                Name = "presp8pw_cat.jpg",
                Status = 0,
            },
            new ProductImage()
            {
                Id = new Guid("d5c65161-7591-48c1-9198-daca156bce4c"),
                ProductDetailId = new Guid("1eaaba04-80ff-43a6-a746-a74a91c4c3e2"),
                Name = "presp8pw_01.jpg",
                Status = 0,
            },
            new ProductImage()
            {
                Id = new Guid("d5c65161-7591-48c1-9198-daca156bce5c"),
                ProductDetailId = new Guid("1eaaba04-80ff-43a6-a746-a74a91c4c3e2"),
                Name = "presp8pw_cat.jpg",
                Status = 0,
            },
            new ProductImage()
            {
                Id = new Guid("d5c65161-7591-48c1-9198-daca156bce6c"),
                ProductDetailId = new Guid("1eaaba04-80ff-43a6-a746-a74a91c4c3e3"),
                Name = "presp8pw_01.jpg",
                Status = 0,
            },
            new ProductImage()
            {
                Id = new Guid("d5c65161-7591-48c1-9198-daca156bce7c"),
                ProductDetailId = new Guid("1eaaba04-80ff-43a6-a746-a74a91c4c3e3"),
                Name = "presp8pw_cat.jpg",
                Status = 0,
            },
            new ProductImage()
            {
                Id = new Guid("d5c65161-7591-48c1-9198-daca156bce8c"),
                ProductDetailId = new Guid("1eaaba04-80ff-43a6-a746-a74a91c4c3e4"),
                Name = "presp8pw_01.jpg",
                Status = 0,
            },
            new ProductImage()
            {
                Id = new Guid("d5c65161-7591-48c1-9198-daca156bce9c"),
                ProductDetailId = new Guid("1eaaba04-80ff-43a6-a746-a74a91c4c3e4"),
                Name = "presp8pw_cat.jpg",
                Status = 0,
            },
            new ProductImage()
            {
                Id = new Guid("d5c65161-7591-48c1-9198-daca157bce0c"),
                ProductDetailId = new Guid("1eaaba04-80ff-43a6-a746-a74a91c4c3e5"),
                Name = "presp8pw_01.jpg",
                Status = 0,
            },
            new ProductImage()
            {
                Id = new Guid("d5c65161-7591-48c1-9198-daca157bce1c"),
                ProductDetailId = new Guid("1eaaba04-80ff-43a6-a746-a74a91c4c3e5"),
                Name = "presp8pw_cat.jpg",
                Status = 0,
            },
            new ProductImage()
            {
                Id = new Guid("d5c65161-7591-48c1-9198-daca157bce2c"),
                ProductDetailId = new Guid("1eaaba04-80ff-43a6-a746-a74a91c4c3e6"),
                Name = "presp8pw_01.jpg",
                Status = 0,
            },
            new ProductImage()
            {
                Id = new Guid("d5c65161-7591-48c1-9198-daca157bce3c"),
                ProductDetailId = new Guid("1eaaba04-80ff-43a6-a746-a74a91c4c3e6"),
                Name = "presp8pw_cat.jpg",
                Status = 0,
            },
            new ProductImage()
            {
                Id = new Guid("d5c65161-7591-48c1-9198-daca157bce4c"),
                ProductDetailId = new Guid("1eaaba04-80ff-43a6-a746-a74a91c4c3e7"),
                Name = "presp8pw_01.jpg",
                Status = 0,
            },
            new ProductImage()
            {
                Id = new Guid("d5c65161-7591-48c1-9198-daca157bce5c"),
                ProductDetailId = new Guid("1eaaba04-80ff-43a6-a746-a74a91c4c3e7"),
                Name = "presp8pw_cat.jpg",
                Status = 0,
            },
            new ProductImage()
            {
                Id = new Guid("d5c65161-7591-48c1-9198-daca157bce6c"),
                ProductDetailId = new Guid("1eaaba04-80ff-43a6-a746-a74a91c4c3e8"),
                Name = "presp8pw_01.jpg",
                Status = 0,
            },
            new ProductImage()
            {
                Id = new Guid("d5c65161-7591-48c1-9198-daca157bce7c"),
                ProductDetailId = new Guid("1eaaba04-80ff-43a6-a746-a74a91c4c3e8"),
                Name = "presp8pw_cat.jpg",
                Status = 0,
            },
            new ProductImage()
            {
                Id = new Guid("d5c65161-7591-48c1-9198-daca157bce8c"),
                ProductDetailId = new Guid("1eaaba04-80ff-43a6-a746-a74a91c4c3e9"),
                Name = "presp8pw_01.jpg",
                Status = 0,
            },
            new ProductImage()
            {
                Id = new Guid("d5c65161-7591-48c1-9198-daca157bce9c"),
                ProductDetailId = new Guid("1eaaba04-80ff-43a6-a746-a74a91c4c3e9"),
                Name = "presp8pw_cat.jpg",
                Status = 0,
            },
            new ProductImage()
            {
                Id = new Guid("d5c65161-7591-48c1-9198-daca158bce0c"),
                ProductDetailId = new Guid("1eaaba04-80ff-43a6-a746-a74a91c5c0e0"),
                Name = "presp8pw_01.jpg",
                Status = 0,
            },
            new ProductImage()
            {
                Id = new Guid("d5c65161-7591-48c1-9198-daca158bce1c"),
                ProductDetailId = new Guid("1eaaba04-80ff-43a6-a746-a74a91c5c0e0"),
                Name = "presp8pw_cat.jpg",
                Status = 0,
            },
            new ProductImage()
            {
                Id = new Guid("d5c65161-7591-48c1-9198-daca158bce2c"),
                ProductDetailId = new Guid("1eaaba04-80ff-43a6-a746-a74a91c5c0e1"),
                Name = "presp8pw_01.jpg",
                Status = 0,
            },
            new ProductImage()
            {
                Id = new Guid("d5c65161-7591-48c1-9198-daca158bce3c"),
                ProductDetailId = new Guid("1eaaba04-80ff-43a6-a746-a74a91c5c0e1"),
                Name = "presp8pw_cat.jpg",
                Status = 0,
            },
            new ProductImage()
            {
                Id = new Guid("d5c65161-7591-48c1-9198-daca158bce4c"),
                ProductDetailId = new Guid("1eaaba04-80ff-43a6-a746-a74a91c5c0e2"),
                Name = "presp8pw_01.jpg",
                Status = 0,
            },
            new ProductImage()
            {
                Id = new Guid("d5c65161-7591-48c1-9198-daca158bce5c"),
                ProductDetailId = new Guid("1eaaba04-80ff-43a6-a746-a74a91c5c0e2"),
                Name = "presp8pw_cat.jpg",
                Status = 0,
            },
            new ProductImage()
            {
                Id = new Guid("d5c65161-7591-48c1-9198-daca158bce6c"),
                ProductDetailId = new Guid("1eaaba04-80ff-43a6-a746-a74a91c5c0e3"),
                Name = "presp8pw_01.jpg",
                Status = 0,
            },
            new ProductImage()
            {
                Id = new Guid("d5c65161-7591-48c1-9198-daca158bce7c"),
                ProductDetailId = new Guid("1eaaba04-80ff-43a6-a746-a74a91c5c0e3"),
                Name = "presp8pw_cat.jpg",
                Status = 0,
            },
            new ProductImage()
            {
                Id = new Guid("d5c65161-7591-48c1-9198-daca158bce8c"),
                ProductDetailId = new Guid("1eaaba04-80ff-43a6-a746-a74a91c5c0e4"),
                Name = "presp8pw_01.jpg",
                Status = 0,
            },
            new ProductImage()
            {
                Id = new Guid("d5c65161-7591-48c1-9198-daca158bce9c"),
                ProductDetailId = new Guid("1eaaba04-80ff-43a6-a746-a74a91c5c0e4"),
                Name = "presp8pw_cat.jpg",
                Status = 0,
            },
            new ProductImage()
            {
                Id = new Guid("d5c65161-7591-48c1-9198-daca159bce0c"),
                ProductDetailId = new Guid("1eaaba04-80ff-43a6-a746-a74a91c5c0e5"),
                Name = "presp8pw_01.jpg",
                Status = 0,
            },
            new ProductImage()
            {
                Id = new Guid("d5c65161-7591-48c1-9198-daca159bce1c"),
                ProductDetailId = new Guid("1eaaba04-80ff-43a6-a746-a74a91c5c0e5"),
                Name = "presp8pw_cat.jpg",
                Status = 0,
            },
            new ProductImage()
            {
                Id = new Guid("d5c65161-7591-48c1-9198-daca159bce2c"),
                ProductDetailId = new Guid("1eaaba04-80ff-43a6-a746-a74a91c5c0e6"),
                Name = "presp8pw_01.jpg",
                Status = 0,
            },
            new ProductImage()
            {
                Id = new Guid("d5c65161-7591-48c1-9198-daca159bce3c"),
                ProductDetailId = new Guid("1eaaba04-80ff-43a6-a746-a74a91c5c0e6"),
                Name = "presp8pw_cat.jpg",
                Status = 0,
            },
            new ProductImage()
            {
                Id = new Guid("d5c65161-7591-48c1-9198-daca159bce4c"),
                ProductDetailId = new Guid("1eaaba04-80ff-43a6-a746-a74a91c5c0e7"),
                Name = "presp8pw_01.jpg",
                Status = 0,
            },
            new ProductImage()
            {
                Id = new Guid("d5c65161-7591-48c1-9198-daca159bce5c"),
                ProductDetailId = new Guid("1eaaba04-80ff-43a6-a746-a74a91c5c0e7"),
                Name = "presp8pw_cat.jpg",
                Status = 0,
            },
            new ProductImage()
            {
                Id = new Guid("d5c65161-7591-48c1-9198-daca159bce6c"),
                ProductDetailId = new Guid("1eaaba04-80ff-43a6-a746-a74a91c5c0e8"),
                Name = "presp8pw_01.jpg",
                Status = 0,
            },
            new ProductImage()
            {
                Id = new Guid("d5c65161-7591-48c1-9198-daca159bce7c"),
                ProductDetailId = new Guid("1eaaba04-80ff-43a6-a746-a74a91c5c0e8"),
                Name = "presp8pw_cat.jpg",
                Status = 0,
            },
            new ProductImage()
            {
                Id = new Guid("d5c65161-7591-48c1-9198-daca159bce8c"),
                ProductDetailId = new Guid("1eaaba04-80ff-43a6-a746-a74a91c5c0e9"),
                Name = "presp8pw_01.jpg",
                Status = 0,
            },
            new ProductImage()
            {
                Id = new Guid("d5c65161-7591-48c1-9198-daca159bce9c"),
                ProductDetailId = new Guid("1eaaba04-80ff-43a6-a746-a74a91c5c0e9"),
                Name = "presp8pw_cat.jpg",
                Status = 0,
            },
            new ProductImage()
            {
                Id = new Guid("d5c65161-7591-48c1-9198-daca161bce0c"),
                ProductDetailId = new Guid("1eaaba04-80ff-43a6-a746-a74a91c5c1e0"),
                Name = "presp8pw_01.jpg",
                Status = 0,
            },
            new ProductImage()
            {
                Id = new Guid("d5c65161-7591-48c1-9198-daca161bce1c"),
                ProductDetailId = new Guid("1eaaba04-80ff-43a6-a746-a74a91c5c1e0"),
                Name = "presp8pw_cat.jpg",
                Status = 0,
            },
            new ProductImage()
            {
                Id = new Guid("d5c65161-7591-48c1-9198-daca161bce2c"),
                ProductDetailId = new Guid("1eaaba04-80ff-43a6-a746-a74a91c5c1e1"),
                Name = "presp8pw_01.jpg",
                Status = 0,
            },
            new ProductImage()
            {
                Id = new Guid("d5c65161-7591-48c1-9198-daca161bce3c"),
                ProductDetailId = new Guid("1eaaba04-80ff-43a6-a746-a74a91c5c1e1"),
                Name = "presp8pw_cat.jpg",
                Status = 0,
            },
            new ProductImage()
            {
                Id = new Guid("d5c65161-7591-48c1-9198-daca161bce4c"),
                ProductDetailId = new Guid("1eaaba04-80ff-43a6-a746-a74a91c5c1e2"),
                Name = "presp8pw_01.jpg",
                Status = 0,
            },
            new ProductImage()
            {
                Id = new Guid("d5c65161-7591-48c1-9198-daca161bce5c"),
                ProductDetailId = new Guid("1eaaba04-80ff-43a6-a746-a74a91c5c1e2"),
                Name = "presp8pw_cat.jpg",
                Status = 0,
            },
            new ProductImage()
            {
                Id = new Guid("d5c65161-7591-48c1-9198-daca161bce6c"),
                ProductDetailId = new Guid("1eaaba04-80ff-43a6-a746-a74a91c5c1e3"),
                Name = "presp8pw_01.jpg",
                Status = 0,
            },
            new ProductImage()
            {
                Id = new Guid("d5c65161-7591-48c1-9198-daca161bce7c"),
                ProductDetailId = new Guid("1eaaba04-80ff-43a6-a746-a74a91c5c1e3"),
                Name = "presp8pw_cat.jpg",
                Status = 0,
            },
            new ProductImage()
            {
                Id = new Guid("d5c65161-7591-48c1-9198-daca161bce8c"),
                ProductDetailId = new Guid("1eaaba04-80ff-43a6-a746-a74a91c5c1e4"),
                Name = "presp8pw_01.jpg",
                Status = 0,
            },
            new ProductImage()
            {
                Id = new Guid("d5c65161-7591-48c1-9198-daca161bce9c"),
                ProductDetailId = new Guid("1eaaba04-80ff-43a6-a746-a74a91c5c1e4"),
                Name = "presp8pw_cat.jpg",
                Status = 0,
            },
            new ProductImage()
            {
                Id = new Guid("d5c65161-7591-48c1-9198-daca162bce0c"),
                ProductDetailId = new Guid("1eaaba04-80ff-43a6-a746-a74a91c5c1e5"),
                Name = "presp8pw_01.jpg",
                Status = 0,
            },
            new ProductImage()
            {
                Id = new Guid("d5c65161-7591-48c1-9198-daca162bce1c"),
                ProductDetailId = new Guid("1eaaba04-80ff-43a6-a746-a74a91c5c1e5"),
                Name = "presp8pw_cat.jpg",
                Status = 0,
            },
            new ProductImage()
            {
                Id = new Guid("d5c65161-7591-48c1-9198-daca162bce2c"),
                ProductDetailId = new Guid("1eaaba04-80ff-43a6-a746-a74a91c5c1e6"),
                Name = "presp8pw_01.jpg",
                Status = 0,
            },
            new ProductImage()
            {
                Id = new Guid("d5c65161-7591-48c1-9198-daca162bce3c"),
                ProductDetailId = new Guid("1eaaba04-80ff-43a6-a746-a74a91c5c1e6"),
                Name = "presp8pw_cat.jpg",
                Status = 0,
            },
            new ProductImage()
            {
                Id = new Guid("d5c65161-7591-48c1-9198-daca162bce4c"),
                ProductDetailId = new Guid("1eaaba04-80ff-43a6-a746-a74a91c5c1e7"),
                Name = "presp8pw_01.jpg",
                Status = 0,
            },
            new ProductImage()
            {
                Id = new Guid("d5c65161-7591-48c1-9198-daca162bce5c"),
                ProductDetailId = new Guid("1eaaba04-80ff-43a6-a746-a74a91c5c1e7"),
                Name = "presp8pw_cat.jpg",
                Status = 0,
            },
            new ProductImage()
            {
                Id = new Guid("d5c65161-7591-48c1-9198-daca162bce6c"),
                ProductDetailId = new Guid("1eaaba04-80ff-43a6-a746-a74a91c5c1e8"),
                Name = "presp8pw_01.jpg",
                Status = 0,
            },
            new ProductImage()
            {
                Id = new Guid("d5c65161-7591-48c1-9198-daca162bce7c"),
                ProductDetailId = new Guid("1eaaba04-80ff-43a6-a746-a74a91c5c1e8"),
                Name = "presp8pw_cat.jpg",
                Status = 0,
            },
            new ProductImage()
            {
                Id = new Guid("d5c65161-7591-48c1-9198-daca162bce8c"),
                ProductDetailId = new Guid("1eaaba04-80ff-43a6-a746-a74a91c5c1e9"),
                Name = "presp8pw_01.jpg",
                Status = 0,
            },
            new ProductImage()
            {
                Id = new Guid("d5c65161-7591-48c1-9198-daca162bce9c"),
                ProductDetailId = new Guid("1eaaba04-80ff-43a6-a746-a74a91c5c1e9"),
                Name = "presp8pw_cat.jpg",
                Status = 0,
            },
            new ProductImage()
            {
                Id = new Guid("d5c65161-7591-48c1-9198-daca163bce0c"),
                ProductDetailId = new Guid("1eaaba04-80ff-43a6-a746-a74a91c5c2e0"),
                Name = "presp8pw_01.jpg",
                Status = 0,
            },
            new ProductImage()
            {
                Id = new Guid("d5c65161-7591-48c1-9198-daca163bce1c"),
                ProductDetailId = new Guid("1eaaba04-80ff-43a6-a746-a74a91c5c2e0"),
                Name = "presp8pw_cat.jpg",
                Status = 0,
            },
            new ProductImage()
            {
                Id = new Guid("d5c65161-7591-48c1-9198-daca163bce2c"),
                ProductDetailId = new Guid("1eaaba04-80ff-43a6-a746-a74a91c5c2e1"),
                Name = "presp8pw_01.jpg",
                Status = 0,
            },
            new ProductImage()
            {
                Id = new Guid("d5c65161-7591-48c1-9198-daca163bce3c"),
                ProductDetailId = new Guid("1eaaba04-80ff-43a6-a746-a74a91c5c2e1"),
                Name = "presp8pw_cat.jpg",
                Status = 0,
            },
            new ProductImage()
            {
                Id = new Guid("d5c65161-7591-48c1-9198-daca163bce4c"),
                ProductDetailId = new Guid("1eaaba04-80ff-43a6-a746-a74a91c5c2e2"),
                Name = "presp8pw_01.jpg",
                Status = 0,
            },
            new ProductImage()
            {
                Id = new Guid("d5c65161-7591-48c1-9198-daca163bce5c"),
                ProductDetailId = new Guid("1eaaba04-80ff-43a6-a746-a74a91c5c2e2"),
                Name = "presp8pw_cat.jpg",
                Status = 0,
            },
            new ProductImage()
            {
                Id = new Guid("d5c65161-7591-48c1-9198-daca163bce6c"),
                ProductDetailId = new Guid("1eaaba04-80ff-43a6-a746-a74a91c5c2e3"),
                Name = "presp8pw_01.jpg",
                Status = 0,
            },
            new ProductImage()
            {
                Id = new Guid("d5c65161-7591-48c1-9198-daca163bce7c"),
                ProductDetailId = new Guid("1eaaba04-80ff-43a6-a746-a74a91c5c2e3"),
                Name = "presp8pw_cat.jpg",
                Status = 0,
            },
            new ProductImage()
            {
                Id = new Guid("d5c65161-7591-48c1-9198-daca163bce8c"),
                ProductDetailId = new Guid("1eaaba04-80ff-43a6-a746-a74a91c5c2e4"),
                Name = "presp8pw_01.jpg",
                Status = 0,
            },
            new ProductImage()
            {
                Id = new Guid("d5c65161-7591-48c1-9198-daca163bce9c"),
                ProductDetailId = new Guid("1eaaba04-80ff-43a6-a746-a74a91c5c2e4"),
                Name = "presp8pw_cat.jpg",
                Status = 0,
            },
            new ProductImage()
            {
                Id = new Guid("d5c65161-7591-48c1-9198-daca164bce0c"),
                ProductDetailId = new Guid("1eaaba04-80ff-43a6-a746-a74a91c5c2e5"),
                Name = "presp8pw_01.jpg",
                Status = 0,
            },
            new ProductImage()
            {
                Id = new Guid("d5c65161-7591-48c1-9198-daca164bce1c"),
                ProductDetailId = new Guid("1eaaba04-80ff-43a6-a746-a74a91c5c2e5"),
                Name = "presp8pw_cat.jpg",
                Status = 0,
            },
            new ProductImage()
            {
                Id = new Guid("d5c65161-7591-48c1-9198-daca164bce2c"),
                ProductDetailId = new Guid("1eaaba04-80ff-43a6-a746-a74a91c5c2e6"),
                Name = "presp8pw_01.jpg",
                Status = 0,
            },
            new ProductImage()
            {
                Id = new Guid("d5c65161-7591-48c1-9198-daca164bce3c"),
                ProductDetailId = new Guid("1eaaba04-80ff-43a6-a746-a74a91c5c2e6"),
                Name = "presp8pw_cat.jpg",
                Status = 0,
            },
            new ProductImage()
            {
                Id = new Guid("d5c65161-7591-48c1-9198-daca164bce4c"),
                ProductDetailId = new Guid("1eaaba04-80ff-43a6-a746-a74a91c5c2e7"),
                Name = "presp8pw_01.jpg",
                Status = 0,
            },
            new ProductImage()
            {
                Id = new Guid("d5c65161-7591-48c1-9198-daca164bce5c"),
                ProductDetailId = new Guid("1eaaba04-80ff-43a6-a746-a74a91c5c2e7"),
                Name = "presp8pw_cat.jpg",
                Status = 0,
            },
            new ProductImage()
            {
                Id = new Guid("d5c65161-7591-48c1-9198-daca164bce6c"),
                ProductDetailId = new Guid("1eaaba04-80ff-43a6-a746-a74a91c5c2e8"),
                Name = "presp8pw_01.jpg",
                Status = 0,
            },
            new ProductImage()
            {
                Id = new Guid("d5c65161-7591-48c1-9198-daca164bce7c"),
                ProductDetailId = new Guid("1eaaba04-80ff-43a6-a746-a74a91c5c2e8"),
                Name = "presp8pw_cat.jpg",
                Status = 0,
            },
            new ProductImage()
            {
                Id = new Guid("d5c65161-7591-48c1-9198-daca164bce8c"),
                ProductDetailId = new Guid("1eaaba04-80ff-43a6-a746-a74a91c5c2e9"),
                Name = "presp8pw_01.jpg",
                Status = 0,
            },
            new ProductImage()
            {
                Id = new Guid("d5c65161-7591-48c1-9198-daca164bce9c"),
                ProductDetailId = new Guid("1eaaba04-80ff-43a6-a746-a74a91c5c2e9"),
                Name = "presp8pw_cat.jpg",
                Status = 0,
            },
            new ProductImage()
            {
                Id = new Guid("d5c65161-7591-48c1-9198-daca165bce0c"),
                ProductDetailId = new Guid("1eaaba04-80ff-43a6-a746-a74a91c5c3e0"),
                Name = "presp8pw_01.jpg",
                Status = 0,
            },
            new ProductImage()
            {
                Id = new Guid("d5c65161-7591-48c1-9198-daca165bce1c"),
                ProductDetailId = new Guid("1eaaba04-80ff-43a6-a746-a74a91c5c3e0"),
                Name = "presp8pw_cat.jpg",
                Status = 0,
            },
            new ProductImage()
            {
                Id = new Guid("d5c65161-7591-48c1-9198-daca165bce2c"),
                ProductDetailId = new Guid("1eaaba04-80ff-43a6-a746-a74a91c5c3e1"),
                Name = "presp8pw_01.jpg",
                Status = 0,
            },
            new ProductImage()
            {
                Id = new Guid("d5c65161-7591-48c1-9198-daca165bce3c"),
                ProductDetailId = new Guid("1eaaba04-80ff-43a6-a746-a74a91c5c3e1"),
                Name = "presp8pw_cat.jpg",
                Status = 0,
            },
            new ProductImage()
            {
                Id = new Guid("d5c65161-7591-48c1-9198-daca165bce4c"),
                ProductDetailId = new Guid("1eaaba04-80ff-43a6-a746-a74a91c5c3e2"),
                Name = "presp8pw_01.jpg",
                Status = 0,
            },
            new ProductImage()
            {
                Id = new Guid("d5c65161-7591-48c1-9198-daca165bce5c"),
                ProductDetailId = new Guid("1eaaba04-80ff-43a6-a746-a74a91c5c3e2"),
                Name = "presp8pw_cat.jpg",
                Status = 0,
            },
            new ProductImage()
            {
                Id = new Guid("d5c65161-7591-48c1-9198-daca165bce6c"),
                ProductDetailId = new Guid("1eaaba04-80ff-43a6-a746-a74a91c5c3e3"),
                Name = "presp8pw_01.jpg",
                Status = 0,
            },
            new ProductImage()
            {
                Id = new Guid("d5c65161-7591-48c1-9198-daca166bce7c"),
                ProductDetailId = new Guid("1eaaba04-80ff-43a6-a746-a74a91c5c3e3"),
                Name = "presp8pw_cat.jpg",
                Status = 0,
            },
            new ProductImage()
            {
                Id = new Guid("d5c65161-7591-48c1-9198-daca166bce8c"),
                ProductDetailId = new Guid("1eaaba04-80ff-43a6-a746-a74a91c5c3e4"),
                Name = "presp8pw_01.jpg",
                Status = 0,
            },
            new ProductImage()
            {
                Id = new Guid("d5c65161-7591-48c1-9198-daca166bce9c"),
                ProductDetailId = new Guid("1eaaba04-80ff-43a6-a746-a74a91c5c3e4"),
                Name = "presp8pw_cat.jpg",
                Status = 0,
            },
            new ProductImage()
            {
                Id = new Guid("d5c65161-7591-48c1-9198-daca167bce0c"),
                ProductDetailId = new Guid("1eaaba04-80ff-43a6-a746-a74a91c5c3e5"),
                Name = "presp8pw_01.jpg",
                Status = 0,
            },
            new ProductImage()
            {
                Id = new Guid("d5c65161-7591-48c1-9198-daca167bce1c"),
                ProductDetailId = new Guid("1eaaba04-80ff-43a6-a746-a74a91c5c3e5"),
                Name = "presp8pw_cat.jpg",
                Status = 0,
            },
            new ProductImage()
            {
                Id = new Guid("d5c65161-7591-48c1-9198-daca167bce2c"),
                ProductDetailId = new Guid("1eaaba04-80ff-43a6-a746-a74a91c5c3e6"),
                Name = "presp8pw_01.jpg",
                Status = 0,
            },
            new ProductImage()
            {
                Id = new Guid("d5c65161-7591-48c1-9198-daca167bce3c"),
                ProductDetailId = new Guid("1eaaba04-80ff-43a6-a746-a74a91c5c3e6"),
                Name = "presp8pw_cat.jpg",
                Status = 0,
            },
            new ProductImage()
            {
                Id = new Guid("d5c65161-7591-48c1-9198-daca167bce4c"),
                ProductDetailId = new Guid("1eaaba04-80ff-43a6-a746-a74a91c5c3e7"),
                Name = "presp8pw_01.jpg",
                Status = 0,
            },
            new ProductImage()
            {
                Id = new Guid("d5c65161-7591-48c1-9198-daca167bce5c"),
                ProductDetailId = new Guid("1eaaba04-80ff-43a6-a746-a74a91c5c3e7"),
                Name = "presp8pw_cat.jpg",
                Status = 0,
            },
            new ProductImage()
            {
                Id = new Guid("d5c65161-7591-48c1-9198-daca167bce6c"),
                ProductDetailId = new Guid("1eaaba04-80ff-43a6-a746-a74a91c5c3e8"),
                Name = "presp8pw_01.jpg",
                Status = 0,
            },
            new ProductImage()
            {
                Id = new Guid("d5c65161-7591-48c1-9198-daca167bce7c"),
                ProductDetailId = new Guid("1eaaba04-80ff-43a6-a746-a74a91c5c3e8"),
                Name = "presp8pw_cat.jpg",
                Status = 0,
            },
            new ProductImage()
            {
                Id = new Guid("d5c65161-7591-48c1-9198-daca167bce8c"),
                ProductDetailId = new Guid("1eaaba04-80ff-43a6-a746-a74a91c5c3e9"),
                Name = "presp8pw_01.jpg",
                Status = 0,
            },
            new ProductImage()
            {
                Id = new Guid("d5c65161-7591-48c1-9198-daca167bce9c"),
                ProductDetailId = new Guid("1eaaba04-80ff-43a6-a746-a74a91c5c3e9"),
                Name = "presp8pw_cat.jpg",
                Status = 0,
            },
            new ProductImage()
            {
                Id = new Guid("d5c65161-7591-48c1-9198-daca168bce0c"),
                ProductDetailId = new Guid("1eaaba04-80ff-43a6-a746-a74a91c6c0e0"),
                Name = "presp8pw_01.jpg",
                Status = 0,
            },
            new ProductImage()
            {
                Id = new Guid("d5c65161-7591-48c1-9198-daca168bce1c"),
                ProductDetailId = new Guid("1eaaba04-80ff-43a6-a746-a74a91c6c0e0"),
                Name = "presp8pw_cat.jpg",
                Status = 0,
            },
            new ProductImage()
            {
                Id = new Guid("d5c65161-7591-48c1-9198-daca168bce2c"),
                ProductDetailId = new Guid("1eaaba04-80ff-43a6-a746-a74a91c6c0e1"),
                Name = "presp8pw_01.jpg",
                Status = 0,
            },
            new ProductImage()
            {
                Id = new Guid("d5c65161-7591-48c1-9198-daca168bce3c"),
                ProductDetailId = new Guid("1eaaba04-80ff-43a6-a746-a74a91c6c0e1"),
                Name = "presp8pw_cat.jpg",
                Status = 0,
            },
            new ProductImage()
            {
                Id = new Guid("d5c65161-7591-48c1-9198-daca168bce4c"),
                ProductDetailId = new Guid("1eaaba04-80ff-43a6-a746-a74a91c6c0e2"),
                Name = "presp8pw_01.jpg",
                Status = 0,
            },
            new ProductImage()
            {
                Id = new Guid("d5c65161-7591-48c1-9198-daca168bce5c"),
                ProductDetailId = new Guid("1eaaba04-80ff-43a6-a746-a74a91c6c0e2"),
                Name = "presp8pw_cat.jpg",
                Status = 0,
            },
            new ProductImage()
            {
                Id = new Guid("d5c65161-7591-48c1-9198-daca168bce6c"),
                ProductDetailId = new Guid("1eaaba04-80ff-43a6-a746-a74a91c6c0e3"),
                Name = "presp8pw_01.jpg",
                Status = 0,
            },
            new ProductImage()
            {
                Id = new Guid("d5c65161-7591-48c1-9198-daca168bce7c"),
                ProductDetailId = new Guid("1eaaba04-80ff-43a6-a746-a74a91c6c0e3"),
                Name = "presp8pw_cat.jpg",
                Status = 0,
            },
            new ProductImage()
            {
                Id = new Guid("d5c65161-7591-48c1-9198-daca168bce8c"),
                ProductDetailId = new Guid("1eaaba04-80ff-43a6-a746-a74a91c6c0e4"),
                Name = "presp8pw_01.jpg",
                Status = 0,
            },
            new ProductImage()
            {
                Id = new Guid("d5c65161-7591-48c1-9198-daca168bce9c"),
                ProductDetailId = new Guid("1eaaba04-80ff-43a6-a746-a74a91c6c0e4"),
                Name = "presp8pw_cat.jpg",
                Status = 0,
            },
            new ProductImage()
            {
                Id = new Guid("d5c65161-7591-48c1-9198-daca169bce0c"),
                ProductDetailId = new Guid("1eaaba04-80ff-43a6-a746-a74a91c6c0e5"),
                Name = "presp8pw_01.jpg",
                Status = 0,
            },
            new ProductImage()
            {
                Id = new Guid("d5c65161-7591-48c1-9198-daca169bce1c"),
                ProductDetailId = new Guid("1eaaba04-80ff-43a6-a746-a74a91c6c0e5"),
                Name = "presp8pw_cat.jpg",
                Status = 0,
            },
            new ProductImage()
            {
                Id = new Guid("d5c65161-7591-48c1-9198-daca169bce2c"),
                ProductDetailId = new Guid("1eaaba04-80ff-43a6-a746-a74a91c6c0e6"),
                Name = "presp8pw_01.jpg",
                Status = 0,
            },
            new ProductImage()
            {
                Id = new Guid("d5c65161-7591-48c1-9198-daca169bce3c"),
                ProductDetailId = new Guid("1eaaba04-80ff-43a6-a746-a74a91c6c0e6"),
                Name = "presp8pw_cat.jpg",
                Status = 0,
            },
            new ProductImage()
            {
                Id = new Guid("d5c65161-7591-48c1-9198-daca169bce4c"),
                ProductDetailId = new Guid("1eaaba04-80ff-43a6-a746-a74a91c6c0e7"),
                Name = "presp8pw_01.jpg",
                Status = 0,
            },
            new ProductImage()
            {
                Id = new Guid("d5c65161-7591-48c1-9198-daca169bce5c"),
                ProductDetailId = new Guid("1eaaba04-80ff-43a6-a746-a74a91c6c0e7"),
                Name = "presp8pw_cat.jpg",
                Status = 0,
            },
            new ProductImage()
            {
                Id = new Guid("d5c65161-7591-48c1-9198-daca169bce6c"),
                ProductDetailId = new Guid("1eaaba04-80ff-43a6-a746-a74a91c6c0e8"),
                Name = "presp8pw_01.jpg",
                Status = 0,
            },
            new ProductImage()
            {
                Id = new Guid("d5c65161-7591-48c1-9198-daca169bce7c"),
                ProductDetailId = new Guid("1eaaba04-80ff-43a6-a746-a74a91c6c0e8"),
                Name = "presp8pw_cat.jpg",
                Status = 0,
            },
            new ProductImage()
            {
                Id = new Guid("d5c65161-7591-48c1-9198-daca169bce8c"),
                ProductDetailId = new Guid("1eaaba04-80ff-43a6-a746-a74a91c6c0e9"),
                Name = "presp8pw_01.jpg",
                Status = 0,
            },
            new ProductImage()
            {
                Id = new Guid("d5c65161-7591-48c1-9198-daca169bce9c"),
                ProductDetailId = new Guid("1eaaba04-80ff-43a6-a746-a74a91c6c0e9"),
                Name = "presp8pw_cat.jpg",
                Status = 0,
            },
            new ProductImage()
            {
                Id = new Guid("d5c65161-7591-48c1-9198-daca170bce0c"),
                ProductDetailId = new Guid("1eaaba04-80ff-43a6-a746-a74a91c6c1e0"),
                Name = "presp8pw_01.jpg",
                Status = 0,
            },
            new ProductImage()
            {
                Id = new Guid("d5c65161-7591-48c1-9198-daca170bce1c"),
                ProductDetailId = new Guid("1eaaba04-80ff-43a6-a746-a74a91c6c1e0"),
                Name = "presp8pw_cat.jpg",
                Status = 0,
            },
            new ProductImage()
            {
                Id = new Guid("d5c65161-7591-48c1-9198-daca170bce2c"),
                ProductDetailId = new Guid("1eaaba04-80ff-43a6-a746-a74a91c6c1e1"),
                Name = "presp8pw_01.jpg",
                Status = 0,
            },
            new ProductImage()
            {
                Id = new Guid("d5c65161-7591-48c1-9198-daca170bce3c"),
                ProductDetailId = new Guid("1eaaba04-80ff-43a6-a746-a74a91c6c1e1"),
                Name = "presp8pw_cat.jpg",
                Status = 0,
            },
            new ProductImage()
            {
                Id = new Guid("d5c65161-7591-48c1-9198-daca170bce4c"),
                ProductDetailId = new Guid("1eaaba04-80ff-43a6-a746-a74a91c6c1e2"),
                Name = "presp8pw_01.jpg",
                Status = 0,
            },
            new ProductImage()
            {
                Id = new Guid("d5c65161-7591-48c1-9198-daca170bce5c"),
                ProductDetailId = new Guid("1eaaba04-80ff-43a6-a746-a74a91c6c1e2"),
                Name = "presp8pw_cat.jpg",
                Status = 0,
            },
            new ProductImage()
            {
                Id = new Guid("d5c65161-7591-48c1-9198-daca170bce6c"),
                ProductDetailId = new Guid("1eaaba04-80ff-43a6-a746-a74a91c6c1e3"),
                Name = "presp8pw_01.jpg",
                Status = 0,
            },
            new ProductImage()
            {
                Id = new Guid("d5c65161-7591-48c1-9198-daca170bce7c"),
                ProductDetailId = new Guid("1eaaba04-80ff-43a6-a746-a74a91c6c1e3"),
                Name = "presp8pw_cat.jpg",
                Status = 0,
            },
            new ProductImage()
            {
                Id = new Guid("d5c65161-7591-48c1-9198-daca170bce8c"),
                ProductDetailId = new Guid("1eaaba04-80ff-43a6-a746-a74a91c6c1e4"),
                Name = "presp8pw_01.jpg",
                Status = 0,
            },
            new ProductImage()
            {
                Id = new Guid("d5c65161-7591-48c1-9198-daca170bce9c"),
                ProductDetailId = new Guid("1eaaba04-80ff-43a6-a746-a74a91c6c1e4"),
                Name = "presp8pw_cat.jpg",
                Status = 0,
            },
            new ProductImage()
            {
                Id = new Guid("d5c65161-7591-48c1-9198-daca171bce0c"),
                ProductDetailId = new Guid("1eaaba04-80ff-43a6-a746-a74a91c6c1e5"),
                Name = "presp8pw_01.jpg",
                Status = 0,
            },
            new ProductImage()
            {
                Id = new Guid("d5c65161-7591-48c1-9198-daca171bce1c"),
                ProductDetailId = new Guid("1eaaba04-80ff-43a6-a746-a74a91c6c1e5"),
                Name = "presp8pw_cat.jpg",
                Status = 0,
            },
            new ProductImage()
            {
                Id = new Guid("d5c65161-7591-48c1-9198-daca171bce2c"),
                ProductDetailId = new Guid("1eaaba04-80ff-43a6-a746-a74a91c6c1e6"),
                Name = "presp8pw_01.jpg",
                Status = 0,
            },
            new ProductImage()
            {
                Id = new Guid("d5c65161-7591-48c1-9198-daca171bce3c"),
                ProductDetailId = new Guid("1eaaba04-80ff-43a6-a746-a74a91c6c1e6"),
                Name = "presp8pw_cat.jpg",
                Status = 0,
            },
            new ProductImage()
            {
                Id = new Guid("d5c65161-7591-48c1-9198-daca171bce4c"),
                ProductDetailId = new Guid("1eaaba04-80ff-43a6-a746-a74a91c6c1e7"),
                Name = "presp8pw_01.jpg",
                Status = 0,
            },
            new ProductImage()
            {
                Id = new Guid("d5c65161-7591-48c1-9198-daca171bce5c"),
                ProductDetailId = new Guid("1eaaba04-80ff-43a6-a746-a74a91c6c1e7"),
                Name = "presp8pw_cat.jpg",
                Status = 0,
            },
            new ProductImage()
            {
                Id = new Guid("d5c65161-7591-48c1-9198-daca171bce6c"),
                ProductDetailId = new Guid("1eaaba04-80ff-43a6-a746-a74a91c6c1e8"),
                Name = "presp8pw_01.jpg",
                Status = 0,
            },
            new ProductImage()
            {
                Id = new Guid("d5c65161-7591-48c1-9198-daca171bce7c"),
                ProductDetailId = new Guid("1eaaba04-80ff-43a6-a746-a74a91c6c1e8"),
                Name = "presp8pw_cat.jpg",
                Status = 0,
            },
            new ProductImage()
            {
                Id = new Guid("d5c65161-7591-48c1-9198-daca171bce8c"),
                ProductDetailId = new Guid("1eaaba04-80ff-43a6-a746-a74a91c6c1e9"),
                Name = "presp8pw_01.jpg",
                Status = 0,
            },
            new ProductImage()
            {
                Id = new Guid("d5c65161-7591-48c1-9198-daca171bce9c"),
                ProductDetailId = new Guid("1eaaba04-80ff-43a6-a746-a74a91c6c1e9"),
                Name = "presp8pw_cat.jpg",
                Status = 0,
            },
            new ProductImage()
            {
                Id = new Guid("d5c65161-7591-48c1-9198-daca172bce0c"),
                ProductDetailId = new Guid("1eaaba04-80ff-43a6-a746-a74a91c6c2e0"),
                Name = "presp8pw_01.jpg",
                Status = 0,
            },
            new ProductImage()
            {
                Id = new Guid("d5c65161-7591-48c1-9198-daca172bce1c"),
                ProductDetailId = new Guid("1eaaba04-80ff-43a6-a746-a74a91c6c2e0"),
                Name = "presp8pw_cat.jpg",
                Status = 0,
            },
            new ProductImage()
            {
                Id = new Guid("d5c65161-7591-48c1-9198-daca172bce2c"),
                ProductDetailId = new Guid("1eaaba04-80ff-43a6-a746-a74a91c6c2e1"),
                Name = "presp8pw_01.jpg",
                Status = 0,
            },
            new ProductImage()
            {
                Id = new Guid("d5c65161-7591-48c1-9198-daca172bce3c"),
                ProductDetailId = new Guid("1eaaba04-80ff-43a6-a746-a74a91c6c2e1"),
                Name = "presp8pw_cat.jpg",
                Status = 0,
            },
            new ProductImage()
            {
                Id = new Guid("d5c65161-7591-48c1-9198-daca172bce4c"),
                ProductDetailId = new Guid("1eaaba04-80ff-43a6-a746-a74a91c6c2e2"),
                Name = "presp8pw_01.jpg",
                Status = 0,
            },
            new ProductImage()
            {
                Id = new Guid("d5c65161-7591-48c1-9198-daca172bce5c"),
                ProductDetailId = new Guid("1eaaba04-80ff-43a6-a746-a74a91c6c2e2"),
                Name = "presp8pw_cat.jpg",
                Status = 0,
            },
            new ProductImage()
            {
                Id = new Guid("d5c65161-7591-48c1-9198-daca172bce6c"),
                ProductDetailId = new Guid("1eaaba04-80ff-43a6-a746-a74a91c6c2e3"),
                Name = "presp8pw_01.jpg",
                Status = 0,
            },
            new ProductImage()
            {
                Id = new Guid("d5c65161-7591-48c1-9198-daca172bce7c"),
                ProductDetailId = new Guid("1eaaba04-80ff-43a6-a746-a74a91c6c2e3"),
                Name = "presp8pw_cat.jpg",
                Status = 0,
            },
            new ProductImage()
            {
                Id = new Guid("d5c65161-7591-48c1-9198-daca172bce8c"),
                ProductDetailId = new Guid("1eaaba04-80ff-43a6-a746-a74a91c6c2e4"),
                Name = "presp8pw_01.jpg",
                Status = 0,
            },
            new ProductImage()
            {
                Id = new Guid("d5c65161-7591-48c1-9198-daca172bce9c"),
                ProductDetailId = new Guid("1eaaba04-80ff-43a6-a746-a74a91c6c2e4"),
                Name = "presp8pw_cat.jpg",
                Status = 0,
            },
            new ProductImage()
            {
                Id = new Guid("d5c65161-7591-48c1-9198-daca173bce0c"),
                ProductDetailId = new Guid("1eaaba04-80ff-43a6-a746-a74a91c6c2e5"),
                Name = "presp8pw_01.jpg",
                Status = 0,
            },
            new ProductImage()
            {
                Id = new Guid("d5c65161-7591-48c1-9198-daca173bce1c"),
                ProductDetailId = new Guid("1eaaba04-80ff-43a6-a746-a74a91c6c2e5"),
                Name = "presp8pw_cat.jpg",
                Status = 0,
            },
            new ProductImage()
            {
                Id = new Guid("d5c65161-7591-48c1-9198-daca173bce2c"),
                ProductDetailId = new Guid("1eaaba04-80ff-43a6-a746-a74a91c6c2e6"),
                Name = "presp8pw_01.jpg",
                Status = 0,
            },
            new ProductImage()
            {
                Id = new Guid("d5c65161-7591-48c1-9198-daca173bce3c"),
                ProductDetailId = new Guid("1eaaba04-80ff-43a6-a746-a74a91c6c2e6"),
                Name = "presp8pw_cat.jpg",
                Status = 0,
            },
            new ProductImage()
            {
                Id = new Guid("d5c65161-7591-48c1-9198-daca173bce4c"),
                ProductDetailId = new Guid("1eaaba04-80ff-43a6-a746-a74a91c6c2e7"),
                Name = "presp8pw_01.jpg",
                Status = 0,
            },
            new ProductImage()
            {
                Id = new Guid("d5c65161-7591-48c1-9198-daca173bce5c"),
                ProductDetailId = new Guid("1eaaba04-80ff-43a6-a746-a74a91c6c2e7"),
                Name = "presp8pw_cat.jpg",
                Status = 0,
            },
            new ProductImage()
            {
                Id = new Guid("d5c65161-7591-48c1-9198-daca173bce6c"),
                ProductDetailId = new Guid("1eaaba04-80ff-43a6-a746-a74a91c6c2e8"),
                Name = "presp8pw_01.jpg",
                Status = 0,
            },
            new ProductImage()
            {
                Id = new Guid("d5c65161-7591-48c1-9198-daca173bce7c"),
                ProductDetailId = new Guid("1eaaba04-80ff-43a6-a746-a74a91c6c2e8"),
                Name = "presp8pw_cat.jpg",
                Status = 0,
            },
            new ProductImage()
            {
                Id = new Guid("d5c65161-7591-48c1-9198-daca173bce8c"),
                ProductDetailId = new Guid("1eaaba04-80ff-43a6-a746-a74a91c6c2e9"),
                Name = "presp8pw_01.jpg",
                Status = 0,
            },
            new ProductImage()
            {
                Id = new Guid("d5c65161-7591-48c1-9198-daca173bce9c"),
                ProductDetailId = new Guid("1eaaba04-80ff-43a6-a746-a74a91c6c2e9"),
                Name = "presp8pw_cat.jpg",
                Status = 0,
            },
            new ProductImage()
            {
                Id = new Guid("d5c65161-7591-48c1-9198-daca174bce0c"),
                ProductDetailId = new Guid("1eaaba04-80ff-43a6-a746-a74a91c6c3e0"),
                Name = "presp8pw_01.jpg",
                Status = 0,
            },
            new ProductImage()
            {
                Id = new Guid("d5c65161-7591-48c1-9198-daca174bce1c"),
                ProductDetailId = new Guid("1eaaba04-80ff-43a6-a746-a74a91c6c3e0"),
                Name = "presp8pw_cat.jpg",
                Status = 0,
            },
            new ProductImage()
            {
                Id = new Guid("d5c65161-7591-48c1-9198-daca174bce2c"),
                ProductDetailId = new Guid("1eaaba04-80ff-43a6-a746-a74a91c6c3e1"),
                Name = "presp8pw_01.jpg",
                Status = 0,
            },
            new ProductImage()
            {
                Id = new Guid("d5c65161-7591-48c1-9198-daca174bce3c"),
                ProductDetailId = new Guid("1eaaba04-80ff-43a6-a746-a74a91c6c3e1"),
                Name = "presp8pw_cat.jpg",
                Status = 0,
            },
            new ProductImage()
            {
                Id = new Guid("d5c65161-7591-48c1-9198-daca174bce4c"),
                ProductDetailId = new Guid("1eaaba04-80ff-43a6-a746-a74a91c6c3e2"),
                Name = "presp8pw_01.jpg",
                Status = 0,
            },
            new ProductImage()
            {
                Id = new Guid("d5c65161-7591-48c1-9198-daca174bce5c"),
                ProductDetailId = new Guid("1eaaba04-80ff-43a6-a746-a74a91c6c3e2"),
                Name = "presp8pw_cat.jpg",
                Status = 0,
            },
            new ProductImage()
            {
                Id = new Guid("d5c65161-7591-48c1-9198-daca174bce6c"),
                ProductDetailId = new Guid("1eaaba04-80ff-43a6-a746-a74a91c6c3e3"),
                Name = "presp8pw_01.jpg",
                Status = 0,
            },
            new ProductImage()
            {
                Id = new Guid("d5c65161-7591-48c1-9198-daca174bce7c"),
                ProductDetailId = new Guid("1eaaba04-80ff-43a6-a746-a74a91c6c3e3"),
                Name = "presp8pw_cat.jpg",
                Status = 0,
            },
            new ProductImage()
            {
                Id = new Guid("d5c65161-7591-48c1-9198-daca174bce8c"),
                ProductDetailId = new Guid("1eaaba04-80ff-43a6-a746-a74a91c6c3e4"),
                Name = "presp8pw_01.jpg",
                Status = 0,
            },
            new ProductImage()
            {
                Id = new Guid("d5c65161-7591-48c1-9198-daca174bce9c"),
                ProductDetailId = new Guid("1eaaba04-80ff-43a6-a746-a74a91c6c3e4"),
                Name = "presp8pw_cat.jpg",
                Status = 0,
            },
            new ProductImage()
            {
                Id = new Guid("d5c65161-7591-48c1-9198-daca175bce0c"),
                ProductDetailId = new Guid("1eaaba04-80ff-43a6-a746-a74a91c6c3e5"),
                Name = "presp8pw_01.jpg",
                Status = 0,
            },
            new ProductImage()
            {
                Id = new Guid("d5c65161-7591-48c1-9198-daca175bce1c"),
                ProductDetailId = new Guid("1eaaba04-80ff-43a6-a746-a74a91c6c3e5"),
                Name = "presp8pw_cat.jpg",
                Status = 0,
            },
            new ProductImage()
            {
                Id = new Guid("d5c65161-7591-48c1-9198-daca175bce2c"),
                ProductDetailId = new Guid("1eaaba04-80ff-43a6-a746-a74a91c6c3e6"),
                Name = "presp8pw_01.jpg",
                Status = 0,
            },
            new ProductImage()
            {
                Id = new Guid("d5c65161-7591-48c1-9198-daca175bce3c"),
                ProductDetailId = new Guid("1eaaba04-80ff-43a6-a746-a74a91c6c3e6"),
                Name = "presp8pw_cat.jpg",
                Status = 0,
            },
            new ProductImage()
            {
                Id = new Guid("d5c65161-7591-48c1-9198-daca175bce4c"),
                ProductDetailId = new Guid("1eaaba04-80ff-43a6-a746-a74a91c6c3e7"),
                Name = "presp8pw_01.jpg",
                Status = 0,
            },
            new ProductImage()
            {
                Id = new Guid("d5c65161-7591-48c1-9198-daca175bce5c"),
                ProductDetailId = new Guid("1eaaba04-80ff-43a6-a746-a74a91c6c3e7"),
                Name = "presp8pw_cat.jpg",
                Status = 0,
            },
            new ProductImage()
            {
                Id = new Guid("d5c65161-7591-48c1-9198-daca175bce6c"),
                ProductDetailId = new Guid("1eaaba04-80ff-43a6-a746-a74a91c6c3e8"),
                Name = "presp8pw_01.jpg",
                Status = 0,
            },
            new ProductImage()
            {
                Id = new Guid("d5c65161-7591-48c1-9198-daca175bce7c"),
                ProductDetailId = new Guid("1eaaba04-80ff-43a6-a746-a74a91c6c3e8"),
                Name = "presp8pw_cat.jpg",
                Status = 0,
            },
            new ProductImage()
            {
                Id = new Guid("d5c65161-7591-48c1-9198-daca175bce8c"),
                ProductDetailId = new Guid("1eaaba04-80ff-43a6-a746-a74a91c6c3e9"),
                Name = "presp8pw_01.jpg",
                Status = 0,
            },
            new ProductImage()
            {
                Id = new Guid("d5c65161-7591-48c1-9198-daca175bce9c"),
                ProductDetailId = new Guid("1eaaba04-80ff-43a6-a746-a74a91c6c3e9"),
                Name = "presp8pw_cat.jpg",
                Status = 0,
            },
            new ProductImage()
            {
                Id = new Guid("d5c65161-7591-48c1-9198-daca176bce0c"),
                ProductDetailId = new Guid("1eaaba04-80ff-43a6-a746-a74a91c7c0e0"),
                Name = "presp8pw_01.jpg",
                Status = 0,
            },
            new ProductImage()
            {
                Id = new Guid("d5c65161-7591-48c1-9198-daca176bce1c"),
                ProductDetailId = new Guid("1eaaba04-80ff-43a6-a746-a74a91c7c0e0"),
                Name = "presp8pw_cat.jpg",
                Status = 0,
            },
            new ProductImage()
            {
                Id = new Guid("d5c65161-7591-48c1-9198-daca176bce2c"),
                ProductDetailId = new Guid("1eaaba04-80ff-43a6-a746-a74a91c7c0e1"),
                Name = "presp8pw_01.jpg",
                Status = 0,
            },
            new ProductImage()
            {
                Id = new Guid("d5c65161-7591-48c1-9198-daca176bce3c"),
                ProductDetailId = new Guid("1eaaba04-80ff-43a6-a746-a74a91c7c0e1"),
                Name = "presp8pw_cat.jpg",
                Status = 0,
            },
            new ProductImage()
            {
                Id = new Guid("d5c65161-7591-48c1-9198-daca176bce4c"),
                ProductDetailId = new Guid("1eaaba04-80ff-43a6-a746-a74a91c7c0e2"),
                Name = "presp8pw_01.jpg",
                Status = 0,
            },
            new ProductImage()
            {
                Id = new Guid("d5c65161-7591-48c1-9198-daca176bce5c"),
                ProductDetailId = new Guid("1eaaba04-80ff-43a6-a746-a74a91c7c0e2"),
                Name = "presp8pw_cat.jpg",
                Status = 0,
            },
            new ProductImage()
            {
                Id = new Guid("d5c65161-7591-48c1-9198-daca176bce6c"),
                ProductDetailId = new Guid("1eaaba04-80ff-43a6-a746-a74a91c7c0e3"),
                Name = "presp8pw_01.jpg",
                Status = 0,
            },
            new ProductImage()
            {
                Id = new Guid("d5c65161-7591-48c1-9198-daca176bce7c"),
                ProductDetailId = new Guid("1eaaba04-80ff-43a6-a746-a74a91c7c0e3"),
                Name = "presp8pw_cat.jpg",
                Status = 0,
            },
            new ProductImage()
            {
                Id = new Guid("d5c65161-7591-48c1-9198-daca176bce8c"),
                ProductDetailId = new Guid("1eaaba04-80ff-43a6-a746-a74a91c7c0e4"),
                Name = "presp8pw_01.jpg",
                Status = 0,
            },
            new ProductImage()
            {
                Id = new Guid("d5c65161-7591-48c1-9198-daca176bce9c"),
                ProductDetailId = new Guid("1eaaba04-80ff-43a6-a746-a74a91c7c0e4"),
                Name = "presp8pw_cat.jpg",
                Status = 0,
            },
            new ProductImage()
            {
                Id = new Guid("d5c65161-7591-48c1-9198-daca177bce0c"),
                ProductDetailId = new Guid("1eaaba04-80ff-43a6-a746-a74a91c7c0e5"),
                Name = "presp8pw_01.jpg",
                Status = 0,
            },
            new ProductImage()
            {
                Id = new Guid("d5c65161-7591-48c1-9198-daca177bce1c"),
                ProductDetailId = new Guid("1eaaba04-80ff-43a6-a746-a74a91c7c0e5"),
                Name = "presp8pw_cat.jpg",
                Status = 0,
            },
            new ProductImage()
            {
                Id = new Guid("d5c65161-7591-48c1-9198-daca177bce2c"),
                ProductDetailId = new Guid("1eaaba04-80ff-43a6-a746-a74a91c7c0e6"),
                Name = "presp8pw_01.jpg",
                Status = 0,
            },
            new ProductImage()
            {
                Id = new Guid("d5c65161-7591-48c1-9198-daca177bce3c"),
                ProductDetailId = new Guid("1eaaba04-80ff-43a6-a746-a74a91c7c0e6"),
                Name = "presp8pw_cat.jpg",
                Status = 0,
            },
            new ProductImage()
            {
                Id = new Guid("d5c65161-7591-48c1-9198-daca177bce4c"),
                ProductDetailId = new Guid("1eaaba04-80ff-43a6-a746-a74a91c7c0e7"),
                Name = "presp8pw_01.jpg",
                Status = 0,
            },
            new ProductImage()
            {
                Id = new Guid("d5c65161-7591-48c1-9198-daca177bce5c"),
                ProductDetailId = new Guid("1eaaba04-80ff-43a6-a746-a74a91c7c0e7"),
                Name = "presp8pw_cat.jpg",
                Status = 0,
            },
            new ProductImage()
            {
                Id = new Guid("d5c65161-7591-48c1-9198-daca177bce6c"),
                ProductDetailId = new Guid("1eaaba04-80ff-43a6-a746-a74a91c7c0e8"),
                Name = "presp8pw_01.jpg",
                Status = 0,
            },
            new ProductImage()
            {
                Id = new Guid("d5c65161-7591-48c1-9198-daca177bce7c"),
                ProductDetailId = new Guid("1eaaba04-80ff-43a6-a746-a74a91c7c0e8"),
                Name = "presp8pw_cat.jpg",
                Status = 0,
            },
            new ProductImage()
            {
                Id = new Guid("d5c65161-7591-48c1-9198-daca177bce8c"),
                ProductDetailId = new Guid("1eaaba04-80ff-43a6-a746-a74a91c7c0e9"),
                Name = "presp8pw_01.jpg",
                Status = 0,
            },
            new ProductImage()
            {
                Id = new Guid("d5c65161-7591-48c1-9198-daca177bce9c"),
                ProductDetailId = new Guid("1eaaba04-80ff-43a6-a746-a74a91c7c0e9"),
                Name = "presp8pw_cat.jpg",
                Status = 0,
            },
            new ProductImage()
            {
                Id = new Guid("d5c65161-7591-48c1-9198-daca178bce0c"),
                ProductDetailId = new Guid("1eaaba04-80ff-43a6-a746-a74a91c7c1e0"),
                Name = "presp8pw_01.jpg",
                Status = 0,
            },
            new ProductImage()
            {
                Id = new Guid("d5c65161-7591-48c1-9198-daca178bce1c"),
                ProductDetailId = new Guid("1eaaba04-80ff-43a6-a746-a74a91c7c1e0"),
                Name = "presp8pw_cat.jpg",
                Status = 0,
            },
            new ProductImage()
            {
                Id = new Guid("d5c65161-7591-48c1-9198-daca178bce2c"),
                ProductDetailId = new Guid("1eaaba04-80ff-43a6-a746-a74a91c7c1e1"),
                Name = "presp8pw_01.jpg",
                Status = 0,
            },
            new ProductImage()
            {
                Id = new Guid("d5c65161-7591-48c1-9198-daca178bce3c"),
                ProductDetailId = new Guid("1eaaba04-80ff-43a6-a746-a74a91c7c1e1"),
                Name = "presp8pw_cat.jpg",
                Status = 0,
            },
            new ProductImage()
            {
                Id = new Guid("d5c65161-7591-48c1-9198-daca178bce4c"),
                ProductDetailId = new Guid("1eaaba04-80ff-43a6-a746-a74a91c7c1e2"),
                Name = "presp8pw_01.jpg",
                Status = 0,
            },
            new ProductImage()
            {
                Id = new Guid("d5c65161-7591-48c1-9198-daca178bce5c"),
                ProductDetailId = new Guid("1eaaba04-80ff-43a6-a746-a74a91c7c1e2"),
                Name = "presp8pw_cat.jpg",
                Status = 0,
            },
            new ProductImage()
            {
                Id = new Guid("d5c65161-7591-48c1-9198-daca178bce6c"),
                ProductDetailId = new Guid("1eaaba04-80ff-43a6-a746-a74a91c7c1e3"),
                Name = "presp8pw_01.jpg",
                Status = 0,
            },
            new ProductImage()
            {
                Id = new Guid("d5c65161-7591-48c1-9198-daca178bce7c"),
                ProductDetailId = new Guid("1eaaba04-80ff-43a6-a746-a74a91c7c1e3"),
                Name = "presp8pw_cat.jpg",
                Status = 0,
            },
            new ProductImage()
            {
                Id = new Guid("d5c65161-7591-48c1-9198-daca178bce8c"),
                ProductDetailId = new Guid("1eaaba04-80ff-43a6-a746-a74a91c7c1e4"),
                Name = "presp8pw_01.jpg",
                Status = 0,
            },
            new ProductImage()
            {
                Id = new Guid("d5c65161-7591-48c1-9198-daca178bce9c"),
                ProductDetailId = new Guid("1eaaba04-80ff-43a6-a746-a74a91c7c1e4"),
                Name = "presp8pw_cat.jpg",
                Status = 0,
            },
            new ProductImage()
            {
                Id = new Guid("d5c65161-7591-48c1-9198-daca179bce0c"),
                ProductDetailId = new Guid("1eaaba04-80ff-43a6-a746-a74a91c7c1e5"),
                Name = "presp8pw_01.jpg",
                Status = 0,
            },
            new ProductImage()
            {
                Id = new Guid("d5c65161-7591-48c1-9198-daca179bce1c"),
                ProductDetailId = new Guid("1eaaba04-80ff-43a6-a746-a74a91c7c1e5"),
                Name = "presp8pw_cat.jpg",
                Status = 0,
            },
            new ProductImage()
            {
                Id = new Guid("d5c65161-7591-48c1-9198-daca179bce2c"),
                ProductDetailId = new Guid("1eaaba04-80ff-43a6-a746-a74a91c7c1e6"),
                Name = "presp8pw_01.jpg",
                Status = 0,
            },
            new ProductImage()
            {
                Id = new Guid("d5c65161-7591-48c1-9198-daca179bce3c"),
                ProductDetailId = new Guid("1eaaba04-80ff-43a6-a746-a74a91c7c1e6"),
                Name = "presp8pw_cat.jpg",
                Status = 0,
            },
            new ProductImage()
            {
                Id = new Guid("d5c65161-7591-48c1-9198-daca179bce4c"),
                ProductDetailId = new Guid("1eaaba04-80ff-43a6-a746-a74a91c7c1e7"),
                Name = "presp8pw_01.jpg",
                Status = 0,
            },
            new ProductImage()
            {
                Id = new Guid("d5c65161-7591-48c1-9198-daca179bce5c"),
                ProductDetailId = new Guid("1eaaba04-80ff-43a6-a746-a74a91c7c1e7"),
                Name = "presp8pw_cat.jpg",
                Status = 0,
            },
            new ProductImage()
            {
                Id = new Guid("d5c65161-7591-48c1-9198-daca179bce6c"),
                ProductDetailId = new Guid("1eaaba04-80ff-43a6-a746-a74a91c7c1e8"),
                Name = "presp8pw_01.jpg",
                Status = 0,
            },
            new ProductImage()
            {
                Id = new Guid("d5c65161-7591-48c1-9198-daca179bce7c"),
                ProductDetailId = new Guid("1eaaba04-80ff-43a6-a746-a74a91c7c1e8"),
                Name = "presp8pw_cat.jpg",
                Status = 0,
            },
            new ProductImage()
            {
                Id = new Guid("d5c65161-7591-48c1-9198-daca179bce8c"),
                ProductDetailId = new Guid("1eaaba04-80ff-43a6-a746-a74a91c7c1e9"),
                Name = "presp8pw_01.jpg",
                Status = 0,
            },
            new ProductImage()
            {
                Id = new Guid("d5c65161-7591-48c1-9198-daca179bce9c"),
                ProductDetailId = new Guid("1eaaba04-80ff-43a6-a746-a74a91c7c1e9"),
                Name = "presp8pw_cat.jpg",
                Status = 0,
            },
            new ProductImage()
            {
                Id = new Guid("d5c65161-7591-48c1-9198-daca180bce0c"),
                ProductDetailId = new Guid("1eaaba04-80ff-43a6-a746-a74a91c7c2e0"),
                Name = "presp8pw_01.jpg",
                Status = 0,
            },
            new ProductImage()
            {
                Id = new Guid("d5c65161-7591-48c1-9198-daca180bce1c"),
                ProductDetailId = new Guid("1eaaba04-80ff-43a6-a746-a74a91c7c2e0"),
                Name = "presp8pw_cat.jpg",
                Status = 0,
            },
            new ProductImage()
            {
                Id = new Guid("d5c65161-7591-48c1-9198-daca180bce2c"),
                ProductDetailId = new Guid("1eaaba04-80ff-43a6-a746-a74a91c7c2e1"),
                Name = "presp8pw_01.jpg",
                Status = 0,
            },
            new ProductImage()
            {
                Id = new Guid("d5c65161-7591-48c1-9198-daca180bce3c"),
                ProductDetailId = new Guid("1eaaba04-80ff-43a6-a746-a74a91c7c2e1"),
                Name = "presp8pw_cat.jpg",
                Status = 0,
            },
            new ProductImage()
            {
                Id = new Guid("d5c65161-7591-48c1-9198-daca180bce4c"),
                ProductDetailId = new Guid("1eaaba04-80ff-43a6-a746-a74a91c7c2e2"),
                Name = "presp8pw_01.jpg",
                Status = 0,
            },
            new ProductImage()
            {
                Id = new Guid("d5c65161-7591-48c1-9198-daca180bce5c"),
                ProductDetailId = new Guid("1eaaba04-80ff-43a6-a746-a74a91c7c2e2"),
                Name = "presp8pw_cat.jpg",
                Status = 0,
            },
            new ProductImage()
            {
                Id = new Guid("d5c65161-7591-48c1-9198-daca180bce6c"),
                ProductDetailId = new Guid("1eaaba04-80ff-43a6-a746-a74a91c7c2e3"),
                Name = "presp8pw_01.jpg",
                Status = 0,
            },
            new ProductImage()
            {
                Id = new Guid("d5c65161-7591-48c1-9198-daca180bce7c"),
                ProductDetailId = new Guid("1eaaba04-80ff-43a6-a746-a74a91c7c2e3"),
                Name = "presp8pw_cat.jpg",
                Status = 0,
            },
            new ProductImage()
            {
                Id = new Guid("d5c65161-7591-48c1-9198-daca180bce8c"),
                ProductDetailId = new Guid("1eaaba04-80ff-43a6-a746-a74a91c7c2e4"),
                Name = "presp8pw_01.jpg",
                Status = 0,
            },
            new ProductImage()
            {
                Id = new Guid("d5c65161-7591-48c1-9198-daca180bce9c"),
                ProductDetailId = new Guid("1eaaba04-80ff-43a6-a746-a74a91c7c2e4"),
                Name = "presp8pw_cat.jpg",
                Status = 0,
            },
            new ProductImage()
            {
                Id = new Guid("d5c65161-7591-48c1-9198-daca181bce0c"),
                ProductDetailId = new Guid("1eaaba04-80ff-43a6-a746-a74a91c7c2e5"),
                Name = "presp8pw_01.jpg",
                Status = 0,
            },
            new ProductImage()
            {
                Id = new Guid("d5c65161-7591-48c1-9198-daca181bce1c"),
                ProductDetailId = new Guid("1eaaba04-80ff-43a6-a746-a74a91c7c2e5"),
                Name = "presp8pw_cat.jpg",
                Status = 0,
            },
            new ProductImage()
            {
                Id = new Guid("d5c65161-7591-48c1-9198-daca181bce2c"),
                ProductDetailId = new Guid("1eaaba04-80ff-43a6-a746-a74a91c7c2e6"),
                Name = "presp8pw_01.jpg",
                Status = 0,
            },
            new ProductImage()
            {
                Id = new Guid("d5c65161-7591-48c1-9198-daca181bce3c"),
                ProductDetailId = new Guid("1eaaba04-80ff-43a6-a746-a74a91c7c2e6"),
                Name = "presp8pw_cat.jpg",
                Status = 0,
            },
            new ProductImage()
            {
                Id = new Guid("d5c65161-7591-48c1-9198-daca181bce4c"),
                ProductDetailId = new Guid("1eaaba04-80ff-43a6-a746-a74a91c7c2e7"),
                Name = "presp8pw_01.jpg",
                Status = 0,
            },
            new ProductImage()
            {
                Id = new Guid("d5c65161-7591-48c1-9198-daca181bce5c"),
                ProductDetailId = new Guid("1eaaba04-80ff-43a6-a746-a74a91c7c2e7"),
                Name = "presp8pw_cat.jpg",
                Status = 0,
            },
            new ProductImage()
            {
                Id = new Guid("d5c65161-7591-48c1-9198-daca181bce6c"),
                ProductDetailId = new Guid("1eaaba04-80ff-43a6-a746-a74a91c7c2e8"),
                Name = "presp8pw_01.jpg",
                Status = 0,
            },
            new ProductImage()
            {
                Id = new Guid("d5c65161-7591-48c1-9198-daca181bce7c"),
                ProductDetailId = new Guid("1eaaba04-80ff-43a6-a746-a74a91c7c2e8"),
                Name = "presp8pw_cat.jpg",
                Status = 0,
            },
            new ProductImage()
            {
                Id = new Guid("d5c65161-7591-48c1-9198-daca181bce8c"),
                ProductDetailId = new Guid("1eaaba04-80ff-43a6-a746-a74a91c7c2e9"),
                Name = "presp8pw_01.jpg",
                Status = 0,
            },
            new ProductImage()
            {
                Id = new Guid("d5c65161-7591-48c1-9198-daca181bce9c"),
                ProductDetailId = new Guid("1eaaba04-80ff-43a6-a746-a74a91c7c2e9"),
                Name = "presp8pw_cat.jpg",
                Status = 0,
            },
            new ProductImage()
            {
                Id = new Guid("d5c65161-7591-48c1-9198-daca182bce0c"),
                ProductDetailId = new Guid("1eaaba04-80ff-43a6-a746-a74a91c7c3e0"),
                Name = "presp8pw_01.jpg",
                Status = 0,
            },
            new ProductImage()
            {
                Id = new Guid("d5c65161-7591-48c1-9198-daca182bce1c"),
                ProductDetailId = new Guid("1eaaba04-80ff-43a6-a746-a74a91c7c3e0"),
                Name = "presp8pw_cat.jpg",
                Status = 0,
            },
            new ProductImage()
            {
                Id = new Guid("d5c65161-7591-48c1-9198-daca182bce2c"),
                ProductDetailId = new Guid("1eaaba04-80ff-43a6-a746-a74a91c7c3e1"),
                Name = "presp8pw_01.jpg",
                Status = 0,
            },
            new ProductImage()
            {
                Id = new Guid("d5c65161-7591-48c1-9198-daca182bce3c"),
                ProductDetailId = new Guid("1eaaba04-80ff-43a6-a746-a74a91c7c3e1"),
                Name = "presp8pw_cat.jpg",
                Status = 0,
            },
            new ProductImage()
            {
                Id = new Guid("d5c65161-7591-48c1-9198-daca182bce4c"),
                ProductDetailId = new Guid("1eaaba04-80ff-43a6-a746-a74a91c7c3e2"),
                Name = "presp8pw_01.jpg",
                Status = 0,
            },
            new ProductImage()
            {
                Id = new Guid("d5c65161-7591-48c1-9198-daca182bce5c"),
                ProductDetailId = new Guid("1eaaba04-80ff-43a6-a746-a74a91c7c3e2"),
                Name = "presp8pw_cat.jpg",
                Status = 0,
            },
            new ProductImage()
            {
                Id = new Guid("d5c65161-7591-48c1-9198-daca182bce6c"),
                ProductDetailId = new Guid("1eaaba04-80ff-43a6-a746-a74a91c7c3e3"),
                Name = "presp8pw_01.jpg",
                Status = 0,
            },
            new ProductImage()
            {
                Id = new Guid("d5c65161-7591-48c1-9198-daca182bce7c"),
                ProductDetailId = new Guid("1eaaba04-80ff-43a6-a746-a74a91c7c3e3"),
                Name = "presp8pw_cat.jpg",
                Status = 0,
            },
            new ProductImage()
            {
                Id = new Guid("d5c65161-7591-48c1-9198-daca182bce8c"),
                ProductDetailId = new Guid("1eaaba04-80ff-43a6-a746-a74a91c7c3e4"),
                Name = "presp8pw_01.jpg",
                Status = 0,
            },
            new ProductImage()
            {
                Id = new Guid("d5c65161-7591-48c1-9198-daca182bce9c"),
                ProductDetailId = new Guid("1eaaba04-80ff-43a6-a746-a74a91c7c3e4"),
                Name = "presp8pw_cat.jpg",
                Status = 0,
            },
            new ProductImage()
            {
                Id = new Guid("d5c65161-7591-48c1-9198-daca183bce0c"),
                ProductDetailId = new Guid("1eaaba04-80ff-43a6-a746-a74a91c7c3e5"),
                Name = "presp8pw_01.jpg",
                Status = 0,
            },
            new ProductImage()
            {
                Id = new Guid("d5c65161-7591-48c1-9198-daca183bce1c"),
                ProductDetailId = new Guid("1eaaba04-80ff-43a6-a746-a74a91c7c3e5"),
                Name = "presp8pw_cat.jpg",
                Status = 0,
            },
            new ProductImage()
            {
                Id = new Guid("d5c65161-7591-48c1-9198-daca183bce2c"),
                ProductDetailId = new Guid("1eaaba04-80ff-43a6-a746-a74a91c7c3e6"),
                Name = "presp8pw_01.jpg",
                Status = 0,
            },
            new ProductImage()
            {
                Id = new Guid("d5c65161-7591-48c1-9198-daca183bce3c"),
                ProductDetailId = new Guid("1eaaba04-80ff-43a6-a746-a74a91c7c3e6"),
                Name = "presp8pw_cat.jpg",
                Status = 0,
            },
            new ProductImage()
            {
                Id = new Guid("d5c65161-7591-48c1-9198-daca183bce4c"),
                ProductDetailId = new Guid("1eaaba04-80ff-43a6-a746-a74a91c7c3e7"),
                Name = "presp8pw_01.jpg",
                Status = 0,
            },
            new ProductImage()
            {
                Id = new Guid("d5c65161-7591-48c1-9198-daca183bce5c"),
                ProductDetailId = new Guid("1eaaba04-80ff-43a6-a746-a74a91c7c3e7"),
                Name = "presp8pw_cat.jpg",
                Status = 0,
            },
            new ProductImage()
            {
                Id = new Guid("d5c65161-7591-48c1-9198-daca183bce6c"),
                ProductDetailId = new Guid("1eaaba04-80ff-43a6-a746-a74a91c7c3e8"),
                Name = "presp8pw_01.jpg",
                Status = 0,
            },
            new ProductImage()
            {
                Id = new Guid("d5c65161-7591-48c1-9198-daca183bce7c"),
                ProductDetailId = new Guid("1eaaba04-80ff-43a6-a746-a74a91c7c3e8"),
                Name = "presp8pw_cat.jpg",
                Status = 0,
            },
            new ProductImage()
            {
                Id = new Guid("d5c65161-7591-48c1-9198-daca183bce8c"),
                ProductDetailId = new Guid("1eaaba04-80ff-43a6-a746-a74a91c7c3e9"),
                Name = "presp8pw_01.jpg",
                Status = 0,
            },
            new ProductImage()
            {
                Id = new Guid("d5c65161-7591-48c1-9198-daca183bce9c"),
                ProductDetailId = new Guid("1eaaba04-80ff-43a6-a746-a74a91c7c3e9"),
                Name = "presp8pw_cat.jpg",
                Status = 0,
            },
            new ProductImage()
            {
                Id = new Guid("e666f8b0-0d76-400e-bdb0-ca85a9ba65d1"),
                ProductDetailId = new Guid("979a227c-41b7-4644-8ab1-e1c8d092f79f"),
                Name = "1.png",
                Status = 0,
            },
            new ProductImage()
            {
                Id = new Guid("a9e47c8b-4af6-4ccd-b259-7367eb8f6423"),
                ProductDetailId = new Guid("84a7b7bd-0490-4cf1-9499-1d9fe88580c3"),
                Name = "2.png",
                Status = 0,
            },
            new ProductImage()
            {
                Id = new Guid("e666f8b0-0d76-400e-bdb0-ca85a9ba65d4"),
                ProductDetailId = new Guid("84a7b7bd-0490-4cf1-9499-1d9fe88580c4"),
                Name = "1.png",
                Status = 0,
            },
            new ProductImage()
            {
                Id = new Guid("a9e47c8b-4af6-4ccd-b259-7367eb8f6425"),
                ProductDetailId = new Guid("84a7b7bd-0490-4cf1-9499-1d9fe88580c5"),
                Name = "2.png",
                Status = 0,
            },
            new ProductImage()
            {
                Id = new Guid("a9e47c8b-4af6-4ccd-b259-7367eb8f6426"),
                ProductDetailId = new Guid("84a7b7bd-0490-4cf1-9499-1d9fe88580c6"),
                Name = "2.png",
                Status = 0,
            },
            new ProductImage()
            {
                Id = new Guid("a9e47c8b-4af6-4ccd-b259-7367eb8f6427"),
                ProductDetailId = new Guid("84a7b7bd-0490-4cf1-9499-1d9fe88580c7"),
                Name = "1.png",
                Status = 0,
            },
            new ProductImage()
            {
                Id = new Guid("a9e47c8b-4af6-4ccd-b259-7367eb8f6428"),
                ProductDetailId = new Guid("84a7b7bd-0490-4cf1-9499-1d9fe88580c8"),
                Name = "2.png",
                Status = 0,
            },
            new ProductImage()
            {
                Id = new Guid("a9e47c8b-4af6-4ccd-b259-7367eb8f6429"),
                ProductDetailId = new Guid("84a7b7bd-0490-4cf1-9499-1d9fe88580c9"),
                Name = "1.png",
                Status = 0,
            },
            new ProductImage()
            {
                Id = new Guid("a9e47c8b-4af6-4ccd-b259-7367eb8f6420"),
                ProductDetailId = new Guid("84a7b7bd-0490-4cf1-9499-1d9fe88580c0"),
                Name = "2.png",
                Status = 0,
            });

            modelBuilder.Entity<Post>().HasData(
                new Post()
                {
                    Id = new Guid("1e510dc9-e8fd-40fc-ac14-19e701736531"),
                    EmployeeId = new Guid("40b601c0-2c08-449f-a41e-7564648f2c87"),
                    Title = "Nóng bảng xếp hạng bi-a thế giới: Hồng Thái “bay cao”, “thần đồng” Hàn Quốc lên số 1",
                    Content = "Giải carom 3 băng Veghel World Cup 2023 kết thúc khuya ngày 28/10 mới đây chứng kiến màn lên ngôi rất thuyết phục của Dick Jaspers. Với phong độ ấn tượng, siêu sao người Hà Lan chỉ mất đúng 12 lượt cơ để đánh bại cơ thủ số 1 nước Đức Martin Horn với cách biệt 50-22 để giành chức vô địch.\r\n\r\nNgay sau khi giải đấu kết thúc, Liên đoàn carom 3 băng thế giới (UMB) đã cập nhật điểm số và công bố bảng xếp hạng thế giới mới với rất nhiều bất ngờ thú vị. Trong đó, điểm nhấn lớn nhất là việc “thần đồng” 25 tuổi người Hàn Quốc Cho Myung Woo bất ngờ leo lên ngôi số 1 thế giới.\r\n\r\nMặc dù dừng bước ở vòng 16 và giữ nguyên số điểm là 258 điểm, Cho Myung Woo lại chiếm lấy vị trí đỉnh BXH của Marco Zanetti khi siêu sao người Ý sớm bị loại từ vòng bảng, qua đó chỉ còn 257 điểm, thua đúng 1 điểm trước Cho Myung Woo khiến ông rơi xuống vị trí thứ 2.\r\n\r\nMột trong những nguyên nhân khiến Marco Zanetti bị loại sớm và mất ngôi số 1 đến từ trận thua sốc trước Chiêm Hồng Thái. Cụ thể ở lượt trận mở màn vòng bảng, tài năng 24 tuổi của Việt Nam đã thể hiện phong độ xuất thần để đánh bại siêu sao người Ý với tỉ số 40-25 sau 20 lượt cơ.\r\n\r\nTiếp đà hưng phấn, Hồng Thái đã một mạch tiến vào đến tứ kết và trở thành cơ thủ Việt Nam lọt vào sâu nhất tại giải đấu này. Với màn thể hiện ấn tượng, Hồng Thái đã thăng tiến 9 bậc từ hạng 30 lên hạng 21 thế giới với 123 điểm.\r\n\r\n2 cơ thủ khác của Việt Nam là Trần Thanh Lực (từ hạng 35 lên hạng 29 thế giới) và Nguyễn Trần Thanh Tự (từ hạng 62 lên 56 thế giới) cũng có sự thăng tiến nhẹ khi vượt qua vòng loại để góp mặt ở vòng chính. Ngoài ra, Trần Quyết Chiến (hạng 5 thế giới) và Bao Phương Vinh (hạng 11 thế giới) giữ nguyên thứ hạng của mình.\r\n\r\nMặt khác, trong top 10 thế giới có thêm chút thay đổi khi Eddy Merckx tăng 2 bậc lên hạng 6 thế giới, đẩy Sameh Sidhom xuống hạng 7. Với khoảng cách về điểm số là rất ít, BXH được dự báo sẽ biến động rất mạnh ở chặng World Cup tiếp theo sẽ diễn ra tại Hàn Quốc vào đầu tháng 11 tới đây.",
                    Image = "slidenews1.jpg",
                    CreatedDate = DateTime.Now,
                    UpdatedDate = DateTime.Now,
                    Description = "(Tin thể thao, tin bi-a) Những kết quả bất ngờ tại giải carom 3 băng Veghel World Cup 2023 đã khiến bảng xếp hạng carom 3 băng thế giới có nhiều sự thay đổi thú vị.",
                    Status = 0
                },
                new Post()
                {
                    Id = new Guid("1e510dc9-e8fd-40fc-ac14-19e701736532"),
                    EmployeeId = new Guid("40b601c0-2c08-449f-a41e-7564648f2c87"),
                    Title = "Cơ thủ bi-a số 1 thế giới tiến cử \"Khải tóc dài\" thi đấu cho tuyển châu Âu",
                    Content = "Hanoi Pool Open Championship 2023 đã kết thúc tại Hà Nội vào 15/10 nhưng dư âm về sự kiện này vẫn đang kéo dài. Giải đấu pool quốc tế lần đầu tiên tổ chức tại Thủ đô giúp khán giả Việt Nam tới gần hơn với những cơ thủ hàng đầu thế giới, hay huyền thoại lừng danh thế giới, các tay cơ chủ nhà cũng có dịp thi đấu, cọ xát với đối thủ lớn.\r\n\r\nĐáng tiếc, không có tay cơ nào của Việt Nam đi tiếp sau vòng knock-out, dù vậy những Anh Tuấn, Đức Thiện, Thành Kiên..., đặc biệt là Đỗ Khải tạo dấu ấn đậm nét với khán giả và bạn bè quốc tế.\r\n\r\nVới phong cách thi đấu phóng khoáng và có phần \"hoang dã\", Đỗ Khải là cái tên gây sốt nhất tại Hanoi Open. Tay cơ \"Khải tóc dài\" có thêm biệt danh \"Quý ông người Pháp\" sau khi trao nụ hôn lên tay của CEO Matchroom Multi Sports, bà Emily Frazer.\r\n\r\nNhờ lối thi đấu mang đậm tính giải trí, Đỗ Khải đã được thi đấu trận giao lưu với huyền thoại Efren Reyes, cơ thủ 69 tuổi, được mệnh danh \"Phù thủy\" bi-a tới từ Philippines.\r\n\r\nNhưng chưa hết, \"Khải tóc dài\" còn được cơ thủ số 1 bi-a pool (do Matchroom xếp hạng) Francisco Sanchez Ruiz \"mời gia nhập\" đội tuyển châu Âu.\r\n\r\nMosconi Cup 2023 diễn ra từ 6 tới 9/12 tại Anh, Team Europe (đội bi-a châu Âu) đã xác định được 3/5 cái tên bao gồm Sanchez Ruiz, David Alcaide và Jayson Shaw. 2/5 suất còn lại là suất wildcard (suất đặc cách) và sẽ được lựa chọn tùy ý theo quyết định riêng của từng đội tuyển.\r\n\r\nTrong phần bình luận mới đây, cơ thủ người Tây Ban Nha Sanchez Ruiz đã nhắc tới tên của Đỗ Khải, anh này mong muốn cơ thủ Việt Nam sẽ là thành viên nhận 1 trong suất còn lại của tuyển châu Âu.\r\n\r\nRõ ràng đây chỉ là bình luận vui vẻ của cơ thủ Ruiz, dù có biệt danh là \"Quý ông người Pháp\" nhưng Đỗ Khải mang quốc tịch Việt Nam vì thế anh không thể chơi cho đội tuyển châu Âu ở giải đồng đội sắp tới.\r\n\r\nTất nhiên chuyện gì cũng có thể xảy ra. Nếu Mosconi Cup 2023 có màn thi đấu giao lưu dành cho khách mời như ở Hanoi Open vừa qua, thì rất có khả năng Đỗ Khải sẽ trở thành khách mời đặc biệt.",
                    Image = "post2.jpg",
                    CreatedDate = DateTime.Now,
                    UpdatedDate = DateTime.Now,
                    Description = "(Tin thể thao, tin bi-a) Francisco Sanchez Ruiz nhắn nhủ lời đặc biệt tới cơ thủ Đỗ Khải của Việt Nam.",
                    Status = 0
                },
                new Post()
                {
                    Id = new Guid("1e510dc9-e8fd-40fc-ac14-19e701736533"),
                    EmployeeId = new Guid("40b601c0-2c08-449f-a41e-7564648f2c87"),
                    Title = "\"Nữ thần\" bi-a Trung Quốc đua tài, khoe sắc ở giải vô địch thế giới 2023",
                    Content = "Sau giải bi-a quốc tế diễn ra ở Hà Nội, lúc này làng bi-a pool đang hướng sự tập trung vào giải vô địch 10 bi nữ thế giới 2023 diễn ra tại Áo từ 18 tới 22/10.\r\n\r\nTrải những trận đấu vòng loại, ban tổ chức đã xác định được 16 cái tên giành vé vào 1/8 thi đấu vào tối 20/10. Gương mặt nhận được nhiều sự quan tâm nhất có lẽ là Pan Xiaoting (Phan Hiểu Đình), VĐV \"tài sắc vẹn toàn\" đến từ Trung Quốc.\r\n\r\nỞ vòng loại, mỹ nhân 41 tuổi trải qua nhiều trận đấu căng thẳng, trong đó phải kể tới màn \"ngược dòng\" thắng Chihiro Kawahara 7-6, trước đó cơ thủ Nhật Bản dẫn trước Hiểu Đình tới 5-0.\r\n\r\nTại vòng đấu dành cho 16 cơ thủ, mỹ nhân Trung Quốc chạm trán Allison Fisher. Đây là trận đấu của hai phong cách đối lập, nếu như Fisher mang phong cách tomboy thì Hiểu Đình là mỹ nhân yểu điệu, duyên dáng của làng billiard thế giới.\r\n\r\nFisher tỏ ra vượt trội hơn, cô đã dẫn tỷ số ván 4-1 sau 5 ván đầu tiên, trong khi Pan Xiaoting dù rất nỗ lực cũng chỉ đủ rút ngắn cách biệt xuống còn 2 điểm. Fisher thắng chung cuộc với tỷ số 9-6.",
                    Image = "post3.jpg",
                    CreatedDate = DateTime.Now,
                    UpdatedDate = DateTime.Now,
                    Description = "(Tin thể thao, tin bi-a) Nữ thần bi-a Trung Quốc vừa có màn \"ngược dòng\" ấn tượng trước đối thủ Nhật Bản.",
                    Status = 0
                },
                new Post()
                {
                    Id = new Guid("1e510dc9-e8fd-40fc-ac14-19e701736534"),
                    EmployeeId = new Guid("40b601c0-2c08-449f-a41e-7564648f2c87"),
                    Title = "Reyes đánh bại \"Khải tóc dài\", Jayson Shaw vô địch nghẹt thở giải bi-a ở Hà Nội",
                    Content = "Hanoi Open Pool Championship 2023 tổ chức tại Hà Nội từ 10 tới 15/10 tại Hà Nội mang tới cho khán giả Việt Nam quá nhiều kỷ niệm đáng nhớ. Ở sự kiện bi-a quốc tế tầm cỡ lần đầu tiên diễn ra tại Việt Nam, quy tụ những cơ thủ hàng đầu thế giới, cơ cấu giải thưởng lớn và có cả sự xuất hiện của \"Phù thủy\" Efren Reyes (Philippines).\r\n\r\nNhững siêu sao hàng đầu bi-a pool thế giới như Shane Van Boening, Francisco Sanchez Ruiz, Fedor Gorst, Jayson Shaw... đã trình diễn những đường cơ làm hài lòng những khán giả khó tính nhất. Bên cạnh đó, huyền thoại bi-a được cả thế giới ngưỡng mộ Reyes có hai trận đấu giao lưu mãn nhãn với Anh Tuấn và Đỗ Khải. \r\n\r\nSau trận đấu giao lưu với cơ thủ Anh Tuấn vào tối 14/10, sức hút từ cơ thủ 69 tuổi Philippines đã khiến ban tổ chức tạo thêm màn so cơ không có trong kế hoạch với Đỗ Khải, hay còn gọi là \"Khải tóc dài\", vào chiều 15/10.\r\n\r\nSự kết hợp giữa \"Phù thủy\" Reyes và ngôi sao có khả năng \"phù phép bi chủ\" Đỗ Khải đã tạo ra màn so tài mang nặng tính giải trí. Không chỉ khán giả, trong trận đấu nhiều lần huyền thoại Reyes cũng phải cười phá lên vì những động tác uốn éo như nhảy cùng trái bóng của Đỗ Khải. Reyes thắng 7-4 trước Đỗ Khải và ông sẽ mang theo rất nhiều kỷ niệm về Đỗ Khải, người hâm mộ và không khí cổ vũ tuyệt vời tại Hà Nội. \r\n\r\nKhép lại màn so cơ của Reyes và Đỗ Khải, trận chung kết được chờ đợi nhất giữa Jayson Shaw (Anh) và Albin Ouschan (Áo) mang tới cuộc rượt đuổi tỷ số nghẹt thở. \r\n\r\nLà một trong những cơ thủ chơi ổn định nhất, Shaw cơ thủ có biệt danh \"Mắt đại bàng\" bất ngờ để Albin dẫn 0-4. Chơi tập trung gỡ 3-4, nhưng rồi Shaw tiếp tục bị dẫn trước 6-10.\r\n\r\nBản lĩnh của Shaw được phát huy, \"Mắt đại bàng\" thi đấu cực tốt để vươn lên dẫn trước 12-11. Chỉ cần 1 ván nữa là thắng nhưng cơ thủ người Anh chơi ẩu, đánh lắc lỗ 1 bi ở ván 24, tạo điều kiện cho đối thủ Áo gỡ hòa 12-12.\r\n\r\nVận may cuối cùng ngoảnh mặt với Albin, ở tình huống phá bàn, bi chủ đã rơi xuống lỗ. Được đặt bóng ở vị trí thuận lợi, \"Mắt đại bàng\" tận dụng tốt cơ hội để khép lại trận đấu với tỷ số 13-12, qua đó bước lên ngôi vô địch Hanoi Open Pool Championship 2023. \r\n\r\nShaw nhận cúp và phần thưởng 30.000 USD (733 triệu đồng) cho chức vô địch, á quân Albin nhận 15.000  USD (366 triệu đồng), 2 cơ thủ đồng hạng ba cùng nhận 9.500 USD (232 triệu đồng).",
                    Image = "post4.jpg",
                    CreatedDate = DateTime.Now,
                    UpdatedDate = DateTime.Now,
                    Description = "(Tin thể thao, tin bi-a) Ngày cuối cùng Hanoi Open Pool Championship để lại nhiều ấn tượng khó quên với khán giả hâm mộ billiards (bi-a) trong nước và thế giới.",
                    Status = 0
                },
                new Post()
                {
                    Id = new Guid("1e510dc9-e8fd-40fc-ac14-19e701736535"),
                    EmployeeId = new Guid("40b601c0-2c08-449f-a41e-7564648f2c87"),
                    Title = "\"Phù thủy bi-a\" Reyes tri ân khán giả Việt bằng cơ 4 băng kinh điển",
                    Content = "Hanoi Open Pool Championship 2023, giải bi-a quốc tế tầm cỡ đầu tiên được tổ chức tại Hà Nội từ 10 tới 15/10 dần bước vào những trận đấu cuối cùng. Không chỉ có những cơ thủ hàng đầu tới tranh tài, sự kiện còn \"nóng\" hơn khi huyền thoại 69 tuổi, Efren Reyes xuất hiện vào chiều 14/10.\r\n\r\nTới tham dự giải với tư cách khách mời danh dự, \"Phù thủy\" Philippines tham gia trận đấu biểu diễn với tay cơ số 2 pool Việt Nam Nguyễn Anh Tuấn. Những trận đấu tại vòng knock-out Hanoi Open, cộng với hiệu ứng từ Reyes giúp Cung thể thao Điền kinh trong nhà Mỹ Đình trở nên nhộn nhịp. \r\n\r\nNgay khi xuất hiện, huyền thoại Reyes đã được người hâm mộ vây quanh, ông rất cảm kích trước tình cảm của khán giả dành cho mình. \r\n\r\nNhư để tri ân người xem, ngay ở cơ đánh dạo bàn khởi động đầu tiên, người đàn ông Philippines đã thực hiện pha \"dọn bàn\" đẹp mắt. Toàn bộ 9 bi được \"Phù thủy\" đưa xuống lỗ, đặc biệt nhất là bóng số 9. Dù đó là cơ đánh thẳng tắp để ăn bi số 9, nhưng Reyes đã đưa trái bóng này đi 4 băng trước khi rơi vào lỗ góc. Tình huống khiến nhiều người có mặt rất phấn khích. \r\n\r\nKhi bước vào trận đấu biểu diễn, giao lưu với Nguyễn Anh Tuấn (hạng 107 thế giới theo bảng xếp hạng Matchroom), huyền thoại Philippines vẫn thể hiện được nhiều cơ đánh tốt nhưng \"Tkon\" xuất sắc hơn. \r\n\r\nVới thể thức đánh \"chạm 10\", Reyes và Anh Tuấn tạo ra tỷ số rượt đuổi hấp dẫn, cuối cùng thì tài năng và sức trẻ giúp cơ thủ Việt Nam vượt qua huyền thoại Philippines 10-7. \r\n\r\nDĩ nhiên kết quả này không quá quan trọng, sau trận đấu cơ thủ Anh Tuấn tiến tới xin chữ ký của huyền thoại Reyes và anh thổ lộ \"thầy cũng mệt rồi nên thi đấu không được như ý\". \r\n\r\nCơ thủ Reyes, 69 tuổi, từng vô địch thế giới pool 9 bi năm 1999 và pool 8 bi năm 2004. Reyes không chỉ nổi tiếng bởi những danh hiệu, ông được cả thế giới biết tới thông qua những trận \"đánh độ\" tại quê nhà và phô diễn các đường cơ huyền ảo. \r\n\r\nKhán giả không sai khi đặt cho Reyes biệt danh \"Phù thủy\", người đàn ông sở hữu cả \"kho tàng\" những cú đánh chẳng thể tìm thấy trong sách giáo khoa nào cả.",
                    Image = "post5.jpg",
                    CreatedDate = DateTime.Now,
                    UpdatedDate = DateTime.Now,
                    Description = "(Tin thể thao, tin bi-a) Thêm một lần góp mặt tại các sự kiện bi-a tổ chức ở Việt Nam, \"Phù thủy\" Reyes tri ân khán giả bằng pha đi cơ đáng nhớ.",
                    Status = 0
                },
                new Post()
                {
                    Id = new Guid("1e510dc9-e8fd-40fc-ac14-19e701736536"),
                    EmployeeId = new Guid("40b601c0-2c08-449f-a41e-7564648f2c87"),
                    Title = "Cơ thủ chơi bi-a kiểu robot, hạ đối thủ 10-0 mặt vẫn lạnh tanh",
                    Content = "Shane Van Boening, cơ thủ sinh năm 1983 người Mỹ là một trong số những VĐV đặc biệt nhất của làng bi-a thế giới. Anh bị khiếm thính từ nhỏ, bi-a đã giúp cơ thủ phát huy tài năng để tự tin bước ra ngoài trở thành ngôi sao hàng đầu bi-a.\r\n\r\nĐược xem như một trong số cơ thủ bi-a Mỹ giỏi nhất và từng vươn tới số 1 thế giới năm 2020, Boening nổi tiếng với nhiều cơ đánh nhanh, mạnh, chính xác. Ở một giải bi-a pool 9 bi vào năm 2022, cơ thủ Boeing \"dọn bàn\" chỉ sau 72 giây.\r\n\r\nVào tháng trước Boening cũng góp mặt tại sự kiện bi-a tại Hà Nội, dù không giành được chức vô địch nhưng cơ thủ người Mỹ để lại nhiều ấn tượng đẹp với người hâm mộ.\r\n\r\nTrong 2 tuần liên tiếp vừa qua, cơ thủ 40 tuổi đăng quang tại giải Vô địch 8 bi thế giới 2023, rồi lên ngôi Bigfoot 10 bi International Open 2023 tại Mỹ.\r\n\r\nVới phong độ rất tốt sau khi giành chức vô địch 10 bi Bigfoot, Boening chỉ mất đúng 1 tiếng 25 phút để đánh bại cơ thủ người Philippines, Joven Bustamante với tỷ số 10-0 tại sự kiện 9 bi International Open 2023 diễn ra ở Mỹ.\r\n\r\nĐể thắng trắng 1 trận đấu bi-a là điều không phải dễ dàng, và Boening đã làm được điều đáng kinh ngạc này. Tỷ số cũng cho thấy khả năng phá bóng rồi \"dọn bàn\" gần như hoàn hảo của cơ thủ 40 tuổi. Suốt trận đấu Bustamante chẳng khác nào khán giả xem Boening đi cơ.",
                    Image = "post6.jpg",
                    CreatedDate = DateTime.Now.AddDays(-1),
                    UpdatedDate = DateTime.Now.AddDays(-1),
                    Description = "(Tin thể thao, tin bi-a) Thi đấu với tâm lý vững vàng và gần như \"không cảm xúc\", cơ thủ người Mỹ hạ tay cơ Philippines 10-0.",
                    Status = 0
                });
        }
    }
}