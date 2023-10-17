using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Datn_Api.Migrations
{
    public partial class datn : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "BillStatuses",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BillStatuses", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Categories",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Status = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Categories", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Employees",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Gender = table.Column<int>(type: "int", nullable: false),
                    DateOfBirth = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Address = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreateDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Status = table.Column<int>(type: "int", nullable: false),
                    UserName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedUserName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    Email = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedEmail = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    EmailConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    PasswordHash = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SecurityStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumberConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    TwoFactorEnabled = table.Column<bool>(type: "bit", nullable: false),
                    LockoutEnd = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    LockoutEnabled = table.Column<bool>(type: "bit", nullable: false),
                    AccessFailedCount = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Employees", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Payments",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Payments", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Ranks",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    NecessaryPoints = table.Column<int>(type: "int", nullable: false),
                    Status = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Ranks", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Roles",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Roles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Shafts",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Price = table.Column<double>(type: "float", nullable: false),
                    Size = table.Column<int>(type: "int", nullable: false),
                    Length = table.Column<int>(type: "int", nullable: false),
                    Material = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Color = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Status = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Shafts", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Tips",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Price = table.Column<double>(type: "float", nullable: false),
                    Size = table.Column<int>(type: "int", nullable: false),
                    Length = table.Column<int>(type: "int", nullable: false),
                    Material = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Color = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Status = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tips", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Weights",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Price = table.Column<double>(type: "float", nullable: false),
                    Status = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Weights", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Products",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CategoryID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Pin = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Wrap = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Rings = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    AvailableQuantity = table.Column<int>(type: "int", nullable: false),
                    Sold = table.Column<int>(type: "int", nullable: false),
                    Likes = table.Column<int>(type: "int", nullable: false),
                    Producer = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreateDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Status = table.Column<int>(type: "int", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Products", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Products_Categories_CategoryID",
                        column: x => x.CategoryID,
                        principalTable: "Categories",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "EmployeeClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EmployeeClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_EmployeeClaims_Employees_UserId",
                        column: x => x.UserId,
                        principalTable: "Employees",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "EmployeeLogins",
                columns: table => new
                {
                    LoginProvider = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ProviderKey = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ProviderDisplayName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UserId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EmployeeLogins", x => new { x.LoginProvider, x.ProviderKey });
                    table.ForeignKey(
                        name: "FK_EmployeeLogins_Employees_UserId",
                        column: x => x.UserId,
                        principalTable: "Employees",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "EmployeeTokens",
                columns: table => new
                {
                    UserId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    LoginProvider = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Value = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EmployeeTokens", x => new { x.UserId, x.LoginProvider, x.Name });
                    table.ForeignKey(
                        name: "FK_EmployeeTokens_Employees_UserId",
                        column: x => x.UserId,
                        principalTable: "Employees",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Vouchers",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    EmPloyeeId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Code = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Value = table.Column<double>(type: "float", nullable: false),
                    TimeStart = table.Column<DateTime>(type: "datetime2", nullable: false),
                    TimeEnd = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Status = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Vouchers", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Vouchers_Employees_EmPloyeeId",
                        column: x => x.EmPloyeeId,
                        principalTable: "Employees",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Customers",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    RankId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Gender = table.Column<int>(type: "int", nullable: false),
                    DateOfBirth = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreateDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Address = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Point = table.Column<int>(type: "int", nullable: false),
                    Status = table.Column<int>(type: "int", nullable: false),
                    UserName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    NormalizedUserName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    NormalizedEmail = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    EmailConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    PasswordHash = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SecurityStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumberConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    TwoFactorEnabled = table.Column<bool>(type: "bit", nullable: false),
                    LockoutEnd = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    LockoutEnabled = table.Column<bool>(type: "bit", nullable: false),
                    AccessFailedCount = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Customers", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Customers_Ranks_RankId",
                        column: x => x.RankId,
                        principalTable: "Ranks",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "EmployeeRoles",
                columns: table => new
                {
                    UserId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    RoleId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EmployeeRoles", x => new { x.UserId, x.RoleId });
                    table.ForeignKey(
                        name: "FK_EmployeeRoles_Employees_UserId",
                        column: x => x.UserId,
                        principalTable: "Employees",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_EmployeeRoles_Roles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "Roles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "RoleClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RoleId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RoleClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_RoleClaims_Roles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "Roles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ProductDetails",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ProductID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ShaftId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    WeightId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    TipId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Quantity = table.Column<int>(type: "int", nullable: false),
                    ImportPrice = table.Column<double>(type: "float", nullable: false),
                    Price = table.Column<double>(type: "float", nullable: false),
                    CreateDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Status = table.Column<int>(type: "int", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProductDetails", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ProductDetails_Products_ProductID",
                        column: x => x.ProductID,
                        principalTable: "Products",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ProductDetails_Shafts_ShaftId",
                        column: x => x.ShaftId,
                        principalTable: "Shafts",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ProductDetails_Tips_TipId",
                        column: x => x.TipId,
                        principalTable: "Tips",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ProductDetails_Weights_WeightId",
                        column: x => x.WeightId,
                        principalTable: "Weights",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Bills",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CustomerId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    BillStatusId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    PaymentId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Price = table.Column<double>(type: "float", nullable: false),
                    CreateDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Address = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Bills", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Bills_BillStatuses_BillStatusId",
                        column: x => x.BillStatusId,
                        principalTable: "BillStatuses",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Bills_Customers_CustomerId",
                        column: x => x.CustomerId,
                        principalTable: "Customers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Bills_Payments_PaymentId",
                        column: x => x.PaymentId,
                        principalTable: "Payments",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Carts",
                columns: table => new
                {
                    CustomerId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Quantity = table.Column<int>(type: "int", nullable: false),
                    TotalMoney = table.Column<double>(type: "float", nullable: false),
                    Status = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Carts", x => x.CustomerId);
                    table.ForeignKey(
                        name: "FK_Carts_Customers_CustomerId",
                        column: x => x.CustomerId,
                        principalTable: "Customers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "WishLists",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CustomerId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ProductId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_WishLists", x => x.Id);
                    table.ForeignKey(
                        name: "FK_WishLists_Customers_CustomerId",
                        column: x => x.CustomerId,
                        principalTable: "Customers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_WishLists_Products_ProductId",
                        column: x => x.ProductId,
                        principalTable: "Products",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ProductImages",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ProductDetailId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Status = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProductImages", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ProductImages_ProductDetails_ProductDetailId",
                        column: x => x.ProductDetailId,
                        principalTable: "ProductDetails",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "BillDetails",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    BillId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ProductDetailId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Quantity = table.Column<int>(type: "int", nullable: false),
                    Price = table.Column<double>(type: "float", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BillDetails", x => x.Id);
                    table.ForeignKey(
                        name: "FK_BillDetails_Bills_BillId",
                        column: x => x.BillId,
                        principalTable: "Bills",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_BillDetails_ProductDetails_ProductDetailId",
                        column: x => x.ProductDetailId,
                        principalTable: "ProductDetails",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "UsedVouchers",
                columns: table => new
                {
                    BillId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    VoucherId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UsedVouchers", x => x.BillId);
                    table.ForeignKey(
                        name: "FK_UsedVouchers_Bills_BillId",
                        column: x => x.BillId,
                        principalTable: "Bills",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_UsedVouchers_Vouchers_VoucherId",
                        column: x => x.VoucherId,
                        principalTable: "Vouchers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "CartDetails",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CustomerId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ProductDetailId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Quantity = table.Column<int>(type: "int", nullable: false),
                    Price = table.Column<double>(type: "float", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CartDetails", x => x.Id);
                    table.ForeignKey(
                        name: "FK_CartDetails_Carts_CustomerId",
                        column: x => x.CustomerId,
                        principalTable: "Carts",
                        principalColumn: "CustomerId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CartDetails_ProductDetails_ProductDetailId",
                        column: x => x.ProductDetailId,
                        principalTable: "ProductDetails",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "BillStatuses",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { new Guid("a51f7c3c-a8e7-4c0a-aeea-b6fc70492b15"), "Chờ xác nhận" },
                    { new Guid("a51f7c3c-a8e7-4c0a-aeea-b6fc70492bf5"), "Đã xác nhận" }
                });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "Name", "Status" },
                values: new object[,]
                {
                    { new Guid("357267e8-d162-4844-a660-661f46933d00"), "HOW", 0 },
                    { new Guid("357267e8-d162-4844-a660-661f46933d03"), "BK", 0 },
                    { new Guid("357267e8-d162-4844-a660-661f46933d04"), "Cuetec", 0 },
                    { new Guid("357267e8-d162-4844-a660-661f46933d05"), "Demon", 0 },
                    { new Guid("357267e8-d162-4844-a660-661f46933d06"), "EXCEED", 0 },
                    { new Guid("357267e8-d162-4844-a660-661f46933d07"), "Fury", 0 },
                    { new Guid("357267e8-d162-4844-a660-661f46933d08"), "Peri Pool", 0 },
                    { new Guid("357267e8-d162-4844-a660-661f46933d09"), "Predator", 0 },
                    { new Guid("357267e8-d162-4844-a660-661f46933d10"), "Mezz", 0 },
                    { new Guid("357267e8-d162-4844-a660-661f46933d11"), "Mit", 0 },
                    { new Guid("357267e8-d162-4844-a660-661f46933d12"), "Cơ Lỗ Cho Người Mới", 0 },
                    { new Guid("357267e8-d162-4844-a660-661f46933d13"), "Rhino", 0 },
                    { new Guid("357267e8-d162-4844-a660-661f46933d14"), "The Rack", 0 }
                });

            migrationBuilder.InsertData(
                table: "Employees",
                columns: new[] { "Id", "AccessFailedCount", "Address", "ConcurrencyStamp", "CreateDate", "DateOfBirth", "Email", "EmailConfirmed", "Gender", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "Status", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { new Guid("40b601c0-2c08-449f-a41e-7564648f2c87"), 0, "Hoa Thanh Quế", "e4bf7cff-6b1d-4814-801c-02470855c7e5", new DateTime(2020, 10, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2003, 8, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), "quocphuong@gmail.com", false, 0, true, null, "QUOCPHUONG@GMAIL.COM", "QUOCPHUONG", "AQAAAAEAACcQAAAAEDnw9/bad7RVII19Bn9Zetmhe4D2/RUELI0q65G6PgafUeSuvXTxEHTAC/hp5s372A==", "06969433323", false, "4GK7QXS2ZVKDV4BO2GGNSUH5SIGOGCMZ", 0, false, "QuocPhuong" },
                    { new Guid("dbca0788-4fb0-4986-8928-4df593da3f5e"), 0, "Hoa Thanh Quế", "e4bf7cff-6b1d-4814-801c-02470855c7e5", new DateTime(2020, 12, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2000, 10, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), "vanphuong@gmail.com", false, 0, true, null, "VANPHUONG@GMAIL.COM", "VANPHUONG", "AQAAAAEAACcQAAAAEDnw9/bad7RVII19Bn9Zetmhe4D2/RUELI0q65G6PgafUeSuvXTxEHTAC/hp5s372A==", "0386753434", false, "4GK7QXS2ZVKDV4BO2GGNSUH5SIGOGCMZ", 0, false, "VanPhuong" }
                });

            migrationBuilder.InsertData(
                table: "Payments",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { new Guid("a51f7c3c-a8e7-4c0a-aeea-b6fc70492b16"), "Online" },
                    { new Guid("a51f7c3c-a8e7-4c0a-aeea-b6fc70492bf6"), "Offline" }
                });

            migrationBuilder.InsertData(
                table: "Ranks",
                columns: new[] { "Id", "Name", "NecessaryPoints", "Status" },
                values: new object[,]
                {
                    { new Guid("a77f8ae9-af3d-4288-bbf3-8f77776f9232"), "Đồng", 1000, 0 },
                    { new Guid("a77f8ae9-af3d-4288-bbf3-8f77776f9233"), "Bạc", 2000, 0 },
                    { new Guid("a77f8ae9-af3d-4288-bbf3-8f77776f9234"), "Vàng", 5000, 0 },
                    { new Guid("a77f8ae9-af3d-4288-bbf3-8f77776f9235"), "Bạch kim", 8000, 0 },
                    { new Guid("a77f8ae9-af3d-4288-bbf3-8f77776f9236"), "Kim cương", 12000, 0 }
                });

            migrationBuilder.InsertData(
                table: "Roles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { new Guid("b108d866-eb13-46e3-b3d2-ecae4fbfe872"), "28ce2014-422f-4998-9256-532acf40b861", "Quản lý", "MANAGE" },
                    { new Guid("b108d866-eb13-46e3-b3d2-ecae4fbfe873"), "632a6307-8426-43ed-a490-2b9c03ab369a", "Nhân viên", "STAFF" }
                });

            migrationBuilder.InsertData(
                table: "Shafts",
                columns: new[] { "Id", "Color", "Length", "Material", "Name", "Price", "Size", "Status" },
                values: new object[,]
                {
                    { new Guid("cc37720a-7e89-463a-9510-1936e6761d53"), "Đen", 2, "Sắt", "Trơn", 140.0, 2, 0 },
                    { new Guid("cc37720a-7e89-463a-9510-1936e6761d63"), "Đen", 2, "Nhôm", "Bọc cao su", 90.0, 1, 0 },
                    { new Guid("cc37720a-7e89-463a-9510-1936e6761d73"), "Xanh", 1, "Gỗ", "Bọc da", 120.0, 2, 0 },
                    { new Guid("cc37720a-7e89-463a-9510-1936e6761d83"), "Đen", 1, "Gỗ", "Cuốn chỉ", 100.0, 1, 0 }
                });

            migrationBuilder.InsertData(
                table: "Tips",
                columns: new[] { "Id", "Color", "Length", "Material", "Name", "Price", "Size", "Status" },
                values: new object[,]
                {
                    { new Guid("cc37720a-7e89-463a-9510-1936e6761d74"), "Xanh", 2, "Gỗ", "F1 france", 140.0, 2, 0 },
                    { new Guid("cc37720a-7e89-463a-9510-1936e6761d84"), "Đen", 1, "Gỗ", "F1 CLEAR", 100.0, 1, 0 }
                });

            migrationBuilder.InsertData(
                table: "Weights",
                columns: new[] { "Id", "Name", "Price", "Status" },
                values: new object[,]
                {
                    { new Guid("cc37720a-7e89-463a-9510-1936e6761d75"), "CW3", 120.0, 0 },
                    { new Guid("cc37720a-7e89-463a-9510-1936e6761d85"), "CW4", 100.0, 0 }
                });

            migrationBuilder.InsertData(
                table: "Customers",
                columns: new[] { "Id", "AccessFailedCount", "Address", "ConcurrencyStamp", "CreateDate", "DateOfBirth", "Email", "EmailConfirmed", "Gender", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "Point", "RankId", "SecurityStamp", "Status", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { new Guid("a77f8ae9-af3d-4288-bbf3-8f77776f9230"), 0, "Hoa Thanh Quế", "e4bf7cff-6b1d-4814-801c-02470855c7e5", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2003, 11, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), "quynhanh@gmail.com", false, 1, true, null, "QUYNHANH@GMAIL.COM", "QUYNHANH", "AQAAAAEAACcQAAAAEDnw9/bad7RVII19Bn9Zetmhe4D2/RUELI0q65G6PgafUeSuvXTxEHTAC/hp5s372A==", "0363636363", false, 12000, new Guid("a77f8ae9-af3d-4288-bbf3-8f77776f9236"), "4GK7QXS2ZVKDV4BO2GGNSUH5SIGOGCMZ", 0, false, "QuynhAnh" },
                    { new Guid("a77f8ae9-af3d-4288-bbf3-8f77776f9231"), 0, "Hoa Thanh Quế", "e4bf7cff-6b1d-4814-801c-02470855c7e5", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2003, 10, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), "thanhtung@gmail.com", false, 0, true, null, "THANHTUNG@GMAIL.COM", "THANHTUNG", "AQAAAAEAACcQAAAAEDnw9/bad7RVII19Bn9Zetmhe4D2/RUELI0q65G6PgafUeSuvXTxEHTAC/hp5s372A==", "0696969696", false, 12000, new Guid("a77f8ae9-af3d-4288-bbf3-8f77776f9236"), "4GK7QXS2ZVKDV4BO2GGNSUH5SIGOGCMZ", 0, false, "ThanhTung" }
                });

            migrationBuilder.InsertData(
                table: "EmployeeRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[,]
                {
                    { new Guid("b108d866-eb13-46e3-b3d2-ecae4fbfe872"), new Guid("40b601c0-2c08-449f-a41e-7564648f2c87") },
                    { new Guid("b108d866-eb13-46e3-b3d2-ecae4fbfe873"), new Guid("dbca0788-4fb0-4986-8928-4df593da3f5e") }
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "AvailableQuantity", "CategoryID", "CreateDate", "Description", "Likes", "Name", "Pin", "Producer", "Rings", "Sold", "Status", "Wrap" },
                values: new object[,]
                {
                    { new Guid("cc37720a-7e89-463a-9510-1936e6761d8a"), 1000, new Guid("357267e8-d162-4844-a660-661f46933d03"), new DateTime(2023, 9, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), "Description", 1000, "Gậy bida sành điệu 1", "pin1", "Lucasi", "ring1", 500, 0, "wrap1" },
                    { new Guid("cc37720a-7e89-463a-9510-1936e6761d8b"), 2000, new Guid("357267e8-d162-4844-a660-661f46933d04"), new DateTime(2023, 9, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), "Description", 1000, "Gậy bida sành điệu 2", "pin2", "Lucasi", "ring2", 500, 0, "wrap2" },
                    { new Guid("cc37720a-7e89-463a-9510-1936e6761d8c"), 2000, new Guid("357267e8-d162-4844-a660-661f46933d05"), new DateTime(2023, 9, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), "Description", 1000, "Gậy bida sành điệu 3", "pin3", "Lucasi", "ring3", 500, 0, "wrap3" }
                });

            migrationBuilder.InsertData(
                table: "Vouchers",
                columns: new[] { "Id", "Code", "EmPloyeeId", "Status", "TimeEnd", "TimeStart", "Value" },
                values: new object[,]
                {
                    { new Guid("a51f7c3c-a8e7-4c0a-aeea-b6fc70492b14"), "Pitover", new Guid("dbca0788-4fb0-4986-8928-4df593da3f5e"), 1, new DateTime(2023, 9, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 9, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), 50.0 },
                    { new Guid("a51f7c3c-a8e7-4c0a-aeea-b6fc70492bf4"), "DEMACIA", new Guid("40b601c0-2c08-449f-a41e-7564648f2c87"), 0, new DateTime(2023, 10, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 9, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), 30.0 }
                });

            migrationBuilder.InsertData(
                table: "Bills",
                columns: new[] { "Id", "Address", "BillStatusId", "CreateDate", "CustomerId", "PaymentId", "Price" },
                values: new object[,]
                {
                    { new Guid("a51f7c3c-a8e7-4c0a-aeea-b6fc70492b13"), "phi phai", new Guid("a51f7c3c-a8e7-4c0a-aeea-b6fc70492bf5"), new DateTime(2023, 9, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("a77f8ae9-af3d-4288-bbf3-8f77776f9230"), new Guid("a51f7c3c-a8e7-4c0a-aeea-b6fc70492b16"), 1450.0 },
                    { new Guid("a51f7c3c-a8e7-4c0a-aeea-b6fc70492bf3"), "Bình nguyên vô tận", new Guid("a51f7c3c-a8e7-4c0a-aeea-b6fc70492b15"), new DateTime(2023, 9, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("a77f8ae9-af3d-4288-bbf3-8f77776f9230"), new Guid("a51f7c3c-a8e7-4c0a-aeea-b6fc70492bf6"), 1500.0 }
                });

            migrationBuilder.InsertData(
                table: "Carts",
                columns: new[] { "CustomerId", "Quantity", "Status", "TotalMoney" },
                values: new object[,]
                {
                    { new Guid("a77f8ae9-af3d-4288-bbf3-8f77776f9230"), 0, 1, 0.0 },
                    { new Guid("a77f8ae9-af3d-4288-bbf3-8f77776f9231"), 1, 0, 2000.0 }
                });

            migrationBuilder.InsertData(
                table: "ProductDetails",
                columns: new[] { "Id", "CreateDate", "Description", "ImportPrice", "Price", "ProductID", "Quantity", "ShaftId", "Status", "TipId", "WeightId" },
                values: new object[,]
                {
                    { new Guid("1eaaba04-80ff-43a6-a746-a74a91c4c0e3"), new DateTime(2023, 9, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "Description", 1500.0, 2000.0, new Guid("cc37720a-7e89-463a-9510-1936e6761d8a"), 2, new Guid("cc37720a-7e89-463a-9510-1936e6761d83"), 0, new Guid("cc37720a-7e89-463a-9510-1936e6761d84"), new Guid("cc37720a-7e89-463a-9510-1936e6761d85") },
                    { new Guid("979a227c-41b7-4644-8ab1-e1c8d092f79f"), new DateTime(2023, 9, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "Description", 1500.0, 2000.0, new Guid("cc37720a-7e89-463a-9510-1936e6761d8b"), 2, new Guid("cc37720a-7e89-463a-9510-1936e6761d73"), 0, new Guid("cc37720a-7e89-463a-9510-1936e6761d74"), new Guid("cc37720a-7e89-463a-9510-1936e6761d75") }
                });

            migrationBuilder.InsertData(
                table: "WishLists",
                columns: new[] { "Id", "CustomerId", "ProductId" },
                values: new object[] { new Guid("37c66a8d-acb9-41a1-af73-f46e83a578dc"), new Guid("a77f8ae9-af3d-4288-bbf3-8f77776f9231"), new Guid("cc37720a-7e89-463a-9510-1936e6761d8a") });

            migrationBuilder.InsertData(
                table: "BillDetails",
                columns: new[] { "Id", "BillId", "Price", "ProductDetailId", "Quantity" },
                values: new object[,]
                {
                    { new Guid("8f95d2d6-c3d3-4749-be89-97e220d62e78"), new Guid("a51f7c3c-a8e7-4c0a-aeea-b6fc70492b13"), 1450.0, new Guid("979a227c-41b7-4644-8ab1-e1c8d092f79f"), 1 },
                    { new Guid("8f95d2d6-c3d3-4749-be89-97e220d62e79"), new Guid("a51f7c3c-a8e7-4c0a-aeea-b6fc70492bf3"), 1500.0, new Guid("1eaaba04-80ff-43a6-a746-a74a91c4c0e3"), 1 }
                });

            migrationBuilder.InsertData(
                table: "CartDetails",
                columns: new[] { "Id", "CustomerId", "Price", "ProductDetailId", "Quantity" },
                values: new object[] { new Guid("357267e8-d162-4844-a660-661f46933d02"), new Guid("a77f8ae9-af3d-4288-bbf3-8f77776f9231"), 2000.0, new Guid("979a227c-41b7-4644-8ab1-e1c8d092f79f"), 1 });

            migrationBuilder.InsertData(
                table: "ProductImages",
                columns: new[] { "Id", "Name", "ProductDetailId", "Status" },
                values: new object[] { new Guid("d5c65161-7591-48c1-9198-daca151bce7c"), "image1", new Guid("1eaaba04-80ff-43a6-a746-a74a91c4c0e3"), 0 });

            migrationBuilder.InsertData(
                table: "UsedVouchers",
                columns: new[] { "BillId", "VoucherId" },
                values: new object[] { new Guid("a51f7c3c-a8e7-4c0a-aeea-b6fc70492b13"), new Guid("a51f7c3c-a8e7-4c0a-aeea-b6fc70492b14") });

            migrationBuilder.CreateIndex(
                name: "IX_BillDetails_BillId",
                table: "BillDetails",
                column: "BillId");

            migrationBuilder.CreateIndex(
                name: "IX_BillDetails_ProductDetailId",
                table: "BillDetails",
                column: "ProductDetailId");

            migrationBuilder.CreateIndex(
                name: "IX_Bills_BillStatusId",
                table: "Bills",
                column: "BillStatusId");

            migrationBuilder.CreateIndex(
                name: "IX_Bills_CustomerId",
                table: "Bills",
                column: "CustomerId");

            migrationBuilder.CreateIndex(
                name: "IX_Bills_PaymentId",
                table: "Bills",
                column: "PaymentId");

            migrationBuilder.CreateIndex(
                name: "IX_CartDetails_CustomerId",
                table: "CartDetails",
                column: "CustomerId");

            migrationBuilder.CreateIndex(
                name: "IX_CartDetails_ProductDetailId",
                table: "CartDetails",
                column: "ProductDetailId");

            migrationBuilder.CreateIndex(
                name: "IX_Customers_RankId",
                table: "Customers",
                column: "RankId");

            migrationBuilder.CreateIndex(
                name: "IX_EmployeeClaims_UserId",
                table: "EmployeeClaims",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_EmployeeLogins_UserId",
                table: "EmployeeLogins",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_EmployeeRoles_RoleId",
                table: "EmployeeRoles",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "EmailIndex",
                table: "Employees",
                column: "NormalizedEmail");

            migrationBuilder.CreateIndex(
                name: "UserNameIndex",
                table: "Employees",
                column: "NormalizedUserName",
                unique: true,
                filter: "[NormalizedUserName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_ProductDetails_ProductID",
                table: "ProductDetails",
                column: "ProductID");

            migrationBuilder.CreateIndex(
                name: "IX_ProductDetails_ShaftId",
                table: "ProductDetails",
                column: "ShaftId");

            migrationBuilder.CreateIndex(
                name: "IX_ProductDetails_TipId",
                table: "ProductDetails",
                column: "TipId");

            migrationBuilder.CreateIndex(
                name: "IX_ProductDetails_WeightId",
                table: "ProductDetails",
                column: "WeightId");

            migrationBuilder.CreateIndex(
                name: "IX_ProductImages_ProductDetailId",
                table: "ProductImages",
                column: "ProductDetailId");

            migrationBuilder.CreateIndex(
                name: "IX_Products_CategoryID",
                table: "Products",
                column: "CategoryID");

            migrationBuilder.CreateIndex(
                name: "IX_RoleClaims_RoleId",
                table: "RoleClaims",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "RoleNameIndex",
                table: "Roles",
                column: "NormalizedName",
                unique: true,
                filter: "[NormalizedName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_UsedVouchers_VoucherId",
                table: "UsedVouchers",
                column: "VoucherId");

            migrationBuilder.CreateIndex(
                name: "IX_Vouchers_EmPloyeeId",
                table: "Vouchers",
                column: "EmPloyeeId");

            migrationBuilder.CreateIndex(
                name: "IX_WishLists_CustomerId",
                table: "WishLists",
                column: "CustomerId");

            migrationBuilder.CreateIndex(
                name: "IX_WishLists_ProductId",
                table: "WishLists",
                column: "ProductId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "BillDetails");

            migrationBuilder.DropTable(
                name: "CartDetails");

            migrationBuilder.DropTable(
                name: "EmployeeClaims");

            migrationBuilder.DropTable(
                name: "EmployeeLogins");

            migrationBuilder.DropTable(
                name: "EmployeeRoles");

            migrationBuilder.DropTable(
                name: "EmployeeTokens");

            migrationBuilder.DropTable(
                name: "ProductImages");

            migrationBuilder.DropTable(
                name: "RoleClaims");

            migrationBuilder.DropTable(
                name: "UsedVouchers");

            migrationBuilder.DropTable(
                name: "WishLists");

            migrationBuilder.DropTable(
                name: "Carts");

            migrationBuilder.DropTable(
                name: "ProductDetails");

            migrationBuilder.DropTable(
                name: "Roles");

            migrationBuilder.DropTable(
                name: "Bills");

            migrationBuilder.DropTable(
                name: "Vouchers");

            migrationBuilder.DropTable(
                name: "Products");

            migrationBuilder.DropTable(
                name: "Shafts");

            migrationBuilder.DropTable(
                name: "Tips");

            migrationBuilder.DropTable(
                name: "Weights");

            migrationBuilder.DropTable(
                name: "BillStatuses");

            migrationBuilder.DropTable(
                name: "Customers");

            migrationBuilder.DropTable(
                name: "Payments");

            migrationBuilder.DropTable(
                name: "Employees");

            migrationBuilder.DropTable(
                name: "Categories");

            migrationBuilder.DropTable(
                name: "Ranks");
        }
    }
}
