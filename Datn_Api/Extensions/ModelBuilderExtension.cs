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
                Name = "Vantage Uni-Loc® P3 Thin Black Collar",
                Price = 100,
                Size = 12.9,
                Length = 29,
                Material = "Gỗ Maple",
                Color = "Gỗ",
                Status = 0,
            },
            new Shaft()
            {
                Id = new Guid("cc37720a-7e89-463a-9510-1936e6761d73"),
                Name = "REVO 12.4 White Vault Plate Uni-Loc® Quick Release",
                Price = 120,
                Size = 12.4,
                Length = 29,
                Material = "Carbon Fiber Composite",
                Color = "Đen",
                Status = 0,
            },
            new Shaft()
            {
                Id = new Guid("cc37720a-7e89-463a-9510-1936e6761d63"),
                Name = "REVO 11.8 White Vault Plate Uni-Loc® Quick Release",
                Price = 90,
                Size = 11.8,
                Length = 29,
                Material = "Carbon Fiber Composite",
                Color = "Đen",
                Status = 0,
            },
            new Shaft()
            {
                Id = new Guid("cc37720a-7e89-463a-9510-1936e6761d53"),
                Name = "REVO 11.8 Black Vault Plate Uni-Loc® Quick Release",
                Price = 140,
                Size = 11.8,
                Length = 29,
                Material = "Carbon Fiber Composite",
                Color = "Đen",
                Status = 0,
            });

            modelBuilder.Entity<Tip>().HasData(
            new Tip()
            {
                Id = new Guid("cc37720a-7e89-463a-9510-1936e6761d04"),
                Name = "Kamui Clear Black - Super Soft",
                Price = 28.3,
                Size = 13,
                Length = 10,
                Material = "Siêu mềm",
                Color = "Đen",
                Status = 0,
            },
            new Tip()
            {
                Id = new Guid("cc37720a-7e89-463a-9510-1936e6761d14"),
                Name = "Kamui Clear Black - Soft",
                Price = 28.3,
                Size = 13,
                Length = 10,
                Material = "Mềm mại",
                Color = "Đen",
                Status = 0,
            },
            new Tip()
            {
                Id = new Guid("cc37720a-7e89-463a-9510-1936e6761d24"),
                Name = "Kamui Clear Black - Medium",
                Price = 28.3,
                Size = 13,
                Length = 10,
                Material = "Trung bình",
                Color = "Đen",
                Status = 0,
            },
            new Tip()
            {
                Id = new Guid("cc37720a-7e89-463a-9510-1936e6761d34"),
                Name = "Kamui Clear Black - Hard",
                Price = 28.3,
                Size = 13,
                Length = 10,
                Material = "Cứng",
                Color = "Đen",
                Status = 0,
            },
            new Tip()
            {
                Id = new Guid("cc37720a-7e89-463a-9510-1936e6761d44"),
                Name = "Kamui Black - Hard",
                Price = 26.8,
                Size = 13,
                Length = 10,
                Material = "Cứng",
                Color = "Đen",
                Status = 0,
            },
            new Tip()
            {
                Id = new Guid("cc37720a-7e89-463a-9510-1936e6761d54"),
                Name = "Kamui Black - Medium",
                Price = 26.8,
                Size = 13,
                Length = 10,
                Material = "Trung bình",
                Color = "Đen",
                Status = 0,
            },
            new Tip()
            {
                Id = new Guid("cc37720a-7e89-463a-9510-1936e6761d64"),
                Name = "Kamui Black - Soft",
                Price = 26.8,
                Size = 13,
                Length = 10,
                Material = "Mềm mại",
                Color = "Đen",
                Status = 0,
            },
            new Tip()
            {
                Id = new Guid("cc37720a-7e89-463a-9510-1936e6761d74"),
                Name = "Kamui Black  - Super Soft",
                Price = 26.8,
                Size = 13,
                Length = 10,
                Material = "Siêu mềm",
                Color = "Đen",
                Status = 0,
            },
            new Tip()
            {
                Id = new Guid("cc37720a-7e89-463a-9510-1936e6761d84"),
                Name = "Kamui Original Clear Super Soft",
                Price = 24.8,
                Size = 13,
                Length = 10,
                Material = "Siêu mềm",
                Color = "Đen",
                Status = 0,
            },
            new Tip()
            {
                Id = new Guid("cc37720a-7e89-463a-9510-1936e6761d94"),
                Name = "Kamui Original Clear Soft",
                Price = 24.8,
                Size = 13,
                Length = 10,
                Material = "Mềm mại",
                Color = "Đen",
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
                    Name = "ELITE ELBJGB BREAK JUMP CUE W",
                    Pin = "Action Quick-Release (both joints)",
                    Wrap = "Black Irish linen",
                    Rings = "None",
                    AvailableQuantity = 2000,
                    Sold = 500,
                    Likes = 1000,
                    CreateDate = new DateTime(2023, 09, 11),
                    Producer = "ELBJGB",
                    Status = 0,
                    Description = "This Elite ELBJGB pool cue has a two-piece butt that crushes racks when fully assembled and paired with the specially designed break shaft. The phenolic tip really POPS, efficiently transferring all of the power from you break stroke right into the cue ball. That same shaft used with the four Rosewood point forearm creates a 9.2oz, 41-inch jump cue that utilizes that same POP for easy and accurate jump shots!\r\n\r\nAfter you smash the rack, the quick-release joint makes it fast and easy to pair the butt with the pro-tapered, hard rock maple shaft with 13mm Tiger Everest tip. This playing cue configuration is a solid and straight shooter that can also get plenty of draw and English when you need it.\r\n\r\nIf you are playing in a room with a close wall or other obstruction, you can pair the playing shaft with the Black Irish linen handle of the butt for a 46” trouble shooter cue. That is also a great size option for kids that want to take part in a game of pool.\r\n\r\nWith the ability to break, jump, run racks, avoid obstructions and provide an option for kids this cue is a freaking AWESOME first pool cue and must-have for every home game room.",
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
                    Id = new Guid("2eaaba04-80ff-43a6-a746-a74a91c4c0e0"),
                    ProductID = new Guid("cc37720a-7e89-463a-9510-1936e6761d8b"),
                    TipId = new Guid("cc37720a-7e89-463a-9510-1936e6761d74"),
                    ShaftId = new Guid("cc37720a-7e89-463a-9510-1936e6761d73"),
                    WeightId = new Guid("cc37720a-7e89-463a-9510-1936e6761d75"),
                    Quantity = 1,
                    ImportPrice = 4000000,
                    Price = 5000000,
                    CreateDate = new DateTime(2023, 09, 12),
                    Status = 0,
                    Description = "Description",
                },
                new ProductDetail()
                {
                    Id = new Guid("2eaaba04-80ff-43a6-a746-a74a91c4c0e1"),
                    ProductID = new Guid("cc37720a-7e89-463a-9510-1936e6761d8b"),
                    TipId = new Guid("cc37720a-7e89-463a-9510-1936e6761d14"),
                    ShaftId = new Guid("cc37720a-7e89-463a-9510-1936e6761d83"),
                    WeightId = new Guid("cc37720a-7e89-463a-9510-1936e6761d85"),
                    Quantity = 1,
                    ImportPrice = 4000000,
                    Price = 5000000,
                    CreateDate = new DateTime(2023, 09, 12),
                    Status = 0,
                    Description = "Description",
                },
                new ProductDetail()
                {
                    Id = new Guid("2eaaba04-80ff-43a6-a746-a74a91c4c0e2"),
                    ProductID = new Guid("cc37720a-7e89-463a-9510-1936e6761d8b"),
                    TipId = new Guid("cc37720a-7e89-463a-9510-1936e6761d24"),
                    ShaftId = new Guid("cc37720a-7e89-463a-9510-1936e6761d83"),
                    WeightId = new Guid("cc37720a-7e89-463a-9510-1936e6761d85"),
                    Quantity = 1,
                    ImportPrice = 4000000,
                    Price = 5000000,
                    CreateDate = new DateTime(2023, 09, 12),
                    Status = 0,
                    Description = "Description",
                },
                new ProductDetail()
                {
                    Id = new Guid("2eaaba04-80ff-43a6-a746-a74a91c4c0e3"),
                    ProductID = new Guid("cc37720a-7e89-463a-9510-1936e6761d8b"),
                    TipId = new Guid("cc37720a-7e89-463a-9510-1936e6761d34"),
                    ShaftId = new Guid("cc37720a-7e89-463a-9510-1936e6761d83"),
                    WeightId = new Guid("cc37720a-7e89-463a-9510-1936e6761d85"),
                    Quantity = 1,
                    ImportPrice = 4000000,
                    Price = 5000000,
                    CreateDate = new DateTime(2023, 09, 12),
                    Status = 0,
                    Description = "Description",
                },
                new ProductDetail()
                {
                    Id = new Guid("2eaaba04-80ff-43a6-a746-a74a91c4c0e4"),
                    ProductID = new Guid("cc37720a-7e89-463a-9510-1936e6761d8b"),
                    TipId = new Guid("cc37720a-7e89-463a-9510-1936e6761d44"),
                    ShaftId = new Guid("cc37720a-7e89-463a-9510-1936e6761d83"),
                    WeightId = new Guid("cc37720a-7e89-463a-9510-1936e6761d85"),
                    Quantity = 1,
                    ImportPrice = 4000000,
                    Price = 5000000,
                    CreateDate = new DateTime(2023, 09, 12),
                    Status = 0,
                    Description = "Description",
                },
                new ProductDetail()
                {
                    Id = new Guid("2eaaba04-80ff-43a6-a746-a74a91c4c0e5"),
                    ProductID = new Guid("cc37720a-7e89-463a-9510-1936e6761d8b"),
                    TipId = new Guid("cc37720a-7e89-463a-9510-1936e6761d54"),
                    ShaftId = new Guid("cc37720a-7e89-463a-9510-1936e6761d83"),
                    WeightId = new Guid("cc37720a-7e89-463a-9510-1936e6761d85"),
                    Quantity = 1,
                    ImportPrice = 4000000,
                    Price = 5000000,
                    CreateDate = new DateTime(2023, 09, 12),
                    Status = 0,
                    Description = "Description",
                },
                new ProductDetail()
                {
                    Id = new Guid("2eaaba04-80ff-43a6-a746-a74a91c4c0e6"),
                    ProductID = new Guid("cc37720a-7e89-463a-9510-1936e6761d8b"),
                    TipId = new Guid("cc37720a-7e89-463a-9510-1936e6761d64"),
                    ShaftId = new Guid("cc37720a-7e89-463a-9510-1936e6761d83"),
                    WeightId = new Guid("cc37720a-7e89-463a-9510-1936e6761d85"),
                    Quantity = 1,
                    ImportPrice = 4000000,
                    Price = 5000000,
                    CreateDate = new DateTime(2023, 09, 12),
                    Status = 0,
                    Description = "Description",
                },
                new ProductDetail()
                {
                    Id = new Guid("2eaaba04-80ff-43a6-a746-a74a91c4c0e7"),
                    ProductID = new Guid("cc37720a-7e89-463a-9510-1936e6761d8b"),
                    TipId = new Guid("cc37720a-7e89-463a-9510-1936e6761d74"),
                    ShaftId = new Guid("cc37720a-7e89-463a-9510-1936e6761d83"),
                    WeightId = new Guid("cc37720a-7e89-463a-9510-1936e6761d85"),
                    Quantity = 1,
                    ImportPrice = 4000000,
                    Price = 5000000,
                    CreateDate = new DateTime(2023, 09, 12),
                    Status = 0,
                    Description = "Description",
                },
                new ProductDetail()
                {
                    Id = new Guid("2eaaba04-80ff-43a6-a746-a74a91c4c0e8"),
                    ProductID = new Guid("cc37720a-7e89-463a-9510-1936e6761d8b"),
                    TipId = new Guid("cc37720a-7e89-463a-9510-1936e6761d84"),
                    ShaftId = new Guid("cc37720a-7e89-463a-9510-1936e6761d83"),
                    WeightId = new Guid("cc37720a-7e89-463a-9510-1936e6761d85"),
                    Quantity = 1,
                    ImportPrice = 4000000,
                    Price = 5000000,
                    CreateDate = new DateTime(2023, 09, 12),
                    Status = 0,
                    Description = "Description",
                },
                new ProductDetail()
                {
                    Id = new Guid("2eaaba04-80ff-43a6-a746-a74a91c4c0e9"),
                    ProductID = new Guid("cc37720a-7e89-463a-9510-1936e6761d8b"),
                    TipId = new Guid("cc37720a-7e89-463a-9510-1936e6761d94"),
                    ShaftId = new Guid("cc37720a-7e89-463a-9510-1936e6761d83"),
                    WeightId = new Guid("cc37720a-7e89-463a-9510-1936e6761d85"),
                    Quantity = 1,
                    ImportPrice = 4000000,
                    Price = 5000000,
                    CreateDate = new DateTime(2023, 09, 12),
                    Status = 0,
                    Description = "Description",
                },
                new ProductDetail()
                {
                    Id = new Guid("2eaaba04-80ff-43a6-a746-a74a91c4c1e0"),
                    ProductID = new Guid("cc37720a-7e89-463a-9510-1936e6761d8b"),
                    TipId = new Guid("cc37720a-7e89-463a-9510-1936e6761d04"),
                    ShaftId = new Guid("cc37720a-7e89-463a-9510-1936e6761d73"),
                    WeightId = new Guid("cc37720a-7e89-463a-9510-1936e6761d85"),
                    Quantity = 1,
                    ImportPrice = 4000000,
                    Price = 5000000,
                    CreateDate = new DateTime(2023, 09, 12),
                    Status = 0,
                    Description = "Description",
                },
                new ProductDetail()
                {
                    Id = new Guid("2eaaba04-80ff-43a6-a746-a74a91c4c1e1"),
                    ProductID = new Guid("cc37720a-7e89-463a-9510-1936e6761d8b"),
                    TipId = new Guid("cc37720a-7e89-463a-9510-1936e6761d14"),
                    ShaftId = new Guid("cc37720a-7e89-463a-9510-1936e6761d73"),
                    WeightId = new Guid("cc37720a-7e89-463a-9510-1936e6761d85"),
                    Quantity = 1,
                    ImportPrice = 4000000,
                    Price = 5000000,
                    CreateDate = new DateTime(2023, 09, 12),
                    Status = 0,
                    Description = "Description",
                },
                new ProductDetail()
                {
                    Id = new Guid("2eaaba04-80ff-43a6-a746-a74a91c4c1e2"),
                    ProductID = new Guid("cc37720a-7e89-463a-9510-1936e6761d8b"),
                    TipId = new Guid("cc37720a-7e89-463a-9510-1936e6761d24"),
                    ShaftId = new Guid("cc37720a-7e89-463a-9510-1936e6761d73"),
                    WeightId = new Guid("cc37720a-7e89-463a-9510-1936e6761d85"),
                    Quantity = 1,
                    ImportPrice = 4000000,
                    Price = 5000000,
                    CreateDate = new DateTime(2023, 09, 12),
                    Status = 0,
                    Description = "Description",
                },
                new ProductDetail()
                {
                    Id = new Guid("2eaaba04-80ff-43a6-a746-a74a91c4c1e3"),
                    ProductID = new Guid("cc37720a-7e89-463a-9510-1936e6761d8b"),
                    TipId = new Guid("cc37720a-7e89-463a-9510-1936e6761d34"),
                    ShaftId = new Guid("cc37720a-7e89-463a-9510-1936e6761d73"),
                    WeightId = new Guid("cc37720a-7e89-463a-9510-1936e6761d85"),
                    Quantity = 1,
                    ImportPrice = 4000000,
                    Price = 5000000,
                    CreateDate = new DateTime(2023, 09, 12),
                    Status = 0,
                    Description = "Description",
                },
                new ProductDetail()
                {
                    Id = new Guid("2eaaba04-80ff-43a6-a746-a74a91c4c1e4"),
                    ProductID = new Guid("cc37720a-7e89-463a-9510-1936e6761d8b"),
                    TipId = new Guid("cc37720a-7e89-463a-9510-1936e6761d44"),
                    ShaftId = new Guid("cc37720a-7e89-463a-9510-1936e6761d73"),
                    WeightId = new Guid("cc37720a-7e89-463a-9510-1936e6761d85"),
                    Quantity = 1,
                    ImportPrice = 4000000,
                    Price = 5000000,
                    CreateDate = new DateTime(2023, 09, 12),
                    Status = 0,
                    Description = "Description",
                },
                new ProductDetail()
                {
                    Id = new Guid("2eaaba04-80ff-43a6-a746-a74a91c4c1e5"),
                    ProductID = new Guid("cc37720a-7e89-463a-9510-1936e6761d8b"),
                    TipId = new Guid("cc37720a-7e89-463a-9510-1936e6761d54"),
                    ShaftId = new Guid("cc37720a-7e89-463a-9510-1936e6761d73"),
                    WeightId = new Guid("cc37720a-7e89-463a-9510-1936e6761d85"),
                    Quantity = 1,
                    ImportPrice = 4000000,
                    Price = 5000000,
                    CreateDate = new DateTime(2023, 09, 12),
                    Status = 0,
                    Description = "Description",
                },
                new ProductDetail()
                {
                    Id = new Guid("2eaaba04-80ff-43a6-a746-a74a91c4c1e6"),
                    ProductID = new Guid("cc37720a-7e89-463a-9510-1936e6761d8b"),
                    TipId = new Guid("cc37720a-7e89-463a-9510-1936e6761d64"),
                    ShaftId = new Guid("cc37720a-7e89-463a-9510-1936e6761d73"),
                    WeightId = new Guid("cc37720a-7e89-463a-9510-1936e6761d85"),
                    Quantity = 1,
                    ImportPrice = 4000000,
                    Price = 5000000,
                    CreateDate = new DateTime(2023, 09, 12),
                    Status = 0,
                    Description = "Description",
                },
                new ProductDetail()
                {
                    Id = new Guid("2eaaba04-80ff-43a6-a746-a74a91c4c1e7"),
                    ProductID = new Guid("cc37720a-7e89-463a-9510-1936e6761d8b"),
                    TipId = new Guid("cc37720a-7e89-463a-9510-1936e6761d74"),
                    ShaftId = new Guid("cc37720a-7e89-463a-9510-1936e6761d73"),
                    WeightId = new Guid("cc37720a-7e89-463a-9510-1936e6761d85"),
                    Quantity = 1,
                    ImportPrice = 4000000,
                    Price = 5000000,
                    CreateDate = new DateTime(2023, 09, 12),
                    Status = 0,
                    Description = "Description",
                },
                new ProductDetail()
                {
                    Id = new Guid("2eaaba04-80ff-43a6-a746-a74a91c4c1e8"),
                    ProductID = new Guid("cc37720a-7e89-463a-9510-1936e6761d8b"),
                    TipId = new Guid("cc37720a-7e89-463a-9510-1936e6761d84"),
                    ShaftId = new Guid("cc37720a-7e89-463a-9510-1936e6761d73"),
                    WeightId = new Guid("cc37720a-7e89-463a-9510-1936e6761d85"),
                    Quantity = 1,
                    ImportPrice = 4000000,
                    Price = 5000000,
                    CreateDate = new DateTime(2023, 09, 12),
                    Status = 0,
                    Description = "Description",
                },
                new ProductDetail()
                {
                    Id = new Guid("2eaaba04-80ff-43a6-a746-a74a91c4c1e9"),
                    ProductID = new Guid("cc37720a-7e89-463a-9510-1936e6761d8b"),
                    TipId = new Guid("cc37720a-7e89-463a-9510-1936e6761d94"),
                    ShaftId = new Guid("cc37720a-7e89-463a-9510-1936e6761d73"),
                    WeightId = new Guid("cc37720a-7e89-463a-9510-1936e6761d85"),
                    Quantity = 1,
                    ImportPrice = 4000000,
                    Price = 5000000,
                    CreateDate = new DateTime(2023, 09, 12),
                    Status = 0,
                    Description = "Description",
                },
                new ProductDetail()
                {
                    Id = new Guid("2eaaba04-80ff-43a6-a746-a74a91c4c2e0"),
                    ProductID = new Guid("cc37720a-7e89-463a-9510-1936e6761d8b"),
                    TipId = new Guid("cc37720a-7e89-463a-9510-1936e6761d04"),
                    ShaftId = new Guid("cc37720a-7e89-463a-9510-1936e6761d63"),
                    WeightId = new Guid("cc37720a-7e89-463a-9510-1936e6761d85"),
                    Quantity = 1,
                    ImportPrice = 4000000,
                    Price = 5000000,
                    CreateDate = new DateTime(2023, 09, 12),
                    Status = 0,
                    Description = "Description",
                },
                new ProductDetail()
                {
                    Id = new Guid("2eaaba04-80ff-43a6-a746-a74a91c4c2e1"),
                    ProductID = new Guid("cc37720a-7e89-463a-9510-1936e6761d8b"),
                    TipId = new Guid("cc37720a-7e89-463a-9510-1936e6761d14"),
                    ShaftId = new Guid("cc37720a-7e89-463a-9510-1936e6761d63"),
                    WeightId = new Guid("cc37720a-7e89-463a-9510-1936e6761d85"),
                    Quantity = 1,
                    ImportPrice = 4000000,
                    Price = 5000000,
                    CreateDate = new DateTime(2023, 09, 12),
                    Status = 0,
                    Description = "Description",
                },
                new ProductDetail()
                {
                    Id = new Guid("2eaaba04-80ff-43a6-a746-a74a91c4c2e2"),
                    ProductID = new Guid("cc37720a-7e89-463a-9510-1936e6761d8b"),
                    TipId = new Guid("cc37720a-7e89-463a-9510-1936e6761d24"),
                    ShaftId = new Guid("cc37720a-7e89-463a-9510-1936e6761d63"),
                    WeightId = new Guid("cc37720a-7e89-463a-9510-1936e6761d85"),
                    Quantity = 1,
                    ImportPrice = 4000000,
                    Price = 5000000,
                    CreateDate = new DateTime(2023, 09, 12),
                    Status = 0,
                    Description = "Description",
                },
                new ProductDetail()
                {
                    Id = new Guid("2eaaba04-80ff-43a6-a746-a74a91c4c2e3"),
                    ProductID = new Guid("cc37720a-7e89-463a-9510-1936e6761d8b"),
                    TipId = new Guid("cc37720a-7e89-463a-9510-1936e6761d34"),
                    ShaftId = new Guid("cc37720a-7e89-463a-9510-1936e6761d63"),
                    WeightId = new Guid("cc37720a-7e89-463a-9510-1936e6761d85"),
                    Quantity = 1,
                    ImportPrice = 4000000,
                    Price = 5000000,
                    CreateDate = new DateTime(2023, 09, 12),
                    Status = 0,
                    Description = "Description",
                },
                new ProductDetail()
                {
                    Id = new Guid("2eaaba04-80ff-43a6-a746-a74a91c4c2e4"),
                    ProductID = new Guid("cc37720a-7e89-463a-9510-1936e6761d8b"),
                    TipId = new Guid("cc37720a-7e89-463a-9510-1936e6761d44"),
                    ShaftId = new Guid("cc37720a-7e89-463a-9510-1936e6761d63"),
                    WeightId = new Guid("cc37720a-7e89-463a-9510-1936e6761d85"),
                    Quantity = 1,
                    ImportPrice = 4000000,
                    Price = 5000000,
                    CreateDate = new DateTime(2023, 09, 12),
                    Status = 0,
                    Description = "Description",
                },
                new ProductDetail()
                {
                    Id = new Guid("2eaaba04-80ff-43a6-a746-a74a91c4c2e5"),
                    ProductID = new Guid("cc37720a-7e89-463a-9510-1936e6761d8b"),
                    TipId = new Guid("cc37720a-7e89-463a-9510-1936e6761d54"),
                    ShaftId = new Guid("cc37720a-7e89-463a-9510-1936e6761d63"),
                    WeightId = new Guid("cc37720a-7e89-463a-9510-1936e6761d85"),
                    Quantity = 1,
                    ImportPrice = 4000000,
                    Price = 5000000,
                    CreateDate = new DateTime(2023, 09, 12),
                    Status = 0,
                    Description = "Description",
                },
                new ProductDetail()
                {
                    Id = new Guid("2eaaba04-80ff-43a6-a746-a74a91c4c2e6"),
                    ProductID = new Guid("cc37720a-7e89-463a-9510-1936e6761d8b"),
                    TipId = new Guid("cc37720a-7e89-463a-9510-1936e6761d64"),
                    ShaftId = new Guid("cc37720a-7e89-463a-9510-1936e6761d63"),
                    WeightId = new Guid("cc37720a-7e89-463a-9510-1936e6761d85"),
                    Quantity = 1,
                    ImportPrice = 4000000,
                    Price = 5000000,
                    CreateDate = new DateTime(2023, 09, 12),
                    Status = 0,
                    Description = "Description",
                },
                new ProductDetail()
                {
                    Id = new Guid("2eaaba04-80ff-43a6-a746-a74a91c4c2e7"),
                    ProductID = new Guid("cc37720a-7e89-463a-9510-1936e6761d8b"),
                    TipId = new Guid("cc37720a-7e89-463a-9510-1936e6761d74"),
                    ShaftId = new Guid("cc37720a-7e89-463a-9510-1936e6761d63"),
                    WeightId = new Guid("cc37720a-7e89-463a-9510-1936e6761d85"),
                    Quantity = 1,
                    ImportPrice = 4000000,
                    Price = 5000000,
                    CreateDate = new DateTime(2023, 09, 12),
                    Status = 0,
                    Description = "Description",
                },
                new ProductDetail()
                {
                    Id = new Guid("2eaaba04-80ff-43a6-a746-a74a91c4c2e8"),
                    ProductID = new Guid("cc37720a-7e89-463a-9510-1936e6761d8b"),
                    TipId = new Guid("cc37720a-7e89-463a-9510-1936e6761d84"),
                    ShaftId = new Guid("cc37720a-7e89-463a-9510-1936e6761d63"),
                    WeightId = new Guid("cc37720a-7e89-463a-9510-1936e6761d85"),
                    Quantity = 1,
                    ImportPrice = 4000000,
                    Price = 5000000,
                    CreateDate = new DateTime(2023, 09, 12),
                    Status = 0,
                    Description = "Description",
                },
                new ProductDetail()
                {
                    Id = new Guid("2eaaba04-80ff-43a6-a746-a74a91c4c2e9"),
                    ProductID = new Guid("cc37720a-7e89-463a-9510-1936e6761d8b"),
                    TipId = new Guid("cc37720a-7e89-463a-9510-1936e6761d94"),
                    ShaftId = new Guid("cc37720a-7e89-463a-9510-1936e6761d63"),
                    WeightId = new Guid("cc37720a-7e89-463a-9510-1936e6761d85"),
                    Quantity = 1,
                    ImportPrice = 4000000,
                    Price = 5000000,
                    CreateDate = new DateTime(2023, 09, 12),
                    Status = 0,
                    Description = "Description",
                },
                new ProductDetail()
                {
                    Id = new Guid("2eaaba04-80ff-43a6-a746-a74a91c4c3e0"),
                    ProductID = new Guid("cc37720a-7e89-463a-9510-1936e6761d8b"),
                    TipId = new Guid("cc37720a-7e89-463a-9510-1936e6761d04"),
                    ShaftId = new Guid("cc37720a-7e89-463a-9510-1936e6761d53"),
                    WeightId = new Guid("cc37720a-7e89-463a-9510-1936e6761d85"),
                    Quantity = 1,
                    ImportPrice = 4000000,
                    Price = 5000000,
                    CreateDate = new DateTime(2023, 09, 12),
                    Status = 0,
                    Description = "Description",
                },
                new ProductDetail()
                {
                    Id = new Guid("2eaaba04-80ff-43a6-a746-a74a91c4c3e1"),
                    ProductID = new Guid("cc37720a-7e89-463a-9510-1936e6761d8b"),
                    TipId = new Guid("cc37720a-7e89-463a-9510-1936e6761d14"),
                    ShaftId = new Guid("cc37720a-7e89-463a-9510-1936e6761d53"),
                    WeightId = new Guid("cc37720a-7e89-463a-9510-1936e6761d85"),
                    Quantity = 1,
                    ImportPrice = 4000000,
                    Price = 5000000,
                    CreateDate = new DateTime(2023, 09, 12),
                    Status = 0,
                    Description = "Description",
                },
                new ProductDetail()
                {
                    Id = new Guid("2eaaba04-80ff-43a6-a746-a74a91c4c3e2"),
                    ProductID = new Guid("cc37720a-7e89-463a-9510-1936e6761d8b"),
                    TipId = new Guid("cc37720a-7e89-463a-9510-1936e6761d24"),
                    ShaftId = new Guid("cc37720a-7e89-463a-9510-1936e6761d53"),
                    WeightId = new Guid("cc37720a-7e89-463a-9510-1936e6761d85"),
                    Quantity = 1,
                    ImportPrice = 4000000,
                    Price = 5000000,
                    CreateDate = new DateTime(2023, 09, 12),
                    Status = 0,
                    Description = "Description",
                },
                new ProductDetail()
                {
                    Id = new Guid("2eaaba04-80ff-43a6-a746-a74a91c4c3e3"),
                    ProductID = new Guid("cc37720a-7e89-463a-9510-1936e6761d8b"),
                    TipId = new Guid("cc37720a-7e89-463a-9510-1936e6761d34"),
                    ShaftId = new Guid("cc37720a-7e89-463a-9510-1936e6761d53"),
                    WeightId = new Guid("cc37720a-7e89-463a-9510-1936e6761d85"),
                    Quantity = 1,
                    ImportPrice = 4000000,
                    Price = 5000000,
                    CreateDate = new DateTime(2023, 09, 12),
                    Status = 0,
                    Description = "Description",
                },
                new ProductDetail()
                {
                    Id = new Guid("2eaaba04-80ff-43a6-a746-a74a91c4c3e4"),
                    ProductID = new Guid("cc37720a-7e89-463a-9510-1936e6761d8b"),
                    TipId = new Guid("cc37720a-7e89-463a-9510-1936e6761d44"),
                    ShaftId = new Guid("cc37720a-7e89-463a-9510-1936e6761d53"),
                    WeightId = new Guid("cc37720a-7e89-463a-9510-1936e6761d85"),
                    Quantity = 1,
                    ImportPrice = 4000000,
                    Price = 5000000,
                    CreateDate = new DateTime(2023, 09, 12),
                    Status = 0,
                    Description = "Description",
                },
                new ProductDetail()
                {
                    Id = new Guid("2eaaba04-80ff-43a6-a746-a74a91c4c3e5"),
                    ProductID = new Guid("cc37720a-7e89-463a-9510-1936e6761d8b"),
                    TipId = new Guid("cc37720a-7e89-463a-9510-1936e6761d54"),
                    ShaftId = new Guid("cc37720a-7e89-463a-9510-1936e6761d53"),
                    WeightId = new Guid("cc37720a-7e89-463a-9510-1936e6761d85"),
                    Quantity = 1,
                    ImportPrice = 4000000,
                    Price = 5000000,
                    CreateDate = new DateTime(2023, 09, 12),
                    Status = 0,
                    Description = "Description",
                },
                new ProductDetail()
                {
                    Id = new Guid("2eaaba04-80ff-43a6-a746-a74a91c4c3e6"),
                    ProductID = new Guid("cc37720a-7e89-463a-9510-1936e6761d8b"),
                    TipId = new Guid("cc37720a-7e89-463a-9510-1936e6761d64"),
                    ShaftId = new Guid("cc37720a-7e89-463a-9510-1936e6761d53"),
                    WeightId = new Guid("cc37720a-7e89-463a-9510-1936e6761d85"),
                    Quantity = 1,
                    ImportPrice = 4000000,
                    Price = 5000000,
                    CreateDate = new DateTime(2023, 09, 12),
                    Status = 0,
                    Description = "Description",
                },
                new ProductDetail()
                {
                    Id = new Guid("2eaaba04-80ff-43a6-a746-a74a91c4c3e7"),
                    ProductID = new Guid("cc37720a-7e89-463a-9510-1936e6761d8b"),
                    TipId = new Guid("cc37720a-7e89-463a-9510-1936e6761d74"),
                    ShaftId = new Guid("cc37720a-7e89-463a-9510-1936e6761d53"),
                    WeightId = new Guid("cc37720a-7e89-463a-9510-1936e6761d85"),
                    Quantity = 1,
                    ImportPrice = 4000000,
                    Price = 5000000,
                    CreateDate = new DateTime(2023, 09, 12),
                    Status = 0,
                    Description = "Description",
                },
                new ProductDetail()
                {
                    Id = new Guid("2eaaba04-80ff-43a6-a746-a74a91c4c3e8"),
                    ProductID = new Guid("cc37720a-7e89-463a-9510-1936e6761d8b"),
                    TipId = new Guid("cc37720a-7e89-463a-9510-1936e6761d84"),
                    ShaftId = new Guid("cc37720a-7e89-463a-9510-1936e6761d53"),
                    WeightId = new Guid("cc37720a-7e89-463a-9510-1936e6761d85"),
                    Quantity = 1,
                    ImportPrice = 4000000,
                    Price = 5000000,
                    CreateDate = new DateTime(2023, 09, 12),
                    Status = 0,
                    Description = "Description",
                },
                new ProductDetail()
                {
                    Id = new Guid("2eaaba04-80ff-43a6-a746-a74a91c4c3e9"),
                    ProductID = new Guid("cc37720a-7e89-463a-9510-1936e6761d8b"),
                    TipId = new Guid("cc37720a-7e89-463a-9510-1936e6761d94"),
                    ShaftId = new Guid("cc37720a-7e89-463a-9510-1936e6761d53"),
                    WeightId = new Guid("cc37720a-7e89-463a-9510-1936e6761d85"),
                    Quantity = 1,
                    ImportPrice = 4000000,
                    Price = 5000000,
                    CreateDate = new DateTime(2023, 09, 12),
                    Status = 0,
                    Description = "Description",
                },
                new ProductDetail()
                {
                    Id = new Guid("2eaaba04-80ff-43a6-a746-a74a91c5c0e0"),
                    ProductID = new Guid("cc37720a-7e89-463a-9510-1936e6761d8b"),
                    TipId = new Guid("cc37720a-7e89-463a-9510-1936e6761d04"),
                    ShaftId = new Guid("cc37720a-7e89-463a-9510-1936e6761d83"),
                    WeightId = new Guid("cc37720a-7e89-463a-9510-1936e6761d75"),
                    Quantity = 1,
                    ImportPrice = 4000000,
                    Price = 5000000,
                    CreateDate = new DateTime(2023, 09, 12),
                    Status = 0,
                    Description = "Description",
                },
                new ProductDetail()
                {
                    Id = new Guid("2eaaba04-80ff-43a6-a746-a74a91c5c0e1"),
                    ProductID = new Guid("cc37720a-7e89-463a-9510-1936e6761d8b"),
                    TipId = new Guid("cc37720a-7e89-463a-9510-1936e6761d14"),
                    ShaftId = new Guid("cc37720a-7e89-463a-9510-1936e6761d83"),
                    WeightId = new Guid("cc37720a-7e89-463a-9510-1936e6761d75"),
                    Quantity = 1,
                    ImportPrice = 4000000,
                    Price = 5000000,
                    CreateDate = new DateTime(2023, 09, 12),
                    Status = 0,
                    Description = "Description",
                },
                new ProductDetail()
                {
                    Id = new Guid("2eaaba04-80ff-43a6-a746-a74a91c5c0e2"),
                    ProductID = new Guid("cc37720a-7e89-463a-9510-1936e6761d8b"),
                    TipId = new Guid("cc37720a-7e89-463a-9510-1936e6761d24"),
                    ShaftId = new Guid("cc37720a-7e89-463a-9510-1936e6761d83"),
                    WeightId = new Guid("cc37720a-7e89-463a-9510-1936e6761d75"),
                    Quantity = 1,
                    ImportPrice = 4000000,
                    Price = 5000000,
                    CreateDate = new DateTime(2023, 09, 12),
                    Status = 0,
                    Description = "Description",
                },
                new ProductDetail()
                {
                    Id = new Guid("2eaaba04-80ff-43a6-a746-a74a91c5c0e3"),
                    ProductID = new Guid("cc37720a-7e89-463a-9510-1936e6761d8b"),
                    TipId = new Guid("cc37720a-7e89-463a-9510-1936e6761d34"),
                    ShaftId = new Guid("cc37720a-7e89-463a-9510-1936e6761d83"),
                    WeightId = new Guid("cc37720a-7e89-463a-9510-1936e6761d75"),
                    Quantity = 1,
                    ImportPrice = 4000000,
                    Price = 5000000,
                    CreateDate = new DateTime(2023, 09, 12),
                    Status = 0,
                    Description = "Description",
                },
                new ProductDetail()
                {
                    Id = new Guid("2eaaba04-80ff-43a6-a746-a74a91c5c0e4"),
                    ProductID = new Guid("cc37720a-7e89-463a-9510-1936e6761d8b"),
                    TipId = new Guid("cc37720a-7e89-463a-9510-1936e6761d44"),
                    ShaftId = new Guid("cc37720a-7e89-463a-9510-1936e6761d83"),
                    WeightId = new Guid("cc37720a-7e89-463a-9510-1936e6761d75"),
                    Quantity = 1,
                    ImportPrice = 4000000,
                    Price = 5000000,
                    CreateDate = new DateTime(2023, 09, 12),
                    Status = 0,
                    Description = "Description",
                },
                new ProductDetail()
                {
                    Id = new Guid("2eaaba04-80ff-43a6-a746-a74a91c5c0e5"),
                    ProductID = new Guid("cc37720a-7e89-463a-9510-1936e6761d8b"),
                    TipId = new Guid("cc37720a-7e89-463a-9510-1936e6761d54"),
                    ShaftId = new Guid("cc37720a-7e89-463a-9510-1936e6761d83"),
                    WeightId = new Guid("cc37720a-7e89-463a-9510-1936e6761d75"),
                    Quantity = 1,
                    ImportPrice = 4000000,
                    Price = 5000000,
                    CreateDate = new DateTime(2023, 09, 12),
                    Status = 0,
                    Description = "Description",
                },
                new ProductDetail()
                {
                    Id = new Guid("2eaaba04-80ff-43a6-a746-a74a91c5c0e6"),
                    ProductID = new Guid("cc37720a-7e89-463a-9510-1936e6761d8b"),
                    TipId = new Guid("cc37720a-7e89-463a-9510-1936e6761d64"),
                    ShaftId = new Guid("cc37720a-7e89-463a-9510-1936e6761d83"),
                    WeightId = new Guid("cc37720a-7e89-463a-9510-1936e6761d75"),
                    Quantity = 1,
                    ImportPrice = 4000000,
                    Price = 5000000,
                    CreateDate = new DateTime(2023, 09, 12),
                    Status = 0,
                    Description = "Description",
                },
                new ProductDetail()
                {
                    Id = new Guid("2eaaba04-80ff-43a6-a746-a74a91c5c0e7"),
                    ProductID = new Guid("cc37720a-7e89-463a-9510-1936e6761d8b"),
                    TipId = new Guid("cc37720a-7e89-463a-9510-1936e6761d74"),
                    ShaftId = new Guid("cc37720a-7e89-463a-9510-1936e6761d83"),
                    WeightId = new Guid("cc37720a-7e89-463a-9510-1936e6761d75"),
                    Quantity = 1,
                    ImportPrice = 4000000,
                    Price = 5000000,
                    CreateDate = new DateTime(2023, 09, 12),
                    Status = 0,
                    Description = "Description",
                },
                new ProductDetail()
                {
                    Id = new Guid("2eaaba04-80ff-43a6-a746-a74a91c5c0e8"),
                    ProductID = new Guid("cc37720a-7e89-463a-9510-1936e6761d8b"),
                    TipId = new Guid("cc37720a-7e89-463a-9510-1936e6761d84"),
                    ShaftId = new Guid("cc37720a-7e89-463a-9510-1936e6761d83"),
                    WeightId = new Guid("cc37720a-7e89-463a-9510-1936e6761d75"),
                    Quantity = 1,
                    ImportPrice = 4000000,
                    Price = 5000000,
                    CreateDate = new DateTime(2023, 09, 12),
                    Status = 0,
                    Description = "Description",
                },
                new ProductDetail()
                {
                    Id = new Guid("2eaaba04-80ff-43a6-a746-a74a91c5c0e9"),
                    ProductID = new Guid("cc37720a-7e89-463a-9510-1936e6761d8b"),
                    TipId = new Guid("cc37720a-7e89-463a-9510-1936e6761d94"),
                    ShaftId = new Guid("cc37720a-7e89-463a-9510-1936e6761d83"),
                    WeightId = new Guid("cc37720a-7e89-463a-9510-1936e6761d75"),
                    Quantity = 1,
                    ImportPrice = 4000000,
                    Price = 5000000,
                    CreateDate = new DateTime(2023, 09, 12),
                    Status = 0,
                    Description = "Description",
                },
                new ProductDetail()
                {
                    Id = new Guid("2eaaba04-80ff-43a6-a746-a74a91c5c1e0"),
                    ProductID = new Guid("cc37720a-7e89-463a-9510-1936e6761d8b"),
                    TipId = new Guid("cc37720a-7e89-463a-9510-1936e6761d04"),
                    ShaftId = new Guid("cc37720a-7e89-463a-9510-1936e6761d73"),
                    WeightId = new Guid("cc37720a-7e89-463a-9510-1936e6761d75"),
                    Quantity = 1,
                    ImportPrice = 4000000,
                    Price = 5000000,
                    CreateDate = new DateTime(2023, 09, 12),
                    Status = 0,
                    Description = "Description",
                },
                new ProductDetail()
                {
                    Id = new Guid("2eaaba04-80ff-43a6-a746-a74a91c5c1e1"),
                    ProductID = new Guid("cc37720a-7e89-463a-9510-1936e6761d8b"),
                    TipId = new Guid("cc37720a-7e89-463a-9510-1936e6761d14"),
                    ShaftId = new Guid("cc37720a-7e89-463a-9510-1936e6761d73"),
                    WeightId = new Guid("cc37720a-7e89-463a-9510-1936e6761d75"),
                    Quantity = 1,
                    ImportPrice = 4000000,
                    Price = 5000000,
                    CreateDate = new DateTime(2023, 09, 12),
                    Status = 0,
                    Description = "Description",
                },
                new ProductDetail()
                {
                    Id = new Guid("2eaaba04-80ff-43a6-a746-a74a91c5c1e2"),
                    ProductID = new Guid("cc37720a-7e89-463a-9510-1936e6761d8b"),
                    TipId = new Guid("cc37720a-7e89-463a-9510-1936e6761d24"),
                    ShaftId = new Guid("cc37720a-7e89-463a-9510-1936e6761d73"),
                    WeightId = new Guid("cc37720a-7e89-463a-9510-1936e6761d75"),
                    Quantity = 1,
                    ImportPrice = 4000000,
                    Price = 5000000,
                    CreateDate = new DateTime(2023, 09, 12),
                    Status = 0,
                    Description = "Description",
                },
                new ProductDetail()
                {
                    Id = new Guid("2eaaba04-80ff-43a6-a746-a74a91c5c1e3"),
                    ProductID = new Guid("cc37720a-7e89-463a-9510-1936e6761d8b"),
                    TipId = new Guid("cc37720a-7e89-463a-9510-1936e6761d34"),
                    ShaftId = new Guid("cc37720a-7e89-463a-9510-1936e6761d73"),
                    WeightId = new Guid("cc37720a-7e89-463a-9510-1936e6761d75"),
                    Quantity = 1,
                    ImportPrice = 4000000,
                    Price = 5000000,
                    CreateDate = new DateTime(2023, 09, 12),
                    Status = 0,
                    Description = "Description",
                },
                new ProductDetail()
                {
                    Id = new Guid("2eaaba04-80ff-43a6-a746-a74a91c5c1e4"),
                    ProductID = new Guid("cc37720a-7e89-463a-9510-1936e6761d8b"),
                    TipId = new Guid("cc37720a-7e89-463a-9510-1936e6761d44"),
                    ShaftId = new Guid("cc37720a-7e89-463a-9510-1936e6761d73"),
                    WeightId = new Guid("cc37720a-7e89-463a-9510-1936e6761d75"),
                    Quantity = 1,
                    ImportPrice = 4000000,
                    Price = 5000000,
                    CreateDate = new DateTime(2023, 09, 12),
                    Status = 0,
                    Description = "Description",
                },
                new ProductDetail()
                {
                    Id = new Guid("2eaaba04-80ff-43a6-a746-a74a91c5c1e5"),
                    ProductID = new Guid("cc37720a-7e89-463a-9510-1936e6761d8b"),
                    TipId = new Guid("cc37720a-7e89-463a-9510-1936e6761d54"),
                    ShaftId = new Guid("cc37720a-7e89-463a-9510-1936e6761d73"),
                    WeightId = new Guid("cc37720a-7e89-463a-9510-1936e6761d75"),
                    Quantity = 1,
                    ImportPrice = 4000000,
                    Price = 5000000,
                    CreateDate = new DateTime(2023, 09, 12),
                    Status = 0,
                    Description = "Description",
                },
                new ProductDetail()
                {
                    Id = new Guid("2eaaba04-80ff-43a6-a746-a74a91c5c1e6"),
                    ProductID = new Guid("cc37720a-7e89-463a-9510-1936e6761d8b"),
                    TipId = new Guid("cc37720a-7e89-463a-9510-1936e6761d64"),
                    ShaftId = new Guid("cc37720a-7e89-463a-9510-1936e6761d73"),
                    WeightId = new Guid("cc37720a-7e89-463a-9510-1936e6761d75"),
                    Quantity = 1,
                    ImportPrice = 4000000,
                    Price = 5000000,
                    CreateDate = new DateTime(2023, 09, 12),
                    Status = 0,
                    Description = "Description",
                },
                new ProductDetail()
                {
                    Id = new Guid("2eaaba04-80ff-43a6-a746-a74a91c5c1e7"),
                    ProductID = new Guid("cc37720a-7e89-463a-9510-1936e6761d8b"),
                    TipId = new Guid("cc37720a-7e89-463a-9510-1936e6761d74"),
                    ShaftId = new Guid("cc37720a-7e89-463a-9510-1936e6761d73"),
                    WeightId = new Guid("cc37720a-7e89-463a-9510-1936e6761d75"),
                    Quantity = 1,
                    ImportPrice = 4000000,
                    Price = 5000000,
                    CreateDate = new DateTime(2023, 09, 12),
                    Status = 0,
                    Description = "Description",
                },
                new ProductDetail()
                {
                    Id = new Guid("2eaaba04-80ff-43a6-a746-a74a91c5c1e8"),
                    ProductID = new Guid("cc37720a-7e89-463a-9510-1936e6761d8b"),
                    TipId = new Guid("cc37720a-7e89-463a-9510-1936e6761d84"),
                    ShaftId = new Guid("cc37720a-7e89-463a-9510-1936e6761d73"),
                    WeightId = new Guid("cc37720a-7e89-463a-9510-1936e6761d75"),
                    Quantity = 1,
                    ImportPrice = 4000000,
                    Price = 5000000,
                    CreateDate = new DateTime(2023, 09, 12),
                    Status = 0,
                    Description = "Description",
                },
                new ProductDetail()
                {
                    Id = new Guid("2eaaba04-80ff-43a6-a746-a74a91c5c1e9"),
                    ProductID = new Guid("cc37720a-7e89-463a-9510-1936e6761d8b"),
                    TipId = new Guid("cc37720a-7e89-463a-9510-1936e6761d94"),
                    ShaftId = new Guid("cc37720a-7e89-463a-9510-1936e6761d73"),
                    WeightId = new Guid("cc37720a-7e89-463a-9510-1936e6761d75"),
                    Quantity = 1,
                    ImportPrice = 4000000,
                    Price = 5000000,
                    CreateDate = new DateTime(2023, 09, 12),
                    Status = 0,
                    Description = "Description",
                },
                new ProductDetail()
                {
                    Id = new Guid("2eaaba04-80ff-43a6-a746-a74a91c5c2e0"),
                    ProductID = new Guid("cc37720a-7e89-463a-9510-1936e6761d8b"),
                    TipId = new Guid("cc37720a-7e89-463a-9510-1936e6761d04"),
                    ShaftId = new Guid("cc37720a-7e89-463a-9510-1936e6761d63"),
                    WeightId = new Guid("cc37720a-7e89-463a-9510-1936e6761d75"),
                    Quantity = 1,
                    ImportPrice = 4000000,
                    Price = 5000000,
                    CreateDate = new DateTime(2023, 09, 12),
                    Status = 0,
                    Description = "Description",
                },
                new ProductDetail()
                {
                    Id = new Guid("2eaaba04-80ff-43a6-a746-a74a91c5c2e1"),
                    ProductID = new Guid("cc37720a-7e89-463a-9510-1936e6761d8b"),
                    TipId = new Guid("cc37720a-7e89-463a-9510-1936e6761d14"),
                    ShaftId = new Guid("cc37720a-7e89-463a-9510-1936e6761d63"),
                    WeightId = new Guid("cc37720a-7e89-463a-9510-1936e6761d75"),
                    Quantity = 1,
                    ImportPrice = 4000000,
                    Price = 5000000,
                    CreateDate = new DateTime(2023, 09, 12),
                    Status = 0,
                    Description = "Description",
                },
                new ProductDetail()
                {
                    Id = new Guid("2eaaba04-80ff-43a6-a746-a74a91c5c2e2"),
                    ProductID = new Guid("cc37720a-7e89-463a-9510-1936e6761d8b"),
                    TipId = new Guid("cc37720a-7e89-463a-9510-1936e6761d24"),
                    ShaftId = new Guid("cc37720a-7e89-463a-9510-1936e6761d63"),
                    WeightId = new Guid("cc37720a-7e89-463a-9510-1936e6761d75"),
                    Quantity = 1,
                    ImportPrice = 4000000,
                    Price = 5000000,
                    CreateDate = new DateTime(2023, 09, 12),
                    Status = 0,
                    Description = "Description",
                },
                new ProductDetail()
                {
                    Id = new Guid("2eaaba04-80ff-43a6-a746-a74a91c5c2e3"),
                    ProductID = new Guid("cc37720a-7e89-463a-9510-1936e6761d8b"),
                    TipId = new Guid("cc37720a-7e89-463a-9510-1936e6761d34"),
                    ShaftId = new Guid("cc37720a-7e89-463a-9510-1936e6761d63"),
                    WeightId = new Guid("cc37720a-7e89-463a-9510-1936e6761d75"),
                    Quantity = 1,
                    ImportPrice = 4000000,
                    Price = 5000000,
                    CreateDate = new DateTime(2023, 09, 12),
                    Status = 0,
                    Description = "Description",
                },
                new ProductDetail()
                {
                    Id = new Guid("2eaaba04-80ff-43a6-a746-a74a91c5c2e4"),
                    ProductID = new Guid("cc37720a-7e89-463a-9510-1936e6761d8b"),
                    TipId = new Guid("cc37720a-7e89-463a-9510-1936e6761d44"),
                    ShaftId = new Guid("cc37720a-7e89-463a-9510-1936e6761d63"),
                    WeightId = new Guid("cc37720a-7e89-463a-9510-1936e6761d75"),
                    Quantity = 1,
                    ImportPrice = 4000000,
                    Price = 5000000,
                    CreateDate = new DateTime(2023, 09, 12),
                    Status = 0,
                    Description = "Description",
                },
                new ProductDetail()
                {
                    Id = new Guid("2eaaba04-80ff-43a6-a746-a74a91c5c2e5"),
                    ProductID = new Guid("cc37720a-7e89-463a-9510-1936e6761d8b"),
                    TipId = new Guid("cc37720a-7e89-463a-9510-1936e6761d54"),
                    ShaftId = new Guid("cc37720a-7e89-463a-9510-1936e6761d63"),
                    WeightId = new Guid("cc37720a-7e89-463a-9510-1936e6761d75"),
                    Quantity = 1,
                    ImportPrice = 4000000,
                    Price = 5000000,
                    CreateDate = new DateTime(2023, 09, 12),
                    Status = 0,
                    Description = "Description",
                },
                new ProductDetail()
                {
                    Id = new Guid("2eaaba04-80ff-43a6-a746-a74a91c5c2e6"),
                    ProductID = new Guid("cc37720a-7e89-463a-9510-1936e6761d8b"),
                    TipId = new Guid("cc37720a-7e89-463a-9510-1936e6761d64"),
                    ShaftId = new Guid("cc37720a-7e89-463a-9510-1936e6761d63"),
                    WeightId = new Guid("cc37720a-7e89-463a-9510-1936e6761d75"),
                    Quantity = 1,
                    ImportPrice = 4000000,
                    Price = 5000000,
                    CreateDate = new DateTime(2023, 09, 12),
                    Status = 0,
                    Description = "Description",
                },
                new ProductDetail()
                {
                    Id = new Guid("2eaaba04-80ff-43a6-a746-a74a91c5c2e7"),
                    ProductID = new Guid("cc37720a-7e89-463a-9510-1936e6761d8b"),
                    TipId = new Guid("cc37720a-7e89-463a-9510-1936e6761d74"),
                    ShaftId = new Guid("cc37720a-7e89-463a-9510-1936e6761d63"),
                    WeightId = new Guid("cc37720a-7e89-463a-9510-1936e6761d75"),
                    Quantity = 1,
                    ImportPrice = 4000000,
                    Price = 5000000,
                    CreateDate = new DateTime(2023, 09, 12),
                    Status = 0,
                    Description = "Description",
                },
                new ProductDetail()
                {
                    Id = new Guid("2eaaba04-80ff-43a6-a746-a74a91c5c2e8"),
                    ProductID = new Guid("cc37720a-7e89-463a-9510-1936e6761d8b"),
                    TipId = new Guid("cc37720a-7e89-463a-9510-1936e6761d84"),
                    ShaftId = new Guid("cc37720a-7e89-463a-9510-1936e6761d63"),
                    WeightId = new Guid("cc37720a-7e89-463a-9510-1936e6761d75"),
                    Quantity = 1,
                    ImportPrice = 4000000,
                    Price = 5000000,
                    CreateDate = new DateTime(2023, 09, 12),
                    Status = 0,
                    Description = "Description",
                },
                new ProductDetail()
                {
                    Id = new Guid("2eaaba04-80ff-43a6-a746-a74a91c5c2e9"),
                    ProductID = new Guid("cc37720a-7e89-463a-9510-1936e6761d8b"),
                    TipId = new Guid("cc37720a-7e89-463a-9510-1936e6761d94"),
                    ShaftId = new Guid("cc37720a-7e89-463a-9510-1936e6761d63"),
                    WeightId = new Guid("cc37720a-7e89-463a-9510-1936e6761d75"),
                    Quantity = 1,
                    ImportPrice = 4000000,
                    Price = 5000000,
                    CreateDate = new DateTime(2023, 09, 12),
                    Status = 0,
                    Description = "Description",
                },
                new ProductDetail()
                {
                    Id = new Guid("2eaaba04-80ff-43a6-a746-a74a91c5c3e0"),
                    ProductID = new Guid("cc37720a-7e89-463a-9510-1936e6761d8b"),
                    TipId = new Guid("cc37720a-7e89-463a-9510-1936e6761d04"),
                    ShaftId = new Guid("cc37720a-7e89-463a-9510-1936e6761d53"),
                    WeightId = new Guid("cc37720a-7e89-463a-9510-1936e6761d75"),
                    Quantity = 1,
                    ImportPrice = 4000000,
                    Price = 5000000,
                    CreateDate = new DateTime(2023, 09, 12),
                    Status = 0,
                    Description = "Description",
                },
                new ProductDetail()
                {
                    Id = new Guid("2eaaba04-80ff-43a6-a746-a74a91c5c3e1"),
                    ProductID = new Guid("cc37720a-7e89-463a-9510-1936e6761d8b"),
                    TipId = new Guid("cc37720a-7e89-463a-9510-1936e6761d14"),
                    ShaftId = new Guid("cc37720a-7e89-463a-9510-1936e6761d53"),
                    WeightId = new Guid("cc37720a-7e89-463a-9510-1936e6761d75"),
                    Quantity = 1,
                    ImportPrice = 4000000,
                    Price = 5000000,
                    CreateDate = new DateTime(2023, 09, 12),
                    Status = 0,
                    Description = "Description",
                },
                new ProductDetail()
                {
                    Id = new Guid("2eaaba04-80ff-43a6-a746-a74a91c5c3e2"),
                    ProductID = new Guid("cc37720a-7e89-463a-9510-1936e6761d8b"),
                    TipId = new Guid("cc37720a-7e89-463a-9510-1936e6761d24"),
                    ShaftId = new Guid("cc37720a-7e89-463a-9510-1936e6761d53"),
                    WeightId = new Guid("cc37720a-7e89-463a-9510-1936e6761d75"),
                    Quantity = 1,
                    ImportPrice = 4000000,
                    Price = 5000000,
                    CreateDate = new DateTime(2023, 09, 12),
                    Status = 0,
                    Description = "Description",
                },
                new ProductDetail()
                {
                    Id = new Guid("2eaaba04-80ff-43a6-a746-a74a91c5c3e3"),
                    ProductID = new Guid("cc37720a-7e89-463a-9510-1936e6761d8b"),
                    TipId = new Guid("cc37720a-7e89-463a-9510-1936e6761d34"),
                    ShaftId = new Guid("cc37720a-7e89-463a-9510-1936e6761d53"),
                    WeightId = new Guid("cc37720a-7e89-463a-9510-1936e6761d75"),
                    Quantity = 1,
                    ImportPrice = 4000000,
                    Price = 5000000,
                    CreateDate = new DateTime(2023, 09, 12),
                    Status = 0,
                    Description = "Description",
                },
                new ProductDetail()
                {
                    Id = new Guid("2eaaba04-80ff-43a6-a746-a74a91c5c3e4"),
                    ProductID = new Guid("cc37720a-7e89-463a-9510-1936e6761d8b"),
                    TipId = new Guid("cc37720a-7e89-463a-9510-1936e6761d44"),
                    ShaftId = new Guid("cc37720a-7e89-463a-9510-1936e6761d53"),
                    WeightId = new Guid("cc37720a-7e89-463a-9510-1936e6761d75"),
                    Quantity = 1,
                    ImportPrice = 4000000,
                    Price = 5000000,
                    CreateDate = new DateTime(2023, 09, 12),
                    Status = 0,
                    Description = "Description",
                },
                new ProductDetail()
                {
                    Id = new Guid("2eaaba04-80ff-43a6-a746-a74a91c5c3e5"),
                    ProductID = new Guid("cc37720a-7e89-463a-9510-1936e6761d8b"),
                    TipId = new Guid("cc37720a-7e89-463a-9510-1936e6761d54"),
                    ShaftId = new Guid("cc37720a-7e89-463a-9510-1936e6761d53"),
                    WeightId = new Guid("cc37720a-7e89-463a-9510-1936e6761d75"),
                    Quantity = 1,
                    ImportPrice = 4000000,
                    Price = 5000000,
                    CreateDate = new DateTime(2023, 09, 12),
                    Status = 0,
                    Description = "Description",
                },
                new ProductDetail()
                {
                    Id = new Guid("2eaaba04-80ff-43a6-a746-a74a91c5c3e6"),
                    ProductID = new Guid("cc37720a-7e89-463a-9510-1936e6761d8b"),
                    TipId = new Guid("cc37720a-7e89-463a-9510-1936e6761d64"),
                    ShaftId = new Guid("cc37720a-7e89-463a-9510-1936e6761d53"),
                    WeightId = new Guid("cc37720a-7e89-463a-9510-1936e6761d75"),
                    Quantity = 1,
                    ImportPrice = 4000000,
                    Price = 5000000,
                    CreateDate = new DateTime(2023, 09, 12),
                    Status = 0,
                    Description = "Description",
                },
                new ProductDetail()
                {
                    Id = new Guid("2eaaba04-80ff-43a6-a746-a74a91c5c3e7"),
                    ProductID = new Guid("cc37720a-7e89-463a-9510-1936e6761d8b"),
                    TipId = new Guid("cc37720a-7e89-463a-9510-1936e6761d74"),
                    ShaftId = new Guid("cc37720a-7e89-463a-9510-1936e6761d53"),
                    WeightId = new Guid("cc37720a-7e89-463a-9510-1936e6761d75"),
                    Quantity = 1,
                    ImportPrice = 4000000,
                    Price = 5000000,
                    CreateDate = new DateTime(2023, 09, 12),
                    Status = 0,
                    Description = "Description",
                },
                new ProductDetail()
                {
                    Id = new Guid("2eaaba04-80ff-43a6-a746-a74a91c5c3e8"),
                    ProductID = new Guid("cc37720a-7e89-463a-9510-1936e6761d8b"),
                    TipId = new Guid("cc37720a-7e89-463a-9510-1936e6761d84"),
                    ShaftId = new Guid("cc37720a-7e89-463a-9510-1936e6761d53"),
                    WeightId = new Guid("cc37720a-7e89-463a-9510-1936e6761d75"),
                    Quantity = 1,
                    ImportPrice = 4000000,
                    Price = 5000000,
                    CreateDate = new DateTime(2023, 09, 12),
                    Status = 0,
                    Description = "Description",
                },
                new ProductDetail()
                {
                    Id = new Guid("2eaaba04-80ff-43a6-a746-a74a91c5c3e9"),
                    ProductID = new Guid("cc37720a-7e89-463a-9510-1936e6761d8b"),
                    TipId = new Guid("cc37720a-7e89-463a-9510-1936e6761d94"),
                    ShaftId = new Guid("cc37720a-7e89-463a-9510-1936e6761d53"),
                    WeightId = new Guid("cc37720a-7e89-463a-9510-1936e6761d75"),
                    Quantity = 1,
                    ImportPrice = 4000000,
                    Price = 5000000,
                    CreateDate = new DateTime(2023, 09, 12),
                    Status = 0,
                    Description = "Description",
                },
                new ProductDetail()
                {
                    Id = new Guid("2eaaba04-80ff-43a6-a746-a74a91c6c0e0"),
                    ProductID = new Guid("cc37720a-7e89-463a-9510-1936e6761d8b"),
                    TipId = new Guid("cc37720a-7e89-463a-9510-1936e6761d04"),
                    ShaftId = new Guid("cc37720a-7e89-463a-9510-1936e6761d83"),
                    WeightId = new Guid("cc37720a-7e89-463a-9510-1936e6761d65"),
                    Quantity = 1,
                    ImportPrice = 4000000,
                    Price = 5000000,
                    CreateDate = new DateTime(2023, 09, 12),
                    Status = 0,
                    Description = "Description",
                },
                new ProductDetail()
                {
                    Id = new Guid("2eaaba04-80ff-43a6-a746-a74a91c6c0e1"),
                    ProductID = new Guid("cc37720a-7e89-463a-9510-1936e6761d8b"),
                    TipId = new Guid("cc37720a-7e89-463a-9510-1936e6761d14"),
                    ShaftId = new Guid("cc37720a-7e89-463a-9510-1936e6761d83"),
                    WeightId = new Guid("cc37720a-7e89-463a-9510-1936e6761d65"),
                    Quantity = 1,
                    ImportPrice = 4000000,
                    Price = 5000000,
                    CreateDate = new DateTime(2023, 09, 12),
                    Status = 0,
                    Description = "Description",
                },
                new ProductDetail()
                {
                    Id = new Guid("2eaaba04-80ff-43a6-a746-a74a91c6c0e2"),
                    ProductID = new Guid("cc37720a-7e89-463a-9510-1936e6761d8b"),
                    TipId = new Guid("cc37720a-7e89-463a-9510-1936e6761d24"),
                    ShaftId = new Guid("cc37720a-7e89-463a-9510-1936e6761d83"),
                    WeightId = new Guid("cc37720a-7e89-463a-9510-1936e6761d65"),
                    Quantity = 1,
                    ImportPrice = 4000000,
                    Price = 5000000,
                    CreateDate = new DateTime(2023, 09, 12),
                    Status = 0,
                    Description = "Description",
                },
                new ProductDetail()
                {
                    Id = new Guid("2eaaba04-80ff-43a6-a746-a74a91c6c0e3"),
                    ProductID = new Guid("cc37720a-7e89-463a-9510-1936e6761d8b"),
                    TipId = new Guid("cc37720a-7e89-463a-9510-1936e6761d34"),
                    ShaftId = new Guid("cc37720a-7e89-463a-9510-1936e6761d83"),
                    WeightId = new Guid("cc37720a-7e89-463a-9510-1936e6761d65"),
                    Quantity = 1,
                    ImportPrice = 4000000,
                    Price = 5000000,
                    CreateDate = new DateTime(2023, 09, 12),
                    Status = 0,
                    Description = "Description",
                },
                new ProductDetail()
                {
                    Id = new Guid("2eaaba04-80ff-43a6-a746-a74a91c6c0e4"),
                    ProductID = new Guid("cc37720a-7e89-463a-9510-1936e6761d8b"),
                    TipId = new Guid("cc37720a-7e89-463a-9510-1936e6761d44"),
                    ShaftId = new Guid("cc37720a-7e89-463a-9510-1936e6761d83"),
                    WeightId = new Guid("cc37720a-7e89-463a-9510-1936e6761d65"),
                    Quantity = 1,
                    ImportPrice = 4000000,
                    Price = 5000000,
                    CreateDate = new DateTime(2023, 09, 12),
                    Status = 0,
                    Description = "Description",
                },
                new ProductDetail()
                {
                    Id = new Guid("2eaaba04-80ff-43a6-a746-a74a91c6c0e5"),
                    ProductID = new Guid("cc37720a-7e89-463a-9510-1936e6761d8b"),
                    TipId = new Guid("cc37720a-7e89-463a-9510-1936e6761d54"),
                    ShaftId = new Guid("cc37720a-7e89-463a-9510-1936e6761d83"),
                    WeightId = new Guid("cc37720a-7e89-463a-9510-1936e6761d65"),
                    Quantity = 1,
                    ImportPrice = 4000000,
                    Price = 5000000,
                    CreateDate = new DateTime(2023, 09, 12),
                    Status = 0,
                    Description = "Description",
                },
                new ProductDetail()
                {
                    Id = new Guid("2eaaba04-80ff-43a6-a746-a74a91c6c0e6"),
                    ProductID = new Guid("cc37720a-7e89-463a-9510-1936e6761d8b"),
                    TipId = new Guid("cc37720a-7e89-463a-9510-1936e6761d64"),
                    ShaftId = new Guid("cc37720a-7e89-463a-9510-1936e6761d83"),
                    WeightId = new Guid("cc37720a-7e89-463a-9510-1936e6761d65"),
                    Quantity = 1,
                    ImportPrice = 4000000,
                    Price = 5000000,
                    CreateDate = new DateTime(2023, 09, 12),
                    Status = 0,
                    Description = "Description",
                },
                new ProductDetail()
                {
                    Id = new Guid("2eaaba04-80ff-43a6-a746-a74a91c6c0e7"),
                    ProductID = new Guid("cc37720a-7e89-463a-9510-1936e6761d8b"),
                    TipId = new Guid("cc37720a-7e89-463a-9510-1936e6761d74"),
                    ShaftId = new Guid("cc37720a-7e89-463a-9510-1936e6761d83"),
                    WeightId = new Guid("cc37720a-7e89-463a-9510-1936e6761d65"),
                    Quantity = 1,
                    ImportPrice = 4000000,
                    Price = 5000000,
                    CreateDate = new DateTime(2023, 09, 12),
                    Status = 0,
                    Description = "Description",
                },
                new ProductDetail()
                {
                    Id = new Guid("2eaaba04-80ff-43a6-a746-a74a91c6c0e8"),
                    ProductID = new Guid("cc37720a-7e89-463a-9510-1936e6761d8b"),
                    TipId = new Guid("cc37720a-7e89-463a-9510-1936e6761d84"),
                    ShaftId = new Guid("cc37720a-7e89-463a-9510-1936e6761d83"),
                    WeightId = new Guid("cc37720a-7e89-463a-9510-1936e6761d65"),
                    Quantity = 1,
                    ImportPrice = 4000000,
                    Price = 5000000,
                    CreateDate = new DateTime(2023, 09, 12),
                    Status = 0,
                    Description = "Description",
                },
                new ProductDetail()
                {
                    Id = new Guid("2eaaba04-80ff-43a6-a746-a74a91c6c0e9"),
                    ProductID = new Guid("cc37720a-7e89-463a-9510-1936e6761d8b"),
                    TipId = new Guid("cc37720a-7e89-463a-9510-1936e6761d94"),
                    ShaftId = new Guid("cc37720a-7e89-463a-9510-1936e6761d83"),
                    WeightId = new Guid("cc37720a-7e89-463a-9510-1936e6761d65"),
                    Quantity = 1,
                    ImportPrice = 4000000,
                    Price = 5000000,
                    CreateDate = new DateTime(2023, 09, 12),
                    Status = 0,
                    Description = "Description",
                },
                new ProductDetail()
                {
                    Id = new Guid("2eaaba04-80ff-43a6-a746-a74a91c6c1e0"),
                    ProductID = new Guid("cc37720a-7e89-463a-9510-1936e6761d8b"),
                    TipId = new Guid("cc37720a-7e89-463a-9510-1936e6761d04"),
                    ShaftId = new Guid("cc37720a-7e89-463a-9510-1936e6761d73"),
                    WeightId = new Guid("cc37720a-7e89-463a-9510-1936e6761d65"),
                    Quantity = 1,
                    ImportPrice = 4000000,
                    Price = 5000000,
                    CreateDate = new DateTime(2023, 09, 12),
                    Status = 0,
                    Description = "Description",
                },
                new ProductDetail()
                {
                    Id = new Guid("2eaaba04-80ff-43a6-a746-a74a91c6c1e1"),
                    ProductID = new Guid("cc37720a-7e89-463a-9510-1936e6761d8b"),
                    TipId = new Guid("cc37720a-7e89-463a-9510-1936e6761d14"),
                    ShaftId = new Guid("cc37720a-7e89-463a-9510-1936e6761d73"),
                    WeightId = new Guid("cc37720a-7e89-463a-9510-1936e6761d65"),
                    Quantity = 1,
                    ImportPrice = 4000000,
                    Price = 5000000,
                    CreateDate = new DateTime(2023, 09, 12),
                    Status = 0,
                    Description = "Description",
                },
                new ProductDetail()
                {
                    Id = new Guid("2eaaba04-80ff-43a6-a746-a74a91c6c1e2"),
                    ProductID = new Guid("cc37720a-7e89-463a-9510-1936e6761d8b"),
                    TipId = new Guid("cc37720a-7e89-463a-9510-1936e6761d24"),
                    ShaftId = new Guid("cc37720a-7e89-463a-9510-1936e6761d73"),
                    WeightId = new Guid("cc37720a-7e89-463a-9510-1936e6761d65"),
                    Quantity = 1,
                    ImportPrice = 4000000,
                    Price = 5000000,
                    CreateDate = new DateTime(2023, 09, 12),
                    Status = 0,
                    Description = "Description",
                },
                new ProductDetail()
                {
                    Id = new Guid("2eaaba04-80ff-43a6-a746-a74a91c6c1e3"),
                    ProductID = new Guid("cc37720a-7e89-463a-9510-1936e6761d8b"),
                    TipId = new Guid("cc37720a-7e89-463a-9510-1936e6761d34"),
                    ShaftId = new Guid("cc37720a-7e89-463a-9510-1936e6761d73"),
                    WeightId = new Guid("cc37720a-7e89-463a-9510-1936e6761d65"),
                    Quantity = 1,
                    ImportPrice = 4000000,
                    Price = 5000000,
                    CreateDate = new DateTime(2023, 09, 12),
                    Status = 0,
                    Description = "Description",
                },
                new ProductDetail()
                {
                    Id = new Guid("2eaaba04-80ff-43a6-a746-a74a91c6c1e4"),
                    ProductID = new Guid("cc37720a-7e89-463a-9510-1936e6761d8b"),
                    TipId = new Guid("cc37720a-7e89-463a-9510-1936e6761d44"),
                    ShaftId = new Guid("cc37720a-7e89-463a-9510-1936e6761d73"),
                    WeightId = new Guid("cc37720a-7e89-463a-9510-1936e6761d65"),
                    Quantity = 1,
                    ImportPrice = 4000000,
                    Price = 5000000,
                    CreateDate = new DateTime(2023, 09, 12),
                    Status = 0,
                    Description = "Description",
                },
                new ProductDetail()
                {
                    Id = new Guid("2eaaba04-80ff-43a6-a746-a74a91c6c1e5"),
                    ProductID = new Guid("cc37720a-7e89-463a-9510-1936e6761d8b"),
                    TipId = new Guid("cc37720a-7e89-463a-9510-1936e6761d54"),
                    ShaftId = new Guid("cc37720a-7e89-463a-9510-1936e6761d73"),
                    WeightId = new Guid("cc37720a-7e89-463a-9510-1936e6761d65"),
                    Quantity = 1,
                    ImportPrice = 4000000,
                    Price = 5000000,
                    CreateDate = new DateTime(2023, 09, 12),
                    Status = 0,
                    Description = "Description",
                },
                new ProductDetail()
                {
                    Id = new Guid("2eaaba04-80ff-43a6-a746-a74a91c6c1e6"),
                    ProductID = new Guid("cc37720a-7e89-463a-9510-1936e6761d8b"),
                    TipId = new Guid("cc37720a-7e89-463a-9510-1936e6761d64"),
                    ShaftId = new Guid("cc37720a-7e89-463a-9510-1936e6761d73"),
                    WeightId = new Guid("cc37720a-7e89-463a-9510-1936e6761d65"),
                    Quantity = 1,
                    ImportPrice = 4000000,
                    Price = 5000000,
                    CreateDate = new DateTime(2023, 09, 12),
                    Status = 0,
                    Description = "Description",
                },
                new ProductDetail()
                {
                    Id = new Guid("2eaaba04-80ff-43a6-a746-a74a91c6c1e7"),
                    ProductID = new Guid("cc37720a-7e89-463a-9510-1936e6761d8b"),
                    TipId = new Guid("cc37720a-7e89-463a-9510-1936e6761d74"),
                    ShaftId = new Guid("cc37720a-7e89-463a-9510-1936e6761d73"),
                    WeightId = new Guid("cc37720a-7e89-463a-9510-1936e6761d65"),
                    Quantity = 1,
                    ImportPrice = 4000000,
                    Price = 5000000,
                    CreateDate = new DateTime(2023, 09, 12),
                    Status = 0,
                    Description = "Description",
                },
                new ProductDetail()
                {
                    Id = new Guid("2eaaba04-80ff-43a6-a746-a74a91c6c1e8"),
                    ProductID = new Guid("cc37720a-7e89-463a-9510-1936e6761d8b"),
                    TipId = new Guid("cc37720a-7e89-463a-9510-1936e6761d84"),
                    ShaftId = new Guid("cc37720a-7e89-463a-9510-1936e6761d73"),
                    WeightId = new Guid("cc37720a-7e89-463a-9510-1936e6761d65"),
                    Quantity = 1,
                    ImportPrice = 4000000,
                    Price = 5000000,
                    CreateDate = new DateTime(2023, 09, 12),
                    Status = 0,
                    Description = "Description",
                },
                new ProductDetail()
                {
                    Id = new Guid("2eaaba04-80ff-43a6-a746-a74a91c6c1e9"),
                    ProductID = new Guid("cc37720a-7e89-463a-9510-1936e6761d8b"),
                    TipId = new Guid("cc37720a-7e89-463a-9510-1936e6761d94"),
                    ShaftId = new Guid("cc37720a-7e89-463a-9510-1936e6761d73"),
                    WeightId = new Guid("cc37720a-7e89-463a-9510-1936e6761d65"),
                    Quantity = 1,
                    ImportPrice = 4000000,
                    Price = 5000000,
                    CreateDate = new DateTime(2023, 09, 12),
                    Status = 0,
                    Description = "Description",
                },
                new ProductDetail()
                {
                    Id = new Guid("2eaaba04-80ff-43a6-a746-a74a91c6c2e0"),
                    ProductID = new Guid("cc37720a-7e89-463a-9510-1936e6761d8b"),
                    TipId = new Guid("cc37720a-7e89-463a-9510-1936e6761d04"),
                    ShaftId = new Guid("cc37720a-7e89-463a-9510-1936e6761d63"),
                    WeightId = new Guid("cc37720a-7e89-463a-9510-1936e6761d65"),
                    Quantity = 1,
                    ImportPrice = 4000000,
                    Price = 5000000,
                    CreateDate = new DateTime(2023, 09, 12),
                    Status = 0,
                    Description = "Description",
                },
                new ProductDetail()
                {
                    Id = new Guid("2eaaba04-80ff-43a6-a746-a74a91c6c2e1"),
                    ProductID = new Guid("cc37720a-7e89-463a-9510-1936e6761d8b"),
                    TipId = new Guid("cc37720a-7e89-463a-9510-1936e6761d14"),
                    ShaftId = new Guid("cc37720a-7e89-463a-9510-1936e6761d63"),
                    WeightId = new Guid("cc37720a-7e89-463a-9510-1936e6761d65"),
                    Quantity = 1,
                    ImportPrice = 4000000,
                    Price = 5000000,
                    CreateDate = new DateTime(2023, 09, 12),
                    Status = 0,
                    Description = "Description",
                },
                new ProductDetail()
                {
                    Id = new Guid("2eaaba04-80ff-43a6-a746-a74a91c6c2e2"),
                    ProductID = new Guid("cc37720a-7e89-463a-9510-1936e6761d8b"),
                    TipId = new Guid("cc37720a-7e89-463a-9510-1936e6761d24"),
                    ShaftId = new Guid("cc37720a-7e89-463a-9510-1936e6761d63"),
                    WeightId = new Guid("cc37720a-7e89-463a-9510-1936e6761d65"),
                    Quantity = 1,
                    ImportPrice = 4000000,
                    Price = 5000000,
                    CreateDate = new DateTime(2023, 09, 12),
                    Status = 0,
                    Description = "Description",
                },
                new ProductDetail()
                {
                    Id = new Guid("2eaaba04-80ff-43a6-a746-a74a91c6c2e3"),
                    ProductID = new Guid("cc37720a-7e89-463a-9510-1936e6761d8b"),
                    TipId = new Guid("cc37720a-7e89-463a-9510-1936e6761d34"),
                    ShaftId = new Guid("cc37720a-7e89-463a-9510-1936e6761d63"),
                    WeightId = new Guid("cc37720a-7e89-463a-9510-1936e6761d65"),
                    Quantity = 1,
                    ImportPrice = 4000000,
                    Price = 5000000,
                    CreateDate = new DateTime(2023, 09, 12),
                    Status = 0,
                    Description = "Description",
                },
                new ProductDetail()
                {
                    Id = new Guid("2eaaba04-80ff-43a6-a746-a74a91c6c2e4"),
                    ProductID = new Guid("cc37720a-7e89-463a-9510-1936e6761d8b"),
                    TipId = new Guid("cc37720a-7e89-463a-9510-1936e6761d44"),
                    ShaftId = new Guid("cc37720a-7e89-463a-9510-1936e6761d63"),
                    WeightId = new Guid("cc37720a-7e89-463a-9510-1936e6761d65"),
                    Quantity = 1,
                    ImportPrice = 4000000,
                    Price = 5000000,
                    CreateDate = new DateTime(2023, 09, 12),
                    Status = 0,
                    Description = "Description",
                },
                new ProductDetail()
                {
                    Id = new Guid("2eaaba04-80ff-43a6-a746-a74a91c6c2e5"),
                    ProductID = new Guid("cc37720a-7e89-463a-9510-1936e6761d8b"),
                    TipId = new Guid("cc37720a-7e89-463a-9510-1936e6761d54"),
                    ShaftId = new Guid("cc37720a-7e89-463a-9510-1936e6761d63"),
                    WeightId = new Guid("cc37720a-7e89-463a-9510-1936e6761d65"),
                    Quantity = 1,
                    ImportPrice = 4000000,
                    Price = 5000000,
                    CreateDate = new DateTime(2023, 09, 12),
                    Status = 0,
                    Description = "Description",
                },
                new ProductDetail()
                {
                    Id = new Guid("2eaaba04-80ff-43a6-a746-a74a91c6c2e6"),
                    ProductID = new Guid("cc37720a-7e89-463a-9510-1936e6761d8b"),
                    TipId = new Guid("cc37720a-7e89-463a-9510-1936e6761d64"),
                    ShaftId = new Guid("cc37720a-7e89-463a-9510-1936e6761d63"),
                    WeightId = new Guid("cc37720a-7e89-463a-9510-1936e6761d65"),
                    Quantity = 1,
                    ImportPrice = 4000000,
                    Price = 5000000,
                    CreateDate = new DateTime(2023, 09, 12),
                    Status = 0,
                    Description = "Description",
                },
                new ProductDetail()
                {
                    Id = new Guid("2eaaba04-80ff-43a6-a746-a74a91c6c2e7"),
                    ProductID = new Guid("cc37720a-7e89-463a-9510-1936e6761d8b"),
                    TipId = new Guid("cc37720a-7e89-463a-9510-1936e6761d74"),
                    ShaftId = new Guid("cc37720a-7e89-463a-9510-1936e6761d63"),
                    WeightId = new Guid("cc37720a-7e89-463a-9510-1936e6761d65"),
                    Quantity = 1,
                    ImportPrice = 4000000,
                    Price = 5000000,
                    CreateDate = new DateTime(2023, 09, 12),
                    Status = 0,
                    Description = "Description",
                },
                new ProductDetail()
                {
                    Id = new Guid("2eaaba04-80ff-43a6-a746-a74a91c6c2e8"),
                    ProductID = new Guid("cc37720a-7e89-463a-9510-1936e6761d8b"),
                    TipId = new Guid("cc37720a-7e89-463a-9510-1936e6761d84"),
                    ShaftId = new Guid("cc37720a-7e89-463a-9510-1936e6761d63"),
                    WeightId = new Guid("cc37720a-7e89-463a-9510-1936e6761d65"),
                    Quantity = 1,
                    ImportPrice = 4000000,
                    Price = 5000000,
                    CreateDate = new DateTime(2023, 09, 12),
                    Status = 0,
                    Description = "Description",
                },
                new ProductDetail()
                {
                    Id = new Guid("2eaaba04-80ff-43a6-a746-a74a91c6c2e9"),
                    ProductID = new Guid("cc37720a-7e89-463a-9510-1936e6761d8b"),
                    TipId = new Guid("cc37720a-7e89-463a-9510-1936e6761d94"),
                    ShaftId = new Guid("cc37720a-7e89-463a-9510-1936e6761d63"),
                    WeightId = new Guid("cc37720a-7e89-463a-9510-1936e6761d65"),
                    Quantity = 1,
                    ImportPrice = 4000000,
                    Price = 5000000,
                    CreateDate = new DateTime(2023, 09, 12),
                    Status = 0,
                    Description = "Description",
                },
                new ProductDetail()
                {
                    Id = new Guid("2eaaba04-80ff-43a6-a746-a74a91c6c3e0"),
                    ProductID = new Guid("cc37720a-7e89-463a-9510-1936e6761d8b"),
                    TipId = new Guid("cc37720a-7e89-463a-9510-1936e6761d04"),
                    ShaftId = new Guid("cc37720a-7e89-463a-9510-1936e6761d53"),
                    WeightId = new Guid("cc37720a-7e89-463a-9510-1936e6761d65"),
                    Quantity = 1,
                    ImportPrice = 4000000,
                    Price = 5000000,
                    CreateDate = new DateTime(2023, 09, 12),
                    Status = 0,
                    Description = "Description",
                },
                new ProductDetail()
                {
                    Id = new Guid("2eaaba04-80ff-43a6-a746-a74a91c6c3e1"),
                    ProductID = new Guid("cc37720a-7e89-463a-9510-1936e6761d8b"),
                    TipId = new Guid("cc37720a-7e89-463a-9510-1936e6761d14"),
                    ShaftId = new Guid("cc37720a-7e89-463a-9510-1936e6761d53"),
                    WeightId = new Guid("cc37720a-7e89-463a-9510-1936e6761d65"),
                    Quantity = 1,
                    ImportPrice = 4000000,
                    Price = 5000000,
                    CreateDate = new DateTime(2023, 09, 12),
                    Status = 0,
                    Description = "Description",
                },
                new ProductDetail()
                {
                    Id = new Guid("2eaaba04-80ff-43a6-a746-a74a91c6c3e2"),
                    ProductID = new Guid("cc37720a-7e89-463a-9510-1936e6761d8b"),
                    TipId = new Guid("cc37720a-7e89-463a-9510-1936e6761d24"),
                    ShaftId = new Guid("cc37720a-7e89-463a-9510-1936e6761d53"),
                    WeightId = new Guid("cc37720a-7e89-463a-9510-1936e6761d65"),
                    Quantity = 1,
                    ImportPrice = 4000000,
                    Price = 5000000,
                    CreateDate = new DateTime(2023, 09, 12),
                    Status = 0,
                    Description = "Description",
                },
                new ProductDetail()
                {
                    Id = new Guid("2eaaba04-80ff-43a6-a746-a74a91c6c3e3"),
                    ProductID = new Guid("cc37720a-7e89-463a-9510-1936e6761d8b"),
                    TipId = new Guid("cc37720a-7e89-463a-9510-1936e6761d34"),
                    ShaftId = new Guid("cc37720a-7e89-463a-9510-1936e6761d53"),
                    WeightId = new Guid("cc37720a-7e89-463a-9510-1936e6761d65"),
                    Quantity = 1,
                    ImportPrice = 4000000,
                    Price = 5000000,
                    CreateDate = new DateTime(2023, 09, 12),
                    Status = 0,
                    Description = "Description",
                },
                new ProductDetail()
                {
                    Id = new Guid("2eaaba04-80ff-43a6-a746-a74a91c6c3e4"),
                    ProductID = new Guid("cc37720a-7e89-463a-9510-1936e6761d8b"),
                    TipId = new Guid("cc37720a-7e89-463a-9510-1936e6761d44"),
                    ShaftId = new Guid("cc37720a-7e89-463a-9510-1936e6761d53"),
                    WeightId = new Guid("cc37720a-7e89-463a-9510-1936e6761d65"),
                    Quantity = 1,
                    ImportPrice = 4000000,
                    Price = 5000000,
                    CreateDate = new DateTime(2023, 09, 12),
                    Status = 0,
                    Description = "Description",
                },
                new ProductDetail()
                {
                    Id = new Guid("2eaaba04-80ff-43a6-a746-a74a91c6c3e5"),
                    ProductID = new Guid("cc37720a-7e89-463a-9510-1936e6761d8b"),
                    TipId = new Guid("cc37720a-7e89-463a-9510-1936e6761d54"),
                    ShaftId = new Guid("cc37720a-7e89-463a-9510-1936e6761d53"),
                    WeightId = new Guid("cc37720a-7e89-463a-9510-1936e6761d65"),
                    Quantity = 1,
                    ImportPrice = 4000000,
                    Price = 5000000,
                    CreateDate = new DateTime(2023, 09, 12),
                    Status = 0,
                    Description = "Description",
                },
                new ProductDetail()
                {
                    Id = new Guid("2eaaba04-80ff-43a6-a746-a74a91c6c3e6"),
                    ProductID = new Guid("cc37720a-7e89-463a-9510-1936e6761d8b"),
                    TipId = new Guid("cc37720a-7e89-463a-9510-1936e6761d64"),
                    ShaftId = new Guid("cc37720a-7e89-463a-9510-1936e6761d53"),
                    WeightId = new Guid("cc37720a-7e89-463a-9510-1936e6761d65"),
                    Quantity = 1,
                    ImportPrice = 4000000,
                    Price = 5000000,
                    CreateDate = new DateTime(2023, 09, 12),
                    Status = 0,
                    Description = "Description",
                },
                new ProductDetail()
                {
                    Id = new Guid("2eaaba04-80ff-43a6-a746-a74a91c6c3e7"),
                    ProductID = new Guid("cc37720a-7e89-463a-9510-1936e6761d8b"),
                    TipId = new Guid("cc37720a-7e89-463a-9510-1936e6761d74"),
                    ShaftId = new Guid("cc37720a-7e89-463a-9510-1936e6761d53"),
                    WeightId = new Guid("cc37720a-7e89-463a-9510-1936e6761d65"),
                    Quantity = 1,
                    ImportPrice = 4000000,
                    Price = 5000000,
                    CreateDate = new DateTime(2023, 09, 12),
                    Status = 0,
                    Description = "Description",
                },
                new ProductDetail()
                {
                    Id = new Guid("2eaaba04-80ff-43a6-a746-a74a91c6c3e8"),
                    ProductID = new Guid("cc37720a-7e89-463a-9510-1936e6761d8b"),
                    TipId = new Guid("cc37720a-7e89-463a-9510-1936e6761d84"),
                    ShaftId = new Guid("cc37720a-7e89-463a-9510-1936e6761d53"),
                    WeightId = new Guid("cc37720a-7e89-463a-9510-1936e6761d65"),
                    Quantity = 1,
                    ImportPrice = 4000000,
                    Price = 5000000,
                    CreateDate = new DateTime(2023, 09, 12),
                    Status = 0,
                    Description = "Description",
                },
                new ProductDetail()
                {
                    Id = new Guid("2eaaba04-80ff-43a6-a746-a74a91c6c3e9"),
                    ProductID = new Guid("cc37720a-7e89-463a-9510-1936e6761d8b"),
                    TipId = new Guid("cc37720a-7e89-463a-9510-1936e6761d94"),
                    ShaftId = new Guid("cc37720a-7e89-463a-9510-1936e6761d53"),
                    WeightId = new Guid("cc37720a-7e89-463a-9510-1936e6761d65"),
                    Quantity = 1,
                    ImportPrice = 4000000,
                    Price = 5000000,
                    CreateDate = new DateTime(2023, 09, 12),
                    Status = 0,
                    Description = "Description",
                },
                new ProductDetail()
                {
                    Id = new Guid("2eaaba04-80ff-43a6-a746-a74a91c7c0e0"),
                    ProductID = new Guid("cc37720a-7e89-463a-9510-1936e6761d8b"),
                    TipId = new Guid("cc37720a-7e89-463a-9510-1936e6761d04"),
                    ShaftId = new Guid("cc37720a-7e89-463a-9510-1936e6761d83"),
                    WeightId = new Guid("cc37720a-7e89-463a-9510-1936e6761d55"),
                    Quantity = 1,
                    ImportPrice = 4000000,
                    Price = 5000000,
                    CreateDate = new DateTime(2023, 09, 12),
                    Status = 0,
                    Description = "Description",
                },
                new ProductDetail()
                {
                    Id = new Guid("2eaaba04-80ff-43a6-a746-a74a91c7c0e1"),
                    ProductID = new Guid("cc37720a-7e89-463a-9510-1936e6761d8b"),
                    TipId = new Guid("cc37720a-7e89-463a-9510-1936e6761d14"),
                    ShaftId = new Guid("cc37720a-7e89-463a-9510-1936e6761d83"),
                    WeightId = new Guid("cc37720a-7e89-463a-9510-1936e6761d55"),
                    Quantity = 1,
                    ImportPrice = 4000000,
                    Price = 5000000,
                    CreateDate = new DateTime(2023, 09, 12),
                    Status = 0,
                    Description = "Description",
                },
                new ProductDetail()
                {
                    Id = new Guid("2eaaba04-80ff-43a6-a746-a74a91c7c0e2"),
                    ProductID = new Guid("cc37720a-7e89-463a-9510-1936e6761d8b"),
                    TipId = new Guid("cc37720a-7e89-463a-9510-1936e6761d24"),
                    ShaftId = new Guid("cc37720a-7e89-463a-9510-1936e6761d83"),
                    WeightId = new Guid("cc37720a-7e89-463a-9510-1936e6761d55"),
                    Quantity = 1,
                    ImportPrice = 4000000,
                    Price = 5000000,
                    CreateDate = new DateTime(2023, 09, 12),
                    Status = 0,
                    Description = "Description",
                },
                new ProductDetail()
                {
                    Id = new Guid("2eaaba04-80ff-43a6-a746-a74a91c7c0e3"),
                    ProductID = new Guid("cc37720a-7e89-463a-9510-1936e6761d8b"),
                    TipId = new Guid("cc37720a-7e89-463a-9510-1936e6761d34"),
                    ShaftId = new Guid("cc37720a-7e89-463a-9510-1936e6761d83"),
                    WeightId = new Guid("cc37720a-7e89-463a-9510-1936e6761d55"),
                    Quantity = 1,
                    ImportPrice = 4000000,
                    Price = 5000000,
                    CreateDate = new DateTime(2023, 09, 12),
                    Status = 0,
                    Description = "Description",
                },
                new ProductDetail()
                {
                    Id = new Guid("2eaaba04-80ff-43a6-a746-a74a91c7c0e4"),
                    ProductID = new Guid("cc37720a-7e89-463a-9510-1936e6761d8b"),
                    TipId = new Guid("cc37720a-7e89-463a-9510-1936e6761d44"),
                    ShaftId = new Guid("cc37720a-7e89-463a-9510-1936e6761d83"),
                    WeightId = new Guid("cc37720a-7e89-463a-9510-1936e6761d55"),
                    Quantity = 1,
                    ImportPrice = 4000000,
                    Price = 5000000,
                    CreateDate = new DateTime(2023, 09, 12),
                    Status = 0,
                    Description = "Description",
                },
                new ProductDetail()
                {
                    Id = new Guid("2eaaba04-80ff-43a6-a746-a74a91c7c0e5"),
                    ProductID = new Guid("cc37720a-7e89-463a-9510-1936e6761d8b"),
                    TipId = new Guid("cc37720a-7e89-463a-9510-1936e6761d54"),
                    ShaftId = new Guid("cc37720a-7e89-463a-9510-1936e6761d83"),
                    WeightId = new Guid("cc37720a-7e89-463a-9510-1936e6761d55"),
                    Quantity = 1,
                    ImportPrice = 4000000,
                    Price = 5000000,
                    CreateDate = new DateTime(2023, 09, 12),
                    Status = 0,
                    Description = "Description",
                },
                new ProductDetail()
                {
                    Id = new Guid("2eaaba04-80ff-43a6-a746-a74a91c7c0e6"),
                    ProductID = new Guid("cc37720a-7e89-463a-9510-1936e6761d8b"),
                    TipId = new Guid("cc37720a-7e89-463a-9510-1936e6761d64"),
                    ShaftId = new Guid("cc37720a-7e89-463a-9510-1936e6761d83"),
                    WeightId = new Guid("cc37720a-7e89-463a-9510-1936e6761d55"),
                    Quantity = 1,
                    ImportPrice = 4000000,
                    Price = 5000000,
                    CreateDate = new DateTime(2023, 09, 12),
                    Status = 0,
                    Description = "Description",
                },
                new ProductDetail()
                {
                    Id = new Guid("2eaaba04-80ff-43a6-a746-a74a91c7c0e7"),
                    ProductID = new Guid("cc37720a-7e89-463a-9510-1936e6761d8b"),
                    TipId = new Guid("cc37720a-7e89-463a-9510-1936e6761d74"),
                    ShaftId = new Guid("cc37720a-7e89-463a-9510-1936e6761d83"),
                    WeightId = new Guid("cc37720a-7e89-463a-9510-1936e6761d55"),
                    Quantity = 1,
                    ImportPrice = 4000000,
                    Price = 5000000,
                    CreateDate = new DateTime(2023, 09, 12),
                    Status = 0,
                    Description = "Description",
                },
                new ProductDetail()
                {
                    Id = new Guid("2eaaba04-80ff-43a6-a746-a74a91c7c0e8"),
                    ProductID = new Guid("cc37720a-7e89-463a-9510-1936e6761d8b"),
                    TipId = new Guid("cc37720a-7e89-463a-9510-1936e6761d84"),
                    ShaftId = new Guid("cc37720a-7e89-463a-9510-1936e6761d83"),
                    WeightId = new Guid("cc37720a-7e89-463a-9510-1936e6761d55"),
                    Quantity = 1,
                    ImportPrice = 4000000,
                    Price = 5000000,
                    CreateDate = new DateTime(2023, 09, 12),
                    Status = 0,
                    Description = "Description",
                },
                new ProductDetail()
                {
                    Id = new Guid("2eaaba04-80ff-43a6-a746-a74a91c7c0e9"),
                    ProductID = new Guid("cc37720a-7e89-463a-9510-1936e6761d8b"),
                    TipId = new Guid("cc37720a-7e89-463a-9510-1936e6761d94"),
                    ShaftId = new Guid("cc37720a-7e89-463a-9510-1936e6761d83"),
                    WeightId = new Guid("cc37720a-7e89-463a-9510-1936e6761d55"),
                    Quantity = 1,
                    ImportPrice = 4000000,
                    Price = 5000000,
                    CreateDate = new DateTime(2023, 09, 12),
                    Status = 0,
                    Description = "Description",
                },
                new ProductDetail()
                {
                    Id = new Guid("2eaaba04-80ff-43a6-a746-a74a91c7c1e0"),
                    ProductID = new Guid("cc37720a-7e89-463a-9510-1936e6761d8b"),
                    TipId = new Guid("cc37720a-7e89-463a-9510-1936e6761d04"),
                    ShaftId = new Guid("cc37720a-7e89-463a-9510-1936e6761d73"),
                    WeightId = new Guid("cc37720a-7e89-463a-9510-1936e6761d55"),
                    Quantity = 1,
                    ImportPrice = 4000000,
                    Price = 5000000,
                    CreateDate = new DateTime(2023, 09, 12),
                    Status = 0,
                    Description = "Description",
                },
                new ProductDetail()
                {
                    Id = new Guid("2eaaba04-80ff-43a6-a746-a74a91c7c1e1"),
                    ProductID = new Guid("cc37720a-7e89-463a-9510-1936e6761d8b"),
                    TipId = new Guid("cc37720a-7e89-463a-9510-1936e6761d14"),
                    ShaftId = new Guid("cc37720a-7e89-463a-9510-1936e6761d73"),
                    WeightId = new Guid("cc37720a-7e89-463a-9510-1936e6761d55"),
                    Quantity = 1,
                    ImportPrice = 4000000,
                    Price = 5000000,
                    CreateDate = new DateTime(2023, 09, 12),
                    Status = 0,
                    Description = "Description",
                },
                new ProductDetail()
                {
                    Id = new Guid("2eaaba04-80ff-43a6-a746-a74a91c7c1e2"),
                    ProductID = new Guid("cc37720a-7e89-463a-9510-1936e6761d8b"),
                    TipId = new Guid("cc37720a-7e89-463a-9510-1936e6761d24"),
                    ShaftId = new Guid("cc37720a-7e89-463a-9510-1936e6761d73"),
                    WeightId = new Guid("cc37720a-7e89-463a-9510-1936e6761d55"),
                    Quantity = 1,
                    ImportPrice = 4000000,
                    Price = 5000000,
                    CreateDate = new DateTime(2023, 09, 12),
                    Status = 0,
                    Description = "Description",
                },
                new ProductDetail()
                {
                    Id = new Guid("2eaaba04-80ff-43a6-a746-a74a91c7c1e3"),
                    ProductID = new Guid("cc37720a-7e89-463a-9510-1936e6761d8b"),
                    TipId = new Guid("cc37720a-7e89-463a-9510-1936e6761d34"),
                    ShaftId = new Guid("cc37720a-7e89-463a-9510-1936e6761d73"),
                    WeightId = new Guid("cc37720a-7e89-463a-9510-1936e6761d55"),
                    Quantity = 1,
                    ImportPrice = 4000000,
                    Price = 5000000,
                    CreateDate = new DateTime(2023, 09, 12),
                    Status = 0,
                    Description = "Description",
                },
                new ProductDetail()
                {
                    Id = new Guid("2eaaba04-80ff-43a6-a746-a74a91c7c1e4"),
                    ProductID = new Guid("cc37720a-7e89-463a-9510-1936e6761d8b"),
                    TipId = new Guid("cc37720a-7e89-463a-9510-1936e6761d44"),
                    ShaftId = new Guid("cc37720a-7e89-463a-9510-1936e6761d73"),
                    WeightId = new Guid("cc37720a-7e89-463a-9510-1936e6761d55"),
                    Quantity = 1,
                    ImportPrice = 4000000,
                    Price = 5000000,
                    CreateDate = new DateTime(2023, 09, 12),
                    Status = 0,
                    Description = "Description",
                },
                new ProductDetail()
                {
                    Id = new Guid("2eaaba04-80ff-43a6-a746-a74a91c7c1e5"),
                    ProductID = new Guid("cc37720a-7e89-463a-9510-1936e6761d8b"),
                    TipId = new Guid("cc37720a-7e89-463a-9510-1936e6761d54"),
                    ShaftId = new Guid("cc37720a-7e89-463a-9510-1936e6761d73"),
                    WeightId = new Guid("cc37720a-7e89-463a-9510-1936e6761d55"),
                    Quantity = 1,
                    ImportPrice = 4000000,
                    Price = 5000000,
                    CreateDate = new DateTime(2023, 09, 12),
                    Status = 0,
                    Description = "Description",
                },
                new ProductDetail()
                {
                    Id = new Guid("2eaaba04-80ff-43a6-a746-a74a91c7c1e6"),
                    ProductID = new Guid("cc37720a-7e89-463a-9510-1936e6761d8b"),
                    TipId = new Guid("cc37720a-7e89-463a-9510-1936e6761d64"),
                    ShaftId = new Guid("cc37720a-7e89-463a-9510-1936e6761d73"),
                    WeightId = new Guid("cc37720a-7e89-463a-9510-1936e6761d55"),
                    Quantity = 1,
                    ImportPrice = 4000000,
                    Price = 5000000,
                    CreateDate = new DateTime(2023, 09, 12),
                    Status = 0,
                    Description = "Description",
                },
                new ProductDetail()
                {
                    Id = new Guid("2eaaba04-80ff-43a6-a746-a74a91c7c1e7"),
                    ProductID = new Guid("cc37720a-7e89-463a-9510-1936e6761d8b"),
                    TipId = new Guid("cc37720a-7e89-463a-9510-1936e6761d74"),
                    ShaftId = new Guid("cc37720a-7e89-463a-9510-1936e6761d73"),
                    WeightId = new Guid("cc37720a-7e89-463a-9510-1936e6761d55"),
                    Quantity = 1,
                    ImportPrice = 4000000,
                    Price = 5000000,
                    CreateDate = new DateTime(2023, 09, 12),
                    Status = 0,
                    Description = "Description",
                },
                new ProductDetail()
                {
                    Id = new Guid("2eaaba04-80ff-43a6-a746-a74a91c7c1e8"),
                    ProductID = new Guid("cc37720a-7e89-463a-9510-1936e6761d8b"),
                    TipId = new Guid("cc37720a-7e89-463a-9510-1936e6761d84"),
                    ShaftId = new Guid("cc37720a-7e89-463a-9510-1936e6761d73"),
                    WeightId = new Guid("cc37720a-7e89-463a-9510-1936e6761d55"),
                    Quantity = 1,
                    ImportPrice = 4000000,
                    Price = 5000000,
                    CreateDate = new DateTime(2023, 09, 12),
                    Status = 0,
                    Description = "Description",
                },
                new ProductDetail()
                {
                    Id = new Guid("2eaaba04-80ff-43a6-a746-a74a91c7c1e9"),
                    ProductID = new Guid("cc37720a-7e89-463a-9510-1936e6761d8b"),
                    TipId = new Guid("cc37720a-7e89-463a-9510-1936e6761d94"),
                    ShaftId = new Guid("cc37720a-7e89-463a-9510-1936e6761d73"),
                    WeightId = new Guid("cc37720a-7e89-463a-9510-1936e6761d55"),
                    Quantity = 1,
                    ImportPrice = 4000000,
                    Price = 5000000,
                    CreateDate = new DateTime(2023, 09, 12),
                    Status = 0,
                    Description = "Description",
                },
                new ProductDetail()
                {
                    Id = new Guid("2eaaba04-80ff-43a6-a746-a74a91c7c2e0"),
                    ProductID = new Guid("cc37720a-7e89-463a-9510-1936e6761d8b"),
                    TipId = new Guid("cc37720a-7e89-463a-9510-1936e6761d04"),
                    ShaftId = new Guid("cc37720a-7e89-463a-9510-1936e6761d63"),
                    WeightId = new Guid("cc37720a-7e89-463a-9510-1936e6761d55"),
                    Quantity = 1,
                    ImportPrice = 4000000,
                    Price = 5000000,
                    CreateDate = new DateTime(2023, 09, 12),
                    Status = 0,
                    Description = "Description",
                },
                new ProductDetail()
                {
                    Id = new Guid("2eaaba04-80ff-43a6-a746-a74a91c7c2e1"),
                    ProductID = new Guid("cc37720a-7e89-463a-9510-1936e6761d8b"),
                    TipId = new Guid("cc37720a-7e89-463a-9510-1936e6761d14"),
                    ShaftId = new Guid("cc37720a-7e89-463a-9510-1936e6761d63"),
                    WeightId = new Guid("cc37720a-7e89-463a-9510-1936e6761d55"),
                    Quantity = 1,
                    ImportPrice = 4000000,
                    Price = 5000000,
                    CreateDate = new DateTime(2023, 09, 12),
                    Status = 0,
                    Description = "Description",
                },
                new ProductDetail()
                {
                    Id = new Guid("2eaaba04-80ff-43a6-a746-a74a91c7c2e2"),
                    ProductID = new Guid("cc37720a-7e89-463a-9510-1936e6761d8b"),
                    TipId = new Guid("cc37720a-7e89-463a-9510-1936e6761d24"),
                    ShaftId = new Guid("cc37720a-7e89-463a-9510-1936e6761d63"),
                    WeightId = new Guid("cc37720a-7e89-463a-9510-1936e6761d55"),
                    Quantity = 1,
                    ImportPrice = 4000000,
                    Price = 5000000,
                    CreateDate = new DateTime(2023, 09, 12),
                    Status = 0,
                    Description = "Description",
                },
                new ProductDetail()
                {
                    Id = new Guid("2eaaba04-80ff-43a6-a746-a74a91c7c2e3"),
                    ProductID = new Guid("cc37720a-7e89-463a-9510-1936e6761d8b"),
                    TipId = new Guid("cc37720a-7e89-463a-9510-1936e6761d34"),
                    ShaftId = new Guid("cc37720a-7e89-463a-9510-1936e6761d63"),
                    WeightId = new Guid("cc37720a-7e89-463a-9510-1936e6761d55"),
                    Quantity = 1,
                    ImportPrice = 4000000,
                    Price = 5000000,
                    CreateDate = new DateTime(2023, 09, 12),
                    Status = 0,
                    Description = "Description",
                },
                new ProductDetail()
                {
                    Id = new Guid("2eaaba04-80ff-43a6-a746-a74a91c7c2e4"),
                    ProductID = new Guid("cc37720a-7e89-463a-9510-1936e6761d8b"),
                    TipId = new Guid("cc37720a-7e89-463a-9510-1936e6761d44"),
                    ShaftId = new Guid("cc37720a-7e89-463a-9510-1936e6761d63"),
                    WeightId = new Guid("cc37720a-7e89-463a-9510-1936e6761d55"),
                    Quantity = 1,
                    ImportPrice = 4000000,
                    Price = 5000000,
                    CreateDate = new DateTime(2023, 09, 12),
                    Status = 0,
                    Description = "Description",
                },
                new ProductDetail()
                {
                    Id = new Guid("2eaaba04-80ff-43a6-a746-a74a91c7c2e5"),
                    ProductID = new Guid("cc37720a-7e89-463a-9510-1936e6761d8b"),
                    TipId = new Guid("cc37720a-7e89-463a-9510-1936e6761d54"),
                    ShaftId = new Guid("cc37720a-7e89-463a-9510-1936e6761d63"),
                    WeightId = new Guid("cc37720a-7e89-463a-9510-1936e6761d55"),
                    Quantity = 1,
                    ImportPrice = 4000000,
                    Price = 5000000,
                    CreateDate = new DateTime(2023, 09, 12),
                    Status = 0,
                    Description = "Description",
                },
                new ProductDetail()
                {
                    Id = new Guid("2eaaba04-80ff-43a6-a746-a74a91c7c2e6"),
                    ProductID = new Guid("cc37720a-7e89-463a-9510-1936e6761d8b"),
                    TipId = new Guid("cc37720a-7e89-463a-9510-1936e6761d64"),
                    ShaftId = new Guid("cc37720a-7e89-463a-9510-1936e6761d63"),
                    WeightId = new Guid("cc37720a-7e89-463a-9510-1936e6761d55"),
                    Quantity = 1,
                    ImportPrice = 4000000,
                    Price = 5000000,
                    CreateDate = new DateTime(2023, 09, 12),
                    Status = 0,
                    Description = "Description",
                },
                new ProductDetail()
                {
                    Id = new Guid("2eaaba04-80ff-43a6-a746-a74a91c7c2e7"),
                    ProductID = new Guid("cc37720a-7e89-463a-9510-1936e6761d8b"),
                    TipId = new Guid("cc37720a-7e89-463a-9510-1936e6761d74"),
                    ShaftId = new Guid("cc37720a-7e89-463a-9510-1936e6761d63"),
                    WeightId = new Guid("cc37720a-7e89-463a-9510-1936e6761d55"),
                    Quantity = 1,
                    ImportPrice = 4000000,
                    Price = 5000000,
                    CreateDate = new DateTime(2023, 09, 12),
                    Status = 0,
                    Description = "Description",
                },
                new ProductDetail()
                {
                    Id = new Guid("2eaaba04-80ff-43a6-a746-a74a91c7c2e8"),
                    ProductID = new Guid("cc37720a-7e89-463a-9510-1936e6761d8b"),
                    TipId = new Guid("cc37720a-7e89-463a-9510-1936e6761d84"),
                    ShaftId = new Guid("cc37720a-7e89-463a-9510-1936e6761d63"),
                    WeightId = new Guid("cc37720a-7e89-463a-9510-1936e6761d55"),
                    Quantity = 1,
                    ImportPrice = 4000000,
                    Price = 5000000,
                    CreateDate = new DateTime(2023, 09, 12),
                    Status = 0,
                    Description = "Description",
                },
                new ProductDetail()
                {
                    Id = new Guid("2eaaba04-80ff-43a6-a746-a74a91c7c2e9"),
                    ProductID = new Guid("cc37720a-7e89-463a-9510-1936e6761d8b"),
                    TipId = new Guid("cc37720a-7e89-463a-9510-1936e6761d94"),
                    ShaftId = new Guid("cc37720a-7e89-463a-9510-1936e6761d63"),
                    WeightId = new Guid("cc37720a-7e89-463a-9510-1936e6761d55"),
                    Quantity = 1,
                    ImportPrice = 4000000,
                    Price = 5000000,
                    CreateDate = new DateTime(2023, 09, 12),
                    Status = 0,
                    Description = "Description",
                },
                new ProductDetail()
                {
                    Id = new Guid("2eaaba04-80ff-43a6-a746-a74a91c7c3e0"),
                    ProductID = new Guid("cc37720a-7e89-463a-9510-1936e6761d8b"),
                    TipId = new Guid("cc37720a-7e89-463a-9510-1936e6761d04"),
                    ShaftId = new Guid("cc37720a-7e89-463a-9510-1936e6761d53"),
                    WeightId = new Guid("cc37720a-7e89-463a-9510-1936e6761d55"),
                    Quantity = 1,
                    ImportPrice = 4000000,
                    Price = 5000000,
                    CreateDate = new DateTime(2023, 09, 12),
                    Status = 0,
                    Description = "Description",
                },
                new ProductDetail()
                {
                    Id = new Guid("2eaaba04-80ff-43a6-a746-a74a91c7c3e1"),
                    ProductID = new Guid("cc37720a-7e89-463a-9510-1936e6761d8b"),
                    TipId = new Guid("cc37720a-7e89-463a-9510-1936e6761d14"),
                    ShaftId = new Guid("cc37720a-7e89-463a-9510-1936e6761d53"),
                    WeightId = new Guid("cc37720a-7e89-463a-9510-1936e6761d55"),
                    Quantity = 1,
                    ImportPrice = 4000000,
                    Price = 5000000,
                    CreateDate = new DateTime(2023, 09, 12),
                    Status = 0,
                    Description = "Description",
                },
                new ProductDetail()
                {
                    Id = new Guid("2eaaba04-80ff-43a6-a746-a74a91c7c3e2"),
                    ProductID = new Guid("cc37720a-7e89-463a-9510-1936e6761d8b"),
                    TipId = new Guid("cc37720a-7e89-463a-9510-1936e6761d24"),
                    ShaftId = new Guid("cc37720a-7e89-463a-9510-1936e6761d53"),
                    WeightId = new Guid("cc37720a-7e89-463a-9510-1936e6761d55"),
                    Quantity = 1,
                    ImportPrice = 4000000,
                    Price = 5000000,
                    CreateDate = new DateTime(2023, 09, 12),
                    Status = 0,
                    Description = "Description",
                },
                new ProductDetail()
                {
                    Id = new Guid("2eaaba04-80ff-43a6-a746-a74a91c7c3e3"),
                    ProductID = new Guid("cc37720a-7e89-463a-9510-1936e6761d8b"),
                    TipId = new Guid("cc37720a-7e89-463a-9510-1936e6761d34"),
                    ShaftId = new Guid("cc37720a-7e89-463a-9510-1936e6761d53"),
                    WeightId = new Guid("cc37720a-7e89-463a-9510-1936e6761d55"),
                    Quantity = 1,
                    ImportPrice = 4000000,
                    Price = 5000000,
                    CreateDate = new DateTime(2023, 09, 12),
                    Status = 0,
                    Description = "Description",
                },
                new ProductDetail()
                {
                    Id = new Guid("2eaaba04-80ff-43a6-a746-a74a91c7c3e4"),
                    ProductID = new Guid("cc37720a-7e89-463a-9510-1936e6761d8b"),
                    TipId = new Guid("cc37720a-7e89-463a-9510-1936e6761d44"),
                    ShaftId = new Guid("cc37720a-7e89-463a-9510-1936e6761d53"),
                    WeightId = new Guid("cc37720a-7e89-463a-9510-1936e6761d55"),
                    Quantity = 1,
                    ImportPrice = 4000000,
                    Price = 5000000,
                    CreateDate = new DateTime(2023, 09, 12),
                    Status = 0,
                    Description = "Description",
                },
                new ProductDetail()
                {
                    Id = new Guid("2eaaba04-80ff-43a6-a746-a74a91c7c3e5"),
                    ProductID = new Guid("cc37720a-7e89-463a-9510-1936e6761d8b"),
                    TipId = new Guid("cc37720a-7e89-463a-9510-1936e6761d54"),
                    ShaftId = new Guid("cc37720a-7e89-463a-9510-1936e6761d53"),
                    WeightId = new Guid("cc37720a-7e89-463a-9510-1936e6761d55"),
                    Quantity = 1,
                    ImportPrice = 4000000,
                    Price = 5000000,
                    CreateDate = new DateTime(2023, 09, 12),
                    Status = 0,
                    Description = "Description",
                },
                new ProductDetail()
                {
                    Id = new Guid("2eaaba04-80ff-43a6-a746-a74a91c7c3e6"),
                    ProductID = new Guid("cc37720a-7e89-463a-9510-1936e6761d8b"),
                    TipId = new Guid("cc37720a-7e89-463a-9510-1936e6761d64"),
                    ShaftId = new Guid("cc37720a-7e89-463a-9510-1936e6761d53"),
                    WeightId = new Guid("cc37720a-7e89-463a-9510-1936e6761d55"),
                    Quantity = 1,
                    ImportPrice = 4000000,
                    Price = 5000000,
                    CreateDate = new DateTime(2023, 09, 12),
                    Status = 0,
                    Description = "Description",
                },
                new ProductDetail()
                {
                    Id = new Guid("2eaaba04-80ff-43a6-a746-a74a91c7c3e7"),
                    ProductID = new Guid("cc37720a-7e89-463a-9510-1936e6761d8b"),
                    TipId = new Guid("cc37720a-7e89-463a-9510-1936e6761d74"),
                    ShaftId = new Guid("cc37720a-7e89-463a-9510-1936e6761d53"),
                    WeightId = new Guid("cc37720a-7e89-463a-9510-1936e6761d55"),
                    Quantity = 1,
                    ImportPrice = 4000000,
                    Price = 5000000,
                    CreateDate = new DateTime(2023, 09, 12),
                    Status = 0,
                    Description = "Description",
                },
                new ProductDetail()
                {
                    Id = new Guid("2eaaba04-80ff-43a6-a746-a74a91c7c3e8"),
                    ProductID = new Guid("cc37720a-7e89-463a-9510-1936e6761d8b"),
                    TipId = new Guid("cc37720a-7e89-463a-9510-1936e6761d84"),
                    ShaftId = new Guid("cc37720a-7e89-463a-9510-1936e6761d53"),
                    WeightId = new Guid("cc37720a-7e89-463a-9510-1936e6761d55"),
                    Quantity = 1,
                    ImportPrice = 4000000,
                    Price = 5000000,
                    CreateDate = new DateTime(2023, 09, 12),
                    Status = 0,
                    Description = "Description",
                },
                new ProductDetail()
                {
                    Id = new Guid("2eaaba04-80ff-43a6-a746-a74a91c7c3e9"),
                    ProductID = new Guid("cc37720a-7e89-463a-9510-1936e6761d8b"),
                    TipId = new Guid("cc37720a-7e89-463a-9510-1936e6761d94"),
                    ShaftId = new Guid("cc37720a-7e89-463a-9510-1936e6761d53"),
                    WeightId = new Guid("cc37720a-7e89-463a-9510-1936e6761d55"),
                    Quantity = 1,
                    ImportPrice = 4000000,
                    Price = 5000000,
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
                    ImportPrice = 4000000,
                    Price = 5000000,
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
                    ImportPrice = 4000000,
                    Price = 5000000,
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
                    ImportPrice = 4000000,
                    Price = 5000000,
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
                    ProductDetailId = new Guid("2eaaba04-80ff-43a6-a746-a74a91c4c0e0"),
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
                ProductDetailId = new Guid("2eaaba04-80ff-43a6-a746-a74a91c4c0e0"),
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
                Id = new Guid("d5c65162-7591-48c1-9198-daca150bce0c"),
                ProductDetailId = new Guid("2eaaba04-80ff-43a6-a746-a74a91c4c0e0"),
                Name = "elbjgb_02.jpg",
                Status = 0,
            },
            new ProductImage()
            {
                Id = new Guid("d5c65162-7591-48c1-9198-daca150bce1c"),
                ProductDetailId = new Guid("2eaaba04-80ff-43a6-a746-a74a91c4c0e0"),
                Name = "elbjgb-h2_01.jpg",
                Status = 0,
            },
            new ProductImage()
            {
                Id = new Guid("d5c65162-7591-48c1-9198-daca150bce2c"),
                ProductDetailId = new Guid("2eaaba04-80ff-43a6-a746-a74a91c4c0e0"),
                Name = "elbjgb-h1_01.jpg",
                Status = 0,
            },
            new ProductImage()
            {
                Id = new Guid("d5c65162-7591-48c1-9198-daca150bce3c"),
                ProductDetailId = new Guid("2eaaba04-80ff-43a6-a746-a74a91c4c0e0"),
                Name = "actxs-e_02_1_1.jpg",
                Status = 0,
            },
            new ProductImage()
            {
                Id = new Guid("d5c65162-7591-48c1-9198-daca150bce4c"),
                ProductDetailId = new Guid("2eaaba04-80ff-43a6-a746-a74a91c4c0e0"),
                Name = "actxs-q_02.jpg",
                Status = 0,
            },
            new ProductImage()
            {
                Id = new Guid("d5c65162-7591-48c1-9198-daca150bce5c"),
                ProductDetailId = new Guid("2eaaba04-80ff-43a6-a746-a74a91c4c0e1"),
                Name = "elbjgb_02.jpg",
                Status = 0,
            },
            new ProductImage()
            {
                Id = new Guid("d5c65162-7591-48c1-9198-daca150bce6c"),
                ProductDetailId = new Guid("2eaaba04-80ff-43a6-a746-a74a91c4c0e1"),
                Name = "elbjgb-h2_01.jpg",
                Status = 0,
            },
            new ProductImage()
            {
                Id = new Guid("d5c65162-7591-48c1-9198-daca150bce7c"),
                ProductDetailId = new Guid("2eaaba04-80ff-43a6-a746-a74a91c4c0e1"),
                Name = "elbjgb-h1_01.jpg",
                Status = 0,
            },
            new ProductImage()
            {
                Id = new Guid("d5c65162-7591-48c1-9198-daca150bce8c"),
                ProductDetailId = new Guid("2eaaba04-80ff-43a6-a746-a74a91c4c0e1"),
                Name = "actxs-e_02_1_1.jpg",
                Status = 0,
            },
            new ProductImage()
            {
                Id = new Guid("d5c65162-7591-48c1-9198-daca150bce9c"),
                ProductDetailId = new Guid("2eaaba04-80ff-43a6-a746-a74a91c4c0e1"),
                Name = "actxs-q_02.jpg",
                Status = 0,
            },
            new ProductImage()
            {
                Id = new Guid("d5c65162-7591-48c1-9198-daca151bce0c"),
                ProductDetailId = new Guid("2eaaba04-80ff-43a6-a746-a74a91c4c0e2"),
                Name = "elbjgb_02.jpg",
                Status = 0,
            },
            new ProductImage()
            {
                Id = new Guid("d5c65162-7591-48c1-9198-daca151bce1c"),
                ProductDetailId = new Guid("2eaaba04-80ff-43a6-a746-a74a91c4c0e2"),
                Name = "elbjgb-h2_01.jpg",
                Status = 0,
            },
            new ProductImage()
            {
                Id = new Guid("d5c65162-7591-48c1-9198-daca151bce2c"),
                ProductDetailId = new Guid("2eaaba04-80ff-43a6-a746-a74a91c4c0e2"),
                Name = "elbjgb-h1_01.jpg",
                Status = 0,
            },
            new ProductImage()
            {
                Id = new Guid("d5c65162-7591-48c1-9198-daca151bce3c"),
                ProductDetailId = new Guid("2eaaba04-80ff-43a6-a746-a74a91c4c0e2"),
                Name = "actxs-e_02_1_1.jpg",
                Status = 0,
            },
            new ProductImage()
            {
                Id = new Guid("d5c65162-7591-48c1-9198-daca151bce4c"),
                ProductDetailId = new Guid("2eaaba04-80ff-43a6-a746-a74a91c4c0e2"),
                Name = "actxs-q_02.jpg",
                Status = 0,
            },
            new ProductImage()
            {
                Id = new Guid("d5c65162-7591-48c1-9198-daca151bce5c"),
                ProductDetailId = new Guid("2eaaba04-80ff-43a6-a746-a74a91c4c0e3"),
                Name = "elbjgb_02.jpg",
                Status = 0,
            },
            new ProductImage()
            {
                Id = new Guid("d5c65162-7591-48c1-9198-daca151bce6c"),
                ProductDetailId = new Guid("2eaaba04-80ff-43a6-a746-a74a91c4c0e3"),
                Name = "elbjgb-h2_01.jpg",
                Status = 0,
            },
            new ProductImage()
            {
                Id = new Guid("d5c65162-7591-48c1-9198-daca151bce7c"),
                ProductDetailId = new Guid("2eaaba04-80ff-43a6-a746-a74a91c4c0e3"),
                Name = "elbjgb-h1_01.jpg",
                Status = 0,
            },
            new ProductImage()
            {
                Id = new Guid("d5c65162-7591-48c1-9198-daca151bce8c"),
                ProductDetailId = new Guid("2eaaba04-80ff-43a6-a746-a74a91c4c0e3"),
                Name = "actxs-e_02_1_1.jpg",
                Status = 0,
            },
            new ProductImage()
            {
                Id = new Guid("d5c65162-7591-48c1-9198-daca151bce9c"),
                ProductDetailId = new Guid("2eaaba04-80ff-43a6-a746-a74a91c4c0e3"),
                Name = "actxs-q_02.jpg",
                Status = 0,
            },
            new ProductImage()
            {
                Id = new Guid("d5c65162-7591-48c1-9198-daca152bce0c"),
                ProductDetailId = new Guid("2eaaba04-80ff-43a6-a746-a74a91c4c0e4"),
                Name = "elbjgb_02.jpg",
                Status = 0,
            },
            new ProductImage()
            {
                Id = new Guid("d5c65162-7591-48c1-9198-daca152bce1c"),
                ProductDetailId = new Guid("2eaaba04-80ff-43a6-a746-a74a91c4c0e4"),
                Name = "elbjgb-h2_01.jpg",
                Status = 0,
            },
            new ProductImage()
            {
                Id = new Guid("d5c65162-7591-48c1-9198-daca152bce2c"),
                ProductDetailId = new Guid("2eaaba04-80ff-43a6-a746-a74a91c4c0e4"),
                Name = "elbjgb-h1_01.jpg",
                Status = 0,
            },
            new ProductImage()
            {
                Id = new Guid("d5c65162-7591-48c1-9198-daca152bce3c"),
                ProductDetailId = new Guid("2eaaba04-80ff-43a6-a746-a74a91c4c0e4"),
                Name = "actxs-e_02_1_1.jpg",
                Status = 0,
            },
            new ProductImage()
            {
                Id = new Guid("d5c65162-7591-48c1-9198-daca152bce4c"),
                ProductDetailId = new Guid("2eaaba04-80ff-43a6-a746-a74a91c4c0e4"),
                Name = "actxs-q_02.jpg",
                Status = 0,
            },
            new ProductImage()
            {
                Id = new Guid("d5c65162-7591-48c1-9198-daca152bce5c"),
                ProductDetailId = new Guid("2eaaba04-80ff-43a6-a746-a74a91c4c0e5"),
                Name = "elbjgb_02.jpg",
                Status = 0,
            },
            new ProductImage()
            {
                Id = new Guid("d5c65162-7591-48c1-9198-daca152bce6c"),
                ProductDetailId = new Guid("2eaaba04-80ff-43a6-a746-a74a91c4c0e5"),
                Name = "elbjgb-h2_01.jpg",
                Status = 0,
            },
            new ProductImage()
            {
                Id = new Guid("d5c65162-7591-48c1-9198-daca152bce7c"),
                ProductDetailId = new Guid("2eaaba04-80ff-43a6-a746-a74a91c4c0e5"),
                Name = "elbjgb-h1_01.jpg",
                Status = 0,
            },
            new ProductImage()
            {
                Id = new Guid("d5c65162-7591-48c1-9198-daca152bce8c"),
                ProductDetailId = new Guid("2eaaba04-80ff-43a6-a746-a74a91c4c0e5"),
                Name = "actxs-e_02_1_1.jpg",
                Status = 0,
            },
            new ProductImage()
            {
                Id = new Guid("d5c65162-7591-48c1-9198-daca152bce9c"),
                ProductDetailId = new Guid("2eaaba04-80ff-43a6-a746-a74a91c4c0e5"),
                Name = "actxs-q_02.jpg",
                Status = 0,
            },
            new ProductImage()
            {
                Id = new Guid("d5c65162-7591-48c1-9198-daca153bce0c"),
                ProductDetailId = new Guid("2eaaba04-80ff-43a6-a746-a74a91c4c0e6"),
                Name = "elbjgb_02.jpg",
                Status = 0,
            },
            new ProductImage()
            {
                Id = new Guid("d5c65162-7591-48c1-9198-daca153bce1c"),
                ProductDetailId = new Guid("2eaaba04-80ff-43a6-a746-a74a91c4c0e6"),
                Name = "elbjgb-h2_01.jpg",
                Status = 0,
            },
            new ProductImage()
            {
                Id = new Guid("d5c65162-7591-48c1-9198-daca153bce2c"),
                ProductDetailId = new Guid("2eaaba04-80ff-43a6-a746-a74a91c4c0e6"),
                Name = "elbjgb-h1_01.jpg",
                Status = 0,
            },
            new ProductImage()
            {
                Id = new Guid("d5c65162-7591-48c1-9198-daca153bce3c"),
                ProductDetailId = new Guid("2eaaba04-80ff-43a6-a746-a74a91c4c0e6"),
                Name = "actxs-e_02_1_1.jpg",
                Status = 0,
            },
            new ProductImage()
            {
                Id = new Guid("d5c65162-7591-48c1-9198-daca153bce4c"),
                ProductDetailId = new Guid("2eaaba04-80ff-43a6-a746-a74a91c4c0e6"),
                Name = "actxs-q_02.jpg",
                Status = 0,
            },
            new ProductImage()
            {
                Id = new Guid("d5c65162-7591-48c1-9198-daca153bce5c"),
                ProductDetailId = new Guid("2eaaba04-80ff-43a6-a746-a74a91c4c0e7"),
                Name = "elbjgb_02.jpg",
                Status = 0,
            },
            new ProductImage()
            {
                Id = new Guid("d5c65162-7591-48c1-9198-daca153bce6c"),
                ProductDetailId = new Guid("2eaaba04-80ff-43a6-a746-a74a91c4c0e7"),
                Name = "elbjgb-h2_01.jpg",
                Status = 0,
            },
            new ProductImage()
            {
                Id = new Guid("d5c65162-7591-48c1-9198-daca153bce7c"),
                ProductDetailId = new Guid("2eaaba04-80ff-43a6-a746-a74a91c4c0e7"),
                Name = "elbjgb-h1_01.jpg",
                Status = 0,
            },
            new ProductImage()
            {
                Id = new Guid("d5c65162-7591-48c1-9198-daca153bce8c"),
                ProductDetailId = new Guid("2eaaba04-80ff-43a6-a746-a74a91c4c0e7"),
                Name = "actxs-e_02_1_1.jpg",
                Status = 0,
            },
            new ProductImage()
            {
                Id = new Guid("d5c65162-7591-48c1-9198-daca153bce9c"),
                ProductDetailId = new Guid("2eaaba04-80ff-43a6-a746-a74a91c4c0e7"),
                Name = "actxs-q_02.jpg",
                Status = 0,
            },
            new ProductImage()
            {
                Id = new Guid("d5c65162-7591-48c1-9198-daca154bce0c"),
                ProductDetailId = new Guid("2eaaba04-80ff-43a6-a746-a74a91c4c0e8"),
                Name = "elbjgb_02.jpg",
                Status = 0,
            },
            new ProductImage()
            {
                Id = new Guid("d5c65162-7591-48c1-9198-daca154bce1c"),
                ProductDetailId = new Guid("2eaaba04-80ff-43a6-a746-a74a91c4c0e8"),
                Name = "elbjgb-h2_01.jpg",
                Status = 0,
            },
            new ProductImage()
            {
                Id = new Guid("d5c65162-7591-48c1-9198-daca154bce2c"),
                ProductDetailId = new Guid("2eaaba04-80ff-43a6-a746-a74a91c4c0e8"),
                Name = "elbjgb-h1_01.jpg",
                Status = 0,
            },
            new ProductImage()
            {
                Id = new Guid("d5c65162-7591-48c1-9198-daca154bce3c"),
                ProductDetailId = new Guid("2eaaba04-80ff-43a6-a746-a74a91c4c0e8"),
                Name = "actxs-e_02_1_1.jpg",
                Status = 0,
            },
            new ProductImage()
            {
                Id = new Guid("d5c65162-7591-48c1-9198-daca154bce4c"),
                ProductDetailId = new Guid("2eaaba04-80ff-43a6-a746-a74a91c4c0e8"),
                Name = "actxs-q_02.jpg",
                Status = 0,
            },
            new ProductImage()
            {
                Id = new Guid("d5c65162-7591-48c1-9198-daca154bce5c"),
                ProductDetailId = new Guid("2eaaba04-80ff-43a6-a746-a74a91c4c0e9"),
                Name = "elbjgb_02.jpg",
                Status = 0,
            },
            new ProductImage()
            {
                Id = new Guid("d5c65162-7591-48c1-9198-daca154bce6c"),
                ProductDetailId = new Guid("2eaaba04-80ff-43a6-a746-a74a91c4c0e9"),
                Name = "elbjgb-h2_01.jpg",
                Status = 0,
            },
            new ProductImage()
            {
                Id = new Guid("d5c65162-7591-48c1-9198-daca154bce7c"),
                ProductDetailId = new Guid("2eaaba04-80ff-43a6-a746-a74a91c4c0e9"),
                Name = "elbjgb-h1_01.jpg",
                Status = 0,
            },
            new ProductImage()
            {
                Id = new Guid("d5c65162-7591-48c1-9198-daca154bce8c"),
                ProductDetailId = new Guid("2eaaba04-80ff-43a6-a746-a74a91c4c0e9"),
                Name = "actxs-e_02_1_1.jpg",
                Status = 0,
            },
            new ProductImage()
            {
                Id = new Guid("d5c65162-7591-48c1-9198-daca154bce9c"),
                ProductDetailId = new Guid("2eaaba04-80ff-43a6-a746-a74a91c4c0e9"),
                Name = "actxs-q_02.jpg",
                Status = 0,
            },
            new ProductImage()
            {
                Id = new Guid("d5c65162-7591-48c1-9198-daca155bce0c"),
                ProductDetailId = new Guid("2eaaba04-80ff-43a6-a746-a74a91c4c1e0"),
                Name = "elbjgb_02.jpg",
                Status = 0,
            },
            new ProductImage()
            {
                Id = new Guid("d5c65162-7591-48c1-9198-daca155bce1c"),
                ProductDetailId = new Guid("2eaaba04-80ff-43a6-a746-a74a91c4c1e0"),
                Name = "elbjgb-h2_01.jpg",
                Status = 0,
            },
            new ProductImage()
            {
                Id = new Guid("d5c65162-7591-48c1-9198-daca155bce2c"),
                ProductDetailId = new Guid("2eaaba04-80ff-43a6-a746-a74a91c4c1e0"),
                Name = "elbjgb-h1_01.jpg",
                Status = 0,
            },
            new ProductImage()
            {
                Id = new Guid("d5c65162-7591-48c1-9198-daca155bce3c"),
                ProductDetailId = new Guid("2eaaba04-80ff-43a6-a746-a74a91c4c1e0"),
                Name = "actxs-e_02_1_1.jpg",
                Status = 0,
            },
            new ProductImage()
            {
                Id = new Guid("d5c65162-7591-48c1-9198-daca155bce4c"),
                ProductDetailId = new Guid("2eaaba04-80ff-43a6-a746-a74a91c4c1e0"),
                Name = "actxs-q_02.jpg",
                Status = 0,
            },
            new ProductImage()
            {
                Id = new Guid("d5c65162-7591-48c1-9198-daca155bce5c"),
                ProductDetailId = new Guid("2eaaba04-80ff-43a6-a746-a74a91c4c1e1"),
                Name = "elbjgb_02.jpg",
                Status = 0,
            },
            new ProductImage()
            {
                Id = new Guid("d5c65162-7591-48c1-9198-daca155bce6c"),
                ProductDetailId = new Guid("2eaaba04-80ff-43a6-a746-a74a91c4c1e1"),
                Name = "elbjgb-h2_01.jpg",
                Status = 0,
            },
            new ProductImage()
            {
                Id = new Guid("d5c65162-7591-48c1-9198-daca155bce7c"),
                ProductDetailId = new Guid("2eaaba04-80ff-43a6-a746-a74a91c4c1e1"),
                Name = "elbjgb-h1_01.jpg",
                Status = 0,
            },
            new ProductImage()
            {
                Id = new Guid("d5c65162-7591-48c1-9198-daca155bce8c"),
                ProductDetailId = new Guid("2eaaba04-80ff-43a6-a746-a74a91c4c1e1"),
                Name = "actxs-e_02_1_1.jpg",
                Status = 0,
            },
            new ProductImage()
            {
                Id = new Guid("d5c65162-7591-48c1-9198-daca155bce9c"),
                ProductDetailId = new Guid("2eaaba04-80ff-43a6-a746-a74a91c4c1e1"),
                Name = "actxs-q_02.jpg",
                Status = 0,
            },
            new ProductImage()
            {
                Id = new Guid("d5c65162-7591-48c1-9198-daca156bce0c"),
                ProductDetailId = new Guid("2eaaba04-80ff-43a6-a746-a74a91c4c1e2"),
                Name = "elbjgb_02.jpg",
                Status = 0,
            },
            new ProductImage()
            {
                Id = new Guid("d5c65162-7591-48c1-9198-daca156bce1c"),
                ProductDetailId = new Guid("2eaaba04-80ff-43a6-a746-a74a91c4c1e2"),
                Name = "elbjgb-h2_01.jpg",
                Status = 0,
            },
            new ProductImage()
            {
                Id = new Guid("d5c65162-7591-48c1-9198-daca156bce2c"),
                ProductDetailId = new Guid("2eaaba04-80ff-43a6-a746-a74a91c4c1e2"),
                Name = "elbjgb-h1_01.jpg",
                Status = 0,
            },
            new ProductImage()
            {
                Id = new Guid("d5c65162-7591-48c1-9198-daca156bce3c"),
                ProductDetailId = new Guid("2eaaba04-80ff-43a6-a746-a74a91c4c1e2"),
                Name = "actxs-e_02_1_1.jpg",
                Status = 0,
            },
            new ProductImage()
            {
                Id = new Guid("d5c65162-7591-48c1-9198-daca156bce4c"),
                ProductDetailId = new Guid("2eaaba04-80ff-43a6-a746-a74a91c4c1e2"),
                Name = "actxs-q_02.jpg",
                Status = 0,
            },
            new ProductImage()
            {
                Id = new Guid("d5c65162-7591-48c1-9198-daca156bce5c"),
                ProductDetailId = new Guid("2eaaba04-80ff-43a6-a746-a74a91c4c1e3"),
                Name = "elbjgb_02.jpg",
                Status = 0,
            },
            new ProductImage()
            {
                Id = new Guid("d5c65162-7591-48c1-9198-daca156bce6c"),
                ProductDetailId = new Guid("2eaaba04-80ff-43a6-a746-a74a91c4c1e3"),
                Name = "elbjgb-h2_01.jpg",
                Status = 0,
            },
            new ProductImage()
            {
                Id = new Guid("d5c65162-7591-48c1-9198-daca156bce7c"),
                ProductDetailId = new Guid("2eaaba04-80ff-43a6-a746-a74a91c4c1e3"),
                Name = "elbjgb-h1_01.jpg",
                Status = 0,
            },
            new ProductImage()
            {
                Id = new Guid("d5c65162-7591-48c1-9198-daca156bce8c"),
                ProductDetailId = new Guid("2eaaba04-80ff-43a6-a746-a74a91c4c1e3"),
                Name = "actxs-e_02_1_1.jpg",
                Status = 0,
            },
            new ProductImage()
            {
                Id = new Guid("d5c65162-7591-48c1-9198-daca156bce9c"),
                ProductDetailId = new Guid("2eaaba04-80ff-43a6-a746-a74a91c4c1e3"),
                Name = "actxs-q_02.jpg",
                Status = 0,
            },
            new ProductImage()
            {
                Id = new Guid("d5c65162-7591-48c1-9198-daca157bce0c"),
                ProductDetailId = new Guid("2eaaba04-80ff-43a6-a746-a74a91c4c1e4"),
                Name = "elbjgb_02.jpg",
                Status = 0,
            },
            new ProductImage()
            {
                Id = new Guid("d5c65162-7591-48c1-9198-daca157bce1c"),
                ProductDetailId = new Guid("2eaaba04-80ff-43a6-a746-a74a91c4c1e4"),
                Name = "elbjgb-h2_01.jpg",
                Status = 0,
            },
            new ProductImage()
            {
                Id = new Guid("d5c65162-7591-48c1-9198-daca157bce2c"),
                ProductDetailId = new Guid("2eaaba04-80ff-43a6-a746-a74a91c4c1e4"),
                Name = "elbjgb-h1_01.jpg",
                Status = 0,
            },
            new ProductImage()
            {
                Id = new Guid("d5c65162-7591-48c1-9198-daca157bce3c"),
                ProductDetailId = new Guid("2eaaba04-80ff-43a6-a746-a74a91c4c1e4"),
                Name = "actxs-e_02_1_1.jpg",
                Status = 0,
            },
            new ProductImage()
            {
                Id = new Guid("d5c65162-7591-48c1-9198-daca157bce4c"),
                ProductDetailId = new Guid("2eaaba04-80ff-43a6-a746-a74a91c4c1e4"),
                Name = "actxs-q_02.jpg",
                Status = 0,
            },
            new ProductImage()
            {
                Id = new Guid("d5c65162-7591-48c1-9198-daca157bce5c"),
                ProductDetailId = new Guid("2eaaba04-80ff-43a6-a746-a74a91c4c1e5"),
                Name = "elbjgb_02.jpg",
                Status = 0,
            },
            new ProductImage()
            {
                Id = new Guid("d5c65162-7591-48c1-9198-daca157bce6c"),
                ProductDetailId = new Guid("2eaaba04-80ff-43a6-a746-a74a91c4c1e5"),
                Name = "elbjgb-h2_01.jpg",
                Status = 0,
            },
            new ProductImage()
            {
                Id = new Guid("d5c65162-7591-48c1-9198-daca157bce7c"),
                ProductDetailId = new Guid("2eaaba04-80ff-43a6-a746-a74a91c4c1e5"),
                Name = "elbjgb-h1_01.jpg",
                Status = 0,
            },
            new ProductImage()
            {
                Id = new Guid("d5c65162-7591-48c1-9198-daca157bce8c"),
                ProductDetailId = new Guid("2eaaba04-80ff-43a6-a746-a74a91c4c1e5"),
                Name = "actxs-e_02_1_1.jpg",
                Status = 0,
            },
            new ProductImage()
            {
                Id = new Guid("d5c65162-7591-48c1-9198-daca157bce9c"),
                ProductDetailId = new Guid("2eaaba04-80ff-43a6-a746-a74a91c4c1e5"),
                Name = "actxs-q_02.jpg",
                Status = 0,
            },
            new ProductImage()
            {
                Id = new Guid("d5c65162-7591-48c1-9198-daca158bce0c"),
                ProductDetailId = new Guid("2eaaba04-80ff-43a6-a746-a74a91c4c1e6"),
                Name = "elbjgb_02.jpg",
                Status = 0,
            },
            new ProductImage()
            {
                Id = new Guid("d5c65162-7591-48c1-9198-daca158bce1c"),
                ProductDetailId = new Guid("2eaaba04-80ff-43a6-a746-a74a91c4c1e6"),
                Name = "elbjgb-h2_01.jpg",
                Status = 0,
            },
            new ProductImage()
            {
                Id = new Guid("d5c65162-7591-48c1-9198-daca158bce2c"),
                ProductDetailId = new Guid("2eaaba04-80ff-43a6-a746-a74a91c4c1e6"),
                Name = "elbjgb-h1_01.jpg",
                Status = 0,
            },
            new ProductImage()
            {
                Id = new Guid("d5c65162-7591-48c1-9198-daca158bce3c"),
                ProductDetailId = new Guid("2eaaba04-80ff-43a6-a746-a74a91c4c1e6"),
                Name = "actxs-e_02_1_1.jpg",
                Status = 0,
            },
            new ProductImage()
            {
                Id = new Guid("d5c65162-7591-48c1-9198-daca158bce4c"),
                ProductDetailId = new Guid("2eaaba04-80ff-43a6-a746-a74a91c4c1e6"),
                Name = "actxs-q_02.jpg",
                Status = 0,
            },
            new ProductImage()
            {
                Id = new Guid("d5c65162-7591-48c1-9198-daca158bce5c"),
                ProductDetailId = new Guid("2eaaba04-80ff-43a6-a746-a74a91c4c1e7"),
                Name = "elbjgb_02.jpg",
                Status = 0,
            },
            new ProductImage()
            {
                Id = new Guid("d5c65162-7591-48c1-9198-daca158bce6c"),
                ProductDetailId = new Guid("2eaaba04-80ff-43a6-a746-a74a91c4c1e7"),
                Name = "elbjgb-h2_01.jpg",
                Status = 0,
            },
            new ProductImage()
            {
                Id = new Guid("d5c65162-7591-48c1-9198-daca158bce7c"),
                ProductDetailId = new Guid("2eaaba04-80ff-43a6-a746-a74a91c4c1e7"),
                Name = "elbjgb-h1_01.jpg",
                Status = 0,
            },
            new ProductImage()
            {
                Id = new Guid("d5c65162-7591-48c1-9198-daca158bce8c"),
                ProductDetailId = new Guid("2eaaba04-80ff-43a6-a746-a74a91c4c1e7"),
                Name = "actxs-e_02_1_1.jpg",
                Status = 0,
            },
            new ProductImage()
            {
                Id = new Guid("d5c65162-7591-48c1-9198-daca158bce9c"),
                ProductDetailId = new Guid("2eaaba04-80ff-43a6-a746-a74a91c4c1e7"),
                Name = "actxs-q_02.jpg",
                Status = 0,
            },
            new ProductImage()
            {
                Id = new Guid("d5c65162-7591-48c1-9198-daca1539ce0c"),
                ProductDetailId = new Guid("2eaaba04-80ff-43a6-a746-a74a91c4c1e8"),
                Name = "elbjgb_02.jpg",
                Status = 0,
            },
            new ProductImage()
            {
                Id = new Guid("d5c65162-7591-48c1-9198-daca1539ce1c"),
                ProductDetailId = new Guid("2eaaba04-80ff-43a6-a746-a74a91c4c1e8"),
                Name = "elbjgb-h2_01.jpg",
                Status = 0,
            },
            new ProductImage()
            {
                Id = new Guid("d5c65162-7591-48c1-9198-daca159bce2c"),
                ProductDetailId = new Guid("2eaaba04-80ff-43a6-a746-a74a91c4c1e8"),
                Name = "elbjgb-h1_01.jpg",
                Status = 0,
            },
            new ProductImage()
            {
                Id = new Guid("d5c65162-7591-48c1-9198-daca159bce3c"),
                ProductDetailId = new Guid("2eaaba04-80ff-43a6-a746-a74a91c4c1e8"),
                Name = "actxs-e_02_1_1.jpg",
                Status = 0,
            },
            new ProductImage()
            {
                Id = new Guid("d5c65162-7591-48c1-9198-daca159bce4c"),
                ProductDetailId = new Guid("2eaaba04-80ff-43a6-a746-a74a91c4c1e8"),
                Name = "actxs-q_02.jpg",
                Status = 0,
            },
            new ProductImage()
            {
                Id = new Guid("d5c65162-7591-48c1-9198-daca159bce5c"),
                ProductDetailId = new Guid("2eaaba04-80ff-43a6-a746-a74a91c4c1e9"),
                Name = "elbjgb_02.jpg",
                Status = 0,
            },
            new ProductImage()
            {
                Id = new Guid("d5c65162-7591-48c1-9198-daca159bce6c"),
                ProductDetailId = new Guid("2eaaba04-80ff-43a6-a746-a74a91c4c1e9"),
                Name = "elbjgb-h2_01.jpg",
                Status = 0,
            },
            new ProductImage()
            {
                Id = new Guid("d5c65162-7591-48c1-9198-daca159bce7c"),
                ProductDetailId = new Guid("2eaaba04-80ff-43a6-a746-a74a91c4c1e9"),
                Name = "elbjgb-h1_01.jpg",
                Status = 0,
            },
            new ProductImage()
            {
                Id = new Guid("d5c65162-7591-48c1-9198-daca159bce8c"),
                ProductDetailId = new Guid("2eaaba04-80ff-43a6-a746-a74a91c4c1e9"),
                Name = "actxs-e_02_1_1.jpg",
                Status = 0,
            },
            new ProductImage()
            {
                Id = new Guid("d5c65162-7591-48c1-9198-daca159bce9c"),
                ProductDetailId = new Guid("2eaaba04-80ff-43a6-a746-a74a91c4c1e9"),
                Name = "actxs-q_02.jpg",
                Status = 0,
            },
            new ProductImage()
            {
                Id = new Guid("d5c65162-7591-48c1-9198-daca160bce0c"),
                ProductDetailId = new Guid("2eaaba04-80ff-43a6-a746-a74a91c4c2e0"),
                Name = "elbjgb_02.jpg",
                Status = 0,
            },
            new ProductImage()
            {
                Id = new Guid("d5c65162-7591-48c1-9198-daca160bce1c"),
                ProductDetailId = new Guid("2eaaba04-80ff-43a6-a746-a74a91c4c2e0"),
                Name = "elbjgb-h2_01.jpg",
                Status = 0,
            },
            new ProductImage()
            {
                Id = new Guid("d5c65162-7591-48c1-9198-daca160bce2c"),
                ProductDetailId = new Guid("2eaaba04-80ff-43a6-a746-a74a91c4c2e0"),
                Name = "elbjgb-h1_01.jpg",
                Status = 0,
            },
            new ProductImage()
            {
                Id = new Guid("d5c65162-7591-48c1-9198-daca160bce3c"),
                ProductDetailId = new Guid("2eaaba04-80ff-43a6-a746-a74a91c4c2e0"),
                Name = "actxs-e_02_1_1.jpg",
                Status = 0,
            },
            new ProductImage()
            {
                Id = new Guid("d5c65162-7591-48c1-9198-daca160bce4c"),
                ProductDetailId = new Guid("2eaaba04-80ff-43a6-a746-a74a91c4c2e0"),
                Name = "actxs-q_02.jpg",
                Status = 0,
            },
            new ProductImage()
            {
                Id = new Guid("d5c65162-7591-48c1-9198-daca160bce5c"),
                ProductDetailId = new Guid("2eaaba04-80ff-43a6-a746-a74a91c4c2e1"),
                Name = "elbjgb_02.jpg",
                Status = 0,
            },
            new ProductImage()
            {
                Id = new Guid("d5c65162-7591-48c1-9198-daca160bce6c"),
                ProductDetailId = new Guid("2eaaba04-80ff-43a6-a746-a74a91c4c2e1"),
                Name = "elbjgb-h2_01.jpg",
                Status = 0,
            },
            new ProductImage()
            {
                Id = new Guid("d5c65162-7591-48c1-9198-daca160bce7c"),
                ProductDetailId = new Guid("2eaaba04-80ff-43a6-a746-a74a91c4c2e1"),
                Name = "elbjgb-h1_01.jpg",
                Status = 0,
            },
            new ProductImage()
            {
                Id = new Guid("d5c65162-7591-48c1-9198-daca160bce8c"),
                ProductDetailId = new Guid("2eaaba04-80ff-43a6-a746-a74a91c4c2e1"),
                Name = "actxs-e_02_1_1.jpg",
                Status = 0,
            },
            new ProductImage()
            {
                Id = new Guid("d5c65162-7591-48c1-9198-daca160bce9c"),
                ProductDetailId = new Guid("2eaaba04-80ff-43a6-a746-a74a91c4c2e1"),
                Name = "actxs-q_02.jpg",
                Status = 0,
            },
            new ProductImage()
            {
                Id = new Guid("d5c65162-7591-48c1-9198-daca161bce0c"),
                ProductDetailId = new Guid("2eaaba04-80ff-43a6-a746-a74a91c4c2e2"),
                Name = "elbjgb_02.jpg",
                Status = 0,
            },
            new ProductImage()
            {
                Id = new Guid("d5c65162-7591-48c1-9198-daca161bce1c"),
                ProductDetailId = new Guid("2eaaba04-80ff-43a6-a746-a74a91c4c2e2"),
                Name = "elbjgb-h2_01.jpg",
                Status = 0,
            },
            new ProductImage()
            {
                Id = new Guid("d5c65162-7591-48c1-9198-daca161bce2c"),
                ProductDetailId = new Guid("2eaaba04-80ff-43a6-a746-a74a91c4c2e2"),
                Name = "elbjgb-h1_01.jpg",
                Status = 0,
            },
            new ProductImage()
            {
                Id = new Guid("d5c65162-7591-48c1-9198-daca161bce3c"),
                ProductDetailId = new Guid("2eaaba04-80ff-43a6-a746-a74a91c4c2e2"),
                Name = "actxs-e_02_1_1.jpg",
                Status = 0,
            },
            new ProductImage()
            {
                Id = new Guid("d5c65162-7591-48c1-9198-daca161bce4c"),
                ProductDetailId = new Guid("2eaaba04-80ff-43a6-a746-a74a91c4c2e2"),
                Name = "actxs-q_02.jpg",
                Status = 0,
            },
            new ProductImage()
            {
                Id = new Guid("d5c65162-7591-48c1-9198-daca161bce5c"),
                ProductDetailId = new Guid("2eaaba04-80ff-43a6-a746-a74a91c4c2e3"),
                Name = "elbjgb_02.jpg",
                Status = 0,
            },
            new ProductImage()
            {
                Id = new Guid("d5c65162-7591-48c1-9198-daca161bce6c"),
                ProductDetailId = new Guid("2eaaba04-80ff-43a6-a746-a74a91c4c2e3"),
                Name = "elbjgb-h2_01.jpg",
                Status = 0,
            },
            new ProductImage()
            {
                Id = new Guid("d5c65162-7591-48c1-9198-daca161bce7c"),
                ProductDetailId = new Guid("2eaaba04-80ff-43a6-a746-a74a91c4c2e3"),
                Name = "elbjgb-h1_01.jpg",
                Status = 0,
            },
            new ProductImage()
            {
                Id = new Guid("d5c65162-7591-48c1-9198-daca161bce8c"),
                ProductDetailId = new Guid("2eaaba04-80ff-43a6-a746-a74a91c4c2e3"),
                Name = "actxs-e_02_1_1.jpg",
                Status = 0,
            },
            new ProductImage()
            {
                Id = new Guid("d5c65162-7591-48c1-9198-daca161bce9c"),
                ProductDetailId = new Guid("2eaaba04-80ff-43a6-a746-a74a91c4c2e3"),
                Name = "actxs-q_02.jpg",
                Status = 0,
            },
            new ProductImage()
            {
                Id = new Guid("d5c65162-7591-48c1-9198-daca162bce0c"),
                ProductDetailId = new Guid("2eaaba04-80ff-43a6-a746-a74a91c4c2e4"),
                Name = "elbjgb_02.jpg",
                Status = 0,
            },
            new ProductImage()
            {
                Id = new Guid("d5c65162-7591-48c1-9198-daca162bce1c"),
                ProductDetailId = new Guid("2eaaba04-80ff-43a6-a746-a74a91c4c2e4"),
                Name = "elbjgb-h2_01.jpg",
                Status = 0,
            },
            new ProductImage()
            {
                Id = new Guid("d5c65162-7591-48c1-9198-daca162bce2c"),
                ProductDetailId = new Guid("2eaaba04-80ff-43a6-a746-a74a91c4c2e4"),
                Name = "elbjgb-h1_01.jpg",
                Status = 0,
            },
            new ProductImage()
            {
                Id = new Guid("d5c65162-7591-48c1-9198-daca162bce3c"),
                ProductDetailId = new Guid("2eaaba04-80ff-43a6-a746-a74a91c4c2e4"),
                Name = "actxs-e_02_1_1.jpg",
                Status = 0,
            },
            new ProductImage()
            {
                Id = new Guid("d5c65162-7591-48c1-9198-daca162bce4c"),
                ProductDetailId = new Guid("2eaaba04-80ff-43a6-a746-a74a91c4c2e4"),
                Name = "actxs-q_02.jpg",
                Status = 0,
            },
            new ProductImage()
            {
                Id = new Guid("d5c65162-7591-48c1-9198-daca162bce5c"),
                ProductDetailId = new Guid("2eaaba04-80ff-43a6-a746-a74a91c4c2e5"),
                Name = "elbjgb_02.jpg",
                Status = 0,
            },
            new ProductImage()
            {
                Id = new Guid("d5c65162-7591-48c1-9198-daca162bce6c"),
                ProductDetailId = new Guid("2eaaba04-80ff-43a6-a746-a74a91c4c2e5"),
                Name = "elbjgb-h2_01.jpg",
                Status = 0,
            },
            new ProductImage()
            {
                Id = new Guid("d5c65162-7591-48c1-9198-daca162bce7c"),
                ProductDetailId = new Guid("2eaaba04-80ff-43a6-a746-a74a91c4c2e5"),
                Name = "elbjgb-h1_01.jpg",
                Status = 0,
            },
            new ProductImage()
            {
                Id = new Guid("d5c65162-7591-48c1-9198-daca162bce8c"),
                ProductDetailId = new Guid("2eaaba04-80ff-43a6-a746-a74a91c4c2e5"),
                Name = "actxs-e_02_1_1.jpg",
                Status = 0,
            },
            new ProductImage()
            {
                Id = new Guid("d5c65162-7591-48c1-9198-daca162bce9c"),
                ProductDetailId = new Guid("2eaaba04-80ff-43a6-a746-a74a91c4c2e5"),
                Name = "actxs-q_02.jpg",
                Status = 0,
            },
            new ProductImage()
            {
                Id = new Guid("d5c65162-7591-48c1-9198-daca163bce0c"),
                ProductDetailId = new Guid("2eaaba04-80ff-43a6-a746-a74a91c4c2e6"),
                Name = "elbjgb_02.jpg",
                Status = 0,
            },
            new ProductImage()
            {
                Id = new Guid("d5c65162-7591-48c1-9198-daca163bce1c"),
                ProductDetailId = new Guid("2eaaba04-80ff-43a6-a746-a74a91c4c2e6"),
                Name = "elbjgb-h2_01.jpg",
                Status = 0,
            },
            new ProductImage()
            {
                Id = new Guid("d5c65162-7591-48c1-9198-daca163bce2c"),
                ProductDetailId = new Guid("2eaaba04-80ff-43a6-a746-a74a91c4c2e6"),
                Name = "elbjgb-h1_01.jpg",
                Status = 0,
            },
            new ProductImage()
            {
                Id = new Guid("d5c65162-7591-48c1-9198-daca163bce3c"),
                ProductDetailId = new Guid("2eaaba04-80ff-43a6-a746-a74a91c4c2e6"),
                Name = "actxs-e_02_1_1.jpg",
                Status = 0,
            },
            new ProductImage()
            {
                Id = new Guid("d5c65162-7591-48c1-9198-daca163bce4c"),
                ProductDetailId = new Guid("2eaaba04-80ff-43a6-a746-a74a91c4c2e6"),
                Name = "actxs-q_02.jpg",
                Status = 0,
            },
            new ProductImage()
            {
                Id = new Guid("d5c65162-7591-48c1-9198-daca163bce5c"),
                ProductDetailId = new Guid("2eaaba04-80ff-43a6-a746-a74a91c4c2e7"),
                Name = "elbjgb_02.jpg",
                Status = 0,
            },
            new ProductImage()
            {
                Id = new Guid("d5c65162-7591-48c1-9198-daca163bce6c"),
                ProductDetailId = new Guid("2eaaba04-80ff-43a6-a746-a74a91c4c2e7"),
                Name = "elbjgb-h2_01.jpg",
                Status = 0,
            },
            new ProductImage()
            {
                Id = new Guid("d5c65162-7591-48c1-9198-daca163bce7c"),
                ProductDetailId = new Guid("2eaaba04-80ff-43a6-a746-a74a91c4c2e7"),
                Name = "elbjgb-h1_01.jpg",
                Status = 0,
            },
            new ProductImage()
            {
                Id = new Guid("d5c65162-7591-48c1-9198-daca163bce8c"),
                ProductDetailId = new Guid("2eaaba04-80ff-43a6-a746-a74a91c4c2e7"),
                Name = "actxs-e_02_1_1.jpg",
                Status = 0,
            },
            new ProductImage()
            {
                Id = new Guid("d5c65162-7591-48c1-9198-daca163bce9c"),
                ProductDetailId = new Guid("2eaaba04-80ff-43a6-a746-a74a91c4c2e7"),
                Name = "actxs-q_02.jpg",
                Status = 0,
            },
            new ProductImage()
            {
                Id = new Guid("d5c65162-7591-48c1-9198-daca164bce0c"),
                ProductDetailId = new Guid("2eaaba04-80ff-43a6-a746-a74a91c4c2e8"),
                Name = "elbjgb_02.jpg",
                Status = 0,
            },
            new ProductImage()
            {
                Id = new Guid("d5c65162-7591-48c1-9198-daca164bce1c"),
                ProductDetailId = new Guid("2eaaba04-80ff-43a6-a746-a74a91c4c2e8"),
                Name = "elbjgb-h2_01.jpg",
                Status = 0,
            },
            new ProductImage()
            {
                Id = new Guid("d5c65162-7591-48c1-9198-daca164bce2c"),
                ProductDetailId = new Guid("2eaaba04-80ff-43a6-a746-a74a91c4c2e8"),
                Name = "elbjgb-h1_01.jpg",
                Status = 0,
            },
            new ProductImage()
            {
                Id = new Guid("d5c65162-7591-48c1-9198-daca164bce3c"),
                ProductDetailId = new Guid("2eaaba04-80ff-43a6-a746-a74a91c4c2e8"),
                Name = "actxs-e_02_1_1.jpg",
                Status = 0,
            },
            new ProductImage()
            {
                Id = new Guid("d5c65162-7591-48c1-9198-daca164bce4c"),
                ProductDetailId = new Guid("2eaaba04-80ff-43a6-a746-a74a91c4c2e8"),
                Name = "actxs-q_02.jpg",
                Status = 0,
            },
            new ProductImage()
            {
                Id = new Guid("d5c65162-7591-48c1-9198-daca164bce5c"),
                ProductDetailId = new Guid("2eaaba04-80ff-43a6-a746-a74a91c4c2e9"),
                Name = "elbjgb_02.jpg",
                Status = 0,
            },
            new ProductImage()
            {
                Id = new Guid("d5c65162-7591-48c1-9198-daca164bce6c"),
                ProductDetailId = new Guid("2eaaba04-80ff-43a6-a746-a74a91c4c2e9"),
                Name = "elbjgb-h2_01.jpg",
                Status = 0,
            },
            new ProductImage()
            {
                Id = new Guid("d5c65162-7591-48c1-9198-daca164bce7c"),
                ProductDetailId = new Guid("2eaaba04-80ff-43a6-a746-a74a91c4c2e9"),
                Name = "elbjgb-h1_01.jpg",
                Status = 0,
            },
            new ProductImage()
            {
                Id = new Guid("d5c65162-7591-48c1-9198-daca164bce8c"),
                ProductDetailId = new Guid("2eaaba04-80ff-43a6-a746-a74a91c4c2e9"),
                Name = "actxs-e_02_1_1.jpg",
                Status = 0,
            },
            new ProductImage()
            {
                Id = new Guid("d5c65162-7591-48c1-9198-daca164bce9c"),
                ProductDetailId = new Guid("2eaaba04-80ff-43a6-a746-a74a91c4c2e9"),
                Name = "actxs-q_02.jpg",
                Status = 0,
            },
            new ProductImage()
            {
                Id = new Guid("d5c65162-7591-48c1-9198-daca165bce0c"),
                ProductDetailId = new Guid("2eaaba04-80ff-43a6-a746-a74a91c4c3e0"),
                Name = "elbjgb_02.jpg",
                Status = 0,
            },
            new ProductImage()
            {
                Id = new Guid("d5c65162-7591-48c1-9198-daca165bce1c"),
                ProductDetailId = new Guid("2eaaba04-80ff-43a6-a746-a74a91c4c3e0"),
                Name = "elbjgb-h2_01.jpg",
                Status = 0,
            },
            new ProductImage()
            {
                Id = new Guid("d5c65162-7591-48c1-9198-daca165bce2c"),
                ProductDetailId = new Guid("2eaaba04-80ff-43a6-a746-a74a91c4c3e0"),
                Name = "elbjgb-h1_01.jpg",
                Status = 0,
            },
            new ProductImage()
            {
                Id = new Guid("d5c65162-7591-48c1-9198-daca165bce3c"),
                ProductDetailId = new Guid("2eaaba04-80ff-43a6-a746-a74a91c4c3e0"),
                Name = "actxs-e_02_1_1.jpg",
                Status = 0,
            },
            new ProductImage()
            {
                Id = new Guid("d5c65162-7591-48c1-9198-daca165bce4c"),
                ProductDetailId = new Guid("2eaaba04-80ff-43a6-a746-a74a91c4c3e0"),
                Name = "actxs-q_02.jpg",
                Status = 0,
            },
            new ProductImage()
            {
                Id = new Guid("d5c65162-7591-48c1-9198-daca165bce5c"),
                ProductDetailId = new Guid("2eaaba04-80ff-43a6-a746-a74a91c4c3e1"),
                Name = "elbjgb_02.jpg",
                Status = 0,
            },
            new ProductImage()
            {
                Id = new Guid("d5c65162-7591-48c1-9198-daca165bce6c"),
                ProductDetailId = new Guid("2eaaba04-80ff-43a6-a746-a74a91c4c3e1"),
                Name = "elbjgb-h2_01.jpg",
                Status = 0,
            },
            new ProductImage()
            {
                Id = new Guid("d5c65162-7591-48c1-9198-daca165bce7c"),
                ProductDetailId = new Guid("2eaaba04-80ff-43a6-a746-a74a91c4c3e1"),
                Name = "elbjgb-h1_01.jpg",
                Status = 0,
            },
            new ProductImage()
            {
                Id = new Guid("d5c65162-7591-48c1-9198-daca165bce8c"),
                ProductDetailId = new Guid("2eaaba04-80ff-43a6-a746-a74a91c4c3e1"),
                Name = "actxs-e_02_1_1.jpg",
                Status = 0,
            },
            new ProductImage()
            {
                Id = new Guid("d5c65162-7591-48c1-9198-daca165bce9c"),
                ProductDetailId = new Guid("2eaaba04-80ff-43a6-a746-a74a91c4c3e1"),
                Name = "actxs-q_02.jpg",
                Status = 0,
            },
            new ProductImage()
            {
                Id = new Guid("d5c65162-7591-48c1-9198-daca166bce0c"),
                ProductDetailId = new Guid("2eaaba04-80ff-43a6-a746-a74a91c4c3e2"),
                Name = "elbjgb_02.jpg",
                Status = 0,
            },
            new ProductImage()
            {
                Id = new Guid("d5c65162-7591-48c1-9198-daca166bce1c"),
                ProductDetailId = new Guid("2eaaba04-80ff-43a6-a746-a74a91c4c3e2"),
                Name = "elbjgb-h2_01.jpg",
                Status = 0,
            },
            new ProductImage()
            {
                Id = new Guid("d5c65162-7591-48c1-9198-daca166bce2c"),
                ProductDetailId = new Guid("2eaaba04-80ff-43a6-a746-a74a91c4c3e2"),
                Name = "elbjgb-h1_01.jpg",
                Status = 0,
            },
            new ProductImage()
            {
                Id = new Guid("d5c65162-7591-48c1-9198-daca166bce3c"),
                ProductDetailId = new Guid("2eaaba04-80ff-43a6-a746-a74a91c4c3e2"),
                Name = "actxs-e_02_1_1.jpg",
                Status = 0,
            },
            new ProductImage()
            {
                Id = new Guid("d5c65162-7591-48c1-9198-daca166bce4c"),
                ProductDetailId = new Guid("2eaaba04-80ff-43a6-a746-a74a91c4c3e2"),
                Name = "actxs-q_02.jpg",
                Status = 0,
            },
            new ProductImage()
            {
                Id = new Guid("d5c65162-7591-48c1-9198-daca166bce5c"),
                ProductDetailId = new Guid("2eaaba04-80ff-43a6-a746-a74a91c4c3e3"),
                Name = "elbjgb_02.jpg",
                Status = 0,
            },
            new ProductImage()
            {
                Id = new Guid("d5c65162-7591-48c1-9198-daca166bce6c"),
                ProductDetailId = new Guid("2eaaba04-80ff-43a6-a746-a74a91c4c3e3"),
                Name = "elbjgb-h2_01.jpg",
                Status = 0,
            },
            new ProductImage()
            {
                Id = new Guid("d5c65162-7591-48c1-9198-daca166bce7c"),
                ProductDetailId = new Guid("2eaaba04-80ff-43a6-a746-a74a91c4c3e3"),
                Name = "elbjgb-h1_01.jpg",
                Status = 0,
            },
            new ProductImage()
            {
                Id = new Guid("d5c65162-7591-48c1-9198-daca166bce8c"),
                ProductDetailId = new Guid("2eaaba04-80ff-43a6-a746-a74a91c4c3e3"),
                Name = "actxs-e_02_1_1.jpg",
                Status = 0,
            },
            new ProductImage()
            {
                Id = new Guid("d5c65162-7591-48c1-9198-daca166bce9c"),
                ProductDetailId = new Guid("2eaaba04-80ff-43a6-a746-a74a91c4c3e3"),
                Name = "actxs-q_02.jpg",
                Status = 0,
            },
            new ProductImage()
            {
                Id = new Guid("d5c65162-7591-48c1-9198-daca167bce0c"),
                ProductDetailId = new Guid("2eaaba04-80ff-43a6-a746-a74a91c4c3e4"),
                Name = "elbjgb_02.jpg",
                Status = 0,
            },
            new ProductImage()
            {
                Id = new Guid("d5c65162-7591-48c1-9198-daca167bce1c"),
                ProductDetailId = new Guid("2eaaba04-80ff-43a6-a746-a74a91c4c3e4"),
                Name = "elbjgb-h2_01.jpg",
                Status = 0,
            },
            new ProductImage()
            {
                Id = new Guid("d5c65162-7591-48c1-9198-daca167bce2c"),
                ProductDetailId = new Guid("2eaaba04-80ff-43a6-a746-a74a91c4c3e4"),
                Name = "elbjgb-h1_01.jpg",
                Status = 0,
            },
            new ProductImage()
            {
                Id = new Guid("d5c65162-7591-48c1-9198-daca167bce3c"),
                ProductDetailId = new Guid("2eaaba04-80ff-43a6-a746-a74a91c4c3e4"),
                Name = "actxs-e_02_1_1.jpg",
                Status = 0,
            },
            new ProductImage()
            {
                Id = new Guid("d5c65162-7591-48c1-9198-daca167bce4c"),
                ProductDetailId = new Guid("2eaaba04-80ff-43a6-a746-a74a91c4c3e4"),
                Name = "actxs-q_02.jpg",
                Status = 0,
            },
            new ProductImage()
            {
                Id = new Guid("d5c65162-7591-48c1-9198-daca167bce5c"),
                ProductDetailId = new Guid("2eaaba04-80ff-43a6-a746-a74a91c4c3e5"),
                Name = "elbjgb_02.jpg",
                Status = 0,
            },
            new ProductImage()
            {
                Id = new Guid("d5c65162-7591-48c1-9198-daca167bce6c"),
                ProductDetailId = new Guid("2eaaba04-80ff-43a6-a746-a74a91c4c3e5"),
                Name = "elbjgb-h2_01.jpg",
                Status = 0,
            },
            new ProductImage()
            {
                Id = new Guid("d5c65162-7591-48c1-9198-daca167bce7c"),
                ProductDetailId = new Guid("2eaaba04-80ff-43a6-a746-a74a91c4c3e5"),
                Name = "elbjgb-h1_01.jpg",
                Status = 0,
            },
            new ProductImage()
            {
                Id = new Guid("d5c65162-7591-48c1-9198-daca167bce8c"),
                ProductDetailId = new Guid("2eaaba04-80ff-43a6-a746-a74a91c4c3e5"),
                Name = "actxs-e_02_1_1.jpg",
                Status = 0,
            },
            new ProductImage()
            {
                Id = new Guid("d5c65162-7591-48c1-9198-daca167bce9c"),
                ProductDetailId = new Guid("2eaaba04-80ff-43a6-a746-a74a91c4c3e5"),
                Name = "actxs-q_02.jpg",
                Status = 0,
            },
            new ProductImage()
            {
                Id = new Guid("d5c65162-7591-48c1-9198-daca168bce0c"),
                ProductDetailId = new Guid("2eaaba04-80ff-43a6-a746-a74a91c4c3e6"),
                Name = "elbjgb_02.jpg",
                Status = 0,
            },
            new ProductImage()
            {
                Id = new Guid("d5c65162-7591-48c1-9198-daca168bce1c"),
                ProductDetailId = new Guid("2eaaba04-80ff-43a6-a746-a74a91c4c3e6"),
                Name = "elbjgb-h2_01.jpg",
                Status = 0,
            },
            new ProductImage()
            {
                Id = new Guid("d5c65162-7591-48c1-9198-daca168bce2c"),
                ProductDetailId = new Guid("2eaaba04-80ff-43a6-a746-a74a91c4c3e6"),
                Name = "elbjgb-h1_01.jpg",
                Status = 0,
            },
            new ProductImage()
            {
                Id = new Guid("d5c65162-7591-48c1-9198-daca168bce3c"),
                ProductDetailId = new Guid("2eaaba04-80ff-43a6-a746-a74a91c4c3e6"),
                Name = "actxs-e_02_1_1.jpg",
                Status = 0,
            },
            new ProductImage()
            {
                Id = new Guid("d5c65162-7591-48c1-9198-daca168bce4c"),
                ProductDetailId = new Guid("2eaaba04-80ff-43a6-a746-a74a91c4c3e6"),
                Name = "actxs-q_02.jpg",
                Status = 0,
            },
            new ProductImage()
            {
                Id = new Guid("d5c65162-7591-48c1-9198-daca168bce5c"),
                ProductDetailId = new Guid("2eaaba04-80ff-43a6-a746-a74a91c4c3e7"),
                Name = "elbjgb_02.jpg",
                Status = 0,
            },
            new ProductImage()
            {
                Id = new Guid("d5c65162-7591-48c1-9198-daca168bce6c"),
                ProductDetailId = new Guid("2eaaba04-80ff-43a6-a746-a74a91c4c3e7"),
                Name = "elbjgb-h2_01.jpg",
                Status = 0,
            },
            new ProductImage()
            {
                Id = new Guid("d5c65162-7591-48c1-9198-daca168bce7c"),
                ProductDetailId = new Guid("2eaaba04-80ff-43a6-a746-a74a91c4c3e7"),
                Name = "elbjgb-h1_01.jpg",
                Status = 0,
            },
            new ProductImage()
            {
                Id = new Guid("d5c65162-7591-48c1-9198-daca168bce8c"),
                ProductDetailId = new Guid("2eaaba04-80ff-43a6-a746-a74a91c4c3e7"),
                Name = "actxs-e_02_1_1.jpg",
                Status = 0,
            },
            new ProductImage()
            {
                Id = new Guid("d5c65162-7591-48c1-9198-daca168bce9c"),
                ProductDetailId = new Guid("2eaaba04-80ff-43a6-a746-a74a91c4c3e7"),
                Name = "actxs-q_02.jpg",
                Status = 0,
            },
            new ProductImage()
            {
                Id = new Guid("d5c65162-7591-48c1-9198-daca169bce0c"),
                ProductDetailId = new Guid("2eaaba04-80ff-43a6-a746-a74a91c4c3e8"),
                Name = "elbjgb_02.jpg",
                Status = 0,
            },
            new ProductImage()
            {
                Id = new Guid("d5c65162-7591-48c1-9198-daca169bce1c"),
                ProductDetailId = new Guid("2eaaba04-80ff-43a6-a746-a74a91c4c3e8"),
                Name = "elbjgb-h2_01.jpg",
                Status = 0,
            },
            new ProductImage()
            {
                Id = new Guid("d5c65162-7591-48c1-9198-daca169bce2c"),
                ProductDetailId = new Guid("2eaaba04-80ff-43a6-a746-a74a91c4c3e8"),
                Name = "elbjgb-h1_01.jpg",
                Status = 0,
            },
            new ProductImage()
            {
                Id = new Guid("d5c65162-7591-48c1-9198-daca169bce3c"),
                ProductDetailId = new Guid("2eaaba04-80ff-43a6-a746-a74a91c4c3e8"),
                Name = "actxs-e_02_1_1.jpg",
                Status = 0,
            },
            new ProductImage()
            {
                Id = new Guid("d5c65162-7591-48c1-9198-daca169bce4c"),
                ProductDetailId = new Guid("2eaaba04-80ff-43a6-a746-a74a91c4c3e8"),
                Name = "actxs-q_02.jpg",
                Status = 0,
            },
            new ProductImage()
            {
                Id = new Guid("d5c65162-7591-48c1-9198-daca169bce5c"),
                ProductDetailId = new Guid("2eaaba04-80ff-43a6-a746-a74a91c4c3e9"),
                Name = "elbjgb_02.jpg",
                Status = 0,
            },
            new ProductImage()
            {
                Id = new Guid("d5c65162-7591-48c1-9198-daca169bce6c"),
                ProductDetailId = new Guid("2eaaba04-80ff-43a6-a746-a74a91c4c3e9"),
                Name = "elbjgb-h2_01.jpg",
                Status = 0,
            },
            new ProductImage()
            {
                Id = new Guid("d5c65162-7591-48c1-9198-daca169bce7c"),
                ProductDetailId = new Guid("2eaaba04-80ff-43a6-a746-a74a91c4c3e9"),
                Name = "elbjgb-h1_01.jpg",
                Status = 0,
            },
            new ProductImage()
            {
                Id = new Guid("d5c65162-7591-48c1-9198-daca169bce8c"),
                ProductDetailId = new Guid("2eaaba04-80ff-43a6-a746-a74a91c4c3e9"),
                Name = "actxs-e_02_1_1.jpg",
                Status = 0,
            },
            new ProductImage()
            {
                Id = new Guid("d5c65162-7591-48c1-9198-daca169bce9c"),
                ProductDetailId = new Guid("2eaaba04-80ff-43a6-a746-a74a91c4c3e9"),
                Name = "actxs-q_02.jpg",
                Status = 0,
            },
            new ProductImage()
            {
                Id = new Guid("d5c65162-7591-48c1-9198-daca170bce0c"),
                ProductDetailId = new Guid("2eaaba04-80ff-43a6-a746-a74a91c5c0e0"),
                Name = "elbjgb_02.jpg",
                Status = 0,
            },
            new ProductImage()
            {
                Id = new Guid("d5c65162-7591-48c1-9198-daca170bce1c"),
                ProductDetailId = new Guid("2eaaba04-80ff-43a6-a746-a74a91c5c0e0"),
                Name = "elbjgb-h2_01.jpg",
                Status = 0,
            },
            new ProductImage()
            {
                Id = new Guid("d5c65162-7591-48c1-9198-daca170bce2c"),
                ProductDetailId = new Guid("2eaaba04-80ff-43a6-a746-a74a91c5c0e0"),
                Name = "elbjgb-h1_01.jpg",
                Status = 0,
            },
            new ProductImage()
            {
                Id = new Guid("d5c65162-7591-48c1-9198-daca170bce3c"),
                ProductDetailId = new Guid("2eaaba04-80ff-43a6-a746-a74a91c5c0e0"),
                Name = "actxs-e_02_1_1.jpg",
                Status = 0,
            },
            new ProductImage()
            {
                Id = new Guid("d5c65162-7591-48c1-9198-daca170bce4c"),
                ProductDetailId = new Guid("2eaaba04-80ff-43a6-a746-a74a91c5c0e0"),
                Name = "actxs-q_02.jpg",
                Status = 0,
            },
            new ProductImage()
            {
                Id = new Guid("d5c65162-7591-48c1-9198-daca170bce5c"),
                ProductDetailId = new Guid("2eaaba04-80ff-43a6-a746-a74a91c5c0e1"),
                Name = "elbjgb_02.jpg",
                Status = 0,
            },
            new ProductImage()
            {
                Id = new Guid("d5c65162-7591-48c1-9198-daca170bce6c"),
                ProductDetailId = new Guid("2eaaba04-80ff-43a6-a746-a74a91c5c0e1"),
                Name = "elbjgb-h2_01.jpg",
                Status = 0,
            },
            new ProductImage()
            {
                Id = new Guid("d5c65162-7591-48c1-9198-daca170bce7c"),
                ProductDetailId = new Guid("2eaaba04-80ff-43a6-a746-a74a91c5c0e1"),
                Name = "elbjgb-h1_01.jpg",
                Status = 0,
            },
            new ProductImage()
            {
                Id = new Guid("d5c65162-7591-48c1-9198-daca170bce8c"),
                ProductDetailId = new Guid("2eaaba04-80ff-43a6-a746-a74a91c5c0e1"),
                Name = "actxs-e_02_1_1.jpg",
                Status = 0,
            },
            new ProductImage()
            {
                Id = new Guid("d5c65162-7591-48c1-9198-daca170bce9c"),
                ProductDetailId = new Guid("2eaaba04-80ff-43a6-a746-a74a91c5c0e1"),
                Name = "actxs-q_02.jpg",
                Status = 0,
            },
            new ProductImage()
            {
                Id = new Guid("d5c65162-7591-48c1-9198-daca171bce0c"),
                ProductDetailId = new Guid("2eaaba04-80ff-43a6-a746-a74a91c5c0e2"),
                Name = "elbjgb_02.jpg",
                Status = 0,
            },
            new ProductImage()
            {
                Id = new Guid("d5c65162-7591-48c1-9198-daca171bce1c"),
                ProductDetailId = new Guid("2eaaba04-80ff-43a6-a746-a74a91c5c0e2"),
                Name = "elbjgb-h2_01.jpg",
                Status = 0,
            },
            new ProductImage()
            {
                Id = new Guid("d5c65162-7591-48c1-9198-daca171bce2c"),
                ProductDetailId = new Guid("2eaaba04-80ff-43a6-a746-a74a91c5c0e2"),
                Name = "elbjgb-h1_01.jpg",
                Status = 0,
            },
            new ProductImage()
            {
                Id = new Guid("d5c65162-7591-48c1-9198-daca171bce3c"),
                ProductDetailId = new Guid("2eaaba04-80ff-43a6-a746-a74a91c5c0e2"),
                Name = "actxs-e_02_1_1.jpg",
                Status = 0,
            },
            new ProductImage()
            {
                Id = new Guid("d5c65162-7591-48c1-9198-daca171bce4c"),
                ProductDetailId = new Guid("2eaaba04-80ff-43a6-a746-a74a91c5c0e2"),
                Name = "actxs-q_02.jpg",
                Status = 0,
            },
            new ProductImage()
            {
                Id = new Guid("d5c65162-7591-48c1-9198-daca171bce5c"),
                ProductDetailId = new Guid("2eaaba04-80ff-43a6-a746-a74a91c5c0e3"),
                Name = "elbjgb_02.jpg",
                Status = 0,
            },
            new ProductImage()
            {
                Id = new Guid("d5c65162-7591-48c1-9198-daca171bce6c"),
                ProductDetailId = new Guid("2eaaba04-80ff-43a6-a746-a74a91c5c0e3"),
                Name = "elbjgb-h2_01.jpg",
                Status = 0,
            },
            new ProductImage()
            {
                Id = new Guid("d5c65162-7591-48c1-9198-daca171bce7c"),
                ProductDetailId = new Guid("2eaaba04-80ff-43a6-a746-a74a91c5c0e3"),
                Name = "elbjgb-h1_01.jpg",
                Status = 0,
            },
            new ProductImage()
            {
                Id = new Guid("d5c65162-7591-48c1-9198-daca171bce8c"),
                ProductDetailId = new Guid("2eaaba04-80ff-43a6-a746-a74a91c5c0e3"),
                Name = "actxs-e_02_1_1.jpg",
                Status = 0,
            },
            new ProductImage()
            {
                Id = new Guid("d5c65162-7591-48c1-9198-daca171bce9c"),
                ProductDetailId = new Guid("2eaaba04-80ff-43a6-a746-a74a91c5c0e3"),
                Name = "actxs-q_02.jpg",
                Status = 0,
            },
            new ProductImage()
            {
                Id = new Guid("d5c65162-7591-48c1-9198-daca172bce0c"),
                ProductDetailId = new Guid("2eaaba04-80ff-43a6-a746-a74a91c5c0e4"),
                Name = "elbjgb_02.jpg",
                Status = 0,
            },
            new ProductImage()
            {
                Id = new Guid("d5c65162-7591-48c1-9198-daca172bce1c"),
                ProductDetailId = new Guid("2eaaba04-80ff-43a6-a746-a74a91c5c0e4"),
                Name = "elbjgb-h2_01.jpg",
                Status = 0,
            },
            new ProductImage()
            {
                Id = new Guid("d5c65162-7591-48c1-9198-daca172bce2c"),
                ProductDetailId = new Guid("2eaaba04-80ff-43a6-a746-a74a91c5c0e4"),
                Name = "elbjgb-h1_01.jpg",
                Status = 0,
            },
            new ProductImage()
            {
                Id = new Guid("d5c65162-7591-48c1-9198-daca172bce3c"),
                ProductDetailId = new Guid("2eaaba04-80ff-43a6-a746-a74a91c5c0e4"),
                Name = "actxs-e_02_1_1.jpg",
                Status = 0,
            },
            new ProductImage()
            {
                Id = new Guid("d5c65162-7591-48c1-9198-daca172bce4c"),
                ProductDetailId = new Guid("2eaaba04-80ff-43a6-a746-a74a91c5c0e4"),
                Name = "actxs-q_02.jpg",
                Status = 0,
            },
            new ProductImage()
            {
                Id = new Guid("d5c65162-7591-48c1-9198-daca172bce5c"),
                ProductDetailId = new Guid("2eaaba04-80ff-43a6-a746-a74a91c5c0e5"),
                Name = "elbjgb_02.jpg",
                Status = 0,
            },
            new ProductImage()
            {
                Id = new Guid("d5c65162-7591-48c1-9198-daca172bce6c"),
                ProductDetailId = new Guid("2eaaba04-80ff-43a6-a746-a74a91c5c0e5"),
                Name = "elbjgb-h2_01.jpg",
                Status = 0,
            },
            new ProductImage()
            {
                Id = new Guid("d5c65162-7591-48c1-9198-daca172bce7c"),
                ProductDetailId = new Guid("2eaaba04-80ff-43a6-a746-a74a91c5c0e5"),
                Name = "elbjgb-h1_01.jpg",
                Status = 0,
            },
            new ProductImage()
            {
                Id = new Guid("d5c65162-7591-48c1-9198-daca172bce8c"),
                ProductDetailId = new Guid("2eaaba04-80ff-43a6-a746-a74a91c5c0e5"),
                Name = "actxs-e_02_1_1.jpg",
                Status = 0,
            },
            new ProductImage()
            {
                Id = new Guid("d5c65162-7591-48c1-9198-daca172bce9c"),
                ProductDetailId = new Guid("2eaaba04-80ff-43a6-a746-a74a91c5c0e5"),
                Name = "actxs-q_02.jpg",
                Status = 0,
            },
            new ProductImage()
            {
                Id = new Guid("d5c65162-7591-48c1-9198-daca173bce0c"),
                ProductDetailId = new Guid("2eaaba04-80ff-43a6-a746-a74a91c5c0e6"),
                Name = "elbjgb_02.jpg",
                Status = 0,
            },
            new ProductImage()
            {
                Id = new Guid("d5c65162-7591-48c1-9198-daca173bce1c"),
                ProductDetailId = new Guid("2eaaba04-80ff-43a6-a746-a74a91c5c0e6"),
                Name = "elbjgb-h2_01.jpg",
                Status = 0,
            },
            new ProductImage()
            {
                Id = new Guid("d5c65162-7591-48c1-9198-daca173bce2c"),
                ProductDetailId = new Guid("2eaaba04-80ff-43a6-a746-a74a91c5c0e6"),
                Name = "elbjgb-h1_01.jpg",
                Status = 0,
            },
            new ProductImage()
            {
                Id = new Guid("d5c65162-7591-48c1-9198-daca173bce3c"),
                ProductDetailId = new Guid("2eaaba04-80ff-43a6-a746-a74a91c5c0e6"),
                Name = "actxs-e_02_1_1.jpg",
                Status = 0,
            },
            new ProductImage()
            {
                Id = new Guid("d5c65162-7591-48c1-9198-daca173bce4c"),
                ProductDetailId = new Guid("2eaaba04-80ff-43a6-a746-a74a91c5c0e6"),
                Name = "actxs-q_02.jpg",
                Status = 0,
            },
            new ProductImage()
            {
                Id = new Guid("d5c65162-7591-48c1-9198-daca173bce5c"),
                ProductDetailId = new Guid("2eaaba04-80ff-43a6-a746-a74a91c5c0e7"),
                Name = "elbjgb_02.jpg",
                Status = 0,
            },
            new ProductImage()
            {
                Id = new Guid("d5c65162-7591-48c1-9198-daca173bce6c"),
                ProductDetailId = new Guid("2eaaba04-80ff-43a6-a746-a74a91c5c0e7"),
                Name = "elbjgb-h2_01.jpg",
                Status = 0,
            },
            new ProductImage()
            {
                Id = new Guid("d5c65162-7591-48c1-9198-daca173bce7c"),
                ProductDetailId = new Guid("2eaaba04-80ff-43a6-a746-a74a91c5c0e7"),
                Name = "elbjgb-h1_01.jpg",
                Status = 0,
            },
            new ProductImage()
            {
                Id = new Guid("d5c65162-7591-48c1-9198-daca999bce8c"),
                ProductDetailId = new Guid("2eaaba04-80ff-43a6-a746-a74a91c5c0e7"),
                Name = "actxs-e_02_1_1.jpg",
                Status = 0,
            },
            new ProductImage()
            {
                Id = new Guid("d5c65162-7591-48c1-9198-daca173bce8c"),
                ProductDetailId = new Guid("2eaaba04-80ff-43a6-a746-a74a91c5c0e7"),
                Name = "actxs-q_02.jpg",
                Status = 0,
            },
            new ProductImage()
            {
                Id = new Guid("d5c65162-7591-48c1-9198-daca173bce9c"),
                ProductDetailId = new Guid("2eaaba04-80ff-43a6-a746-a74a91c5c0e8"),
                Name = "elbjgb_02.jpg",
                Status = 0,
            },
            new ProductImage()
            {
                Id = new Guid("d5c65162-7591-48c1-9198-daca174bce0c"),
                ProductDetailId = new Guid("2eaaba04-80ff-43a6-a746-a74a91c5c0e8"),
                Name = "elbjgb-h2_01.jpg",
                Status = 0,
            },
            new ProductImage()
            {
                Id = new Guid("d5c65162-7591-48c1-9198-daca174bce1c"),
                ProductDetailId = new Guid("2eaaba04-80ff-43a6-a746-a74a91c5c0e8"),
                Name = "elbjgb-h1_01.jpg",
                Status = 0,
            },
            new ProductImage()
            {
                Id = new Guid("d5c65162-7591-48c1-9198-daca174bce2c"),
                ProductDetailId = new Guid("2eaaba04-80ff-43a6-a746-a74a91c5c0e8"),
                Name = "actxs-e_02_1_1.jpg",
                Status = 0,
            },
            new ProductImage()
            {
                Id = new Guid("d5c65162-7591-48c1-9198-daca174bce3c"),
                ProductDetailId = new Guid("2eaaba04-80ff-43a6-a746-a74a91c5c0e8"),
                Name = "actxs-q_02.jpg",
                Status = 0,
            },
            new ProductImage()
            {
                Id = new Guid("d5c65162-7591-48c1-9198-daca174bce4c"),
                ProductDetailId = new Guid("2eaaba04-80ff-43a6-a746-a74a91c5c0e9"),
                Name = "elbjgb_02.jpg",
                Status = 0,
            },
            new ProductImage()
            {
                Id = new Guid("d5c65162-7591-48c1-9198-daca174bce5c"),
                ProductDetailId = new Guid("2eaaba04-80ff-43a6-a746-a74a91c5c0e9"),
                Name = "elbjgb-h2_01.jpg",
                Status = 0,
            },
            new ProductImage()
            {
                Id = new Guid("d5c65162-7591-48c1-9198-daca174bce6c"),
                ProductDetailId = new Guid("2eaaba04-80ff-43a6-a746-a74a91c5c0e9"),
                Name = "elbjgb-h1_01.jpg",
                Status = 0,
            },
            new ProductImage()
            {
                Id = new Guid("d5c65162-7591-48c1-9198-daca174bce7c"),
                ProductDetailId = new Guid("2eaaba04-80ff-43a6-a746-a74a91c5c0e9"),
                Name = "actxs-e_02_1_1.jpg",
                Status = 0,
            },
            new ProductImage()
            {
                Id = new Guid("d5c65162-7591-48c1-9198-daca174bce8c"),
                ProductDetailId = new Guid("2eaaba04-80ff-43a6-a746-a74a91c5c0e9"),
                Name = "actxs-q_02.jpg",
                Status = 0,
            },
            new ProductImage()
            {
                Id = new Guid("d5c65162-7591-48c1-9198-daca174bce9c"),
                ProductDetailId = new Guid("2eaaba04-80ff-43a6-a746-a74a91c5c1e0"),
                Name = "elbjgb_02.jpg",
                Status = 0,
            },
            new ProductImage()
            {
                Id = new Guid("d5c65162-7591-48c1-9198-daca175bce0c"),
                ProductDetailId = new Guid("2eaaba04-80ff-43a6-a746-a74a91c5c1e0"),
                Name = "elbjgb-h2_01.jpg",
                Status = 0,
            },
            new ProductImage()
            {
                Id = new Guid("d5c65162-7591-48c1-9198-daca175bce1c"),
                ProductDetailId = new Guid("2eaaba04-80ff-43a6-a746-a74a91c5c1e0"),
                Name = "elbjgb-h1_01.jpg",
                Status = 0,
            },
            new ProductImage()
            {
                Id = new Guid("d5c65162-7591-48c1-9198-daca175bce2c"),
                ProductDetailId = new Guid("2eaaba04-80ff-43a6-a746-a74a91c5c1e0"),
                Name = "actxs-e_02_1_1.jpg",
                Status = 0,
            },
            new ProductImage()
            {
                Id = new Guid("d5c65162-7591-48c1-9198-daca175bce3c"),
                ProductDetailId = new Guid("2eaaba04-80ff-43a6-a746-a74a91c5c1e0"),
                Name = "actxs-q_02.jpg",
                Status = 0,
            },
            new ProductImage()
            {
                Id = new Guid("d5c65162-7591-48c1-9198-daca175bce4c"),
                ProductDetailId = new Guid("2eaaba04-80ff-43a6-a746-a74a91c5c1e1"),
                Name = "elbjgb_02.jpg",
                Status = 0,
            },
            new ProductImage()
            {
                Id = new Guid("d5c65162-7591-48c1-9198-daca175bce5c"),
                ProductDetailId = new Guid("2eaaba04-80ff-43a6-a746-a74a91c5c1e1"),
                Name = "elbjgb-h2_01.jpg",
                Status = 0,
            },
            new ProductImage()
            {
                Id = new Guid("d5c65162-7591-48c1-9198-daca175bce6c"),
                ProductDetailId = new Guid("2eaaba04-80ff-43a6-a746-a74a91c5c1e1"),
                Name = "elbjgb-h1_01.jpg",
                Status = 0,
            },
            new ProductImage()
            {
                Id = new Guid("d5c65162-7591-48c1-9198-daca175bce7c"),
                ProductDetailId = new Guid("2eaaba04-80ff-43a6-a746-a74a91c5c1e1"),
                Name = "actxs-e_02_1_1.jpg",
                Status = 0,
            },
            new ProductImage()
            {
                Id = new Guid("d5c65162-7591-48c1-9198-daca175bce8c"),
                ProductDetailId = new Guid("2eaaba04-80ff-43a6-a746-a74a91c5c1e1"),
                Name = "actxs-q_02.jpg",
                Status = 0,
            },
            new ProductImage()
            {
                Id = new Guid("d5c65162-7591-48c1-9198-daca175bce9c"),
                ProductDetailId = new Guid("2eaaba04-80ff-43a6-a746-a74a91c5c1e2"),
                Name = "elbjgb_02.jpg",
                Status = 0,
            },
            new ProductImage()
            {
                Id = new Guid("d5c65162-7591-48c1-9198-daca176bce0c"),
                ProductDetailId = new Guid("2eaaba04-80ff-43a6-a746-a74a91c5c1e2"),
                Name = "elbjgb-h2_01.jpg",
                Status = 0,
            },
            new ProductImage()
            {
                Id = new Guid("d5c65162-7591-48c1-9198-daca176bce1c"),
                ProductDetailId = new Guid("2eaaba04-80ff-43a6-a746-a74a91c5c1e2"),
                Name = "elbjgb-h1_01.jpg",
                Status = 0,
            },
            new ProductImage()
            {
                Id = new Guid("d5c65162-7591-48c1-9198-daca176bce2c"),
                ProductDetailId = new Guid("2eaaba04-80ff-43a6-a746-a74a91c5c1e2"),
                Name = "actxs-e_02_1_1.jpg",
                Status = 0,
            },
            new ProductImage()
            {
                Id = new Guid("d5c65162-7591-48c1-9198-daca176bce3c"),
                ProductDetailId = new Guid("2eaaba04-80ff-43a6-a746-a74a91c5c1e2"),
                Name = "actxs-q_02.jpg",
                Status = 0,
            },
            new ProductImage()
            {
                Id = new Guid("d5c65162-7591-48c1-9198-daca176bce4c"),
                ProductDetailId = new Guid("2eaaba04-80ff-43a6-a746-a74a91c5c1e3"),
                Name = "elbjgb_02.jpg",
                Status = 0,
            },
            new ProductImage()
            {
                Id = new Guid("d5c65162-7591-48c1-9198-daca176bce5c"),
                ProductDetailId = new Guid("2eaaba04-80ff-43a6-a746-a74a91c5c1e3"),
                Name = "elbjgb-h2_01.jpg",
                Status = 0,
            },
            new ProductImage()
            {
                Id = new Guid("d5c65162-7591-48c1-9198-daca176bce6c"),
                ProductDetailId = new Guid("2eaaba04-80ff-43a6-a746-a74a91c5c1e3"),
                Name = "elbjgb-h1_01.jpg",
                Status = 0,
            },
            new ProductImage()
            {
                Id = new Guid("d5c65162-7591-48c1-9198-daca176bce7c"),
                ProductDetailId = new Guid("2eaaba04-80ff-43a6-a746-a74a91c5c1e3"),
                Name = "actxs-e_02_1_1.jpg",
                Status = 0,
            },
            new ProductImage()
            {
                Id = new Guid("d5c65162-7591-48c1-9198-daca176bce8c"),
                ProductDetailId = new Guid("2eaaba04-80ff-43a6-a746-a74a91c5c1e3"),
                Name = "actxs-q_02.jpg",
                Status = 0,
            },
            new ProductImage()
            {
                Id = new Guid("d5c65162-7591-48c1-9198-daca176bce9c"),
                ProductDetailId = new Guid("2eaaba04-80ff-43a6-a746-a74a91c5c1e4"),
                Name = "elbjgb_02.jpg",
                Status = 0,
            },
            new ProductImage()
            {
                Id = new Guid("d5c65162-7591-48c1-9198-daca177bce0c"),
                ProductDetailId = new Guid("2eaaba04-80ff-43a6-a746-a74a91c5c1e4"),
                Name = "elbjgb-h2_01.jpg",
                Status = 0,
            },
            new ProductImage()
            {
                Id = new Guid("d5c65162-7591-48c1-9198-daca177bce1c"),
                ProductDetailId = new Guid("2eaaba04-80ff-43a6-a746-a74a91c5c1e4"),
                Name = "elbjgb-h1_01.jpg",
                Status = 0,
            },
            new ProductImage()
            {
                Id = new Guid("d5c65162-7591-48c1-9198-daca177bce2c"),
                ProductDetailId = new Guid("2eaaba04-80ff-43a6-a746-a74a91c5c1e4"),
                Name = "actxs-e_02_1_1.jpg",
                Status = 0,
            },
            new ProductImage()
            {
                Id = new Guid("d5c65162-7591-48c1-9198-daca177bce3c"),
                ProductDetailId = new Guid("2eaaba04-80ff-43a6-a746-a74a91c5c1e4"),
                Name = "actxs-q_02.jpg",
                Status = 0,
            },
            new ProductImage()
            {
                Id = new Guid("d5c65162-7591-48c1-9198-daca177bce4c"),
                ProductDetailId = new Guid("2eaaba04-80ff-43a6-a746-a74a91c5c1e5"),
                Name = "elbjgb_02.jpg",
                Status = 0,
            },
            new ProductImage()
            {
                Id = new Guid("d5c65162-7591-48c1-9198-daca177bce5c"),
                ProductDetailId = new Guid("2eaaba04-80ff-43a6-a746-a74a91c5c1e5"),
                Name = "elbjgb-h2_01.jpg",
                Status = 0,
            },
            new ProductImage()
            {
                Id = new Guid("d5c65162-7591-48c1-9198-daca177bce6c"),
                ProductDetailId = new Guid("2eaaba04-80ff-43a6-a746-a74a91c5c1e5"),
                Name = "elbjgb-h1_01.jpg",
                Status = 0,
            },
            new ProductImage()
            {
                Id = new Guid("d5c65162-7591-48c1-9198-daca177bce7c"),
                ProductDetailId = new Guid("2eaaba04-80ff-43a6-a746-a74a91c5c1e5"),
                Name = "actxs-e_02_1_1.jpg",
                Status = 0,
            },
            new ProductImage()
            {
                Id = new Guid("d5c65162-7591-48c1-9198-daca177bce8c"),
                ProductDetailId = new Guid("2eaaba04-80ff-43a6-a746-a74a91c5c1e5"),
                Name = "actxs-q_02.jpg",
                Status = 0,
            },
            new ProductImage()
            {
                Id = new Guid("d5c65162-7591-48c1-9198-daca177bce9c"),
                ProductDetailId = new Guid("2eaaba04-80ff-43a6-a746-a74a91c5c1e6"),
                Name = "elbjgb_02.jpg",
                Status = 0,
            },
            new ProductImage()
            {
                Id = new Guid("d5c65162-7591-48c1-9198-daca178bce0c"),
                ProductDetailId = new Guid("2eaaba04-80ff-43a6-a746-a74a91c5c1e6"),
                Name = "elbjgb-h2_01.jpg",
                Status = 0,
            },
            new ProductImage()
            {
                Id = new Guid("d5c65162-7591-48c1-9198-daca178bce1c"),
                ProductDetailId = new Guid("2eaaba04-80ff-43a6-a746-a74a91c5c1e6"),
                Name = "elbjgb-h1_01.jpg",
                Status = 0,
            },
            new ProductImage()
            {
                Id = new Guid("d5c65162-7591-48c1-9198-daca178bce2c"),
                ProductDetailId = new Guid("2eaaba04-80ff-43a6-a746-a74a91c5c1e6"),
                Name = "actxs-e_02_1_1.jpg",
                Status = 0,
            },
            new ProductImage()
            {
                Id = new Guid("d5c65162-7591-48c1-9198-daca178bce3c"),
                ProductDetailId = new Guid("2eaaba04-80ff-43a6-a746-a74a91c5c1e6"),
                Name = "actxs-q_02.jpg",
                Status = 0,
            },
            new ProductImage()
            {
                Id = new Guid("d5c65162-7591-48c1-9198-daca178bce4c"),
                ProductDetailId = new Guid("2eaaba04-80ff-43a6-a746-a74a91c5c1e7"),
                Name = "elbjgb_02.jpg",
                Status = 0,
            },
            new ProductImage()
            {
                Id = new Guid("d5c65162-7591-48c1-9198-daca178bce5c"),
                ProductDetailId = new Guid("2eaaba04-80ff-43a6-a746-a74a91c5c1e7"),
                Name = "elbjgb-h2_01.jpg",
                Status = 0,
            },
            new ProductImage()
            {
                Id = new Guid("d5c65162-7591-48c1-9198-daca178bce6c"),
                ProductDetailId = new Guid("2eaaba04-80ff-43a6-a746-a74a91c5c1e7"),
                Name = "elbjgb-h1_01.jpg",
                Status = 0,
            },
            new ProductImage()
            {
                Id = new Guid("d5c65162-7591-48c1-9198-daca178bce7c"),
                ProductDetailId = new Guid("2eaaba04-80ff-43a6-a746-a74a91c5c1e7"),
                Name = "actxs-e_02_1_1.jpg",
                Status = 0,
            },
            new ProductImage()
            {
                Id = new Guid("d5c65162-7591-48c1-9198-daca178bce8c"),
                ProductDetailId = new Guid("2eaaba04-80ff-43a6-a746-a74a91c5c1e7"),
                Name = "actxs-q_02.jpg",
                Status = 0,
            },
            new ProductImage()
            {
                Id = new Guid("d5c65162-7591-48c1-9198-daca178bce9c"),
                ProductDetailId = new Guid("2eaaba04-80ff-43a6-a746-a74a91c5c1e8"),
                Name = "elbjgb_02.jpg",
                Status = 0,
            },
            new ProductImage()
            {
                Id = new Guid("d5c65162-7591-48c1-9198-daca179bce0c"),
                ProductDetailId = new Guid("2eaaba04-80ff-43a6-a746-a74a91c5c1e8"),
                Name = "elbjgb-h2_01.jpg",
                Status = 0,
            },
            new ProductImage()
            {
                Id = new Guid("d5c65162-7591-48c1-9198-daca179bce1c"),
                ProductDetailId = new Guid("2eaaba04-80ff-43a6-a746-a74a91c5c1e8"),
                Name = "elbjgb-h1_01.jpg",
                Status = 0,
            },
            new ProductImage()
            {
                Id = new Guid("d5c65162-7591-48c1-9198-daca179bce2c"),
                ProductDetailId = new Guid("2eaaba04-80ff-43a6-a746-a74a91c5c1e8"),
                Name = "actxs-e_02_1_1.jpg",
                Status = 0,
            },
            new ProductImage()
            {
                Id = new Guid("d5c65162-7591-48c1-9198-daca179bce3c"),
                ProductDetailId = new Guid("2eaaba04-80ff-43a6-a746-a74a91c5c1e8"),
                Name = "actxs-q_02.jpg",
                Status = 0,
            },
            new ProductImage()
            {
                Id = new Guid("d5c65162-7591-48c1-9198-daca179bce4c"),
                ProductDetailId = new Guid("2eaaba04-80ff-43a6-a746-a74a91c5c1e9"),
                Name = "elbjgb_02.jpg",
                Status = 0,
            },
            new ProductImage()
            {
                Id = new Guid("d5c65162-7591-48c1-9198-daca179bce5c"),
                ProductDetailId = new Guid("2eaaba04-80ff-43a6-a746-a74a91c5c1e9"),
                Name = "elbjgb-h2_01.jpg",
                Status = 0,
            },
            new ProductImage()
            {
                Id = new Guid("d5c65162-7591-48c1-9198-daca179bce6c"),
                ProductDetailId = new Guid("2eaaba04-80ff-43a6-a746-a74a91c5c1e9"),
                Name = "elbjgb-h1_01.jpg",
                Status = 0,
            },
            new ProductImage()
            {
                Id = new Guid("d5c65162-7591-48c1-9198-daca179bce7c"),
                ProductDetailId = new Guid("2eaaba04-80ff-43a6-a746-a74a91c5c1e9"),
                Name = "actxs-e_02_1_1.jpg",
                Status = 0,
            },
            new ProductImage()
            {
                Id = new Guid("d5c65162-7591-48c1-9198-daca179bce8c"),
                ProductDetailId = new Guid("2eaaba04-80ff-43a6-a746-a74a91c5c1e9"),
                Name = "actxs-q_02.jpg",
                Status = 0,
            },
            new ProductImage()
            {
                Id = new Guid("d5c65162-7591-48c1-9198-daca179bce9c"),
                ProductDetailId = new Guid("2eaaba04-80ff-43a6-a746-a74a91c5c2e0"),
                Name = "elbjgb_02.jpg",
                Status = 0,
            },
            new ProductImage()
            {
                Id = new Guid("d5c65162-7591-48c1-9198-daca180bce0c"),
                ProductDetailId = new Guid("2eaaba04-80ff-43a6-a746-a74a91c5c2e0"),
                Name = "elbjgb-h2_01.jpg",
                Status = 0,
            },
            new ProductImage()
            {
                Id = new Guid("d5c65162-7591-48c1-9198-daca180bce1c"),
                ProductDetailId = new Guid("2eaaba04-80ff-43a6-a746-a74a91c5c2e0"),
                Name = "elbjgb-h1_01.jpg",
                Status = 0,
            },
            new ProductImage()
            {
                Id = new Guid("d5c65162-7591-48c1-9198-daca180bce2c"),
                ProductDetailId = new Guid("2eaaba04-80ff-43a6-a746-a74a91c5c2e0"),
                Name = "actxs-e_02_1_1.jpg",
                Status = 0,
            },
            new ProductImage()
            {
                Id = new Guid("d5c65162-7591-48c1-9198-daca180bce3c"),
                ProductDetailId = new Guid("2eaaba04-80ff-43a6-a746-a74a91c5c2e0"),
                Name = "actxs-q_02.jpg",
                Status = 0,
            },
            new ProductImage()
            {
                Id = new Guid("d5c65162-7591-48c1-9198-daca180bce4c"),
                ProductDetailId = new Guid("2eaaba04-80ff-43a6-a746-a74a91c5c2e1"),
                Name = "elbjgb_02.jpg",
                Status = 0,
            },
            new ProductImage()
            {
                Id = new Guid("d5c65162-7591-48c1-9198-daca180bce5c"),
                ProductDetailId = new Guid("2eaaba04-80ff-43a6-a746-a74a91c5c2e1"),
                Name = "elbjgb-h2_01.jpg",
                Status = 0,
            },
            new ProductImage()
            {
                Id = new Guid("d5c65162-7591-48c1-9198-daca180bce6c"),
                ProductDetailId = new Guid("2eaaba04-80ff-43a6-a746-a74a91c5c2e1"),
                Name = "elbjgb-h1_01.jpg",
                Status = 0,
            },
            new ProductImage()
            {
                Id = new Guid("d5c65162-7591-48c1-9198-daca180bce7c"),
                ProductDetailId = new Guid("2eaaba04-80ff-43a6-a746-a74a91c5c2e1"),
                Name = "actxs-e_02_1_1.jpg",
                Status = 0,
            },
            new ProductImage()
            {
                Id = new Guid("d5c65162-7591-48c1-9198-daca180bce8c"),
                ProductDetailId = new Guid("2eaaba04-80ff-43a6-a746-a74a91c5c2e1"),
                Name = "actxs-q_02.jpg",
                Status = 0,
            },
            new ProductImage()
            {
                Id = new Guid("d5c65162-7591-48c1-9198-daca180bce9c"),
                ProductDetailId = new Guid("2eaaba04-80ff-43a6-a746-a74a91c5c2e2"),
                Name = "elbjgb_02.jpg",
                Status = 0,
            },
            new ProductImage()
            {
                Id = new Guid("d5c65162-7591-48c1-9198-daca181bce0c"),
                ProductDetailId = new Guid("2eaaba04-80ff-43a6-a746-a74a91c5c2e2"),
                Name = "elbjgb-h2_01.jpg",
                Status = 0,
            },
            new ProductImage()
            {
                Id = new Guid("d5c65162-7591-48c1-9198-daca181bce1c"),
                ProductDetailId = new Guid("2eaaba04-80ff-43a6-a746-a74a91c5c2e2"),
                Name = "elbjgb-h1_01.jpg",
                Status = 0,
            },
            new ProductImage()
            {
                Id = new Guid("d5c65162-7591-48c1-9198-daca181bce2c"),
                ProductDetailId = new Guid("2eaaba04-80ff-43a6-a746-a74a91c5c2e2"),
                Name = "actxs-e_02_1_1.jpg",
                Status = 0,
            },
            new ProductImage()
            {
                Id = new Guid("d5c65162-7591-48c1-9198-daca181bce3c"),
                ProductDetailId = new Guid("2eaaba04-80ff-43a6-a746-a74a91c5c2e2"),
                Name = "actxs-q_02.jpg",
                Status = 0,
            },
            new ProductImage()
            {
                Id = new Guid("d5c65162-7591-48c1-9198-daca181bce4c"),
                ProductDetailId = new Guid("2eaaba04-80ff-43a6-a746-a74a91c5c2e3"),
                Name = "elbjgb_02.jpg",
                Status = 0,
            },
            new ProductImage()
            {
                Id = new Guid("d5c65162-7591-48c1-9198-daca181bce5c"),
                ProductDetailId = new Guid("2eaaba04-80ff-43a6-a746-a74a91c5c2e3"),
                Name = "elbjgb-h2_01.jpg",
                Status = 0,
            },
            new ProductImage()
            {
                Id = new Guid("d5c65162-7591-48c1-9198-daca181bce6c"),
                ProductDetailId = new Guid("2eaaba04-80ff-43a6-a746-a74a91c5c2e3"),
                Name = "elbjgb-h1_01.jpg",
                Status = 0,
            },
            new ProductImage()
            {
                Id = new Guid("d5c65162-7591-48c1-9198-daca181bce7c"),
                ProductDetailId = new Guid("2eaaba04-80ff-43a6-a746-a74a91c5c2e3"),
                Name = "actxs-e_02_1_1.jpg",
                Status = 0,
            },
            new ProductImage()
            {
                Id = new Guid("d5c65162-7591-48c1-9198-daca181bce8c"),
                ProductDetailId = new Guid("2eaaba04-80ff-43a6-a746-a74a91c5c2e3"),
                Name = "actxs-q_02.jpg",
                Status = 0,
            },
            new ProductImage()
            {
                Id = new Guid("d5c65162-7591-48c1-9198-daca181bce9c"),
                ProductDetailId = new Guid("2eaaba04-80ff-43a6-a746-a74a91c5c2e4"),
                Name = "elbjgb_02.jpg",
                Status = 0,
            },
            new ProductImage()
            {
                Id = new Guid("d5c65162-7591-48c1-9198-daca182bce0c"),
                ProductDetailId = new Guid("2eaaba04-80ff-43a6-a746-a74a91c5c2e4"),
                Name = "elbjgb-h2_01.jpg",
                Status = 0,
            },
            new ProductImage()
            {
                Id = new Guid("d5c65162-7591-48c1-9198-daca182bce1c"),
                ProductDetailId = new Guid("2eaaba04-80ff-43a6-a746-a74a91c5c2e4"),
                Name = "elbjgb-h1_01.jpg",
                Status = 0,
            },
            new ProductImage()
            {
                Id = new Guid("d5c65162-7591-48c1-9198-daca182bce2c"),
                ProductDetailId = new Guid("2eaaba04-80ff-43a6-a746-a74a91c5c2e4"),
                Name = "actxs-e_02_1_1.jpg",
                Status = 0,
            },
            new ProductImage()
            {
                Id = new Guid("d5c65162-7591-48c1-9198-daca182bce3c"),
                ProductDetailId = new Guid("2eaaba04-80ff-43a6-a746-a74a91c5c2e4"),
                Name = "actxs-q_02.jpg",
                Status = 0,
            },
            new ProductImage()
            {
                Id = new Guid("d5c65162-7591-48c1-9198-daca182bce4c"),
                ProductDetailId = new Guid("2eaaba04-80ff-43a6-a746-a74a91c5c2e5"),
                Name = "elbjgb_02.jpg",
                Status = 0,
            },
            new ProductImage()
            {
                Id = new Guid("d5c65162-7591-48c1-9198-daca182bce5c"),
                ProductDetailId = new Guid("2eaaba04-80ff-43a6-a746-a74a91c5c2e5"),
                Name = "elbjgb-h2_01.jpg",
                Status = 0,
            },
            new ProductImage()
            {
                Id = new Guid("d5c65162-7591-48c1-9198-daca182bce6c"),
                ProductDetailId = new Guid("2eaaba04-80ff-43a6-a746-a74a91c5c2e5"),
                Name = "elbjgb-h1_01.jpg",
                Status = 0,
            },
            new ProductImage()
            {
                Id = new Guid("d5c65162-7591-48c1-9198-daca182bce7c"),
                ProductDetailId = new Guid("2eaaba04-80ff-43a6-a746-a74a91c5c2e5"),
                Name = "actxs-e_02_1_1.jpg",
                Status = 0,
            },
            new ProductImage()
            {
                Id = new Guid("d5c65162-7591-48c1-9198-daca182bce8c"),
                ProductDetailId = new Guid("2eaaba04-80ff-43a6-a746-a74a91c5c2e5"),
                Name = "actxs-q_02.jpg",
                Status = 0,
            },
            new ProductImage()
            {
                Id = new Guid("d5c65162-7591-48c1-9198-daca182bce9c"),
                ProductDetailId = new Guid("2eaaba04-80ff-43a6-a746-a74a91c5c2e6"),
                Name = "elbjgb_02.jpg",
                Status = 0,
            },
            new ProductImage()
            {
                Id = new Guid("d5c65162-7591-48c1-9198-daca183bce0c"),
                ProductDetailId = new Guid("2eaaba04-80ff-43a6-a746-a74a91c5c2e6"),
                Name = "elbjgb-h2_01.jpg",
                Status = 0,
            },
            new ProductImage()
            {
                Id = new Guid("d5c65162-7591-48c1-9198-daca183bce1c"),
                ProductDetailId = new Guid("2eaaba04-80ff-43a6-a746-a74a91c5c2e6"),
                Name = "elbjgb-h1_01.jpg",
                Status = 0,
            },
            new ProductImage()
            {
                Id = new Guid("d5c65162-7591-48c1-9198-daca183bce2c"),
                ProductDetailId = new Guid("2eaaba04-80ff-43a6-a746-a74a91c5c2e6"),
                Name = "actxs-e_02_1_1.jpg",
                Status = 0,
            },
            new ProductImage()
            {
                Id = new Guid("d5c65162-7591-48c1-9198-daca183bce3c"),
                ProductDetailId = new Guid("2eaaba04-80ff-43a6-a746-a74a91c5c2e6"),
                Name = "actxs-q_02.jpg",
                Status = 0,
            },
            new ProductImage()
            {
                Id = new Guid("d5c65162-7591-48c1-9198-daca183bce4c"),
                ProductDetailId = new Guid("2eaaba04-80ff-43a6-a746-a74a91c5c2e7"),
                Name = "elbjgb_02.jpg",
                Status = 0,
            },
            new ProductImage()
            {
                Id = new Guid("d5c65162-7591-48c1-9198-daca183bce5c"),
                ProductDetailId = new Guid("2eaaba04-80ff-43a6-a746-a74a91c5c2e7"),
                Name = "elbjgb-h2_01.jpg",
                Status = 0,
            },
            new ProductImage()
            {
                Id = new Guid("d5c65162-7591-48c1-9198-daca183bce6c"),
                ProductDetailId = new Guid("2eaaba04-80ff-43a6-a746-a74a91c5c2e7"),
                Name = "elbjgb-h1_01.jpg",
                Status = 0,
            },
            new ProductImage()
            {
                Id = new Guid("d5c65162-7591-48c1-9198-daca183bce7c"),
                ProductDetailId = new Guid("2eaaba04-80ff-43a6-a746-a74a91c5c2e7"),
                Name = "actxs-e_02_1_1.jpg",
                Status = 0,
            },
            new ProductImage()
            {
                Id = new Guid("d5c65162-7591-48c1-9198-daca183bce8c"),
                ProductDetailId = new Guid("2eaaba04-80ff-43a6-a746-a74a91c5c2e7"),
                Name = "actxs-q_02.jpg",
                Status = 0,
            },
            new ProductImage()
            {
                Id = new Guid("d5c65162-7591-48c1-9198-daca183bce9c"),
                ProductDetailId = new Guid("2eaaba04-80ff-43a6-a746-a74a91c5c2e8"),
                Name = "elbjgb_02.jpg",
                Status = 0,
            },
            new ProductImage()
            {
                Id = new Guid("d5c65162-7591-48c1-9198-daca184bce0c"),
                ProductDetailId = new Guid("2eaaba04-80ff-43a6-a746-a74a91c5c2e8"),
                Name = "elbjgb-h2_01.jpg",
                Status = 0,
            },
            new ProductImage()
            {
                Id = new Guid("d5c65162-7591-48c1-9198-daca184bce1c"),
                ProductDetailId = new Guid("2eaaba04-80ff-43a6-a746-a74a91c5c2e8"),
                Name = "elbjgb-h1_01.jpg",
                Status = 0,
            },
            new ProductImage()
            {
                Id = new Guid("d5c65162-7591-48c1-9198-daca184bce2c"),
                ProductDetailId = new Guid("2eaaba04-80ff-43a6-a746-a74a91c5c2e8"),
                Name = "actxs-e_02_1_1.jpg",
                Status = 0,
            },
            new ProductImage()
            {
                Id = new Guid("d5c65162-7591-48c1-9198-daca184bce3c"),
                ProductDetailId = new Guid("2eaaba04-80ff-43a6-a746-a74a91c5c2e8"),
                Name = "actxs-q_02.jpg",
                Status = 0,
            },
            new ProductImage()
            {
                Id = new Guid("d5c65162-7591-48c1-9198-daca184bce4c"),
                ProductDetailId = new Guid("2eaaba04-80ff-43a6-a746-a74a91c5c2e9"),
                Name = "elbjgb_02.jpg",
                Status = 0,
            },
            new ProductImage()
            {
                Id = new Guid("d5c65162-7591-48c1-9198-daca184bce5c"),
                ProductDetailId = new Guid("2eaaba04-80ff-43a6-a746-a74a91c5c2e9"),
                Name = "elbjgb-h2_01.jpg",
                Status = 0,
            },
            new ProductImage()
            {
                Id = new Guid("d5c65162-7591-48c1-9198-daca184bce6c"),
                ProductDetailId = new Guid("2eaaba04-80ff-43a6-a746-a74a91c5c2e9"),
                Name = "elbjgb-h1_01.jpg",
                Status = 0,
            },
            new ProductImage()
            {
                Id = new Guid("d5c65162-7591-48c1-9198-daca184bce7c"),
                ProductDetailId = new Guid("2eaaba04-80ff-43a6-a746-a74a91c5c2e9"),
                Name = "actxs-e_02_1_1.jpg",
                Status = 0,
            },
            new ProductImage()
            {
                Id = new Guid("d5c65162-7591-48c1-9198-daca184bce8c"),
                ProductDetailId = new Guid("2eaaba04-80ff-43a6-a746-a74a91c5c2e9"),
                Name = "actxs-q_02.jpg",
                Status = 0,
            },
            new ProductImage()
            {
                Id = new Guid("d5c65162-7591-48c1-9198-daca184bce9c"),
                ProductDetailId = new Guid("2eaaba04-80ff-43a6-a746-a74a91c5c3e0"),
                Name = "elbjgb_02.jpg",
                Status = 0,
            },
            new ProductImage()
            {
                Id = new Guid("d5c65162-7591-48c1-9198-daca185bce0c"),
                ProductDetailId = new Guid("2eaaba04-80ff-43a6-a746-a74a91c5c3e0"),
                Name = "elbjgb-h2_01.jpg",
                Status = 0,
            },
            new ProductImage()
            {
                Id = new Guid("d5c65162-7591-48c1-9198-daca185bce1c"),
                ProductDetailId = new Guid("2eaaba04-80ff-43a6-a746-a74a91c5c3e0"),
                Name = "elbjgb-h1_01.jpg",
                Status = 0,
            },
            new ProductImage()
            {
                Id = new Guid("d5c65162-7591-48c1-9198-daca185bce2c"),
                ProductDetailId = new Guid("2eaaba04-80ff-43a6-a746-a74a91c5c3e0"),
                Name = "actxs-e_02_1_1.jpg",
                Status = 0,
            },
            new ProductImage()
            {
                Id = new Guid("d5c65162-7591-48c1-9198-daca185bce3c"),
                ProductDetailId = new Guid("2eaaba04-80ff-43a6-a746-a74a91c5c3e0"),
                Name = "actxs-q_02.jpg",
                Status = 0,
            },
            new ProductImage()
            {
                Id = new Guid("d5c65162-7591-48c1-9198-daca185bce4c"),
                ProductDetailId = new Guid("2eaaba04-80ff-43a6-a746-a74a91c5c3e1"),
                Name = "elbjgb_02.jpg",
                Status = 0,
            },
            new ProductImage()
            {
                Id = new Guid("d5c65162-7591-48c1-9198-daca185bce5c"),
                ProductDetailId = new Guid("2eaaba04-80ff-43a6-a746-a74a91c5c3e1"),
                Name = "elbjgb-h2_01.jpg",
                Status = 0,
            },
            new ProductImage()
            {
                Id = new Guid("d5c65162-7591-48c1-9198-daca185bce6c"),
                ProductDetailId = new Guid("2eaaba04-80ff-43a6-a746-a74a91c5c3e1"),
                Name = "elbjgb-h1_01.jpg",
                Status = 0,
            },
            new ProductImage()
            {
                Id = new Guid("d5c65162-7591-48c1-9198-daca185bce7c"),
                ProductDetailId = new Guid("2eaaba04-80ff-43a6-a746-a74a91c5c3e1"),
                Name = "actxs-e_02_1_1.jpg",
                Status = 0,
            },
            new ProductImage()
            {
                Id = new Guid("d5c65162-7591-48c1-9198-daca185bce8c"),
                ProductDetailId = new Guid("2eaaba04-80ff-43a6-a746-a74a91c5c3e1"),
                Name = "actxs-q_02.jpg",
                Status = 0,
            },
            new ProductImage()
            {
                Id = new Guid("d5c65162-7591-48c1-9198-daca185bce9c"),
                ProductDetailId = new Guid("2eaaba04-80ff-43a6-a746-a74a91c5c3e2"),
                Name = "elbjgb_02.jpg",
                Status = 0,
            },
            new ProductImage()
            {
                Id = new Guid("d5c65162-7591-48c1-9198-daca186bce0c"),
                ProductDetailId = new Guid("2eaaba04-80ff-43a6-a746-a74a91c5c3e2"),
                Name = "elbjgb-h2_01.jpg",
                Status = 0,
            },
            new ProductImage()
            {
                Id = new Guid("d5c65162-7591-48c1-9198-daca186bce1c"),
                ProductDetailId = new Guid("2eaaba04-80ff-43a6-a746-a74a91c5c3e2"),
                Name = "elbjgb-h1_01.jpg",
                Status = 0,
            },
            new ProductImage()
            {
                Id = new Guid("d5c65162-7591-48c1-9198-daca186bce2c"),
                ProductDetailId = new Guid("2eaaba04-80ff-43a6-a746-a74a91c5c3e2"),
                Name = "actxs-e_02_1_1.jpg",
                Status = 0,
            },
            new ProductImage()
            {
                Id = new Guid("d5c65162-7591-48c1-9198-daca186bce3c"),
                ProductDetailId = new Guid("2eaaba04-80ff-43a6-a746-a74a91c5c3e2"),
                Name = "actxs-q_02.jpg",
                Status = 0,
            },
            new ProductImage()
            {
                Id = new Guid("d5c65162-7591-48c1-9198-daca186bce4c"),
                ProductDetailId = new Guid("2eaaba04-80ff-43a6-a746-a74a91c5c3e3"),
                Name = "elbjgb_02.jpg",
                Status = 0,
            },
            new ProductImage()
            {
                Id = new Guid("d5c65162-7591-48c1-9198-daca186bce5c"),
                ProductDetailId = new Guid("2eaaba04-80ff-43a6-a746-a74a91c5c3e3"),
                Name = "elbjgb-h2_01.jpg",
                Status = 0,
            },
            new ProductImage()
            {
                Id = new Guid("d5c65162-7591-48c1-9198-daca186bce6c"),
                ProductDetailId = new Guid("2eaaba04-80ff-43a6-a746-a74a91c5c3e3"),
                Name = "elbjgb-h1_01.jpg",
                Status = 0,
            },
            new ProductImage()
            {
                Id = new Guid("d5c65162-7591-48c1-9198-daca186bce7c"),
                ProductDetailId = new Guid("2eaaba04-80ff-43a6-a746-a74a91c5c3e3"),
                Name = "actxs-e_02_1_1.jpg",
                Status = 0,
            },
            new ProductImage()
            {
                Id = new Guid("d5c65162-7591-48c1-9198-daca186bce8c"),
                ProductDetailId = new Guid("2eaaba04-80ff-43a6-a746-a74a91c5c3e3"),
                Name = "actxs-q_02.jpg",
                Status = 0,
            },
            new ProductImage()
            {
                Id = new Guid("d5c65162-7591-48c1-9198-daca186bce9c"),
                ProductDetailId = new Guid("2eaaba04-80ff-43a6-a746-a74a91c5c3e4"),
                Name = "elbjgb_02.jpg",
                Status = 0,
            },
            new ProductImage()
            {
                Id = new Guid("d5c65162-7591-48c1-9198-daca187bce0c"),
                ProductDetailId = new Guid("2eaaba04-80ff-43a6-a746-a74a91c5c3e4"),
                Name = "elbjgb-h2_01.jpg",
                Status = 0,
            },
            new ProductImage()
            {
                Id = new Guid("d5c65162-7591-48c1-9198-daca187bce1c"),
                ProductDetailId = new Guid("2eaaba04-80ff-43a6-a746-a74a91c5c3e4"),
                Name = "elbjgb-h1_01.jpg",
                Status = 0,
            },
            new ProductImage()
            {
                Id = new Guid("d5c65162-7591-48c1-9198-daca187bce2c"),
                ProductDetailId = new Guid("2eaaba04-80ff-43a6-a746-a74a91c5c3e4"),
                Name = "actxs-e_02_1_1.jpg",
                Status = 0,
            },
            new ProductImage()
            {
                Id = new Guid("d5c65162-7591-48c1-9198-daca187bce3c"),
                ProductDetailId = new Guid("2eaaba04-80ff-43a6-a746-a74a91c5c3e4"),
                Name = "actxs-q_02.jpg",
                Status = 0,
            },
            new ProductImage()
            {
                Id = new Guid("d5c65162-7591-48c1-9198-daca187bce4c"),
                ProductDetailId = new Guid("2eaaba04-80ff-43a6-a746-a74a91c5c3e5"),
                Name = "elbjgb_02.jpg",
                Status = 0,
            },
            new ProductImage()
            {
                Id = new Guid("d5c65162-7591-48c1-9198-daca187bce5c"),
                ProductDetailId = new Guid("2eaaba04-80ff-43a6-a746-a74a91c5c3e5"),
                Name = "elbjgb-h2_01.jpg",
                Status = 0,
            },
            new ProductImage()
            {
                Id = new Guid("d5c65162-7591-48c1-9198-daca187bce6c"),
                ProductDetailId = new Guid("2eaaba04-80ff-43a6-a746-a74a91c5c3e5"),
                Name = "elbjgb-h1_01.jpg",
                Status = 0,
            },
            new ProductImage()
            {
                Id = new Guid("d5c65162-7591-48c1-9198-daca187bce7c"),
                ProductDetailId = new Guid("2eaaba04-80ff-43a6-a746-a74a91c5c3e5"),
                Name = "actxs-e_02_1_1.jpg",
                Status = 0,
            },
            new ProductImage()
            {
                Id = new Guid("d5c65162-7591-48c1-9198-daca187bce8c"),
                ProductDetailId = new Guid("2eaaba04-80ff-43a6-a746-a74a91c5c3e5"),
                Name = "actxs-q_02.jpg",
                Status = 0,
            },
            new ProductImage()
            {
                Id = new Guid("d5c65162-7591-48c1-9198-daca187bce9c"),
                ProductDetailId = new Guid("2eaaba04-80ff-43a6-a746-a74a91c5c3e6"),
                Name = "elbjgb_02.jpg",
                Status = 0,
            },
            new ProductImage()
            {
                Id = new Guid("d5c65162-7591-48c1-9198-daca188bce0c"),
                ProductDetailId = new Guid("2eaaba04-80ff-43a6-a746-a74a91c5c3e6"),
                Name = "elbjgb-h2_01.jpg",
                Status = 0,
            },
            new ProductImage()
            {
                Id = new Guid("d5c65162-7591-48c1-9198-daca188bce1c"),
                ProductDetailId = new Guid("2eaaba04-80ff-43a6-a746-a74a91c5c3e6"),
                Name = "elbjgb-h1_01.jpg",
                Status = 0,
            },
            new ProductImage()
            {
                Id = new Guid("d5c65162-7591-48c1-9198-daca188bce2c"),
                ProductDetailId = new Guid("2eaaba04-80ff-43a6-a746-a74a91c5c3e6"),
                Name = "actxs-e_02_1_1.jpg",
                Status = 0,
            },
            new ProductImage()
            {
                Id = new Guid("d5c65162-7591-48c1-9198-daca188bce3c"),
                ProductDetailId = new Guid("2eaaba04-80ff-43a6-a746-a74a91c5c3e6"),
                Name = "actxs-q_02.jpg",
                Status = 0,
            },
            new ProductImage()
            {
                Id = new Guid("d5c65162-7591-48c1-9198-daca188bce4c"),
                ProductDetailId = new Guid("2eaaba04-80ff-43a6-a746-a74a91c5c3e7"),
                Name = "elbjgb_02.jpg",
                Status = 0,
            },
            new ProductImage()
            {
                Id = new Guid("d5c65162-7591-48c1-9198-daca188bce5c"),
                ProductDetailId = new Guid("2eaaba04-80ff-43a6-a746-a74a91c5c3e7"),
                Name = "elbjgb-h2_01.jpg",
                Status = 0,
            },
            new ProductImage()
            {
                Id = new Guid("d5c65162-7591-48c1-9198-daca188bce6c"),
                ProductDetailId = new Guid("2eaaba04-80ff-43a6-a746-a74a91c5c3e7"),
                Name = "elbjgb-h1_01.jpg",
                Status = 0,
            },
            new ProductImage()
            {
                Id = new Guid("d5c65162-7591-48c1-9198-daca188bce7c"),
                ProductDetailId = new Guid("2eaaba04-80ff-43a6-a746-a74a91c5c3e7"),
                Name = "actxs-e_02_1_1.jpg",
                Status = 0,
            },
            new ProductImage()
            {
                Id = new Guid("d5c65162-7591-48c1-9198-daca188bce8c"),
                ProductDetailId = new Guid("2eaaba04-80ff-43a6-a746-a74a91c5c3e7"),
                Name = "actxs-q_02.jpg",
                Status = 0,
            },
            new ProductImage()
            {
                Id = new Guid("d5c65162-7591-48c1-9198-daca188bce9c"),
                ProductDetailId = new Guid("2eaaba04-80ff-43a6-a746-a74a91c5c3e8"),
                Name = "elbjgb_02.jpg",
                Status = 0,
            },
            new ProductImage()
            {
                Id = new Guid("d5c65162-7591-48c1-9198-daca189bce0c"),
                ProductDetailId = new Guid("2eaaba04-80ff-43a6-a746-a74a91c5c3e8"),
                Name = "elbjgb-h2_01.jpg",
                Status = 0,
            },
            new ProductImage()
            {
                Id = new Guid("d5c65162-7591-48c1-9198-daca189bce1c"),
                ProductDetailId = new Guid("2eaaba04-80ff-43a6-a746-a74a91c5c3e8"),
                Name = "elbjgb-h1_01.jpg",
                Status = 0,
            },
            new ProductImage()
            {
                Id = new Guid("d5c65162-7591-48c1-9198-daca189bce2c"),
                ProductDetailId = new Guid("2eaaba04-80ff-43a6-a746-a74a91c5c3e8"),
                Name = "actxs-e_02_1_1.jpg",
                Status = 0,
            },
            new ProductImage()
            {
                Id = new Guid("d5c65162-7591-48c1-9198-daca189bce3c"),
                ProductDetailId = new Guid("2eaaba04-80ff-43a6-a746-a74a91c5c3e8"),
                Name = "actxs-q_02.jpg",
                Status = 0,
            },
            new ProductImage()
            {
                Id = new Guid("d5c65162-7591-48c1-9198-daca189bce4c"),
                ProductDetailId = new Guid("2eaaba04-80ff-43a6-a746-a74a91c5c3e9"),
                Name = "elbjgb_02.jpg",
                Status = 0,
            },
            new ProductImage()
            {
                Id = new Guid("d5c65162-7591-48c1-9198-daca189bce5c"),
                ProductDetailId = new Guid("2eaaba04-80ff-43a6-a746-a74a91c5c3e9"),
                Name = "elbjgb-h2_01.jpg",
                Status = 0,
            },
            new ProductImage()
            {
                Id = new Guid("d5c65162-7591-48c1-9198-daca189bce6c"),
                ProductDetailId = new Guid("2eaaba04-80ff-43a6-a746-a74a91c5c3e9"),
                Name = "elbjgb-h1_01.jpg",
                Status = 0,
            },
            new ProductImage()
            {
                Id = new Guid("d5c65162-7591-48c1-9198-daca189bce7c"),
                ProductDetailId = new Guid("2eaaba04-80ff-43a6-a746-a74a91c5c3e9"),
                Name = "actxs-e_02_1_1.jpg",
                Status = 0,
            },
            new ProductImage()
            {
                Id = new Guid("d5c65162-7591-48c1-9198-daca189bce8c"),
                ProductDetailId = new Guid("2eaaba04-80ff-43a6-a746-a74a91c5c3e9"),
                Name = "actxs-q_02.jpg",
                Status = 0,
            },
            new ProductImage()
            {
                Id = new Guid("d5c65162-7591-48c1-9198-daca189bce9c"),
                ProductDetailId = new Guid("2eaaba04-80ff-43a6-a746-a74a91c6c0e0"),
                Name = "elbjgb_02.jpg",
                Status = 0,
            },
            new ProductImage()
            {
                Id = new Guid("d5c65162-7591-48c1-9198-daca190bce0c"),
                ProductDetailId = new Guid("2eaaba04-80ff-43a6-a746-a74a91c6c0e0"),
                Name = "elbjgb-h2_01.jpg",
                Status = 0,
            },
            new ProductImage()
            {
                Id = new Guid("d5c65162-7591-48c1-9198-daca190bce1c"),
                ProductDetailId = new Guid("2eaaba04-80ff-43a6-a746-a74a91c6c0e0"),
                Name = "elbjgb-h1_01.jpg",
                Status = 0,
            },
            new ProductImage()
            {
                Id = new Guid("d5c65162-7591-48c1-9198-daca190bce2c"),
                ProductDetailId = new Guid("2eaaba04-80ff-43a6-a746-a74a91c6c0e0"),
                Name = "actxs-e_02_1_1.jpg",
                Status = 0,
            },
            new ProductImage()
            {
                Id = new Guid("d5c65162-7591-48c1-9198-daca190bce3c"),
                ProductDetailId = new Guid("2eaaba04-80ff-43a6-a746-a74a91c6c0e0"),
                Name = "actxs-q_02.jpg",
                Status = 0,
            },
            new ProductImage()
            {
                Id = new Guid("d5c65162-7591-48c1-9198-daca190bce4c"),
                ProductDetailId = new Guid("2eaaba04-80ff-43a6-a746-a74a91c6c0e1"),
                Name = "elbjgb_02.jpg",
                Status = 0,
            },
            new ProductImage()
            {
                Id = new Guid("d5c65162-7591-48c1-9198-daca190bce5c"),
                ProductDetailId = new Guid("2eaaba04-80ff-43a6-a746-a74a91c6c0e1"),
                Name = "elbjgb-h2_01.jpg",
                Status = 0,
            },
            new ProductImage()
            {
                Id = new Guid("d5c65162-7591-48c1-9198-daca190bce6c"),
                ProductDetailId = new Guid("2eaaba04-80ff-43a6-a746-a74a91c6c0e1"),
                Name = "elbjgb-h1_01.jpg",
                Status = 0,
            },
            new ProductImage()
            {
                Id = new Guid("d5c65162-7591-48c1-9198-daca190bce7c"),
                ProductDetailId = new Guid("2eaaba04-80ff-43a6-a746-a74a91c6c0e1"),
                Name = "actxs-e_02_1_1.jpg",
                Status = 0,
            },
            new ProductImage()
            {
                Id = new Guid("d5c65162-7591-48c1-9198-daca190bce8c"),
                ProductDetailId = new Guid("2eaaba04-80ff-43a6-a746-a74a91c6c0e1"),
                Name = "actxs-q_02.jpg",
                Status = 0,
            },
            new ProductImage()
            {
                Id = new Guid("d5c65162-7591-48c1-9198-daca190bce9c"),
                ProductDetailId = new Guid("2eaaba04-80ff-43a6-a746-a74a91c6c0e2"),
                Name = "elbjgb_02.jpg",
                Status = 0,
            },
            new ProductImage()
            {
                Id = new Guid("d5c65162-7591-48c1-9198-daca191bce0c"),
                ProductDetailId = new Guid("2eaaba04-80ff-43a6-a746-a74a91c6c0e2"),
                Name = "elbjgb-h2_01.jpg",
                Status = 0,
            },
            new ProductImage()
            {
                Id = new Guid("d5c65162-7591-48c1-9198-daca191bce1c"),
                ProductDetailId = new Guid("2eaaba04-80ff-43a6-a746-a74a91c6c0e2"),
                Name = "elbjgb-h1_01.jpg",
                Status = 0,
            },
            new ProductImage()
            {
                Id = new Guid("d5c65162-7591-48c1-9198-daca191bce2c"),
                ProductDetailId = new Guid("2eaaba04-80ff-43a6-a746-a74a91c6c0e2"),
                Name = "actxs-e_02_1_1.jpg",
                Status = 0,
            },
            new ProductImage()
            {
                Id = new Guid("d5c65162-7591-48c1-9198-daca191bce3c"),
                ProductDetailId = new Guid("2eaaba04-80ff-43a6-a746-a74a91c6c0e2"),
                Name = "actxs-q_02.jpg",
                Status = 0,
            },
            new ProductImage()
            {
                Id = new Guid("d5c65162-7591-48c1-9198-daca191bce4c"),
                ProductDetailId = new Guid("2eaaba04-80ff-43a6-a746-a74a91c6c0e3"),
                Name = "elbjgb_02.jpg",
                Status = 0,
            },
            new ProductImage()
            {
                Id = new Guid("d5c65162-7591-48c1-9198-daca191bce5c"),
                ProductDetailId = new Guid("2eaaba04-80ff-43a6-a746-a74a91c6c0e3"),
                Name = "elbjgb-h2_01.jpg",
                Status = 0,
            },
            new ProductImage()
            {
                Id = new Guid("d5c65162-7591-48c1-9198-daca191bce6c"),
                ProductDetailId = new Guid("2eaaba04-80ff-43a6-a746-a74a91c6c0e3"),
                Name = "elbjgb-h1_01.jpg",
                Status = 0,
            },
            new ProductImage()
            {
                Id = new Guid("d5c65162-7591-48c1-9198-daca191bce7c"),
                ProductDetailId = new Guid("2eaaba04-80ff-43a6-a746-a74a91c6c0e3"),
                Name = "actxs-e_02_1_1.jpg",
                Status = 0,
            },
            new ProductImage()
            {
                Id = new Guid("d5c65162-7591-48c1-9198-daca191bce8c"),
                ProductDetailId = new Guid("2eaaba04-80ff-43a6-a746-a74a91c6c0e3"),
                Name = "actxs-q_02.jpg",
                Status = 0,
            },
            new ProductImage()
            {
                Id = new Guid("d5c65162-7591-48c1-9198-daca191bce9c"),
                ProductDetailId = new Guid("2eaaba04-80ff-43a6-a746-a74a91c6c0e4"),
                Name = "elbjgb_02.jpg",
                Status = 0,
            },
            new ProductImage()
            {
                Id = new Guid("d5c65162-7591-48c1-9198-daca192bce0c"),
                ProductDetailId = new Guid("2eaaba04-80ff-43a6-a746-a74a91c6c0e4"),
                Name = "elbjgb-h2_01.jpg",
                Status = 0,
            },
            new ProductImage()
            {
                Id = new Guid("d5c65162-7591-48c1-9198-daca192bce1c"),
                ProductDetailId = new Guid("2eaaba04-80ff-43a6-a746-a74a91c6c0e4"),
                Name = "elbjgb-h1_01.jpg",
                Status = 0,
            },
            new ProductImage()
            {
                Id = new Guid("d5c65162-7591-48c1-9198-daca192bce2c"),
                ProductDetailId = new Guid("2eaaba04-80ff-43a6-a746-a74a91c6c0e4"),
                Name = "actxs-e_02_1_1.jpg",
                Status = 0,
            },
            new ProductImage()
            {
                Id = new Guid("d5c65162-7591-48c1-9198-daca192bce3c"),
                ProductDetailId = new Guid("2eaaba04-80ff-43a6-a746-a74a91c6c0e4"),
                Name = "actxs-q_02.jpg",
                Status = 0,
            },
            new ProductImage()
            {
                Id = new Guid("d5c65162-7591-48c1-9198-daca192bce4c"),
                ProductDetailId = new Guid("2eaaba04-80ff-43a6-a746-a74a91c6c0e5"),
                Name = "elbjgb_02.jpg",
                Status = 0,
            },
            new ProductImage()
            {
                Id = new Guid("d5c65162-7591-48c1-9198-daca192bce5c"),
                ProductDetailId = new Guid("2eaaba04-80ff-43a6-a746-a74a91c6c0e5"),
                Name = "elbjgb-h2_01.jpg",
                Status = 0,
            },
            new ProductImage()
            {
                Id = new Guid("d5c65162-7591-48c1-9198-daca192bce6c"),
                ProductDetailId = new Guid("2eaaba04-80ff-43a6-a746-a74a91c6c0e5"),
                Name = "elbjgb-h1_01.jpg",
                Status = 0,
            },
            new ProductImage()
            {
                Id = new Guid("d5c65162-7591-48c1-9198-daca192bce7c"),
                ProductDetailId = new Guid("2eaaba04-80ff-43a6-a746-a74a91c6c0e5"),
                Name = "actxs-e_02_1_1.jpg",
                Status = 0,
            },
            new ProductImage()
            {
                Id = new Guid("d5c65162-7591-48c1-9198-daca192bce8c"),
                ProductDetailId = new Guid("2eaaba04-80ff-43a6-a746-a74a91c6c0e5"),
                Name = "actxs-q_02.jpg",
                Status = 0,
            },
            new ProductImage()
            {
                Id = new Guid("d5c65162-7591-48c1-9198-daca192bce9c"),
                ProductDetailId = new Guid("2eaaba04-80ff-43a6-a746-a74a91c6c0e6"),
                Name = "elbjgb_02.jpg",
                Status = 0,
            },
            new ProductImage()
            {
                Id = new Guid("d5c65162-7591-48c1-9198-daca193bce0c"),
                ProductDetailId = new Guid("2eaaba04-80ff-43a6-a746-a74a91c6c0e6"),
                Name = "elbjgb-h2_01.jpg",
                Status = 0,
            },
            new ProductImage()
            {
                Id = new Guid("d5c65162-7591-48c1-9198-daca193bce1c"),
                ProductDetailId = new Guid("2eaaba04-80ff-43a6-a746-a74a91c6c0e6"),
                Name = "elbjgb-h1_01.jpg",
                Status = 0,
            },
            new ProductImage()
            {
                Id = new Guid("d5c65162-7591-48c1-9198-daca193bce2c"),
                ProductDetailId = new Guid("2eaaba04-80ff-43a6-a746-a74a91c6c0e6"),
                Name = "actxs-e_02_1_1.jpg",
                Status = 0,
            },
            new ProductImage()
            {
                Id = new Guid("d5c65162-7591-48c1-9198-daca193bce3c"),
                ProductDetailId = new Guid("2eaaba04-80ff-43a6-a746-a74a91c6c0e6"),
                Name = "actxs-q_02.jpg",
                Status = 0,
            },
            new ProductImage()
            {
                Id = new Guid("d5c65162-7591-48c1-9198-daca193bce4c"),
                ProductDetailId = new Guid("2eaaba04-80ff-43a6-a746-a74a91c6c0e7"),
                Name = "elbjgb_02.jpg",
                Status = 0,
            },
            new ProductImage()
            {
                Id = new Guid("d5c65162-7591-48c1-9198-daca193bce5c"),
                ProductDetailId = new Guid("2eaaba04-80ff-43a6-a746-a74a91c6c0e7"),
                Name = "elbjgb-h2_01.jpg",
                Status = 0,
            },
            new ProductImage()
            {
                Id = new Guid("d5c65162-7591-48c1-9198-daca193bce6c"),
                ProductDetailId = new Guid("2eaaba04-80ff-43a6-a746-a74a91c6c0e7"),
                Name = "elbjgb-h1_01.jpg",
                Status = 0,
            },
            new ProductImage()
            {
                Id = new Guid("d5c65162-7591-48c1-9198-daca193bce7c"),
                ProductDetailId = new Guid("2eaaba04-80ff-43a6-a746-a74a91c6c0e7"),
                Name = "actxs-e_02_1_1.jpg",
                Status = 0,
            },
            new ProductImage()
            {
                Id = new Guid("d5c65162-7591-48c1-9198-daca193bce8c"),
                ProductDetailId = new Guid("2eaaba04-80ff-43a6-a746-a74a91c6c0e7"),
                Name = "actxs-q_02.jpg",
                Status = 0,
            },
            new ProductImage()
            {
                Id = new Guid("d5c65162-7591-48c1-9198-daca193bce9c"),
                ProductDetailId = new Guid("2eaaba04-80ff-43a6-a746-a74a91c6c0e8"),
                Name = "elbjgb_02.jpg",
                Status = 0,
            },
            new ProductImage()
            {
                Id = new Guid("d5c65162-7591-48c1-9198-daca194bce0c"),
                ProductDetailId = new Guid("2eaaba04-80ff-43a6-a746-a74a91c6c0e8"),
                Name = "elbjgb-h2_01.jpg",
                Status = 0,
            },
            new ProductImage()
            {
                Id = new Guid("d5c65162-7591-48c1-9198-daca194bce1c"),
                ProductDetailId = new Guid("2eaaba04-80ff-43a6-a746-a74a91c6c0e8"),
                Name = "elbjgb-h1_01.jpg",
                Status = 0,
            },
            new ProductImage()
            {
                Id = new Guid("d5c65162-7591-48c1-9198-daca194bce2c"),
                ProductDetailId = new Guid("2eaaba04-80ff-43a6-a746-a74a91c6c0e8"),
                Name = "actxs-e_02_1_1.jpg",
                Status = 0,
            },
            new ProductImage()
            {
                Id = new Guid("d5c65162-7591-48c1-9198-daca999bce2c"),
                ProductDetailId = new Guid("2eaaba04-80ff-43a6-a746-a74a91c6c0e8"),
                Name = "actxs-q_02.jpg",
                Status = 0,
            },
            new ProductImage()
            {
                Id = new Guid("d5c65162-7591-48c1-9198-daca194bce3c"),
                ProductDetailId = new Guid("2eaaba04-80ff-43a6-a746-a74a91c6c0e9"),
                Name = "elbjgb_02.jpg",
                Status = 0,
            },
            new ProductImage()
            {
                Id = new Guid("d5c65162-7591-48c1-9198-daca194bce4c"),
                ProductDetailId = new Guid("2eaaba04-80ff-43a6-a746-a74a91c6c0e9"),
                Name = "elbjgb-h2_01.jpg",
                Status = 0,
            },
            new ProductImage()
            {
                Id = new Guid("d5c65162-7591-48c1-9198-daca194bce5c"),
                ProductDetailId = new Guid("2eaaba04-80ff-43a6-a746-a74a91c6c0e9"),
                Name = "elbjgb-h1_01.jpg",
                Status = 0,
            },
            new ProductImage()
            {
                Id = new Guid("d5c65162-7591-48c1-9198-daca194bce6c"),
                ProductDetailId = new Guid("2eaaba04-80ff-43a6-a746-a74a91c6c0e9"),
                Name = "actxs-e_02_1_1.jpg",
                Status = 0,
            },
            new ProductImage()
            {
                Id = new Guid("d5c65162-7591-48c1-9198-daca194bce7c"),
                ProductDetailId = new Guid("2eaaba04-80ff-43a6-a746-a74a91c6c0e9"),
                Name = "actxs-q_02.jpg",
                Status = 0,
            },
            new ProductImage()
            {
                Id = new Guid("d5c65162-7591-48c1-9198-daca194bce8c"),
                ProductDetailId = new Guid("2eaaba04-80ff-43a6-a746-a74a91c6c1e0"),
                Name = "elbjgb_02.jpg",
                Status = 0,
            },
            new ProductImage()
            {
                Id = new Guid("d5c65162-7591-48c1-9198-daca194bce9c"),
                ProductDetailId = new Guid("2eaaba04-80ff-43a6-a746-a74a91c6c1e0"),
                Name = "elbjgb-h2_01.jpg",
                Status = 0,
            },
            new ProductImage()
            {
                Id = new Guid("d5c65162-7591-48c1-9198-daca195bce0c"),
                ProductDetailId = new Guid("2eaaba04-80ff-43a6-a746-a74a91c6c1e0"),
                Name = "elbjgb-h1_01.jpg",
                Status = 0,
            },
            new ProductImage()
            {
                Id = new Guid("d5c65162-7591-48c1-9198-daca195bce1c"),
                ProductDetailId = new Guid("2eaaba04-80ff-43a6-a746-a74a91c6c1e0"),
                Name = "actxs-e_02_1_1.jpg",
                Status = 0,
            },
            new ProductImage()
            {
                Id = new Guid("d5c65162-7591-48c1-9198-daca195bce2c"),
                ProductDetailId = new Guid("2eaaba04-80ff-43a6-a746-a74a91c6c1e0"),
                Name = "actxs-q_02.jpg",
                Status = 0,
            },
            new ProductImage()
            {
                Id = new Guid("d5c65162-7591-48c1-9198-daca195bce3c"),
                ProductDetailId = new Guid("2eaaba04-80ff-43a6-a746-a74a91c6c1e1"),
                Name = "elbjgb_02.jpg",
                Status = 0,
            },
            new ProductImage()
            {
                Id = new Guid("d5c65162-7591-48c1-9198-daca195bce4c"),
                ProductDetailId = new Guid("2eaaba04-80ff-43a6-a746-a74a91c6c1e1"),
                Name = "elbjgb-h2_01.jpg",
                Status = 0,
            },
            new ProductImage()
            {
                Id = new Guid("d5c65162-7591-48c1-9198-daca195bce5c"),
                ProductDetailId = new Guid("2eaaba04-80ff-43a6-a746-a74a91c6c1e1"),
                Name = "elbjgb-h1_01.jpg",
                Status = 0,
            },
            new ProductImage()
            {
                Id = new Guid("d5c65162-7591-48c1-9198-daca195bce6c"),
                ProductDetailId = new Guid("2eaaba04-80ff-43a6-a746-a74a91c6c1e1"),
                Name = "actxs-e_02_1_1.jpg",
                Status = 0,
            },
            new ProductImage()
            {
                Id = new Guid("d5c65162-7591-48c1-9198-daca195bce7c"),
                ProductDetailId = new Guid("2eaaba04-80ff-43a6-a746-a74a91c6c1e1"),
                Name = "actxs-q_02.jpg",
                Status = 0,
            },
            new ProductImage()
            {
                Id = new Guid("d5c65162-7591-48c1-9198-daca195bce8c"),
                ProductDetailId = new Guid("2eaaba04-80ff-43a6-a746-a74a91c6c1e2"),
                Name = "elbjgb_02.jpg",
                Status = 0,
            },
            new ProductImage()
            {
                Id = new Guid("d5c65162-7591-48c1-9198-daca195bce9c"),
                ProductDetailId = new Guid("2eaaba04-80ff-43a6-a746-a74a91c6c1e2"),
                Name = "elbjgb-h2_01.jpg",
                Status = 0,
            },
            new ProductImage()
            {
                Id = new Guid("d5c65162-7591-48c1-9198-daca196bce0c"),
                ProductDetailId = new Guid("2eaaba04-80ff-43a6-a746-a74a91c6c1e2"),
                Name = "elbjgb-h1_01.jpg",
                Status = 0,
            },
            new ProductImage()
            {
                Id = new Guid("d5c65162-7591-48c1-9198-daca196bce1c"),
                ProductDetailId = new Guid("2eaaba04-80ff-43a6-a746-a74a91c6c1e2"),
                Name = "actxs-e_02_1_1.jpg",
                Status = 0,
            },
            new ProductImage()
            {
                Id = new Guid("d5c65162-7591-48c1-9198-daca196bce2c"),
                ProductDetailId = new Guid("2eaaba04-80ff-43a6-a746-a74a91c6c1e2"),
                Name = "actxs-q_02.jpg",
                Status = 0,
            },
            new ProductImage()
            {
                Id = new Guid("d5c65162-7591-48c1-9198-daca196bce3c"),
                ProductDetailId = new Guid("2eaaba04-80ff-43a6-a746-a74a91c6c1e3"),
                Name = "elbjgb_02.jpg",
                Status = 0,
            },
            new ProductImage()
            {
                Id = new Guid("d5c65162-7591-48c1-9198-daca196bce4c"),
                ProductDetailId = new Guid("2eaaba04-80ff-43a6-a746-a74a91c6c1e3"),
                Name = "elbjgb-h2_01.jpg",
                Status = 0,
            },
            new ProductImage()
            {
                Id = new Guid("d5c65162-7591-48c1-9198-daca196bce5c"),
                ProductDetailId = new Guid("2eaaba04-80ff-43a6-a746-a74a91c6c1e3"),
                Name = "elbjgb-h1_01.jpg",
                Status = 0,
            },
            new ProductImage()
            {
                Id = new Guid("d5c65162-7591-48c1-9198-daca196bce6c"),
                ProductDetailId = new Guid("2eaaba04-80ff-43a6-a746-a74a91c6c1e3"),
                Name = "actxs-e_02_1_1.jpg",
                Status = 0,
            },
            new ProductImage()
            {
                Id = new Guid("d5c65162-7591-48c1-9198-daca196bce7c"),
                ProductDetailId = new Guid("2eaaba04-80ff-43a6-a746-a74a91c6c1e3"),
                Name = "actxs-q_02.jpg",
                Status = 0,
            },
            new ProductImage()
            {
                Id = new Guid("d5c65162-7591-48c1-9198-daca196bce8c"),
                ProductDetailId = new Guid("2eaaba04-80ff-43a6-a746-a74a91c6c1e4"),
                Name = "elbjgb_02.jpg",
                Status = 0,
            },
            new ProductImage()
            {
                Id = new Guid("d5c65162-7591-48c1-9198-daca196bce9c"),
                ProductDetailId = new Guid("2eaaba04-80ff-43a6-a746-a74a91c6c1e4"),
                Name = "elbjgb-h2_01.jpg",
                Status = 0,
            },
            new ProductImage()
            {
                Id = new Guid("d5c65162-7591-48c1-9198-daca197bce0c"),
                ProductDetailId = new Guid("2eaaba04-80ff-43a6-a746-a74a91c6c1e4"),
                Name = "elbjgb-h1_01.jpg",
                Status = 0,
            },
            new ProductImage()
            {
                Id = new Guid("d5c65162-7591-48c1-9198-daca197bce1c"),
                ProductDetailId = new Guid("2eaaba04-80ff-43a6-a746-a74a91c6c1e4"),
                Name = "actxs-e_02_1_1.jpg",
                Status = 0,
            },
            new ProductImage()
            {
                Id = new Guid("d5c65162-7591-48c1-9198-daca197bce2c"),
                ProductDetailId = new Guid("2eaaba04-80ff-43a6-a746-a74a91c6c1e4"),
                Name = "actxs-q_02.jpg",
                Status = 0,
            },
            new ProductImage()
            {
                Id = new Guid("d5c65162-7591-48c1-9198-daca197bce3c"),
                ProductDetailId = new Guid("2eaaba04-80ff-43a6-a746-a74a91c6c1e5"),
                Name = "elbjgb_02.jpg",
                Status = 0,
            },
            new ProductImage()
            {
                Id = new Guid("d5c65162-7591-48c1-9198-daca197bce4c"),
                ProductDetailId = new Guid("2eaaba04-80ff-43a6-a746-a74a91c6c1e5"),
                Name = "elbjgb-h2_01.jpg",
                Status = 0,
            },
            new ProductImage()
            {
                Id = new Guid("d5c65162-7591-48c1-9198-daca197bce5c"),
                ProductDetailId = new Guid("2eaaba04-80ff-43a6-a746-a74a91c6c1e5"),
                Name = "elbjgb-h1_01.jpg",
                Status = 0,
            },
            new ProductImage()
            {
                Id = new Guid("d5c65162-7591-48c1-9198-daca197bce6c"),
                ProductDetailId = new Guid("2eaaba04-80ff-43a6-a746-a74a91c6c1e5"),
                Name = "actxs-e_02_1_1.jpg",
                Status = 0,
            },
            new ProductImage()
            {
                Id = new Guid("d5c65162-7591-48c1-9198-daca197bce7c"),
                ProductDetailId = new Guid("2eaaba04-80ff-43a6-a746-a74a91c6c1e5"),
                Name = "actxs-q_02.jpg",
                Status = 0,
            },
            new ProductImage()
            {
                Id = new Guid("d5c65162-7591-48c1-9198-daca197bce8c"),
                ProductDetailId = new Guid("2eaaba04-80ff-43a6-a746-a74a91c6c1e6"),
                Name = "elbjgb_02.jpg",
                Status = 0,
            },
            new ProductImage()
            {
                Id = new Guid("d5c65162-7591-48c1-9198-daca197bce9c"),
                ProductDetailId = new Guid("2eaaba04-80ff-43a6-a746-a74a91c6c1e6"),
                Name = "elbjgb-h2_01.jpg",
                Status = 0,
            },
            new ProductImage()
            {
                Id = new Guid("d5c65162-7591-48c1-9198-daca198bce0c"),
                ProductDetailId = new Guid("2eaaba04-80ff-43a6-a746-a74a91c6c1e6"),
                Name = "elbjgb-h1_01.jpg",
                Status = 0,
            },
            new ProductImage()
            {
                Id = new Guid("d5c65162-7591-48c1-9198-daca198bce1c"),
                ProductDetailId = new Guid("2eaaba04-80ff-43a6-a746-a74a91c6c1e6"),
                Name = "actxs-e_02_1_1.jpg",
                Status = 0,
            },
            new ProductImage()
            {
                Id = new Guid("d5c65162-7591-48c1-9198-daca198bce2c"),
                ProductDetailId = new Guid("2eaaba04-80ff-43a6-a746-a74a91c6c1e6"),
                Name = "actxs-q_02.jpg",
                Status = 0,
            },
            new ProductImage()
            {
                Id = new Guid("d5c65162-7591-48c1-9198-daca198bce3c"),
                ProductDetailId = new Guid("2eaaba04-80ff-43a6-a746-a74a91c6c1e7"),
                Name = "elbjgb_02.jpg",
                Status = 0,
            },
            new ProductImage()
            {
                Id = new Guid("d5c65162-7591-48c1-9198-daca198bce4c"),
                ProductDetailId = new Guid("2eaaba04-80ff-43a6-a746-a74a91c6c1e7"),
                Name = "elbjgb-h2_01.jpg",
                Status = 0,
            },
            new ProductImage()
            {
                Id = new Guid("d5c65162-7591-48c1-9198-daca198bce5c"),
                ProductDetailId = new Guid("2eaaba04-80ff-43a6-a746-a74a91c6c1e7"),
                Name = "elbjgb-h1_01.jpg",
                Status = 0,
            },
            new ProductImage()
            {
                Id = new Guid("d5c65162-7591-48c1-9198-daca198bce6c"),
                ProductDetailId = new Guid("2eaaba04-80ff-43a6-a746-a74a91c6c1e7"),
                Name = "actxs-e_02_1_1.jpg",
                Status = 0,
            },
            new ProductImage()
            {
                Id = new Guid("d5c65162-7591-48c1-9198-daca198bce7c"),
                ProductDetailId = new Guid("2eaaba04-80ff-43a6-a746-a74a91c6c1e7"),
                Name = "actxs-q_02.jpg",
                Status = 0,
            },
            new ProductImage()
            {
                Id = new Guid("d5c65162-7591-48c1-9198-daca198bce8c"),
                ProductDetailId = new Guid("2eaaba04-80ff-43a6-a746-a74a91c6c1e8"),
                Name = "elbjgb_02.jpg",
                Status = 0,
            },
            new ProductImage()
            {
                Id = new Guid("d5c65162-7591-48c1-9198-daca198bce9c"),
                ProductDetailId = new Guid("2eaaba04-80ff-43a6-a746-a74a91c6c1e8"),
                Name = "elbjgb-h2_01.jpg",
                Status = 0,
            },
            new ProductImage()
            {
                Id = new Guid("d5c65162-7591-48c1-9198-daca199bce0c"),
                ProductDetailId = new Guid("2eaaba04-80ff-43a6-a746-a74a91c6c1e8"),
                Name = "elbjgb-h1_01.jpg",
                Status = 0,
            },
            new ProductImage()
            {
                Id = new Guid("d5c65162-7591-48c1-9198-daca199bce1c"),
                ProductDetailId = new Guid("2eaaba04-80ff-43a6-a746-a74a91c6c1e8"),
                Name = "actxs-e_02_1_1.jpg",
                Status = 0,
            },
            new ProductImage()
            {
                Id = new Guid("d5c65162-7591-48c1-9198-daca199bce2c"),
                ProductDetailId = new Guid("2eaaba04-80ff-43a6-a746-a74a91c6c1e8"),
                Name = "actxs-q_02.jpg",
                Status = 0,
            },
            new ProductImage()
            {
                Id = new Guid("d5c65162-7591-48c1-9198-daca199bce3c"),
                ProductDetailId = new Guid("2eaaba04-80ff-43a6-a746-a74a91c6c1e9"),
                Name = "elbjgb_02.jpg",
                Status = 0,
            },
            new ProductImage()
            {
                Id = new Guid("d5c65162-7591-48c1-9198-daca199bce4c"),
                ProductDetailId = new Guid("2eaaba04-80ff-43a6-a746-a74a91c6c1e9"),
                Name = "elbjgb-h2_01.jpg",
                Status = 0,
            },
            new ProductImage()
            {
                Id = new Guid("d5c65162-7591-48c1-9198-daca199bce5c"),
                ProductDetailId = new Guid("2eaaba04-80ff-43a6-a746-a74a91c6c1e9"),
                Name = "elbjgb-h1_01.jpg",
                Status = 0,
            },
            new ProductImage()
            {
                Id = new Guid("d5c65162-7591-48c1-9198-daca199bce6c"),
                ProductDetailId = new Guid("2eaaba04-80ff-43a6-a746-a74a91c6c1e9"),
                Name = "actxs-e_02_1_1.jpg",
                Status = 0,
            },
            new ProductImage()
            {
                Id = new Guid("d5c65162-7591-48c1-9198-daca199bce7c"),
                ProductDetailId = new Guid("2eaaba04-80ff-43a6-a746-a74a91c6c1e9"),
                Name = "actxs-q_02.jpg",
                Status = 0,
            },
            new ProductImage()
            {
                Id = new Guid("d5c65162-7591-48c1-9198-daca199bce8c"),
                ProductDetailId = new Guid("2eaaba04-80ff-43a6-a746-a74a91c6c2e0"),
                Name = "elbjgb_02.jpg",
                Status = 0,
            },
            new ProductImage()
            {
                Id = new Guid("d5c65162-7591-48c1-9198-daca199bce9c"),
                ProductDetailId = new Guid("2eaaba04-80ff-43a6-a746-a74a91c6c2e0"),
                Name = "elbjgb-h2_01.jpg",
                Status = 0,
            },
            new ProductImage()
            {
                Id = new Guid("d5c65162-7591-48c1-9198-daca200bce0c"),
                ProductDetailId = new Guid("2eaaba04-80ff-43a6-a746-a74a91c6c2e0"),
                Name = "elbjgb-h1_01.jpg",
                Status = 0,
            },
            new ProductImage()
            {
                Id = new Guid("d5c65162-7591-48c1-9198-daca200bce1c"),
                ProductDetailId = new Guid("2eaaba04-80ff-43a6-a746-a74a91c6c2e0"),
                Name = "actxs-e_02_1_1.jpg",
                Status = 0,
            },
            new ProductImage()
            {
                Id = new Guid("d5c65162-7591-48c1-9198-daca200bce2c"),
                ProductDetailId = new Guid("2eaaba04-80ff-43a6-a746-a74a91c6c2e0"),
                Name = "actxs-q_02.jpg",
                Status = 0,
            },
            new ProductImage()
            {
                Id = new Guid("d5c65162-7591-48c1-9198-daca200bce3c"),
                ProductDetailId = new Guid("2eaaba04-80ff-43a6-a746-a74a91c6c2e1"),
                Name = "elbjgb_02.jpg",
                Status = 0,
            },
            new ProductImage()
            {
                Id = new Guid("d5c65162-7591-48c1-9198-daca200bce4c"),
                ProductDetailId = new Guid("2eaaba04-80ff-43a6-a746-a74a91c6c2e1"),
                Name = "elbjgb-h2_01.jpg",
                Status = 0,
            },
            new ProductImage()
            {
                Id = new Guid("d5c65162-7591-48c1-9198-daca200bce5c"),
                ProductDetailId = new Guid("2eaaba04-80ff-43a6-a746-a74a91c6c2e1"),
                Name = "elbjgb-h1_01.jpg",
                Status = 0,
            },
            new ProductImage()
            {
                Id = new Guid("d5c65162-7591-48c1-9198-daca200bce6c"),
                ProductDetailId = new Guid("2eaaba04-80ff-43a6-a746-a74a91c6c2e1"),
                Name = "actxs-e_02_1_1.jpg",
                Status = 0,
            },
            new ProductImage()
            {
                Id = new Guid("d5c65162-7591-48c1-9198-daca200bce7c"),
                ProductDetailId = new Guid("2eaaba04-80ff-43a6-a746-a74a91c6c2e1"),
                Name = "actxs-q_02.jpg",
                Status = 0,
            },
            new ProductImage()
            {
                Id = new Guid("d5c65162-7591-48c1-9198-daca200bce8c"),
                ProductDetailId = new Guid("2eaaba04-80ff-43a6-a746-a74a91c6c2e2"),
                Name = "elbjgb_02.jpg",
                Status = 0,
            },
            new ProductImage()
            {
                Id = new Guid("d5c65162-7591-48c1-9198-daca200bce9c"),
                ProductDetailId = new Guid("2eaaba04-80ff-43a6-a746-a74a91c6c2e2"),
                Name = "elbjgb-h2_01.jpg",
                Status = 0,
            },
            new ProductImage()
            {
                Id = new Guid("d5c65162-7591-48c1-9198-daca201bce0c"),
                ProductDetailId = new Guid("2eaaba04-80ff-43a6-a746-a74a91c6c2e2"),
                Name = "elbjgb-h1_01.jpg",
                Status = 0,
            },
            new ProductImage()
            {
                Id = new Guid("d5c65162-7591-48c1-9198-daca201bce1c"),
                ProductDetailId = new Guid("2eaaba04-80ff-43a6-a746-a74a91c6c2e2"),
                Name = "actxs-e_02_1_1.jpg",
                Status = 0,
            },
            new ProductImage()
            {
                Id = new Guid("d5c65162-7591-48c1-9198-daca201bce2c"),
                ProductDetailId = new Guid("2eaaba04-80ff-43a6-a746-a74a91c6c2e2"),
                Name = "actxs-q_02.jpg",
                Status = 0,
            },
            new ProductImage()
            {
                Id = new Guid("d5c65162-7591-48c1-9198-daca201bce3c"),
                ProductDetailId = new Guid("2eaaba04-80ff-43a6-a746-a74a91c6c2e3"),
                Name = "elbjgb_02.jpg",
                Status = 0,
            },
            new ProductImage()
            {
                Id = new Guid("d5c65162-7591-48c1-9198-daca201bce4c"),
                ProductDetailId = new Guid("2eaaba04-80ff-43a6-a746-a74a91c6c2e3"),
                Name = "elbjgb-h2_01.jpg",
                Status = 0,
            },
            new ProductImage()
            {
                Id = new Guid("d5c65162-7591-48c1-9198-daca201bce5c"),
                ProductDetailId = new Guid("2eaaba04-80ff-43a6-a746-a74a91c6c2e3"),
                Name = "elbjgb-h1_01.jpg",
                Status = 0,
            },
            new ProductImage()
            {
                Id = new Guid("d5c65162-7591-48c1-9198-daca201bce6c"),
                ProductDetailId = new Guid("2eaaba04-80ff-43a6-a746-a74a91c6c2e3"),
                Name = "actxs-e_02_1_1.jpg",
                Status = 0,
            },
            new ProductImage()
            {
                Id = new Guid("d5c65162-7591-48c1-9198-daca201bce7c"),
                ProductDetailId = new Guid("2eaaba04-80ff-43a6-a746-a74a91c6c2e3"),
                Name = "actxs-q_02.jpg",
                Status = 0,
            },
            new ProductImage()
            {
                Id = new Guid("d5c65162-7591-48c1-9198-daca201bce8c"),
                ProductDetailId = new Guid("2eaaba04-80ff-43a6-a746-a74a91c6c2e4"),
                Name = "elbjgb_02.jpg",
                Status = 0,
            },
            new ProductImage()
            {
                Id = new Guid("d5c65162-7591-48c1-9198-daca201bce9c"),
                ProductDetailId = new Guid("2eaaba04-80ff-43a6-a746-a74a91c6c2e4"),
                Name = "elbjgb-h2_01.jpg",
                Status = 0,
            },
            new ProductImage()
            {
                Id = new Guid("d5c65162-7591-48c1-9198-daca202bce0c"),
                ProductDetailId = new Guid("2eaaba04-80ff-43a6-a746-a74a91c6c2e4"),
                Name = "elbjgb-h1_01.jpg",
                Status = 0,
            },
            new ProductImage()
            {
                Id = new Guid("d5c65162-7591-48c1-9198-daca202bce1c"),
                ProductDetailId = new Guid("2eaaba04-80ff-43a6-a746-a74a91c6c2e4"),
                Name = "actxs-e_02_1_1.jpg",
                Status = 0,
            },
            new ProductImage()
            {
                Id = new Guid("d5c65162-7591-48c1-9198-daca202bce2c"),
                ProductDetailId = new Guid("2eaaba04-80ff-43a6-a746-a74a91c6c2e4"),
                Name = "actxs-q_02.jpg",
                Status = 0,
            },
            new ProductImage()
            {
                Id = new Guid("d5c65162-7591-48c1-9198-daca202bce3c"),
                ProductDetailId = new Guid("2eaaba04-80ff-43a6-a746-a74a91c6c2e5"),
                Name = "elbjgb_02.jpg",
                Status = 0,
            },
            new ProductImage()
            {
                Id = new Guid("d5c65162-7591-48c1-9198-daca202bce4c"),
                ProductDetailId = new Guid("2eaaba04-80ff-43a6-a746-a74a91c6c2e5"),
                Name = "elbjgb-h2_01.jpg",
                Status = 0,
            },
            new ProductImage()
            {
                Id = new Guid("d5c65162-7591-48c1-9198-daca202bce5c"),
                ProductDetailId = new Guid("2eaaba04-80ff-43a6-a746-a74a91c6c2e5"),
                Name = "elbjgb-h1_01.jpg",
                Status = 0,
            },
            new ProductImage()
            {
                Id = new Guid("d5c65162-7591-48c1-9198-daca202bce6c"),
                ProductDetailId = new Guid("2eaaba04-80ff-43a6-a746-a74a91c6c2e5"),
                Name = "actxs-e_02_1_1.jpg",
                Status = 0,
            },
            new ProductImage()
            {
                Id = new Guid("d5c65162-7591-48c1-9198-daca202bce7c"),
                ProductDetailId = new Guid("2eaaba04-80ff-43a6-a746-a74a91c6c2e5"),
                Name = "actxs-q_02.jpg",
                Status = 0,
            },
            new ProductImage()
            {
                Id = new Guid("d5c65162-7591-48c1-9198-daca202bce8c"),
                ProductDetailId = new Guid("2eaaba04-80ff-43a6-a746-a74a91c6c2e6"),
                Name = "elbjgb_02.jpg",
                Status = 0,
            },
            new ProductImage()
            {
                Id = new Guid("d5c65162-7591-48c1-9198-daca202bce9c"),
                ProductDetailId = new Guid("2eaaba04-80ff-43a6-a746-a74a91c6c2e6"),
                Name = "elbjgb-h2_01.jpg",
                Status = 0,
            },
            new ProductImage()
            {
                Id = new Guid("d5c65162-7591-48c1-9198-daca203bce0c"),
                ProductDetailId = new Guid("2eaaba04-80ff-43a6-a746-a74a91c6c2e6"),
                Name = "elbjgb-h1_01.jpg",
                Status = 0,
            },
            new ProductImage()
            {
                Id = new Guid("d5c65162-7591-48c1-9198-daca203bce1c"),
                ProductDetailId = new Guid("2eaaba04-80ff-43a6-a746-a74a91c6c2e6"),
                Name = "actxs-e_02_1_1.jpg",
                Status = 0,
            },
            new ProductImage()
            {
                Id = new Guid("d5c65162-7591-48c1-9198-daca203bce2c"),
                ProductDetailId = new Guid("2eaaba04-80ff-43a6-a746-a74a91c6c2e6"),
                Name = "actxs-q_02.jpg",
                Status = 0,
            },
            new ProductImage()
            {
                Id = new Guid("d5c65162-7591-48c1-9198-daca203bce3c"),
                ProductDetailId = new Guid("2eaaba04-80ff-43a6-a746-a74a91c6c2e7"),
                Name = "elbjgb_02.jpg",
                Status = 0,
            },
            new ProductImage()
            {
                Id = new Guid("d5c65162-7591-48c1-9198-daca203bce4c"),
                ProductDetailId = new Guid("2eaaba04-80ff-43a6-a746-a74a91c6c2e7"),
                Name = "elbjgb-h2_01.jpg",
                Status = 0,
            },
            new ProductImage()
            {
                Id = new Guid("d5c65162-7591-48c1-9198-daca203bce5c"),
                ProductDetailId = new Guid("2eaaba04-80ff-43a6-a746-a74a91c6c2e7"),
                Name = "elbjgb-h1_01.jpg",
                Status = 0,
            },
            new ProductImage()
            {
                Id = new Guid("d5c65162-7591-48c1-9198-daca203bce6c"),
                ProductDetailId = new Guid("2eaaba04-80ff-43a6-a746-a74a91c6c2e7"),
                Name = "actxs-e_02_1_1.jpg",
                Status = 0,
            },
            new ProductImage()
            {
                Id = new Guid("d5c65162-7591-48c1-9198-daca203bce7c"),
                ProductDetailId = new Guid("2eaaba04-80ff-43a6-a746-a74a91c6c2e7"),
                Name = "actxs-q_02.jpg",
                Status = 0,
            },
            new ProductImage()
            {
                Id = new Guid("d5c65162-7591-48c1-9198-daca203bce8c"),
                ProductDetailId = new Guid("2eaaba04-80ff-43a6-a746-a74a91c6c2e8"),
                Name = "elbjgb_02.jpg",
                Status = 0,
            },
            new ProductImage()
            {
                Id = new Guid("d5c65162-7591-48c1-9198-daca203bce9c"),
                ProductDetailId = new Guid("2eaaba04-80ff-43a6-a746-a74a91c6c2e8"),
                Name = "elbjgb-h2_01.jpg",
                Status = 0,
            },
            new ProductImage()
            {
                Id = new Guid("d5c65162-7591-48c1-9198-daca204bce0c"),
                ProductDetailId = new Guid("2eaaba04-80ff-43a6-a746-a74a91c6c2e8"),
                Name = "elbjgb-h1_01.jpg",
                Status = 0,
            },
            new ProductImage()
            {
                Id = new Guid("d5c65162-7591-48c1-9198-daca204bce1c"),
                ProductDetailId = new Guid("2eaaba04-80ff-43a6-a746-a74a91c6c2e8"),
                Name = "actxs-e_02_1_1.jpg",
                Status = 0,
            },
            new ProductImage()
            {
                Id = new Guid("d5c65162-7591-48c1-9198-daca204bce2c"),
                ProductDetailId = new Guid("2eaaba04-80ff-43a6-a746-a74a91c6c2e8"),
                Name = "actxs-q_02.jpg",
                Status = 0,
            },
            new ProductImage()
            {
                Id = new Guid("d5c65162-7591-48c1-9198-daca204bce3c"),
                ProductDetailId = new Guid("2eaaba04-80ff-43a6-a746-a74a91c6c2e9"),
                Name = "elbjgb_02.jpg",
                Status = 0,
            },
            new ProductImage()
            {
                Id = new Guid("d5c65162-7591-48c1-9198-daca204bce4c"),
                ProductDetailId = new Guid("2eaaba04-80ff-43a6-a746-a74a91c6c2e9"),
                Name = "elbjgb-h2_01.jpg",
                Status = 0,
            },
            new ProductImage()
            {
                Id = new Guid("d5c65162-7591-48c1-9198-daca204bce5c"),
                ProductDetailId = new Guid("2eaaba04-80ff-43a6-a746-a74a91c6c2e9"),
                Name = "elbjgb-h1_01.jpg",
                Status = 0,
            },
            new ProductImage()
            {
                Id = new Guid("d5c65162-7591-48c1-9198-daca204bce6c"),
                ProductDetailId = new Guid("2eaaba04-80ff-43a6-a746-a74a91c6c2e9"),
                Name = "actxs-e_02_1_1.jpg",
                Status = 0,
            },
            new ProductImage()
            {
                Id = new Guid("d5c65162-7591-48c1-9198-daca204bce7c"),
                ProductDetailId = new Guid("2eaaba04-80ff-43a6-a746-a74a91c6c2e9"),
                Name = "actxs-q_02.jpg",
                Status = 0,
            },
            new ProductImage()
            {
                Id = new Guid("d5c65162-7591-48c1-9198-daca204bce8c"),
                ProductDetailId = new Guid("2eaaba04-80ff-43a6-a746-a74a91c6c3e0"),
                Name = "elbjgb_02.jpg",
                Status = 0,
            },
            new ProductImage()
            {
                Id = new Guid("d5c65162-7591-48c1-9198-daca204bce9c"),
                ProductDetailId = new Guid("2eaaba04-80ff-43a6-a746-a74a91c6c3e0"),
                Name = "elbjgb-h2_01.jpg",
                Status = 0,
            },
            new ProductImage()
            {
                Id = new Guid("d5c65162-7591-48c1-9198-daca205bce0c"),
                ProductDetailId = new Guid("2eaaba04-80ff-43a6-a746-a74a91c6c3e0"),
                Name = "elbjgb-h1_01.jpg",
                Status = 0,
            },
            new ProductImage()
            {
                Id = new Guid("d5c65162-7591-48c1-9198-daca205bce1c"),
                ProductDetailId = new Guid("2eaaba04-80ff-43a6-a746-a74a91c6c3e0"),
                Name = "actxs-e_02_1_1.jpg",
                Status = 0,
            },
            new ProductImage()
            {
                Id = new Guid("d5c65162-7591-48c1-9198-daca205bce2c"),
                ProductDetailId = new Guid("2eaaba04-80ff-43a6-a746-a74a91c6c3e0"),
                Name = "actxs-q_02.jpg",
                Status = 0,
            },
            new ProductImage()
            {
                Id = new Guid("d5c65162-7591-48c1-9198-daca205bce3c"),
                ProductDetailId = new Guid("2eaaba04-80ff-43a6-a746-a74a91c6c3e1"),
                Name = "elbjgb_02.jpg",
                Status = 0,
            },
            new ProductImage()
            {
                Id = new Guid("d5c65162-7591-48c1-9198-daca205bce4c"),
                ProductDetailId = new Guid("2eaaba04-80ff-43a6-a746-a74a91c6c3e1"),
                Name = "elbjgb-h2_01.jpg",
                Status = 0,
            },
            new ProductImage()
            {
                Id = new Guid("d5c65162-7591-48c1-9198-daca205bce5c"),
                ProductDetailId = new Guid("2eaaba04-80ff-43a6-a746-a74a91c6c3e1"),
                Name = "elbjgb-h1_01.jpg",
                Status = 0,
            },
            new ProductImage()
            {
                Id = new Guid("d5c65162-7591-48c1-9198-daca205bce6c"),
                ProductDetailId = new Guid("2eaaba04-80ff-43a6-a746-a74a91c6c3e1"),
                Name = "actxs-e_02_1_1.jpg",
                Status = 0,
            },
            new ProductImage()
            {
                Id = new Guid("d5c65162-7591-48c1-9198-daca205bce7c"),
                ProductDetailId = new Guid("2eaaba04-80ff-43a6-a746-a74a91c6c3e1"),
                Name = "actxs-q_02.jpg",
                Status = 0,
            },
            new ProductImage()
            {
                Id = new Guid("d5c65162-7591-48c1-9198-daca205bce8c"),
                ProductDetailId = new Guid("2eaaba04-80ff-43a6-a746-a74a91c6c3e2"),
                Name = "elbjgb_02.jpg",
                Status = 0,
            },
            new ProductImage()
            {
                Id = new Guid("d5c65162-7591-48c1-9198-daca205bce9c"),
                ProductDetailId = new Guid("2eaaba04-80ff-43a6-a746-a74a91c6c3e2"),
                Name = "elbjgb-h2_01.jpg",
                Status = 0,
            },
            new ProductImage()
            {
                Id = new Guid("d5c65162-7591-48c1-9198-daca206bce0c"),
                ProductDetailId = new Guid("2eaaba04-80ff-43a6-a746-a74a91c6c3e2"),
                Name = "elbjgb-h1_01.jpg",
                Status = 0,
            },
            new ProductImage()
            {
                Id = new Guid("d5c65162-7591-48c1-9198-daca206bce1c"),
                ProductDetailId = new Guid("2eaaba04-80ff-43a6-a746-a74a91c6c3e2"),
                Name = "actxs-e_02_1_1.jpg",
                Status = 0,
            },
            new ProductImage()
            {
                Id = new Guid("d5c65162-7591-48c1-9198-daca206bce2c"),
                ProductDetailId = new Guid("2eaaba04-80ff-43a6-a746-a74a91c6c3e2"),
                Name = "actxs-q_02.jpg",
                Status = 0,
            },
            new ProductImage()
            {
                Id = new Guid("d5c65162-7591-48c1-9198-daca206bce3c"),
                ProductDetailId = new Guid("2eaaba04-80ff-43a6-a746-a74a91c6c3e3"),
                Name = "elbjgb_02.jpg",
                Status = 0,
            },
            new ProductImage()
            {
                Id = new Guid("d5c65162-7591-48c1-9198-daca206bce4c"),
                ProductDetailId = new Guid("2eaaba04-80ff-43a6-a746-a74a91c6c3e3"),
                Name = "elbjgb-h2_01.jpg",
                Status = 0,
            },
            new ProductImage()
            {
                Id = new Guid("d5c65162-7591-48c1-9198-daca206bce5c"),
                ProductDetailId = new Guid("2eaaba04-80ff-43a6-a746-a74a91c6c3e3"),
                Name = "elbjgb-h1_01.jpg",
                Status = 0,
            },
            new ProductImage()
            {
                Id = new Guid("d5c65162-7591-48c1-9198-daca206bce6c"),
                ProductDetailId = new Guid("2eaaba04-80ff-43a6-a746-a74a91c6c3e3"),
                Name = "actxs-e_02_1_1.jpg",
                Status = 0,
            },
            new ProductImage()
            {
                Id = new Guid("d5c65162-7591-48c1-9198-daca206bce7c"),
                ProductDetailId = new Guid("2eaaba04-80ff-43a6-a746-a74a91c6c3e3"),
                Name = "actxs-q_02.jpg",
                Status = 0,
            },
            new ProductImage()
            {
                Id = new Guid("d5c65162-7591-48c1-9198-daca206bce8c"),
                ProductDetailId = new Guid("2eaaba04-80ff-43a6-a746-a74a91c6c3e4"),
                Name = "elbjgb_02.jpg",
                Status = 0,
            },
            new ProductImage()
            {
                Id = new Guid("d5c65162-7591-48c1-9198-daca206bce9c"),
                ProductDetailId = new Guid("2eaaba04-80ff-43a6-a746-a74a91c6c3e4"),
                Name = "elbjgb-h2_01.jpg",
                Status = 0,
            },
            new ProductImage()
            {
                Id = new Guid("d5c65162-7591-48c1-9198-daca207bce0c"),
                ProductDetailId = new Guid("2eaaba04-80ff-43a6-a746-a74a91c6c3e4"),
                Name = "elbjgb-h1_01.jpg",
                Status = 0,
            },
            new ProductImage()
            {
                Id = new Guid("d5c65162-7591-48c1-9198-daca207bce1c"),
                ProductDetailId = new Guid("2eaaba04-80ff-43a6-a746-a74a91c6c3e4"),
                Name = "actxs-e_02_1_1.jpg",
                Status = 0,
            },
            new ProductImage()
            {
                Id = new Guid("d5c65162-7591-48c1-9198-daca207bce2c"),
                ProductDetailId = new Guid("2eaaba04-80ff-43a6-a746-a74a91c6c3e4"),
                Name = "actxs-q_02.jpg",
                Status = 0,
            },
            new ProductImage()
            {
                Id = new Guid("d5c65162-7591-48c1-9198-daca207bce3c"),
                ProductDetailId = new Guid("2eaaba04-80ff-43a6-a746-a74a91c6c3e5"),
                Name = "elbjgb_02.jpg",
                Status = 0,
            },
            new ProductImage()
            {
                Id = new Guid("d5c65162-7591-48c1-9198-daca207bce4c"),
                ProductDetailId = new Guid("2eaaba04-80ff-43a6-a746-a74a91c6c3e5"),
                Name = "elbjgb-h2_01.jpg",
                Status = 0,
            },
            new ProductImage()
            {
                Id = new Guid("d5c65162-7591-48c1-9198-daca207bce5c"),
                ProductDetailId = new Guid("2eaaba04-80ff-43a6-a746-a74a91c6c3e5"),
                Name = "elbjgb-h1_01.jpg",
                Status = 0,
            },
            new ProductImage()
            {
                Id = new Guid("d5c65162-7591-48c1-9198-daca207bce6c"),
                ProductDetailId = new Guid("2eaaba04-80ff-43a6-a746-a74a91c6c3e5"),
                Name = "actxs-e_02_1_1.jpg",
                Status = 0,
            },
            new ProductImage()
            {
                Id = new Guid("d5c65162-7591-48c1-9198-daca207bce7c"),
                ProductDetailId = new Guid("2eaaba04-80ff-43a6-a746-a74a91c6c3e5"),
                Name = "actxs-q_02.jpg",
                Status = 0,
            },
            new ProductImage()
            {
                Id = new Guid("d5c65162-7591-48c1-9198-daca207bce8c"),
                ProductDetailId = new Guid("2eaaba04-80ff-43a6-a746-a74a91c6c3e6"),
                Name = "elbjgb_02.jpg",
                Status = 0,
            },
            new ProductImage()
            {
                Id = new Guid("d5c65162-7591-48c1-9198-daca207bce9c"),
                ProductDetailId = new Guid("2eaaba04-80ff-43a6-a746-a74a91c6c3e6"),
                Name = "elbjgb-h2_01.jpg",
                Status = 0,
            },
            new ProductImage()
            {
                Id = new Guid("d5c65162-7591-48c1-9198-daca208bce0c"),
                ProductDetailId = new Guid("2eaaba04-80ff-43a6-a746-a74a91c6c3e6"),
                Name = "elbjgb-h1_01.jpg",
                Status = 0,
            },
            new ProductImage()
            {
                Id = new Guid("d5c65162-7591-48c1-9198-daca208bce1c"),
                ProductDetailId = new Guid("2eaaba04-80ff-43a6-a746-a74a91c6c3e6"),
                Name = "actxs-e_02_1_1.jpg",
                Status = 0,
            },
            new ProductImage()
            {
                Id = new Guid("d5c65162-7591-48c1-9198-daca208bce2c"),
                ProductDetailId = new Guid("2eaaba04-80ff-43a6-a746-a74a91c6c3e6"),
                Name = "actxs-q_02.jpg",
                Status = 0,
            },
            new ProductImage()
            {
                Id = new Guid("d5c65162-7591-48c1-9198-daca208bce3c"),
                ProductDetailId = new Guid("2eaaba04-80ff-43a6-a746-a74a91c6c3e7"),
                Name = "elbjgb_02.jpg",
                Status = 0,
            },
            new ProductImage()
            {
                Id = new Guid("d5c65162-7591-48c1-9198-daca208bce4c"),
                ProductDetailId = new Guid("2eaaba04-80ff-43a6-a746-a74a91c6c3e7"),
                Name = "elbjgb-h2_01.jpg",
                Status = 0,
            },
            new ProductImage()
            {
                Id = new Guid("d5c65162-7591-48c1-9198-daca208bce5c"),
                ProductDetailId = new Guid("2eaaba04-80ff-43a6-a746-a74a91c6c3e7"),
                Name = "elbjgb-h1_01.jpg",
                Status = 0,
            },
            new ProductImage()
            {
                Id = new Guid("d5c65162-7591-48c1-9198-daca208bce6c"),
                ProductDetailId = new Guid("2eaaba04-80ff-43a6-a746-a74a91c6c3e7"),
                Name = "actxs-e_02_1_1.jpg",
                Status = 0,
            },
            new ProductImage()
            {
                Id = new Guid("d5c65162-7591-48c1-9198-daca208bce7c"),
                ProductDetailId = new Guid("2eaaba04-80ff-43a6-a746-a74a91c6c3e7"),
                Name = "actxs-q_02.jpg",
                Status = 0,
            },
            new ProductImage()
            {
                Id = new Guid("d5c65162-7591-48c1-9198-daca208bce8c"),
                ProductDetailId = new Guid("2eaaba04-80ff-43a6-a746-a74a91c6c3e8"),
                Name = "elbjgb_02.jpg",
                Status = 0,
            },
            new ProductImage()
            {
                Id = new Guid("d5c65162-7591-48c1-9198-daca208bce9c"),
                ProductDetailId = new Guid("2eaaba04-80ff-43a6-a746-a74a91c6c3e8"),
                Name = "elbjgb-h2_01.jpg",
                Status = 0,
            },
            new ProductImage()
            {
                Id = new Guid("d5c65162-7591-48c1-9198-daca209bce0c"),
                ProductDetailId = new Guid("2eaaba04-80ff-43a6-a746-a74a91c6c3e8"),
                Name = "elbjgb-h1_01.jpg",
                Status = 0,
            },
            new ProductImage()
            {
                Id = new Guid("d5c65162-7591-48c1-9198-daca209bce1c"),
                ProductDetailId = new Guid("2eaaba04-80ff-43a6-a746-a74a91c6c3e8"),
                Name = "actxs-e_02_1_1.jpg",
                Status = 0,
            },
            new ProductImage()
            {
                Id = new Guid("d5c65162-7591-48c1-9198-daca209bce2c"),
                ProductDetailId = new Guid("2eaaba04-80ff-43a6-a746-a74a91c6c3e8"),
                Name = "actxs-q_02.jpg",
                Status = 0,
            },
            new ProductImage()
            {
                Id = new Guid("d5c65162-7591-48c1-9198-daca209bce3c"),
                ProductDetailId = new Guid("2eaaba04-80ff-43a6-a746-a74a91c6c3e9"),
                Name = "elbjgb_02.jpg",
                Status = 0,
            },
            new ProductImage()
            {
                Id = new Guid("d5c65162-7591-48c1-9198-daca209bce4c"),
                ProductDetailId = new Guid("2eaaba04-80ff-43a6-a746-a74a91c6c3e9"),
                Name = "elbjgb-h2_01.jpg",
                Status = 0,
            },
            new ProductImage()
            {
                Id = new Guid("d5c65162-7591-48c1-9198-daca209bce5c"),
                ProductDetailId = new Guid("2eaaba04-80ff-43a6-a746-a74a91c6c3e9"),
                Name = "elbjgb-h1_01.jpg",
                Status = 0,
            },
            new ProductImage()
            {
                Id = new Guid("d5c65162-7591-48c1-9198-daca209bce6c"),
                ProductDetailId = new Guid("2eaaba04-80ff-43a6-a746-a74a91c6c3e9"),
                Name = "actxs-e_02_1_1.jpg",
                Status = 0,
            },
            new ProductImage()
            {
                Id = new Guid("d5c65162-7591-48c1-9198-daca209bce7c"),
                ProductDetailId = new Guid("2eaaba04-80ff-43a6-a746-a74a91c6c3e9"),
                Name = "actxs-q_02.jpg",
                Status = 0,
            },
            new ProductImage()
            {
                Id = new Guid("d5c65162-7591-48c1-9198-daca209bce8c"),
                ProductDetailId = new Guid("2eaaba04-80ff-43a6-a746-a74a91c7c0e0"),
                Name = "elbjgb_02.jpg",
                Status = 0,
            },
            new ProductImage()
            {
                Id = new Guid("d5c65162-7591-48c1-9198-daca209bce9c"),
                ProductDetailId = new Guid("2eaaba04-80ff-43a6-a746-a74a91c7c0e0"),
                Name = "elbjgb-h2_01.jpg",
                Status = 0,
            },
            new ProductImage()
            {
                Id = new Guid("d5c65162-7591-48c1-9198-daca210bce0c"),
                ProductDetailId = new Guid("2eaaba04-80ff-43a6-a746-a74a91c7c0e0"),
                Name = "elbjgb-h1_01.jpg",
                Status = 0,
            },
            new ProductImage()
            {
                Id = new Guid("d5c65162-7591-48c1-9198-daca210bce1c"),
                ProductDetailId = new Guid("2eaaba04-80ff-43a6-a746-a74a91c7c0e0"),
                Name = "actxs-e_02_1_1.jpg",
                Status = 0,
            },
            new ProductImage()
            {
                Id = new Guid("d5c65162-7591-48c1-9198-daca210bce2c"),
                ProductDetailId = new Guid("2eaaba04-80ff-43a6-a746-a74a91c7c0e0"),
                Name = "actxs-q_02.jpg",
                Status = 0,
            },
            new ProductImage()
            {
                Id = new Guid("d5c65162-7591-48c1-9198-daca210bce3c"),
                ProductDetailId = new Guid("2eaaba04-80ff-43a6-a746-a74a91c7c0e1"),
                Name = "elbjgb_02.jpg",
                Status = 0,
            },
            new ProductImage()
            {
                Id = new Guid("d5c65162-7591-48c1-9198-daca210bce4c"),
                ProductDetailId = new Guid("2eaaba04-80ff-43a6-a746-a74a91c7c0e1"),
                Name = "elbjgb-h2_01.jpg",
                Status = 0,
            },
            new ProductImage()
            {
                Id = new Guid("d5c65162-7591-48c1-9198-daca210bce5c"),
                ProductDetailId = new Guid("2eaaba04-80ff-43a6-a746-a74a91c7c0e1"),
                Name = "elbjgb-h1_01.jpg",
                Status = 0,
            },
            new ProductImage()
            {
                Id = new Guid("d5c65162-7591-48c1-9198-daca210bce6c"),
                ProductDetailId = new Guid("2eaaba04-80ff-43a6-a746-a74a91c7c0e1"),
                Name = "actxs-e_02_1_1.jpg",
                Status = 0,
            },
            new ProductImage()
            {
                Id = new Guid("d5c65162-7591-48c1-9198-daca210bce7c"),
                ProductDetailId = new Guid("2eaaba04-80ff-43a6-a746-a74a91c7c0e1"),
                Name = "actxs-q_02.jpg",
                Status = 0,
            },
            new ProductImage()
            {
                Id = new Guid("d5c65162-7591-48c1-9198-daca210bce8c"),
                ProductDetailId = new Guid("2eaaba04-80ff-43a6-a746-a74a91c7c0e2"),
                Name = "elbjgb_02.jpg",
                Status = 0,
            },
            new ProductImage()
            {
                Id = new Guid("d5c65162-7591-48c1-9198-daca210bce9c"),
                ProductDetailId = new Guid("2eaaba04-80ff-43a6-a746-a74a91c7c0e2"),
                Name = "elbjgb-h2_01.jpg",
                Status = 0,
            },
            new ProductImage()
            {
                Id = new Guid("d5c65162-7591-48c1-9198-daca211bce0c"),
                ProductDetailId = new Guid("2eaaba04-80ff-43a6-a746-a74a91c7c0e2"),
                Name = "elbjgb-h1_01.jpg",
                Status = 0,
            },
            new ProductImage()
            {
                Id = new Guid("d5c65162-7591-48c1-9198-daca211bce1c"),
                ProductDetailId = new Guid("2eaaba04-80ff-43a6-a746-a74a91c7c0e2"),
                Name = "actxs-e_02_1_1.jpg",
                Status = 0,
            },
            new ProductImage()
            {
                Id = new Guid("d5c65162-7591-48c1-9198-daca211bce2c"),
                ProductDetailId = new Guid("2eaaba04-80ff-43a6-a746-a74a91c7c0e2"),
                Name = "actxs-q_02.jpg",
                Status = 0,
            },
            new ProductImage()
            {
                Id = new Guid("d5c65162-7591-48c1-9198-daca211bce3c"),
                ProductDetailId = new Guid("2eaaba04-80ff-43a6-a746-a74a91c7c0e3"),
                Name = "elbjgb_02.jpg",
                Status = 0,
            },
            new ProductImage()
            {
                Id = new Guid("d5c65162-7591-48c1-9198-daca211bce4c"),
                ProductDetailId = new Guid("2eaaba04-80ff-43a6-a746-a74a91c7c0e3"),
                Name = "elbjgb-h2_01.jpg",
                Status = 0,
            },
            new ProductImage()
            {
                Id = new Guid("d5c65162-7591-48c1-9198-daca211bce5c"),
                ProductDetailId = new Guid("2eaaba04-80ff-43a6-a746-a74a91c7c0e3"),
                Name = "elbjgb-h1_01.jpg",
                Status = 0,
            },
            new ProductImage()
            {
                Id = new Guid("d5c65162-7591-48c1-9198-daca211bce6c"),
                ProductDetailId = new Guid("2eaaba04-80ff-43a6-a746-a74a91c7c0e3"),
                Name = "actxs-e_02_1_1.jpg",
                Status = 0,
            },
            new ProductImage()
            {
                Id = new Guid("d5c65162-7591-48c1-9198-daca211bce7c"),
                ProductDetailId = new Guid("2eaaba04-80ff-43a6-a746-a74a91c7c0e3"),
                Name = "actxs-q_02.jpg",
                Status = 0,
            },
            new ProductImage()
            {
                Id = new Guid("d5c65162-7591-48c1-9198-daca211bce8c"),
                ProductDetailId = new Guid("2eaaba04-80ff-43a6-a746-a74a91c7c0e4"),
                Name = "elbjgb_02.jpg",
                Status = 0,
            },
            new ProductImage()
            {
                Id = new Guid("d5c65162-7591-48c1-9198-daca211bce9c"),
                ProductDetailId = new Guid("2eaaba04-80ff-43a6-a746-a74a91c7c0e4"),
                Name = "elbjgb-h2_01.jpg",
                Status = 0,
            },
            new ProductImage()
            {
                Id = new Guid("d5c65162-7591-48c1-9198-daca212bce0c"),
                ProductDetailId = new Guid("2eaaba04-80ff-43a6-a746-a74a91c7c0e4"),
                Name = "elbjgb-h1_01.jpg",
                Status = 0,
            },
            new ProductImage()
            {
                Id = new Guid("d5c65162-7591-48c1-9198-daca212bce1c"),
                ProductDetailId = new Guid("2eaaba04-80ff-43a6-a746-a74a91c7c0e4"),
                Name = "actxs-e_02_1_1.jpg",
                Status = 0,
            },
            new ProductImage()
            {
                Id = new Guid("d5c65162-7591-48c1-9198-daca212bce2c"),
                ProductDetailId = new Guid("2eaaba04-80ff-43a6-a746-a74a91c7c0e4"),
                Name = "actxs-q_02.jpg",
                Status = 0,
            },
            new ProductImage()
            {
                Id = new Guid("d5c65162-7591-48c1-9198-daca212bce3c"),
                ProductDetailId = new Guid("2eaaba04-80ff-43a6-a746-a74a91c7c0e5"),
                Name = "elbjgb_02.jpg",
                Status = 0,
            },
            new ProductImage()
            {
                Id = new Guid("d5c65162-7591-48c1-9198-daca212bce4c"),
                ProductDetailId = new Guid("2eaaba04-80ff-43a6-a746-a74a91c7c0e5"),
                Name = "elbjgb-h2_01.jpg",
                Status = 0,
            },
            new ProductImage()
            {
                Id = new Guid("d5c65162-7591-48c1-9198-daca212bce5c"),
                ProductDetailId = new Guid("2eaaba04-80ff-43a6-a746-a74a91c7c0e5"),
                Name = "elbjgb-h1_01.jpg",
                Status = 0,
            },
            new ProductImage()
            {
                Id = new Guid("d5c65162-7591-48c1-9198-daca212bce6c"),
                ProductDetailId = new Guid("2eaaba04-80ff-43a6-a746-a74a91c7c0e5"),
                Name = "actxs-e_02_1_1.jpg",
                Status = 0,
            },
            new ProductImage()
            {
                Id = new Guid("d5c65162-7591-48c1-9198-daca212bce7c"),
                ProductDetailId = new Guid("2eaaba04-80ff-43a6-a746-a74a91c7c0e5"),
                Name = "actxs-q_02.jpg",
                Status = 0,
            },
            new ProductImage()
            {
                Id = new Guid("d5c65162-7591-48c1-9198-daca212bce8c"),
                ProductDetailId = new Guid("2eaaba04-80ff-43a6-a746-a74a91c7c0e6"),
                Name = "elbjgb_02.jpg",
                Status = 0,
            },
            new ProductImage()
            {
                Id = new Guid("d5c65162-7591-48c1-9198-daca212bce9c"),
                ProductDetailId = new Guid("2eaaba04-80ff-43a6-a746-a74a91c7c0e6"),
                Name = "elbjgb-h2_01.jpg",
                Status = 0,
            },
            new ProductImage()
            {
                Id = new Guid("d5c65162-7591-48c1-9198-daca998bce0c"),
                ProductDetailId = new Guid("2eaaba04-80ff-43a6-a746-a74a91c7c0e6"),
                Name = "elbjgb-h1_01.jpg",
                Status = 0,
            },
            new ProductImage()
            {
                Id = new Guid("d5c65162-7591-48c1-9198-daca998bce1c"),
                ProductDetailId = new Guid("2eaaba04-80ff-43a6-a746-a74a91c7c0e6"),
                Name = "actxs-e_02_1_1.jpg",
                Status = 0,
            },
            new ProductImage()
            {
                Id = new Guid("d5c65162-7591-48c1-9198-daca998bce2c"),
                ProductDetailId = new Guid("2eaaba04-80ff-43a6-a746-a74a91c7c0e6"),
                Name = "actxs-q_02.jpg",
                Status = 0,
            },
            new ProductImage()
            {
                Id = new Guid("d5c65162-7591-48c1-9198-daca998bce3c"),
                ProductDetailId = new Guid("2eaaba04-80ff-43a6-a746-a74a91c7c0e7"),
                Name = "elbjgb_02.jpg",
                Status = 0,
            },
            new ProductImage()
            {
                Id = new Guid("d5c65162-7591-48c1-9198-daca998bce4c"),
                ProductDetailId = new Guid("2eaaba04-80ff-43a6-a746-a74a91c7c0e7"),
                Name = "elbjgb-h2_01.jpg",
                Status = 0,
            },
            new ProductImage()
            {
                Id = new Guid("d5c65162-7591-48c1-9198-daca998bce5c"),
                ProductDetailId = new Guid("2eaaba04-80ff-43a6-a746-a74a91c7c0e7"),
                Name = "elbjgb-h1_01.jpg",
                Status = 0,
            },
            new ProductImage()
            {
                Id = new Guid("d5c65162-7591-48c1-9198-daca998bce6c"),
                ProductDetailId = new Guid("2eaaba04-80ff-43a6-a746-a74a91c7c0e7"),
                Name = "actxs-e_02_1_1.jpg",
                Status = 0,
            },
            new ProductImage()
            {
                Id = new Guid("d5c65162-7591-48c1-9198-daca998bce7c"),
                ProductDetailId = new Guid("2eaaba04-80ff-43a6-a746-a74a91c7c0e7"),
                Name = "actxs-q_02.jpg",
                Status = 0,
            },
            new ProductImage()
            {
                Id = new Guid("d5c65162-7591-48c1-9198-daca998bce8c"),
                ProductDetailId = new Guid("2eaaba04-80ff-43a6-a746-a74a91c7c0e8"),
                Name = "elbjgb_02.jpg",
                Status = 0,
            },
            new ProductImage()
            {
                Id = new Guid("d5c65162-7591-48c1-9198-daca998bce9c"),
                ProductDetailId = new Guid("2eaaba04-80ff-43a6-a746-a74a91c7c0e8"),
                Name = "elbjgb-h2_01.jpg",
                Status = 0,
            },
            new ProductImage()
            {
                Id = new Guid("d5c65162-7591-48c1-9198-daca213bce0c"),
                ProductDetailId = new Guid("2eaaba04-80ff-43a6-a746-a74a91c7c0e8"),
                Name = "elbjgb-h1_01.jpg",
                Status = 0,
            },
            new ProductImage()
            {
                Id = new Guid("d5c65162-7591-48c1-9198-daca213bce1c"),
                ProductDetailId = new Guid("2eaaba04-80ff-43a6-a746-a74a91c7c0e8"),
                Name = "actxs-e_02_1_1.jpg",
                Status = 0,
            },
            new ProductImage()
            {
                Id = new Guid("d5c65162-7591-48c1-9198-daca213bce2c"),
                ProductDetailId = new Guid("2eaaba04-80ff-43a6-a746-a74a91c7c0e8"),
                Name = "actxs-q_02.jpg",
                Status = 0,
            },
            new ProductImage()
            {
                Id = new Guid("d5c65162-7591-48c1-9198-daca213bce3c"),
                ProductDetailId = new Guid("2eaaba04-80ff-43a6-a746-a74a91c7c0e9"),
                Name = "elbjgb_02.jpg",
                Status = 0,
            },
            new ProductImage()
            {
                Id = new Guid("d5c65162-7591-48c1-9198-daca213bce4c"),
                ProductDetailId = new Guid("2eaaba04-80ff-43a6-a746-a74a91c7c0e9"),
                Name = "elbjgb-h2_01.jpg",
                Status = 0,
            },
            new ProductImage()
            {
                Id = new Guid("d5c65162-7591-48c1-9198-daca213bce5c"),
                ProductDetailId = new Guid("2eaaba04-80ff-43a6-a746-a74a91c7c0e9"),
                Name = "elbjgb-h1_01.jpg",
                Status = 0,
            },
            new ProductImage()
            {
                Id = new Guid("d5c65162-7591-48c1-9198-daca213bce6c"),
                ProductDetailId = new Guid("2eaaba04-80ff-43a6-a746-a74a91c7c0e9"),
                Name = "actxs-e_02_1_1.jpg",
                Status = 0,
            },
            new ProductImage()
            {
                Id = new Guid("d5c65162-7591-48c1-9198-daca213bce7c"),
                ProductDetailId = new Guid("2eaaba04-80ff-43a6-a746-a74a91c7c0e9"),
                Name = "actxs-q_02.jpg",
                Status = 0,
            },
            new ProductImage()
            {
                Id = new Guid("d5c65162-7591-48c1-9198-daca213bce8c"),
                ProductDetailId = new Guid("2eaaba04-80ff-43a6-a746-a74a91c7c1e0"),
                Name = "elbjgb_02.jpg",
                Status = 0,
            },
            new ProductImage()
            {
                Id = new Guid("d5c65162-7591-48c1-9198-daca213bce9c"),
                ProductDetailId = new Guid("2eaaba04-80ff-43a6-a746-a74a91c7c1e0"),
                Name = "elbjgb-h2_01.jpg",
                Status = 0,
            },
            new ProductImage()
            {
                Id = new Guid("d5c65162-7591-48c1-9198-daca214bce0c"),
                ProductDetailId = new Guid("2eaaba04-80ff-43a6-a746-a74a91c7c1e0"),
                Name = "elbjgb-h1_01.jpg",
                Status = 0,
            },
            new ProductImage()
            {
                Id = new Guid("d5c65162-7591-48c1-9198-daca214bce1c"),
                ProductDetailId = new Guid("2eaaba04-80ff-43a6-a746-a74a91c7c1e0"),
                Name = "actxs-e_02_1_1.jpg",
                Status = 0,
            },
            new ProductImage()
            {
                Id = new Guid("d5c65162-7591-48c1-9198-daca214bce2c"),
                ProductDetailId = new Guid("2eaaba04-80ff-43a6-a746-a74a91c7c1e0"),
                Name = "actxs-q_02.jpg",
                Status = 0,
            },
            new ProductImage()
            {
                Id = new Guid("d5c65162-7591-48c1-9198-daca214bce3c"),
                ProductDetailId = new Guid("2eaaba04-80ff-43a6-a746-a74a91c7c1e1"),
                Name = "elbjgb_02.jpg",
                Status = 0,
            },
            new ProductImage()
            {
                Id = new Guid("d5c65162-7591-48c1-9198-daca214bce4c"),
                ProductDetailId = new Guid("2eaaba04-80ff-43a6-a746-a74a91c7c1e1"),
                Name = "elbjgb-h2_01.jpg",
                Status = 0,
            },
            new ProductImage()
            {
                Id = new Guid("d5c65162-7591-48c1-9198-daca214bce5c"),
                ProductDetailId = new Guid("2eaaba04-80ff-43a6-a746-a74a91c7c1e1"),
                Name = "elbjgb-h1_01.jpg",
                Status = 0,
            },
            new ProductImage()
            {
                Id = new Guid("d5c65162-7591-48c1-9198-daca214bce6c"),
                ProductDetailId = new Guid("2eaaba04-80ff-43a6-a746-a74a91c7c1e1"),
                Name = "actxs-e_02_1_1.jpg",
                Status = 0,
            },
            new ProductImage()
            {
                Id = new Guid("d5c65162-7591-48c1-9198-daca214bce7c"),
                ProductDetailId = new Guid("2eaaba04-80ff-43a6-a746-a74a91c7c1e1"),
                Name = "actxs-q_02.jpg",
                Status = 0,
            },
            new ProductImage()
            {
                Id = new Guid("d5c65162-7591-48c1-9198-daca214bce8c"),
                ProductDetailId = new Guid("2eaaba04-80ff-43a6-a746-a74a91c7c1e2"),
                Name = "elbjgb_02.jpg",
                Status = 0,
            },
            new ProductImage()
            {
                Id = new Guid("d5c65162-7591-48c1-9198-daca214bce9c"),
                ProductDetailId = new Guid("2eaaba04-80ff-43a6-a746-a74a91c7c1e2"),
                Name = "elbjgb-h2_01.jpg",
                Status = 0,
            },
            new ProductImage()
            {
                Id = new Guid("d5c65162-7591-48c1-9198-daca215bce0c"),
                ProductDetailId = new Guid("2eaaba04-80ff-43a6-a746-a74a91c7c1e2"),
                Name = "elbjgb-h1_01.jpg",
                Status = 0,
            },
            new ProductImage()
            {
                Id = new Guid("d5c65162-7591-48c1-9198-daca215bce1c"),
                ProductDetailId = new Guid("2eaaba04-80ff-43a6-a746-a74a91c7c1e2"),
                Name = "actxs-e_02_1_1.jpg",
                Status = 0,
            },
            new ProductImage()
            {
                Id = new Guid("d5c65162-7591-48c1-9198-daca215bce2c"),
                ProductDetailId = new Guid("2eaaba04-80ff-43a6-a746-a74a91c7c1e2"),
                Name = "actxs-q_02.jpg",
                Status = 0,
            },
            new ProductImage()
            {
                Id = new Guid("d5c65162-7591-48c1-9198-daca215bce3c"),
                ProductDetailId = new Guid("2eaaba04-80ff-43a6-a746-a74a91c7c1e3"),
                Name = "elbjgb_02.jpg",
                Status = 0,
            },
            new ProductImage()
            {
                Id = new Guid("d5c65162-7591-48c1-9198-daca215bce4c"),
                ProductDetailId = new Guid("2eaaba04-80ff-43a6-a746-a74a91c7c1e3"),
                Name = "elbjgb-h2_01.jpg",
                Status = 0,
            },
            new ProductImage()
            {
                Id = new Guid("d5c65162-7591-48c1-9198-daca215bce5c"),
                ProductDetailId = new Guid("2eaaba04-80ff-43a6-a746-a74a91c7c1e3"),
                Name = "elbjgb-h1_01.jpg",
                Status = 0,
            },
            new ProductImage()
            {
                Id = new Guid("d5c65162-7591-48c1-9198-daca215bce6c"),
                ProductDetailId = new Guid("2eaaba04-80ff-43a6-a746-a74a91c7c1e3"),
                Name = "actxs-e_02_1_1.jpg",
                Status = 0,
            },
            new ProductImage()
            {
                Id = new Guid("d5c65162-7591-48c1-9198-daca215bce7c"),
                ProductDetailId = new Guid("2eaaba04-80ff-43a6-a746-a74a91c7c1e3"),
                Name = "actxs-q_02.jpg",
                Status = 0,
            },
            new ProductImage()
            {
                Id = new Guid("d5c65162-7591-48c1-9198-daca215bce8c"),
                ProductDetailId = new Guid("2eaaba04-80ff-43a6-a746-a74a91c7c1e4"),
                Name = "elbjgb_02.jpg",
                Status = 0,
            },
            new ProductImage()
            {
                Id = new Guid("d5c65162-7591-48c1-9198-daca215bce9c"),
                ProductDetailId = new Guid("2eaaba04-80ff-43a6-a746-a74a91c7c1e4"),
                Name = "elbjgb-h2_01.jpg",
                Status = 0,
            },
            new ProductImage()
            {
                Id = new Guid("d5c65162-7591-48c1-9198-daca216bce0c"),
                ProductDetailId = new Guid("2eaaba04-80ff-43a6-a746-a74a91c7c1e4"),
                Name = "elbjgb-h1_01.jpg",
                Status = 0,
            },
            new ProductImage()
            {
                Id = new Guid("d5c65162-7591-48c1-9198-daca216bce1c"),
                ProductDetailId = new Guid("2eaaba04-80ff-43a6-a746-a74a91c7c1e4"),
                Name = "actxs-e_02_1_1.jpg",
                Status = 0,
            },
            new ProductImage()
            {
                Id = new Guid("d5c65162-7591-48c1-9198-daca216bce2c"),
                ProductDetailId = new Guid("2eaaba04-80ff-43a6-a746-a74a91c7c1e4"),
                Name = "actxs-q_02.jpg",
                Status = 0,
            },
            new ProductImage()
            {
                Id = new Guid("d5c65162-7591-48c1-9198-daca216bce3c"),
                ProductDetailId = new Guid("2eaaba04-80ff-43a6-a746-a74a91c7c1e5"),
                Name = "elbjgb_02.jpg",
                Status = 0,
            },
            new ProductImage()
            {
                Id = new Guid("d5c65162-7591-48c1-9198-daca216bce4c"),
                ProductDetailId = new Guid("2eaaba04-80ff-43a6-a746-a74a91c7c1e5"),
                Name = "elbjgb-h2_01.jpg",
                Status = 0,
            },
            new ProductImage()
            {
                Id = new Guid("d5c65162-7591-48c1-9198-daca216bce5c"),
                ProductDetailId = new Guid("2eaaba04-80ff-43a6-a746-a74a91c7c1e5"),
                Name = "elbjgb-h1_01.jpg",
                Status = 0,
            },
            new ProductImage()
            {
                Id = new Guid("d5c65162-7591-48c1-9198-daca216bce6c"),
                ProductDetailId = new Guid("2eaaba04-80ff-43a6-a746-a74a91c7c1e5"),
                Name = "actxs-e_02_1_1.jpg",
                Status = 0,
            },
            new ProductImage()
            {
                Id = new Guid("d5c65162-7591-48c1-9198-daca216bce7c"),
                ProductDetailId = new Guid("2eaaba04-80ff-43a6-a746-a74a91c7c1e5"),
                Name = "actxs-q_02.jpg",
                Status = 0,
            },
            new ProductImage()
            {
                Id = new Guid("d5c65162-7591-48c1-9198-daca216bce8c"),
                ProductDetailId = new Guid("2eaaba04-80ff-43a6-a746-a74a91c7c1e6"),
                Name = "elbjgb_02.jpg",
                Status = 0,
            },
            new ProductImage()
            {
                Id = new Guid("d5c65162-7591-48c1-9198-daca216bce9c"),
                ProductDetailId = new Guid("2eaaba04-80ff-43a6-a746-a74a91c7c1e6"),
                Name = "elbjgb-h2_01.jpg",
                Status = 0,
            },
            new ProductImage()
            {
                Id = new Guid("d5c65162-7591-48c1-9198-daca217bce0c"),
                ProductDetailId = new Guid("2eaaba04-80ff-43a6-a746-a74a91c7c1e6"),
                Name = "elbjgb-h1_01.jpg",
                Status = 0,
            },
            new ProductImage()
            {
                Id = new Guid("d5c65162-7591-48c1-9198-daca217bce1c"),
                ProductDetailId = new Guid("2eaaba04-80ff-43a6-a746-a74a91c7c1e6"),
                Name = "actxs-e_02_1_1.jpg",
                Status = 0,
            },
            new ProductImage()
            {
                Id = new Guid("d5c65162-7591-48c1-9198-daca217bce2c"),
                ProductDetailId = new Guid("2eaaba04-80ff-43a6-a746-a74a91c7c1e6"),
                Name = "actxs-q_02.jpg",
                Status = 0,
            },
            new ProductImage()
            {
                Id = new Guid("d5c65162-7591-48c1-9198-daca217bce3c"),
                ProductDetailId = new Guid("2eaaba04-80ff-43a6-a746-a74a91c7c1e7"),
                Name = "elbjgb_02.jpg",
                Status = 0,
            },
            new ProductImage()
            {
                Id = new Guid("d5c65162-7591-48c1-9198-daca217bce4c"),
                ProductDetailId = new Guid("2eaaba04-80ff-43a6-a746-a74a91c7c1e7"),
                Name = "elbjgb-h2_01.jpg",
                Status = 0,
            },
            new ProductImage()
            {
                Id = new Guid("d5c65162-7591-48c1-9198-daca217bce5c"),
                ProductDetailId = new Guid("2eaaba04-80ff-43a6-a746-a74a91c7c1e7"),
                Name = "elbjgb-h1_01.jpg",
                Status = 0,
            },
            new ProductImage()
            {
                Id = new Guid("d5c65162-7591-48c1-9198-daca217bce6c"),
                ProductDetailId = new Guid("2eaaba04-80ff-43a6-a746-a74a91c7c1e7"),
                Name = "actxs-e_02_1_1.jpg",
                Status = 0,
            },
            new ProductImage()
            {
                Id = new Guid("d5c65162-7591-48c1-9198-daca217bce7c"),
                ProductDetailId = new Guid("2eaaba04-80ff-43a6-a746-a74a91c7c1e7"),
                Name = "actxs-q_02.jpg",
                Status = 0,
            },
            new ProductImage()
            {
                Id = new Guid("d5c65162-7591-48c1-9198-daca217bce8c"),
                ProductDetailId = new Guid("2eaaba04-80ff-43a6-a746-a74a91c7c1e8"),
                Name = "elbjgb_02.jpg",
                Status = 0,
            },
            new ProductImage()
            {
                Id = new Guid("d5c65162-7591-48c1-9198-daca217bce9c"),
                ProductDetailId = new Guid("2eaaba04-80ff-43a6-a746-a74a91c7c1e8"),
                Name = "elbjgb-h2_01.jpg",
                Status = 0,
            },
            new ProductImage()
            {
                Id = new Guid("d5c65162-7591-48c1-9198-daca218bce0c"),
                ProductDetailId = new Guid("2eaaba04-80ff-43a6-a746-a74a91c7c1e8"),
                Name = "elbjgb-h1_01.jpg",
                Status = 0,
            },
            new ProductImage()
            {
                Id = new Guid("d5c65162-7591-48c1-9198-daca218bce1c"),
                ProductDetailId = new Guid("2eaaba04-80ff-43a6-a746-a74a91c7c1e8"),
                Name = "actxs-e_02_1_1.jpg",
                Status = 0,
            },
            new ProductImage()
            {
                Id = new Guid("d5c65162-7591-48c1-9198-daca218bce2c"),
                ProductDetailId = new Guid("2eaaba04-80ff-43a6-a746-a74a91c7c1e8"),
                Name = "actxs-q_02.jpg",
                Status = 0,
            },
            new ProductImage()
            {
                Id = new Guid("d5c65162-7591-48c1-9198-daca218bce3c"),
                ProductDetailId = new Guid("2eaaba04-80ff-43a6-a746-a74a91c7c1e9"),
                Name = "elbjgb_02.jpg",
                Status = 0,
            },
            new ProductImage()
            {
                Id = new Guid("d5c65162-7591-48c1-9198-daca218bce4c"),
                ProductDetailId = new Guid("2eaaba04-80ff-43a6-a746-a74a91c7c1e9"),
                Name = "elbjgb-h2_01.jpg",
                Status = 0,
            },
            new ProductImage()
            {
                Id = new Guid("d5c65162-7591-48c1-9198-daca218bce5c"),
                ProductDetailId = new Guid("2eaaba04-80ff-43a6-a746-a74a91c7c1e9"),
                Name = "elbjgb-h1_01.jpg",
                Status = 0,
            },
            new ProductImage()
            {
                Id = new Guid("d5c65162-7591-48c1-9198-daca218bce6c"),
                ProductDetailId = new Guid("2eaaba04-80ff-43a6-a746-a74a91c7c1e9"),
                Name = "actxs-e_02_1_1.jpg",
                Status = 0,
            },
            new ProductImage()
            {
                Id = new Guid("d5c65162-7591-48c1-9198-daca218bce7c"),
                ProductDetailId = new Guid("2eaaba04-80ff-43a6-a746-a74a91c7c1e9"),
                Name = "actxs-q_02.jpg",
                Status = 0,
            },
            new ProductImage()
            {
                Id = new Guid("d5c65162-7591-48c1-9198-daca218bce8c"),
                ProductDetailId = new Guid("2eaaba04-80ff-43a6-a746-a74a91c7c2e0"),
                Name = "elbjgb_02.jpg",
                Status = 0,
            },
            new ProductImage()
            {
                Id = new Guid("d5c65162-7591-48c1-9198-daca218bce9c"),
                ProductDetailId = new Guid("2eaaba04-80ff-43a6-a746-a74a91c7c2e0"),
                Name = "elbjgb-h2_01.jpg",
                Status = 0,
            },
            new ProductImage()
            {
                Id = new Guid("d5c65162-7591-48c1-9198-daca219bce0c"),
                ProductDetailId = new Guid("2eaaba04-80ff-43a6-a746-a74a91c7c2e0"),
                Name = "elbjgb-h1_01.jpg",
                Status = 0,
            },
            new ProductImage()
            {
                Id = new Guid("d5c65162-7591-48c1-9198-daca219bce1c"),
                ProductDetailId = new Guid("2eaaba04-80ff-43a6-a746-a74a91c7c2e0"),
                Name = "actxs-e_02_1_1.jpg",
                Status = 0,
            },
            new ProductImage()
            {
                Id = new Guid("d5c65162-7591-48c1-9198-daca219bce2c"),
                ProductDetailId = new Guid("2eaaba04-80ff-43a6-a746-a74a91c7c2e0"),
                Name = "actxs-q_02.jpg",
                Status = 0,
            },
            new ProductImage()
            {
                Id = new Guid("d5c65162-7591-48c1-9198-daca219bce3c"),
                ProductDetailId = new Guid("2eaaba04-80ff-43a6-a746-a74a91c7c2e1"),
                Name = "elbjgb_02.jpg",
                Status = 0,
            },
            new ProductImage()
            {
                Id = new Guid("d5c65162-7591-48c1-9198-daca219bce4c"),
                ProductDetailId = new Guid("2eaaba04-80ff-43a6-a746-a74a91c7c2e1"),
                Name = "elbjgb-h2_01.jpg",
                Status = 0,
            },
            new ProductImage()
            {
                Id = new Guid("d5c65162-7591-48c1-9198-daca219bce5c"),
                ProductDetailId = new Guid("2eaaba04-80ff-43a6-a746-a74a91c7c2e1"),
                Name = "elbjgb-h1_01.jpg",
                Status = 0,
            },
            new ProductImage()
            {
                Id = new Guid("d5c65162-7591-48c1-9198-daca219bce6c"),
                ProductDetailId = new Guid("2eaaba04-80ff-43a6-a746-a74a91c7c2e1"),
                Name = "actxs-e_02_1_1.jpg",
                Status = 0,
            },
            new ProductImage()
            {
                Id = new Guid("d5c65162-7591-48c1-9198-daca219bce7c"),
                ProductDetailId = new Guid("2eaaba04-80ff-43a6-a746-a74a91c7c2e1"),
                Name = "actxs-q_02.jpg",
                Status = 0,
            },
            new ProductImage()
            {
                Id = new Guid("d5c65162-7591-48c1-9198-daca219bce8c"),
                ProductDetailId = new Guid("2eaaba04-80ff-43a6-a746-a74a91c7c2e2"),
                Name = "elbjgb_02.jpg",
                Status = 0,
            },
            new ProductImage()
            {
                Id = new Guid("d5c65162-7591-48c1-9198-daca219bce9c"),
                ProductDetailId = new Guid("2eaaba04-80ff-43a6-a746-a74a91c7c2e2"),
                Name = "elbjgb-h2_01.jpg",
                Status = 0,
            },
            new ProductImage()
            {
                Id = new Guid("d5c65162-7591-48c1-9198-daca220bce0c"),
                ProductDetailId = new Guid("2eaaba04-80ff-43a6-a746-a74a91c7c2e2"),
                Name = "elbjgb-h1_01.jpg",
                Status = 0,
            },
            new ProductImage()
            {
                Id = new Guid("d5c65162-7591-48c1-9198-daca220bce1c"),
                ProductDetailId = new Guid("2eaaba04-80ff-43a6-a746-a74a91c7c2e2"),
                Name = "actxs-e_02_1_1.jpg",
                Status = 0,
            },
            new ProductImage()
            {
                Id = new Guid("d5c65162-7591-48c1-9198-daca220bce2c"),
                ProductDetailId = new Guid("2eaaba04-80ff-43a6-a746-a74a91c7c2e2"),
                Name = "actxs-q_02.jpg",
                Status = 0,
            },
            new ProductImage()
            {
                Id = new Guid("d5c65162-7591-48c1-9198-daca220bce3c"),
                ProductDetailId = new Guid("2eaaba04-80ff-43a6-a746-a74a91c7c2e3"),
                Name = "elbjgb_02.jpg",
                Status = 0,
            },
            new ProductImage()
            {
                Id = new Guid("d5c65162-7591-48c1-9198-daca220bce4c"),
                ProductDetailId = new Guid("2eaaba04-80ff-43a6-a746-a74a91c7c2e3"),
                Name = "elbjgb-h2_01.jpg",
                Status = 0,
            },
            new ProductImage()
            {
                Id = new Guid("d5c65162-7591-48c1-9198-daca220bce5c"),
                ProductDetailId = new Guid("2eaaba04-80ff-43a6-a746-a74a91c7c2e3"),
                Name = "elbjgb-h1_01.jpg",
                Status = 0,
            },
            new ProductImage()
            {
                Id = new Guid("d5c65162-7591-48c1-9198-daca220bce6c"),
                ProductDetailId = new Guid("2eaaba04-80ff-43a6-a746-a74a91c7c2e3"),
                Name = "actxs-e_02_1_1.jpg",
                Status = 0,
            },
            new ProductImage()
            {
                Id = new Guid("d5c65162-7591-48c1-9198-daca220bce7c"),
                ProductDetailId = new Guid("2eaaba04-80ff-43a6-a746-a74a91c7c2e3"),
                Name = "actxs-q_02.jpg",
                Status = 0,
            },
            new ProductImage()
            {
                Id = new Guid("d5c65162-7591-48c1-9198-daca220bce8c"),
                ProductDetailId = new Guid("2eaaba04-80ff-43a6-a746-a74a91c7c2e4"),
                Name = "elbjgb_02.jpg",
                Status = 0,
            },
            new ProductImage()
            {
                Id = new Guid("d5c65162-7591-48c1-9198-daca220bce9c"),
                ProductDetailId = new Guid("2eaaba04-80ff-43a6-a746-a74a91c7c2e4"),
                Name = "elbjgb-h2_01.jpg",
                Status = 0,
            },
            new ProductImage()
            {
                Id = new Guid("d5c65162-7591-48c1-9198-daca221bce0c"),
                ProductDetailId = new Guid("2eaaba04-80ff-43a6-a746-a74a91c7c2e4"),
                Name = "elbjgb-h1_01.jpg",
                Status = 0,
            },
            new ProductImage()
            {
                Id = new Guid("d5c65162-7591-48c1-9198-daca221bce1c"),
                ProductDetailId = new Guid("2eaaba04-80ff-43a6-a746-a74a91c7c2e4"),
                Name = "actxs-e_02_1_1.jpg",
                Status = 0,
            },
            new ProductImage()
            {
                Id = new Guid("d5c65162-7591-48c1-9198-daca221bce2c"),
                ProductDetailId = new Guid("2eaaba04-80ff-43a6-a746-a74a91c7c2e4"),
                Name = "actxs-q_02.jpg",
                Status = 0,
            },
            new ProductImage()
            {
                Id = new Guid("d5c65162-7591-48c1-9198-daca221bce3c"),
                ProductDetailId = new Guid("2eaaba04-80ff-43a6-a746-a74a91c7c2e5"),
                Name = "elbjgb_02.jpg",
                Status = 0,
            },
            new ProductImage()
            {
                Id = new Guid("d5c65162-7591-48c1-9198-daca221bce4c"),
                ProductDetailId = new Guid("2eaaba04-80ff-43a6-a746-a74a91c7c2e5"),
                Name = "elbjgb-h2_01.jpg",
                Status = 0,
            },
            new ProductImage()
            {
                Id = new Guid("d5c65162-7591-48c1-9198-daca221bce5c"),
                ProductDetailId = new Guid("2eaaba04-80ff-43a6-a746-a74a91c7c2e5"),
                Name = "elbjgb-h1_01.jpg",
                Status = 0,
            },
            new ProductImage()
            {
                Id = new Guid("d5c65162-7591-48c1-9198-daca221bce6c"),
                ProductDetailId = new Guid("2eaaba04-80ff-43a6-a746-a74a91c7c2e5"),
                Name = "actxs-e_02_1_1.jpg",
                Status = 0,
            },
            new ProductImage()
            {
                Id = new Guid("d5c65162-7591-48c1-9198-daca221bce7c"),
                ProductDetailId = new Guid("2eaaba04-80ff-43a6-a746-a74a91c7c2e5"),
                Name = "actxs-q_02.jpg",
                Status = 0,
            },
            new ProductImage()
            {
                Id = new Guid("d5c65162-7591-48c1-9198-daca221bce8c"),
                ProductDetailId = new Guid("2eaaba04-80ff-43a6-a746-a74a91c7c2e6"),
                Name = "elbjgb_02.jpg",
                Status = 0,
            },
            new ProductImage()
            {
                Id = new Guid("d5c65162-7591-48c1-9198-daca221bce9c"),
                ProductDetailId = new Guid("2eaaba04-80ff-43a6-a746-a74a91c7c2e6"),
                Name = "elbjgb-h2_01.jpg",
                Status = 0,
            },
            new ProductImage()
            {
                Id = new Guid("d5c65162-7591-48c1-9198-daca222bce0c"),
                ProductDetailId = new Guid("2eaaba04-80ff-43a6-a746-a74a91c7c2e6"),
                Name = "elbjgb-h1_01.jpg",
                Status = 0,
            },
            new ProductImage()
            {
                Id = new Guid("d5c65162-7591-48c1-9198-daca222bce1c"),
                ProductDetailId = new Guid("2eaaba04-80ff-43a6-a746-a74a91c7c2e6"),
                Name = "actxs-e_02_1_1.jpg",
                Status = 0,
            },
            new ProductImage()
            {
                Id = new Guid("d5c65162-7591-48c1-9198-daca222bce2c"),
                ProductDetailId = new Guid("2eaaba04-80ff-43a6-a746-a74a91c7c2e6"),
                Name = "actxs-q_02.jpg",
                Status = 0,
            },
            new ProductImage()
            {
                Id = new Guid("d5c65162-7591-48c1-9198-daca222bce3c"),
                ProductDetailId = new Guid("2eaaba04-80ff-43a6-a746-a74a91c7c2e7"),
                Name = "elbjgb_02.jpg",
                Status = 0,
            },
            new ProductImage()
            {
                Id = new Guid("d5c65162-7591-48c1-9198-daca222bce4c"),
                ProductDetailId = new Guid("2eaaba04-80ff-43a6-a746-a74a91c7c2e7"),
                Name = "elbjgb-h2_01.jpg",
                Status = 0,
            },
            new ProductImage()
            {
                Id = new Guid("d5c65162-7591-48c1-9198-daca222bce5c"),
                ProductDetailId = new Guid("2eaaba04-80ff-43a6-a746-a74a91c7c2e7"),
                Name = "elbjgb-h1_01.jpg",
                Status = 0,
            },
            new ProductImage()
            {
                Id = new Guid("d5c65162-7591-48c1-9198-daca222bce6c"),
                ProductDetailId = new Guid("2eaaba04-80ff-43a6-a746-a74a91c7c2e7"),
                Name = "actxs-e_02_1_1.jpg",
                Status = 0,
            },
            new ProductImage()
            {
                Id = new Guid("d5c65162-7591-48c1-9198-daca222bce7c"),
                ProductDetailId = new Guid("2eaaba04-80ff-43a6-a746-a74a91c7c2e7"),
                Name = "actxs-q_02.jpg",
                Status = 0,
            },
            new ProductImage()
            {
                Id = new Guid("d5c65162-7591-48c1-9198-daca222bce8c"),
                ProductDetailId = new Guid("2eaaba04-80ff-43a6-a746-a74a91c7c2e8"),
                Name = "elbjgb_02.jpg",
                Status = 0,
            },
            new ProductImage()
            {
                Id = new Guid("d5c65162-7591-48c1-9198-daca222bce9c"),
                ProductDetailId = new Guid("2eaaba04-80ff-43a6-a746-a74a91c7c2e8"),
                Name = "elbjgb-h2_01.jpg",
                Status = 0,
            },
            new ProductImage()
            {
                Id = new Guid("d5c65162-7591-48c1-9198-daca223bce0c"),
                ProductDetailId = new Guid("2eaaba04-80ff-43a6-a746-a74a91c7c2e8"),
                Name = "elbjgb-h1_01.jpg",
                Status = 0,
            },
            new ProductImage()
            {
                Id = new Guid("d5c65162-7591-48c1-9198-daca223bce1c"),
                ProductDetailId = new Guid("2eaaba04-80ff-43a6-a746-a74a91c7c2e8"),
                Name = "actxs-e_02_1_1.jpg",
                Status = 0,
            },
            new ProductImage()
            {
                Id = new Guid("d5c65162-7591-48c1-9198-daca223bce2c"),
                ProductDetailId = new Guid("2eaaba04-80ff-43a6-a746-a74a91c7c2e8"),
                Name = "actxs-q_02.jpg",
                Status = 0,
            },
            new ProductImage()
            {
                Id = new Guid("d5c65162-7591-48c1-9198-daca223bce3c"),
                ProductDetailId = new Guid("2eaaba04-80ff-43a6-a746-a74a91c7c2e9"),
                Name = "elbjgb_02.jpg",
                Status = 0,
            },
            new ProductImage()
            {
                Id = new Guid("d5c65162-7591-48c1-9198-daca223bce4c"),
                ProductDetailId = new Guid("2eaaba04-80ff-43a6-a746-a74a91c7c2e9"),
                Name = "elbjgb-h2_01.jpg",
                Status = 0,
            },
            new ProductImage()
            {
                Id = new Guid("d5c65162-7591-48c1-9198-daca223bce5c"),
                ProductDetailId = new Guid("2eaaba04-80ff-43a6-a746-a74a91c7c2e9"),
                Name = "elbjgb-h1_01.jpg",
                Status = 0,
            },
            new ProductImage()
            {
                Id = new Guid("d5c65162-7591-48c1-9198-daca223bce6c"),
                ProductDetailId = new Guid("2eaaba04-80ff-43a6-a746-a74a91c7c2e9"),
                Name = "actxs-e_02_1_1.jpg",
                Status = 0,
            },
            new ProductImage()
            {
                Id = new Guid("d5c65162-7591-48c1-9198-daca223bce7c"),
                ProductDetailId = new Guid("2eaaba04-80ff-43a6-a746-a74a91c7c2e9"),
                Name = "actxs-q_02.jpg",
                Status = 0,
            },
            new ProductImage()
            {
                Id = new Guid("d5c65162-7591-48c1-9198-daca223bce8c"),
                ProductDetailId = new Guid("2eaaba04-80ff-43a6-a746-a74a91c7c3e0"),
                Name = "elbjgb_02.jpg",
                Status = 0,
            },
            new ProductImage()
            {
                Id = new Guid("d5c65162-7591-48c1-9198-daca223bce9c"),
                ProductDetailId = new Guid("2eaaba04-80ff-43a6-a746-a74a91c7c3e0"),
                Name = "elbjgb-h2_01.jpg",
                Status = 0,
            },
            new ProductImage()
            {
                Id = new Guid("d5c65162-7591-48c1-9198-daca224bce0c"),
                ProductDetailId = new Guid("2eaaba04-80ff-43a6-a746-a74a91c7c3e0"),
                Name = "elbjgb-h1_01.jpg",
                Status = 0,
            },
            new ProductImage()
            {
                Id = new Guid("d5c65162-7591-48c1-9198-daca224bce1c"),
                ProductDetailId = new Guid("2eaaba04-80ff-43a6-a746-a74a91c7c3e0"),
                Name = "actxs-e_02_1_1.jpg",
                Status = 0,
            },
            new ProductImage()
            {
                Id = new Guid("d5c65162-7591-48c1-9198-daca224bce2c"),
                ProductDetailId = new Guid("2eaaba04-80ff-43a6-a746-a74a91c7c3e0"),
                Name = "actxs-q_02.jpg",
                Status = 0,
            },
            new ProductImage()
            {
                Id = new Guid("d5c65162-7591-48c1-9198-daca224bce3c"),
                ProductDetailId = new Guid("2eaaba04-80ff-43a6-a746-a74a91c7c3e1"),
                Name = "elbjgb_02.jpg",
                Status = 0,
            },
            new ProductImage()
            {
                Id = new Guid("d5c65162-7591-48c1-9198-daca224bce4c"),
                ProductDetailId = new Guid("2eaaba04-80ff-43a6-a746-a74a91c7c3e1"),
                Name = "elbjgb-h2_01.jpg",
                Status = 0,
            },
            new ProductImage()
            {
                Id = new Guid("d5c65162-7591-48c1-9198-daca224bce5c"),
                ProductDetailId = new Guid("2eaaba04-80ff-43a6-a746-a74a91c7c3e1"),
                Name = "elbjgb-h1_01.jpg",
                Status = 0,
            },
            new ProductImage()
            {
                Id = new Guid("d5c65162-7591-48c1-9198-daca224bce6c"),
                ProductDetailId = new Guid("2eaaba04-80ff-43a6-a746-a74a91c7c3e1"),
                Name = "actxs-e_02_1_1.jpg",
                Status = 0,
            },
            new ProductImage()
            {
                Id = new Guid("d5c65162-7591-48c1-9198-daca224bce7c"),
                ProductDetailId = new Guid("2eaaba04-80ff-43a6-a746-a74a91c7c3e1"),
                Name = "actxs-q_02.jpg",
                Status = 0,
            },
            new ProductImage()
            {
                Id = new Guid("d5c65162-7591-48c1-9198-daca224bce8c"),
                ProductDetailId = new Guid("2eaaba04-80ff-43a6-a746-a74a91c7c3e2"),
                Name = "elbjgb_02.jpg",
                Status = 0,
            },
            new ProductImage()
            {
                Id = new Guid("d5c65162-7591-48c1-9198-daca224bce9c"),
                ProductDetailId = new Guid("2eaaba04-80ff-43a6-a746-a74a91c7c3e2"),
                Name = "elbjgb-h2_01.jpg",
                Status = 0,
            },
            new ProductImage()
            {
                Id = new Guid("d5c65162-7591-48c1-9198-daca255bce0c"),
                ProductDetailId = new Guid("2eaaba04-80ff-43a6-a746-a74a91c7c3e2"),
                Name = "elbjgb-h1_01.jpg",
                Status = 0,
            },
            new ProductImage()
            {
                Id = new Guid("d5c65162-7591-48c1-9198-daca255bce1c"),
                ProductDetailId = new Guid("2eaaba04-80ff-43a6-a746-a74a91c7c3e2"),
                Name = "actxs-e_02_1_1.jpg",
                Status = 0,
            },
            new ProductImage()
            {
                Id = new Guid("d5c65162-7591-48c1-9198-daca255bce2c"),
                ProductDetailId = new Guid("2eaaba04-80ff-43a6-a746-a74a91c7c3e2"),
                Name = "actxs-q_02.jpg",
                Status = 0,
            },
            new ProductImage()
            {
                Id = new Guid("d5c65162-7591-48c1-9198-daca255bce3c"),
                ProductDetailId = new Guid("2eaaba04-80ff-43a6-a746-a74a91c7c3e3"),
                Name = "elbjgb_02.jpg",
                Status = 0,
            },
            new ProductImage()
            {
                Id = new Guid("d5c65162-7591-48c1-9198-daca255bce4c"),
                ProductDetailId = new Guid("2eaaba04-80ff-43a6-a746-a74a91c7c3e3"),
                Name = "elbjgb-h2_01.jpg",
                Status = 0,
            },
            new ProductImage()
            {
                Id = new Guid("d5c65162-7591-48c1-9198-daca255bce5c"),
                ProductDetailId = new Guid("2eaaba04-80ff-43a6-a746-a74a91c7c3e3"),
                Name = "elbjgb-h1_01.jpg",
                Status = 0,
            },
            new ProductImage()
            {
                Id = new Guid("d5c65162-7591-48c1-9198-daca255bce6c"),
                ProductDetailId = new Guid("2eaaba04-80ff-43a6-a746-a74a91c7c3e3"),
                Name = "actxs-e_02_1_1.jpg",
                Status = 0,
            },
            new ProductImage()
            {
                Id = new Guid("d5c65162-7591-48c1-9198-daca255bce7c"),
                ProductDetailId = new Guid("2eaaba04-80ff-43a6-a746-a74a91c7c3e3"),
                Name = "actxs-q_02.jpg",
                Status = 0,
            },
            new ProductImage()
            {
                Id = new Guid("d5c65162-7591-48c1-9198-daca255bce8c"),
                ProductDetailId = new Guid("2eaaba04-80ff-43a6-a746-a74a91c7c3e4"),
                Name = "elbjgb_02.jpg",
                Status = 0,
            },
            new ProductImage()
            {
                Id = new Guid("d5c65162-7591-48c1-9198-daca255bce9c"),
                ProductDetailId = new Guid("2eaaba04-80ff-43a6-a746-a74a91c7c3e4"),
                Name = "elbjgb-h2_01.jpg",
                Status = 0,
            },
            new ProductImage()
            {
                Id = new Guid("d5c65162-7591-48c1-9198-daca256bce0c"),
                ProductDetailId = new Guid("2eaaba04-80ff-43a6-a746-a74a91c7c3e4"),
                Name = "elbjgb-h1_01.jpg",
                Status = 0,
            },
            new ProductImage()
            {
                Id = new Guid("d5c65162-7591-48c1-9198-daca256bce1c"),
                ProductDetailId = new Guid("2eaaba04-80ff-43a6-a746-a74a91c7c3e4"),
                Name = "actxs-e_02_1_1.jpg",
                Status = 0,
            },
            new ProductImage()
            {
                Id = new Guid("d5c65162-7591-48c1-9198-daca256bce2c"),
                ProductDetailId = new Guid("2eaaba04-80ff-43a6-a746-a74a91c7c3e4"),
                Name = "actxs-q_02.jpg",
                Status = 0,
            },
            new ProductImage()
            {
                Id = new Guid("d5c65162-7591-48c1-9198-daca256bce3c"),
                ProductDetailId = new Guid("2eaaba04-80ff-43a6-a746-a74a91c7c3e5"),
                Name = "elbjgb_02.jpg",
                Status = 0,
            },
            new ProductImage()
            {
                Id = new Guid("d5c65162-7591-48c1-9198-daca256bce4c"),
                ProductDetailId = new Guid("2eaaba04-80ff-43a6-a746-a74a91c7c3e5"),
                Name = "elbjgb-h2_01.jpg",
                Status = 0,
            },
            new ProductImage()
            {
                Id = new Guid("d5c65162-7591-48c1-9198-daca256bce5c"),
                ProductDetailId = new Guid("2eaaba04-80ff-43a6-a746-a74a91c7c3e5"),
                Name = "elbjgb-h1_01.jpg",
                Status = 0,
            },
            new ProductImage()
            {
                Id = new Guid("d5c65162-7591-48c1-9198-daca256bce6c"),
                ProductDetailId = new Guid("2eaaba04-80ff-43a6-a746-a74a91c7c3e5"),
                Name = "actxs-e_02_1_1.jpg",
                Status = 0,
            },
            new ProductImage()
            {
                Id = new Guid("d5c65162-7591-48c1-9198-daca256bce7c"),
                ProductDetailId = new Guid("2eaaba04-80ff-43a6-a746-a74a91c7c3e5"),
                Name = "actxs-q_02.jpg",
                Status = 0,
            },
            new ProductImage()
            {
                Id = new Guid("d5c65162-7591-48c1-9198-daca256bce8c"),
                ProductDetailId = new Guid("2eaaba04-80ff-43a6-a746-a74a91c7c3e6"),
                Name = "elbjgb_02.jpg",
                Status = 0,
            },
            new ProductImage()
            {
                Id = new Guid("d5c65162-7591-48c1-9198-daca256bce9c"),
                ProductDetailId = new Guid("2eaaba04-80ff-43a6-a746-a74a91c7c3e6"),
                Name = "elbjgb-h2_01.jpg",
                Status = 0,
            },
            new ProductImage()
            {
                Id = new Guid("d5c65162-7591-48c1-9198-daca257bce0c"),
                ProductDetailId = new Guid("2eaaba04-80ff-43a6-a746-a74a91c7c3e6"),
                Name = "elbjgb-h1_01.jpg",
                Status = 0,
            },
            new ProductImage()
            {
                Id = new Guid("d5c65162-7591-48c1-9198-daca257bce1c"),
                ProductDetailId = new Guid("2eaaba04-80ff-43a6-a746-a74a91c7c3e6"),
                Name = "actxs-e_02_1_1.jpg",
                Status = 0,
            },
            new ProductImage()
            {
                Id = new Guid("d5c65162-7591-48c1-9198-daca257bce2c"),
                ProductDetailId = new Guid("2eaaba04-80ff-43a6-a746-a74a91c7c3e6"),
                Name = "actxs-q_02.jpg",
                Status = 0,
            },
            new ProductImage()
            {
                Id = new Guid("d5c65162-7591-48c1-9198-daca257bce3c"),
                ProductDetailId = new Guid("2eaaba04-80ff-43a6-a746-a74a91c7c3e7"),
                Name = "elbjgb_02.jpg",
                Status = 0,
            },
            new ProductImage()
            {
                Id = new Guid("d5c65162-7591-48c1-9198-daca257bce4c"),
                ProductDetailId = new Guid("2eaaba04-80ff-43a6-a746-a74a91c7c3e7"),
                Name = "elbjgb-h2_01.jpg",
                Status = 0,
            },
            new ProductImage()
            {
                Id = new Guid("d5c65162-7591-48c1-9198-daca257bce5c"),
                ProductDetailId = new Guid("2eaaba04-80ff-43a6-a746-a74a91c7c3e7"),
                Name = "elbjgb-h1_01.jpg",
                Status = 0,
            },
            new ProductImage()
            {
                Id = new Guid("d5c65162-7591-48c1-9198-daca257bce6c"),
                ProductDetailId = new Guid("2eaaba04-80ff-43a6-a746-a74a91c7c3e7"),
                Name = "actxs-e_02_1_1.jpg",
                Status = 0,
            },
            new ProductImage()
            {
                Id = new Guid("d5c65162-7591-48c1-9198-daca257bce7c"),
                ProductDetailId = new Guid("2eaaba04-80ff-43a6-a746-a74a91c7c3e7"),
                Name = "actxs-q_02.jpg",
                Status = 0,
            },
            new ProductImage()
            {
                Id = new Guid("d5c65162-7591-48c1-9198-daca257bce8c"),
                ProductDetailId = new Guid("2eaaba04-80ff-43a6-a746-a74a91c7c3e8"),
                Name = "elbjgb_02.jpg",
                Status = 0,
            },
            new ProductImage()
            {
                Id = new Guid("d5c65162-7591-48c1-9198-daca257bce9c"),
                ProductDetailId = new Guid("2eaaba04-80ff-43a6-a746-a74a91c7c3e8"),
                Name = "elbjgb-h2_01.jpg",
                Status = 0,
            },
            new ProductImage()
            {
                Id = new Guid("d5c65162-7591-48c1-9198-daca258bce0c"),
                ProductDetailId = new Guid("2eaaba04-80ff-43a6-a746-a74a91c7c3e8"),
                Name = "elbjgb-h1_01.jpg",
                Status = 0,
            },
            new ProductImage()
            {
                Id = new Guid("d5c65162-7591-48c1-9198-daca258bce1c"),
                ProductDetailId = new Guid("2eaaba04-80ff-43a6-a746-a74a91c7c3e8"),
                Name = "actxs-e_02_1_1.jpg",
                Status = 0,
            },
            new ProductImage()
            {
                Id = new Guid("d5c65162-7591-48c1-9198-daca258bce2c"),
                ProductDetailId = new Guid("2eaaba04-80ff-43a6-a746-a74a91c7c3e8"),
                Name = "actxs-q_02.jpg",
                Status = 0,
            },
            new ProductImage()
            {
                Id = new Guid("d5c65162-7591-48c1-9198-daca258bce3c"),
                ProductDetailId = new Guid("2eaaba04-80ff-43a6-a746-a74a91c7c3e9"),
                Name = "elbjgb_02.jpg",
                Status = 0,
            },
            new ProductImage()
            {
                Id = new Guid("d5c65162-7591-48c1-9198-daca258bce4c"),
                ProductDetailId = new Guid("2eaaba04-80ff-43a6-a746-a74a91c7c3e9"),
                Name = "elbjgb-h2_01.jpg",
                Status = 0,
            },
            new ProductImage()
            {
                Id = new Guid("d5c65162-7591-48c1-9198-daca258bce5c"),
                ProductDetailId = new Guid("2eaaba04-80ff-43a6-a746-a74a91c7c3e9"),
                Name = "elbjgb-h1_01.jpg",
                Status = 0,
            },
            new ProductImage()
            {
                Id = new Guid("d5c65162-7591-48c1-9198-daca258bce6c"),
                ProductDetailId = new Guid("2eaaba04-80ff-43a6-a746-a74a91c7c3e9"),
                Name = "actxs-e_02_1_1.jpg",
                Status = 0,
            },
            new ProductImage()
            {
                Id = new Guid("d5c65162-7591-48c1-9198-daca258bce7c"),
                ProductDetailId = new Guid("2eaaba04-80ff-43a6-a746-a74a91c7c3e9"),
                Name = "actxs-q_02.jpg",
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
                    EmployeeId = new Guid("dbca0788-4fb0-4986-8928-4df593da3f5e"),
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
                    EmployeeId = new Guid("dbca0788-4fb0-4986-8928-4df593da3f5e"),
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
                },
                new Post()
                {
                    Id = new Guid("1e510dc9-e8fd-40fc-ac14-19e701736537"),
                    EmployeeId = new Guid("dbca0788-4fb0-4986-8928-4df593da3f5e"),
                    Title = "\"Phù thủy\" bi-a ngưỡng mộ Djokovic, dù được so sánh với Federer",
                    Content = "O'Sullivan được mọi người ca ngợi là tay cơ vĩ đại và thành công nhất trong lịch sử bi-a với 7 lần vô địch thế giới cùng lối đánh hoa mỹ. Huyền thoại bi-a Jimmy White cho rằng đỉnh cao của O'Sullivan có thể so sánh với Roger Federer ở môn quần vợt.\r\n\r\nWhite nói: “Đừng nhầm lẫn, đường cơ của O'Sullivan thật huyền ảo! Nó giống như phong cánh chơi tennis của Roger Federer và những người kiểu như vậy. Nhưng O'Sullivan là người cầu toàn và anh ấy có thể nói rằng anh ấy đã chơi rất tệ”.\r\n\r\nO'Sullivan là một fan hâm mộ quần vợt cuồng nhiệt, nhưng tay vợt yêu thích của anh lại là Novak Djokovic, một trong những đối thủ lớn nhất của Federer khi huyền thoại người Thụy Sĩ còn thi đấu.\r\n\r\nNhà vô địch thế giới 7 lần nói: “Federer, Nadal, Djokovic. Tôi luôn thích xem họ thi đấu. Họ là ba tay vợt xuất sắc nhất mọi thời đại. Đối với tôi, Djokovic sẽ là vua của tất cả. Không quan trọng bạn là cầu thủ bóng đá, vận động viên chơi golf, hay vận động viên khúc côn cầu, mọi người đều nhìn vào Djokovic.\r\n\r\nTôi ước gì mình có thể làm được những gì Djokovic đã làm ở quần vợt. Cuộc sống của một vận động viên quần vợt chuyên nghiệp thật khó khăn. Nhưng khi họ ở trên đỉnh cao… thì những địa điểm họ thi đấu thật ấn tượng”.\r\n\r\nThể thức “một chọi một” của quần vợt về mặt nào đó có thể so sánh với bi-a. Đó có thể là lý do tại sao O'Sullivan lại rất ngưỡng mộ Djokovic, tay vợt nam sở hữu nhiều danh hiệu Grand Slam nhất lịch sử với 24 danh hiệu.\r\n\r\nVề phần O'Sullivan, anh đã tạo ra tiếng vang lớn với bộ phim tài liệu mới “The Edge of Everything” trong những ngày gần đây. Bộ phim hấp dẫn được công chiếu ở London (Anh) hôm 28/11, ghi lại những khó khăn về sức khỏe tinh thần của người đàn ông 47 tuổi trong thời gian đầu trong sự nghiệp bi-a của anh, đặc biệt là sau khi cha anh bị bỏ tù vì tội giết người vào năm 1992.\r\n\r\nCơ thủ được mệnh danh là \"Phù thủy bi-a\", hay \"The Rocket\" đã vượt lên tất cả để trở thành ngôi sao thể thao hàng đầu thế giới. Bộ phim lên đến đỉnh điểm với việc O'Sullivan lên ngôi tại giải vô địch bi-a thế giới năm 2022, danh hiệu thứ 7 giúp anh sánh ngang huyền thoại Stephen Hendry.",
                    Image = "post7.jpg",
                    CreatedDate = DateTime.Now.AddDays(-1),
                    UpdatedDate = DateTime.Now.AddDays(-1),
                    Description = "(Tin thể thao, tin tennis) Huyền thoại bi-a Ronnie O'Sullivan đã dành lời ca ngợi cho Novak Djokovic.",
                    Status = 0
                },
                new Post()
                {
                    Id = new Guid("1e510dc9-e8fd-40fc-ac14-19e701736538"),
                    EmployeeId = new Guid("dbca0788-4fb0-4986-8928-4df593da3f5e"),
                    Title = "Số 3 thế giới Trump đưa \"Thần đồng\" bi-a 12 tuổi \"trở lại mặt đất\"",
                    Content = "Cựu số 1 bi-a snooker, từng vô địch thế giới Judd Trump (Anh) khiến khán giả Trung Quốc có phần hụt hẫng khi loại bỏ \"Thần đồng\" 12 nước này một cách nhanh chóng.\r\n\r\nTay cơ 34 tuổi có biệt danh \"Át chủ bài\" thể hiện thái độ thi đấu cực kỳ chuyên nghiệp, anh coi VĐV 12 tuổi là đối thủ, vì thế chơi nghiêm túc, không bộ lộ nhiều cảm xúc.\r\n\r\nKhi Trump chơi tập trung, cơ hội dành cho Wang Xinzhong không nhiều. Tại vòng loại International Championship 2023 diễn ra tại Thiên Tân, Trung Quốc (từ 5 tới 12/11), Trump nhanh chóng đánh bại Wang 6-0 để giành vé vào đấu chính thức.\r\n\r\nTừ một ngôi sao được đặt nhiều kỳ vọng, \"Thần đồng\" Wang đã phải \"trở lại mặt đất\" sau trận đấu gặp Trump. Nhiều khán giả chủ nhà bày tỏ sự thất vọng, có người tỏ ra rất sốc.\r\n\r\n\"Thần đồng\" 12 tuổi bị thua nhanh chóng, vẫn còn nhiều thời gian để xóa khoảng cách về trình độ\", một người viết. \"Cậu bé mới chỉ 12 tuổi, thật khó vượt qua cú sốc từ trận đấu này\", người khác viết. \"Cậu ấy mới có 12 tuổi thôi, có thể ưu ái một chút được không?\", tài khoản khác viết.\r\n\r\nSố 3 thế giới Trump đối mặt với Michael White (Xứ Wales) ở vòng đấu tiếp theo. Trump đã vô địch ở sự kiện tổ chức năm 2019. Cho đến nay, Mark Selby là tay vợt duy nhất bảo vệ thành công chức vô địch vào năm 2016, 2017.",
                    Image = "post8.jpg",
                    CreatedDate = DateTime.Now.AddDays(-1),
                    UpdatedDate = DateTime.Now.AddDays(-1),
                    Description = "(Tin thể thao, tin bi-a) Judd Trump không hề nương tay khi so tài với \"Thần đồng\" bi-a Trung Quốc 12 tuổi.",
                    Status = 0
                },
                new Post()
                {
                    Id = new Guid("1e510dc9-e8fd-40fc-ac14-19e701736539"),
                    EmployeeId = new Guid("dbca0788-4fb0-4986-8928-4df593da3f5e"),
                    Title = "Chấn động bi-a: Nữ cơ thủ bỏ đấu chung kết để phản ứng đối thủ",
                    Content = "Mới đây scandal từ chối thi đấu bi-a diễn ra tại sự kiện Ladies Champions of Champions ở Denbighshire, Xứ Wales. Nữ cơ thủ Lynne Pinches từ chối so tài với Harriet Haynes, vì đây là VĐV chuyển giới nam thành nữ.\r\n\r\nĐoạn phim ghi lại cho thấy, nữ cơ thủ đến gần trọng tài để thông báo về không thi đấu, rồi vẫy tay chào khán giả. Cô quay trở lại chỗ ngồi của mình, thu dọn đồ đạc và rời khỏi đấu trường trước sự choáng váng của người xem. Haynes không hiểu chuyện gì xảy ra, sau đó nghiễm nhiên trở thành nhà vô địch.\r\n\r\nAnh trai của Pinches, Barry, lên mạng xã hội để khen ngợi em gái mình là người \"có lập trường\" và cho rằng việc phải thi đấu với 1 người chuyển giới là \"không công bằng\".\r\n\r\nBarry nói: \"Tôi hoàn toàn đồng ý với quan điểm của em gái mình, việc phụ nữ thi đấu với một VĐV chuyển giới ở bất kỳ môn thể thao nào cũng hoàn toàn không công bằng\".\r\n\r\nPinches từng là một trong số các VĐV nữ hàng đầu lên tiếng về việc phụ nữ chuyển giới được phép thi đấu tại các sự kiện lớn.\r\n\r\nCuộc tranh cãi hiện đang làm rung chuyển các giải đấu bi-a chuyên nghiệp từ 24/10, thời điểm Liên đoàn bi-a 8 bóng thế giới (WEPF) thay đổi quy định, cho phép người chuyển giới tham dự các giải đấu dành cho nữ.\r\n\r\nLuật được thông qua, những cơ thủ nam chuyển giới thành nữ đủ điều kiện tham dự giải nữ, mặc cho làn sóng phản đối họ thi đấu. Cơ thủ chuyển giới chỉ làm theo luật, nhưng điều đáng tiếc, họ không được chào đón ở nhiều sự kiện.",
                    Image = "post9.jpg",
                    CreatedDate = DateTime.Now.AddDays(-1),
                    UpdatedDate = DateTime.Now.AddDays(-1),
                    Description = "(Tin thể thao, tin bi-a) Lynne Pinches không màng tới chiếc cúp vô địch, cô từ chối thi đấu để phản đối đối thủ.",
                    Status = 0
                },
                new Post()
                {
                    Id = new Guid("1e510dc9-e8fd-40fc-ac14-19e701736540"),
                    EmployeeId = new Guid("40b601c0-2c08-449f-a41e-7564648f2c87"),
                    Title = "Nức lòng bi-a Việt Nam: 2 cơ thủ lọt top 10 thế giới, Bao Phương Vinh lập mốc mới",
                    Content = "Giải carom 3 băng Seoul World Cup 2023 kết thúc cuối tuần vừa qua tại Hàn Quốc chứng kiến màn đăng quang thuyết phục của siêu sao 55 tuổi Eddy Merckx. Đối đầu “thần đồng” đang xếp hạng 1 thế giới Cho Myung Woo, tay cơ người Bỉ đã nhập cuộc tự tin để dẫn trước đến 20-4. Dù Cho Myung Woo đã nỗ lực rút ngắn cách biệt, Eddy Merckx giữ vững phong độ để về đích với chiến thắng 50-43 sau 21 lượt cơ.\r\n\r\nEddy Merckx một lần nữa khẳng định vì sao được xem là “ông vua của những trận chung kết” khi đây đã là chức vô địch World Cup thứ 13 của ông chỉ sau 14 lần vào chung kết. “Thần cơ nước Bỉ” cũng là tay cơ vô địch World Cup nhiều nhất khi rời châu Âu với 4 lần vô địch ở Hàn Quốc, 3 lần ở Ai Cập và 2 lần tại Việt Nam. Ông là tay cơ vô địch World Cup ở Hàn Quốc nhiều nhất trên thế giới.\r\n\r\nTuy nhiên do phải bảo vệ 80 điểm với chức vô địch trước đó nên thứ hạng của Eddy Merckx (hạng 6 thế giới) vẫn giữ nguyên khi Liên đoàn carom thế giới (UMB) công bố bảng xếp hạng (BXH) carom 3 băng thế giới mới ngay sau Seoul World Cup 2023. Ngược lại, BXH này mang đến tin vui cho các cơ thủ Việt Nam.\r\n\r\nNếu như Trần Quyết Chiến vẫn giữ nguyên vị trí hạng 5 thế giới của mình thì Bao Phương Vinh tiếp tục thiết lập cột mốc ấn tượng mới cho bản thân khi tăng 2 bậc lên hạng 9 thế giới. Rõ ràng khi chỉ mới 28 tuổi, nhà đương kim vô địch thế giới sẽ còn có thể tiến xa hơn trong tương lai.\r\n\r\nViệc Phương Vinh vươn lên hạng 9 cũng làm người hâm mộ phấn khích khi đã rất lâu rồi, carom 3 băng Việt Nam mới lại được chứng kiến việc có 2 cơ thủ Việt Nam cùng nằm trong top 10 thế giới.\r\n\r\nTrên BXH thế giới hiện tại, Việt Nam là 1 trong 2 quốc gia có 2 tay cơ nằm trong top 10 (cùng với Hàn Quốc). Với việc vào đến vòng 1/8 và là cơ thủ Việt Nam tiến xa nhất ở giải đấu này, tay cơ 24 tuổi Chiêm Hồng Thái tăng 2 bậc lên hạng 19 thế giới.\r\n\r\nMột số thay đổi đáng chú ý, Dick Jaspers và Torbjorn Blomdahl đổi chỗ cho nhau khi Dick Jaspers lên hạng 3 thế giới, còn Blomdahl xuống vị trí thứ 4. Kim Haeng Jik tăng 2 bậc lên hạng 8 thế giới. Cơ thủ số 1 của Thổ Nhĩ Kỳ Tayfun Tasdemir từ hạng 9 xuống hạng 11 thế giới. Chặng World Cup tiếp theo sẽ diễn ra từ ngày 3-9/12 tại Ai Cập.",
                    Image = "post10.jpg",
                    CreatedDate = DateTime.Now.AddDays(-1),
                    UpdatedDate = DateTime.Now.AddDays(-1),
                    Description = "(Tin thể thao, tin bi-a) Cơ thủ Bao Phương Vinh thiết lập cột mốc mới trên bảng xếp hạng carom 3 băng thế giới, qua đó giúp Billiards Việt Nam hiện có 2 cơ thủ nằm trong top 10.",
                    Status = 0
                },
                new Post()
                {
                    Id = new Guid("1e510dc9-e8fd-40fc-ac14-19e701736541"),
                    EmployeeId = new Guid("dbca0788-4fb0-4986-8928-4df593da3f5e"),
                    Title = "Chiêm Hồng Thái “đại náo” bi-a World Cup, ngoạn mục vượt bảng “tử thần”",
                    Content = "Đây là trận đấu mà Hồng Thái đã bị đối thủ kỳ cựu dẫn trước đến 10-21 sau hiệp đầu. Dù vậy trong hiệp 2, cơ thủ mới 24 tuổi của Việt Nam vùng lên mạnh mẽ với nhiều series ghi điểm trung bình để dẫn ngược lại 31-28.\r\n\r\nBury sau đó có tiếp một cú đánh ghi 6 điểm để dẫn 39-34. Khi đối thủ chỉ còn đúng 1 điểm, Hồng Thái cho thấy bản lĩnh đáng nể để ghi thêm 6 điểm và cầm hòa đối thủ với cách biệt 40-40 sau 25 lượt cơ.\r\n\r\nỞ lượt trận cuối cùng của bảng đấu, Hồng Thái làm nức lòng người hâm mộ bi-a nước nhà khi đánh bại tay cơ người Áo Gerhard Kostistansky với tỉ số 40-19 chỉ sau 16 lượt cơ để độc chiếm ngôi đầu bảng và giành suất đi tiếp vào vòng knock-out top 16. Ở lượt trận còn lại của bảng đấu này, Sameh Sidhom với đường cơ 15 điểm đã đánh bại Jeremy Bury để giành ngôi nhì bảng cùng suất đi tiếp còn lại.\r\n\r\nĐáng tiếc ở bảng G, Phương Bao Vinh đã để thua Myeong Jong Cha (Hàn Quốc) với tỉ số 31-40 sau 21 lượt cơ trong trận đấu quyết định cho suất đi tiếp. Ngoài ra tại bảng E, Trần Quyết Chiến bị loại khi để thua cả 3 trận.\r\n\r\nNhư vậy, Chiêm Hồng Thái là đại diện duy nhất của Việt Nam tại vòng knock-out của 16 tay cơ xuất sắc nhất giải. Đối thủ của Hồng Thái tại vòng đấu này là Ruben Legazpi (Tây Ban Nha). Trận đấu diễn ra vào lúc 12h ngày 11/11 (theo giờ Việt Nam).",
                    Image = "post11.jpg",
                    CreatedDate = DateTime.Now,
                    UpdatedDate = DateTime.Now,
                    Description = "(Tin thể thao, tin bi-a) Sau khi gây sốc với chiến thắng trước cơ thủ hạng 7 thế giới Sameh Sidhom, Chiêm Hồng Thái tiếp tục thể hiện phong độ ấn tượng khi xuất sắc cầm hòa “quái kiệt bi-a” Jeremy Bury ở lượt trận thứ 2 tại bảng F trong khuôn khổ vòng bảng chính thức giải carom 3 băng Seoul World Cup 2023.",
                    Status = 0
                },
                new Post()
                {
                    Id = new Guid("1e510dc9-e8fd-40fc-ac14-19e701736542"),
                    EmployeeId = new Guid("40b601c0-2c08-449f-a41e-7564648f2c87"),
                    Title = "Trần Quyết Chiến tung hoành bi-a World Cup, choáng “cơ điên” 25 điểm loại Thanh Lực",
                    Content = "Vòng bảng chính thức giải carom 3 băng Veghel World Cup 2023 kết thúc vào rạng sáng ngày 27/10 tại Hà Lan chứng kiến nhiều diễn biến hấp dẫn, trong đó có những màn thể hiện ấn tượng của hai cơ thủ Việt Nam là Chiêm Hồng Thái và Trần Quyết Chiến.\r\n\r\nTại bảng B, Chiêm Hồng Thái sớm gây chấn động khi đánh bại cơ thủ số 1 thế giới Marco Zanetti (Ý) với tỉ số 40-25 chỉ sau 20 lượt cơ. Mặc dù để thua Sam Van Etten (Hà Lan) ở lượt trận tiếp theo, tài năng trẻ 24 tuổi của Việt Nam kịp lấy lại tinh thần để có chiến thắng quyết định trước Jeong Ye Sung (Hàn Quốc) với cách biệt 40-33 sau 32 lượt cơ để đứng nhì bảng B, cùng Sam Van Etten (nhất bảng) giành 2 suất đi tiếp vào vòng 16 tại bảng đấu này.\r\n\r\nTrong khi đó ở bảng H, Trần Quyết Chiến sớm giành quyền đi tiếp trước 1 lượt đấu bằng 2 chiến thắng liên tiếp trước Nguyễn Trần Thanh Tự (40-36 sau 27 lượt cơ) và Peter Ceulemans (40-22 sau 17 lượt cơ). Mặc dù Quyết Chiến để thua lượt trận cuối cùng trước Kim Haeng Jik, cơ thủ số 1 Việt Nam vẫn giành ngôi nhất bảng để cùng tay cơ người Hàn Quốc có suất đi tiếp, còn Thanh Tự bị loại.\r\n\r\nĐáng tiếc nhất phải kể đến trường hợp bị loại của Trần Thanh Lực tại bảng E. Cơ thủ của Việt Nam đã khởi đầu như mơ bằng chiến thắng ấn tượng 40-36 sau 22 lượt cơ trước thần đồng đang xếp hạng 2 thế giới Cho Myung Woo, dù cơ thủ người Hàn Quốc đã có series 11 ở trận đấu này.\r\n\r\nTuy nhiên sau đó, Thanh Lực hòa 40-40 trước Barry Van Beers (Hà Lan) và để thua Nikos Polychronopoulos (Hi Lạp) với tỉ số 25-40 sau 13 lượt cơ. Đáng nói trong trận đấu với Nikos, Thanh Lực dẫn trước đến 18-1 thì bất ngờ tay cơ người Hi Lạp tung “cơ điên” lên đến 25 điểm để lật ngược tình thế. Hai cơ thủ giành suất đi tiếp tại bảng đấu này là Cho Myung Woo và Nikos Polychronopoulos.\r\n\r\nĐại diện còn lại của Việt Nam là Bao Phương Vinh cũng bị loại khi chỉ đứng thứ 3 tại bảng D. Nhà đương kim vô địch thế giới có được chiến thắng trước cơ thủ hạng 6 thế giới Sameh Sidhom (Ai Cập) nhưng để thua hai đối thủ còn lại là Heo Jung Han (Hàn Quốc, tỉ số 24-40) và Berkay Karakurt (Thổ Nhĩ Kỳ, tỉ số 36-40).\r\n\r\nNhư vậy, tuyển billiards Việt Nam có 2 đại diện góp mặt ở vòng 16 diễn ra chiều tối ngày 27/10 là Trần Quyết Chiến và Chiêm Hồng Thái. Tại vòng đấu này, Quyết Chiến sẽ gặp tay cơ vừa có series 25 điểm Nikos Polychronopoulos (Hi Lạp), còn Hồng Thái đụng độ Berkay Karakurt (Thổ Nhĩ Kỳ). Bên cạnh đó, lượt trận tứ kết sẽ diễn ra vào khuya cùng ngày.",
                    Image = "post12.jpg",
                    CreatedDate = DateTime.Now,
                    UpdatedDate = DateTime.Now,
                    Description = "(Tin thể thao, tin bi-a) Nếu như Trần Quyết Chiến và Chiêm Hồng Thái thi đấu ấn tượng để tiến sâu thì Trần Thanh Lực bị loại sốc bởi đường cơ 25 điểm.",
                    Status = 0
                },
                new Post()
                {
                    Id = new Guid("1e510dc9-e8fd-40fc-ac14-19e701736543"),
                    EmployeeId = new Guid("dbca0788-4fb0-4986-8928-4df593da3f5e"),
                    Title = "Hot girl bi-a Hàn Quốc liên tiếp \"dọn bàn\", tuyển VN gặp khó tại siêu cúp quốc tế",
                    Content = "Giải Billiards siêu cúp Việt Nam – Hàn Quốc (Hollywood Super Cup) năm 2023 diễn ra tại TP.HCM trong 2 ngày 25 và 26/11. Đây là lần thứ hai, tuyển Billiards Việt Nam và Hàn Quốc gặp nhau ở giải đấu đồng đội hấp dẫn ở cả hai nội dung pool và carom 3 băng. Trước đó ở lần đầu tiên diễn ra tại Quảng Nam hồi tháng 2 năm nay, tuyển Billiards Việt Nam đã có màn ngược dòng ngoạn mục để giành chiến thắng.\r\n\r\nVới quyết tâm “đòi nợ”, tuyển Billiards Hàn Quốc đã mang đến giải đội hình rất mạnh với dàn cơ thủ nổi tiếng xứ sở Kim chi như nhà vô địch Carom 3 băng World Cup Heo Jung Han, Kim Jun Tae (hạng 13 thế giới), các nữ cơ thủ tài năng và xinh đẹp như Choi Bo-me, Heo Chae Won, Lee Woo Jin…\r\n\r\nTrong khi đó, tuyển Việt Nam có lực lượng được xem là tốt nhất với Trần Quyết Chiến (hạng 5 thế giới), đương kim vô địch World Championship Bao Phương Vinh, hai cơ thủ nữ hàng đầu Nguyễn Hoàng Yến Nhi và Phùng Kiện Tường ở nội dung carom 3 băng.  Ở nội dung pool, tuyển Việt Nam có mặt Dương Quốc Hoàng, Bùi Xuân Vàng và Huỳnh Thị Ngọc Huyền.\r\n\r\nTheo lịch thi đấu, ngày 25/11 diễn ra nội dung pool với các trận đấu đơn nam, 2 trận đơn nữ, đôi nam nữ và đồng đội. Nội dung carom 3 băng sẽ thi đấu vào ngày 26/11 với 2 trận đơn nam, 2 trận đơn nữ cùng đồng đội tiếp sức. Đội giành chiến thắng chung cuộc sẽ nhận 20.000 USD (khoảng 484 triệu đồng) và đội thua sẽ nhận 10.000 USD (khoảng 242 triệu đồng). \r\n\r\nỞ trận đấu mở màn diễn ra sáng ngày 25/11 theo thể thức pool đơn nữ, Bùi Xuân Vàng có màn đối đầu với nữ cơ thủ xinh đẹp Jin Hye Ju. Trong năm 2023, cơ thủ 27 tuổi của Hàn Quốc từng liên tiếp vào top 5 của 2 giải Pool nữ lớn của thế giới là China Open 2023 và vô địch 9 bi nữ thế giới 2023.\r\n\r\nVới đẳng cấp của mình, Jin Hye Ju sớm dẫn trước 4-0 sau 4 ván đầu, trong đó có 2 lần “dọn bàn” ấn tượng. Sau giờ nghỉ giải lao, Xuân Vàng vùng lên mạnh mẽ để san hòa tỉ số 4-4. Tuy nhiên sau đó, Jin Hye Ju tiếp tục có 3 ván thắng nữa để thắng chung cuộc 7-4, đưa tuyển Hàn Quốc vượt lên dẫn 1-0.\r\n\r\nTrận đấu thứ 2 là trận pool đơn nam giữa Dương Quốc Hoàng và Ha Minug. Với những cú đánh tỉ mỉ và tinh tế, Ha Minug dẫn trước 7-4 sau 11 ván đầu. Nỗ lực của Quốc Hoàng giúp anh san hòa được cách biệt 8-8. Tuy nhiên ở ván đấu quyết định, Ha Minug một lần nữa có được sự chính xác để thắng 9-8.\r\n\r\nMột cơ thủ xinh đẹp khác của Hàn Quốc là Lee Ha Rin tiếp tục gây khó khăn cho tuyển Việt Nam khi có chiến thắng ấn tượng 7-4 trong trận pool đơn nữ trước nhà vô địch quốc gia Huỳnh Thị Ngọc Huyền. Đây là trận đấu mà Lee Ha Rin khiến khán giả phải trầm trồ bằng kỹ thuật điêu luyện, đặc biệt là những cú đánh sút tê (nhảy bi) có độ chính xác rất cao. \r\n\r\nMặc dù Dương Quốc Hoàng và Bùi Xuân Vàng có được chiến thắng 5-2 trước bộ đôi Ha Minug và Lee Ha Rin ở trận đấu song tô đôi nam nữ, nhưng sau đó bộ ba Ha Minug, Lee Ha Rin và Jin Hye Ju lại có chiến thắng 5-1 trước 3 cơ thủ Dương Quốc Hoàng, Bùi Xuân Vàng, Huỳnh Thị Ngọc Huyền ở trận đấu đồng đội.\r\n\r\nNhư vậy sau ngày thi đấu đầu tiên ở nội dung pool, tuyển Billiards Việt Nam đang tạm bị dẫn trước đến 1-4. Điều này bắt buộc Quyết Chiến và các đồng đội sẽ phải thi đấu thăng hoa trong 5 trận đấu carom 3 băng ở ngày thi đấu còn lại mới mong lật ngược được thế trận để có chiến thắng chung cuộc.",
                    Image = "post13.jpg",
                    CreatedDate = DateTime.Now,
                    UpdatedDate = DateTime.Now,
                    Description = "(Tin thể thao, tin bi-a) Hai nữ cơ thủ xinh đẹp và tài năng Jin Hye Ju và Lee Ha Rin đã khiến tuyển Billiards Việt Nam rơi vào tình thế khó khăn tại giải Billiards siêu cúp Việt Nam – Hàn Quốc 2023.",
                    Status = 0
                },
                new Post()
                {
                    Id = new Guid("1e510dc9-e8fd-40fc-ac14-19e701736544"),
                    EmployeeId = new Guid("dbca0788-4fb0-4986-8928-4df593da3f5e"),
                    Title = "Sững sờ bi-a: Cú đánh trượt ở cửa lỗ lại được đề cử \"tình huống số 1 năm\"",
                    Content = "Sự kiện bi-a snooker Champion of Champions 2023 diễn ra tại Anh chứng kiến pha đi cơ đặc biệt. Ván đấu cuối cùng màn so tài vòng 1/16, Mark Williams (Xứ Wales) dù thua 2-4 trước Robert Milkins (Anh) nhưng vẫn được khán giả ca ngợi.\r\n\r\nTình huống ấn tượng diễn ra ở ván cuối, Milkins đang thắng 3-2 và dẫn 64-50. Lúc này, trên bàn chỉ còn bi hồng (6 điểm) và bi đen (7 điểm), dù có đưa cả 2 bóng này xuống bàn Williams vẫn thua. Đây là lý do mà cơ thủ 48 tuổi tới từ Xứ Wales dùng kĩ thuật móc bi hồng ra khỏi lỗ góc, sau đó còn giấu thành công bi chủ nấp sau bi đen.\r\n\r\nWilliams làm như vậy để buộc đối thủ mắc lỗi sẽ giúp cho anh có thêm điểm để thắng. Nhưng Milkins không phải tay mơ, ngôi sao người Anh sau đó đi cơ \"giải vây\" thành công và khép lại trận đấu với kết quả 4-2.\r\n\r\nDù thua, Williams nhận lời khen đặc biệt vì cú \"giấu bi\" đẳng cấp. Một khán giả viết: \"Không thể tin được. Tình huống đi cơ làm nhiều người nhớ tới các huyền thoại như Ronnie, Trump và Jimmy!\"\r\n\r\nNgười khác bày tỏ: \"Đây là một trong những tình huống đi cơ hay nhất lịch sử. Một cơ thủ thú vị để theo dõi\". Tài khoản còn lại viết: \"Một trong những sở thích lớn nhất của tôi, đó là xem Mark Williams thi đấu!\".\r\n\r\nMilkins giành quyền đi tiếp vào vòng 1/8, tại đây hành trình của anh dừng lại bởi đối thủ Robert Hawkins.",
                    Image = "post14.jpg",
                    CreatedDate = DateTime.Now,
                    UpdatedDate = DateTime.Now,
                    Description = "(Tin thể thao, tin bi-a) Dù bi mục tiêu nằm ở cửa lỗ nhưng bằng cách nào đó cơ thủ lại móc được ra ngoài.",
                    Status = 0
                },
                new Post()
                {
                    Id = new Guid("1e510dc9-e8fd-40fc-ac14-19e701736545"),
                    EmployeeId = new Guid("40b601c0-2c08-449f-a41e-7564648f2c87"),
                    Title = "600 tù nhân làm loạn nhà giam cổ vũ \"Phù thủy bi-a\" Sullivan vô địch thế giới",
                    Content = "Ronnie O'Sullivan, cơ thủ người Anh là một trong số những huyền thoại sống vẫn còn thi đấu thể thao. Bước sang tuổi 47, O'Sullivan vẫn đang giữ ngôi số 1 thế giới, và đang chia sẻ Stephen Hendry giữ kỷ lục 7 lần giành ngôi vô địch thế giới.\r\n\r\nĐể trở thành một ngôi sao như hiện tại, O'Sullivan trải qua rất nhiều khó khăn khi cha mẹ từng phải ngồi tù, bản thân tay cơ 47 tuổi từng dính vào chất kích thích. Nhưng tay cơ được mệnh danh là \"Phù thủy bi-a\", hay \"The Rocket\" vượt lên tất cả để biến bản thân trở thành ngôi sao thể thao hàng đầu thế giới.\r\n\r\nBộ phim tài liệu về sự nghiệp, cuộc sống của O'Sullivan sắp được công chiếu, ở đó có chi tiết anh được 600 tù nhân cổ vũ khi vô địch thế giới lần 2.\r\n\r\nBố của O'Sullivan, Ronnie O'Sullivan Sr, bị kết án tù chung thân vào năm 1992 vì tội giết người, thời điểm này tay cơ người Anh mới chưa đầy 17 tuổi.\r\n\r\nTrong nhà giam, dù không có tivi nhưng người bố Ronnie Sr vẫn làm mọi cách để cổ vũ con trai thi đấu. Ronnie Sr đã cố gắng biến những người bạn tù thành fan của cậu con trai \"The Rocket\" và 600 tù nhân đã \"mở hội\" trong nhà giam khi Ronnie Jr đánh bại Dotts với tỷ số 18-8 để bước lên ngôi vô địch snooker thế giới năm 2004.\r\n\r\nO'Sullivan Sr cho biết: \"Thời điểm con trai tôi vô địch, 600 tù nhân cùng đập vào tường, cửa, tạo ra âm thanh náo loạn tại phòng giam. Một cảnh tượng khiến tôi không thể nào quên\".O'Sullivan từng suy sụp ở quãng thời gian bố mình đi tù, thậm chí anh cũng phải quán xuyến công việc kinh doanh gia đình khi mẹ anh, bà Maria, bị bỏ tù một năm vì tội trốn thuế vào những năm 1990.\r\n\r\nCơ thủ 47 tuổi thừa nhận anh mất đi 5 năm quý giá, nếu không anh đã có hơn 7 lần vô địch thế giới: \"Từ năm 1995 đến năm 2000, tôi đã thắng một số giải đấu nhưng mọi thứ không phải tuyệt vời nhất. Có lẽ tôi đã lãng phí 5 năm sự nghiệp của mình, mọi thứ thực sự là lộn xộn\".",
                    Image = "post15.jpg",
                    CreatedDate = DateTime.Now,
                    UpdatedDate = DateTime.Now,
                    Description = "(Tin thể thao, tin bi-a) Ít ai biết, bố của cơ thủ huyền thoại Ronnie O'Sullivan từng là một kẻ giết người.",
                    Status = 0
                });
        }
    }
}