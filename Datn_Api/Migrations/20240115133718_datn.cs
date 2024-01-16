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
                name: "Brands",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Status = table.Column<int>(type: "int", nullable: false),
                    DateCreated = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Brands", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Categories",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
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
                    FullName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Image = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Gender = table.Column<int>(type: "int", nullable: false),
                    DateOfBirth = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Address = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Twitter = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Facebook = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Instagram = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Linkedin = table.Column<string>(type: "nvarchar(max)", nullable: true),
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
                    Size = table.Column<double>(type: "float", nullable: false),
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
                    BrandID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Pin = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Wrap = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Rings = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    AvailableQuantity = table.Column<int>(type: "int", nullable: false),
                    Sold = table.Column<int>(type: "int", nullable: false),
                    Likes = table.Column<int>(type: "int", nullable: false),
                    CreateDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Status = table.Column<int>(type: "int", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Products", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Products_Brands_BrandID",
                        column: x => x.BrandID,
                        principalTable: "Brands",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
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
                name: "Posts",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    EmployeeId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Content = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Image = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Status = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Posts", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Posts_Employees_EmployeeId",
                        column: x => x.EmployeeId,
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
                    PointCustomer = table.Column<int>(type: "int", nullable: false),
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
                    FullName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Image = table.Column<string>(type: "nvarchar(max)", nullable: false),
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
                    Address = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CustomerName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CustomerPhone = table.Column<string>(type: "nvarchar(max)", nullable: false)
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
                    Price = table.Column<double>(type: "float", nullable: false),
                    CreateDate = table.Column<DateTime>(type: "datetime2", nullable: false)
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
                    { new Guid("00357f21-9356-468b-8c0c-b590e3d1bc0a"), "Đang giao hàng" },
                    { new Guid("33c0bdd2-85ca-4f05-9360-22be333895fe"), "Giao hàng thành công" },
                    { new Guid("a51f7c3c-a8e7-4c0a-aeea-b6fc70492b15"), "Chờ xác nhận" },
                    { new Guid("a51f7c3c-a8e7-4c0a-aeea-b6fc70492bf5"), "Đã xác nhận" },
                    { new Guid("b392b872-712a-41a7-8542-83fb58249c23"), "Đang lấy hàng" }
                });

            migrationBuilder.InsertData(
                table: "Brands",
                columns: new[] { "Id", "DateCreated", "Description", "Name", "Status" },
                values: new object[,]
                {
                    { new Guid("f205098b-3986-484a-ab3f-8dcab46fc220"), new DateTime(2022, 9, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), "Đợt chạy giới hạn Smoke Grey P3 của Predator sắp kết thúc. Nhận của bạn NGAY BÂY GIỜ trước khi chúng biến mất mãi mãi!\r\nCó rất nhiều lý do khiến Predator là một trong những thương hiệu được biết đến nhiều nhất trong làng bida, nhưng lý do chính rất đơn giản: Công nghệ. Trước khi ra mắt vào năm 1994, nhiều năm nghiên cứu và phát triển đã được tiến hành để phát triển trục có độ lệch thấp Predator 314. Kể từ đó, Predator đã tiếp tục xu hướng đổi mới và xuất sắc bằng cách mở rộng dòng sản phẩm của mình để bao gồm các tín hiệu đẹp, công nghệ tiên tiến và nhiều mẫu cán gậy hơn.\r\n\r\nNgày nay, ngoài trục 314, trục Predator còn có trục Z, trục Vantage và trục REVO bằng carbon tổng hợp mang tính cách mạng. Mỗi trục này tạo ra độ xoay riêng dựa trên khái niệm độ lệch thấp thông qua các loại côn, đường kính đầu và vật liệu trục khác nhau.\r\n\r\nĐừng quên rằng mọi Predator Cue đều đủ điều kiện để được Vận chuyển Mặt đất Miễn phí ở 48 Hoa Kỳ thấp hơn! PoolDawg là Đại lý được ủy quyền cho các sản phẩm gậy, trục và bida Predator. Tất cả các sản phẩm Predator đều được nhà sản xuất bảo hành 1 năm đối với các lỗi.", "Predator Cues", 0 },
                    { new Guid("f205098b-3986-484a-ab3f-8dcab46fc221"), new DateTime(2022, 9, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), "Gậy Elite tập trung vào sự sang trọng và chất lượng. Gậy cao cấp có thiết kế đơn giản, thanh lịch giúp thể hiện vẻ đẹp của gỗ chất lượng. Gỗ phong Birdseye, gỗ cocobolo và gỗ bocote là tiêu chuẩn cho những tín hiệu này, giúp trưng bày tác phẩm vĩ đại nhất của Mẹ Thiên nhiên. Ngoài những chiếc gậy bi-a đẹp mắt, Elite còn sản xuất những hộp đựng bi-a chất lượng cao với đủ kích cỡ và kiểu dáng.\r\n\r\nMỗi sản phẩm Elite đều được nhà sản xuất bảo hành 1 năm. PoolDawg là Đại lý được ủy quyền cho các sản phẩm bida và bida Elite.", "Elite Pool Cues", 0 },
                    { new Guid("f205098b-3986-484a-ab3f-8dcab46fc222"), new DateTime(2022, 9, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), "Trở thành một với tín hiệu bi-a của bạn bằng cách thêm trục có độ lệch thấp Katana. Mỗi trục đều có cấu trúc xuyên tâm 10 mảnh, đầu 12,5mm và vòng sắt 3/8\" rút ngắn mang lại cho bạn hiệu suất tối ưu với giá cả phải chăng. Chỉ có một trục dành cho samurai hồ bơi đích thực và trục đó là Katana.\r\n\r\nVào năm 2013, Katana đã giới thiệu dòng gậy bida đầu tiên của mình. Tất cả các gậy Katana của chúng tôi đều có trục có độ lệch thấp.\r\n\r\nTất cả các tín hiệu và trục bể bơi Katana đều được nhà sản xuất bảo hành một năm đối với các khuyết tật.\r\n\r\nĐừng quên rằng mọi Katana Cue và Shaft đều đủ điều kiện để được Vận chuyển Mặt đất Miễn phí ở 48 Hoa Kỳ thấp hơn!", "Katana Cues", 0 },
                    { new Guid("f205098b-3986-484a-ab3f-8dcab46fc223"), new DateTime(2022, 9, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), "Trò chơi bida có nhiều điểm tương đồng với môn leo núi. Mọi người đều bắt đầu từ phía dưới và đòi hỏi rất nhiều công sức, đào tạo và tập trung để đạt được mục tiêu của mình. Bất kỳ ai cũng có thể vấp ngã qua chân đồi và thậm chí họ có thể có được tầm nhìn đẹp từ một số điểm cao hơn nhưng để đạt đến ĐỈNH, bạn cần có thiết bị phù hợp. Trong môn bida, SUMMIT sẽ đưa bạn lên đỉnh cao!\r\n\r\nQua nhiều năm thử nghiệm và phát triển sản phẩm, các nhà sản xuất cơ bi-a hàng đầu đã phát hiện ra rằng chìa khóa cho hiệu suất của trục cơ bi-a TẤT CẢ là việc giảm khối lượng mặt trước của trục. Họ phát hiện ra rằng việc làm nhẹ vài inch đầu tiên của trục cho phép đầu gậy làm chệch hướng bi cái hiệu quả hơn, vẫn áp dụng độ xoáy mong muốn, nhưng ít phun ra khỏi đường ngắm khi đánh hơn đáng kể. Về cơ bản, khối lượng đầu ít hơn có nghĩa là trục bắn thẳng hơn. TUYỆT VỜI LÀ TỐT HƠN!!!", "SUMMIT PRO-LD", 0 },
                    { new Guid("f205098b-3986-484a-ab3f-8dcab46fc224"), new DateTime(2022, 9, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), "Skylar Woodward Avid Series Proof Cues của Cuetec - Được chưng cất để biểu diễn.\r\nCuetec Cues là một trong những tín hiệu bida phổ biến nhất hiện nay một phần do mối quan hệ của chúng với Nhà vô địch thế giới Shane van Boening. Dòng tín hiệu Cuetec tiêu chuẩn có lớp vỏ composite độc đáo bằng sợi thủy tinh hoạt động giống như áo giáp. Quy trình \"liên kết điện\" Cuetec liên kết vĩnh viễn lớp phủ sợi thủy tinh với gỗ, khóa độ ẩm và tạo ra một trục cơ hồ bơi bền bỉ, chống móp và va đập!\r\n\r\nDòng tín hiệu Cynergy được làm bằng trục sợi Carbon và chúng là công nghệ tín hiệu bi-a mới nhất và tốt nhất có độ lệch gần như bằng 0 cũng như tính nhất quán và độ bền chưa từng có.\r\n \r\nCho dù bạn chọn trục SST cổ điển hay trục sợi carbon Cynergy, bạn không thể sai lầm với Cuetec. PoolDawg là Đại lý được ủy quyền cho các tín hiệu bể bơi Cuetec.", "Cuetec Pool Cues", 0 },
                    { new Guid("f205098b-3986-484a-ab3f-8dcab46fc225"), new DateTime(2022, 9, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), "Gậy Meucci là một trong những thương hiệu nổi tiếng nhất hiện nay. Kể từ những ngày đầu của Meucci Originals, Bob Meucci đã cách mạng hóa thế giới cơ bi-a tùy chỉnh bằng những thiết kế cổ điển của mình. Nhiều thiết kế trong số đó, bao gồm cả dòng Gambler và Hall of Fame nổi tiếng, vẫn đang được chế tạo và cải tiến bằng công nghệ chế tạo cơ hiện đại.\r\n\r\nNgười chơi sử dụng tín hiệu Meucci trung thành và không khoan nhượng khi nói đến cảm giác và hiệu suất của thiết bị của họ. Với độ lệch thấp, trục Black Dot trên mọi mẫu, Meucci có sức hút không giống bất kỳ loại gậy bi-a chất lượng chuyên nghiệp nào khác trên thị trường. Mềm mại và uyển chuyển với thiết kế khớp nối và ống nối độc đáo cho phép đạt được hiệu suất tối đa với nỗ lực tối thiểu.\r\n\r\nĐừng quên rằng mọi Meucci Cue đều đủ điều kiện Vận chuyển mặt đất miễn phí ở 48 Hoa Kỳ! PoolDawg là Đại lý được ủy quyền cho các sản phẩm bida và bida Meucci.", "Meucci Pool Cues", 0 },
                    { new Guid("f205098b-3986-484a-ab3f-8dcab46fc226"), new DateTime(2022, 9, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), "Một số phẩm chất hiện lên trong đầu bạn khi bạn nghĩ về Bò là gì? Có lẽ bướng bỉnh, mạnh mẽ và chăm chỉ? Cá nhân tôi biết đó là những gì hiện lên trong đầu tôi và những Trục sợi carbon này của Bull không khác gì tên động vật của chúng. Với thành carbon dày 1mm, dày hơn hầu hết các đối thủ cạnh tranh bằng sợi carbon, những tín hiệu này cực kỳ chắc chắn, có khả năng chống cong vênh và va đập. Ngoài ra, tôi đã đề cập đến việc chúng đạt tiêu chuẩn với đầu Kamui Black Soft chưa? Kết quả là một gợi ý mà chúng tôi đã nghe từ nhiều người chơi là một trong những cú đánh hay nhất, nếu không muốn nói là hay nhất mà họ từng cảm nhận được. Không chỉ vậy, Bull còn nghĩ ra một hệ thống cho các khớp có thể hoán đổi cho nhau, nghĩa là nếu bạn có nhiều tín hiệu với các khớp khác nhau, bạn có thể hoán đổi nó và chơi với trục nổi tiếng này theo bất kỳ tín hiệu nào bạn muốn.", "Bull Carbon Fiber", 0 },
                    { new Guid("f205098b-3986-484a-ab3f-8dcab46fc227"), new DateTime(2022, 9, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), "George Balabushka là một trong những nhà sản xuất cơ bida tùy chỉnh có ảnh hưởng nhất từ ​​trước đến nay. Mặc dù ông đã qua đời vào những năm 70, nhưng các kỹ thuật và thiết kế sáng tạo của ông vẫn tiếp tục truyền cảm hứng cho các thương hiệu bi-a hàng đầu từ tín hiệu Griffin đến tín hiệu Joss \"Color of Money\". Ngày nay, di sản của ông vẫn tiếp tục với dòng tín hiệu được cấp phép này. Được làm từ vật liệu chất lượng cao nhất, những tín hiệu này đi kèm với trục côn chuyên nghiệp và chứng nhận xác thực. Ngoài ra, đừng quên xem Phấn biểu diễn Balabushka siêu phổ biến.\r\n\r\nĐừng quên rằng mọi Balabushka Cue đều đủ điều kiện để được Vận chuyển Mặt đất Miễn phí ở 48 Hoa Kỳ thấp hơn!", "Balabushka Cues", 0 },
                    { new Guid("f205098b-3986-484a-ab3f-8dcab46fc228"), new DateTime(2022, 9, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), "Có lý do tại sao Tín hiệu hành động là lựa chọn ưa thích của hơn 400.000 người chơi giải đấu trên toàn cầu. Hành động xây dựng tín hiệu bi-a cho mọi cấp độ của người chơi bi-a. Cho dù bạn là người mới bắt đầu hay người chơi trong giải đấu, Action đều có một cây gậy dành riêng cho bạn.\r\n\r\nVới các tín hiệu và hộp đựng Hành động, bạn sẽ có được chất lượng thủ công với mức giá phải chăng. Cho dù đó là hộp đựng bi-a mới, gợi ý hình xăm lấy cảm hứng từ Thủy thủ Jerry từ loạt phim Phiêu lưu hay thậm chí là một trong những loạt phim Impact trừu tượng hơn, luôn có một sản phẩm Hành động đáp ứng nhu cầu của bạn và vượt quá mong đợi của bạn. Mỗi tín hiệu Hành động đều được nhà sản xuất bảo hành 1 năm đối với các lỗi. PoolDawg là Đại lý được ủy quyền cho các sản phẩm bida Action.", "Action Pool Cues", 0 }
                });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "CreatedDate", "Name", "Status", "UpdatedDate" },
                values: new object[,]
                {
                    { new Guid("357267e8-d162-4844-a660-661f46933d03"), new DateTime(2022, 9, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), "Cơ Đánh", 0, new DateTime(2022, 9, 11, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("357267e8-d162-4844-a660-661f46933d04"), new DateTime(2023, 9, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), "Cơ Nhảy", 0, new DateTime(2023, 9, 11, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("357267e8-d162-4844-a660-661f46933d05"), new DateTime(2023, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "Cơ Phá", 0, new DateTime(2023, 9, 10, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("357267e8-d162-4844-a660-661f46933d06"), new DateTime(2023, 11, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "Cơ Phá + Nhảy", 0, new DateTime(2023, 11, 5, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("357267e8-d162-4844-a660-661f46933d07"), new DateTime(2024, 1, 15, 20, 37, 17, 520, DateTimeKind.Local).AddTicks(6022), "Cơ ba băng", 0, new DateTime(2024, 1, 15, 20, 37, 17, 520, DateTimeKind.Local).AddTicks(6029) }
                });

            migrationBuilder.InsertData(
                table: "Employees",
                columns: new[] { "Id", "AccessFailedCount", "Address", "ConcurrencyStamp", "CreateDate", "DateOfBirth", "Email", "EmailConfirmed", "Facebook", "FullName", "Gender", "Image", "Instagram", "Linkedin", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "Status", "Twitter", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { new Guid("40b601c0-2c08-449f-a41e-7564648f2c87"), 0, "Hoa Thanh Quế", "e4bf7cff-6b1d-4814-801c-02470855c7e5", new DateTime(2020, 10, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2003, 8, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), "quocphuong@gmail.com", false, "https://facebook.com/#", "Phạm Nguyễn Quốc Phương", 0, "phuongpnq.png", "https://instagram.com/#", "https://linkedin.com/#", true, null, "QUOCPHUONG@GMAIL.COM", "QUOCPHUONG", "AQAAAAEAACcQAAAAEDnw9/bad7RVII19Bn9Zetmhe4D2/RUELI0q65G6PgafUeSuvXTxEHTAC/hp5s372A==", "06969433323", false, "4GK7QXS2ZVKDV4BO2GGNSUH5SIGOGCMZ", 0, "https://twitter.com/#", false, "QuocPhuong" },
                    { new Guid("dbca0788-4fb0-4986-8928-4df593da3f5e"), 0, "Hoa Thanh Quế", "e4bf7cff-6b1d-4814-801c-02470855c7e5", new DateTime(2020, 12, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2000, 10, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), "vanphuong@gmail.com", false, "https://facebook.com/#", "Mai Văn Phương", 0, "phuongmv.png", "https://instagram.com/#", "https://linkedin.com/#", true, null, "VANPHUONG@GMAIL.COM", "VANPHUONG", "AQAAAAEAACcQAAAAEDnw9/bad7RVII19Bn9Zetmhe4D2/RUELI0q65G6PgafUeSuvXTxEHTAC/hp5s372A==", "0386753434", false, "4GK7QXS2ZVKDV4BO2GGNSUH5SIGOGCMZ", 0, "https://twitter.com/#", false, "VanPhuong" }
                });

            migrationBuilder.InsertData(
                table: "Payments",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { new Guid("a51f7c3c-a8e7-4c0a-aeea-b6fc70492b16"), "Chuyển khoản ngân hàng" },
                    { new Guid("a51f7c3c-a8e7-4c0a-aeea-b6fc70492bf6"), "Ship COD (Thanh toán khi nhận hàng)" }
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
                    { new Guid("b108d866-eb13-46e3-b3d2-ecae4fbfe872"), "da4e19a0-8ba3-4ff0-aa42-ce2460026da9", "Quản lý", "QUẢN LÝ" },
                    { new Guid("b108d866-eb13-46e3-b3d2-ecae4fbfe873"), "4b500818-4382-413f-a7ba-306501d03c37", "Nhân viên", "NHÂN VIÊN" }
                });

            migrationBuilder.InsertData(
                table: "Shafts",
                columns: new[] { "Id", "Color", "Length", "Material", "Name", "Price", "Size", "Status" },
                values: new object[,]
                {
                    { new Guid("cc37720a-7e89-463a-9510-1936e6761d53"), "Đen", 29, "Carbon Fiber Composite", "REVO 11.8 Black Vault Plate Uni-Loc® Quick Release", 140.0, 11.800000000000001, 0 },
                    { new Guid("cc37720a-7e89-463a-9510-1936e6761d63"), "Đen", 29, "Carbon Fiber Composite", "REVO 11.8 White Vault Plate Uni-Loc® Quick Release", 90.0, 11.800000000000001, 0 },
                    { new Guid("cc37720a-7e89-463a-9510-1936e6761d73"), "Đen", 29, "Carbon Fiber Composite", "REVO 12.4 White Vault Plate Uni-Loc® Quick Release", 120.0, 12.4, 0 },
                    { new Guid("cc37720a-7e89-463a-9510-1936e6761d83"), "Gỗ", 29, "Gỗ Maple", "Vantage Uni-Loc® P3 Thin Black Collar", 100.0, 12.9, 0 }
                });

            migrationBuilder.InsertData(
                table: "Tips",
                columns: new[] { "Id", "Color", "Length", "Material", "Name", "Price", "Size", "Status" },
                values: new object[,]
                {
                    { new Guid("cc37720a-7e89-463a-9510-1936e6761d04"), "Đen", 10, "Siêu mềm", "Kamui Clear Black - Super Soft", 28.300000000000001, 13, 0 },
                    { new Guid("cc37720a-7e89-463a-9510-1936e6761d14"), "Đen", 10, "Mềm mại", "Kamui Clear Black - Soft", 28.300000000000001, 13, 0 },
                    { new Guid("cc37720a-7e89-463a-9510-1936e6761d24"), "Đen", 10, "Trung bình", "Kamui Clear Black - Medium", 28.300000000000001, 13, 0 },
                    { new Guid("cc37720a-7e89-463a-9510-1936e6761d34"), "Đen", 10, "Cứng", "Kamui Clear Black - Hard", 28.300000000000001, 13, 0 },
                    { new Guid("cc37720a-7e89-463a-9510-1936e6761d44"), "Đen", 10, "Cứng", "Kamui Black - Hard", 26.800000000000001, 13, 0 },
                    { new Guid("cc37720a-7e89-463a-9510-1936e6761d54"), "Đen", 10, "Trung bình", "Kamui Black - Medium", 26.800000000000001, 13, 0 },
                    { new Guid("cc37720a-7e89-463a-9510-1936e6761d64"), "Đen", 10, "Mềm mại", "Kamui Black - Soft", 26.800000000000001, 13, 0 },
                    { new Guid("cc37720a-7e89-463a-9510-1936e6761d74"), "Đen", 10, "Siêu mềm", "Kamui Black  - Super Soft", 26.800000000000001, 13, 0 }
                });

            migrationBuilder.InsertData(
                table: "Tips",
                columns: new[] { "Id", "Color", "Length", "Material", "Name", "Price", "Size", "Status" },
                values: new object[,]
                {
                    { new Guid("cc37720a-7e89-463a-9510-1936e6761d84"), "Đen", 10, "Siêu mềm", "Kamui Original Clear Super Soft", 24.800000000000001, 13, 0 },
                    { new Guid("cc37720a-7e89-463a-9510-1936e6761d94"), "Đen", 10, "Mềm mại", "Kamui Original Clear Soft", 24.800000000000001, 13, 0 }
                });

            migrationBuilder.InsertData(
                table: "Weights",
                columns: new[] { "Id", "Name", "Price", "Status" },
                values: new object[,]
                {
                    { new Guid("cc37720a-7e89-463a-9510-1936e6761d55"), "21oz", 0.0, 0 },
                    { new Guid("cc37720a-7e89-463a-9510-1936e6761d65"), "20oz", 0.0, 0 },
                    { new Guid("cc37720a-7e89-463a-9510-1936e6761d75"), "19oz", 0.0, 0 },
                    { new Guid("cc37720a-7e89-463a-9510-1936e6761d85"), "18oz", 0.0, 0 }
                });

            migrationBuilder.InsertData(
                table: "Customers",
                columns: new[] { "Id", "AccessFailedCount", "Address", "ConcurrencyStamp", "CreateDate", "DateOfBirth", "Email", "EmailConfirmed", "FullName", "Gender", "Image", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "Point", "RankId", "SecurityStamp", "Status", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { new Guid("a77f8ae9-af3d-4288-bbf3-8f77776f9230"), 0, "Hoa Thanh Quế", "e4bf7cff-6b1d-4814-801c-02470855c7e5", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2003, 11, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), "quynhanh@gmail.com", false, "Quỳnh Anh", 1, "anhq.png", true, null, "QUYNHANH@GMAIL.COM", "QUYNHANH", "AQAAAAEAACcQAAAAEDnw9/bad7RVII19Bn9Zetmhe4D2/RUELI0q65G6PgafUeSuvXTxEHTAC/hp5s372A==", "0363636363", false, 12000, new Guid("a77f8ae9-af3d-4288-bbf3-8f77776f9236"), "4GK7QXS2ZVKDV4BO2GGNSUH5SIGOGCMZ", 0, false, "QuynhAnh" },
                    { new Guid("a77f8ae9-af3d-4288-bbf3-8f77776f9231"), 0, "Hoa Thanh Quế", "e4bf7cff-6b1d-4814-801c-02470855c7e5", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2003, 10, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), "thanhtung@gmail.com", false, "Hoàng Thanh Tùng", 0, "tunght.png", true, null, "THANHTUNG@GMAIL.COM", "THANHTUNG", "AQAAAAEAACcQAAAAEDnw9/bad7RVII19Bn9Zetmhe4D2/RUELI0q65G6PgafUeSuvXTxEHTAC/hp5s372A==", "0696969696", false, 12000, new Guid("a77f8ae9-af3d-4288-bbf3-8f77776f9236"), "4GK7QXS2ZVKDV4BO2GGNSUH5SIGOGCMZ", 0, false, "ThanhTung" }
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
                table: "Posts",
                columns: new[] { "Id", "Content", "CreatedDate", "Description", "EmployeeId", "Image", "Status", "Title", "UpdatedDate" },
                values: new object[,]
                {
                    { new Guid("1e510dc9-e8fd-40fc-ac14-19e701736531"), "Giải carom 3 băng Veghel World Cup 2023 kết thúc khuya ngày 28/10 mới đây chứng kiến màn lên ngôi rất thuyết phục của Dick Jaspers. Với phong độ ấn tượng, siêu sao người Hà Lan chỉ mất đúng 12 lượt cơ để đánh bại cơ thủ số 1 nước Đức Martin Horn với cách biệt 50-22 để giành chức vô địch.\r\n\r\nNgay sau khi giải đấu kết thúc, Liên đoàn carom 3 băng thế giới (UMB) đã cập nhật điểm số và công bố bảng xếp hạng thế giới mới với rất nhiều bất ngờ thú vị. Trong đó, điểm nhấn lớn nhất là việc “thần đồng” 25 tuổi người Hàn Quốc Cho Myung Woo bất ngờ leo lên ngôi số 1 thế giới.\r\n\r\nMặc dù dừng bước ở vòng 16 và giữ nguyên số điểm là 258 điểm, Cho Myung Woo lại chiếm lấy vị trí đỉnh BXH của Marco Zanetti khi siêu sao người Ý sớm bị loại từ vòng bảng, qua đó chỉ còn 257 điểm, thua đúng 1 điểm trước Cho Myung Woo khiến ông rơi xuống vị trí thứ 2.\r\n\r\nMột trong những nguyên nhân khiến Marco Zanetti bị loại sớm và mất ngôi số 1 đến từ trận thua sốc trước Chiêm Hồng Thái. Cụ thể ở lượt trận mở màn vòng bảng, tài năng 24 tuổi của Việt Nam đã thể hiện phong độ xuất thần để đánh bại siêu sao người Ý với tỉ số 40-25 sau 20 lượt cơ.\r\n\r\nTiếp đà hưng phấn, Hồng Thái đã một mạch tiến vào đến tứ kết và trở thành cơ thủ Việt Nam lọt vào sâu nhất tại giải đấu này. Với màn thể hiện ấn tượng, Hồng Thái đã thăng tiến 9 bậc từ hạng 30 lên hạng 21 thế giới với 123 điểm.\r\n\r\n2 cơ thủ khác của Việt Nam là Trần Thanh Lực (từ hạng 35 lên hạng 29 thế giới) và Nguyễn Trần Thanh Tự (từ hạng 62 lên 56 thế giới) cũng có sự thăng tiến nhẹ khi vượt qua vòng loại để góp mặt ở vòng chính. Ngoài ra, Trần Quyết Chiến (hạng 5 thế giới) và Bao Phương Vinh (hạng 11 thế giới) giữ nguyên thứ hạng của mình.\r\n\r\nMặt khác, trong top 10 thế giới có thêm chút thay đổi khi Eddy Merckx tăng 2 bậc lên hạng 6 thế giới, đẩy Sameh Sidhom xuống hạng 7. Với khoảng cách về điểm số là rất ít, BXH được dự báo sẽ biến động rất mạnh ở chặng World Cup tiếp theo sẽ diễn ra tại Hàn Quốc vào đầu tháng 11 tới đây.", new DateTime(2024, 1, 15, 20, 37, 17, 520, DateTimeKind.Local).AddTicks(9754), "(Tin thể thao, tin bi-a) Những kết quả bất ngờ tại giải carom 3 băng Veghel World Cup 2023 đã khiến bảng xếp hạng carom 3 băng thế giới có nhiều sự thay đổi thú vị.", new Guid("40b601c0-2c08-449f-a41e-7564648f2c87"), "slidenews1.jpg", 0, "Nóng bảng xếp hạng bi-a thế giới: Hồng Thái “bay cao”, “thần đồng” Hàn Quốc lên số 1", new DateTime(2024, 1, 15, 20, 37, 17, 520, DateTimeKind.Local).AddTicks(9756) },
                    { new Guid("1e510dc9-e8fd-40fc-ac14-19e701736532"), "Hanoi Pool Open Championship 2023 đã kết thúc tại Hà Nội vào 15/10 nhưng dư âm về sự kiện này vẫn đang kéo dài. Giải đấu pool quốc tế lần đầu tiên tổ chức tại Thủ đô giúp khán giả Việt Nam tới gần hơn với những cơ thủ hàng đầu thế giới, hay huyền thoại lừng danh thế giới, các tay cơ chủ nhà cũng có dịp thi đấu, cọ xát với đối thủ lớn.\r\n\r\nĐáng tiếc, không có tay cơ nào của Việt Nam đi tiếp sau vòng knock-out, dù vậy những Anh Tuấn, Đức Thiện, Thành Kiên..., đặc biệt là Đỗ Khải tạo dấu ấn đậm nét với khán giả và bạn bè quốc tế.\r\n\r\nVới phong cách thi đấu phóng khoáng và có phần \"hoang dã\", Đỗ Khải là cái tên gây sốt nhất tại Hanoi Open. Tay cơ \"Khải tóc dài\" có thêm biệt danh \"Quý ông người Pháp\" sau khi trao nụ hôn lên tay của CEO Matchroom Multi Sports, bà Emily Frazer.\r\n\r\nNhờ lối thi đấu mang đậm tính giải trí, Đỗ Khải đã được thi đấu trận giao lưu với huyền thoại Efren Reyes, cơ thủ 69 tuổi, được mệnh danh \"Phù thủy\" bi-a tới từ Philippines.\r\n\r\nNhưng chưa hết, \"Khải tóc dài\" còn được cơ thủ số 1 bi-a pool (do Matchroom xếp hạng) Francisco Sanchez Ruiz \"mời gia nhập\" đội tuyển châu Âu.\r\n\r\nMosconi Cup 2023 diễn ra từ 6 tới 9/12 tại Anh, Team Europe (đội bi-a châu Âu) đã xác định được 3/5 cái tên bao gồm Sanchez Ruiz, David Alcaide và Jayson Shaw. 2/5 suất còn lại là suất wildcard (suất đặc cách) và sẽ được lựa chọn tùy ý theo quyết định riêng của từng đội tuyển.\r\n\r\nTrong phần bình luận mới đây, cơ thủ người Tây Ban Nha Sanchez Ruiz đã nhắc tới tên của Đỗ Khải, anh này mong muốn cơ thủ Việt Nam sẽ là thành viên nhận 1 trong suất còn lại của tuyển châu Âu.\r\n\r\nRõ ràng đây chỉ là bình luận vui vẻ của cơ thủ Ruiz, dù có biệt danh là \"Quý ông người Pháp\" nhưng Đỗ Khải mang quốc tịch Việt Nam vì thế anh không thể chơi cho đội tuyển châu Âu ở giải đồng đội sắp tới.\r\n\r\nTất nhiên chuyện gì cũng có thể xảy ra. Nếu Mosconi Cup 2023 có màn thi đấu giao lưu dành cho khách mời như ở Hanoi Open vừa qua, thì rất có khả năng Đỗ Khải sẽ trở thành khách mời đặc biệt.", new DateTime(2024, 1, 15, 20, 37, 17, 520, DateTimeKind.Local).AddTicks(9760), "(Tin thể thao, tin bi-a) Francisco Sanchez Ruiz nhắn nhủ lời đặc biệt tới cơ thủ Đỗ Khải của Việt Nam.", new Guid("40b601c0-2c08-449f-a41e-7564648f2c87"), "post2.jpg", 0, "Cơ thủ bi-a số 1 thế giới tiến cử \"Khải tóc dài\" thi đấu cho tuyển châu Âu", new DateTime(2024, 1, 15, 20, 37, 17, 520, DateTimeKind.Local).AddTicks(9760) },
                    { new Guid("1e510dc9-e8fd-40fc-ac14-19e701736533"), "Sau giải bi-a quốc tế diễn ra ở Hà Nội, lúc này làng bi-a pool đang hướng sự tập trung vào giải vô địch 10 bi nữ thế giới 2023 diễn ra tại Áo từ 18 tới 22/10.\r\n\r\nTrải những trận đấu vòng loại, ban tổ chức đã xác định được 16 cái tên giành vé vào 1/8 thi đấu vào tối 20/10. Gương mặt nhận được nhiều sự quan tâm nhất có lẽ là Pan Xiaoting (Phan Hiểu Đình), VĐV \"tài sắc vẹn toàn\" đến từ Trung Quốc.\r\n\r\nỞ vòng loại, mỹ nhân 41 tuổi trải qua nhiều trận đấu căng thẳng, trong đó phải kể tới màn \"ngược dòng\" thắng Chihiro Kawahara 7-6, trước đó cơ thủ Nhật Bản dẫn trước Hiểu Đình tới 5-0.\r\n\r\nTại vòng đấu dành cho 16 cơ thủ, mỹ nhân Trung Quốc chạm trán Allison Fisher. Đây là trận đấu của hai phong cách đối lập, nếu như Fisher mang phong cách tomboy thì Hiểu Đình là mỹ nhân yểu điệu, duyên dáng của làng billiard thế giới.\r\n\r\nFisher tỏ ra vượt trội hơn, cô đã dẫn tỷ số ván 4-1 sau 5 ván đầu tiên, trong khi Pan Xiaoting dù rất nỗ lực cũng chỉ đủ rút ngắn cách biệt xuống còn 2 điểm. Fisher thắng chung cuộc với tỷ số 9-6.", new DateTime(2024, 1, 15, 20, 37, 17, 520, DateTimeKind.Local).AddTicks(9763), "(Tin thể thao, tin bi-a) Nữ thần bi-a Trung Quốc vừa có màn \"ngược dòng\" ấn tượng trước đối thủ Nhật Bản.", new Guid("dbca0788-4fb0-4986-8928-4df593da3f5e"), "post3.jpg", 0, "\"Nữ thần\" bi-a Trung Quốc đua tài, khoe sắc ở giải vô địch thế giới 2023", new DateTime(2024, 1, 15, 20, 37, 17, 520, DateTimeKind.Local).AddTicks(9763) },
                    { new Guid("1e510dc9-e8fd-40fc-ac14-19e701736534"), "Hanoi Open Pool Championship 2023 tổ chức tại Hà Nội từ 10 tới 15/10 tại Hà Nội mang tới cho khán giả Việt Nam quá nhiều kỷ niệm đáng nhớ. Ở sự kiện bi-a quốc tế tầm cỡ lần đầu tiên diễn ra tại Việt Nam, quy tụ những cơ thủ hàng đầu thế giới, cơ cấu giải thưởng lớn và có cả sự xuất hiện của \"Phù thủy\" Efren Reyes (Philippines).\r\n\r\nNhững siêu sao hàng đầu bi-a pool thế giới như Shane Van Boening, Francisco Sanchez Ruiz, Fedor Gorst, Jayson Shaw... đã trình diễn những đường cơ làm hài lòng những khán giả khó tính nhất. Bên cạnh đó, huyền thoại bi-a được cả thế giới ngưỡng mộ Reyes có hai trận đấu giao lưu mãn nhãn với Anh Tuấn và Đỗ Khải. \r\n\r\nSau trận đấu giao lưu với cơ thủ Anh Tuấn vào tối 14/10, sức hút từ cơ thủ 69 tuổi Philippines đã khiến ban tổ chức tạo thêm màn so cơ không có trong kế hoạch với Đỗ Khải, hay còn gọi là \"Khải tóc dài\", vào chiều 15/10.\r\n\r\nSự kết hợp giữa \"Phù thủy\" Reyes và ngôi sao có khả năng \"phù phép bi chủ\" Đỗ Khải đã tạo ra màn so tài mang nặng tính giải trí. Không chỉ khán giả, trong trận đấu nhiều lần huyền thoại Reyes cũng phải cười phá lên vì những động tác uốn éo như nhảy cùng trái bóng của Đỗ Khải. Reyes thắng 7-4 trước Đỗ Khải và ông sẽ mang theo rất nhiều kỷ niệm về Đỗ Khải, người hâm mộ và không khí cổ vũ tuyệt vời tại Hà Nội. \r\n\r\nKhép lại màn so cơ của Reyes và Đỗ Khải, trận chung kết được chờ đợi nhất giữa Jayson Shaw (Anh) và Albin Ouschan (Áo) mang tới cuộc rượt đuổi tỷ số nghẹt thở. \r\n\r\nLà một trong những cơ thủ chơi ổn định nhất, Shaw cơ thủ có biệt danh \"Mắt đại bàng\" bất ngờ để Albin dẫn 0-4. Chơi tập trung gỡ 3-4, nhưng rồi Shaw tiếp tục bị dẫn trước 6-10.\r\n\r\nBản lĩnh của Shaw được phát huy, \"Mắt đại bàng\" thi đấu cực tốt để vươn lên dẫn trước 12-11. Chỉ cần 1 ván nữa là thắng nhưng cơ thủ người Anh chơi ẩu, đánh lắc lỗ 1 bi ở ván 24, tạo điều kiện cho đối thủ Áo gỡ hòa 12-12.\r\n\r\nVận may cuối cùng ngoảnh mặt với Albin, ở tình huống phá bàn, bi chủ đã rơi xuống lỗ. Được đặt bóng ở vị trí thuận lợi, \"Mắt đại bàng\" tận dụng tốt cơ hội để khép lại trận đấu với tỷ số 13-12, qua đó bước lên ngôi vô địch Hanoi Open Pool Championship 2023. \r\n\r\nShaw nhận cúp và phần thưởng 30.000 USD (733 triệu đồng) cho chức vô địch, á quân Albin nhận 15.000  USD (366 triệu đồng), 2 cơ thủ đồng hạng ba cùng nhận 9.500 USD (232 triệu đồng).", new DateTime(2024, 1, 15, 20, 37, 17, 520, DateTimeKind.Local).AddTicks(9766), "(Tin thể thao, tin bi-a) Ngày cuối cùng Hanoi Open Pool Championship để lại nhiều ấn tượng khó quên với khán giả hâm mộ billiards (bi-a) trong nước và thế giới.", new Guid("dbca0788-4fb0-4986-8928-4df593da3f5e"), "post4.jpg", 0, "Reyes đánh bại \"Khải tóc dài\", Jayson Shaw vô địch nghẹt thở giải bi-a ở Hà Nội", new DateTime(2024, 1, 15, 20, 37, 17, 520, DateTimeKind.Local).AddTicks(9766) },
                    { new Guid("1e510dc9-e8fd-40fc-ac14-19e701736535"), "Hanoi Open Pool Championship 2023, giải bi-a quốc tế tầm cỡ đầu tiên được tổ chức tại Hà Nội từ 10 tới 15/10 dần bước vào những trận đấu cuối cùng. Không chỉ có những cơ thủ hàng đầu tới tranh tài, sự kiện còn \"nóng\" hơn khi huyền thoại 69 tuổi, Efren Reyes xuất hiện vào chiều 14/10.\r\n\r\nTới tham dự giải với tư cách khách mời danh dự, \"Phù thủy\" Philippines tham gia trận đấu biểu diễn với tay cơ số 2 pool Việt Nam Nguyễn Anh Tuấn. Những trận đấu tại vòng knock-out Hanoi Open, cộng với hiệu ứng từ Reyes giúp Cung thể thao Điền kinh trong nhà Mỹ Đình trở nên nhộn nhịp. \r\n\r\nNgay khi xuất hiện, huyền thoại Reyes đã được người hâm mộ vây quanh, ông rất cảm kích trước tình cảm của khán giả dành cho mình. \r\n\r\nNhư để tri ân người xem, ngay ở cơ đánh dạo bàn khởi động đầu tiên, người đàn ông Philippines đã thực hiện pha \"dọn bàn\" đẹp mắt. Toàn bộ 9 bi được \"Phù thủy\" đưa xuống lỗ, đặc biệt nhất là bóng số 9. Dù đó là cơ đánh thẳng tắp để ăn bi số 9, nhưng Reyes đã đưa trái bóng này đi 4 băng trước khi rơi vào lỗ góc. Tình huống khiến nhiều người có mặt rất phấn khích. \r\n\r\nKhi bước vào trận đấu biểu diễn, giao lưu với Nguyễn Anh Tuấn (hạng 107 thế giới theo bảng xếp hạng Matchroom), huyền thoại Philippines vẫn thể hiện được nhiều cơ đánh tốt nhưng \"Tkon\" xuất sắc hơn. \r\n\r\nVới thể thức đánh \"chạm 10\", Reyes và Anh Tuấn tạo ra tỷ số rượt đuổi hấp dẫn, cuối cùng thì tài năng và sức trẻ giúp cơ thủ Việt Nam vượt qua huyền thoại Philippines 10-7. \r\n\r\nDĩ nhiên kết quả này không quá quan trọng, sau trận đấu cơ thủ Anh Tuấn tiến tới xin chữ ký của huyền thoại Reyes và anh thổ lộ \"thầy cũng mệt rồi nên thi đấu không được như ý\". \r\n\r\nCơ thủ Reyes, 69 tuổi, từng vô địch thế giới pool 9 bi năm 1999 và pool 8 bi năm 2004. Reyes không chỉ nổi tiếng bởi những danh hiệu, ông được cả thế giới biết tới thông qua những trận \"đánh độ\" tại quê nhà và phô diễn các đường cơ huyền ảo. \r\n\r\nKhán giả không sai khi đặt cho Reyes biệt danh \"Phù thủy\", người đàn ông sở hữu cả \"kho tàng\" những cú đánh chẳng thể tìm thấy trong sách giáo khoa nào cả.", new DateTime(2024, 1, 15, 20, 37, 17, 520, DateTimeKind.Local).AddTicks(9769), "(Tin thể thao, tin bi-a) Thêm một lần góp mặt tại các sự kiện bi-a tổ chức ở Việt Nam, \"Phù thủy\" Reyes tri ân khán giả bằng pha đi cơ đáng nhớ.", new Guid("40b601c0-2c08-449f-a41e-7564648f2c87"), "post5.jpg", 0, "\"Phù thủy bi-a\" Reyes tri ân khán giả Việt bằng cơ 4 băng kinh điển", new DateTime(2024, 1, 15, 20, 37, 17, 520, DateTimeKind.Local).AddTicks(9769) },
                    { new Guid("1e510dc9-e8fd-40fc-ac14-19e701736536"), "Shane Van Boening, cơ thủ sinh năm 1983 người Mỹ là một trong số những VĐV đặc biệt nhất của làng bi-a thế giới. Anh bị khiếm thính từ nhỏ, bi-a đã giúp cơ thủ phát huy tài năng để tự tin bước ra ngoài trở thành ngôi sao hàng đầu bi-a.\r\n\r\nĐược xem như một trong số cơ thủ bi-a Mỹ giỏi nhất và từng vươn tới số 1 thế giới năm 2020, Boening nổi tiếng với nhiều cơ đánh nhanh, mạnh, chính xác. Ở một giải bi-a pool 9 bi vào năm 2022, cơ thủ Boeing \"dọn bàn\" chỉ sau 72 giây.\r\n\r\nVào tháng trước Boening cũng góp mặt tại sự kiện bi-a tại Hà Nội, dù không giành được chức vô địch nhưng cơ thủ người Mỹ để lại nhiều ấn tượng đẹp với người hâm mộ.\r\n\r\nTrong 2 tuần liên tiếp vừa qua, cơ thủ 40 tuổi đăng quang tại giải Vô địch 8 bi thế giới 2023, rồi lên ngôi Bigfoot 10 bi International Open 2023 tại Mỹ.\r\n\r\nVới phong độ rất tốt sau khi giành chức vô địch 10 bi Bigfoot, Boening chỉ mất đúng 1 tiếng 25 phút để đánh bại cơ thủ người Philippines, Joven Bustamante với tỷ số 10-0 tại sự kiện 9 bi International Open 2023 diễn ra ở Mỹ.\r\n\r\nĐể thắng trắng 1 trận đấu bi-a là điều không phải dễ dàng, và Boening đã làm được điều đáng kinh ngạc này. Tỷ số cũng cho thấy khả năng phá bóng rồi \"dọn bàn\" gần như hoàn hảo của cơ thủ 40 tuổi. Suốt trận đấu Bustamante chẳng khác nào khán giả xem Boening đi cơ.", new DateTime(2024, 1, 14, 20, 37, 17, 520, DateTimeKind.Local).AddTicks(9772), "(Tin thể thao, tin bi-a) Thi đấu với tâm lý vững vàng và gần như \"không cảm xúc\", cơ thủ người Mỹ hạ tay cơ Philippines 10-0.", new Guid("40b601c0-2c08-449f-a41e-7564648f2c87"), "post6.jpg", 0, "Cơ thủ chơi bi-a kiểu robot, hạ đối thủ 10-0 mặt vẫn lạnh tanh", new DateTime(2024, 1, 14, 20, 37, 17, 520, DateTimeKind.Local).AddTicks(9776) },
                    { new Guid("1e510dc9-e8fd-40fc-ac14-19e701736537"), "O'Sullivan được mọi người ca ngợi là tay cơ vĩ đại và thành công nhất trong lịch sử bi-a với 7 lần vô địch thế giới cùng lối đánh hoa mỹ. Huyền thoại bi-a Jimmy White cho rằng đỉnh cao của O'Sullivan có thể so sánh với Roger Federer ở môn quần vợt.\r\n\r\nWhite nói: “Đừng nhầm lẫn, đường cơ của O'Sullivan thật huyền ảo! Nó giống như phong cánh chơi tennis của Roger Federer và những người kiểu như vậy. Nhưng O'Sullivan là người cầu toàn và anh ấy có thể nói rằng anh ấy đã chơi rất tệ”.\r\n\r\nO'Sullivan là một fan hâm mộ quần vợt cuồng nhiệt, nhưng tay vợt yêu thích của anh lại là Novak Djokovic, một trong những đối thủ lớn nhất của Federer khi huyền thoại người Thụy Sĩ còn thi đấu.\r\n\r\nNhà vô địch thế giới 7 lần nói: “Federer, Nadal, Djokovic. Tôi luôn thích xem họ thi đấu. Họ là ba tay vợt xuất sắc nhất mọi thời đại. Đối với tôi, Djokovic sẽ là vua của tất cả. Không quan trọng bạn là cầu thủ bóng đá, vận động viên chơi golf, hay vận động viên khúc côn cầu, mọi người đều nhìn vào Djokovic.\r\n\r\nTôi ước gì mình có thể làm được những gì Djokovic đã làm ở quần vợt. Cuộc sống của một vận động viên quần vợt chuyên nghiệp thật khó khăn. Nhưng khi họ ở trên đỉnh cao… thì những địa điểm họ thi đấu thật ấn tượng”.\r\n\r\nThể thức “một chọi một” của quần vợt về mặt nào đó có thể so sánh với bi-a. Đó có thể là lý do tại sao O'Sullivan lại rất ngưỡng mộ Djokovic, tay vợt nam sở hữu nhiều danh hiệu Grand Slam nhất lịch sử với 24 danh hiệu.\r\n\r\nVề phần O'Sullivan, anh đã tạo ra tiếng vang lớn với bộ phim tài liệu mới “The Edge of Everything” trong những ngày gần đây. Bộ phim hấp dẫn được công chiếu ở London (Anh) hôm 28/11, ghi lại những khó khăn về sức khỏe tinh thần của người đàn ông 47 tuổi trong thời gian đầu trong sự nghiệp bi-a của anh, đặc biệt là sau khi cha anh bị bỏ tù vì tội giết người vào năm 1992.\r\n\r\nCơ thủ được mệnh danh là \"Phù thủy bi-a\", hay \"The Rocket\" đã vượt lên tất cả để trở thành ngôi sao thể thao hàng đầu thế giới. Bộ phim lên đến đỉnh điểm với việc O'Sullivan lên ngôi tại giải vô địch bi-a thế giới năm 2022, danh hiệu thứ 7 giúp anh sánh ngang huyền thoại Stephen Hendry.", new DateTime(2024, 1, 14, 20, 37, 17, 520, DateTimeKind.Local).AddTicks(9779), "(Tin thể thao, tin tennis) Huyền thoại bi-a Ronnie O'Sullivan đã dành lời ca ngợi cho Novak Djokovic.", new Guid("dbca0788-4fb0-4986-8928-4df593da3f5e"), "post7.jpg", 0, "\"Phù thủy\" bi-a ngưỡng mộ Djokovic, dù được so sánh với Federer", new DateTime(2024, 1, 14, 20, 37, 17, 520, DateTimeKind.Local).AddTicks(9779) },
                    { new Guid("1e510dc9-e8fd-40fc-ac14-19e701736538"), "Cựu số 1 bi-a snooker, từng vô địch thế giới Judd Trump (Anh) khiến khán giả Trung Quốc có phần hụt hẫng khi loại bỏ \"Thần đồng\" 12 nước này một cách nhanh chóng.\r\n\r\nTay cơ 34 tuổi có biệt danh \"Át chủ bài\" thể hiện thái độ thi đấu cực kỳ chuyên nghiệp, anh coi VĐV 12 tuổi là đối thủ, vì thế chơi nghiêm túc, không bộ lộ nhiều cảm xúc.\r\n\r\nKhi Trump chơi tập trung, cơ hội dành cho Wang Xinzhong không nhiều. Tại vòng loại International Championship 2023 diễn ra tại Thiên Tân, Trung Quốc (từ 5 tới 12/11), Trump nhanh chóng đánh bại Wang 6-0 để giành vé vào đấu chính thức.\r\n\r\nTừ một ngôi sao được đặt nhiều kỳ vọng, \"Thần đồng\" Wang đã phải \"trở lại mặt đất\" sau trận đấu gặp Trump. Nhiều khán giả chủ nhà bày tỏ sự thất vọng, có người tỏ ra rất sốc.\r\n\r\n\"Thần đồng\" 12 tuổi bị thua nhanh chóng, vẫn còn nhiều thời gian để xóa khoảng cách về trình độ\", một người viết. \"Cậu bé mới chỉ 12 tuổi, thật khó vượt qua cú sốc từ trận đấu này\", người khác viết. \"Cậu ấy mới có 12 tuổi thôi, có thể ưu ái một chút được không?\", tài khoản khác viết.\r\n\r\nSố 3 thế giới Trump đối mặt với Michael White (Xứ Wales) ở vòng đấu tiếp theo. Trump đã vô địch ở sự kiện tổ chức năm 2019. Cho đến nay, Mark Selby là tay vợt duy nhất bảo vệ thành công chức vô địch vào năm 2016, 2017.", new DateTime(2024, 1, 14, 20, 37, 17, 520, DateTimeKind.Local).AddTicks(9782), "(Tin thể thao, tin bi-a) Judd Trump không hề nương tay khi so tài với \"Thần đồng\" bi-a Trung Quốc 12 tuổi.", new Guid("dbca0788-4fb0-4986-8928-4df593da3f5e"), "post8.jpg", 0, "Số 3 thế giới Trump đưa \"Thần đồng\" bi-a 12 tuổi \"trở lại mặt đất\"", new DateTime(2024, 1, 14, 20, 37, 17, 520, DateTimeKind.Local).AddTicks(9783) },
                    { new Guid("1e510dc9-e8fd-40fc-ac14-19e701736539"), "Mới đây scandal từ chối thi đấu bi-a diễn ra tại sự kiện Ladies Champions of Champions ở Denbighshire, Xứ Wales. Nữ cơ thủ Lynne Pinches từ chối so tài với Harriet Haynes, vì đây là VĐV chuyển giới nam thành nữ.\r\n\r\nĐoạn phim ghi lại cho thấy, nữ cơ thủ đến gần trọng tài để thông báo về không thi đấu, rồi vẫy tay chào khán giả. Cô quay trở lại chỗ ngồi của mình, thu dọn đồ đạc và rời khỏi đấu trường trước sự choáng váng của người xem. Haynes không hiểu chuyện gì xảy ra, sau đó nghiễm nhiên trở thành nhà vô địch.\r\n\r\nAnh trai của Pinches, Barry, lên mạng xã hội để khen ngợi em gái mình là người \"có lập trường\" và cho rằng việc phải thi đấu với 1 người chuyển giới là \"không công bằng\".\r\n\r\nBarry nói: \"Tôi hoàn toàn đồng ý với quan điểm của em gái mình, việc phụ nữ thi đấu với một VĐV chuyển giới ở bất kỳ môn thể thao nào cũng hoàn toàn không công bằng\".\r\n\r\nPinches từng là một trong số các VĐV nữ hàng đầu lên tiếng về việc phụ nữ chuyển giới được phép thi đấu tại các sự kiện lớn.\r\n\r\nCuộc tranh cãi hiện đang làm rung chuyển các giải đấu bi-a chuyên nghiệp từ 24/10, thời điểm Liên đoàn bi-a 8 bóng thế giới (WEPF) thay đổi quy định, cho phép người chuyển giới tham dự các giải đấu dành cho nữ.\r\n\r\nLuật được thông qua, những cơ thủ nam chuyển giới thành nữ đủ điều kiện tham dự giải nữ, mặc cho làn sóng phản đối họ thi đấu. Cơ thủ chuyển giới chỉ làm theo luật, nhưng điều đáng tiếc, họ không được chào đón ở nhiều sự kiện.", new DateTime(2024, 1, 14, 20, 37, 17, 520, DateTimeKind.Local).AddTicks(9785), "(Tin thể thao, tin bi-a) Lynne Pinches không màng tới chiếc cúp vô địch, cô từ chối thi đấu để phản đối đối thủ.", new Guid("dbca0788-4fb0-4986-8928-4df593da3f5e"), "post9.jpg", 0, "Chấn động bi-a: Nữ cơ thủ bỏ đấu chung kết để phản ứng đối thủ", new DateTime(2024, 1, 14, 20, 37, 17, 520, DateTimeKind.Local).AddTicks(9785) },
                    { new Guid("1e510dc9-e8fd-40fc-ac14-19e701736540"), "Giải carom 3 băng Seoul World Cup 2023 kết thúc cuối tuần vừa qua tại Hàn Quốc chứng kiến màn đăng quang thuyết phục của siêu sao 55 tuổi Eddy Merckx. Đối đầu “thần đồng” đang xếp hạng 1 thế giới Cho Myung Woo, tay cơ người Bỉ đã nhập cuộc tự tin để dẫn trước đến 20-4. Dù Cho Myung Woo đã nỗ lực rút ngắn cách biệt, Eddy Merckx giữ vững phong độ để về đích với chiến thắng 50-43 sau 21 lượt cơ.\r\n\r\nEddy Merckx một lần nữa khẳng định vì sao được xem là “ông vua của những trận chung kết” khi đây đã là chức vô địch World Cup thứ 13 của ông chỉ sau 14 lần vào chung kết. “Thần cơ nước Bỉ” cũng là tay cơ vô địch World Cup nhiều nhất khi rời châu Âu với 4 lần vô địch ở Hàn Quốc, 3 lần ở Ai Cập và 2 lần tại Việt Nam. Ông là tay cơ vô địch World Cup ở Hàn Quốc nhiều nhất trên thế giới.\r\n\r\nTuy nhiên do phải bảo vệ 80 điểm với chức vô địch trước đó nên thứ hạng của Eddy Merckx (hạng 6 thế giới) vẫn giữ nguyên khi Liên đoàn carom thế giới (UMB) công bố bảng xếp hạng (BXH) carom 3 băng thế giới mới ngay sau Seoul World Cup 2023. Ngược lại, BXH này mang đến tin vui cho các cơ thủ Việt Nam.\r\n\r\nNếu như Trần Quyết Chiến vẫn giữ nguyên vị trí hạng 5 thế giới của mình thì Bao Phương Vinh tiếp tục thiết lập cột mốc ấn tượng mới cho bản thân khi tăng 2 bậc lên hạng 9 thế giới. Rõ ràng khi chỉ mới 28 tuổi, nhà đương kim vô địch thế giới sẽ còn có thể tiến xa hơn trong tương lai.\r\n\r\nViệc Phương Vinh vươn lên hạng 9 cũng làm người hâm mộ phấn khích khi đã rất lâu rồi, carom 3 băng Việt Nam mới lại được chứng kiến việc có 2 cơ thủ Việt Nam cùng nằm trong top 10 thế giới.\r\n\r\nTrên BXH thế giới hiện tại, Việt Nam là 1 trong 2 quốc gia có 2 tay cơ nằm trong top 10 (cùng với Hàn Quốc). Với việc vào đến vòng 1/8 và là cơ thủ Việt Nam tiến xa nhất ở giải đấu này, tay cơ 24 tuổi Chiêm Hồng Thái tăng 2 bậc lên hạng 19 thế giới.\r\n\r\nMột số thay đổi đáng chú ý, Dick Jaspers và Torbjorn Blomdahl đổi chỗ cho nhau khi Dick Jaspers lên hạng 3 thế giới, còn Blomdahl xuống vị trí thứ 4. Kim Haeng Jik tăng 2 bậc lên hạng 8 thế giới. Cơ thủ số 1 của Thổ Nhĩ Kỳ Tayfun Tasdemir từ hạng 9 xuống hạng 11 thế giới. Chặng World Cup tiếp theo sẽ diễn ra từ ngày 3-9/12 tại Ai Cập.", new DateTime(2024, 1, 14, 20, 37, 17, 520, DateTimeKind.Local).AddTicks(9788), "(Tin thể thao, tin bi-a) Cơ thủ Bao Phương Vinh thiết lập cột mốc mới trên bảng xếp hạng carom 3 băng thế giới, qua đó giúp Billiards Việt Nam hiện có 2 cơ thủ nằm trong top 10.", new Guid("40b601c0-2c08-449f-a41e-7564648f2c87"), "post10.jpg", 0, "Nức lòng bi-a Việt Nam: 2 cơ thủ lọt top 10 thế giới, Bao Phương Vinh lập mốc mới", new DateTime(2024, 1, 14, 20, 37, 17, 520, DateTimeKind.Local).AddTicks(9788) },
                    { new Guid("1e510dc9-e8fd-40fc-ac14-19e701736541"), "Đây là trận đấu mà Hồng Thái đã bị đối thủ kỳ cựu dẫn trước đến 10-21 sau hiệp đầu. Dù vậy trong hiệp 2, cơ thủ mới 24 tuổi của Việt Nam vùng lên mạnh mẽ với nhiều series ghi điểm trung bình để dẫn ngược lại 31-28.\r\n\r\nBury sau đó có tiếp một cú đánh ghi 6 điểm để dẫn 39-34. Khi đối thủ chỉ còn đúng 1 điểm, Hồng Thái cho thấy bản lĩnh đáng nể để ghi thêm 6 điểm và cầm hòa đối thủ với cách biệt 40-40 sau 25 lượt cơ.\r\n\r\nỞ lượt trận cuối cùng của bảng đấu, Hồng Thái làm nức lòng người hâm mộ bi-a nước nhà khi đánh bại tay cơ người Áo Gerhard Kostistansky với tỉ số 40-19 chỉ sau 16 lượt cơ để độc chiếm ngôi đầu bảng và giành suất đi tiếp vào vòng knock-out top 16. Ở lượt trận còn lại của bảng đấu này, Sameh Sidhom với đường cơ 15 điểm đã đánh bại Jeremy Bury để giành ngôi nhì bảng cùng suất đi tiếp còn lại.\r\n\r\nĐáng tiếc ở bảng G, Phương Bao Vinh đã để thua Myeong Jong Cha (Hàn Quốc) với tỉ số 31-40 sau 21 lượt cơ trong trận đấu quyết định cho suất đi tiếp. Ngoài ra tại bảng E, Trần Quyết Chiến bị loại khi để thua cả 3 trận.\r\n\r\nNhư vậy, Chiêm Hồng Thái là đại diện duy nhất của Việt Nam tại vòng knock-out của 16 tay cơ xuất sắc nhất giải. Đối thủ của Hồng Thái tại vòng đấu này là Ruben Legazpi (Tây Ban Nha). Trận đấu diễn ra vào lúc 12h ngày 11/11 (theo giờ Việt Nam).", new DateTime(2024, 1, 15, 20, 37, 17, 520, DateTimeKind.Local).AddTicks(9791), "(Tin thể thao, tin bi-a) Sau khi gây sốc với chiến thắng trước cơ thủ hạng 7 thế giới Sameh Sidhom, Chiêm Hồng Thái tiếp tục thể hiện phong độ ấn tượng khi xuất sắc cầm hòa “quái kiệt bi-a” Jeremy Bury ở lượt trận thứ 2 tại bảng F trong khuôn khổ vòng bảng chính thức giải carom 3 băng Seoul World Cup 2023.", new Guid("dbca0788-4fb0-4986-8928-4df593da3f5e"), "post11.jpg", 0, "Chiêm Hồng Thái “đại náo” bi-a World Cup, ngoạn mục vượt bảng “tử thần”", new DateTime(2024, 1, 15, 20, 37, 17, 520, DateTimeKind.Local).AddTicks(9792) },
                    { new Guid("1e510dc9-e8fd-40fc-ac14-19e701736542"), "Vòng bảng chính thức giải carom 3 băng Veghel World Cup 2023 kết thúc vào rạng sáng ngày 27/10 tại Hà Lan chứng kiến nhiều diễn biến hấp dẫn, trong đó có những màn thể hiện ấn tượng của hai cơ thủ Việt Nam là Chiêm Hồng Thái và Trần Quyết Chiến.\r\n\r\nTại bảng B, Chiêm Hồng Thái sớm gây chấn động khi đánh bại cơ thủ số 1 thế giới Marco Zanetti (Ý) với tỉ số 40-25 chỉ sau 20 lượt cơ. Mặc dù để thua Sam Van Etten (Hà Lan) ở lượt trận tiếp theo, tài năng trẻ 24 tuổi của Việt Nam kịp lấy lại tinh thần để có chiến thắng quyết định trước Jeong Ye Sung (Hàn Quốc) với cách biệt 40-33 sau 32 lượt cơ để đứng nhì bảng B, cùng Sam Van Etten (nhất bảng) giành 2 suất đi tiếp vào vòng 16 tại bảng đấu này.\r\n\r\nTrong khi đó ở bảng H, Trần Quyết Chiến sớm giành quyền đi tiếp trước 1 lượt đấu bằng 2 chiến thắng liên tiếp trước Nguyễn Trần Thanh Tự (40-36 sau 27 lượt cơ) và Peter Ceulemans (40-22 sau 17 lượt cơ). Mặc dù Quyết Chiến để thua lượt trận cuối cùng trước Kim Haeng Jik, cơ thủ số 1 Việt Nam vẫn giành ngôi nhất bảng để cùng tay cơ người Hàn Quốc có suất đi tiếp, còn Thanh Tự bị loại.\r\n\r\nĐáng tiếc nhất phải kể đến trường hợp bị loại của Trần Thanh Lực tại bảng E. Cơ thủ của Việt Nam đã khởi đầu như mơ bằng chiến thắng ấn tượng 40-36 sau 22 lượt cơ trước thần đồng đang xếp hạng 2 thế giới Cho Myung Woo, dù cơ thủ người Hàn Quốc đã có series 11 ở trận đấu này.\r\n\r\nTuy nhiên sau đó, Thanh Lực hòa 40-40 trước Barry Van Beers (Hà Lan) và để thua Nikos Polychronopoulos (Hi Lạp) với tỉ số 25-40 sau 13 lượt cơ. Đáng nói trong trận đấu với Nikos, Thanh Lực dẫn trước đến 18-1 thì bất ngờ tay cơ người Hi Lạp tung “cơ điên” lên đến 25 điểm để lật ngược tình thế. Hai cơ thủ giành suất đi tiếp tại bảng đấu này là Cho Myung Woo và Nikos Polychronopoulos.\r\n\r\nĐại diện còn lại của Việt Nam là Bao Phương Vinh cũng bị loại khi chỉ đứng thứ 3 tại bảng D. Nhà đương kim vô địch thế giới có được chiến thắng trước cơ thủ hạng 6 thế giới Sameh Sidhom (Ai Cập) nhưng để thua hai đối thủ còn lại là Heo Jung Han (Hàn Quốc, tỉ số 24-40) và Berkay Karakurt (Thổ Nhĩ Kỳ, tỉ số 36-40).\r\n\r\nNhư vậy, tuyển billiards Việt Nam có 2 đại diện góp mặt ở vòng 16 diễn ra chiều tối ngày 27/10 là Trần Quyết Chiến và Chiêm Hồng Thái. Tại vòng đấu này, Quyết Chiến sẽ gặp tay cơ vừa có series 25 điểm Nikos Polychronopoulos (Hi Lạp), còn Hồng Thái đụng độ Berkay Karakurt (Thổ Nhĩ Kỳ). Bên cạnh đó, lượt trận tứ kết sẽ diễn ra vào khuya cùng ngày.", new DateTime(2024, 1, 15, 20, 37, 17, 520, DateTimeKind.Local).AddTicks(9794), "(Tin thể thao, tin bi-a) Nếu như Trần Quyết Chiến và Chiêm Hồng Thái thi đấu ấn tượng để tiến sâu thì Trần Thanh Lực bị loại sốc bởi đường cơ 25 điểm.", new Guid("40b601c0-2c08-449f-a41e-7564648f2c87"), "post12.jpg", 0, "Trần Quyết Chiến tung hoành bi-a World Cup, choáng “cơ điên” 25 điểm loại Thanh Lực", new DateTime(2024, 1, 15, 20, 37, 17, 520, DateTimeKind.Local).AddTicks(9794) },
                    { new Guid("1e510dc9-e8fd-40fc-ac14-19e701736543"), "Giải Billiards siêu cúp Việt Nam – Hàn Quốc (Hollywood Super Cup) năm 2023 diễn ra tại TP.HCM trong 2 ngày 25 và 26/11. Đây là lần thứ hai, tuyển Billiards Việt Nam và Hàn Quốc gặp nhau ở giải đấu đồng đội hấp dẫn ở cả hai nội dung pool và carom 3 băng. Trước đó ở lần đầu tiên diễn ra tại Quảng Nam hồi tháng 2 năm nay, tuyển Billiards Việt Nam đã có màn ngược dòng ngoạn mục để giành chiến thắng.\r\n\r\nVới quyết tâm “đòi nợ”, tuyển Billiards Hàn Quốc đã mang đến giải đội hình rất mạnh với dàn cơ thủ nổi tiếng xứ sở Kim chi như nhà vô địch Carom 3 băng World Cup Heo Jung Han, Kim Jun Tae (hạng 13 thế giới), các nữ cơ thủ tài năng và xinh đẹp như Choi Bo-me, Heo Chae Won, Lee Woo Jin…\r\n\r\nTrong khi đó, tuyển Việt Nam có lực lượng được xem là tốt nhất với Trần Quyết Chiến (hạng 5 thế giới), đương kim vô địch World Championship Bao Phương Vinh, hai cơ thủ nữ hàng đầu Nguyễn Hoàng Yến Nhi và Phùng Kiện Tường ở nội dung carom 3 băng.  Ở nội dung pool, tuyển Việt Nam có mặt Dương Quốc Hoàng, Bùi Xuân Vàng và Huỳnh Thị Ngọc Huyền.\r\n\r\nTheo lịch thi đấu, ngày 25/11 diễn ra nội dung pool với các trận đấu đơn nam, 2 trận đơn nữ, đôi nam nữ và đồng đội. Nội dung carom 3 băng sẽ thi đấu vào ngày 26/11 với 2 trận đơn nam, 2 trận đơn nữ cùng đồng đội tiếp sức. Đội giành chiến thắng chung cuộc sẽ nhận 20.000 USD (khoảng 484 triệu đồng) và đội thua sẽ nhận 10.000 USD (khoảng 242 triệu đồng). \r\n\r\nỞ trận đấu mở màn diễn ra sáng ngày 25/11 theo thể thức pool đơn nữ, Bùi Xuân Vàng có màn đối đầu với nữ cơ thủ xinh đẹp Jin Hye Ju. Trong năm 2023, cơ thủ 27 tuổi của Hàn Quốc từng liên tiếp vào top 5 của 2 giải Pool nữ lớn của thế giới là China Open 2023 và vô địch 9 bi nữ thế giới 2023.\r\n\r\nVới đẳng cấp của mình, Jin Hye Ju sớm dẫn trước 4-0 sau 4 ván đầu, trong đó có 2 lần “dọn bàn” ấn tượng. Sau giờ nghỉ giải lao, Xuân Vàng vùng lên mạnh mẽ để san hòa tỉ số 4-4. Tuy nhiên sau đó, Jin Hye Ju tiếp tục có 3 ván thắng nữa để thắng chung cuộc 7-4, đưa tuyển Hàn Quốc vượt lên dẫn 1-0.\r\n\r\nTrận đấu thứ 2 là trận pool đơn nam giữa Dương Quốc Hoàng và Ha Minug. Với những cú đánh tỉ mỉ và tinh tế, Ha Minug dẫn trước 7-4 sau 11 ván đầu. Nỗ lực của Quốc Hoàng giúp anh san hòa được cách biệt 8-8. Tuy nhiên ở ván đấu quyết định, Ha Minug một lần nữa có được sự chính xác để thắng 9-8.\r\n\r\nMột cơ thủ xinh đẹp khác của Hàn Quốc là Lee Ha Rin tiếp tục gây khó khăn cho tuyển Việt Nam khi có chiến thắng ấn tượng 7-4 trong trận pool đơn nữ trước nhà vô địch quốc gia Huỳnh Thị Ngọc Huyền. Đây là trận đấu mà Lee Ha Rin khiến khán giả phải trầm trồ bằng kỹ thuật điêu luyện, đặc biệt là những cú đánh sút tê (nhảy bi) có độ chính xác rất cao. \r\n\r\nMặc dù Dương Quốc Hoàng và Bùi Xuân Vàng có được chiến thắng 5-2 trước bộ đôi Ha Minug và Lee Ha Rin ở trận đấu song tô đôi nam nữ, nhưng sau đó bộ ba Ha Minug, Lee Ha Rin và Jin Hye Ju lại có chiến thắng 5-1 trước 3 cơ thủ Dương Quốc Hoàng, Bùi Xuân Vàng, Huỳnh Thị Ngọc Huyền ở trận đấu đồng đội.\r\n\r\nNhư vậy sau ngày thi đấu đầu tiên ở nội dung pool, tuyển Billiards Việt Nam đang tạm bị dẫn trước đến 1-4. Điều này bắt buộc Quyết Chiến và các đồng đội sẽ phải thi đấu thăng hoa trong 5 trận đấu carom 3 băng ở ngày thi đấu còn lại mới mong lật ngược được thế trận để có chiến thắng chung cuộc.", new DateTime(2024, 1, 15, 20, 37, 17, 520, DateTimeKind.Local).AddTicks(9797), "(Tin thể thao, tin bi-a) Hai nữ cơ thủ xinh đẹp và tài năng Jin Hye Ju và Lee Ha Rin đã khiến tuyển Billiards Việt Nam rơi vào tình thế khó khăn tại giải Billiards siêu cúp Việt Nam – Hàn Quốc 2023.", new Guid("dbca0788-4fb0-4986-8928-4df593da3f5e"), "post13.jpg", 0, "Hot girl bi-a Hàn Quốc liên tiếp \"dọn bàn\", tuyển VN gặp khó tại siêu cúp quốc tế", new DateTime(2024, 1, 15, 20, 37, 17, 520, DateTimeKind.Local).AddTicks(9797) },
                    { new Guid("1e510dc9-e8fd-40fc-ac14-19e701736544"), "Sự kiện bi-a snooker Champion of Champions 2023 diễn ra tại Anh chứng kiến pha đi cơ đặc biệt. Ván đấu cuối cùng màn so tài vòng 1/16, Mark Williams (Xứ Wales) dù thua 2-4 trước Robert Milkins (Anh) nhưng vẫn được khán giả ca ngợi.\r\n\r\nTình huống ấn tượng diễn ra ở ván cuối, Milkins đang thắng 3-2 và dẫn 64-50. Lúc này, trên bàn chỉ còn bi hồng (6 điểm) và bi đen (7 điểm), dù có đưa cả 2 bóng này xuống bàn Williams vẫn thua. Đây là lý do mà cơ thủ 48 tuổi tới từ Xứ Wales dùng kĩ thuật móc bi hồng ra khỏi lỗ góc, sau đó còn giấu thành công bi chủ nấp sau bi đen.\r\n\r\nWilliams làm như vậy để buộc đối thủ mắc lỗi sẽ giúp cho anh có thêm điểm để thắng. Nhưng Milkins không phải tay mơ, ngôi sao người Anh sau đó đi cơ \"giải vây\" thành công và khép lại trận đấu với kết quả 4-2.\r\n\r\nDù thua, Williams nhận lời khen đặc biệt vì cú \"giấu bi\" đẳng cấp. Một khán giả viết: \"Không thể tin được. Tình huống đi cơ làm nhiều người nhớ tới các huyền thoại như Ronnie, Trump và Jimmy!\"\r\n\r\nNgười khác bày tỏ: \"Đây là một trong những tình huống đi cơ hay nhất lịch sử. Một cơ thủ thú vị để theo dõi\". Tài khoản còn lại viết: \"Một trong những sở thích lớn nhất của tôi, đó là xem Mark Williams thi đấu!\".\r\n\r\nMilkins giành quyền đi tiếp vào vòng 1/8, tại đây hành trình của anh dừng lại bởi đối thủ Robert Hawkins.", new DateTime(2024, 1, 15, 20, 37, 17, 520, DateTimeKind.Local).AddTicks(9799), "(Tin thể thao, tin bi-a) Dù bi mục tiêu nằm ở cửa lỗ nhưng bằng cách nào đó cơ thủ lại móc được ra ngoài.", new Guid("dbca0788-4fb0-4986-8928-4df593da3f5e"), "post14.jpg", 0, "Sững sờ bi-a: Cú đánh trượt ở cửa lỗ lại được đề cử \"tình huống số 1 năm\"", new DateTime(2024, 1, 15, 20, 37, 17, 520, DateTimeKind.Local).AddTicks(9800) },
                    { new Guid("1e510dc9-e8fd-40fc-ac14-19e701736545"), "Ronnie O'Sullivan, cơ thủ người Anh là một trong số những huyền thoại sống vẫn còn thi đấu thể thao. Bước sang tuổi 47, O'Sullivan vẫn đang giữ ngôi số 1 thế giới, và đang chia sẻ Stephen Hendry giữ kỷ lục 7 lần giành ngôi vô địch thế giới.\r\n\r\nĐể trở thành một ngôi sao như hiện tại, O'Sullivan trải qua rất nhiều khó khăn khi cha mẹ từng phải ngồi tù, bản thân tay cơ 47 tuổi từng dính vào chất kích thích. Nhưng tay cơ được mệnh danh là \"Phù thủy bi-a\", hay \"The Rocket\" vượt lên tất cả để biến bản thân trở thành ngôi sao thể thao hàng đầu thế giới.\r\n\r\nBộ phim tài liệu về sự nghiệp, cuộc sống của O'Sullivan sắp được công chiếu, ở đó có chi tiết anh được 600 tù nhân cổ vũ khi vô địch thế giới lần 2.\r\n\r\nBố của O'Sullivan, Ronnie O'Sullivan Sr, bị kết án tù chung thân vào năm 1992 vì tội giết người, thời điểm này tay cơ người Anh mới chưa đầy 17 tuổi.\r\n\r\nTrong nhà giam, dù không có tivi nhưng người bố Ronnie Sr vẫn làm mọi cách để cổ vũ con trai thi đấu. Ronnie Sr đã cố gắng biến những người bạn tù thành fan của cậu con trai \"The Rocket\" và 600 tù nhân đã \"mở hội\" trong nhà giam khi Ronnie Jr đánh bại Dotts với tỷ số 18-8 để bước lên ngôi vô địch snooker thế giới năm 2004.\r\n\r\nO'Sullivan Sr cho biết: \"Thời điểm con trai tôi vô địch, 600 tù nhân cùng đập vào tường, cửa, tạo ra âm thanh náo loạn tại phòng giam. Một cảnh tượng khiến tôi không thể nào quên\".O'Sullivan từng suy sụp ở quãng thời gian bố mình đi tù, thậm chí anh cũng phải quán xuyến công việc kinh doanh gia đình khi mẹ anh, bà Maria, bị bỏ tù một năm vì tội trốn thuế vào những năm 1990.\r\n\r\nCơ thủ 47 tuổi thừa nhận anh mất đi 5 năm quý giá, nếu không anh đã có hơn 7 lần vô địch thế giới: \"Từ năm 1995 đến năm 2000, tôi đã thắng một số giải đấu nhưng mọi thứ không phải tuyệt vời nhất. Có lẽ tôi đã lãng phí 5 năm sự nghiệp của mình, mọi thứ thực sự là lộn xộn\".", new DateTime(2024, 1, 15, 20, 37, 17, 520, DateTimeKind.Local).AddTicks(9802), "(Tin thể thao, tin bi-a) Ít ai biết, bố của cơ thủ huyền thoại Ronnie O'Sullivan từng là một kẻ giết người.", new Guid("40b601c0-2c08-449f-a41e-7564648f2c87"), "post15.jpg", 0, "600 tù nhân làm loạn nhà giam cổ vũ \"Phù thủy bi-a\" Sullivan vô địch thế giới", new DateTime(2024, 1, 15, 20, 37, 17, 520, DateTimeKind.Local).AddTicks(9803) }
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "AvailableQuantity", "BrandID", "CategoryID", "CreateDate", "Description", "Likes", "Name", "Pin", "Rings", "Sold", "Status", "Wrap" },
                values: new object[,]
                {
                    { new Guid("cc37720a-7e89-463a-9510-1936e6761d8a"), 1000, new Guid("f205098b-3986-484a-ab3f-8dcab46fc220"), new Guid("357267e8-d162-4844-a660-661f46933d03"), new DateTime(2023, 9, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), "Giới thiệu Cue Predator Sneaky Pete, nơi sự khéo léo kết hợp sự sang trọng. Lớp hoàn thiện mờ Purpleheart thể hiện phong cách đặc biệt của nó, với tám điểm màu xanh lam, vàng và đen quyến rũ. Màu xanh bóng mượt với lớp bọc vải lanh Ailen màu trắng tạo thêm nét đẳng cấp và tăng cường khả năng cầm nắm của bạn. Nâng cao trò chơi của bạn với độ chính xác và sự khéo léo của tín hiệu Predator Sneaky Pete.", 0, "Predator Purpleheart 8-Point Sneaky Pete With Wrap", "Uniloc Quick Release", "None", 0, 0, "Blue and White Irish Linen" },
                    { new Guid("cc37720a-7e89-463a-9510-1936e6761d8b"), 2000, new Guid("f205098b-3986-484a-ab3f-8dcab46fc221"), new Guid("357267e8-d162-4844-a660-661f46933d04"), new DateTime(2023, 9, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), "Cue bi-a Elite ELBJGB này có đầu hai mảnh giúp nghiền nát giá đỡ khi được lắp ráp hoàn chỉnh và ghép nối với trục gãy được thiết kế đặc biệt. Đầu phenolic thực sự TUYỆT VỜI, truyền toàn bộ sức mạnh từ cú đột phá của bạn vào bi cái một cách hiệu quả. Cùng một trục được sử dụng với bốn cẳng tay bằng gỗ hồng sắc tạo ra một tín hiệu nhảy 9,2oz, 41 inch sử dụng cùng một POP đó để có những cú nhảy dễ dàng và chính xác!\r\n\r\nSau khi bạn đập vỡ giá đỡ, khớp nhả nhanh giúp việc ghép nối càng nhanh chóng và dễ dàng với trục gỗ thích đá cứng, côn chuyên nghiệp với đầu Tiger Everest 13 mm. Cấu hình tín hiệu chơi này là một game bắn súng chắc chắn và thẳng, cũng có thể thu được nhiều tiếng và tiếng Anh khi bạn cần.\r\n\r\nNếu bạn đang chơi trong phòng có tường kín hoặc vật cản khác, bạn có thể ghép nối trục chơi có tay cầm bằng vải lanh Ailen đen của mông dành cho tín hiệu gây rắc rối 46 inch. Đó cũng là một lựa chọn kích thước tuyệt vời cho những đứa trẻ muốn tham gia trò chơi bi-a.\r\n\r\nVới khả năng phá, nhảy, chạy trên giá, tránh chướng ngại vật và cung cấp tùy chọn cho trẻ em, tín hiệu này là một CƠ Bida đầu tiên TUYỆT VỜI và phải có cho mọi phòng chơi tại nhà.", 0, "ELITE ELBJGB BREAK JUMP CUE W", "Action Quick-Release (both joints)", "None", 0, 0, "Black Irish linen" },
                    { new Guid("cc37720a-7e89-463a-9510-1936e6761d8c"), 2000, new Guid("f205098b-3986-484a-ab3f-8dcab46fc223"), new Guid("357267e8-d162-4844-a660-661f46933d05"), new DateTime(2023, 9, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), "Description", 0, "Summit SUML17 Pool Cue", "Mezz United Joint", "Silver Rings", 0, 0, "Black Irish Linen" },
                    { new Guid("cc37720a-7e89-463a-9510-2936e6761d8a"), 2000, new Guid("f205098b-3986-484a-ab3f-8dcab46fc221"), new Guid("357267e8-d162-4844-a660-661f46933d06"), new DateTime(2023, 9, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), "Description", 0, "Katana KAT19 Pool Cue", "Mezz United Joint", "Silver Rings", 0, 0, "Black Irish Linen" },
                    { new Guid("cc37720a-7e89-463a-9510-3936e6761d8b"), 2000, new Guid("f205098b-3986-484a-ab3f-8dcab46fc223"), new Guid("357267e8-d162-4844-a660-661f46933d07"), new DateTime(2023, 9, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), "Description", 0, "Summit SUML13 Pool Cue", "Mezz United Joint", "Silver Rings", 0, 0, "Black Irish Linen" },
                    { new Guid("cc37720a-7e89-463a-9510-4936e6761d8c"), 1000, new Guid("f205098b-3986-484a-ab3f-8dcab46fc223"), new Guid("357267e8-d162-4844-a660-661f46933d03"), new DateTime(2023, 9, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), "Giới thiệu Cue Predator Sneaky Pete, nơi sự khéo léo kết hợp sự sang trọng. Lớp hoàn thiện mờ Purpleheart thể hiện phong cách đặc biệt của nó, với tám điểm màu xanh lam, vàng và đen quyến rũ. Màu xanh bóng mượt với lớp bọc vải lanh Ailen màu trắng tạo thêm nét đẳng cấp và tăng cường khả năng cầm nắm của bạn. Nâng cao trò chơi của bạn với độ chính xác và sự khéo léo của tín hiệu Predator Sneaky Pete.", 0, "Cuetec AVID Proof CT326NW Pool Cue", "Uniloc Quick Release", "None", 0, 0, "Blue and White Irish Linen" },
                    { new Guid("cc37720a-7e89-463a-9510-5936e6761d8a"), 2000, new Guid("f205098b-3986-484a-ab3f-8dcab46fc223"), new Guid("357267e8-d162-4844-a660-661f46933d04"), new DateTime(2023, 9, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), "Description", 0, "Cuetec AVID Proof CT326LTC Pool Cue", "Mezz United Joint", "Silver Rings", 0, 0, "Black Irish Linen" },
                    { new Guid("cc37720a-7e89-463a-9510-6936e6761d8b"), 2000, new Guid("f205098b-3986-484a-ab3f-8dcab46fc225"), new Guid("357267e8-d162-4844-a660-661f46933d05"), new DateTime(2023, 9, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), "Description", 0, "Meucci Casino MECAS10 Pool Cue", "Mezz United Joint", "Silver Rings", 0, 0, "Black Irish Linen" },
                    { new Guid("cc37720a-7e89-463a-9510-7936e6761d8c"), 2000, new Guid("f205098b-3986-484a-ab3f-8dcab46fc226"), new Guid("357267e8-d162-4844-a660-661f46933d03"), new DateTime(2023, 9, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), "Description", 0, "Bull Carbon BCSP2 Silver Split Cue W/", "Mezz United Joint", "Silver Rings", 0, 0, "Black Irish Linen" },
                    { new Guid("cc37720a-7e89-463a-9510-8936e6761d8a"), 2000, new Guid("f205098b-3986-484a-ab3f-8dcab46fc227"), new Guid("357267e8-d162-4844-a660-661f46933d04"), new DateTime(2023, 9, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), "Description", 0, "Balabushka GBT Era Cue", "Mezz United Joint", "Silver Rings", 0, 0, "Black Irish Linen" }
                });

            migrationBuilder.InsertData(
                table: "Vouchers",
                columns: new[] { "Id", "Code", "EmPloyeeId", "PointCustomer", "Status", "TimeEnd", "TimeStart", "Value" },
                values: new object[,]
                {
                    { new Guid("a51f7c3c-a8e7-4c0a-aeea-b6fc70492b14"), "Pitover", new Guid("dbca0788-4fb0-4986-8928-4df593da3f5e"), 1000, 1, new DateTime(2023, 9, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 9, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), 50.0 },
                    { new Guid("a51f7c3c-a8e7-4c0a-aeea-b6fc70492bf4"), "DEMACIA", new Guid("40b601c0-2c08-449f-a41e-7564648f2c87"), 2000, 0, new DateTime(2023, 10, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 9, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), 30.0 }
                });

            migrationBuilder.InsertData(
                table: "Bills",
                columns: new[] { "Id", "Address", "BillStatusId", "CreateDate", "CustomerId", "CustomerName", "CustomerPhone", "PaymentId", "Price" },
                values: new object[,]
                {
                    { new Guid("a51f7c3c-a8e7-4c0a-aeea-b6fc70492b13"), "phi phai", new Guid("a51f7c3c-a8e7-4c0a-aeea-b6fc70492bf5"), new DateTime(2023, 9, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("a77f8ae9-af3d-4288-bbf3-8f77776f9230"), "Hoàng Xuân", "0364838484", new Guid("a51f7c3c-a8e7-4c0a-aeea-b6fc70492b16"), 1450.0 },
                    { new Guid("a51f7c3c-a8e7-4c0a-aeea-b6fc70492bf3"), "Bình nguyên vô tận", new Guid("a51f7c3c-a8e7-4c0a-aeea-b6fc70492b15"), new DateTime(2023, 9, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("a77f8ae9-af3d-4288-bbf3-8f77776f9230"), "Hoàng Xuân", "0364838484", new Guid("a51f7c3c-a8e7-4c0a-aeea-b6fc70492bf6"), 1500.0 }
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
                    { new Guid("1eaaba04-80ff-43a6-a746-a74a91c4c0e0"), new DateTime(2023, 9, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "Description", 1500.0, 2000.0, new Guid("cc37720a-7e89-463a-9510-1936e6761d8a"), 1, new Guid("cc37720a-7e89-463a-9510-1936e6761d83"), 0, new Guid("cc37720a-7e89-463a-9510-1936e6761d04"), new Guid("cc37720a-7e89-463a-9510-1936e6761d85") },
                    { new Guid("1eaaba04-80ff-43a6-a746-a74a91c4c0e1"), new DateTime(2023, 9, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "Description", 1500.0, 2000.0, new Guid("cc37720a-7e89-463a-9510-1936e6761d8a"), 1, new Guid("cc37720a-7e89-463a-9510-1936e6761d83"), 0, new Guid("cc37720a-7e89-463a-9510-1936e6761d14"), new Guid("cc37720a-7e89-463a-9510-1936e6761d85") },
                    { new Guid("1eaaba04-80ff-43a6-a746-a74a91c4c0e2"), new DateTime(2023, 9, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "Description", 1500.0, 2000.0, new Guid("cc37720a-7e89-463a-9510-1936e6761d8a"), 1, new Guid("cc37720a-7e89-463a-9510-1936e6761d83"), 0, new Guid("cc37720a-7e89-463a-9510-1936e6761d24"), new Guid("cc37720a-7e89-463a-9510-1936e6761d85") },
                    { new Guid("1eaaba04-80ff-43a6-a746-a74a91c4c0e3"), new DateTime(2023, 9, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "Description", 1500.0, 2000.0, new Guid("cc37720a-7e89-463a-9510-1936e6761d8a"), 1, new Guid("cc37720a-7e89-463a-9510-1936e6761d83"), 0, new Guid("cc37720a-7e89-463a-9510-1936e6761d34"), new Guid("cc37720a-7e89-463a-9510-1936e6761d85") },
                    { new Guid("1eaaba04-80ff-43a6-a746-a74a91c4c0e4"), new DateTime(2023, 9, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "Description", 1500.0, 2000.0, new Guid("cc37720a-7e89-463a-9510-1936e6761d8a"), 1, new Guid("cc37720a-7e89-463a-9510-1936e6761d83"), 0, new Guid("cc37720a-7e89-463a-9510-1936e6761d44"), new Guid("cc37720a-7e89-463a-9510-1936e6761d85") },
                    { new Guid("1eaaba04-80ff-43a6-a746-a74a91c4c0e5"), new DateTime(2023, 9, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "Description", 1500.0, 2000.0, new Guid("cc37720a-7e89-463a-9510-1936e6761d8a"), 1, new Guid("cc37720a-7e89-463a-9510-1936e6761d83"), 0, new Guid("cc37720a-7e89-463a-9510-1936e6761d54"), new Guid("cc37720a-7e89-463a-9510-1936e6761d85") },
                    { new Guid("1eaaba04-80ff-43a6-a746-a74a91c4c0e6"), new DateTime(2023, 9, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "Description", 1500.0, 2000.0, new Guid("cc37720a-7e89-463a-9510-1936e6761d8a"), 1, new Guid("cc37720a-7e89-463a-9510-1936e6761d83"), 0, new Guid("cc37720a-7e89-463a-9510-1936e6761d64"), new Guid("cc37720a-7e89-463a-9510-1936e6761d85") },
                    { new Guid("1eaaba04-80ff-43a6-a746-a74a91c4c0e7"), new DateTime(2023, 9, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "Description", 1500.0, 2000.0, new Guid("cc37720a-7e89-463a-9510-1936e6761d8a"), 1, new Guid("cc37720a-7e89-463a-9510-1936e6761d83"), 0, new Guid("cc37720a-7e89-463a-9510-1936e6761d74"), new Guid("cc37720a-7e89-463a-9510-1936e6761d85") },
                    { new Guid("1eaaba04-80ff-43a6-a746-a74a91c4c0e8"), new DateTime(2023, 9, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "Description", 1500.0, 2000.0, new Guid("cc37720a-7e89-463a-9510-1936e6761d8a"), 1, new Guid("cc37720a-7e89-463a-9510-1936e6761d83"), 0, new Guid("cc37720a-7e89-463a-9510-1936e6761d84"), new Guid("cc37720a-7e89-463a-9510-1936e6761d85") },
                    { new Guid("1eaaba04-80ff-43a6-a746-a74a91c4c0e9"), new DateTime(2023, 9, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "Description", 1500.0, 2000.0, new Guid("cc37720a-7e89-463a-9510-1936e6761d8a"), 1, new Guid("cc37720a-7e89-463a-9510-1936e6761d83"), 0, new Guid("cc37720a-7e89-463a-9510-1936e6761d94"), new Guid("cc37720a-7e89-463a-9510-1936e6761d85") },
                    { new Guid("1eaaba04-80ff-43a6-a746-a74a91c4c1e0"), new DateTime(2023, 9, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "Description", 1500.0, 2000.0, new Guid("cc37720a-7e89-463a-9510-1936e6761d8a"), 1, new Guid("cc37720a-7e89-463a-9510-1936e6761d73"), 0, new Guid("cc37720a-7e89-463a-9510-1936e6761d04"), new Guid("cc37720a-7e89-463a-9510-1936e6761d85") },
                    { new Guid("1eaaba04-80ff-43a6-a746-a74a91c4c1e1"), new DateTime(2023, 9, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "Description", 1500.0, 2000.0, new Guid("cc37720a-7e89-463a-9510-1936e6761d8a"), 1, new Guid("cc37720a-7e89-463a-9510-1936e6761d73"), 0, new Guid("cc37720a-7e89-463a-9510-1936e6761d14"), new Guid("cc37720a-7e89-463a-9510-1936e6761d85") },
                    { new Guid("1eaaba04-80ff-43a6-a746-a74a91c4c1e2"), new DateTime(2023, 9, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "Description", 1500.0, 2000.0, new Guid("cc37720a-7e89-463a-9510-1936e6761d8a"), 1, new Guid("cc37720a-7e89-463a-9510-1936e6761d73"), 0, new Guid("cc37720a-7e89-463a-9510-1936e6761d24"), new Guid("cc37720a-7e89-463a-9510-1936e6761d85") },
                    { new Guid("1eaaba04-80ff-43a6-a746-a74a91c4c1e3"), new DateTime(2023, 9, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "Description", 1500.0, 2000.0, new Guid("cc37720a-7e89-463a-9510-1936e6761d8a"), 1, new Guid("cc37720a-7e89-463a-9510-1936e6761d73"), 0, new Guid("cc37720a-7e89-463a-9510-1936e6761d34"), new Guid("cc37720a-7e89-463a-9510-1936e6761d85") },
                    { new Guid("1eaaba04-80ff-43a6-a746-a74a91c4c1e4"), new DateTime(2023, 9, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "Description", 1500.0, 2000.0, new Guid("cc37720a-7e89-463a-9510-1936e6761d8a"), 1, new Guid("cc37720a-7e89-463a-9510-1936e6761d73"), 0, new Guid("cc37720a-7e89-463a-9510-1936e6761d44"), new Guid("cc37720a-7e89-463a-9510-1936e6761d85") },
                    { new Guid("1eaaba04-80ff-43a6-a746-a74a91c4c1e5"), new DateTime(2023, 9, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "Description", 1500.0, 2000.0, new Guid("cc37720a-7e89-463a-9510-1936e6761d8a"), 1, new Guid("cc37720a-7e89-463a-9510-1936e6761d73"), 0, new Guid("cc37720a-7e89-463a-9510-1936e6761d54"), new Guid("cc37720a-7e89-463a-9510-1936e6761d85") },
                    { new Guid("1eaaba04-80ff-43a6-a746-a74a91c4c1e6"), new DateTime(2023, 9, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "Description", 1500.0, 2000.0, new Guid("cc37720a-7e89-463a-9510-1936e6761d8a"), 1, new Guid("cc37720a-7e89-463a-9510-1936e6761d73"), 0, new Guid("cc37720a-7e89-463a-9510-1936e6761d64"), new Guid("cc37720a-7e89-463a-9510-1936e6761d85") },
                    { new Guid("1eaaba04-80ff-43a6-a746-a74a91c4c1e7"), new DateTime(2023, 9, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "Description", 1500.0, 2000.0, new Guid("cc37720a-7e89-463a-9510-1936e6761d8a"), 1, new Guid("cc37720a-7e89-463a-9510-1936e6761d73"), 0, new Guid("cc37720a-7e89-463a-9510-1936e6761d74"), new Guid("cc37720a-7e89-463a-9510-1936e6761d85") },
                    { new Guid("1eaaba04-80ff-43a6-a746-a74a91c4c1e8"), new DateTime(2023, 9, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "Description", 1500.0, 2000.0, new Guid("cc37720a-7e89-463a-9510-1936e6761d8a"), 1, new Guid("cc37720a-7e89-463a-9510-1936e6761d73"), 0, new Guid("cc37720a-7e89-463a-9510-1936e6761d84"), new Guid("cc37720a-7e89-463a-9510-1936e6761d85") },
                    { new Guid("1eaaba04-80ff-43a6-a746-a74a91c4c1e9"), new DateTime(2023, 9, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "Description", 1500.0, 2000.0, new Guid("cc37720a-7e89-463a-9510-1936e6761d8a"), 1, new Guid("cc37720a-7e89-463a-9510-1936e6761d73"), 0, new Guid("cc37720a-7e89-463a-9510-1936e6761d94"), new Guid("cc37720a-7e89-463a-9510-1936e6761d85") },
                    { new Guid("1eaaba04-80ff-43a6-a746-a74a91c4c2e0"), new DateTime(2023, 9, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "Description", 1500.0, 2000.0, new Guid("cc37720a-7e89-463a-9510-1936e6761d8a"), 1, new Guid("cc37720a-7e89-463a-9510-1936e6761d63"), 0, new Guid("cc37720a-7e89-463a-9510-1936e6761d04"), new Guid("cc37720a-7e89-463a-9510-1936e6761d85") },
                    { new Guid("1eaaba04-80ff-43a6-a746-a74a91c4c2e1"), new DateTime(2023, 9, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "Description", 1500.0, 2000.0, new Guid("cc37720a-7e89-463a-9510-1936e6761d8a"), 1, new Guid("cc37720a-7e89-463a-9510-1936e6761d63"), 0, new Guid("cc37720a-7e89-463a-9510-1936e6761d14"), new Guid("cc37720a-7e89-463a-9510-1936e6761d85") },
                    { new Guid("1eaaba04-80ff-43a6-a746-a74a91c4c2e2"), new DateTime(2023, 9, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "Description", 1500.0, 2000.0, new Guid("cc37720a-7e89-463a-9510-1936e6761d8a"), 1, new Guid("cc37720a-7e89-463a-9510-1936e6761d63"), 0, new Guid("cc37720a-7e89-463a-9510-1936e6761d24"), new Guid("cc37720a-7e89-463a-9510-1936e6761d85") },
                    { new Guid("1eaaba04-80ff-43a6-a746-a74a91c4c2e3"), new DateTime(2023, 9, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "Description", 1500.0, 2000.0, new Guid("cc37720a-7e89-463a-9510-1936e6761d8a"), 1, new Guid("cc37720a-7e89-463a-9510-1936e6761d63"), 0, new Guid("cc37720a-7e89-463a-9510-1936e6761d34"), new Guid("cc37720a-7e89-463a-9510-1936e6761d85") },
                    { new Guid("1eaaba04-80ff-43a6-a746-a74a91c4c2e4"), new DateTime(2023, 9, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "Description", 1500.0, 2000.0, new Guid("cc37720a-7e89-463a-9510-1936e6761d8a"), 1, new Guid("cc37720a-7e89-463a-9510-1936e6761d63"), 0, new Guid("cc37720a-7e89-463a-9510-1936e6761d44"), new Guid("cc37720a-7e89-463a-9510-1936e6761d85") },
                    { new Guid("1eaaba04-80ff-43a6-a746-a74a91c4c2e5"), new DateTime(2023, 9, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "Description", 1500.0, 2000.0, new Guid("cc37720a-7e89-463a-9510-1936e6761d8a"), 1, new Guid("cc37720a-7e89-463a-9510-1936e6761d63"), 0, new Guid("cc37720a-7e89-463a-9510-1936e6761d54"), new Guid("cc37720a-7e89-463a-9510-1936e6761d85") },
                    { new Guid("1eaaba04-80ff-43a6-a746-a74a91c4c2e6"), new DateTime(2023, 9, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "Description", 1500.0, 2000.0, new Guid("cc37720a-7e89-463a-9510-1936e6761d8a"), 1, new Guid("cc37720a-7e89-463a-9510-1936e6761d63"), 0, new Guid("cc37720a-7e89-463a-9510-1936e6761d64"), new Guid("cc37720a-7e89-463a-9510-1936e6761d85") },
                    { new Guid("1eaaba04-80ff-43a6-a746-a74a91c4c2e7"), new DateTime(2023, 9, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "Description", 1500.0, 2000.0, new Guid("cc37720a-7e89-463a-9510-1936e6761d8a"), 1, new Guid("cc37720a-7e89-463a-9510-1936e6761d63"), 0, new Guid("cc37720a-7e89-463a-9510-1936e6761d74"), new Guid("cc37720a-7e89-463a-9510-1936e6761d85") },
                    { new Guid("1eaaba04-80ff-43a6-a746-a74a91c4c2e8"), new DateTime(2023, 9, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "Description", 1500.0, 2000.0, new Guid("cc37720a-7e89-463a-9510-1936e6761d8a"), 1, new Guid("cc37720a-7e89-463a-9510-1936e6761d63"), 0, new Guid("cc37720a-7e89-463a-9510-1936e6761d84"), new Guid("cc37720a-7e89-463a-9510-1936e6761d85") },
                    { new Guid("1eaaba04-80ff-43a6-a746-a74a91c4c2e9"), new DateTime(2023, 9, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "Description", 1500.0, 2000.0, new Guid("cc37720a-7e89-463a-9510-1936e6761d8a"), 1, new Guid("cc37720a-7e89-463a-9510-1936e6761d63"), 0, new Guid("cc37720a-7e89-463a-9510-1936e6761d94"), new Guid("cc37720a-7e89-463a-9510-1936e6761d85") },
                    { new Guid("1eaaba04-80ff-43a6-a746-a74a91c4c3e0"), new DateTime(2023, 9, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "Description", 1500.0, 2000.0, new Guid("cc37720a-7e89-463a-9510-1936e6761d8a"), 1, new Guid("cc37720a-7e89-463a-9510-1936e6761d53"), 0, new Guid("cc37720a-7e89-463a-9510-1936e6761d04"), new Guid("cc37720a-7e89-463a-9510-1936e6761d85") },
                    { new Guid("1eaaba04-80ff-43a6-a746-a74a91c4c3e1"), new DateTime(2023, 9, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "Description", 1500.0, 2000.0, new Guid("cc37720a-7e89-463a-9510-1936e6761d8a"), 1, new Guid("cc37720a-7e89-463a-9510-1936e6761d53"), 0, new Guid("cc37720a-7e89-463a-9510-1936e6761d14"), new Guid("cc37720a-7e89-463a-9510-1936e6761d85") },
                    { new Guid("1eaaba04-80ff-43a6-a746-a74a91c4c3e2"), new DateTime(2023, 9, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "Description", 1500.0, 2000.0, new Guid("cc37720a-7e89-463a-9510-1936e6761d8a"), 1, new Guid("cc37720a-7e89-463a-9510-1936e6761d53"), 0, new Guid("cc37720a-7e89-463a-9510-1936e6761d24"), new Guid("cc37720a-7e89-463a-9510-1936e6761d85") },
                    { new Guid("1eaaba04-80ff-43a6-a746-a74a91c4c3e3"), new DateTime(2023, 9, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "Description", 1500.0, 2000.0, new Guid("cc37720a-7e89-463a-9510-1936e6761d8a"), 1, new Guid("cc37720a-7e89-463a-9510-1936e6761d53"), 0, new Guid("cc37720a-7e89-463a-9510-1936e6761d34"), new Guid("cc37720a-7e89-463a-9510-1936e6761d85") },
                    { new Guid("1eaaba04-80ff-43a6-a746-a74a91c4c3e4"), new DateTime(2023, 9, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "Description", 1500.0, 2000.0, new Guid("cc37720a-7e89-463a-9510-1936e6761d8a"), 1, new Guid("cc37720a-7e89-463a-9510-1936e6761d53"), 0, new Guid("cc37720a-7e89-463a-9510-1936e6761d44"), new Guid("cc37720a-7e89-463a-9510-1936e6761d85") },
                    { new Guid("1eaaba04-80ff-43a6-a746-a74a91c4c3e5"), new DateTime(2023, 9, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "Description", 1500.0, 2000.0, new Guid("cc37720a-7e89-463a-9510-1936e6761d8a"), 1, new Guid("cc37720a-7e89-463a-9510-1936e6761d53"), 0, new Guid("cc37720a-7e89-463a-9510-1936e6761d54"), new Guid("cc37720a-7e89-463a-9510-1936e6761d85") },
                    { new Guid("1eaaba04-80ff-43a6-a746-a74a91c4c3e6"), new DateTime(2023, 9, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "Description", 1500.0, 2000.0, new Guid("cc37720a-7e89-463a-9510-1936e6761d8a"), 1, new Guid("cc37720a-7e89-463a-9510-1936e6761d53"), 0, new Guid("cc37720a-7e89-463a-9510-1936e6761d64"), new Guid("cc37720a-7e89-463a-9510-1936e6761d85") },
                    { new Guid("1eaaba04-80ff-43a6-a746-a74a91c4c3e7"), new DateTime(2023, 9, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "Description", 1500.0, 2000.0, new Guid("cc37720a-7e89-463a-9510-1936e6761d8a"), 1, new Guid("cc37720a-7e89-463a-9510-1936e6761d53"), 0, new Guid("cc37720a-7e89-463a-9510-1936e6761d74"), new Guid("cc37720a-7e89-463a-9510-1936e6761d85") }
                });

            migrationBuilder.InsertData(
                table: "ProductDetails",
                columns: new[] { "Id", "CreateDate", "Description", "ImportPrice", "Price", "ProductID", "Quantity", "ShaftId", "Status", "TipId", "WeightId" },
                values: new object[,]
                {
                    { new Guid("1eaaba04-80ff-43a6-a746-a74a91c4c3e8"), new DateTime(2023, 9, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "Description", 1500.0, 2000.0, new Guid("cc37720a-7e89-463a-9510-1936e6761d8a"), 1, new Guid("cc37720a-7e89-463a-9510-1936e6761d53"), 0, new Guid("cc37720a-7e89-463a-9510-1936e6761d84"), new Guid("cc37720a-7e89-463a-9510-1936e6761d85") },
                    { new Guid("1eaaba04-80ff-43a6-a746-a74a91c4c3e9"), new DateTime(2023, 9, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "Description", 1500.0, 2000.0, new Guid("cc37720a-7e89-463a-9510-1936e6761d8a"), 1, new Guid("cc37720a-7e89-463a-9510-1936e6761d53"), 0, new Guid("cc37720a-7e89-463a-9510-1936e6761d94"), new Guid("cc37720a-7e89-463a-9510-1936e6761d85") },
                    { new Guid("1eaaba04-80ff-43a6-a746-a74a91c5c0e0"), new DateTime(2023, 9, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "Description", 1500.0, 2000.0, new Guid("cc37720a-7e89-463a-9510-1936e6761d8a"), 1, new Guid("cc37720a-7e89-463a-9510-1936e6761d83"), 0, new Guid("cc37720a-7e89-463a-9510-1936e6761d04"), new Guid("cc37720a-7e89-463a-9510-1936e6761d75") },
                    { new Guid("1eaaba04-80ff-43a6-a746-a74a91c5c0e1"), new DateTime(2023, 9, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "Description", 1500.0, 2000.0, new Guid("cc37720a-7e89-463a-9510-1936e6761d8a"), 1, new Guid("cc37720a-7e89-463a-9510-1936e6761d83"), 0, new Guid("cc37720a-7e89-463a-9510-1936e6761d14"), new Guid("cc37720a-7e89-463a-9510-1936e6761d75") },
                    { new Guid("1eaaba04-80ff-43a6-a746-a74a91c5c0e2"), new DateTime(2023, 9, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "Description", 1500.0, 2000.0, new Guid("cc37720a-7e89-463a-9510-1936e6761d8a"), 1, new Guid("cc37720a-7e89-463a-9510-1936e6761d83"), 0, new Guid("cc37720a-7e89-463a-9510-1936e6761d24"), new Guid("cc37720a-7e89-463a-9510-1936e6761d75") },
                    { new Guid("1eaaba04-80ff-43a6-a746-a74a91c5c0e3"), new DateTime(2023, 9, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "Description", 1500.0, 2000.0, new Guid("cc37720a-7e89-463a-9510-1936e6761d8a"), 1, new Guid("cc37720a-7e89-463a-9510-1936e6761d83"), 0, new Guid("cc37720a-7e89-463a-9510-1936e6761d34"), new Guid("cc37720a-7e89-463a-9510-1936e6761d75") },
                    { new Guid("1eaaba04-80ff-43a6-a746-a74a91c5c0e4"), new DateTime(2023, 9, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "Description", 1500.0, 2000.0, new Guid("cc37720a-7e89-463a-9510-1936e6761d8a"), 1, new Guid("cc37720a-7e89-463a-9510-1936e6761d83"), 0, new Guid("cc37720a-7e89-463a-9510-1936e6761d44"), new Guid("cc37720a-7e89-463a-9510-1936e6761d75") },
                    { new Guid("1eaaba04-80ff-43a6-a746-a74a91c5c0e5"), new DateTime(2023, 9, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "Description", 1500.0, 2000.0, new Guid("cc37720a-7e89-463a-9510-1936e6761d8a"), 1, new Guid("cc37720a-7e89-463a-9510-1936e6761d83"), 0, new Guid("cc37720a-7e89-463a-9510-1936e6761d54"), new Guid("cc37720a-7e89-463a-9510-1936e6761d75") },
                    { new Guid("1eaaba04-80ff-43a6-a746-a74a91c5c0e6"), new DateTime(2023, 9, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "Description", 1500.0, 2000.0, new Guid("cc37720a-7e89-463a-9510-1936e6761d8a"), 1, new Guid("cc37720a-7e89-463a-9510-1936e6761d83"), 0, new Guid("cc37720a-7e89-463a-9510-1936e6761d64"), new Guid("cc37720a-7e89-463a-9510-1936e6761d75") },
                    { new Guid("1eaaba04-80ff-43a6-a746-a74a91c5c0e7"), new DateTime(2023, 9, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "Description", 1500.0, 2000.0, new Guid("cc37720a-7e89-463a-9510-1936e6761d8a"), 1, new Guid("cc37720a-7e89-463a-9510-1936e6761d83"), 0, new Guid("cc37720a-7e89-463a-9510-1936e6761d74"), new Guid("cc37720a-7e89-463a-9510-1936e6761d75") },
                    { new Guid("1eaaba04-80ff-43a6-a746-a74a91c5c0e8"), new DateTime(2023, 9, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "Description", 1500.0, 2000.0, new Guid("cc37720a-7e89-463a-9510-1936e6761d8a"), 1, new Guid("cc37720a-7e89-463a-9510-1936e6761d83"), 0, new Guid("cc37720a-7e89-463a-9510-1936e6761d84"), new Guid("cc37720a-7e89-463a-9510-1936e6761d75") },
                    { new Guid("1eaaba04-80ff-43a6-a746-a74a91c5c0e9"), new DateTime(2023, 9, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "Description", 1500.0, 2000.0, new Guid("cc37720a-7e89-463a-9510-1936e6761d8a"), 1, new Guid("cc37720a-7e89-463a-9510-1936e6761d83"), 0, new Guid("cc37720a-7e89-463a-9510-1936e6761d94"), new Guid("cc37720a-7e89-463a-9510-1936e6761d75") },
                    { new Guid("1eaaba04-80ff-43a6-a746-a74a91c5c1e0"), new DateTime(2023, 9, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "Description", 1500.0, 2000.0, new Guid("cc37720a-7e89-463a-9510-1936e6761d8a"), 1, new Guid("cc37720a-7e89-463a-9510-1936e6761d73"), 0, new Guid("cc37720a-7e89-463a-9510-1936e6761d04"), new Guid("cc37720a-7e89-463a-9510-1936e6761d75") },
                    { new Guid("1eaaba04-80ff-43a6-a746-a74a91c5c1e1"), new DateTime(2023, 9, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "Description", 1500.0, 2000.0, new Guid("cc37720a-7e89-463a-9510-1936e6761d8a"), 1, new Guid("cc37720a-7e89-463a-9510-1936e6761d73"), 0, new Guid("cc37720a-7e89-463a-9510-1936e6761d14"), new Guid("cc37720a-7e89-463a-9510-1936e6761d75") },
                    { new Guid("1eaaba04-80ff-43a6-a746-a74a91c5c1e2"), new DateTime(2023, 9, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "Description", 1500.0, 2000.0, new Guid("cc37720a-7e89-463a-9510-1936e6761d8a"), 1, new Guid("cc37720a-7e89-463a-9510-1936e6761d73"), 0, new Guid("cc37720a-7e89-463a-9510-1936e6761d24"), new Guid("cc37720a-7e89-463a-9510-1936e6761d75") },
                    { new Guid("1eaaba04-80ff-43a6-a746-a74a91c5c1e3"), new DateTime(2023, 9, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "Description", 1500.0, 2000.0, new Guid("cc37720a-7e89-463a-9510-1936e6761d8a"), 1, new Guid("cc37720a-7e89-463a-9510-1936e6761d73"), 0, new Guid("cc37720a-7e89-463a-9510-1936e6761d34"), new Guid("cc37720a-7e89-463a-9510-1936e6761d75") },
                    { new Guid("1eaaba04-80ff-43a6-a746-a74a91c5c1e4"), new DateTime(2023, 9, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "Description", 1500.0, 2000.0, new Guid("cc37720a-7e89-463a-9510-1936e6761d8a"), 1, new Guid("cc37720a-7e89-463a-9510-1936e6761d73"), 0, new Guid("cc37720a-7e89-463a-9510-1936e6761d44"), new Guid("cc37720a-7e89-463a-9510-1936e6761d75") },
                    { new Guid("1eaaba04-80ff-43a6-a746-a74a91c5c1e5"), new DateTime(2023, 9, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "Description", 1500.0, 2000.0, new Guid("cc37720a-7e89-463a-9510-1936e6761d8a"), 1, new Guid("cc37720a-7e89-463a-9510-1936e6761d73"), 0, new Guid("cc37720a-7e89-463a-9510-1936e6761d54"), new Guid("cc37720a-7e89-463a-9510-1936e6761d75") },
                    { new Guid("1eaaba04-80ff-43a6-a746-a74a91c5c1e6"), new DateTime(2023, 9, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "Description", 1500.0, 2000.0, new Guid("cc37720a-7e89-463a-9510-1936e6761d8a"), 1, new Guid("cc37720a-7e89-463a-9510-1936e6761d73"), 0, new Guid("cc37720a-7e89-463a-9510-1936e6761d64"), new Guid("cc37720a-7e89-463a-9510-1936e6761d75") },
                    { new Guid("1eaaba04-80ff-43a6-a746-a74a91c5c1e7"), new DateTime(2023, 9, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "Description", 1500.0, 2000.0, new Guid("cc37720a-7e89-463a-9510-1936e6761d8a"), 1, new Guid("cc37720a-7e89-463a-9510-1936e6761d73"), 0, new Guid("cc37720a-7e89-463a-9510-1936e6761d74"), new Guid("cc37720a-7e89-463a-9510-1936e6761d75") },
                    { new Guid("1eaaba04-80ff-43a6-a746-a74a91c5c1e8"), new DateTime(2023, 9, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "Description", 1500.0, 2000.0, new Guid("cc37720a-7e89-463a-9510-1936e6761d8a"), 1, new Guid("cc37720a-7e89-463a-9510-1936e6761d73"), 0, new Guid("cc37720a-7e89-463a-9510-1936e6761d84"), new Guid("cc37720a-7e89-463a-9510-1936e6761d75") },
                    { new Guid("1eaaba04-80ff-43a6-a746-a74a91c5c1e9"), new DateTime(2023, 9, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "Description", 1500.0, 2000.0, new Guid("cc37720a-7e89-463a-9510-1936e6761d8a"), 1, new Guid("cc37720a-7e89-463a-9510-1936e6761d73"), 0, new Guid("cc37720a-7e89-463a-9510-1936e6761d94"), new Guid("cc37720a-7e89-463a-9510-1936e6761d75") },
                    { new Guid("1eaaba04-80ff-43a6-a746-a74a91c5c2e0"), new DateTime(2023, 9, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "Description", 1500.0, 2000.0, new Guid("cc37720a-7e89-463a-9510-1936e6761d8a"), 1, new Guid("cc37720a-7e89-463a-9510-1936e6761d63"), 0, new Guid("cc37720a-7e89-463a-9510-1936e6761d04"), new Guid("cc37720a-7e89-463a-9510-1936e6761d75") },
                    { new Guid("1eaaba04-80ff-43a6-a746-a74a91c5c2e1"), new DateTime(2023, 9, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "Description", 1500.0, 2000.0, new Guid("cc37720a-7e89-463a-9510-1936e6761d8a"), 1, new Guid("cc37720a-7e89-463a-9510-1936e6761d63"), 0, new Guid("cc37720a-7e89-463a-9510-1936e6761d14"), new Guid("cc37720a-7e89-463a-9510-1936e6761d75") },
                    { new Guid("1eaaba04-80ff-43a6-a746-a74a91c5c2e2"), new DateTime(2023, 9, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "Description", 1500.0, 2000.0, new Guid("cc37720a-7e89-463a-9510-1936e6761d8a"), 1, new Guid("cc37720a-7e89-463a-9510-1936e6761d63"), 0, new Guid("cc37720a-7e89-463a-9510-1936e6761d24"), new Guid("cc37720a-7e89-463a-9510-1936e6761d75") },
                    { new Guid("1eaaba04-80ff-43a6-a746-a74a91c5c2e3"), new DateTime(2023, 9, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "Description", 1500.0, 2000.0, new Guid("cc37720a-7e89-463a-9510-1936e6761d8a"), 1, new Guid("cc37720a-7e89-463a-9510-1936e6761d63"), 0, new Guid("cc37720a-7e89-463a-9510-1936e6761d34"), new Guid("cc37720a-7e89-463a-9510-1936e6761d75") },
                    { new Guid("1eaaba04-80ff-43a6-a746-a74a91c5c2e4"), new DateTime(2023, 9, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "Description", 1500.0, 2000.0, new Guid("cc37720a-7e89-463a-9510-1936e6761d8a"), 1, new Guid("cc37720a-7e89-463a-9510-1936e6761d63"), 0, new Guid("cc37720a-7e89-463a-9510-1936e6761d44"), new Guid("cc37720a-7e89-463a-9510-1936e6761d75") },
                    { new Guid("1eaaba04-80ff-43a6-a746-a74a91c5c2e5"), new DateTime(2023, 9, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "Description", 1500.0, 2000.0, new Guid("cc37720a-7e89-463a-9510-1936e6761d8a"), 1, new Guid("cc37720a-7e89-463a-9510-1936e6761d63"), 0, new Guid("cc37720a-7e89-463a-9510-1936e6761d54"), new Guid("cc37720a-7e89-463a-9510-1936e6761d75") },
                    { new Guid("1eaaba04-80ff-43a6-a746-a74a91c5c2e6"), new DateTime(2023, 9, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "Description", 1500.0, 2000.0, new Guid("cc37720a-7e89-463a-9510-1936e6761d8a"), 1, new Guid("cc37720a-7e89-463a-9510-1936e6761d63"), 0, new Guid("cc37720a-7e89-463a-9510-1936e6761d64"), new Guid("cc37720a-7e89-463a-9510-1936e6761d75") },
                    { new Guid("1eaaba04-80ff-43a6-a746-a74a91c5c2e7"), new DateTime(2023, 9, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "Description", 1500.0, 2000.0, new Guid("cc37720a-7e89-463a-9510-1936e6761d8a"), 1, new Guid("cc37720a-7e89-463a-9510-1936e6761d63"), 0, new Guid("cc37720a-7e89-463a-9510-1936e6761d74"), new Guid("cc37720a-7e89-463a-9510-1936e6761d75") },
                    { new Guid("1eaaba04-80ff-43a6-a746-a74a91c5c2e8"), new DateTime(2023, 9, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "Description", 1500.0, 2000.0, new Guid("cc37720a-7e89-463a-9510-1936e6761d8a"), 1, new Guid("cc37720a-7e89-463a-9510-1936e6761d63"), 0, new Guid("cc37720a-7e89-463a-9510-1936e6761d84"), new Guid("cc37720a-7e89-463a-9510-1936e6761d75") },
                    { new Guid("1eaaba04-80ff-43a6-a746-a74a91c5c2e9"), new DateTime(2023, 9, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "Description", 1500.0, 2000.0, new Guid("cc37720a-7e89-463a-9510-1936e6761d8a"), 1, new Guid("cc37720a-7e89-463a-9510-1936e6761d63"), 0, new Guid("cc37720a-7e89-463a-9510-1936e6761d94"), new Guid("cc37720a-7e89-463a-9510-1936e6761d75") },
                    { new Guid("1eaaba04-80ff-43a6-a746-a74a91c5c3e0"), new DateTime(2023, 9, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "Description", 1500.0, 2000.0, new Guid("cc37720a-7e89-463a-9510-1936e6761d8a"), 1, new Guid("cc37720a-7e89-463a-9510-1936e6761d53"), 0, new Guid("cc37720a-7e89-463a-9510-1936e6761d04"), new Guid("cc37720a-7e89-463a-9510-1936e6761d75") },
                    { new Guid("1eaaba04-80ff-43a6-a746-a74a91c5c3e1"), new DateTime(2023, 9, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "Description", 1500.0, 2000.0, new Guid("cc37720a-7e89-463a-9510-1936e6761d8a"), 1, new Guid("cc37720a-7e89-463a-9510-1936e6761d53"), 0, new Guid("cc37720a-7e89-463a-9510-1936e6761d14"), new Guid("cc37720a-7e89-463a-9510-1936e6761d75") },
                    { new Guid("1eaaba04-80ff-43a6-a746-a74a91c5c3e2"), new DateTime(2023, 9, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "Description", 1500.0, 2000.0, new Guid("cc37720a-7e89-463a-9510-1936e6761d8a"), 1, new Guid("cc37720a-7e89-463a-9510-1936e6761d53"), 0, new Guid("cc37720a-7e89-463a-9510-1936e6761d24"), new Guid("cc37720a-7e89-463a-9510-1936e6761d75") },
                    { new Guid("1eaaba04-80ff-43a6-a746-a74a91c5c3e3"), new DateTime(2023, 9, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "Description", 1500.0, 2000.0, new Guid("cc37720a-7e89-463a-9510-1936e6761d8a"), 1, new Guid("cc37720a-7e89-463a-9510-1936e6761d53"), 0, new Guid("cc37720a-7e89-463a-9510-1936e6761d34"), new Guid("cc37720a-7e89-463a-9510-1936e6761d75") },
                    { new Guid("1eaaba04-80ff-43a6-a746-a74a91c5c3e4"), new DateTime(2023, 9, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "Description", 1500.0, 2000.0, new Guid("cc37720a-7e89-463a-9510-1936e6761d8a"), 1, new Guid("cc37720a-7e89-463a-9510-1936e6761d53"), 0, new Guid("cc37720a-7e89-463a-9510-1936e6761d44"), new Guid("cc37720a-7e89-463a-9510-1936e6761d75") },
                    { new Guid("1eaaba04-80ff-43a6-a746-a74a91c5c3e5"), new DateTime(2023, 9, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "Description", 1500.0, 2000.0, new Guid("cc37720a-7e89-463a-9510-1936e6761d8a"), 1, new Guid("cc37720a-7e89-463a-9510-1936e6761d53"), 0, new Guid("cc37720a-7e89-463a-9510-1936e6761d54"), new Guid("cc37720a-7e89-463a-9510-1936e6761d75") },
                    { new Guid("1eaaba04-80ff-43a6-a746-a74a91c5c3e6"), new DateTime(2023, 9, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "Description", 1500.0, 2000.0, new Guid("cc37720a-7e89-463a-9510-1936e6761d8a"), 1, new Guid("cc37720a-7e89-463a-9510-1936e6761d53"), 0, new Guid("cc37720a-7e89-463a-9510-1936e6761d64"), new Guid("cc37720a-7e89-463a-9510-1936e6761d75") },
                    { new Guid("1eaaba04-80ff-43a6-a746-a74a91c5c3e7"), new DateTime(2023, 9, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "Description", 1500.0, 2000.0, new Guid("cc37720a-7e89-463a-9510-1936e6761d8a"), 1, new Guid("cc37720a-7e89-463a-9510-1936e6761d53"), 0, new Guid("cc37720a-7e89-463a-9510-1936e6761d74"), new Guid("cc37720a-7e89-463a-9510-1936e6761d75") },
                    { new Guid("1eaaba04-80ff-43a6-a746-a74a91c5c3e8"), new DateTime(2023, 9, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "Description", 1500.0, 2000.0, new Guid("cc37720a-7e89-463a-9510-1936e6761d8a"), 1, new Guid("cc37720a-7e89-463a-9510-1936e6761d53"), 0, new Guid("cc37720a-7e89-463a-9510-1936e6761d84"), new Guid("cc37720a-7e89-463a-9510-1936e6761d75") },
                    { new Guid("1eaaba04-80ff-43a6-a746-a74a91c5c3e9"), new DateTime(2023, 9, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "Description", 1500.0, 2000.0, new Guid("cc37720a-7e89-463a-9510-1936e6761d8a"), 1, new Guid("cc37720a-7e89-463a-9510-1936e6761d53"), 0, new Guid("cc37720a-7e89-463a-9510-1936e6761d94"), new Guid("cc37720a-7e89-463a-9510-1936e6761d75") }
                });

            migrationBuilder.InsertData(
                table: "ProductDetails",
                columns: new[] { "Id", "CreateDate", "Description", "ImportPrice", "Price", "ProductID", "Quantity", "ShaftId", "Status", "TipId", "WeightId" },
                values: new object[,]
                {
                    { new Guid("1eaaba04-80ff-43a6-a746-a74a91c6c0e0"), new DateTime(2023, 9, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "Description", 1500.0, 2000.0, new Guid("cc37720a-7e89-463a-9510-1936e6761d8a"), 1, new Guid("cc37720a-7e89-463a-9510-1936e6761d83"), 0, new Guid("cc37720a-7e89-463a-9510-1936e6761d04"), new Guid("cc37720a-7e89-463a-9510-1936e6761d65") },
                    { new Guid("1eaaba04-80ff-43a6-a746-a74a91c6c0e1"), new DateTime(2023, 9, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "Description", 1500.0, 2000.0, new Guid("cc37720a-7e89-463a-9510-1936e6761d8a"), 1, new Guid("cc37720a-7e89-463a-9510-1936e6761d83"), 0, new Guid("cc37720a-7e89-463a-9510-1936e6761d14"), new Guid("cc37720a-7e89-463a-9510-1936e6761d65") },
                    { new Guid("1eaaba04-80ff-43a6-a746-a74a91c6c0e2"), new DateTime(2023, 9, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "Description", 1500.0, 2000.0, new Guid("cc37720a-7e89-463a-9510-1936e6761d8a"), 1, new Guid("cc37720a-7e89-463a-9510-1936e6761d83"), 0, new Guid("cc37720a-7e89-463a-9510-1936e6761d24"), new Guid("cc37720a-7e89-463a-9510-1936e6761d65") },
                    { new Guid("1eaaba04-80ff-43a6-a746-a74a91c6c0e3"), new DateTime(2023, 9, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "Description", 1500.0, 2000.0, new Guid("cc37720a-7e89-463a-9510-1936e6761d8a"), 1, new Guid("cc37720a-7e89-463a-9510-1936e6761d83"), 0, new Guid("cc37720a-7e89-463a-9510-1936e6761d34"), new Guid("cc37720a-7e89-463a-9510-1936e6761d65") },
                    { new Guid("1eaaba04-80ff-43a6-a746-a74a91c6c0e4"), new DateTime(2023, 9, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "Description", 1500.0, 2000.0, new Guid("cc37720a-7e89-463a-9510-1936e6761d8a"), 1, new Guid("cc37720a-7e89-463a-9510-1936e6761d83"), 0, new Guid("cc37720a-7e89-463a-9510-1936e6761d44"), new Guid("cc37720a-7e89-463a-9510-1936e6761d65") },
                    { new Guid("1eaaba04-80ff-43a6-a746-a74a91c6c0e5"), new DateTime(2023, 9, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "Description", 1500.0, 2000.0, new Guid("cc37720a-7e89-463a-9510-1936e6761d8a"), 1, new Guid("cc37720a-7e89-463a-9510-1936e6761d83"), 0, new Guid("cc37720a-7e89-463a-9510-1936e6761d54"), new Guid("cc37720a-7e89-463a-9510-1936e6761d65") },
                    { new Guid("1eaaba04-80ff-43a6-a746-a74a91c6c0e6"), new DateTime(2023, 9, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "Description", 1500.0, 2000.0, new Guid("cc37720a-7e89-463a-9510-1936e6761d8a"), 1, new Guid("cc37720a-7e89-463a-9510-1936e6761d83"), 0, new Guid("cc37720a-7e89-463a-9510-1936e6761d64"), new Guid("cc37720a-7e89-463a-9510-1936e6761d65") },
                    { new Guid("1eaaba04-80ff-43a6-a746-a74a91c6c0e7"), new DateTime(2023, 9, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "Description", 1500.0, 2000.0, new Guid("cc37720a-7e89-463a-9510-1936e6761d8a"), 1, new Guid("cc37720a-7e89-463a-9510-1936e6761d83"), 0, new Guid("cc37720a-7e89-463a-9510-1936e6761d74"), new Guid("cc37720a-7e89-463a-9510-1936e6761d65") },
                    { new Guid("1eaaba04-80ff-43a6-a746-a74a91c6c0e8"), new DateTime(2023, 9, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "Description", 1500.0, 2000.0, new Guid("cc37720a-7e89-463a-9510-1936e6761d8a"), 1, new Guid("cc37720a-7e89-463a-9510-1936e6761d83"), 0, new Guid("cc37720a-7e89-463a-9510-1936e6761d84"), new Guid("cc37720a-7e89-463a-9510-1936e6761d65") },
                    { new Guid("1eaaba04-80ff-43a6-a746-a74a91c6c0e9"), new DateTime(2023, 9, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "Description", 1500.0, 2000.0, new Guid("cc37720a-7e89-463a-9510-1936e6761d8a"), 1, new Guid("cc37720a-7e89-463a-9510-1936e6761d83"), 0, new Guid("cc37720a-7e89-463a-9510-1936e6761d94"), new Guid("cc37720a-7e89-463a-9510-1936e6761d65") },
                    { new Guid("1eaaba04-80ff-43a6-a746-a74a91c6c1e0"), new DateTime(2023, 9, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "Description", 1500.0, 2000.0, new Guid("cc37720a-7e89-463a-9510-1936e6761d8a"), 1, new Guid("cc37720a-7e89-463a-9510-1936e6761d73"), 0, new Guid("cc37720a-7e89-463a-9510-1936e6761d04"), new Guid("cc37720a-7e89-463a-9510-1936e6761d65") },
                    { new Guid("1eaaba04-80ff-43a6-a746-a74a91c6c1e1"), new DateTime(2023, 9, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "Description", 1500.0, 2000.0, new Guid("cc37720a-7e89-463a-9510-1936e6761d8a"), 1, new Guid("cc37720a-7e89-463a-9510-1936e6761d73"), 0, new Guid("cc37720a-7e89-463a-9510-1936e6761d14"), new Guid("cc37720a-7e89-463a-9510-1936e6761d65") },
                    { new Guid("1eaaba04-80ff-43a6-a746-a74a91c6c1e2"), new DateTime(2023, 9, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "Description", 1500.0, 2000.0, new Guid("cc37720a-7e89-463a-9510-1936e6761d8a"), 1, new Guid("cc37720a-7e89-463a-9510-1936e6761d73"), 0, new Guid("cc37720a-7e89-463a-9510-1936e6761d24"), new Guid("cc37720a-7e89-463a-9510-1936e6761d65") },
                    { new Guid("1eaaba04-80ff-43a6-a746-a74a91c6c1e3"), new DateTime(2023, 9, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "Description", 1500.0, 2000.0, new Guid("cc37720a-7e89-463a-9510-1936e6761d8a"), 1, new Guid("cc37720a-7e89-463a-9510-1936e6761d73"), 0, new Guid("cc37720a-7e89-463a-9510-1936e6761d34"), new Guid("cc37720a-7e89-463a-9510-1936e6761d65") },
                    { new Guid("1eaaba04-80ff-43a6-a746-a74a91c6c1e4"), new DateTime(2023, 9, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "Description", 1500.0, 2000.0, new Guid("cc37720a-7e89-463a-9510-1936e6761d8a"), 1, new Guid("cc37720a-7e89-463a-9510-1936e6761d73"), 0, new Guid("cc37720a-7e89-463a-9510-1936e6761d44"), new Guid("cc37720a-7e89-463a-9510-1936e6761d65") },
                    { new Guid("1eaaba04-80ff-43a6-a746-a74a91c6c1e5"), new DateTime(2023, 9, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "Description", 1500.0, 2000.0, new Guid("cc37720a-7e89-463a-9510-1936e6761d8a"), 1, new Guid("cc37720a-7e89-463a-9510-1936e6761d73"), 0, new Guid("cc37720a-7e89-463a-9510-1936e6761d54"), new Guid("cc37720a-7e89-463a-9510-1936e6761d65") },
                    { new Guid("1eaaba04-80ff-43a6-a746-a74a91c6c1e6"), new DateTime(2023, 9, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "Description", 1500.0, 2000.0, new Guid("cc37720a-7e89-463a-9510-1936e6761d8a"), 1, new Guid("cc37720a-7e89-463a-9510-1936e6761d73"), 0, new Guid("cc37720a-7e89-463a-9510-1936e6761d64"), new Guid("cc37720a-7e89-463a-9510-1936e6761d65") },
                    { new Guid("1eaaba04-80ff-43a6-a746-a74a91c6c1e7"), new DateTime(2023, 9, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "Description", 1500.0, 2000.0, new Guid("cc37720a-7e89-463a-9510-1936e6761d8a"), 1, new Guid("cc37720a-7e89-463a-9510-1936e6761d73"), 0, new Guid("cc37720a-7e89-463a-9510-1936e6761d74"), new Guid("cc37720a-7e89-463a-9510-1936e6761d65") },
                    { new Guid("1eaaba04-80ff-43a6-a746-a74a91c6c1e8"), new DateTime(2023, 9, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "Description", 1500.0, 2000.0, new Guid("cc37720a-7e89-463a-9510-1936e6761d8a"), 1, new Guid("cc37720a-7e89-463a-9510-1936e6761d73"), 0, new Guid("cc37720a-7e89-463a-9510-1936e6761d84"), new Guid("cc37720a-7e89-463a-9510-1936e6761d65") },
                    { new Guid("1eaaba04-80ff-43a6-a746-a74a91c6c1e9"), new DateTime(2023, 9, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "Description", 1500.0, 2000.0, new Guid("cc37720a-7e89-463a-9510-1936e6761d8a"), 1, new Guid("cc37720a-7e89-463a-9510-1936e6761d73"), 0, new Guid("cc37720a-7e89-463a-9510-1936e6761d94"), new Guid("cc37720a-7e89-463a-9510-1936e6761d65") },
                    { new Guid("1eaaba04-80ff-43a6-a746-a74a91c6c2e0"), new DateTime(2023, 9, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "Description", 1500.0, 2000.0, new Guid("cc37720a-7e89-463a-9510-1936e6761d8a"), 1, new Guid("cc37720a-7e89-463a-9510-1936e6761d63"), 0, new Guid("cc37720a-7e89-463a-9510-1936e6761d04"), new Guid("cc37720a-7e89-463a-9510-1936e6761d65") },
                    { new Guid("1eaaba04-80ff-43a6-a746-a74a91c6c2e1"), new DateTime(2023, 9, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "Description", 1500.0, 2000.0, new Guid("cc37720a-7e89-463a-9510-1936e6761d8a"), 1, new Guid("cc37720a-7e89-463a-9510-1936e6761d63"), 0, new Guid("cc37720a-7e89-463a-9510-1936e6761d14"), new Guid("cc37720a-7e89-463a-9510-1936e6761d65") },
                    { new Guid("1eaaba04-80ff-43a6-a746-a74a91c6c2e2"), new DateTime(2023, 9, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "Description", 1500.0, 2000.0, new Guid("cc37720a-7e89-463a-9510-1936e6761d8a"), 1, new Guid("cc37720a-7e89-463a-9510-1936e6761d63"), 0, new Guid("cc37720a-7e89-463a-9510-1936e6761d24"), new Guid("cc37720a-7e89-463a-9510-1936e6761d65") },
                    { new Guid("1eaaba04-80ff-43a6-a746-a74a91c6c2e3"), new DateTime(2023, 9, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "Description", 1500.0, 2000.0, new Guid("cc37720a-7e89-463a-9510-1936e6761d8a"), 1, new Guid("cc37720a-7e89-463a-9510-1936e6761d63"), 0, new Guid("cc37720a-7e89-463a-9510-1936e6761d34"), new Guid("cc37720a-7e89-463a-9510-1936e6761d65") },
                    { new Guid("1eaaba04-80ff-43a6-a746-a74a91c6c2e4"), new DateTime(2023, 9, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "Description", 1500.0, 2000.0, new Guid("cc37720a-7e89-463a-9510-1936e6761d8a"), 1, new Guid("cc37720a-7e89-463a-9510-1936e6761d63"), 0, new Guid("cc37720a-7e89-463a-9510-1936e6761d44"), new Guid("cc37720a-7e89-463a-9510-1936e6761d65") },
                    { new Guid("1eaaba04-80ff-43a6-a746-a74a91c6c2e5"), new DateTime(2023, 9, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "Description", 1500.0, 2000.0, new Guid("cc37720a-7e89-463a-9510-1936e6761d8a"), 1, new Guid("cc37720a-7e89-463a-9510-1936e6761d63"), 0, new Guid("cc37720a-7e89-463a-9510-1936e6761d54"), new Guid("cc37720a-7e89-463a-9510-1936e6761d65") },
                    { new Guid("1eaaba04-80ff-43a6-a746-a74a91c6c2e6"), new DateTime(2023, 9, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "Description", 1500.0, 2000.0, new Guid("cc37720a-7e89-463a-9510-1936e6761d8a"), 1, new Guid("cc37720a-7e89-463a-9510-1936e6761d63"), 0, new Guid("cc37720a-7e89-463a-9510-1936e6761d64"), new Guid("cc37720a-7e89-463a-9510-1936e6761d65") },
                    { new Guid("1eaaba04-80ff-43a6-a746-a74a91c6c2e7"), new DateTime(2023, 9, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "Description", 1500.0, 2000.0, new Guid("cc37720a-7e89-463a-9510-1936e6761d8a"), 1, new Guid("cc37720a-7e89-463a-9510-1936e6761d63"), 0, new Guid("cc37720a-7e89-463a-9510-1936e6761d74"), new Guid("cc37720a-7e89-463a-9510-1936e6761d65") },
                    { new Guid("1eaaba04-80ff-43a6-a746-a74a91c6c2e8"), new DateTime(2023, 9, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "Description", 1500.0, 2000.0, new Guid("cc37720a-7e89-463a-9510-1936e6761d8a"), 1, new Guid("cc37720a-7e89-463a-9510-1936e6761d63"), 0, new Guid("cc37720a-7e89-463a-9510-1936e6761d84"), new Guid("cc37720a-7e89-463a-9510-1936e6761d65") },
                    { new Guid("1eaaba04-80ff-43a6-a746-a74a91c6c2e9"), new DateTime(2023, 9, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "Description", 1500.0, 2000.0, new Guid("cc37720a-7e89-463a-9510-1936e6761d8a"), 1, new Guid("cc37720a-7e89-463a-9510-1936e6761d63"), 0, new Guid("cc37720a-7e89-463a-9510-1936e6761d94"), new Guid("cc37720a-7e89-463a-9510-1936e6761d65") },
                    { new Guid("1eaaba04-80ff-43a6-a746-a74a91c6c3e0"), new DateTime(2023, 9, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "Description", 1500.0, 2000.0, new Guid("cc37720a-7e89-463a-9510-1936e6761d8a"), 1, new Guid("cc37720a-7e89-463a-9510-1936e6761d53"), 0, new Guid("cc37720a-7e89-463a-9510-1936e6761d04"), new Guid("cc37720a-7e89-463a-9510-1936e6761d65") },
                    { new Guid("1eaaba04-80ff-43a6-a746-a74a91c6c3e1"), new DateTime(2023, 9, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "Description", 1500.0, 2000.0, new Guid("cc37720a-7e89-463a-9510-1936e6761d8a"), 1, new Guid("cc37720a-7e89-463a-9510-1936e6761d53"), 0, new Guid("cc37720a-7e89-463a-9510-1936e6761d14"), new Guid("cc37720a-7e89-463a-9510-1936e6761d65") },
                    { new Guid("1eaaba04-80ff-43a6-a746-a74a91c6c3e2"), new DateTime(2023, 9, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "Description", 1500.0, 2000.0, new Guid("cc37720a-7e89-463a-9510-1936e6761d8a"), 1, new Guid("cc37720a-7e89-463a-9510-1936e6761d53"), 0, new Guid("cc37720a-7e89-463a-9510-1936e6761d24"), new Guid("cc37720a-7e89-463a-9510-1936e6761d65") },
                    { new Guid("1eaaba04-80ff-43a6-a746-a74a91c6c3e3"), new DateTime(2023, 9, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "Description", 1500.0, 2000.0, new Guid("cc37720a-7e89-463a-9510-1936e6761d8a"), 1, new Guid("cc37720a-7e89-463a-9510-1936e6761d53"), 0, new Guid("cc37720a-7e89-463a-9510-1936e6761d34"), new Guid("cc37720a-7e89-463a-9510-1936e6761d65") },
                    { new Guid("1eaaba04-80ff-43a6-a746-a74a91c6c3e4"), new DateTime(2023, 9, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "Description", 1500.0, 2000.0, new Guid("cc37720a-7e89-463a-9510-1936e6761d8a"), 1, new Guid("cc37720a-7e89-463a-9510-1936e6761d53"), 0, new Guid("cc37720a-7e89-463a-9510-1936e6761d44"), new Guid("cc37720a-7e89-463a-9510-1936e6761d65") },
                    { new Guid("1eaaba04-80ff-43a6-a746-a74a91c6c3e5"), new DateTime(2023, 9, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "Description", 1500.0, 2000.0, new Guid("cc37720a-7e89-463a-9510-1936e6761d8a"), 1, new Guid("cc37720a-7e89-463a-9510-1936e6761d53"), 0, new Guid("cc37720a-7e89-463a-9510-1936e6761d54"), new Guid("cc37720a-7e89-463a-9510-1936e6761d65") },
                    { new Guid("1eaaba04-80ff-43a6-a746-a74a91c6c3e6"), new DateTime(2023, 9, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "Description", 1500.0, 2000.0, new Guid("cc37720a-7e89-463a-9510-1936e6761d8a"), 1, new Guid("cc37720a-7e89-463a-9510-1936e6761d53"), 0, new Guid("cc37720a-7e89-463a-9510-1936e6761d64"), new Guid("cc37720a-7e89-463a-9510-1936e6761d65") },
                    { new Guid("1eaaba04-80ff-43a6-a746-a74a91c6c3e7"), new DateTime(2023, 9, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "Description", 1500.0, 2000.0, new Guid("cc37720a-7e89-463a-9510-1936e6761d8a"), 1, new Guid("cc37720a-7e89-463a-9510-1936e6761d53"), 0, new Guid("cc37720a-7e89-463a-9510-1936e6761d74"), new Guid("cc37720a-7e89-463a-9510-1936e6761d65") },
                    { new Guid("1eaaba04-80ff-43a6-a746-a74a91c6c3e8"), new DateTime(2023, 9, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "Description", 1500.0, 2000.0, new Guid("cc37720a-7e89-463a-9510-1936e6761d8a"), 1, new Guid("cc37720a-7e89-463a-9510-1936e6761d53"), 0, new Guid("cc37720a-7e89-463a-9510-1936e6761d84"), new Guid("cc37720a-7e89-463a-9510-1936e6761d65") },
                    { new Guid("1eaaba04-80ff-43a6-a746-a74a91c6c3e9"), new DateTime(2023, 9, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "Description", 1500.0, 2000.0, new Guid("cc37720a-7e89-463a-9510-1936e6761d8a"), 1, new Guid("cc37720a-7e89-463a-9510-1936e6761d53"), 0, new Guid("cc37720a-7e89-463a-9510-1936e6761d94"), new Guid("cc37720a-7e89-463a-9510-1936e6761d65") },
                    { new Guid("1eaaba04-80ff-43a6-a746-a74a91c7c0e0"), new DateTime(2023, 9, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "Description", 1500.0, 2000.0, new Guid("cc37720a-7e89-463a-9510-1936e6761d8a"), 1, new Guid("cc37720a-7e89-463a-9510-1936e6761d83"), 0, new Guid("cc37720a-7e89-463a-9510-1936e6761d04"), new Guid("cc37720a-7e89-463a-9510-1936e6761d55") },
                    { new Guid("1eaaba04-80ff-43a6-a746-a74a91c7c0e1"), new DateTime(2023, 9, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "Description", 1500.0, 2000.0, new Guid("cc37720a-7e89-463a-9510-1936e6761d8a"), 1, new Guid("cc37720a-7e89-463a-9510-1936e6761d83"), 0, new Guid("cc37720a-7e89-463a-9510-1936e6761d14"), new Guid("cc37720a-7e89-463a-9510-1936e6761d55") }
                });

            migrationBuilder.InsertData(
                table: "ProductDetails",
                columns: new[] { "Id", "CreateDate", "Description", "ImportPrice", "Price", "ProductID", "Quantity", "ShaftId", "Status", "TipId", "WeightId" },
                values: new object[,]
                {
                    { new Guid("1eaaba04-80ff-43a6-a746-a74a91c7c0e2"), new DateTime(2023, 9, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "Description", 1500.0, 2000.0, new Guid("cc37720a-7e89-463a-9510-1936e6761d8a"), 1, new Guid("cc37720a-7e89-463a-9510-1936e6761d83"), 0, new Guid("cc37720a-7e89-463a-9510-1936e6761d24"), new Guid("cc37720a-7e89-463a-9510-1936e6761d55") },
                    { new Guid("1eaaba04-80ff-43a6-a746-a74a91c7c0e3"), new DateTime(2023, 9, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "Description", 1500.0, 2000.0, new Guid("cc37720a-7e89-463a-9510-1936e6761d8a"), 1, new Guid("cc37720a-7e89-463a-9510-1936e6761d83"), 0, new Guid("cc37720a-7e89-463a-9510-1936e6761d34"), new Guid("cc37720a-7e89-463a-9510-1936e6761d55") },
                    { new Guid("1eaaba04-80ff-43a6-a746-a74a91c7c0e4"), new DateTime(2023, 9, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "Description", 1500.0, 2000.0, new Guid("cc37720a-7e89-463a-9510-1936e6761d8a"), 1, new Guid("cc37720a-7e89-463a-9510-1936e6761d83"), 0, new Guid("cc37720a-7e89-463a-9510-1936e6761d44"), new Guid("cc37720a-7e89-463a-9510-1936e6761d55") },
                    { new Guid("1eaaba04-80ff-43a6-a746-a74a91c7c0e5"), new DateTime(2023, 9, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "Description", 1500.0, 2000.0, new Guid("cc37720a-7e89-463a-9510-1936e6761d8a"), 1, new Guid("cc37720a-7e89-463a-9510-1936e6761d83"), 0, new Guid("cc37720a-7e89-463a-9510-1936e6761d54"), new Guid("cc37720a-7e89-463a-9510-1936e6761d55") },
                    { new Guid("1eaaba04-80ff-43a6-a746-a74a91c7c0e6"), new DateTime(2023, 9, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "Description", 1500.0, 2000.0, new Guid("cc37720a-7e89-463a-9510-1936e6761d8a"), 1, new Guid("cc37720a-7e89-463a-9510-1936e6761d83"), 0, new Guid("cc37720a-7e89-463a-9510-1936e6761d64"), new Guid("cc37720a-7e89-463a-9510-1936e6761d55") },
                    { new Guid("1eaaba04-80ff-43a6-a746-a74a91c7c0e7"), new DateTime(2023, 9, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "Description", 1500.0, 2000.0, new Guid("cc37720a-7e89-463a-9510-1936e6761d8a"), 1, new Guid("cc37720a-7e89-463a-9510-1936e6761d83"), 0, new Guid("cc37720a-7e89-463a-9510-1936e6761d74"), new Guid("cc37720a-7e89-463a-9510-1936e6761d55") },
                    { new Guid("1eaaba04-80ff-43a6-a746-a74a91c7c0e8"), new DateTime(2023, 9, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "Description", 1500.0, 2000.0, new Guid("cc37720a-7e89-463a-9510-1936e6761d8a"), 1, new Guid("cc37720a-7e89-463a-9510-1936e6761d83"), 0, new Guid("cc37720a-7e89-463a-9510-1936e6761d84"), new Guid("cc37720a-7e89-463a-9510-1936e6761d55") },
                    { new Guid("1eaaba04-80ff-43a6-a746-a74a91c7c0e9"), new DateTime(2023, 9, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "Description", 1500.0, 2000.0, new Guid("cc37720a-7e89-463a-9510-1936e6761d8a"), 1, new Guid("cc37720a-7e89-463a-9510-1936e6761d83"), 0, new Guid("cc37720a-7e89-463a-9510-1936e6761d94"), new Guid("cc37720a-7e89-463a-9510-1936e6761d55") },
                    { new Guid("1eaaba04-80ff-43a6-a746-a74a91c7c1e0"), new DateTime(2023, 9, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "Description", 1500.0, 2000.0, new Guid("cc37720a-7e89-463a-9510-1936e6761d8a"), 1, new Guid("cc37720a-7e89-463a-9510-1936e6761d73"), 0, new Guid("cc37720a-7e89-463a-9510-1936e6761d04"), new Guid("cc37720a-7e89-463a-9510-1936e6761d55") },
                    { new Guid("1eaaba04-80ff-43a6-a746-a74a91c7c1e1"), new DateTime(2023, 9, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "Description", 1500.0, 2000.0, new Guid("cc37720a-7e89-463a-9510-1936e6761d8a"), 1, new Guid("cc37720a-7e89-463a-9510-1936e6761d73"), 0, new Guid("cc37720a-7e89-463a-9510-1936e6761d14"), new Guid("cc37720a-7e89-463a-9510-1936e6761d55") },
                    { new Guid("1eaaba04-80ff-43a6-a746-a74a91c7c1e2"), new DateTime(2023, 9, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "Description", 1500.0, 2000.0, new Guid("cc37720a-7e89-463a-9510-1936e6761d8a"), 1, new Guid("cc37720a-7e89-463a-9510-1936e6761d73"), 0, new Guid("cc37720a-7e89-463a-9510-1936e6761d24"), new Guid("cc37720a-7e89-463a-9510-1936e6761d55") },
                    { new Guid("1eaaba04-80ff-43a6-a746-a74a91c7c1e3"), new DateTime(2023, 9, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "Description", 1500.0, 2000.0, new Guid("cc37720a-7e89-463a-9510-1936e6761d8a"), 1, new Guid("cc37720a-7e89-463a-9510-1936e6761d73"), 0, new Guid("cc37720a-7e89-463a-9510-1936e6761d34"), new Guid("cc37720a-7e89-463a-9510-1936e6761d55") },
                    { new Guid("1eaaba04-80ff-43a6-a746-a74a91c7c1e4"), new DateTime(2023, 9, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "Description", 1500.0, 2000.0, new Guid("cc37720a-7e89-463a-9510-1936e6761d8a"), 1, new Guid("cc37720a-7e89-463a-9510-1936e6761d73"), 0, new Guid("cc37720a-7e89-463a-9510-1936e6761d44"), new Guid("cc37720a-7e89-463a-9510-1936e6761d55") },
                    { new Guid("1eaaba04-80ff-43a6-a746-a74a91c7c1e5"), new DateTime(2023, 9, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "Description", 1500.0, 2000.0, new Guid("cc37720a-7e89-463a-9510-1936e6761d8a"), 1, new Guid("cc37720a-7e89-463a-9510-1936e6761d73"), 0, new Guid("cc37720a-7e89-463a-9510-1936e6761d54"), new Guid("cc37720a-7e89-463a-9510-1936e6761d55") },
                    { new Guid("1eaaba04-80ff-43a6-a746-a74a91c7c1e6"), new DateTime(2023, 9, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "Description", 1500.0, 2000.0, new Guid("cc37720a-7e89-463a-9510-1936e6761d8a"), 1, new Guid("cc37720a-7e89-463a-9510-1936e6761d73"), 0, new Guid("cc37720a-7e89-463a-9510-1936e6761d64"), new Guid("cc37720a-7e89-463a-9510-1936e6761d55") },
                    { new Guid("1eaaba04-80ff-43a6-a746-a74a91c7c1e7"), new DateTime(2023, 9, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "Description", 1500.0, 2000.0, new Guid("cc37720a-7e89-463a-9510-1936e6761d8a"), 1, new Guid("cc37720a-7e89-463a-9510-1936e6761d73"), 0, new Guid("cc37720a-7e89-463a-9510-1936e6761d74"), new Guid("cc37720a-7e89-463a-9510-1936e6761d55") },
                    { new Guid("1eaaba04-80ff-43a6-a746-a74a91c7c1e8"), new DateTime(2023, 9, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "Description", 1500.0, 2000.0, new Guid("cc37720a-7e89-463a-9510-1936e6761d8a"), 1, new Guid("cc37720a-7e89-463a-9510-1936e6761d73"), 0, new Guid("cc37720a-7e89-463a-9510-1936e6761d84"), new Guid("cc37720a-7e89-463a-9510-1936e6761d55") },
                    { new Guid("1eaaba04-80ff-43a6-a746-a74a91c7c1e9"), new DateTime(2023, 9, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "Description", 1500.0, 2000.0, new Guid("cc37720a-7e89-463a-9510-1936e6761d8a"), 1, new Guid("cc37720a-7e89-463a-9510-1936e6761d73"), 0, new Guid("cc37720a-7e89-463a-9510-1936e6761d94"), new Guid("cc37720a-7e89-463a-9510-1936e6761d55") },
                    { new Guid("1eaaba04-80ff-43a6-a746-a74a91c7c2e0"), new DateTime(2023, 9, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "Description", 1500.0, 2000.0, new Guid("cc37720a-7e89-463a-9510-1936e6761d8a"), 1, new Guid("cc37720a-7e89-463a-9510-1936e6761d63"), 0, new Guid("cc37720a-7e89-463a-9510-1936e6761d04"), new Guid("cc37720a-7e89-463a-9510-1936e6761d55") },
                    { new Guid("1eaaba04-80ff-43a6-a746-a74a91c7c2e1"), new DateTime(2023, 9, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "Description", 1500.0, 2000.0, new Guid("cc37720a-7e89-463a-9510-1936e6761d8a"), 1, new Guid("cc37720a-7e89-463a-9510-1936e6761d63"), 0, new Guid("cc37720a-7e89-463a-9510-1936e6761d14"), new Guid("cc37720a-7e89-463a-9510-1936e6761d55") },
                    { new Guid("1eaaba04-80ff-43a6-a746-a74a91c7c2e2"), new DateTime(2023, 9, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "Description", 1500.0, 2000.0, new Guid("cc37720a-7e89-463a-9510-1936e6761d8a"), 1, new Guid("cc37720a-7e89-463a-9510-1936e6761d63"), 0, new Guid("cc37720a-7e89-463a-9510-1936e6761d24"), new Guid("cc37720a-7e89-463a-9510-1936e6761d55") },
                    { new Guid("1eaaba04-80ff-43a6-a746-a74a91c7c2e3"), new DateTime(2023, 9, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "Description", 1500.0, 2000.0, new Guid("cc37720a-7e89-463a-9510-1936e6761d8a"), 1, new Guid("cc37720a-7e89-463a-9510-1936e6761d63"), 0, new Guid("cc37720a-7e89-463a-9510-1936e6761d34"), new Guid("cc37720a-7e89-463a-9510-1936e6761d55") },
                    { new Guid("1eaaba04-80ff-43a6-a746-a74a91c7c2e4"), new DateTime(2023, 9, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "Description", 1500.0, 2000.0, new Guid("cc37720a-7e89-463a-9510-1936e6761d8a"), 1, new Guid("cc37720a-7e89-463a-9510-1936e6761d63"), 0, new Guid("cc37720a-7e89-463a-9510-1936e6761d44"), new Guid("cc37720a-7e89-463a-9510-1936e6761d55") },
                    { new Guid("1eaaba04-80ff-43a6-a746-a74a91c7c2e5"), new DateTime(2023, 9, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "Description", 1500.0, 2000.0, new Guid("cc37720a-7e89-463a-9510-1936e6761d8a"), 1, new Guid("cc37720a-7e89-463a-9510-1936e6761d63"), 0, new Guid("cc37720a-7e89-463a-9510-1936e6761d54"), new Guid("cc37720a-7e89-463a-9510-1936e6761d55") },
                    { new Guid("1eaaba04-80ff-43a6-a746-a74a91c7c2e6"), new DateTime(2023, 9, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "Description", 1500.0, 2000.0, new Guid("cc37720a-7e89-463a-9510-1936e6761d8a"), 1, new Guid("cc37720a-7e89-463a-9510-1936e6761d63"), 0, new Guid("cc37720a-7e89-463a-9510-1936e6761d64"), new Guid("cc37720a-7e89-463a-9510-1936e6761d55") },
                    { new Guid("1eaaba04-80ff-43a6-a746-a74a91c7c2e7"), new DateTime(2023, 9, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "Description", 1500.0, 2000.0, new Guid("cc37720a-7e89-463a-9510-1936e6761d8a"), 1, new Guid("cc37720a-7e89-463a-9510-1936e6761d63"), 0, new Guid("cc37720a-7e89-463a-9510-1936e6761d74"), new Guid("cc37720a-7e89-463a-9510-1936e6761d55") },
                    { new Guid("1eaaba04-80ff-43a6-a746-a74a91c7c2e8"), new DateTime(2023, 9, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "Description", 1500.0, 2000.0, new Guid("cc37720a-7e89-463a-9510-1936e6761d8a"), 1, new Guid("cc37720a-7e89-463a-9510-1936e6761d63"), 0, new Guid("cc37720a-7e89-463a-9510-1936e6761d84"), new Guid("cc37720a-7e89-463a-9510-1936e6761d55") },
                    { new Guid("1eaaba04-80ff-43a6-a746-a74a91c7c2e9"), new DateTime(2023, 9, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "Description", 1500.0, 2000.0, new Guid("cc37720a-7e89-463a-9510-1936e6761d8a"), 1, new Guid("cc37720a-7e89-463a-9510-1936e6761d63"), 0, new Guid("cc37720a-7e89-463a-9510-1936e6761d94"), new Guid("cc37720a-7e89-463a-9510-1936e6761d55") },
                    { new Guid("1eaaba04-80ff-43a6-a746-a74a91c7c3e0"), new DateTime(2023, 9, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "Description", 1500.0, 2000.0, new Guid("cc37720a-7e89-463a-9510-1936e6761d8a"), 1, new Guid("cc37720a-7e89-463a-9510-1936e6761d53"), 0, new Guid("cc37720a-7e89-463a-9510-1936e6761d04"), new Guid("cc37720a-7e89-463a-9510-1936e6761d55") },
                    { new Guid("1eaaba04-80ff-43a6-a746-a74a91c7c3e1"), new DateTime(2023, 9, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "Description", 1500.0, 2000.0, new Guid("cc37720a-7e89-463a-9510-1936e6761d8a"), 1, new Guid("cc37720a-7e89-463a-9510-1936e6761d53"), 0, new Guid("cc37720a-7e89-463a-9510-1936e6761d14"), new Guid("cc37720a-7e89-463a-9510-1936e6761d55") },
                    { new Guid("1eaaba04-80ff-43a6-a746-a74a91c7c3e2"), new DateTime(2023, 9, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "Description", 1500.0, 2000.0, new Guid("cc37720a-7e89-463a-9510-1936e6761d8a"), 1, new Guid("cc37720a-7e89-463a-9510-1936e6761d53"), 0, new Guid("cc37720a-7e89-463a-9510-1936e6761d24"), new Guid("cc37720a-7e89-463a-9510-1936e6761d55") },
                    { new Guid("1eaaba04-80ff-43a6-a746-a74a91c7c3e3"), new DateTime(2023, 9, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "Description", 1500.0, 2000.0, new Guid("cc37720a-7e89-463a-9510-1936e6761d8a"), 1, new Guid("cc37720a-7e89-463a-9510-1936e6761d53"), 0, new Guid("cc37720a-7e89-463a-9510-1936e6761d34"), new Guid("cc37720a-7e89-463a-9510-1936e6761d55") },
                    { new Guid("1eaaba04-80ff-43a6-a746-a74a91c7c3e4"), new DateTime(2023, 9, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "Description", 1500.0, 2000.0, new Guid("cc37720a-7e89-463a-9510-1936e6761d8a"), 1, new Guid("cc37720a-7e89-463a-9510-1936e6761d53"), 0, new Guid("cc37720a-7e89-463a-9510-1936e6761d44"), new Guid("cc37720a-7e89-463a-9510-1936e6761d55") },
                    { new Guid("1eaaba04-80ff-43a6-a746-a74a91c7c3e5"), new DateTime(2023, 9, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "Description", 1500.0, 2000.0, new Guid("cc37720a-7e89-463a-9510-1936e6761d8a"), 1, new Guid("cc37720a-7e89-463a-9510-1936e6761d53"), 0, new Guid("cc37720a-7e89-463a-9510-1936e6761d54"), new Guid("cc37720a-7e89-463a-9510-1936e6761d55") },
                    { new Guid("1eaaba04-80ff-43a6-a746-a74a91c7c3e6"), new DateTime(2023, 9, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "Description", 1500.0, 2000.0, new Guid("cc37720a-7e89-463a-9510-1936e6761d8a"), 1, new Guid("cc37720a-7e89-463a-9510-1936e6761d53"), 0, new Guid("cc37720a-7e89-463a-9510-1936e6761d64"), new Guid("cc37720a-7e89-463a-9510-1936e6761d55") },
                    { new Guid("1eaaba04-80ff-43a6-a746-a74a91c7c3e7"), new DateTime(2023, 9, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "Description", 1500.0, 2000.0, new Guid("cc37720a-7e89-463a-9510-1936e6761d8a"), 1, new Guid("cc37720a-7e89-463a-9510-1936e6761d53"), 0, new Guid("cc37720a-7e89-463a-9510-1936e6761d74"), new Guid("cc37720a-7e89-463a-9510-1936e6761d55") },
                    { new Guid("1eaaba04-80ff-43a6-a746-a74a91c7c3e8"), new DateTime(2023, 9, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "Description", 1500.0, 2000.0, new Guid("cc37720a-7e89-463a-9510-1936e6761d8a"), 1, new Guid("cc37720a-7e89-463a-9510-1936e6761d53"), 0, new Guid("cc37720a-7e89-463a-9510-1936e6761d84"), new Guid("cc37720a-7e89-463a-9510-1936e6761d55") },
                    { new Guid("1eaaba04-80ff-43a6-a746-a74a91c7c3e9"), new DateTime(2023, 9, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "Description", 1500.0, 2000.0, new Guid("cc37720a-7e89-463a-9510-1936e6761d8a"), 1, new Guid("cc37720a-7e89-463a-9510-1936e6761d53"), 0, new Guid("cc37720a-7e89-463a-9510-1936e6761d94"), new Guid("cc37720a-7e89-463a-9510-1936e6761d55") },
                    { new Guid("2eaaba04-80ff-43a6-a746-a74a91c4c0e0"), new DateTime(2023, 9, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "Description", 4000000.0, 5000000.0, new Guid("cc37720a-7e89-463a-9510-1936e6761d8b"), 1, new Guid("cc37720a-7e89-463a-9510-1936e6761d73"), 0, new Guid("cc37720a-7e89-463a-9510-1936e6761d74"), new Guid("cc37720a-7e89-463a-9510-1936e6761d75") },
                    { new Guid("2eaaba04-80ff-43a6-a746-a74a91c4c0e1"), new DateTime(2023, 9, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "Description", 4000000.0, 5000000.0, new Guid("cc37720a-7e89-463a-9510-1936e6761d8b"), 1, new Guid("cc37720a-7e89-463a-9510-1936e6761d83"), 0, new Guid("cc37720a-7e89-463a-9510-1936e6761d14"), new Guid("cc37720a-7e89-463a-9510-1936e6761d85") },
                    { new Guid("2eaaba04-80ff-43a6-a746-a74a91c4c0e2"), new DateTime(2023, 9, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "Description", 4000000.0, 5000000.0, new Guid("cc37720a-7e89-463a-9510-1936e6761d8b"), 1, new Guid("cc37720a-7e89-463a-9510-1936e6761d83"), 0, new Guid("cc37720a-7e89-463a-9510-1936e6761d24"), new Guid("cc37720a-7e89-463a-9510-1936e6761d85") },
                    { new Guid("2eaaba04-80ff-43a6-a746-a74a91c4c0e3"), new DateTime(2023, 9, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "Description", 4000000.0, 5000000.0, new Guid("cc37720a-7e89-463a-9510-1936e6761d8b"), 1, new Guid("cc37720a-7e89-463a-9510-1936e6761d83"), 0, new Guid("cc37720a-7e89-463a-9510-1936e6761d34"), new Guid("cc37720a-7e89-463a-9510-1936e6761d85") }
                });

            migrationBuilder.InsertData(
                table: "ProductDetails",
                columns: new[] { "Id", "CreateDate", "Description", "ImportPrice", "Price", "ProductID", "Quantity", "ShaftId", "Status", "TipId", "WeightId" },
                values: new object[,]
                {
                    { new Guid("2eaaba04-80ff-43a6-a746-a74a91c4c0e4"), new DateTime(2023, 9, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "Description", 4000000.0, 5000000.0, new Guid("cc37720a-7e89-463a-9510-1936e6761d8b"), 1, new Guid("cc37720a-7e89-463a-9510-1936e6761d83"), 0, new Guid("cc37720a-7e89-463a-9510-1936e6761d44"), new Guid("cc37720a-7e89-463a-9510-1936e6761d85") },
                    { new Guid("2eaaba04-80ff-43a6-a746-a74a91c4c0e5"), new DateTime(2023, 9, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "Description", 4000000.0, 5000000.0, new Guid("cc37720a-7e89-463a-9510-1936e6761d8b"), 1, new Guid("cc37720a-7e89-463a-9510-1936e6761d83"), 0, new Guid("cc37720a-7e89-463a-9510-1936e6761d54"), new Guid("cc37720a-7e89-463a-9510-1936e6761d85") },
                    { new Guid("2eaaba04-80ff-43a6-a746-a74a91c4c0e6"), new DateTime(2023, 9, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "Description", 4000000.0, 5000000.0, new Guid("cc37720a-7e89-463a-9510-1936e6761d8b"), 1, new Guid("cc37720a-7e89-463a-9510-1936e6761d83"), 0, new Guid("cc37720a-7e89-463a-9510-1936e6761d64"), new Guid("cc37720a-7e89-463a-9510-1936e6761d85") },
                    { new Guid("2eaaba04-80ff-43a6-a746-a74a91c4c0e7"), new DateTime(2023, 9, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "Description", 4000000.0, 5000000.0, new Guid("cc37720a-7e89-463a-9510-1936e6761d8b"), 1, new Guid("cc37720a-7e89-463a-9510-1936e6761d83"), 0, new Guid("cc37720a-7e89-463a-9510-1936e6761d74"), new Guid("cc37720a-7e89-463a-9510-1936e6761d85") },
                    { new Guid("2eaaba04-80ff-43a6-a746-a74a91c4c0e8"), new DateTime(2023, 9, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "Description", 4000000.0, 5000000.0, new Guid("cc37720a-7e89-463a-9510-1936e6761d8b"), 1, new Guid("cc37720a-7e89-463a-9510-1936e6761d83"), 0, new Guid("cc37720a-7e89-463a-9510-1936e6761d84"), new Guid("cc37720a-7e89-463a-9510-1936e6761d85") },
                    { new Guid("2eaaba04-80ff-43a6-a746-a74a91c4c0e9"), new DateTime(2023, 9, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "Description", 4000000.0, 5000000.0, new Guid("cc37720a-7e89-463a-9510-1936e6761d8b"), 1, new Guid("cc37720a-7e89-463a-9510-1936e6761d83"), 0, new Guid("cc37720a-7e89-463a-9510-1936e6761d94"), new Guid("cc37720a-7e89-463a-9510-1936e6761d85") },
                    { new Guid("2eaaba04-80ff-43a6-a746-a74a91c4c1e0"), new DateTime(2023, 9, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "Description", 4000000.0, 5000000.0, new Guid("cc37720a-7e89-463a-9510-1936e6761d8b"), 1, new Guid("cc37720a-7e89-463a-9510-1936e6761d73"), 0, new Guid("cc37720a-7e89-463a-9510-1936e6761d04"), new Guid("cc37720a-7e89-463a-9510-1936e6761d85") },
                    { new Guid("2eaaba04-80ff-43a6-a746-a74a91c4c1e1"), new DateTime(2023, 9, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "Description", 4000000.0, 5000000.0, new Guid("cc37720a-7e89-463a-9510-1936e6761d8b"), 1, new Guid("cc37720a-7e89-463a-9510-1936e6761d73"), 0, new Guid("cc37720a-7e89-463a-9510-1936e6761d14"), new Guid("cc37720a-7e89-463a-9510-1936e6761d85") },
                    { new Guid("2eaaba04-80ff-43a6-a746-a74a91c4c1e2"), new DateTime(2023, 9, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "Description", 4000000.0, 5000000.0, new Guid("cc37720a-7e89-463a-9510-1936e6761d8b"), 1, new Guid("cc37720a-7e89-463a-9510-1936e6761d73"), 0, new Guid("cc37720a-7e89-463a-9510-1936e6761d24"), new Guid("cc37720a-7e89-463a-9510-1936e6761d85") },
                    { new Guid("2eaaba04-80ff-43a6-a746-a74a91c4c1e3"), new DateTime(2023, 9, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "Description", 4000000.0, 5000000.0, new Guid("cc37720a-7e89-463a-9510-1936e6761d8b"), 1, new Guid("cc37720a-7e89-463a-9510-1936e6761d73"), 0, new Guid("cc37720a-7e89-463a-9510-1936e6761d34"), new Guid("cc37720a-7e89-463a-9510-1936e6761d85") },
                    { new Guid("2eaaba04-80ff-43a6-a746-a74a91c4c1e4"), new DateTime(2023, 9, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "Description", 4000000.0, 5000000.0, new Guid("cc37720a-7e89-463a-9510-1936e6761d8b"), 1, new Guid("cc37720a-7e89-463a-9510-1936e6761d73"), 0, new Guid("cc37720a-7e89-463a-9510-1936e6761d44"), new Guid("cc37720a-7e89-463a-9510-1936e6761d85") },
                    { new Guid("2eaaba04-80ff-43a6-a746-a74a91c4c1e5"), new DateTime(2023, 9, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "Description", 4000000.0, 5000000.0, new Guid("cc37720a-7e89-463a-9510-1936e6761d8b"), 1, new Guid("cc37720a-7e89-463a-9510-1936e6761d73"), 0, new Guid("cc37720a-7e89-463a-9510-1936e6761d54"), new Guid("cc37720a-7e89-463a-9510-1936e6761d85") },
                    { new Guid("2eaaba04-80ff-43a6-a746-a74a91c4c1e6"), new DateTime(2023, 9, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "Description", 4000000.0, 5000000.0, new Guid("cc37720a-7e89-463a-9510-1936e6761d8b"), 1, new Guid("cc37720a-7e89-463a-9510-1936e6761d73"), 0, new Guid("cc37720a-7e89-463a-9510-1936e6761d64"), new Guid("cc37720a-7e89-463a-9510-1936e6761d85") },
                    { new Guid("2eaaba04-80ff-43a6-a746-a74a91c4c1e7"), new DateTime(2023, 9, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "Description", 4000000.0, 5000000.0, new Guid("cc37720a-7e89-463a-9510-1936e6761d8b"), 1, new Guid("cc37720a-7e89-463a-9510-1936e6761d73"), 0, new Guid("cc37720a-7e89-463a-9510-1936e6761d74"), new Guid("cc37720a-7e89-463a-9510-1936e6761d85") },
                    { new Guid("2eaaba04-80ff-43a6-a746-a74a91c4c1e8"), new DateTime(2023, 9, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "Description", 4000000.0, 5000000.0, new Guid("cc37720a-7e89-463a-9510-1936e6761d8b"), 1, new Guid("cc37720a-7e89-463a-9510-1936e6761d73"), 0, new Guid("cc37720a-7e89-463a-9510-1936e6761d84"), new Guid("cc37720a-7e89-463a-9510-1936e6761d85") },
                    { new Guid("2eaaba04-80ff-43a6-a746-a74a91c4c1e9"), new DateTime(2023, 9, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "Description", 4000000.0, 5000000.0, new Guid("cc37720a-7e89-463a-9510-1936e6761d8b"), 1, new Guid("cc37720a-7e89-463a-9510-1936e6761d73"), 0, new Guid("cc37720a-7e89-463a-9510-1936e6761d94"), new Guid("cc37720a-7e89-463a-9510-1936e6761d85") },
                    { new Guid("2eaaba04-80ff-43a6-a746-a74a91c4c2e0"), new DateTime(2023, 9, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "Description", 4000000.0, 5000000.0, new Guid("cc37720a-7e89-463a-9510-1936e6761d8b"), 1, new Guid("cc37720a-7e89-463a-9510-1936e6761d63"), 0, new Guid("cc37720a-7e89-463a-9510-1936e6761d04"), new Guid("cc37720a-7e89-463a-9510-1936e6761d85") },
                    { new Guid("2eaaba04-80ff-43a6-a746-a74a91c4c2e1"), new DateTime(2023, 9, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "Description", 4000000.0, 5000000.0, new Guid("cc37720a-7e89-463a-9510-1936e6761d8b"), 1, new Guid("cc37720a-7e89-463a-9510-1936e6761d63"), 0, new Guid("cc37720a-7e89-463a-9510-1936e6761d14"), new Guid("cc37720a-7e89-463a-9510-1936e6761d85") },
                    { new Guid("2eaaba04-80ff-43a6-a746-a74a91c4c2e2"), new DateTime(2023, 9, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "Description", 4000000.0, 5000000.0, new Guid("cc37720a-7e89-463a-9510-1936e6761d8b"), 1, new Guid("cc37720a-7e89-463a-9510-1936e6761d63"), 0, new Guid("cc37720a-7e89-463a-9510-1936e6761d24"), new Guid("cc37720a-7e89-463a-9510-1936e6761d85") },
                    { new Guid("2eaaba04-80ff-43a6-a746-a74a91c4c2e3"), new DateTime(2023, 9, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "Description", 4000000.0, 5000000.0, new Guid("cc37720a-7e89-463a-9510-1936e6761d8b"), 1, new Guid("cc37720a-7e89-463a-9510-1936e6761d63"), 0, new Guid("cc37720a-7e89-463a-9510-1936e6761d34"), new Guid("cc37720a-7e89-463a-9510-1936e6761d85") },
                    { new Guid("2eaaba04-80ff-43a6-a746-a74a91c4c2e4"), new DateTime(2023, 9, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "Description", 4000000.0, 5000000.0, new Guid("cc37720a-7e89-463a-9510-1936e6761d8b"), 1, new Guid("cc37720a-7e89-463a-9510-1936e6761d63"), 0, new Guid("cc37720a-7e89-463a-9510-1936e6761d44"), new Guid("cc37720a-7e89-463a-9510-1936e6761d85") },
                    { new Guid("2eaaba04-80ff-43a6-a746-a74a91c4c2e5"), new DateTime(2023, 9, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "Description", 4000000.0, 5000000.0, new Guid("cc37720a-7e89-463a-9510-1936e6761d8b"), 1, new Guid("cc37720a-7e89-463a-9510-1936e6761d63"), 0, new Guid("cc37720a-7e89-463a-9510-1936e6761d54"), new Guid("cc37720a-7e89-463a-9510-1936e6761d85") },
                    { new Guid("2eaaba04-80ff-43a6-a746-a74a91c4c2e6"), new DateTime(2023, 9, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "Description", 4000000.0, 5000000.0, new Guid("cc37720a-7e89-463a-9510-1936e6761d8b"), 1, new Guid("cc37720a-7e89-463a-9510-1936e6761d63"), 0, new Guid("cc37720a-7e89-463a-9510-1936e6761d64"), new Guid("cc37720a-7e89-463a-9510-1936e6761d85") },
                    { new Guid("2eaaba04-80ff-43a6-a746-a74a91c4c2e7"), new DateTime(2023, 9, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "Description", 4000000.0, 5000000.0, new Guid("cc37720a-7e89-463a-9510-1936e6761d8b"), 1, new Guid("cc37720a-7e89-463a-9510-1936e6761d63"), 0, new Guid("cc37720a-7e89-463a-9510-1936e6761d74"), new Guid("cc37720a-7e89-463a-9510-1936e6761d85") },
                    { new Guid("2eaaba04-80ff-43a6-a746-a74a91c4c2e8"), new DateTime(2023, 9, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "Description", 4000000.0, 5000000.0, new Guid("cc37720a-7e89-463a-9510-1936e6761d8b"), 1, new Guid("cc37720a-7e89-463a-9510-1936e6761d63"), 0, new Guid("cc37720a-7e89-463a-9510-1936e6761d84"), new Guid("cc37720a-7e89-463a-9510-1936e6761d85") },
                    { new Guid("2eaaba04-80ff-43a6-a746-a74a91c4c2e9"), new DateTime(2023, 9, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "Description", 4000000.0, 5000000.0, new Guid("cc37720a-7e89-463a-9510-1936e6761d8b"), 1, new Guid("cc37720a-7e89-463a-9510-1936e6761d63"), 0, new Guid("cc37720a-7e89-463a-9510-1936e6761d94"), new Guid("cc37720a-7e89-463a-9510-1936e6761d85") },
                    { new Guid("2eaaba04-80ff-43a6-a746-a74a91c4c3e0"), new DateTime(2023, 9, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "Description", 4000000.0, 5000000.0, new Guid("cc37720a-7e89-463a-9510-1936e6761d8b"), 1, new Guid("cc37720a-7e89-463a-9510-1936e6761d53"), 0, new Guid("cc37720a-7e89-463a-9510-1936e6761d04"), new Guid("cc37720a-7e89-463a-9510-1936e6761d85") },
                    { new Guid("2eaaba04-80ff-43a6-a746-a74a91c4c3e1"), new DateTime(2023, 9, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "Description", 4000000.0, 5000000.0, new Guid("cc37720a-7e89-463a-9510-1936e6761d8b"), 1, new Guid("cc37720a-7e89-463a-9510-1936e6761d53"), 0, new Guid("cc37720a-7e89-463a-9510-1936e6761d14"), new Guid("cc37720a-7e89-463a-9510-1936e6761d85") },
                    { new Guid("2eaaba04-80ff-43a6-a746-a74a91c4c3e2"), new DateTime(2023, 9, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "Description", 4000000.0, 5000000.0, new Guid("cc37720a-7e89-463a-9510-1936e6761d8b"), 1, new Guid("cc37720a-7e89-463a-9510-1936e6761d53"), 0, new Guid("cc37720a-7e89-463a-9510-1936e6761d24"), new Guid("cc37720a-7e89-463a-9510-1936e6761d85") },
                    { new Guid("2eaaba04-80ff-43a6-a746-a74a91c4c3e3"), new DateTime(2023, 9, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "Description", 4000000.0, 5000000.0, new Guid("cc37720a-7e89-463a-9510-1936e6761d8b"), 1, new Guid("cc37720a-7e89-463a-9510-1936e6761d53"), 0, new Guid("cc37720a-7e89-463a-9510-1936e6761d34"), new Guid("cc37720a-7e89-463a-9510-1936e6761d85") },
                    { new Guid("2eaaba04-80ff-43a6-a746-a74a91c4c3e4"), new DateTime(2023, 9, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "Description", 4000000.0, 5000000.0, new Guid("cc37720a-7e89-463a-9510-1936e6761d8b"), 1, new Guid("cc37720a-7e89-463a-9510-1936e6761d53"), 0, new Guid("cc37720a-7e89-463a-9510-1936e6761d44"), new Guid("cc37720a-7e89-463a-9510-1936e6761d85") },
                    { new Guid("2eaaba04-80ff-43a6-a746-a74a91c4c3e5"), new DateTime(2023, 9, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "Description", 4000000.0, 5000000.0, new Guid("cc37720a-7e89-463a-9510-1936e6761d8b"), 1, new Guid("cc37720a-7e89-463a-9510-1936e6761d53"), 0, new Guid("cc37720a-7e89-463a-9510-1936e6761d54"), new Guid("cc37720a-7e89-463a-9510-1936e6761d85") },
                    { new Guid("2eaaba04-80ff-43a6-a746-a74a91c4c3e6"), new DateTime(2023, 9, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "Description", 4000000.0, 5000000.0, new Guid("cc37720a-7e89-463a-9510-1936e6761d8b"), 1, new Guid("cc37720a-7e89-463a-9510-1936e6761d53"), 0, new Guid("cc37720a-7e89-463a-9510-1936e6761d64"), new Guid("cc37720a-7e89-463a-9510-1936e6761d85") },
                    { new Guid("2eaaba04-80ff-43a6-a746-a74a91c4c3e7"), new DateTime(2023, 9, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "Description", 4000000.0, 5000000.0, new Guid("cc37720a-7e89-463a-9510-1936e6761d8b"), 1, new Guid("cc37720a-7e89-463a-9510-1936e6761d53"), 0, new Guid("cc37720a-7e89-463a-9510-1936e6761d74"), new Guid("cc37720a-7e89-463a-9510-1936e6761d85") },
                    { new Guid("2eaaba04-80ff-43a6-a746-a74a91c4c3e8"), new DateTime(2023, 9, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "Description", 4000000.0, 5000000.0, new Guid("cc37720a-7e89-463a-9510-1936e6761d8b"), 1, new Guid("cc37720a-7e89-463a-9510-1936e6761d53"), 0, new Guid("cc37720a-7e89-463a-9510-1936e6761d84"), new Guid("cc37720a-7e89-463a-9510-1936e6761d85") },
                    { new Guid("2eaaba04-80ff-43a6-a746-a74a91c4c3e9"), new DateTime(2023, 9, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "Description", 4000000.0, 5000000.0, new Guid("cc37720a-7e89-463a-9510-1936e6761d8b"), 1, new Guid("cc37720a-7e89-463a-9510-1936e6761d53"), 0, new Guid("cc37720a-7e89-463a-9510-1936e6761d94"), new Guid("cc37720a-7e89-463a-9510-1936e6761d85") },
                    { new Guid("2eaaba04-80ff-43a6-a746-a74a91c5c0e0"), new DateTime(2023, 9, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "Description", 4000000.0, 5000000.0, new Guid("cc37720a-7e89-463a-9510-1936e6761d8b"), 1, new Guid("cc37720a-7e89-463a-9510-1936e6761d83"), 0, new Guid("cc37720a-7e89-463a-9510-1936e6761d04"), new Guid("cc37720a-7e89-463a-9510-1936e6761d75") },
                    { new Guid("2eaaba04-80ff-43a6-a746-a74a91c5c0e1"), new DateTime(2023, 9, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "Description", 4000000.0, 5000000.0, new Guid("cc37720a-7e89-463a-9510-1936e6761d8b"), 1, new Guid("cc37720a-7e89-463a-9510-1936e6761d83"), 0, new Guid("cc37720a-7e89-463a-9510-1936e6761d14"), new Guid("cc37720a-7e89-463a-9510-1936e6761d75") },
                    { new Guid("2eaaba04-80ff-43a6-a746-a74a91c5c0e2"), new DateTime(2023, 9, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "Description", 4000000.0, 5000000.0, new Guid("cc37720a-7e89-463a-9510-1936e6761d8b"), 1, new Guid("cc37720a-7e89-463a-9510-1936e6761d83"), 0, new Guid("cc37720a-7e89-463a-9510-1936e6761d24"), new Guid("cc37720a-7e89-463a-9510-1936e6761d75") },
                    { new Guid("2eaaba04-80ff-43a6-a746-a74a91c5c0e3"), new DateTime(2023, 9, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "Description", 4000000.0, 5000000.0, new Guid("cc37720a-7e89-463a-9510-1936e6761d8b"), 1, new Guid("cc37720a-7e89-463a-9510-1936e6761d83"), 0, new Guid("cc37720a-7e89-463a-9510-1936e6761d34"), new Guid("cc37720a-7e89-463a-9510-1936e6761d75") },
                    { new Guid("2eaaba04-80ff-43a6-a746-a74a91c5c0e4"), new DateTime(2023, 9, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "Description", 4000000.0, 5000000.0, new Guid("cc37720a-7e89-463a-9510-1936e6761d8b"), 1, new Guid("cc37720a-7e89-463a-9510-1936e6761d83"), 0, new Guid("cc37720a-7e89-463a-9510-1936e6761d44"), new Guid("cc37720a-7e89-463a-9510-1936e6761d75") },
                    { new Guid("2eaaba04-80ff-43a6-a746-a74a91c5c0e5"), new DateTime(2023, 9, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "Description", 4000000.0, 5000000.0, new Guid("cc37720a-7e89-463a-9510-1936e6761d8b"), 1, new Guid("cc37720a-7e89-463a-9510-1936e6761d83"), 0, new Guid("cc37720a-7e89-463a-9510-1936e6761d54"), new Guid("cc37720a-7e89-463a-9510-1936e6761d75") }
                });

            migrationBuilder.InsertData(
                table: "ProductDetails",
                columns: new[] { "Id", "CreateDate", "Description", "ImportPrice", "Price", "ProductID", "Quantity", "ShaftId", "Status", "TipId", "WeightId" },
                values: new object[,]
                {
                    { new Guid("2eaaba04-80ff-43a6-a746-a74a91c5c0e6"), new DateTime(2023, 9, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "Description", 4000000.0, 5000000.0, new Guid("cc37720a-7e89-463a-9510-1936e6761d8b"), 1, new Guid("cc37720a-7e89-463a-9510-1936e6761d83"), 0, new Guid("cc37720a-7e89-463a-9510-1936e6761d64"), new Guid("cc37720a-7e89-463a-9510-1936e6761d75") },
                    { new Guid("2eaaba04-80ff-43a6-a746-a74a91c5c0e7"), new DateTime(2023, 9, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "Description", 4000000.0, 5000000.0, new Guid("cc37720a-7e89-463a-9510-1936e6761d8b"), 1, new Guid("cc37720a-7e89-463a-9510-1936e6761d83"), 0, new Guid("cc37720a-7e89-463a-9510-1936e6761d74"), new Guid("cc37720a-7e89-463a-9510-1936e6761d75") },
                    { new Guid("2eaaba04-80ff-43a6-a746-a74a91c5c0e8"), new DateTime(2023, 9, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "Description", 4000000.0, 5000000.0, new Guid("cc37720a-7e89-463a-9510-1936e6761d8b"), 1, new Guid("cc37720a-7e89-463a-9510-1936e6761d83"), 0, new Guid("cc37720a-7e89-463a-9510-1936e6761d84"), new Guid("cc37720a-7e89-463a-9510-1936e6761d75") },
                    { new Guid("2eaaba04-80ff-43a6-a746-a74a91c5c0e9"), new DateTime(2023, 9, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "Description", 4000000.0, 5000000.0, new Guid("cc37720a-7e89-463a-9510-1936e6761d8b"), 1, new Guid("cc37720a-7e89-463a-9510-1936e6761d83"), 0, new Guid("cc37720a-7e89-463a-9510-1936e6761d94"), new Guid("cc37720a-7e89-463a-9510-1936e6761d75") },
                    { new Guid("2eaaba04-80ff-43a6-a746-a74a91c5c1e0"), new DateTime(2023, 9, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "Description", 4000000.0, 5000000.0, new Guid("cc37720a-7e89-463a-9510-1936e6761d8b"), 1, new Guid("cc37720a-7e89-463a-9510-1936e6761d73"), 0, new Guid("cc37720a-7e89-463a-9510-1936e6761d04"), new Guid("cc37720a-7e89-463a-9510-1936e6761d75") },
                    { new Guid("2eaaba04-80ff-43a6-a746-a74a91c5c1e1"), new DateTime(2023, 9, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "Description", 4000000.0, 5000000.0, new Guid("cc37720a-7e89-463a-9510-1936e6761d8b"), 1, new Guid("cc37720a-7e89-463a-9510-1936e6761d73"), 0, new Guid("cc37720a-7e89-463a-9510-1936e6761d14"), new Guid("cc37720a-7e89-463a-9510-1936e6761d75") },
                    { new Guid("2eaaba04-80ff-43a6-a746-a74a91c5c1e2"), new DateTime(2023, 9, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "Description", 4000000.0, 5000000.0, new Guid("cc37720a-7e89-463a-9510-1936e6761d8b"), 1, new Guid("cc37720a-7e89-463a-9510-1936e6761d73"), 0, new Guid("cc37720a-7e89-463a-9510-1936e6761d24"), new Guid("cc37720a-7e89-463a-9510-1936e6761d75") },
                    { new Guid("2eaaba04-80ff-43a6-a746-a74a91c5c1e3"), new DateTime(2023, 9, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "Description", 4000000.0, 5000000.0, new Guid("cc37720a-7e89-463a-9510-1936e6761d8b"), 1, new Guid("cc37720a-7e89-463a-9510-1936e6761d73"), 0, new Guid("cc37720a-7e89-463a-9510-1936e6761d34"), new Guid("cc37720a-7e89-463a-9510-1936e6761d75") },
                    { new Guid("2eaaba04-80ff-43a6-a746-a74a91c5c1e4"), new DateTime(2023, 9, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "Description", 4000000.0, 5000000.0, new Guid("cc37720a-7e89-463a-9510-1936e6761d8b"), 1, new Guid("cc37720a-7e89-463a-9510-1936e6761d73"), 0, new Guid("cc37720a-7e89-463a-9510-1936e6761d44"), new Guid("cc37720a-7e89-463a-9510-1936e6761d75") },
                    { new Guid("2eaaba04-80ff-43a6-a746-a74a91c5c1e5"), new DateTime(2023, 9, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "Description", 4000000.0, 5000000.0, new Guid("cc37720a-7e89-463a-9510-1936e6761d8b"), 1, new Guid("cc37720a-7e89-463a-9510-1936e6761d73"), 0, new Guid("cc37720a-7e89-463a-9510-1936e6761d54"), new Guid("cc37720a-7e89-463a-9510-1936e6761d75") },
                    { new Guid("2eaaba04-80ff-43a6-a746-a74a91c5c1e6"), new DateTime(2023, 9, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "Description", 4000000.0, 5000000.0, new Guid("cc37720a-7e89-463a-9510-1936e6761d8b"), 1, new Guid("cc37720a-7e89-463a-9510-1936e6761d73"), 0, new Guid("cc37720a-7e89-463a-9510-1936e6761d64"), new Guid("cc37720a-7e89-463a-9510-1936e6761d75") },
                    { new Guid("2eaaba04-80ff-43a6-a746-a74a91c5c1e7"), new DateTime(2023, 9, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "Description", 4000000.0, 5000000.0, new Guid("cc37720a-7e89-463a-9510-1936e6761d8b"), 1, new Guid("cc37720a-7e89-463a-9510-1936e6761d73"), 0, new Guid("cc37720a-7e89-463a-9510-1936e6761d74"), new Guid("cc37720a-7e89-463a-9510-1936e6761d75") },
                    { new Guid("2eaaba04-80ff-43a6-a746-a74a91c5c1e8"), new DateTime(2023, 9, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "Description", 4000000.0, 5000000.0, new Guid("cc37720a-7e89-463a-9510-1936e6761d8b"), 1, new Guid("cc37720a-7e89-463a-9510-1936e6761d73"), 0, new Guid("cc37720a-7e89-463a-9510-1936e6761d84"), new Guid("cc37720a-7e89-463a-9510-1936e6761d75") },
                    { new Guid("2eaaba04-80ff-43a6-a746-a74a91c5c1e9"), new DateTime(2023, 9, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "Description", 4000000.0, 5000000.0, new Guid("cc37720a-7e89-463a-9510-1936e6761d8b"), 1, new Guid("cc37720a-7e89-463a-9510-1936e6761d73"), 0, new Guid("cc37720a-7e89-463a-9510-1936e6761d94"), new Guid("cc37720a-7e89-463a-9510-1936e6761d75") },
                    { new Guid("2eaaba04-80ff-43a6-a746-a74a91c5c2e0"), new DateTime(2023, 9, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "Description", 4000000.0, 5000000.0, new Guid("cc37720a-7e89-463a-9510-1936e6761d8b"), 1, new Guid("cc37720a-7e89-463a-9510-1936e6761d63"), 0, new Guid("cc37720a-7e89-463a-9510-1936e6761d04"), new Guid("cc37720a-7e89-463a-9510-1936e6761d75") },
                    { new Guid("2eaaba04-80ff-43a6-a746-a74a91c5c2e1"), new DateTime(2023, 9, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "Description", 4000000.0, 5000000.0, new Guid("cc37720a-7e89-463a-9510-1936e6761d8b"), 1, new Guid("cc37720a-7e89-463a-9510-1936e6761d63"), 0, new Guid("cc37720a-7e89-463a-9510-1936e6761d14"), new Guid("cc37720a-7e89-463a-9510-1936e6761d75") },
                    { new Guid("2eaaba04-80ff-43a6-a746-a74a91c5c2e2"), new DateTime(2023, 9, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "Description", 4000000.0, 5000000.0, new Guid("cc37720a-7e89-463a-9510-1936e6761d8b"), 1, new Guid("cc37720a-7e89-463a-9510-1936e6761d63"), 0, new Guid("cc37720a-7e89-463a-9510-1936e6761d24"), new Guid("cc37720a-7e89-463a-9510-1936e6761d75") },
                    { new Guid("2eaaba04-80ff-43a6-a746-a74a91c5c2e3"), new DateTime(2023, 9, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "Description", 4000000.0, 5000000.0, new Guid("cc37720a-7e89-463a-9510-1936e6761d8b"), 1, new Guid("cc37720a-7e89-463a-9510-1936e6761d63"), 0, new Guid("cc37720a-7e89-463a-9510-1936e6761d34"), new Guid("cc37720a-7e89-463a-9510-1936e6761d75") },
                    { new Guid("2eaaba04-80ff-43a6-a746-a74a91c5c2e4"), new DateTime(2023, 9, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "Description", 4000000.0, 5000000.0, new Guid("cc37720a-7e89-463a-9510-1936e6761d8b"), 1, new Guid("cc37720a-7e89-463a-9510-1936e6761d63"), 0, new Guid("cc37720a-7e89-463a-9510-1936e6761d44"), new Guid("cc37720a-7e89-463a-9510-1936e6761d75") },
                    { new Guid("2eaaba04-80ff-43a6-a746-a74a91c5c2e5"), new DateTime(2023, 9, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "Description", 4000000.0, 5000000.0, new Guid("cc37720a-7e89-463a-9510-1936e6761d8b"), 1, new Guid("cc37720a-7e89-463a-9510-1936e6761d63"), 0, new Guid("cc37720a-7e89-463a-9510-1936e6761d54"), new Guid("cc37720a-7e89-463a-9510-1936e6761d75") },
                    { new Guid("2eaaba04-80ff-43a6-a746-a74a91c5c2e6"), new DateTime(2023, 9, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "Description", 4000000.0, 5000000.0, new Guid("cc37720a-7e89-463a-9510-1936e6761d8b"), 1, new Guid("cc37720a-7e89-463a-9510-1936e6761d63"), 0, new Guid("cc37720a-7e89-463a-9510-1936e6761d64"), new Guid("cc37720a-7e89-463a-9510-1936e6761d75") },
                    { new Guid("2eaaba04-80ff-43a6-a746-a74a91c5c2e7"), new DateTime(2023, 9, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "Description", 4000000.0, 5000000.0, new Guid("cc37720a-7e89-463a-9510-1936e6761d8b"), 1, new Guid("cc37720a-7e89-463a-9510-1936e6761d63"), 0, new Guid("cc37720a-7e89-463a-9510-1936e6761d74"), new Guid("cc37720a-7e89-463a-9510-1936e6761d75") },
                    { new Guid("2eaaba04-80ff-43a6-a746-a74a91c5c2e8"), new DateTime(2023, 9, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "Description", 4000000.0, 5000000.0, new Guid("cc37720a-7e89-463a-9510-1936e6761d8b"), 1, new Guid("cc37720a-7e89-463a-9510-1936e6761d63"), 0, new Guid("cc37720a-7e89-463a-9510-1936e6761d84"), new Guid("cc37720a-7e89-463a-9510-1936e6761d75") },
                    { new Guid("2eaaba04-80ff-43a6-a746-a74a91c5c2e9"), new DateTime(2023, 9, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "Description", 4000000.0, 5000000.0, new Guid("cc37720a-7e89-463a-9510-1936e6761d8b"), 1, new Guid("cc37720a-7e89-463a-9510-1936e6761d63"), 0, new Guid("cc37720a-7e89-463a-9510-1936e6761d94"), new Guid("cc37720a-7e89-463a-9510-1936e6761d75") },
                    { new Guid("2eaaba04-80ff-43a6-a746-a74a91c5c3e0"), new DateTime(2023, 9, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "Description", 4000000.0, 5000000.0, new Guid("cc37720a-7e89-463a-9510-1936e6761d8b"), 1, new Guid("cc37720a-7e89-463a-9510-1936e6761d53"), 0, new Guid("cc37720a-7e89-463a-9510-1936e6761d04"), new Guid("cc37720a-7e89-463a-9510-1936e6761d75") },
                    { new Guid("2eaaba04-80ff-43a6-a746-a74a91c5c3e1"), new DateTime(2023, 9, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "Description", 4000000.0, 5000000.0, new Guid("cc37720a-7e89-463a-9510-1936e6761d8b"), 1, new Guid("cc37720a-7e89-463a-9510-1936e6761d53"), 0, new Guid("cc37720a-7e89-463a-9510-1936e6761d14"), new Guid("cc37720a-7e89-463a-9510-1936e6761d75") },
                    { new Guid("2eaaba04-80ff-43a6-a746-a74a91c5c3e2"), new DateTime(2023, 9, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "Description", 4000000.0, 5000000.0, new Guid("cc37720a-7e89-463a-9510-1936e6761d8b"), 1, new Guid("cc37720a-7e89-463a-9510-1936e6761d53"), 0, new Guid("cc37720a-7e89-463a-9510-1936e6761d24"), new Guid("cc37720a-7e89-463a-9510-1936e6761d75") },
                    { new Guid("2eaaba04-80ff-43a6-a746-a74a91c5c3e3"), new DateTime(2023, 9, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "Description", 4000000.0, 5000000.0, new Guid("cc37720a-7e89-463a-9510-1936e6761d8b"), 1, new Guid("cc37720a-7e89-463a-9510-1936e6761d53"), 0, new Guid("cc37720a-7e89-463a-9510-1936e6761d34"), new Guid("cc37720a-7e89-463a-9510-1936e6761d75") },
                    { new Guid("2eaaba04-80ff-43a6-a746-a74a91c5c3e4"), new DateTime(2023, 9, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "Description", 4000000.0, 5000000.0, new Guid("cc37720a-7e89-463a-9510-1936e6761d8b"), 1, new Guid("cc37720a-7e89-463a-9510-1936e6761d53"), 0, new Guid("cc37720a-7e89-463a-9510-1936e6761d44"), new Guid("cc37720a-7e89-463a-9510-1936e6761d75") },
                    { new Guid("2eaaba04-80ff-43a6-a746-a74a91c5c3e5"), new DateTime(2023, 9, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "Description", 4000000.0, 5000000.0, new Guid("cc37720a-7e89-463a-9510-1936e6761d8b"), 1, new Guid("cc37720a-7e89-463a-9510-1936e6761d53"), 0, new Guid("cc37720a-7e89-463a-9510-1936e6761d54"), new Guid("cc37720a-7e89-463a-9510-1936e6761d75") },
                    { new Guid("2eaaba04-80ff-43a6-a746-a74a91c5c3e6"), new DateTime(2023, 9, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "Description", 4000000.0, 5000000.0, new Guid("cc37720a-7e89-463a-9510-1936e6761d8b"), 1, new Guid("cc37720a-7e89-463a-9510-1936e6761d53"), 0, new Guid("cc37720a-7e89-463a-9510-1936e6761d64"), new Guid("cc37720a-7e89-463a-9510-1936e6761d75") },
                    { new Guid("2eaaba04-80ff-43a6-a746-a74a91c5c3e7"), new DateTime(2023, 9, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "Description", 4000000.0, 5000000.0, new Guid("cc37720a-7e89-463a-9510-1936e6761d8b"), 1, new Guid("cc37720a-7e89-463a-9510-1936e6761d53"), 0, new Guid("cc37720a-7e89-463a-9510-1936e6761d74"), new Guid("cc37720a-7e89-463a-9510-1936e6761d75") },
                    { new Guid("2eaaba04-80ff-43a6-a746-a74a91c5c3e8"), new DateTime(2023, 9, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "Description", 4000000.0, 5000000.0, new Guid("cc37720a-7e89-463a-9510-1936e6761d8b"), 1, new Guid("cc37720a-7e89-463a-9510-1936e6761d53"), 0, new Guid("cc37720a-7e89-463a-9510-1936e6761d84"), new Guid("cc37720a-7e89-463a-9510-1936e6761d75") },
                    { new Guid("2eaaba04-80ff-43a6-a746-a74a91c5c3e9"), new DateTime(2023, 9, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "Description", 4000000.0, 5000000.0, new Guid("cc37720a-7e89-463a-9510-1936e6761d8b"), 1, new Guid("cc37720a-7e89-463a-9510-1936e6761d53"), 0, new Guid("cc37720a-7e89-463a-9510-1936e6761d94"), new Guid("cc37720a-7e89-463a-9510-1936e6761d75") },
                    { new Guid("2eaaba04-80ff-43a6-a746-a74a91c6c0e0"), new DateTime(2023, 9, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "Description", 4000000.0, 5000000.0, new Guid("cc37720a-7e89-463a-9510-1936e6761d8b"), 1, new Guid("cc37720a-7e89-463a-9510-1936e6761d83"), 0, new Guid("cc37720a-7e89-463a-9510-1936e6761d04"), new Guid("cc37720a-7e89-463a-9510-1936e6761d65") },
                    { new Guid("2eaaba04-80ff-43a6-a746-a74a91c6c0e1"), new DateTime(2023, 9, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "Description", 4000000.0, 5000000.0, new Guid("cc37720a-7e89-463a-9510-1936e6761d8b"), 1, new Guid("cc37720a-7e89-463a-9510-1936e6761d83"), 0, new Guid("cc37720a-7e89-463a-9510-1936e6761d14"), new Guid("cc37720a-7e89-463a-9510-1936e6761d65") },
                    { new Guid("2eaaba04-80ff-43a6-a746-a74a91c6c0e2"), new DateTime(2023, 9, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "Description", 4000000.0, 5000000.0, new Guid("cc37720a-7e89-463a-9510-1936e6761d8b"), 1, new Guid("cc37720a-7e89-463a-9510-1936e6761d83"), 0, new Guid("cc37720a-7e89-463a-9510-1936e6761d24"), new Guid("cc37720a-7e89-463a-9510-1936e6761d65") },
                    { new Guid("2eaaba04-80ff-43a6-a746-a74a91c6c0e3"), new DateTime(2023, 9, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "Description", 4000000.0, 5000000.0, new Guid("cc37720a-7e89-463a-9510-1936e6761d8b"), 1, new Guid("cc37720a-7e89-463a-9510-1936e6761d83"), 0, new Guid("cc37720a-7e89-463a-9510-1936e6761d34"), new Guid("cc37720a-7e89-463a-9510-1936e6761d65") },
                    { new Guid("2eaaba04-80ff-43a6-a746-a74a91c6c0e4"), new DateTime(2023, 9, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "Description", 4000000.0, 5000000.0, new Guid("cc37720a-7e89-463a-9510-1936e6761d8b"), 1, new Guid("cc37720a-7e89-463a-9510-1936e6761d83"), 0, new Guid("cc37720a-7e89-463a-9510-1936e6761d44"), new Guid("cc37720a-7e89-463a-9510-1936e6761d65") },
                    { new Guid("2eaaba04-80ff-43a6-a746-a74a91c6c0e5"), new DateTime(2023, 9, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "Description", 4000000.0, 5000000.0, new Guid("cc37720a-7e89-463a-9510-1936e6761d8b"), 1, new Guid("cc37720a-7e89-463a-9510-1936e6761d83"), 0, new Guid("cc37720a-7e89-463a-9510-1936e6761d54"), new Guid("cc37720a-7e89-463a-9510-1936e6761d65") },
                    { new Guid("2eaaba04-80ff-43a6-a746-a74a91c6c0e6"), new DateTime(2023, 9, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "Description", 4000000.0, 5000000.0, new Guid("cc37720a-7e89-463a-9510-1936e6761d8b"), 1, new Guid("cc37720a-7e89-463a-9510-1936e6761d83"), 0, new Guid("cc37720a-7e89-463a-9510-1936e6761d64"), new Guid("cc37720a-7e89-463a-9510-1936e6761d65") },
                    { new Guid("2eaaba04-80ff-43a6-a746-a74a91c6c0e7"), new DateTime(2023, 9, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "Description", 4000000.0, 5000000.0, new Guid("cc37720a-7e89-463a-9510-1936e6761d8b"), 1, new Guid("cc37720a-7e89-463a-9510-1936e6761d83"), 0, new Guid("cc37720a-7e89-463a-9510-1936e6761d74"), new Guid("cc37720a-7e89-463a-9510-1936e6761d65") }
                });

            migrationBuilder.InsertData(
                table: "ProductDetails",
                columns: new[] { "Id", "CreateDate", "Description", "ImportPrice", "Price", "ProductID", "Quantity", "ShaftId", "Status", "TipId", "WeightId" },
                values: new object[,]
                {
                    { new Guid("2eaaba04-80ff-43a6-a746-a74a91c6c0e8"), new DateTime(2023, 9, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "Description", 4000000.0, 5000000.0, new Guid("cc37720a-7e89-463a-9510-1936e6761d8b"), 1, new Guid("cc37720a-7e89-463a-9510-1936e6761d83"), 0, new Guid("cc37720a-7e89-463a-9510-1936e6761d84"), new Guid("cc37720a-7e89-463a-9510-1936e6761d65") },
                    { new Guid("2eaaba04-80ff-43a6-a746-a74a91c6c0e9"), new DateTime(2023, 9, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "Description", 4000000.0, 5000000.0, new Guid("cc37720a-7e89-463a-9510-1936e6761d8b"), 1, new Guid("cc37720a-7e89-463a-9510-1936e6761d83"), 0, new Guid("cc37720a-7e89-463a-9510-1936e6761d94"), new Guid("cc37720a-7e89-463a-9510-1936e6761d65") },
                    { new Guid("2eaaba04-80ff-43a6-a746-a74a91c6c1e0"), new DateTime(2023, 9, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "Description", 4000000.0, 5000000.0, new Guid("cc37720a-7e89-463a-9510-1936e6761d8b"), 1, new Guid("cc37720a-7e89-463a-9510-1936e6761d73"), 0, new Guid("cc37720a-7e89-463a-9510-1936e6761d04"), new Guid("cc37720a-7e89-463a-9510-1936e6761d65") },
                    { new Guid("2eaaba04-80ff-43a6-a746-a74a91c6c1e1"), new DateTime(2023, 9, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "Description", 4000000.0, 5000000.0, new Guid("cc37720a-7e89-463a-9510-1936e6761d8b"), 1, new Guid("cc37720a-7e89-463a-9510-1936e6761d73"), 0, new Guid("cc37720a-7e89-463a-9510-1936e6761d14"), new Guid("cc37720a-7e89-463a-9510-1936e6761d65") },
                    { new Guid("2eaaba04-80ff-43a6-a746-a74a91c6c1e2"), new DateTime(2023, 9, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "Description", 4000000.0, 5000000.0, new Guid("cc37720a-7e89-463a-9510-1936e6761d8b"), 1, new Guid("cc37720a-7e89-463a-9510-1936e6761d73"), 0, new Guid("cc37720a-7e89-463a-9510-1936e6761d24"), new Guid("cc37720a-7e89-463a-9510-1936e6761d65") },
                    { new Guid("2eaaba04-80ff-43a6-a746-a74a91c6c1e3"), new DateTime(2023, 9, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "Description", 4000000.0, 5000000.0, new Guid("cc37720a-7e89-463a-9510-1936e6761d8b"), 1, new Guid("cc37720a-7e89-463a-9510-1936e6761d73"), 0, new Guid("cc37720a-7e89-463a-9510-1936e6761d34"), new Guid("cc37720a-7e89-463a-9510-1936e6761d65") },
                    { new Guid("2eaaba04-80ff-43a6-a746-a74a91c6c1e4"), new DateTime(2023, 9, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "Description", 4000000.0, 5000000.0, new Guid("cc37720a-7e89-463a-9510-1936e6761d8b"), 1, new Guid("cc37720a-7e89-463a-9510-1936e6761d73"), 0, new Guid("cc37720a-7e89-463a-9510-1936e6761d44"), new Guid("cc37720a-7e89-463a-9510-1936e6761d65") },
                    { new Guid("2eaaba04-80ff-43a6-a746-a74a91c6c1e5"), new DateTime(2023, 9, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "Description", 4000000.0, 5000000.0, new Guid("cc37720a-7e89-463a-9510-1936e6761d8b"), 1, new Guid("cc37720a-7e89-463a-9510-1936e6761d73"), 0, new Guid("cc37720a-7e89-463a-9510-1936e6761d54"), new Guid("cc37720a-7e89-463a-9510-1936e6761d65") },
                    { new Guid("2eaaba04-80ff-43a6-a746-a74a91c6c1e6"), new DateTime(2023, 9, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "Description", 4000000.0, 5000000.0, new Guid("cc37720a-7e89-463a-9510-1936e6761d8b"), 1, new Guid("cc37720a-7e89-463a-9510-1936e6761d73"), 0, new Guid("cc37720a-7e89-463a-9510-1936e6761d64"), new Guid("cc37720a-7e89-463a-9510-1936e6761d65") },
                    { new Guid("2eaaba04-80ff-43a6-a746-a74a91c6c1e7"), new DateTime(2023, 9, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "Description", 4000000.0, 5000000.0, new Guid("cc37720a-7e89-463a-9510-1936e6761d8b"), 1, new Guid("cc37720a-7e89-463a-9510-1936e6761d73"), 0, new Guid("cc37720a-7e89-463a-9510-1936e6761d74"), new Guid("cc37720a-7e89-463a-9510-1936e6761d65") },
                    { new Guid("2eaaba04-80ff-43a6-a746-a74a91c6c1e8"), new DateTime(2023, 9, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "Description", 4000000.0, 5000000.0, new Guid("cc37720a-7e89-463a-9510-1936e6761d8b"), 1, new Guid("cc37720a-7e89-463a-9510-1936e6761d73"), 0, new Guid("cc37720a-7e89-463a-9510-1936e6761d84"), new Guid("cc37720a-7e89-463a-9510-1936e6761d65") },
                    { new Guid("2eaaba04-80ff-43a6-a746-a74a91c6c1e9"), new DateTime(2023, 9, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "Description", 4000000.0, 5000000.0, new Guid("cc37720a-7e89-463a-9510-1936e6761d8b"), 1, new Guid("cc37720a-7e89-463a-9510-1936e6761d73"), 0, new Guid("cc37720a-7e89-463a-9510-1936e6761d94"), new Guid("cc37720a-7e89-463a-9510-1936e6761d65") },
                    { new Guid("2eaaba04-80ff-43a6-a746-a74a91c6c2e0"), new DateTime(2023, 9, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "Description", 4000000.0, 5000000.0, new Guid("cc37720a-7e89-463a-9510-1936e6761d8b"), 1, new Guid("cc37720a-7e89-463a-9510-1936e6761d63"), 0, new Guid("cc37720a-7e89-463a-9510-1936e6761d04"), new Guid("cc37720a-7e89-463a-9510-1936e6761d65") },
                    { new Guid("2eaaba04-80ff-43a6-a746-a74a91c6c2e1"), new DateTime(2023, 9, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "Description", 4000000.0, 5000000.0, new Guid("cc37720a-7e89-463a-9510-1936e6761d8b"), 1, new Guid("cc37720a-7e89-463a-9510-1936e6761d63"), 0, new Guid("cc37720a-7e89-463a-9510-1936e6761d14"), new Guid("cc37720a-7e89-463a-9510-1936e6761d65") },
                    { new Guid("2eaaba04-80ff-43a6-a746-a74a91c6c2e2"), new DateTime(2023, 9, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "Description", 4000000.0, 5000000.0, new Guid("cc37720a-7e89-463a-9510-1936e6761d8b"), 1, new Guid("cc37720a-7e89-463a-9510-1936e6761d63"), 0, new Guid("cc37720a-7e89-463a-9510-1936e6761d24"), new Guid("cc37720a-7e89-463a-9510-1936e6761d65") },
                    { new Guid("2eaaba04-80ff-43a6-a746-a74a91c6c2e3"), new DateTime(2023, 9, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "Description", 4000000.0, 5000000.0, new Guid("cc37720a-7e89-463a-9510-1936e6761d8b"), 1, new Guid("cc37720a-7e89-463a-9510-1936e6761d63"), 0, new Guid("cc37720a-7e89-463a-9510-1936e6761d34"), new Guid("cc37720a-7e89-463a-9510-1936e6761d65") },
                    { new Guid("2eaaba04-80ff-43a6-a746-a74a91c6c2e4"), new DateTime(2023, 9, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "Description", 4000000.0, 5000000.0, new Guid("cc37720a-7e89-463a-9510-1936e6761d8b"), 1, new Guid("cc37720a-7e89-463a-9510-1936e6761d63"), 0, new Guid("cc37720a-7e89-463a-9510-1936e6761d44"), new Guid("cc37720a-7e89-463a-9510-1936e6761d65") },
                    { new Guid("2eaaba04-80ff-43a6-a746-a74a91c6c2e5"), new DateTime(2023, 9, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "Description", 4000000.0, 5000000.0, new Guid("cc37720a-7e89-463a-9510-1936e6761d8b"), 1, new Guid("cc37720a-7e89-463a-9510-1936e6761d63"), 0, new Guid("cc37720a-7e89-463a-9510-1936e6761d54"), new Guid("cc37720a-7e89-463a-9510-1936e6761d65") },
                    { new Guid("2eaaba04-80ff-43a6-a746-a74a91c6c2e6"), new DateTime(2023, 9, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "Description", 4000000.0, 5000000.0, new Guid("cc37720a-7e89-463a-9510-1936e6761d8b"), 1, new Guid("cc37720a-7e89-463a-9510-1936e6761d63"), 0, new Guid("cc37720a-7e89-463a-9510-1936e6761d64"), new Guid("cc37720a-7e89-463a-9510-1936e6761d65") },
                    { new Guid("2eaaba04-80ff-43a6-a746-a74a91c6c2e7"), new DateTime(2023, 9, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "Description", 4000000.0, 5000000.0, new Guid("cc37720a-7e89-463a-9510-1936e6761d8b"), 1, new Guid("cc37720a-7e89-463a-9510-1936e6761d63"), 0, new Guid("cc37720a-7e89-463a-9510-1936e6761d74"), new Guid("cc37720a-7e89-463a-9510-1936e6761d65") },
                    { new Guid("2eaaba04-80ff-43a6-a746-a74a91c6c2e8"), new DateTime(2023, 9, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "Description", 4000000.0, 5000000.0, new Guid("cc37720a-7e89-463a-9510-1936e6761d8b"), 1, new Guid("cc37720a-7e89-463a-9510-1936e6761d63"), 0, new Guid("cc37720a-7e89-463a-9510-1936e6761d84"), new Guid("cc37720a-7e89-463a-9510-1936e6761d65") },
                    { new Guid("2eaaba04-80ff-43a6-a746-a74a91c6c2e9"), new DateTime(2023, 9, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "Description", 4000000.0, 5000000.0, new Guid("cc37720a-7e89-463a-9510-1936e6761d8b"), 1, new Guid("cc37720a-7e89-463a-9510-1936e6761d63"), 0, new Guid("cc37720a-7e89-463a-9510-1936e6761d94"), new Guid("cc37720a-7e89-463a-9510-1936e6761d65") },
                    { new Guid("2eaaba04-80ff-43a6-a746-a74a91c6c3e0"), new DateTime(2023, 9, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "Description", 4000000.0, 5000000.0, new Guid("cc37720a-7e89-463a-9510-1936e6761d8b"), 1, new Guid("cc37720a-7e89-463a-9510-1936e6761d53"), 0, new Guid("cc37720a-7e89-463a-9510-1936e6761d04"), new Guid("cc37720a-7e89-463a-9510-1936e6761d65") },
                    { new Guid("2eaaba04-80ff-43a6-a746-a74a91c6c3e1"), new DateTime(2023, 9, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "Description", 4000000.0, 5000000.0, new Guid("cc37720a-7e89-463a-9510-1936e6761d8b"), 1, new Guid("cc37720a-7e89-463a-9510-1936e6761d53"), 0, new Guid("cc37720a-7e89-463a-9510-1936e6761d14"), new Guid("cc37720a-7e89-463a-9510-1936e6761d65") },
                    { new Guid("2eaaba04-80ff-43a6-a746-a74a91c6c3e2"), new DateTime(2023, 9, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "Description", 4000000.0, 5000000.0, new Guid("cc37720a-7e89-463a-9510-1936e6761d8b"), 1, new Guid("cc37720a-7e89-463a-9510-1936e6761d53"), 0, new Guid("cc37720a-7e89-463a-9510-1936e6761d24"), new Guid("cc37720a-7e89-463a-9510-1936e6761d65") },
                    { new Guid("2eaaba04-80ff-43a6-a746-a74a91c6c3e3"), new DateTime(2023, 9, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "Description", 4000000.0, 5000000.0, new Guid("cc37720a-7e89-463a-9510-1936e6761d8b"), 1, new Guid("cc37720a-7e89-463a-9510-1936e6761d53"), 0, new Guid("cc37720a-7e89-463a-9510-1936e6761d34"), new Guid("cc37720a-7e89-463a-9510-1936e6761d65") },
                    { new Guid("2eaaba04-80ff-43a6-a746-a74a91c6c3e4"), new DateTime(2023, 9, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "Description", 4000000.0, 5000000.0, new Guid("cc37720a-7e89-463a-9510-1936e6761d8b"), 1, new Guid("cc37720a-7e89-463a-9510-1936e6761d53"), 0, new Guid("cc37720a-7e89-463a-9510-1936e6761d44"), new Guid("cc37720a-7e89-463a-9510-1936e6761d65") },
                    { new Guid("2eaaba04-80ff-43a6-a746-a74a91c6c3e5"), new DateTime(2023, 9, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "Description", 4000000.0, 5000000.0, new Guid("cc37720a-7e89-463a-9510-1936e6761d8b"), 1, new Guid("cc37720a-7e89-463a-9510-1936e6761d53"), 0, new Guid("cc37720a-7e89-463a-9510-1936e6761d54"), new Guid("cc37720a-7e89-463a-9510-1936e6761d65") },
                    { new Guid("2eaaba04-80ff-43a6-a746-a74a91c6c3e6"), new DateTime(2023, 9, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "Description", 4000000.0, 5000000.0, new Guid("cc37720a-7e89-463a-9510-1936e6761d8b"), 1, new Guid("cc37720a-7e89-463a-9510-1936e6761d53"), 0, new Guid("cc37720a-7e89-463a-9510-1936e6761d64"), new Guid("cc37720a-7e89-463a-9510-1936e6761d65") },
                    { new Guid("2eaaba04-80ff-43a6-a746-a74a91c6c3e7"), new DateTime(2023, 9, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "Description", 4000000.0, 5000000.0, new Guid("cc37720a-7e89-463a-9510-1936e6761d8b"), 1, new Guid("cc37720a-7e89-463a-9510-1936e6761d53"), 0, new Guid("cc37720a-7e89-463a-9510-1936e6761d74"), new Guid("cc37720a-7e89-463a-9510-1936e6761d65") },
                    { new Guid("2eaaba04-80ff-43a6-a746-a74a91c6c3e8"), new DateTime(2023, 9, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "Description", 4000000.0, 5000000.0, new Guid("cc37720a-7e89-463a-9510-1936e6761d8b"), 1, new Guid("cc37720a-7e89-463a-9510-1936e6761d53"), 0, new Guid("cc37720a-7e89-463a-9510-1936e6761d84"), new Guid("cc37720a-7e89-463a-9510-1936e6761d65") },
                    { new Guid("2eaaba04-80ff-43a6-a746-a74a91c6c3e9"), new DateTime(2023, 9, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "Description", 4000000.0, 5000000.0, new Guid("cc37720a-7e89-463a-9510-1936e6761d8b"), 1, new Guid("cc37720a-7e89-463a-9510-1936e6761d53"), 0, new Guid("cc37720a-7e89-463a-9510-1936e6761d94"), new Guid("cc37720a-7e89-463a-9510-1936e6761d65") },
                    { new Guid("2eaaba04-80ff-43a6-a746-a74a91c7c0e0"), new DateTime(2023, 9, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "Description", 4000000.0, 5000000.0, new Guid("cc37720a-7e89-463a-9510-1936e6761d8b"), 1, new Guid("cc37720a-7e89-463a-9510-1936e6761d83"), 0, new Guid("cc37720a-7e89-463a-9510-1936e6761d04"), new Guid("cc37720a-7e89-463a-9510-1936e6761d55") },
                    { new Guid("2eaaba04-80ff-43a6-a746-a74a91c7c0e1"), new DateTime(2023, 9, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "Description", 4000000.0, 5000000.0, new Guid("cc37720a-7e89-463a-9510-1936e6761d8b"), 1, new Guid("cc37720a-7e89-463a-9510-1936e6761d83"), 0, new Guid("cc37720a-7e89-463a-9510-1936e6761d14"), new Guid("cc37720a-7e89-463a-9510-1936e6761d55") },
                    { new Guid("2eaaba04-80ff-43a6-a746-a74a91c7c0e2"), new DateTime(2023, 9, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "Description", 4000000.0, 5000000.0, new Guid("cc37720a-7e89-463a-9510-1936e6761d8b"), 1, new Guid("cc37720a-7e89-463a-9510-1936e6761d83"), 0, new Guid("cc37720a-7e89-463a-9510-1936e6761d24"), new Guid("cc37720a-7e89-463a-9510-1936e6761d55") },
                    { new Guid("2eaaba04-80ff-43a6-a746-a74a91c7c0e3"), new DateTime(2023, 9, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "Description", 4000000.0, 5000000.0, new Guid("cc37720a-7e89-463a-9510-1936e6761d8b"), 1, new Guid("cc37720a-7e89-463a-9510-1936e6761d83"), 0, new Guid("cc37720a-7e89-463a-9510-1936e6761d34"), new Guid("cc37720a-7e89-463a-9510-1936e6761d55") },
                    { new Guid("2eaaba04-80ff-43a6-a746-a74a91c7c0e4"), new DateTime(2023, 9, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "Description", 4000000.0, 5000000.0, new Guid("cc37720a-7e89-463a-9510-1936e6761d8b"), 1, new Guid("cc37720a-7e89-463a-9510-1936e6761d83"), 0, new Guid("cc37720a-7e89-463a-9510-1936e6761d44"), new Guid("cc37720a-7e89-463a-9510-1936e6761d55") },
                    { new Guid("2eaaba04-80ff-43a6-a746-a74a91c7c0e5"), new DateTime(2023, 9, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "Description", 4000000.0, 5000000.0, new Guid("cc37720a-7e89-463a-9510-1936e6761d8b"), 1, new Guid("cc37720a-7e89-463a-9510-1936e6761d83"), 0, new Guid("cc37720a-7e89-463a-9510-1936e6761d54"), new Guid("cc37720a-7e89-463a-9510-1936e6761d55") },
                    { new Guid("2eaaba04-80ff-43a6-a746-a74a91c7c0e6"), new DateTime(2023, 9, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "Description", 4000000.0, 5000000.0, new Guid("cc37720a-7e89-463a-9510-1936e6761d8b"), 1, new Guid("cc37720a-7e89-463a-9510-1936e6761d83"), 0, new Guid("cc37720a-7e89-463a-9510-1936e6761d64"), new Guid("cc37720a-7e89-463a-9510-1936e6761d55") },
                    { new Guid("2eaaba04-80ff-43a6-a746-a74a91c7c0e7"), new DateTime(2023, 9, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "Description", 4000000.0, 5000000.0, new Guid("cc37720a-7e89-463a-9510-1936e6761d8b"), 1, new Guid("cc37720a-7e89-463a-9510-1936e6761d83"), 0, new Guid("cc37720a-7e89-463a-9510-1936e6761d74"), new Guid("cc37720a-7e89-463a-9510-1936e6761d55") },
                    { new Guid("2eaaba04-80ff-43a6-a746-a74a91c7c0e8"), new DateTime(2023, 9, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "Description", 4000000.0, 5000000.0, new Guid("cc37720a-7e89-463a-9510-1936e6761d8b"), 1, new Guid("cc37720a-7e89-463a-9510-1936e6761d83"), 0, new Guid("cc37720a-7e89-463a-9510-1936e6761d84"), new Guid("cc37720a-7e89-463a-9510-1936e6761d55") },
                    { new Guid("2eaaba04-80ff-43a6-a746-a74a91c7c0e9"), new DateTime(2023, 9, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "Description", 4000000.0, 5000000.0, new Guid("cc37720a-7e89-463a-9510-1936e6761d8b"), 1, new Guid("cc37720a-7e89-463a-9510-1936e6761d83"), 0, new Guid("cc37720a-7e89-463a-9510-1936e6761d94"), new Guid("cc37720a-7e89-463a-9510-1936e6761d55") }
                });

            migrationBuilder.InsertData(
                table: "ProductDetails",
                columns: new[] { "Id", "CreateDate", "Description", "ImportPrice", "Price", "ProductID", "Quantity", "ShaftId", "Status", "TipId", "WeightId" },
                values: new object[,]
                {
                    { new Guid("2eaaba04-80ff-43a6-a746-a74a91c7c1e0"), new DateTime(2023, 9, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "Description", 4000000.0, 5000000.0, new Guid("cc37720a-7e89-463a-9510-1936e6761d8b"), 1, new Guid("cc37720a-7e89-463a-9510-1936e6761d73"), 0, new Guid("cc37720a-7e89-463a-9510-1936e6761d04"), new Guid("cc37720a-7e89-463a-9510-1936e6761d55") },
                    { new Guid("2eaaba04-80ff-43a6-a746-a74a91c7c1e1"), new DateTime(2023, 9, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "Description", 4000000.0, 5000000.0, new Guid("cc37720a-7e89-463a-9510-1936e6761d8b"), 1, new Guid("cc37720a-7e89-463a-9510-1936e6761d73"), 0, new Guid("cc37720a-7e89-463a-9510-1936e6761d14"), new Guid("cc37720a-7e89-463a-9510-1936e6761d55") },
                    { new Guid("2eaaba04-80ff-43a6-a746-a74a91c7c1e2"), new DateTime(2023, 9, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "Description", 4000000.0, 5000000.0, new Guid("cc37720a-7e89-463a-9510-1936e6761d8b"), 1, new Guid("cc37720a-7e89-463a-9510-1936e6761d73"), 0, new Guid("cc37720a-7e89-463a-9510-1936e6761d24"), new Guid("cc37720a-7e89-463a-9510-1936e6761d55") },
                    { new Guid("2eaaba04-80ff-43a6-a746-a74a91c7c1e3"), new DateTime(2023, 9, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "Description", 4000000.0, 5000000.0, new Guid("cc37720a-7e89-463a-9510-1936e6761d8b"), 1, new Guid("cc37720a-7e89-463a-9510-1936e6761d73"), 0, new Guid("cc37720a-7e89-463a-9510-1936e6761d34"), new Guid("cc37720a-7e89-463a-9510-1936e6761d55") },
                    { new Guid("2eaaba04-80ff-43a6-a746-a74a91c7c1e4"), new DateTime(2023, 9, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "Description", 4000000.0, 5000000.0, new Guid("cc37720a-7e89-463a-9510-1936e6761d8b"), 1, new Guid("cc37720a-7e89-463a-9510-1936e6761d73"), 0, new Guid("cc37720a-7e89-463a-9510-1936e6761d44"), new Guid("cc37720a-7e89-463a-9510-1936e6761d55") },
                    { new Guid("2eaaba04-80ff-43a6-a746-a74a91c7c1e5"), new DateTime(2023, 9, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "Description", 4000000.0, 5000000.0, new Guid("cc37720a-7e89-463a-9510-1936e6761d8b"), 1, new Guid("cc37720a-7e89-463a-9510-1936e6761d73"), 0, new Guid("cc37720a-7e89-463a-9510-1936e6761d54"), new Guid("cc37720a-7e89-463a-9510-1936e6761d55") },
                    { new Guid("2eaaba04-80ff-43a6-a746-a74a91c7c1e6"), new DateTime(2023, 9, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "Description", 4000000.0, 5000000.0, new Guid("cc37720a-7e89-463a-9510-1936e6761d8b"), 1, new Guid("cc37720a-7e89-463a-9510-1936e6761d73"), 0, new Guid("cc37720a-7e89-463a-9510-1936e6761d64"), new Guid("cc37720a-7e89-463a-9510-1936e6761d55") },
                    { new Guid("2eaaba04-80ff-43a6-a746-a74a91c7c1e7"), new DateTime(2023, 9, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "Description", 4000000.0, 5000000.0, new Guid("cc37720a-7e89-463a-9510-1936e6761d8b"), 1, new Guid("cc37720a-7e89-463a-9510-1936e6761d73"), 0, new Guid("cc37720a-7e89-463a-9510-1936e6761d74"), new Guid("cc37720a-7e89-463a-9510-1936e6761d55") },
                    { new Guid("2eaaba04-80ff-43a6-a746-a74a91c7c1e8"), new DateTime(2023, 9, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "Description", 4000000.0, 5000000.0, new Guid("cc37720a-7e89-463a-9510-1936e6761d8b"), 1, new Guid("cc37720a-7e89-463a-9510-1936e6761d73"), 0, new Guid("cc37720a-7e89-463a-9510-1936e6761d84"), new Guid("cc37720a-7e89-463a-9510-1936e6761d55") },
                    { new Guid("2eaaba04-80ff-43a6-a746-a74a91c7c1e9"), new DateTime(2023, 9, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "Description", 4000000.0, 5000000.0, new Guid("cc37720a-7e89-463a-9510-1936e6761d8b"), 1, new Guid("cc37720a-7e89-463a-9510-1936e6761d73"), 0, new Guid("cc37720a-7e89-463a-9510-1936e6761d94"), new Guid("cc37720a-7e89-463a-9510-1936e6761d55") },
                    { new Guid("2eaaba04-80ff-43a6-a746-a74a91c7c2e0"), new DateTime(2023, 9, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "Description", 4000000.0, 5000000.0, new Guid("cc37720a-7e89-463a-9510-1936e6761d8b"), 1, new Guid("cc37720a-7e89-463a-9510-1936e6761d63"), 0, new Guid("cc37720a-7e89-463a-9510-1936e6761d04"), new Guid("cc37720a-7e89-463a-9510-1936e6761d55") },
                    { new Guid("2eaaba04-80ff-43a6-a746-a74a91c7c2e1"), new DateTime(2023, 9, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "Description", 4000000.0, 5000000.0, new Guid("cc37720a-7e89-463a-9510-1936e6761d8b"), 1, new Guid("cc37720a-7e89-463a-9510-1936e6761d63"), 0, new Guid("cc37720a-7e89-463a-9510-1936e6761d14"), new Guid("cc37720a-7e89-463a-9510-1936e6761d55") },
                    { new Guid("2eaaba04-80ff-43a6-a746-a74a91c7c2e2"), new DateTime(2023, 9, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "Description", 4000000.0, 5000000.0, new Guid("cc37720a-7e89-463a-9510-1936e6761d8b"), 1, new Guid("cc37720a-7e89-463a-9510-1936e6761d63"), 0, new Guid("cc37720a-7e89-463a-9510-1936e6761d24"), new Guid("cc37720a-7e89-463a-9510-1936e6761d55") },
                    { new Guid("2eaaba04-80ff-43a6-a746-a74a91c7c2e3"), new DateTime(2023, 9, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "Description", 4000000.0, 5000000.0, new Guid("cc37720a-7e89-463a-9510-1936e6761d8b"), 1, new Guid("cc37720a-7e89-463a-9510-1936e6761d63"), 0, new Guid("cc37720a-7e89-463a-9510-1936e6761d34"), new Guid("cc37720a-7e89-463a-9510-1936e6761d55") },
                    { new Guid("2eaaba04-80ff-43a6-a746-a74a91c7c2e4"), new DateTime(2023, 9, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "Description", 4000000.0, 5000000.0, new Guid("cc37720a-7e89-463a-9510-1936e6761d8b"), 1, new Guid("cc37720a-7e89-463a-9510-1936e6761d63"), 0, new Guid("cc37720a-7e89-463a-9510-1936e6761d44"), new Guid("cc37720a-7e89-463a-9510-1936e6761d55") },
                    { new Guid("2eaaba04-80ff-43a6-a746-a74a91c7c2e5"), new DateTime(2023, 9, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "Description", 4000000.0, 5000000.0, new Guid("cc37720a-7e89-463a-9510-1936e6761d8b"), 1, new Guid("cc37720a-7e89-463a-9510-1936e6761d63"), 0, new Guid("cc37720a-7e89-463a-9510-1936e6761d54"), new Guid("cc37720a-7e89-463a-9510-1936e6761d55") },
                    { new Guid("2eaaba04-80ff-43a6-a746-a74a91c7c2e6"), new DateTime(2023, 9, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "Description", 4000000.0, 5000000.0, new Guid("cc37720a-7e89-463a-9510-1936e6761d8b"), 1, new Guid("cc37720a-7e89-463a-9510-1936e6761d63"), 0, new Guid("cc37720a-7e89-463a-9510-1936e6761d64"), new Guid("cc37720a-7e89-463a-9510-1936e6761d55") },
                    { new Guid("2eaaba04-80ff-43a6-a746-a74a91c7c2e7"), new DateTime(2023, 9, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "Description", 4000000.0, 5000000.0, new Guid("cc37720a-7e89-463a-9510-1936e6761d8b"), 1, new Guid("cc37720a-7e89-463a-9510-1936e6761d63"), 0, new Guid("cc37720a-7e89-463a-9510-1936e6761d74"), new Guid("cc37720a-7e89-463a-9510-1936e6761d55") },
                    { new Guid("2eaaba04-80ff-43a6-a746-a74a91c7c2e8"), new DateTime(2023, 9, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "Description", 4000000.0, 5000000.0, new Guid("cc37720a-7e89-463a-9510-1936e6761d8b"), 1, new Guid("cc37720a-7e89-463a-9510-1936e6761d63"), 0, new Guid("cc37720a-7e89-463a-9510-1936e6761d84"), new Guid("cc37720a-7e89-463a-9510-1936e6761d55") },
                    { new Guid("2eaaba04-80ff-43a6-a746-a74a91c7c2e9"), new DateTime(2023, 9, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "Description", 4000000.0, 5000000.0, new Guid("cc37720a-7e89-463a-9510-1936e6761d8b"), 1, new Guid("cc37720a-7e89-463a-9510-1936e6761d63"), 0, new Guid("cc37720a-7e89-463a-9510-1936e6761d94"), new Guid("cc37720a-7e89-463a-9510-1936e6761d55") },
                    { new Guid("2eaaba04-80ff-43a6-a746-a74a91c7c3e0"), new DateTime(2023, 9, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "Description", 4000000.0, 5000000.0, new Guid("cc37720a-7e89-463a-9510-1936e6761d8b"), 1, new Guid("cc37720a-7e89-463a-9510-1936e6761d53"), 0, new Guid("cc37720a-7e89-463a-9510-1936e6761d04"), new Guid("cc37720a-7e89-463a-9510-1936e6761d55") },
                    { new Guid("2eaaba04-80ff-43a6-a746-a74a91c7c3e1"), new DateTime(2023, 9, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "Description", 4000000.0, 5000000.0, new Guid("cc37720a-7e89-463a-9510-1936e6761d8b"), 1, new Guid("cc37720a-7e89-463a-9510-1936e6761d53"), 0, new Guid("cc37720a-7e89-463a-9510-1936e6761d14"), new Guid("cc37720a-7e89-463a-9510-1936e6761d55") },
                    { new Guid("2eaaba04-80ff-43a6-a746-a74a91c7c3e2"), new DateTime(2023, 9, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "Description", 4000000.0, 5000000.0, new Guid("cc37720a-7e89-463a-9510-1936e6761d8b"), 1, new Guid("cc37720a-7e89-463a-9510-1936e6761d53"), 0, new Guid("cc37720a-7e89-463a-9510-1936e6761d24"), new Guid("cc37720a-7e89-463a-9510-1936e6761d55") },
                    { new Guid("2eaaba04-80ff-43a6-a746-a74a91c7c3e3"), new DateTime(2023, 9, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "Description", 4000000.0, 5000000.0, new Guid("cc37720a-7e89-463a-9510-1936e6761d8b"), 1, new Guid("cc37720a-7e89-463a-9510-1936e6761d53"), 0, new Guid("cc37720a-7e89-463a-9510-1936e6761d34"), new Guid("cc37720a-7e89-463a-9510-1936e6761d55") },
                    { new Guid("2eaaba04-80ff-43a6-a746-a74a91c7c3e4"), new DateTime(2023, 9, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "Description", 4000000.0, 5000000.0, new Guid("cc37720a-7e89-463a-9510-1936e6761d8b"), 1, new Guid("cc37720a-7e89-463a-9510-1936e6761d53"), 0, new Guid("cc37720a-7e89-463a-9510-1936e6761d44"), new Guid("cc37720a-7e89-463a-9510-1936e6761d55") },
                    { new Guid("2eaaba04-80ff-43a6-a746-a74a91c7c3e5"), new DateTime(2023, 9, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "Description", 4000000.0, 5000000.0, new Guid("cc37720a-7e89-463a-9510-1936e6761d8b"), 1, new Guid("cc37720a-7e89-463a-9510-1936e6761d53"), 0, new Guid("cc37720a-7e89-463a-9510-1936e6761d54"), new Guid("cc37720a-7e89-463a-9510-1936e6761d55") },
                    { new Guid("2eaaba04-80ff-43a6-a746-a74a91c7c3e6"), new DateTime(2023, 9, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "Description", 4000000.0, 5000000.0, new Guid("cc37720a-7e89-463a-9510-1936e6761d8b"), 1, new Guid("cc37720a-7e89-463a-9510-1936e6761d53"), 0, new Guid("cc37720a-7e89-463a-9510-1936e6761d64"), new Guid("cc37720a-7e89-463a-9510-1936e6761d55") },
                    { new Guid("2eaaba04-80ff-43a6-a746-a74a91c7c3e7"), new DateTime(2023, 9, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "Description", 4000000.0, 5000000.0, new Guid("cc37720a-7e89-463a-9510-1936e6761d8b"), 1, new Guid("cc37720a-7e89-463a-9510-1936e6761d53"), 0, new Guid("cc37720a-7e89-463a-9510-1936e6761d74"), new Guid("cc37720a-7e89-463a-9510-1936e6761d55") },
                    { new Guid("2eaaba04-80ff-43a6-a746-a74a91c7c3e8"), new DateTime(2023, 9, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "Description", 4000000.0, 5000000.0, new Guid("cc37720a-7e89-463a-9510-1936e6761d8b"), 1, new Guid("cc37720a-7e89-463a-9510-1936e6761d53"), 0, new Guid("cc37720a-7e89-463a-9510-1936e6761d84"), new Guid("cc37720a-7e89-463a-9510-1936e6761d55") },
                    { new Guid("2eaaba04-80ff-43a6-a746-a74a91c7c3e9"), new DateTime(2023, 9, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "Description", 4000000.0, 5000000.0, new Guid("cc37720a-7e89-463a-9510-1936e6761d8b"), 1, new Guid("cc37720a-7e89-463a-9510-1936e6761d53"), 0, new Guid("cc37720a-7e89-463a-9510-1936e6761d94"), new Guid("cc37720a-7e89-463a-9510-1936e6761d55") },
                    { new Guid("84a7b7bd-0490-4cf1-9499-1d9fe88580c0"), new DateTime(2023, 9, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "Description", 4000000.0, 5000000.0, new Guid("cc37720a-7e89-463a-9510-8936e6761d8a"), 1, new Guid("cc37720a-7e89-463a-9510-1936e6761d73"), 0, new Guid("cc37720a-7e89-463a-9510-1936e6761d74"), new Guid("cc37720a-7e89-463a-9510-1936e6761d75") },
                    { new Guid("84a7b7bd-0490-4cf1-9499-1d9fe88580c3"), new DateTime(2023, 9, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "Description", 4000000.0, 5000000.0, new Guid("cc37720a-7e89-463a-9510-1936e6761d8c"), 1, new Guid("cc37720a-7e89-463a-9510-1936e6761d73"), 0, new Guid("cc37720a-7e89-463a-9510-1936e6761d74"), new Guid("cc37720a-7e89-463a-9510-1936e6761d75") },
                    { new Guid("84a7b7bd-0490-4cf1-9499-1d9fe88580c4"), new DateTime(2023, 9, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "Description", 4000000.0, 5000000.0, new Guid("cc37720a-7e89-463a-9510-2936e6761d8a"), 1, new Guid("cc37720a-7e89-463a-9510-1936e6761d73"), 0, new Guid("cc37720a-7e89-463a-9510-1936e6761d74"), new Guid("cc37720a-7e89-463a-9510-1936e6761d75") },
                    { new Guid("84a7b7bd-0490-4cf1-9499-1d9fe88580c5"), new DateTime(2023, 9, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "Description", 4000000.0, 5000000.0, new Guid("cc37720a-7e89-463a-9510-3936e6761d8b"), 1, new Guid("cc37720a-7e89-463a-9510-1936e6761d73"), 0, new Guid("cc37720a-7e89-463a-9510-1936e6761d74"), new Guid("cc37720a-7e89-463a-9510-1936e6761d75") },
                    { new Guid("84a7b7bd-0490-4cf1-9499-1d9fe88580c6"), new DateTime(2023, 9, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "Description", 4000000.0, 5000000.0, new Guid("cc37720a-7e89-463a-9510-4936e6761d8c"), 1, new Guid("cc37720a-7e89-463a-9510-1936e6761d73"), 0, new Guid("cc37720a-7e89-463a-9510-1936e6761d74"), new Guid("cc37720a-7e89-463a-9510-1936e6761d75") },
                    { new Guid("84a7b7bd-0490-4cf1-9499-1d9fe88580c7"), new DateTime(2023, 9, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "Description", 4000000.0, 5000000.0, new Guid("cc37720a-7e89-463a-9510-5936e6761d8a"), 1, new Guid("cc37720a-7e89-463a-9510-1936e6761d73"), 0, new Guid("cc37720a-7e89-463a-9510-1936e6761d74"), new Guid("cc37720a-7e89-463a-9510-1936e6761d75") },
                    { new Guid("84a7b7bd-0490-4cf1-9499-1d9fe88580c8"), new DateTime(2023, 9, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "Description", 4000000.0, 5000000.0, new Guid("cc37720a-7e89-463a-9510-6936e6761d8b"), 1, new Guid("cc37720a-7e89-463a-9510-1936e6761d73"), 0, new Guid("cc37720a-7e89-463a-9510-1936e6761d74"), new Guid("cc37720a-7e89-463a-9510-1936e6761d75") },
                    { new Guid("84a7b7bd-0490-4cf1-9499-1d9fe88580c9"), new DateTime(2023, 9, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "Description", 4000000.0, 5000000.0, new Guid("cc37720a-7e89-463a-9510-7936e6761d8c"), 1, new Guid("cc37720a-7e89-463a-9510-1936e6761d73"), 0, new Guid("cc37720a-7e89-463a-9510-1936e6761d74"), new Guid("cc37720a-7e89-463a-9510-1936e6761d75") }
                });

            migrationBuilder.InsertData(
                table: "WishLists",
                columns: new[] { "Id", "CustomerId", "ProductId" },
                values: new object[] { new Guid("37c66a8d-acb9-41a1-af73-f46e83a578dc"), new Guid("a77f8ae9-af3d-4288-bbf3-8f77776f9231"), new Guid("cc37720a-7e89-463a-9510-1936e6761d8a") });

            migrationBuilder.InsertData(
                table: "BillDetails",
                columns: new[] { "Id", "BillId", "CreateDate", "Price", "ProductDetailId", "Quantity" },
                values: new object[,]
                {
                    { new Guid("8f95d2d6-c3d3-4749-be89-97e220d62e78"), new Guid("a51f7c3c-a8e7-4c0a-aeea-b6fc70492b13"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1450.0, new Guid("2eaaba04-80ff-43a6-a746-a74a91c4c0e0"), 1 },
                    { new Guid("8f95d2d6-c3d3-4749-be89-97e220d62e79"), new Guid("a51f7c3c-a8e7-4c0a-aeea-b6fc70492bf3"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1500.0, new Guid("1eaaba04-80ff-43a6-a746-a74a91c4c0e3"), 1 }
                });

            migrationBuilder.InsertData(
                table: "CartDetails",
                columns: new[] { "Id", "CustomerId", "Price", "ProductDetailId", "Quantity" },
                values: new object[] { new Guid("357267e8-d162-4844-a660-661f46933d02"), new Guid("a77f8ae9-af3d-4288-bbf3-8f77776f9231"), 2000.0, new Guid("2eaaba04-80ff-43a6-a746-a74a91c4c0e0"), 1 });

            migrationBuilder.InsertData(
                table: "ProductImages",
                columns: new[] { "Id", "Name", "ProductDetailId", "Status" },
                values: new object[,]
                {
                    { new Guid("a9e47c8b-4af6-4ccd-b259-7367eb8f6420"), "2.png", new Guid("84a7b7bd-0490-4cf1-9499-1d9fe88580c0"), 0 },
                    { new Guid("a9e47c8b-4af6-4ccd-b259-7367eb8f6423"), "2.png", new Guid("84a7b7bd-0490-4cf1-9499-1d9fe88580c3"), 0 },
                    { new Guid("a9e47c8b-4af6-4ccd-b259-7367eb8f6425"), "2.png", new Guid("84a7b7bd-0490-4cf1-9499-1d9fe88580c5"), 0 },
                    { new Guid("a9e47c8b-4af6-4ccd-b259-7367eb8f6426"), "2.png", new Guid("84a7b7bd-0490-4cf1-9499-1d9fe88580c6"), 0 },
                    { new Guid("a9e47c8b-4af6-4ccd-b259-7367eb8f6427"), "1.png", new Guid("84a7b7bd-0490-4cf1-9499-1d9fe88580c7"), 0 },
                    { new Guid("a9e47c8b-4af6-4ccd-b259-7367eb8f6428"), "2.png", new Guid("84a7b7bd-0490-4cf1-9499-1d9fe88580c8"), 0 },
                    { new Guid("a9e47c8b-4af6-4ccd-b259-7367eb8f6429"), "1.png", new Guid("84a7b7bd-0490-4cf1-9499-1d9fe88580c9"), 0 },
                    { new Guid("d5c65161-7591-48c1-9198-daca150bce0c"), "presp8pw_01.jpg", new Guid("1eaaba04-80ff-43a6-a746-a74a91c4c0e0"), 0 },
                    { new Guid("d5c65161-7591-48c1-9198-daca150bce1c"), "presp8pw_cat.jpg", new Guid("1eaaba04-80ff-43a6-a746-a74a91c4c0e0"), 0 },
                    { new Guid("d5c65161-7591-48c1-9198-daca150bce2c"), "presp8pw_01.jpg", new Guid("1eaaba04-80ff-43a6-a746-a74a91c4c0e1"), 0 },
                    { new Guid("d5c65161-7591-48c1-9198-daca150bce3c"), "presp8pw_cat.jpg", new Guid("1eaaba04-80ff-43a6-a746-a74a91c4c0e1"), 0 },
                    { new Guid("d5c65161-7591-48c1-9198-daca150bce4c"), "presp8pw_01.jpg", new Guid("1eaaba04-80ff-43a6-a746-a74a91c4c0e2"), 0 },
                    { new Guid("d5c65161-7591-48c1-9198-daca150bce5c"), "presp8pw_cat.jpg", new Guid("1eaaba04-80ff-43a6-a746-a74a91c4c0e2"), 0 },
                    { new Guid("d5c65161-7591-48c1-9198-daca150bce6c"), "presp8pw_01.jpg", new Guid("1eaaba04-80ff-43a6-a746-a74a91c4c0e3"), 0 },
                    { new Guid("d5c65161-7591-48c1-9198-daca150bce7c"), "presp8pw_cat.jpg", new Guid("1eaaba04-80ff-43a6-a746-a74a91c4c0e3"), 0 },
                    { new Guid("d5c65161-7591-48c1-9198-daca150bce8c"), "presp8pw_01.jpg", new Guid("1eaaba04-80ff-43a6-a746-a74a91c4c0e4"), 0 },
                    { new Guid("d5c65161-7591-48c1-9198-daca150bce9c"), "presp8pw_cat.jpg", new Guid("1eaaba04-80ff-43a6-a746-a74a91c4c0e4"), 0 },
                    { new Guid("d5c65161-7591-48c1-9198-daca151bce0c"), "presp8pw_01.jpg", new Guid("1eaaba04-80ff-43a6-a746-a74a91c4c0e5"), 0 },
                    { new Guid("d5c65161-7591-48c1-9198-daca151bce1c"), "presp8pw_cat.jpg", new Guid("1eaaba04-80ff-43a6-a746-a74a91c4c0e5"), 0 },
                    { new Guid("d5c65161-7591-48c1-9198-daca151bce2c"), "presp8pw_01.jpg", new Guid("1eaaba04-80ff-43a6-a746-a74a91c4c0e6"), 0 },
                    { new Guid("d5c65161-7591-48c1-9198-daca151bce3c"), "presp8pw_cat.jpg", new Guid("1eaaba04-80ff-43a6-a746-a74a91c4c0e6"), 0 },
                    { new Guid("d5c65161-7591-48c1-9198-daca151bce4c"), "presp8pw_01.jpg", new Guid("1eaaba04-80ff-43a6-a746-a74a91c4c0e7"), 0 },
                    { new Guid("d5c65161-7591-48c1-9198-daca151bce5c"), "presp8pw_cat.jpg", new Guid("1eaaba04-80ff-43a6-a746-a74a91c4c0e7"), 0 },
                    { new Guid("d5c65161-7591-48c1-9198-daca151bce6c"), "presp8pw_01.jpg", new Guid("1eaaba04-80ff-43a6-a746-a74a91c4c0e8"), 0 },
                    { new Guid("d5c65161-7591-48c1-9198-daca151bce7c"), "presp8pw_cat.jpg", new Guid("1eaaba04-80ff-43a6-a746-a74a91c4c0e8"), 0 },
                    { new Guid("d5c65161-7591-48c1-9198-daca151bce8c"), "presp8pw_01.jpg", new Guid("1eaaba04-80ff-43a6-a746-a74a91c4c0e9"), 0 },
                    { new Guid("d5c65161-7591-48c1-9198-daca151bce9c"), "presp8pw_cat.jpg", new Guid("1eaaba04-80ff-43a6-a746-a74a91c4c0e9"), 0 },
                    { new Guid("d5c65161-7591-48c1-9198-daca152bce0c"), "presp8pw_01.jpg", new Guid("1eaaba04-80ff-43a6-a746-a74a91c4c1e0"), 0 },
                    { new Guid("d5c65161-7591-48c1-9198-daca152bce1c"), "presp8pw_cat.jpg", new Guid("1eaaba04-80ff-43a6-a746-a74a91c4c1e0"), 0 },
                    { new Guid("d5c65161-7591-48c1-9198-daca152bce2c"), "presp8pw_01.jpg", new Guid("1eaaba04-80ff-43a6-a746-a74a91c4c1e1"), 0 },
                    { new Guid("d5c65161-7591-48c1-9198-daca152bce3c"), "presp8pw_cat.jpg", new Guid("1eaaba04-80ff-43a6-a746-a74a91c4c1e1"), 0 },
                    { new Guid("d5c65161-7591-48c1-9198-daca152bce4c"), "presp8pw_01.jpg", new Guid("1eaaba04-80ff-43a6-a746-a74a91c4c1e2"), 0 },
                    { new Guid("d5c65161-7591-48c1-9198-daca152bce5c"), "presp8pw_cat.jpg", new Guid("1eaaba04-80ff-43a6-a746-a74a91c4c1e2"), 0 },
                    { new Guid("d5c65161-7591-48c1-9198-daca152bce6c"), "presp8pw_01.jpg", new Guid("1eaaba04-80ff-43a6-a746-a74a91c4c1e3"), 0 },
                    { new Guid("d5c65161-7591-48c1-9198-daca152bce7c"), "presp8pw_cat.jpg", new Guid("1eaaba04-80ff-43a6-a746-a74a91c4c1e3"), 0 },
                    { new Guid("d5c65161-7591-48c1-9198-daca152bce8c"), "presp8pw_01.jpg", new Guid("1eaaba04-80ff-43a6-a746-a74a91c4c1e4"), 0 },
                    { new Guid("d5c65161-7591-48c1-9198-daca152bce9c"), "presp8pw_cat.jpg", new Guid("1eaaba04-80ff-43a6-a746-a74a91c4c1e4"), 0 },
                    { new Guid("d5c65161-7591-48c1-9198-daca153bce0c"), "presp8pw_01.jpg", new Guid("1eaaba04-80ff-43a6-a746-a74a91c4c1e5"), 0 },
                    { new Guid("d5c65161-7591-48c1-9198-daca153bce1c"), "presp8pw_cat.jpg", new Guid("1eaaba04-80ff-43a6-a746-a74a91c4c1e5"), 0 }
                });

            migrationBuilder.InsertData(
                table: "ProductImages",
                columns: new[] { "Id", "Name", "ProductDetailId", "Status" },
                values: new object[,]
                {
                    { new Guid("d5c65161-7591-48c1-9198-daca153bce2c"), "presp8pw_01.jpg", new Guid("1eaaba04-80ff-43a6-a746-a74a91c4c1e6"), 0 },
                    { new Guid("d5c65161-7591-48c1-9198-daca153bce3c"), "presp8pw_cat.jpg", new Guid("1eaaba04-80ff-43a6-a746-a74a91c4c1e6"), 0 },
                    { new Guid("d5c65161-7591-48c1-9198-daca153bce4c"), "presp8pw_01.jpg", new Guid("1eaaba04-80ff-43a6-a746-a74a91c4c1e7"), 0 },
                    { new Guid("d5c65161-7591-48c1-9198-daca153bce5c"), "presp8pw_cat.jpg", new Guid("1eaaba04-80ff-43a6-a746-a74a91c4c1e7"), 0 },
                    { new Guid("d5c65161-7591-48c1-9198-daca153bce6c"), "presp8pw_01.jpg", new Guid("1eaaba04-80ff-43a6-a746-a74a91c4c1e8"), 0 },
                    { new Guid("d5c65161-7591-48c1-9198-daca153bce7c"), "presp8pw_cat.jpg", new Guid("1eaaba04-80ff-43a6-a746-a74a91c4c1e8"), 0 },
                    { new Guid("d5c65161-7591-48c1-9198-daca153bce8c"), "presp8pw_01.jpg", new Guid("1eaaba04-80ff-43a6-a746-a74a91c4c1e9"), 0 },
                    { new Guid("d5c65161-7591-48c1-9198-daca153bce9c"), "presp8pw_cat.jpg", new Guid("1eaaba04-80ff-43a6-a746-a74a91c4c1e9"), 0 },
                    { new Guid("d5c65161-7591-48c1-9198-daca154bce0c"), "presp8pw_01.jpg", new Guid("1eaaba04-80ff-43a6-a746-a74a91c4c2e0"), 0 },
                    { new Guid("d5c65161-7591-48c1-9198-daca154bce1c"), "presp8pw_cat.jpg", new Guid("1eaaba04-80ff-43a6-a746-a74a91c4c2e0"), 0 },
                    { new Guid("d5c65161-7591-48c1-9198-daca154bce2c"), "presp8pw_01.jpg", new Guid("1eaaba04-80ff-43a6-a746-a74a91c4c2e1"), 0 },
                    { new Guid("d5c65161-7591-48c1-9198-daca154bce3c"), "presp8pw_cat.jpg", new Guid("1eaaba04-80ff-43a6-a746-a74a91c4c2e1"), 0 },
                    { new Guid("d5c65161-7591-48c1-9198-daca154bce4c"), "presp8pw_01.jpg", new Guid("1eaaba04-80ff-43a6-a746-a74a91c4c2e2"), 0 },
                    { new Guid("d5c65161-7591-48c1-9198-daca154bce5c"), "presp8pw_cat.jpg", new Guid("1eaaba04-80ff-43a6-a746-a74a91c4c2e2"), 0 },
                    { new Guid("d5c65161-7591-48c1-9198-daca154bce6c"), "presp8pw_01.jpg", new Guid("1eaaba04-80ff-43a6-a746-a74a91c4c2e3"), 0 },
                    { new Guid("d5c65161-7591-48c1-9198-daca154bce7c"), "presp8pw_cat.jpg", new Guid("1eaaba04-80ff-43a6-a746-a74a91c4c2e3"), 0 },
                    { new Guid("d5c65161-7591-48c1-9198-daca154bce8c"), "presp8pw_01.jpg", new Guid("1eaaba04-80ff-43a6-a746-a74a91c4c2e4"), 0 },
                    { new Guid("d5c65161-7591-48c1-9198-daca154bce9c"), "presp8pw_cat.jpg", new Guid("1eaaba04-80ff-43a6-a746-a74a91c4c2e4"), 0 },
                    { new Guid("d5c65161-7591-48c1-9198-daca155bce0c"), "presp8pw_01.jpg", new Guid("1eaaba04-80ff-43a6-a746-a74a91c4c2e5"), 0 },
                    { new Guid("d5c65161-7591-48c1-9198-daca155bce1c"), "presp8pw_cat.jpg", new Guid("1eaaba04-80ff-43a6-a746-a74a91c4c2e5"), 0 },
                    { new Guid("d5c65161-7591-48c1-9198-daca155bce2c"), "presp8pw_01.jpg", new Guid("1eaaba04-80ff-43a6-a746-a74a91c4c2e6"), 0 },
                    { new Guid("d5c65161-7591-48c1-9198-daca155bce3c"), "presp8pw_cat.jpg", new Guid("1eaaba04-80ff-43a6-a746-a74a91c4c2e6"), 0 },
                    { new Guid("d5c65161-7591-48c1-9198-daca155bce4c"), "presp8pw_01.jpg", new Guid("1eaaba04-80ff-43a6-a746-a74a91c4c2e7"), 0 },
                    { new Guid("d5c65161-7591-48c1-9198-daca155bce5c"), "presp8pw_cat.jpg", new Guid("1eaaba04-80ff-43a6-a746-a74a91c4c2e7"), 0 },
                    { new Guid("d5c65161-7591-48c1-9198-daca155bce6c"), "presp8pw_01.jpg", new Guid("1eaaba04-80ff-43a6-a746-a74a91c4c2e8"), 0 },
                    { new Guid("d5c65161-7591-48c1-9198-daca155bce7c"), "presp8pw_cat.jpg", new Guid("1eaaba04-80ff-43a6-a746-a74a91c4c2e8"), 0 },
                    { new Guid("d5c65161-7591-48c1-9198-daca155bce8c"), "presp8pw_01.jpg", new Guid("1eaaba04-80ff-43a6-a746-a74a91c4c2e9"), 0 },
                    { new Guid("d5c65161-7591-48c1-9198-daca155bce9c"), "presp8pw_cat.jpg", new Guid("1eaaba04-80ff-43a6-a746-a74a91c4c2e9"), 0 },
                    { new Guid("d5c65161-7591-48c1-9198-daca156bce0c"), "presp8pw_01.jpg", new Guid("1eaaba04-80ff-43a6-a746-a74a91c4c3e0"), 0 },
                    { new Guid("d5c65161-7591-48c1-9198-daca156bce1c"), "presp8pw_cat.jpg", new Guid("1eaaba04-80ff-43a6-a746-a74a91c4c3e0"), 0 },
                    { new Guid("d5c65161-7591-48c1-9198-daca156bce2c"), "presp8pw_01.jpg", new Guid("1eaaba04-80ff-43a6-a746-a74a91c4c3e1"), 0 },
                    { new Guid("d5c65161-7591-48c1-9198-daca156bce3c"), "presp8pw_cat.jpg", new Guid("1eaaba04-80ff-43a6-a746-a74a91c4c3e1"), 0 },
                    { new Guid("d5c65161-7591-48c1-9198-daca156bce4c"), "presp8pw_01.jpg", new Guid("1eaaba04-80ff-43a6-a746-a74a91c4c3e2"), 0 },
                    { new Guid("d5c65161-7591-48c1-9198-daca156bce5c"), "presp8pw_cat.jpg", new Guid("1eaaba04-80ff-43a6-a746-a74a91c4c3e2"), 0 },
                    { new Guid("d5c65161-7591-48c1-9198-daca156bce6c"), "presp8pw_01.jpg", new Guid("1eaaba04-80ff-43a6-a746-a74a91c4c3e3"), 0 },
                    { new Guid("d5c65161-7591-48c1-9198-daca156bce7c"), "presp8pw_cat.jpg", new Guid("1eaaba04-80ff-43a6-a746-a74a91c4c3e3"), 0 },
                    { new Guid("d5c65161-7591-48c1-9198-daca156bce8c"), "presp8pw_01.jpg", new Guid("1eaaba04-80ff-43a6-a746-a74a91c4c3e4"), 0 },
                    { new Guid("d5c65161-7591-48c1-9198-daca156bce9c"), "presp8pw_cat.jpg", new Guid("1eaaba04-80ff-43a6-a746-a74a91c4c3e4"), 0 },
                    { new Guid("d5c65161-7591-48c1-9198-daca157bce0c"), "presp8pw_01.jpg", new Guid("1eaaba04-80ff-43a6-a746-a74a91c4c3e5"), 0 },
                    { new Guid("d5c65161-7591-48c1-9198-daca157bce1c"), "presp8pw_cat.jpg", new Guid("1eaaba04-80ff-43a6-a746-a74a91c4c3e5"), 0 },
                    { new Guid("d5c65161-7591-48c1-9198-daca157bce2c"), "presp8pw_01.jpg", new Guid("1eaaba04-80ff-43a6-a746-a74a91c4c3e6"), 0 },
                    { new Guid("d5c65161-7591-48c1-9198-daca157bce3c"), "presp8pw_cat.jpg", new Guid("1eaaba04-80ff-43a6-a746-a74a91c4c3e6"), 0 }
                });

            migrationBuilder.InsertData(
                table: "ProductImages",
                columns: new[] { "Id", "Name", "ProductDetailId", "Status" },
                values: new object[,]
                {
                    { new Guid("d5c65161-7591-48c1-9198-daca157bce4c"), "presp8pw_01.jpg", new Guid("1eaaba04-80ff-43a6-a746-a74a91c4c3e7"), 0 },
                    { new Guid("d5c65161-7591-48c1-9198-daca157bce5c"), "presp8pw_cat.jpg", new Guid("1eaaba04-80ff-43a6-a746-a74a91c4c3e7"), 0 },
                    { new Guid("d5c65161-7591-48c1-9198-daca157bce6c"), "presp8pw_01.jpg", new Guid("1eaaba04-80ff-43a6-a746-a74a91c4c3e8"), 0 },
                    { new Guid("d5c65161-7591-48c1-9198-daca157bce7c"), "presp8pw_cat.jpg", new Guid("1eaaba04-80ff-43a6-a746-a74a91c4c3e8"), 0 },
                    { new Guid("d5c65161-7591-48c1-9198-daca157bce8c"), "presp8pw_01.jpg", new Guid("1eaaba04-80ff-43a6-a746-a74a91c4c3e9"), 0 },
                    { new Guid("d5c65161-7591-48c1-9198-daca157bce9c"), "presp8pw_cat.jpg", new Guid("1eaaba04-80ff-43a6-a746-a74a91c4c3e9"), 0 },
                    { new Guid("d5c65161-7591-48c1-9198-daca158bce0c"), "presp8pw_01.jpg", new Guid("1eaaba04-80ff-43a6-a746-a74a91c5c0e0"), 0 },
                    { new Guid("d5c65161-7591-48c1-9198-daca158bce1c"), "presp8pw_cat.jpg", new Guid("1eaaba04-80ff-43a6-a746-a74a91c5c0e0"), 0 },
                    { new Guid("d5c65161-7591-48c1-9198-daca158bce2c"), "presp8pw_01.jpg", new Guid("1eaaba04-80ff-43a6-a746-a74a91c5c0e1"), 0 },
                    { new Guid("d5c65161-7591-48c1-9198-daca158bce3c"), "presp8pw_cat.jpg", new Guid("1eaaba04-80ff-43a6-a746-a74a91c5c0e1"), 0 },
                    { new Guid("d5c65161-7591-48c1-9198-daca158bce4c"), "presp8pw_01.jpg", new Guid("1eaaba04-80ff-43a6-a746-a74a91c5c0e2"), 0 },
                    { new Guid("d5c65161-7591-48c1-9198-daca158bce5c"), "presp8pw_cat.jpg", new Guid("1eaaba04-80ff-43a6-a746-a74a91c5c0e2"), 0 },
                    { new Guid("d5c65161-7591-48c1-9198-daca158bce6c"), "presp8pw_01.jpg", new Guid("1eaaba04-80ff-43a6-a746-a74a91c5c0e3"), 0 },
                    { new Guid("d5c65161-7591-48c1-9198-daca158bce7c"), "presp8pw_cat.jpg", new Guid("1eaaba04-80ff-43a6-a746-a74a91c5c0e3"), 0 },
                    { new Guid("d5c65161-7591-48c1-9198-daca158bce8c"), "presp8pw_01.jpg", new Guid("1eaaba04-80ff-43a6-a746-a74a91c5c0e4"), 0 },
                    { new Guid("d5c65161-7591-48c1-9198-daca158bce9c"), "presp8pw_cat.jpg", new Guid("1eaaba04-80ff-43a6-a746-a74a91c5c0e4"), 0 },
                    { new Guid("d5c65161-7591-48c1-9198-daca159bce0c"), "presp8pw_01.jpg", new Guid("1eaaba04-80ff-43a6-a746-a74a91c5c0e5"), 0 },
                    { new Guid("d5c65161-7591-48c1-9198-daca159bce1c"), "presp8pw_cat.jpg", new Guid("1eaaba04-80ff-43a6-a746-a74a91c5c0e5"), 0 },
                    { new Guid("d5c65161-7591-48c1-9198-daca159bce2c"), "presp8pw_01.jpg", new Guid("1eaaba04-80ff-43a6-a746-a74a91c5c0e6"), 0 },
                    { new Guid("d5c65161-7591-48c1-9198-daca159bce3c"), "presp8pw_cat.jpg", new Guid("1eaaba04-80ff-43a6-a746-a74a91c5c0e6"), 0 },
                    { new Guid("d5c65161-7591-48c1-9198-daca159bce4c"), "presp8pw_01.jpg", new Guid("1eaaba04-80ff-43a6-a746-a74a91c5c0e7"), 0 },
                    { new Guid("d5c65161-7591-48c1-9198-daca159bce5c"), "presp8pw_cat.jpg", new Guid("1eaaba04-80ff-43a6-a746-a74a91c5c0e7"), 0 },
                    { new Guid("d5c65161-7591-48c1-9198-daca159bce6c"), "presp8pw_01.jpg", new Guid("1eaaba04-80ff-43a6-a746-a74a91c5c0e8"), 0 },
                    { new Guid("d5c65161-7591-48c1-9198-daca159bce7c"), "presp8pw_cat.jpg", new Guid("1eaaba04-80ff-43a6-a746-a74a91c5c0e8"), 0 },
                    { new Guid("d5c65161-7591-48c1-9198-daca159bce8c"), "presp8pw_01.jpg", new Guid("1eaaba04-80ff-43a6-a746-a74a91c5c0e9"), 0 },
                    { new Guid("d5c65161-7591-48c1-9198-daca159bce9c"), "presp8pw_cat.jpg", new Guid("1eaaba04-80ff-43a6-a746-a74a91c5c0e9"), 0 },
                    { new Guid("d5c65161-7591-48c1-9198-daca161bce0c"), "presp8pw_01.jpg", new Guid("1eaaba04-80ff-43a6-a746-a74a91c5c1e0"), 0 },
                    { new Guid("d5c65161-7591-48c1-9198-daca161bce1c"), "presp8pw_cat.jpg", new Guid("1eaaba04-80ff-43a6-a746-a74a91c5c1e0"), 0 },
                    { new Guid("d5c65161-7591-48c1-9198-daca161bce2c"), "presp8pw_01.jpg", new Guid("1eaaba04-80ff-43a6-a746-a74a91c5c1e1"), 0 },
                    { new Guid("d5c65161-7591-48c1-9198-daca161bce3c"), "presp8pw_cat.jpg", new Guid("1eaaba04-80ff-43a6-a746-a74a91c5c1e1"), 0 },
                    { new Guid("d5c65161-7591-48c1-9198-daca161bce4c"), "presp8pw_01.jpg", new Guid("1eaaba04-80ff-43a6-a746-a74a91c5c1e2"), 0 },
                    { new Guid("d5c65161-7591-48c1-9198-daca161bce5c"), "presp8pw_cat.jpg", new Guid("1eaaba04-80ff-43a6-a746-a74a91c5c1e2"), 0 },
                    { new Guid("d5c65161-7591-48c1-9198-daca161bce6c"), "presp8pw_01.jpg", new Guid("1eaaba04-80ff-43a6-a746-a74a91c5c1e3"), 0 },
                    { new Guid("d5c65161-7591-48c1-9198-daca161bce7c"), "presp8pw_cat.jpg", new Guid("1eaaba04-80ff-43a6-a746-a74a91c5c1e3"), 0 },
                    { new Guid("d5c65161-7591-48c1-9198-daca161bce8c"), "presp8pw_01.jpg", new Guid("1eaaba04-80ff-43a6-a746-a74a91c5c1e4"), 0 },
                    { new Guid("d5c65161-7591-48c1-9198-daca161bce9c"), "presp8pw_cat.jpg", new Guid("1eaaba04-80ff-43a6-a746-a74a91c5c1e4"), 0 },
                    { new Guid("d5c65161-7591-48c1-9198-daca162bce0c"), "presp8pw_01.jpg", new Guid("1eaaba04-80ff-43a6-a746-a74a91c5c1e5"), 0 },
                    { new Guid("d5c65161-7591-48c1-9198-daca162bce1c"), "presp8pw_cat.jpg", new Guid("1eaaba04-80ff-43a6-a746-a74a91c5c1e5"), 0 },
                    { new Guid("d5c65161-7591-48c1-9198-daca162bce2c"), "presp8pw_01.jpg", new Guid("1eaaba04-80ff-43a6-a746-a74a91c5c1e6"), 0 },
                    { new Guid("d5c65161-7591-48c1-9198-daca162bce3c"), "presp8pw_cat.jpg", new Guid("1eaaba04-80ff-43a6-a746-a74a91c5c1e6"), 0 },
                    { new Guid("d5c65161-7591-48c1-9198-daca162bce4c"), "presp8pw_01.jpg", new Guid("1eaaba04-80ff-43a6-a746-a74a91c5c1e7"), 0 },
                    { new Guid("d5c65161-7591-48c1-9198-daca162bce5c"), "presp8pw_cat.jpg", new Guid("1eaaba04-80ff-43a6-a746-a74a91c5c1e7"), 0 }
                });

            migrationBuilder.InsertData(
                table: "ProductImages",
                columns: new[] { "Id", "Name", "ProductDetailId", "Status" },
                values: new object[,]
                {
                    { new Guid("d5c65161-7591-48c1-9198-daca162bce6c"), "presp8pw_01.jpg", new Guid("1eaaba04-80ff-43a6-a746-a74a91c5c1e8"), 0 },
                    { new Guid("d5c65161-7591-48c1-9198-daca162bce7c"), "presp8pw_cat.jpg", new Guid("1eaaba04-80ff-43a6-a746-a74a91c5c1e8"), 0 },
                    { new Guid("d5c65161-7591-48c1-9198-daca162bce8c"), "presp8pw_01.jpg", new Guid("1eaaba04-80ff-43a6-a746-a74a91c5c1e9"), 0 },
                    { new Guid("d5c65161-7591-48c1-9198-daca162bce9c"), "presp8pw_cat.jpg", new Guid("1eaaba04-80ff-43a6-a746-a74a91c5c1e9"), 0 },
                    { new Guid("d5c65161-7591-48c1-9198-daca163bce0c"), "presp8pw_01.jpg", new Guid("1eaaba04-80ff-43a6-a746-a74a91c5c2e0"), 0 },
                    { new Guid("d5c65161-7591-48c1-9198-daca163bce1c"), "presp8pw_cat.jpg", new Guid("1eaaba04-80ff-43a6-a746-a74a91c5c2e0"), 0 },
                    { new Guid("d5c65161-7591-48c1-9198-daca163bce2c"), "presp8pw_01.jpg", new Guid("1eaaba04-80ff-43a6-a746-a74a91c5c2e1"), 0 },
                    { new Guid("d5c65161-7591-48c1-9198-daca163bce3c"), "presp8pw_cat.jpg", new Guid("1eaaba04-80ff-43a6-a746-a74a91c5c2e1"), 0 },
                    { new Guid("d5c65161-7591-48c1-9198-daca163bce4c"), "presp8pw_01.jpg", new Guid("1eaaba04-80ff-43a6-a746-a74a91c5c2e2"), 0 },
                    { new Guid("d5c65161-7591-48c1-9198-daca163bce5c"), "presp8pw_cat.jpg", new Guid("1eaaba04-80ff-43a6-a746-a74a91c5c2e2"), 0 },
                    { new Guid("d5c65161-7591-48c1-9198-daca163bce6c"), "presp8pw_01.jpg", new Guid("1eaaba04-80ff-43a6-a746-a74a91c5c2e3"), 0 },
                    { new Guid("d5c65161-7591-48c1-9198-daca163bce7c"), "presp8pw_cat.jpg", new Guid("1eaaba04-80ff-43a6-a746-a74a91c5c2e3"), 0 },
                    { new Guid("d5c65161-7591-48c1-9198-daca163bce8c"), "presp8pw_01.jpg", new Guid("1eaaba04-80ff-43a6-a746-a74a91c5c2e4"), 0 },
                    { new Guid("d5c65161-7591-48c1-9198-daca163bce9c"), "presp8pw_cat.jpg", new Guid("1eaaba04-80ff-43a6-a746-a74a91c5c2e4"), 0 },
                    { new Guid("d5c65161-7591-48c1-9198-daca164bce0c"), "presp8pw_01.jpg", new Guid("1eaaba04-80ff-43a6-a746-a74a91c5c2e5"), 0 },
                    { new Guid("d5c65161-7591-48c1-9198-daca164bce1c"), "presp8pw_cat.jpg", new Guid("1eaaba04-80ff-43a6-a746-a74a91c5c2e5"), 0 },
                    { new Guid("d5c65161-7591-48c1-9198-daca164bce2c"), "presp8pw_01.jpg", new Guid("1eaaba04-80ff-43a6-a746-a74a91c5c2e6"), 0 },
                    { new Guid("d5c65161-7591-48c1-9198-daca164bce3c"), "presp8pw_cat.jpg", new Guid("1eaaba04-80ff-43a6-a746-a74a91c5c2e6"), 0 },
                    { new Guid("d5c65161-7591-48c1-9198-daca164bce4c"), "presp8pw_01.jpg", new Guid("1eaaba04-80ff-43a6-a746-a74a91c5c2e7"), 0 },
                    { new Guid("d5c65161-7591-48c1-9198-daca164bce5c"), "presp8pw_cat.jpg", new Guid("1eaaba04-80ff-43a6-a746-a74a91c5c2e7"), 0 },
                    { new Guid("d5c65161-7591-48c1-9198-daca164bce6c"), "presp8pw_01.jpg", new Guid("1eaaba04-80ff-43a6-a746-a74a91c5c2e8"), 0 },
                    { new Guid("d5c65161-7591-48c1-9198-daca164bce7c"), "presp8pw_cat.jpg", new Guid("1eaaba04-80ff-43a6-a746-a74a91c5c2e8"), 0 },
                    { new Guid("d5c65161-7591-48c1-9198-daca164bce8c"), "presp8pw_01.jpg", new Guid("1eaaba04-80ff-43a6-a746-a74a91c5c2e9"), 0 },
                    { new Guid("d5c65161-7591-48c1-9198-daca164bce9c"), "presp8pw_cat.jpg", new Guid("1eaaba04-80ff-43a6-a746-a74a91c5c2e9"), 0 },
                    { new Guid("d5c65161-7591-48c1-9198-daca165bce0c"), "presp8pw_01.jpg", new Guid("1eaaba04-80ff-43a6-a746-a74a91c5c3e0"), 0 },
                    { new Guid("d5c65161-7591-48c1-9198-daca165bce1c"), "presp8pw_cat.jpg", new Guid("1eaaba04-80ff-43a6-a746-a74a91c5c3e0"), 0 },
                    { new Guid("d5c65161-7591-48c1-9198-daca165bce2c"), "presp8pw_01.jpg", new Guid("1eaaba04-80ff-43a6-a746-a74a91c5c3e1"), 0 },
                    { new Guid("d5c65161-7591-48c1-9198-daca165bce3c"), "presp8pw_cat.jpg", new Guid("1eaaba04-80ff-43a6-a746-a74a91c5c3e1"), 0 },
                    { new Guid("d5c65161-7591-48c1-9198-daca165bce4c"), "presp8pw_01.jpg", new Guid("1eaaba04-80ff-43a6-a746-a74a91c5c3e2"), 0 },
                    { new Guid("d5c65161-7591-48c1-9198-daca165bce5c"), "presp8pw_cat.jpg", new Guid("1eaaba04-80ff-43a6-a746-a74a91c5c3e2"), 0 },
                    { new Guid("d5c65161-7591-48c1-9198-daca165bce6c"), "presp8pw_01.jpg", new Guid("1eaaba04-80ff-43a6-a746-a74a91c5c3e3"), 0 },
                    { new Guid("d5c65161-7591-48c1-9198-daca166bce7c"), "presp8pw_cat.jpg", new Guid("1eaaba04-80ff-43a6-a746-a74a91c5c3e3"), 0 },
                    { new Guid("d5c65161-7591-48c1-9198-daca166bce8c"), "presp8pw_01.jpg", new Guid("1eaaba04-80ff-43a6-a746-a74a91c5c3e4"), 0 },
                    { new Guid("d5c65161-7591-48c1-9198-daca166bce9c"), "presp8pw_cat.jpg", new Guid("1eaaba04-80ff-43a6-a746-a74a91c5c3e4"), 0 },
                    { new Guid("d5c65161-7591-48c1-9198-daca167bce0c"), "presp8pw_01.jpg", new Guid("1eaaba04-80ff-43a6-a746-a74a91c5c3e5"), 0 },
                    { new Guid("d5c65161-7591-48c1-9198-daca167bce1c"), "presp8pw_cat.jpg", new Guid("1eaaba04-80ff-43a6-a746-a74a91c5c3e5"), 0 },
                    { new Guid("d5c65161-7591-48c1-9198-daca167bce2c"), "presp8pw_01.jpg", new Guid("1eaaba04-80ff-43a6-a746-a74a91c5c3e6"), 0 },
                    { new Guid("d5c65161-7591-48c1-9198-daca167bce3c"), "presp8pw_cat.jpg", new Guid("1eaaba04-80ff-43a6-a746-a74a91c5c3e6"), 0 },
                    { new Guid("d5c65161-7591-48c1-9198-daca167bce4c"), "presp8pw_01.jpg", new Guid("1eaaba04-80ff-43a6-a746-a74a91c5c3e7"), 0 },
                    { new Guid("d5c65161-7591-48c1-9198-daca167bce5c"), "presp8pw_cat.jpg", new Guid("1eaaba04-80ff-43a6-a746-a74a91c5c3e7"), 0 },
                    { new Guid("d5c65161-7591-48c1-9198-daca167bce6c"), "presp8pw_01.jpg", new Guid("1eaaba04-80ff-43a6-a746-a74a91c5c3e8"), 0 },
                    { new Guid("d5c65161-7591-48c1-9198-daca167bce7c"), "presp8pw_cat.jpg", new Guid("1eaaba04-80ff-43a6-a746-a74a91c5c3e8"), 0 }
                });

            migrationBuilder.InsertData(
                table: "ProductImages",
                columns: new[] { "Id", "Name", "ProductDetailId", "Status" },
                values: new object[,]
                {
                    { new Guid("d5c65161-7591-48c1-9198-daca167bce8c"), "presp8pw_01.jpg", new Guid("1eaaba04-80ff-43a6-a746-a74a91c5c3e9"), 0 },
                    { new Guid("d5c65161-7591-48c1-9198-daca167bce9c"), "presp8pw_cat.jpg", new Guid("1eaaba04-80ff-43a6-a746-a74a91c5c3e9"), 0 },
                    { new Guid("d5c65161-7591-48c1-9198-daca168bce0c"), "presp8pw_01.jpg", new Guid("1eaaba04-80ff-43a6-a746-a74a91c6c0e0"), 0 },
                    { new Guid("d5c65161-7591-48c1-9198-daca168bce1c"), "presp8pw_cat.jpg", new Guid("1eaaba04-80ff-43a6-a746-a74a91c6c0e0"), 0 },
                    { new Guid("d5c65161-7591-48c1-9198-daca168bce2c"), "presp8pw_01.jpg", new Guid("1eaaba04-80ff-43a6-a746-a74a91c6c0e1"), 0 },
                    { new Guid("d5c65161-7591-48c1-9198-daca168bce3c"), "presp8pw_cat.jpg", new Guid("1eaaba04-80ff-43a6-a746-a74a91c6c0e1"), 0 },
                    { new Guid("d5c65161-7591-48c1-9198-daca168bce4c"), "presp8pw_01.jpg", new Guid("1eaaba04-80ff-43a6-a746-a74a91c6c0e2"), 0 },
                    { new Guid("d5c65161-7591-48c1-9198-daca168bce5c"), "presp8pw_cat.jpg", new Guid("1eaaba04-80ff-43a6-a746-a74a91c6c0e2"), 0 },
                    { new Guid("d5c65161-7591-48c1-9198-daca168bce6c"), "presp8pw_01.jpg", new Guid("1eaaba04-80ff-43a6-a746-a74a91c6c0e3"), 0 },
                    { new Guid("d5c65161-7591-48c1-9198-daca168bce7c"), "presp8pw_cat.jpg", new Guid("1eaaba04-80ff-43a6-a746-a74a91c6c0e3"), 0 },
                    { new Guid("d5c65161-7591-48c1-9198-daca168bce8c"), "presp8pw_01.jpg", new Guid("1eaaba04-80ff-43a6-a746-a74a91c6c0e4"), 0 },
                    { new Guid("d5c65161-7591-48c1-9198-daca168bce9c"), "presp8pw_cat.jpg", new Guid("1eaaba04-80ff-43a6-a746-a74a91c6c0e4"), 0 },
                    { new Guid("d5c65161-7591-48c1-9198-daca169bce0c"), "presp8pw_01.jpg", new Guid("1eaaba04-80ff-43a6-a746-a74a91c6c0e5"), 0 },
                    { new Guid("d5c65161-7591-48c1-9198-daca169bce1c"), "presp8pw_cat.jpg", new Guid("1eaaba04-80ff-43a6-a746-a74a91c6c0e5"), 0 },
                    { new Guid("d5c65161-7591-48c1-9198-daca169bce2c"), "presp8pw_01.jpg", new Guid("1eaaba04-80ff-43a6-a746-a74a91c6c0e6"), 0 },
                    { new Guid("d5c65161-7591-48c1-9198-daca169bce3c"), "presp8pw_cat.jpg", new Guid("1eaaba04-80ff-43a6-a746-a74a91c6c0e6"), 0 },
                    { new Guid("d5c65161-7591-48c1-9198-daca169bce4c"), "presp8pw_01.jpg", new Guid("1eaaba04-80ff-43a6-a746-a74a91c6c0e7"), 0 },
                    { new Guid("d5c65161-7591-48c1-9198-daca169bce5c"), "presp8pw_cat.jpg", new Guid("1eaaba04-80ff-43a6-a746-a74a91c6c0e7"), 0 },
                    { new Guid("d5c65161-7591-48c1-9198-daca169bce6c"), "presp8pw_01.jpg", new Guid("1eaaba04-80ff-43a6-a746-a74a91c6c0e8"), 0 },
                    { new Guid("d5c65161-7591-48c1-9198-daca169bce7c"), "presp8pw_cat.jpg", new Guid("1eaaba04-80ff-43a6-a746-a74a91c6c0e8"), 0 },
                    { new Guid("d5c65161-7591-48c1-9198-daca169bce8c"), "presp8pw_01.jpg", new Guid("1eaaba04-80ff-43a6-a746-a74a91c6c0e9"), 0 },
                    { new Guid("d5c65161-7591-48c1-9198-daca169bce9c"), "presp8pw_cat.jpg", new Guid("1eaaba04-80ff-43a6-a746-a74a91c6c0e9"), 0 },
                    { new Guid("d5c65161-7591-48c1-9198-daca170bce0c"), "presp8pw_01.jpg", new Guid("1eaaba04-80ff-43a6-a746-a74a91c6c1e0"), 0 },
                    { new Guid("d5c65161-7591-48c1-9198-daca170bce1c"), "presp8pw_cat.jpg", new Guid("1eaaba04-80ff-43a6-a746-a74a91c6c1e0"), 0 },
                    { new Guid("d5c65161-7591-48c1-9198-daca170bce2c"), "presp8pw_01.jpg", new Guid("1eaaba04-80ff-43a6-a746-a74a91c6c1e1"), 0 },
                    { new Guid("d5c65161-7591-48c1-9198-daca170bce3c"), "presp8pw_cat.jpg", new Guid("1eaaba04-80ff-43a6-a746-a74a91c6c1e1"), 0 },
                    { new Guid("d5c65161-7591-48c1-9198-daca170bce4c"), "presp8pw_01.jpg", new Guid("1eaaba04-80ff-43a6-a746-a74a91c6c1e2"), 0 },
                    { new Guid("d5c65161-7591-48c1-9198-daca170bce5c"), "presp8pw_cat.jpg", new Guid("1eaaba04-80ff-43a6-a746-a74a91c6c1e2"), 0 },
                    { new Guid("d5c65161-7591-48c1-9198-daca170bce6c"), "presp8pw_01.jpg", new Guid("1eaaba04-80ff-43a6-a746-a74a91c6c1e3"), 0 },
                    { new Guid("d5c65161-7591-48c1-9198-daca170bce7c"), "presp8pw_cat.jpg", new Guid("1eaaba04-80ff-43a6-a746-a74a91c6c1e3"), 0 },
                    { new Guid("d5c65161-7591-48c1-9198-daca170bce8c"), "presp8pw_01.jpg", new Guid("1eaaba04-80ff-43a6-a746-a74a91c6c1e4"), 0 },
                    { new Guid("d5c65161-7591-48c1-9198-daca170bce9c"), "presp8pw_cat.jpg", new Guid("1eaaba04-80ff-43a6-a746-a74a91c6c1e4"), 0 },
                    { new Guid("d5c65161-7591-48c1-9198-daca171bce0c"), "presp8pw_01.jpg", new Guid("1eaaba04-80ff-43a6-a746-a74a91c6c1e5"), 0 },
                    { new Guid("d5c65161-7591-48c1-9198-daca171bce1c"), "presp8pw_cat.jpg", new Guid("1eaaba04-80ff-43a6-a746-a74a91c6c1e5"), 0 },
                    { new Guid("d5c65161-7591-48c1-9198-daca171bce2c"), "presp8pw_01.jpg", new Guid("1eaaba04-80ff-43a6-a746-a74a91c6c1e6"), 0 },
                    { new Guid("d5c65161-7591-48c1-9198-daca171bce3c"), "presp8pw_cat.jpg", new Guid("1eaaba04-80ff-43a6-a746-a74a91c6c1e6"), 0 },
                    { new Guid("d5c65161-7591-48c1-9198-daca171bce4c"), "presp8pw_01.jpg", new Guid("1eaaba04-80ff-43a6-a746-a74a91c6c1e7"), 0 },
                    { new Guid("d5c65161-7591-48c1-9198-daca171bce5c"), "presp8pw_cat.jpg", new Guid("1eaaba04-80ff-43a6-a746-a74a91c6c1e7"), 0 },
                    { new Guid("d5c65161-7591-48c1-9198-daca171bce6c"), "presp8pw_01.jpg", new Guid("1eaaba04-80ff-43a6-a746-a74a91c6c1e8"), 0 },
                    { new Guid("d5c65161-7591-48c1-9198-daca171bce7c"), "presp8pw_cat.jpg", new Guid("1eaaba04-80ff-43a6-a746-a74a91c6c1e8"), 0 },
                    { new Guid("d5c65161-7591-48c1-9198-daca171bce8c"), "presp8pw_01.jpg", new Guid("1eaaba04-80ff-43a6-a746-a74a91c6c1e9"), 0 },
                    { new Guid("d5c65161-7591-48c1-9198-daca171bce9c"), "presp8pw_cat.jpg", new Guid("1eaaba04-80ff-43a6-a746-a74a91c6c1e9"), 0 }
                });

            migrationBuilder.InsertData(
                table: "ProductImages",
                columns: new[] { "Id", "Name", "ProductDetailId", "Status" },
                values: new object[,]
                {
                    { new Guid("d5c65161-7591-48c1-9198-daca172bce0c"), "presp8pw_01.jpg", new Guid("1eaaba04-80ff-43a6-a746-a74a91c6c2e0"), 0 },
                    { new Guid("d5c65161-7591-48c1-9198-daca172bce1c"), "presp8pw_cat.jpg", new Guid("1eaaba04-80ff-43a6-a746-a74a91c6c2e0"), 0 },
                    { new Guid("d5c65161-7591-48c1-9198-daca172bce2c"), "presp8pw_01.jpg", new Guid("1eaaba04-80ff-43a6-a746-a74a91c6c2e1"), 0 },
                    { new Guid("d5c65161-7591-48c1-9198-daca172bce3c"), "presp8pw_cat.jpg", new Guid("1eaaba04-80ff-43a6-a746-a74a91c6c2e1"), 0 },
                    { new Guid("d5c65161-7591-48c1-9198-daca172bce4c"), "presp8pw_01.jpg", new Guid("1eaaba04-80ff-43a6-a746-a74a91c6c2e2"), 0 },
                    { new Guid("d5c65161-7591-48c1-9198-daca172bce5c"), "presp8pw_cat.jpg", new Guid("1eaaba04-80ff-43a6-a746-a74a91c6c2e2"), 0 },
                    { new Guid("d5c65161-7591-48c1-9198-daca172bce6c"), "presp8pw_01.jpg", new Guid("1eaaba04-80ff-43a6-a746-a74a91c6c2e3"), 0 },
                    { new Guid("d5c65161-7591-48c1-9198-daca172bce7c"), "presp8pw_cat.jpg", new Guid("1eaaba04-80ff-43a6-a746-a74a91c6c2e3"), 0 },
                    { new Guid("d5c65161-7591-48c1-9198-daca172bce8c"), "presp8pw_01.jpg", new Guid("1eaaba04-80ff-43a6-a746-a74a91c6c2e4"), 0 },
                    { new Guid("d5c65161-7591-48c1-9198-daca172bce9c"), "presp8pw_cat.jpg", new Guid("1eaaba04-80ff-43a6-a746-a74a91c6c2e4"), 0 },
                    { new Guid("d5c65161-7591-48c1-9198-daca173bce0c"), "presp8pw_01.jpg", new Guid("1eaaba04-80ff-43a6-a746-a74a91c6c2e5"), 0 },
                    { new Guid("d5c65161-7591-48c1-9198-daca173bce1c"), "presp8pw_cat.jpg", new Guid("1eaaba04-80ff-43a6-a746-a74a91c6c2e5"), 0 },
                    { new Guid("d5c65161-7591-48c1-9198-daca173bce2c"), "presp8pw_01.jpg", new Guid("1eaaba04-80ff-43a6-a746-a74a91c6c2e6"), 0 },
                    { new Guid("d5c65161-7591-48c1-9198-daca173bce3c"), "presp8pw_cat.jpg", new Guid("1eaaba04-80ff-43a6-a746-a74a91c6c2e6"), 0 },
                    { new Guid("d5c65161-7591-48c1-9198-daca173bce4c"), "presp8pw_01.jpg", new Guid("1eaaba04-80ff-43a6-a746-a74a91c6c2e7"), 0 },
                    { new Guid("d5c65161-7591-48c1-9198-daca173bce5c"), "presp8pw_cat.jpg", new Guid("1eaaba04-80ff-43a6-a746-a74a91c6c2e7"), 0 },
                    { new Guid("d5c65161-7591-48c1-9198-daca173bce6c"), "presp8pw_01.jpg", new Guid("1eaaba04-80ff-43a6-a746-a74a91c6c2e8"), 0 },
                    { new Guid("d5c65161-7591-48c1-9198-daca173bce7c"), "presp8pw_cat.jpg", new Guid("1eaaba04-80ff-43a6-a746-a74a91c6c2e8"), 0 },
                    { new Guid("d5c65161-7591-48c1-9198-daca173bce8c"), "presp8pw_01.jpg", new Guid("1eaaba04-80ff-43a6-a746-a74a91c6c2e9"), 0 },
                    { new Guid("d5c65161-7591-48c1-9198-daca173bce9c"), "presp8pw_cat.jpg", new Guid("1eaaba04-80ff-43a6-a746-a74a91c6c2e9"), 0 },
                    { new Guid("d5c65161-7591-48c1-9198-daca174bce0c"), "presp8pw_01.jpg", new Guid("1eaaba04-80ff-43a6-a746-a74a91c6c3e0"), 0 },
                    { new Guid("d5c65161-7591-48c1-9198-daca174bce1c"), "presp8pw_cat.jpg", new Guid("1eaaba04-80ff-43a6-a746-a74a91c6c3e0"), 0 },
                    { new Guid("d5c65161-7591-48c1-9198-daca174bce2c"), "presp8pw_01.jpg", new Guid("1eaaba04-80ff-43a6-a746-a74a91c6c3e1"), 0 },
                    { new Guid("d5c65161-7591-48c1-9198-daca174bce3c"), "presp8pw_cat.jpg", new Guid("1eaaba04-80ff-43a6-a746-a74a91c6c3e1"), 0 },
                    { new Guid("d5c65161-7591-48c1-9198-daca174bce4c"), "presp8pw_01.jpg", new Guid("1eaaba04-80ff-43a6-a746-a74a91c6c3e2"), 0 },
                    { new Guid("d5c65161-7591-48c1-9198-daca174bce5c"), "presp8pw_cat.jpg", new Guid("1eaaba04-80ff-43a6-a746-a74a91c6c3e2"), 0 },
                    { new Guid("d5c65161-7591-48c1-9198-daca174bce6c"), "presp8pw_01.jpg", new Guid("1eaaba04-80ff-43a6-a746-a74a91c6c3e3"), 0 },
                    { new Guid("d5c65161-7591-48c1-9198-daca174bce7c"), "presp8pw_cat.jpg", new Guid("1eaaba04-80ff-43a6-a746-a74a91c6c3e3"), 0 },
                    { new Guid("d5c65161-7591-48c1-9198-daca174bce8c"), "presp8pw_01.jpg", new Guid("1eaaba04-80ff-43a6-a746-a74a91c6c3e4"), 0 },
                    { new Guid("d5c65161-7591-48c1-9198-daca174bce9c"), "presp8pw_cat.jpg", new Guid("1eaaba04-80ff-43a6-a746-a74a91c6c3e4"), 0 },
                    { new Guid("d5c65161-7591-48c1-9198-daca175bce0c"), "presp8pw_01.jpg", new Guid("1eaaba04-80ff-43a6-a746-a74a91c6c3e5"), 0 },
                    { new Guid("d5c65161-7591-48c1-9198-daca175bce1c"), "presp8pw_cat.jpg", new Guid("1eaaba04-80ff-43a6-a746-a74a91c6c3e5"), 0 },
                    { new Guid("d5c65161-7591-48c1-9198-daca175bce2c"), "presp8pw_01.jpg", new Guid("1eaaba04-80ff-43a6-a746-a74a91c6c3e6"), 0 },
                    { new Guid("d5c65161-7591-48c1-9198-daca175bce3c"), "presp8pw_cat.jpg", new Guid("1eaaba04-80ff-43a6-a746-a74a91c6c3e6"), 0 },
                    { new Guid("d5c65161-7591-48c1-9198-daca175bce4c"), "presp8pw_01.jpg", new Guid("1eaaba04-80ff-43a6-a746-a74a91c6c3e7"), 0 },
                    { new Guid("d5c65161-7591-48c1-9198-daca175bce5c"), "presp8pw_cat.jpg", new Guid("1eaaba04-80ff-43a6-a746-a74a91c6c3e7"), 0 },
                    { new Guid("d5c65161-7591-48c1-9198-daca175bce6c"), "presp8pw_01.jpg", new Guid("1eaaba04-80ff-43a6-a746-a74a91c6c3e8"), 0 },
                    { new Guid("d5c65161-7591-48c1-9198-daca175bce7c"), "presp8pw_cat.jpg", new Guid("1eaaba04-80ff-43a6-a746-a74a91c6c3e8"), 0 },
                    { new Guid("d5c65161-7591-48c1-9198-daca175bce8c"), "presp8pw_01.jpg", new Guid("1eaaba04-80ff-43a6-a746-a74a91c6c3e9"), 0 },
                    { new Guid("d5c65161-7591-48c1-9198-daca175bce9c"), "presp8pw_cat.jpg", new Guid("1eaaba04-80ff-43a6-a746-a74a91c6c3e9"), 0 },
                    { new Guid("d5c65161-7591-48c1-9198-daca176bce0c"), "presp8pw_01.jpg", new Guid("1eaaba04-80ff-43a6-a746-a74a91c7c0e0"), 0 },
                    { new Guid("d5c65161-7591-48c1-9198-daca176bce1c"), "presp8pw_cat.jpg", new Guid("1eaaba04-80ff-43a6-a746-a74a91c7c0e0"), 0 }
                });

            migrationBuilder.InsertData(
                table: "ProductImages",
                columns: new[] { "Id", "Name", "ProductDetailId", "Status" },
                values: new object[,]
                {
                    { new Guid("d5c65161-7591-48c1-9198-daca176bce2c"), "presp8pw_01.jpg", new Guid("1eaaba04-80ff-43a6-a746-a74a91c7c0e1"), 0 },
                    { new Guid("d5c65161-7591-48c1-9198-daca176bce3c"), "presp8pw_cat.jpg", new Guid("1eaaba04-80ff-43a6-a746-a74a91c7c0e1"), 0 },
                    { new Guid("d5c65161-7591-48c1-9198-daca176bce4c"), "presp8pw_01.jpg", new Guid("1eaaba04-80ff-43a6-a746-a74a91c7c0e2"), 0 },
                    { new Guid("d5c65161-7591-48c1-9198-daca176bce5c"), "presp8pw_cat.jpg", new Guid("1eaaba04-80ff-43a6-a746-a74a91c7c0e2"), 0 },
                    { new Guid("d5c65161-7591-48c1-9198-daca176bce6c"), "presp8pw_01.jpg", new Guid("1eaaba04-80ff-43a6-a746-a74a91c7c0e3"), 0 },
                    { new Guid("d5c65161-7591-48c1-9198-daca176bce7c"), "presp8pw_cat.jpg", new Guid("1eaaba04-80ff-43a6-a746-a74a91c7c0e3"), 0 },
                    { new Guid("d5c65161-7591-48c1-9198-daca176bce8c"), "presp8pw_01.jpg", new Guid("1eaaba04-80ff-43a6-a746-a74a91c7c0e4"), 0 },
                    { new Guid("d5c65161-7591-48c1-9198-daca176bce9c"), "presp8pw_cat.jpg", new Guid("1eaaba04-80ff-43a6-a746-a74a91c7c0e4"), 0 },
                    { new Guid("d5c65161-7591-48c1-9198-daca177bce0c"), "presp8pw_01.jpg", new Guid("1eaaba04-80ff-43a6-a746-a74a91c7c0e5"), 0 },
                    { new Guid("d5c65161-7591-48c1-9198-daca177bce1c"), "presp8pw_cat.jpg", new Guid("1eaaba04-80ff-43a6-a746-a74a91c7c0e5"), 0 },
                    { new Guid("d5c65161-7591-48c1-9198-daca177bce2c"), "presp8pw_01.jpg", new Guid("1eaaba04-80ff-43a6-a746-a74a91c7c0e6"), 0 },
                    { new Guid("d5c65161-7591-48c1-9198-daca177bce3c"), "presp8pw_cat.jpg", new Guid("1eaaba04-80ff-43a6-a746-a74a91c7c0e6"), 0 },
                    { new Guid("d5c65161-7591-48c1-9198-daca177bce4c"), "presp8pw_01.jpg", new Guid("1eaaba04-80ff-43a6-a746-a74a91c7c0e7"), 0 },
                    { new Guid("d5c65161-7591-48c1-9198-daca177bce5c"), "presp8pw_cat.jpg", new Guid("1eaaba04-80ff-43a6-a746-a74a91c7c0e7"), 0 },
                    { new Guid("d5c65161-7591-48c1-9198-daca177bce6c"), "presp8pw_01.jpg", new Guid("1eaaba04-80ff-43a6-a746-a74a91c7c0e8"), 0 },
                    { new Guid("d5c65161-7591-48c1-9198-daca177bce7c"), "presp8pw_cat.jpg", new Guid("1eaaba04-80ff-43a6-a746-a74a91c7c0e8"), 0 },
                    { new Guid("d5c65161-7591-48c1-9198-daca177bce8c"), "presp8pw_01.jpg", new Guid("1eaaba04-80ff-43a6-a746-a74a91c7c0e9"), 0 },
                    { new Guid("d5c65161-7591-48c1-9198-daca177bce9c"), "presp8pw_cat.jpg", new Guid("1eaaba04-80ff-43a6-a746-a74a91c7c0e9"), 0 },
                    { new Guid("d5c65161-7591-48c1-9198-daca178bce0c"), "presp8pw_01.jpg", new Guid("1eaaba04-80ff-43a6-a746-a74a91c7c1e0"), 0 },
                    { new Guid("d5c65161-7591-48c1-9198-daca178bce1c"), "presp8pw_cat.jpg", new Guid("1eaaba04-80ff-43a6-a746-a74a91c7c1e0"), 0 },
                    { new Guid("d5c65161-7591-48c1-9198-daca178bce2c"), "presp8pw_01.jpg", new Guid("1eaaba04-80ff-43a6-a746-a74a91c7c1e1"), 0 },
                    { new Guid("d5c65161-7591-48c1-9198-daca178bce3c"), "presp8pw_cat.jpg", new Guid("1eaaba04-80ff-43a6-a746-a74a91c7c1e1"), 0 },
                    { new Guid("d5c65161-7591-48c1-9198-daca178bce4c"), "presp8pw_01.jpg", new Guid("1eaaba04-80ff-43a6-a746-a74a91c7c1e2"), 0 },
                    { new Guid("d5c65161-7591-48c1-9198-daca178bce5c"), "presp8pw_cat.jpg", new Guid("1eaaba04-80ff-43a6-a746-a74a91c7c1e2"), 0 },
                    { new Guid("d5c65161-7591-48c1-9198-daca178bce6c"), "presp8pw_01.jpg", new Guid("1eaaba04-80ff-43a6-a746-a74a91c7c1e3"), 0 },
                    { new Guid("d5c65161-7591-48c1-9198-daca178bce7c"), "presp8pw_cat.jpg", new Guid("1eaaba04-80ff-43a6-a746-a74a91c7c1e3"), 0 },
                    { new Guid("d5c65161-7591-48c1-9198-daca178bce8c"), "presp8pw_01.jpg", new Guid("1eaaba04-80ff-43a6-a746-a74a91c7c1e4"), 0 },
                    { new Guid("d5c65161-7591-48c1-9198-daca178bce9c"), "presp8pw_cat.jpg", new Guid("1eaaba04-80ff-43a6-a746-a74a91c7c1e4"), 0 },
                    { new Guid("d5c65161-7591-48c1-9198-daca179bce0c"), "presp8pw_01.jpg", new Guid("1eaaba04-80ff-43a6-a746-a74a91c7c1e5"), 0 },
                    { new Guid("d5c65161-7591-48c1-9198-daca179bce1c"), "presp8pw_cat.jpg", new Guid("1eaaba04-80ff-43a6-a746-a74a91c7c1e5"), 0 },
                    { new Guid("d5c65161-7591-48c1-9198-daca179bce2c"), "presp8pw_01.jpg", new Guid("1eaaba04-80ff-43a6-a746-a74a91c7c1e6"), 0 },
                    { new Guid("d5c65161-7591-48c1-9198-daca179bce3c"), "presp8pw_cat.jpg", new Guid("1eaaba04-80ff-43a6-a746-a74a91c7c1e6"), 0 },
                    { new Guid("d5c65161-7591-48c1-9198-daca179bce4c"), "presp8pw_01.jpg", new Guid("1eaaba04-80ff-43a6-a746-a74a91c7c1e7"), 0 },
                    { new Guid("d5c65161-7591-48c1-9198-daca179bce5c"), "presp8pw_cat.jpg", new Guid("1eaaba04-80ff-43a6-a746-a74a91c7c1e7"), 0 },
                    { new Guid("d5c65161-7591-48c1-9198-daca179bce6c"), "presp8pw_01.jpg", new Guid("1eaaba04-80ff-43a6-a746-a74a91c7c1e8"), 0 },
                    { new Guid("d5c65161-7591-48c1-9198-daca179bce7c"), "presp8pw_cat.jpg", new Guid("1eaaba04-80ff-43a6-a746-a74a91c7c1e8"), 0 },
                    { new Guid("d5c65161-7591-48c1-9198-daca179bce8c"), "presp8pw_01.jpg", new Guid("1eaaba04-80ff-43a6-a746-a74a91c7c1e9"), 0 },
                    { new Guid("d5c65161-7591-48c1-9198-daca179bce9c"), "presp8pw_cat.jpg", new Guid("1eaaba04-80ff-43a6-a746-a74a91c7c1e9"), 0 },
                    { new Guid("d5c65161-7591-48c1-9198-daca180bce0c"), "presp8pw_01.jpg", new Guid("1eaaba04-80ff-43a6-a746-a74a91c7c2e0"), 0 },
                    { new Guid("d5c65161-7591-48c1-9198-daca180bce1c"), "presp8pw_cat.jpg", new Guid("1eaaba04-80ff-43a6-a746-a74a91c7c2e0"), 0 },
                    { new Guid("d5c65161-7591-48c1-9198-daca180bce2c"), "presp8pw_01.jpg", new Guid("1eaaba04-80ff-43a6-a746-a74a91c7c2e1"), 0 },
                    { new Guid("d5c65161-7591-48c1-9198-daca180bce3c"), "presp8pw_cat.jpg", new Guid("1eaaba04-80ff-43a6-a746-a74a91c7c2e1"), 0 }
                });

            migrationBuilder.InsertData(
                table: "ProductImages",
                columns: new[] { "Id", "Name", "ProductDetailId", "Status" },
                values: new object[,]
                {
                    { new Guid("d5c65161-7591-48c1-9198-daca180bce4c"), "presp8pw_01.jpg", new Guid("1eaaba04-80ff-43a6-a746-a74a91c7c2e2"), 0 },
                    { new Guid("d5c65161-7591-48c1-9198-daca180bce5c"), "presp8pw_cat.jpg", new Guid("1eaaba04-80ff-43a6-a746-a74a91c7c2e2"), 0 },
                    { new Guid("d5c65161-7591-48c1-9198-daca180bce6c"), "presp8pw_01.jpg", new Guid("1eaaba04-80ff-43a6-a746-a74a91c7c2e3"), 0 },
                    { new Guid("d5c65161-7591-48c1-9198-daca180bce7c"), "presp8pw_cat.jpg", new Guid("1eaaba04-80ff-43a6-a746-a74a91c7c2e3"), 0 },
                    { new Guid("d5c65161-7591-48c1-9198-daca180bce8c"), "presp8pw_01.jpg", new Guid("1eaaba04-80ff-43a6-a746-a74a91c7c2e4"), 0 },
                    { new Guid("d5c65161-7591-48c1-9198-daca180bce9c"), "presp8pw_cat.jpg", new Guid("1eaaba04-80ff-43a6-a746-a74a91c7c2e4"), 0 },
                    { new Guid("d5c65161-7591-48c1-9198-daca181bce0c"), "presp8pw_01.jpg", new Guid("1eaaba04-80ff-43a6-a746-a74a91c7c2e5"), 0 },
                    { new Guid("d5c65161-7591-48c1-9198-daca181bce1c"), "presp8pw_cat.jpg", new Guid("1eaaba04-80ff-43a6-a746-a74a91c7c2e5"), 0 },
                    { new Guid("d5c65161-7591-48c1-9198-daca181bce2c"), "presp8pw_01.jpg", new Guid("1eaaba04-80ff-43a6-a746-a74a91c7c2e6"), 0 },
                    { new Guid("d5c65161-7591-48c1-9198-daca181bce3c"), "presp8pw_cat.jpg", new Guid("1eaaba04-80ff-43a6-a746-a74a91c7c2e6"), 0 },
                    { new Guid("d5c65161-7591-48c1-9198-daca181bce4c"), "presp8pw_01.jpg", new Guid("1eaaba04-80ff-43a6-a746-a74a91c7c2e7"), 0 },
                    { new Guid("d5c65161-7591-48c1-9198-daca181bce5c"), "presp8pw_cat.jpg", new Guid("1eaaba04-80ff-43a6-a746-a74a91c7c2e7"), 0 },
                    { new Guid("d5c65161-7591-48c1-9198-daca181bce6c"), "presp8pw_01.jpg", new Guid("1eaaba04-80ff-43a6-a746-a74a91c7c2e8"), 0 },
                    { new Guid("d5c65161-7591-48c1-9198-daca181bce7c"), "presp8pw_cat.jpg", new Guid("1eaaba04-80ff-43a6-a746-a74a91c7c2e8"), 0 },
                    { new Guid("d5c65161-7591-48c1-9198-daca181bce8c"), "presp8pw_01.jpg", new Guid("1eaaba04-80ff-43a6-a746-a74a91c7c2e9"), 0 },
                    { new Guid("d5c65161-7591-48c1-9198-daca181bce9c"), "presp8pw_cat.jpg", new Guid("1eaaba04-80ff-43a6-a746-a74a91c7c2e9"), 0 },
                    { new Guid("d5c65161-7591-48c1-9198-daca182bce0c"), "presp8pw_01.jpg", new Guid("1eaaba04-80ff-43a6-a746-a74a91c7c3e0"), 0 },
                    { new Guid("d5c65161-7591-48c1-9198-daca182bce1c"), "presp8pw_cat.jpg", new Guid("1eaaba04-80ff-43a6-a746-a74a91c7c3e0"), 0 },
                    { new Guid("d5c65161-7591-48c1-9198-daca182bce2c"), "presp8pw_01.jpg", new Guid("1eaaba04-80ff-43a6-a746-a74a91c7c3e1"), 0 },
                    { new Guid("d5c65161-7591-48c1-9198-daca182bce3c"), "presp8pw_cat.jpg", new Guid("1eaaba04-80ff-43a6-a746-a74a91c7c3e1"), 0 },
                    { new Guid("d5c65161-7591-48c1-9198-daca182bce4c"), "presp8pw_01.jpg", new Guid("1eaaba04-80ff-43a6-a746-a74a91c7c3e2"), 0 },
                    { new Guid("d5c65161-7591-48c1-9198-daca182bce5c"), "presp8pw_cat.jpg", new Guid("1eaaba04-80ff-43a6-a746-a74a91c7c3e2"), 0 },
                    { new Guid("d5c65161-7591-48c1-9198-daca182bce6c"), "presp8pw_01.jpg", new Guid("1eaaba04-80ff-43a6-a746-a74a91c7c3e3"), 0 },
                    { new Guid("d5c65161-7591-48c1-9198-daca182bce7c"), "presp8pw_cat.jpg", new Guid("1eaaba04-80ff-43a6-a746-a74a91c7c3e3"), 0 },
                    { new Guid("d5c65161-7591-48c1-9198-daca182bce8c"), "presp8pw_01.jpg", new Guid("1eaaba04-80ff-43a6-a746-a74a91c7c3e4"), 0 },
                    { new Guid("d5c65161-7591-48c1-9198-daca182bce9c"), "presp8pw_cat.jpg", new Guid("1eaaba04-80ff-43a6-a746-a74a91c7c3e4"), 0 },
                    { new Guid("d5c65161-7591-48c1-9198-daca183bce0c"), "presp8pw_01.jpg", new Guid("1eaaba04-80ff-43a6-a746-a74a91c7c3e5"), 0 },
                    { new Guid("d5c65161-7591-48c1-9198-daca183bce1c"), "presp8pw_cat.jpg", new Guid("1eaaba04-80ff-43a6-a746-a74a91c7c3e5"), 0 },
                    { new Guid("d5c65161-7591-48c1-9198-daca183bce2c"), "presp8pw_01.jpg", new Guid("1eaaba04-80ff-43a6-a746-a74a91c7c3e6"), 0 },
                    { new Guid("d5c65161-7591-48c1-9198-daca183bce3c"), "presp8pw_cat.jpg", new Guid("1eaaba04-80ff-43a6-a746-a74a91c7c3e6"), 0 },
                    { new Guid("d5c65161-7591-48c1-9198-daca183bce4c"), "presp8pw_01.jpg", new Guid("1eaaba04-80ff-43a6-a746-a74a91c7c3e7"), 0 },
                    { new Guid("d5c65161-7591-48c1-9198-daca183bce5c"), "presp8pw_cat.jpg", new Guid("1eaaba04-80ff-43a6-a746-a74a91c7c3e7"), 0 },
                    { new Guid("d5c65161-7591-48c1-9198-daca183bce6c"), "presp8pw_01.jpg", new Guid("1eaaba04-80ff-43a6-a746-a74a91c7c3e8"), 0 },
                    { new Guid("d5c65161-7591-48c1-9198-daca183bce7c"), "presp8pw_cat.jpg", new Guid("1eaaba04-80ff-43a6-a746-a74a91c7c3e8"), 0 },
                    { new Guid("d5c65161-7591-48c1-9198-daca183bce8c"), "presp8pw_01.jpg", new Guid("1eaaba04-80ff-43a6-a746-a74a91c7c3e9"), 0 },
                    { new Guid("d5c65161-7591-48c1-9198-daca183bce9c"), "presp8pw_cat.jpg", new Guid("1eaaba04-80ff-43a6-a746-a74a91c7c3e9"), 0 },
                    { new Guid("d5c65162-7591-48c1-9198-daca150bce0c"), "elbjgb_02.jpg", new Guid("2eaaba04-80ff-43a6-a746-a74a91c4c0e0"), 0 },
                    { new Guid("d5c65162-7591-48c1-9198-daca150bce1c"), "elbjgb-h2_01.jpg", new Guid("2eaaba04-80ff-43a6-a746-a74a91c4c0e0"), 0 },
                    { new Guid("d5c65162-7591-48c1-9198-daca150bce2c"), "elbjgb-h1_01.jpg", new Guid("2eaaba04-80ff-43a6-a746-a74a91c4c0e0"), 0 },
                    { new Guid("d5c65162-7591-48c1-9198-daca150bce3c"), "actxs-e_02_1_1.jpg", new Guid("2eaaba04-80ff-43a6-a746-a74a91c4c0e0"), 0 },
                    { new Guid("d5c65162-7591-48c1-9198-daca150bce4c"), "actxs-q_02.jpg", new Guid("2eaaba04-80ff-43a6-a746-a74a91c4c0e0"), 0 },
                    { new Guid("d5c65162-7591-48c1-9198-daca150bce5c"), "elbjgb_02.jpg", new Guid("2eaaba04-80ff-43a6-a746-a74a91c4c0e1"), 0 }
                });

            migrationBuilder.InsertData(
                table: "ProductImages",
                columns: new[] { "Id", "Name", "ProductDetailId", "Status" },
                values: new object[,]
                {
                    { new Guid("d5c65162-7591-48c1-9198-daca150bce6c"), "elbjgb-h2_01.jpg", new Guid("2eaaba04-80ff-43a6-a746-a74a91c4c0e1"), 0 },
                    { new Guid("d5c65162-7591-48c1-9198-daca150bce7c"), "elbjgb-h1_01.jpg", new Guid("2eaaba04-80ff-43a6-a746-a74a91c4c0e1"), 0 },
                    { new Guid("d5c65162-7591-48c1-9198-daca150bce8c"), "actxs-e_02_1_1.jpg", new Guid("2eaaba04-80ff-43a6-a746-a74a91c4c0e1"), 0 },
                    { new Guid("d5c65162-7591-48c1-9198-daca150bce9c"), "actxs-q_02.jpg", new Guid("2eaaba04-80ff-43a6-a746-a74a91c4c0e1"), 0 },
                    { new Guid("d5c65162-7591-48c1-9198-daca151bce0c"), "elbjgb_02.jpg", new Guid("2eaaba04-80ff-43a6-a746-a74a91c4c0e2"), 0 },
                    { new Guid("d5c65162-7591-48c1-9198-daca151bce1c"), "elbjgb-h2_01.jpg", new Guid("2eaaba04-80ff-43a6-a746-a74a91c4c0e2"), 0 },
                    { new Guid("d5c65162-7591-48c1-9198-daca151bce2c"), "elbjgb-h1_01.jpg", new Guid("2eaaba04-80ff-43a6-a746-a74a91c4c0e2"), 0 },
                    { new Guid("d5c65162-7591-48c1-9198-daca151bce3c"), "actxs-e_02_1_1.jpg", new Guid("2eaaba04-80ff-43a6-a746-a74a91c4c0e2"), 0 },
                    { new Guid("d5c65162-7591-48c1-9198-daca151bce4c"), "actxs-q_02.jpg", new Guid("2eaaba04-80ff-43a6-a746-a74a91c4c0e2"), 0 },
                    { new Guid("d5c65162-7591-48c1-9198-daca151bce5c"), "elbjgb_02.jpg", new Guid("2eaaba04-80ff-43a6-a746-a74a91c4c0e3"), 0 },
                    { new Guid("d5c65162-7591-48c1-9198-daca151bce6c"), "elbjgb-h2_01.jpg", new Guid("2eaaba04-80ff-43a6-a746-a74a91c4c0e3"), 0 },
                    { new Guid("d5c65162-7591-48c1-9198-daca151bce7c"), "elbjgb-h1_01.jpg", new Guid("2eaaba04-80ff-43a6-a746-a74a91c4c0e3"), 0 },
                    { new Guid("d5c65162-7591-48c1-9198-daca151bce8c"), "actxs-e_02_1_1.jpg", new Guid("2eaaba04-80ff-43a6-a746-a74a91c4c0e3"), 0 },
                    { new Guid("d5c65162-7591-48c1-9198-daca151bce9c"), "actxs-q_02.jpg", new Guid("2eaaba04-80ff-43a6-a746-a74a91c4c0e3"), 0 },
                    { new Guid("d5c65162-7591-48c1-9198-daca152bce0c"), "elbjgb_02.jpg", new Guid("2eaaba04-80ff-43a6-a746-a74a91c4c0e4"), 0 },
                    { new Guid("d5c65162-7591-48c1-9198-daca152bce1c"), "elbjgb-h2_01.jpg", new Guid("2eaaba04-80ff-43a6-a746-a74a91c4c0e4"), 0 },
                    { new Guid("d5c65162-7591-48c1-9198-daca152bce2c"), "elbjgb-h1_01.jpg", new Guid("2eaaba04-80ff-43a6-a746-a74a91c4c0e4"), 0 },
                    { new Guid("d5c65162-7591-48c1-9198-daca152bce3c"), "actxs-e_02_1_1.jpg", new Guid("2eaaba04-80ff-43a6-a746-a74a91c4c0e4"), 0 },
                    { new Guid("d5c65162-7591-48c1-9198-daca152bce4c"), "actxs-q_02.jpg", new Guid("2eaaba04-80ff-43a6-a746-a74a91c4c0e4"), 0 },
                    { new Guid("d5c65162-7591-48c1-9198-daca152bce5c"), "elbjgb_02.jpg", new Guid("2eaaba04-80ff-43a6-a746-a74a91c4c0e5"), 0 },
                    { new Guid("d5c65162-7591-48c1-9198-daca152bce6c"), "elbjgb-h2_01.jpg", new Guid("2eaaba04-80ff-43a6-a746-a74a91c4c0e5"), 0 },
                    { new Guid("d5c65162-7591-48c1-9198-daca152bce7c"), "elbjgb-h1_01.jpg", new Guid("2eaaba04-80ff-43a6-a746-a74a91c4c0e5"), 0 },
                    { new Guid("d5c65162-7591-48c1-9198-daca152bce8c"), "actxs-e_02_1_1.jpg", new Guid("2eaaba04-80ff-43a6-a746-a74a91c4c0e5"), 0 },
                    { new Guid("d5c65162-7591-48c1-9198-daca152bce9c"), "actxs-q_02.jpg", new Guid("2eaaba04-80ff-43a6-a746-a74a91c4c0e5"), 0 },
                    { new Guid("d5c65162-7591-48c1-9198-daca1539ce0c"), "elbjgb_02.jpg", new Guid("2eaaba04-80ff-43a6-a746-a74a91c4c1e8"), 0 },
                    { new Guid("d5c65162-7591-48c1-9198-daca1539ce1c"), "elbjgb-h2_01.jpg", new Guid("2eaaba04-80ff-43a6-a746-a74a91c4c1e8"), 0 },
                    { new Guid("d5c65162-7591-48c1-9198-daca153bce0c"), "elbjgb_02.jpg", new Guid("2eaaba04-80ff-43a6-a746-a74a91c4c0e6"), 0 },
                    { new Guid("d5c65162-7591-48c1-9198-daca153bce1c"), "elbjgb-h2_01.jpg", new Guid("2eaaba04-80ff-43a6-a746-a74a91c4c0e6"), 0 },
                    { new Guid("d5c65162-7591-48c1-9198-daca153bce2c"), "elbjgb-h1_01.jpg", new Guid("2eaaba04-80ff-43a6-a746-a74a91c4c0e6"), 0 },
                    { new Guid("d5c65162-7591-48c1-9198-daca153bce3c"), "actxs-e_02_1_1.jpg", new Guid("2eaaba04-80ff-43a6-a746-a74a91c4c0e6"), 0 },
                    { new Guid("d5c65162-7591-48c1-9198-daca153bce4c"), "actxs-q_02.jpg", new Guid("2eaaba04-80ff-43a6-a746-a74a91c4c0e6"), 0 },
                    { new Guid("d5c65162-7591-48c1-9198-daca153bce5c"), "elbjgb_02.jpg", new Guid("2eaaba04-80ff-43a6-a746-a74a91c4c0e7"), 0 },
                    { new Guid("d5c65162-7591-48c1-9198-daca153bce6c"), "elbjgb-h2_01.jpg", new Guid("2eaaba04-80ff-43a6-a746-a74a91c4c0e7"), 0 },
                    { new Guid("d5c65162-7591-48c1-9198-daca153bce7c"), "elbjgb-h1_01.jpg", new Guid("2eaaba04-80ff-43a6-a746-a74a91c4c0e7"), 0 },
                    { new Guid("d5c65162-7591-48c1-9198-daca153bce8c"), "actxs-e_02_1_1.jpg", new Guid("2eaaba04-80ff-43a6-a746-a74a91c4c0e7"), 0 },
                    { new Guid("d5c65162-7591-48c1-9198-daca153bce9c"), "actxs-q_02.jpg", new Guid("2eaaba04-80ff-43a6-a746-a74a91c4c0e7"), 0 },
                    { new Guid("d5c65162-7591-48c1-9198-daca154bce0c"), "elbjgb_02.jpg", new Guid("2eaaba04-80ff-43a6-a746-a74a91c4c0e8"), 0 },
                    { new Guid("d5c65162-7591-48c1-9198-daca154bce1c"), "elbjgb-h2_01.jpg", new Guid("2eaaba04-80ff-43a6-a746-a74a91c4c0e8"), 0 },
                    { new Guid("d5c65162-7591-48c1-9198-daca154bce2c"), "elbjgb-h1_01.jpg", new Guid("2eaaba04-80ff-43a6-a746-a74a91c4c0e8"), 0 },
                    { new Guid("d5c65162-7591-48c1-9198-daca154bce3c"), "actxs-e_02_1_1.jpg", new Guid("2eaaba04-80ff-43a6-a746-a74a91c4c0e8"), 0 },
                    { new Guid("d5c65162-7591-48c1-9198-daca154bce4c"), "actxs-q_02.jpg", new Guid("2eaaba04-80ff-43a6-a746-a74a91c4c0e8"), 0 },
                    { new Guid("d5c65162-7591-48c1-9198-daca154bce5c"), "elbjgb_02.jpg", new Guid("2eaaba04-80ff-43a6-a746-a74a91c4c0e9"), 0 }
                });

            migrationBuilder.InsertData(
                table: "ProductImages",
                columns: new[] { "Id", "Name", "ProductDetailId", "Status" },
                values: new object[,]
                {
                    { new Guid("d5c65162-7591-48c1-9198-daca154bce6c"), "elbjgb-h2_01.jpg", new Guid("2eaaba04-80ff-43a6-a746-a74a91c4c0e9"), 0 },
                    { new Guid("d5c65162-7591-48c1-9198-daca154bce7c"), "elbjgb-h1_01.jpg", new Guid("2eaaba04-80ff-43a6-a746-a74a91c4c0e9"), 0 },
                    { new Guid("d5c65162-7591-48c1-9198-daca154bce8c"), "actxs-e_02_1_1.jpg", new Guid("2eaaba04-80ff-43a6-a746-a74a91c4c0e9"), 0 },
                    { new Guid("d5c65162-7591-48c1-9198-daca154bce9c"), "actxs-q_02.jpg", new Guid("2eaaba04-80ff-43a6-a746-a74a91c4c0e9"), 0 },
                    { new Guid("d5c65162-7591-48c1-9198-daca155bce0c"), "elbjgb_02.jpg", new Guid("2eaaba04-80ff-43a6-a746-a74a91c4c1e0"), 0 },
                    { new Guid("d5c65162-7591-48c1-9198-daca155bce1c"), "elbjgb-h2_01.jpg", new Guid("2eaaba04-80ff-43a6-a746-a74a91c4c1e0"), 0 },
                    { new Guid("d5c65162-7591-48c1-9198-daca155bce2c"), "elbjgb-h1_01.jpg", new Guid("2eaaba04-80ff-43a6-a746-a74a91c4c1e0"), 0 },
                    { new Guid("d5c65162-7591-48c1-9198-daca155bce3c"), "actxs-e_02_1_1.jpg", new Guid("2eaaba04-80ff-43a6-a746-a74a91c4c1e0"), 0 },
                    { new Guid("d5c65162-7591-48c1-9198-daca155bce4c"), "actxs-q_02.jpg", new Guid("2eaaba04-80ff-43a6-a746-a74a91c4c1e0"), 0 },
                    { new Guid("d5c65162-7591-48c1-9198-daca155bce5c"), "elbjgb_02.jpg", new Guid("2eaaba04-80ff-43a6-a746-a74a91c4c1e1"), 0 },
                    { new Guid("d5c65162-7591-48c1-9198-daca155bce6c"), "elbjgb-h2_01.jpg", new Guid("2eaaba04-80ff-43a6-a746-a74a91c4c1e1"), 0 },
                    { new Guid("d5c65162-7591-48c1-9198-daca155bce7c"), "elbjgb-h1_01.jpg", new Guid("2eaaba04-80ff-43a6-a746-a74a91c4c1e1"), 0 },
                    { new Guid("d5c65162-7591-48c1-9198-daca155bce8c"), "actxs-e_02_1_1.jpg", new Guid("2eaaba04-80ff-43a6-a746-a74a91c4c1e1"), 0 },
                    { new Guid("d5c65162-7591-48c1-9198-daca155bce9c"), "actxs-q_02.jpg", new Guid("2eaaba04-80ff-43a6-a746-a74a91c4c1e1"), 0 },
                    { new Guid("d5c65162-7591-48c1-9198-daca156bce0c"), "elbjgb_02.jpg", new Guid("2eaaba04-80ff-43a6-a746-a74a91c4c1e2"), 0 },
                    { new Guid("d5c65162-7591-48c1-9198-daca156bce1c"), "elbjgb-h2_01.jpg", new Guid("2eaaba04-80ff-43a6-a746-a74a91c4c1e2"), 0 },
                    { new Guid("d5c65162-7591-48c1-9198-daca156bce2c"), "elbjgb-h1_01.jpg", new Guid("2eaaba04-80ff-43a6-a746-a74a91c4c1e2"), 0 },
                    { new Guid("d5c65162-7591-48c1-9198-daca156bce3c"), "actxs-e_02_1_1.jpg", new Guid("2eaaba04-80ff-43a6-a746-a74a91c4c1e2"), 0 },
                    { new Guid("d5c65162-7591-48c1-9198-daca156bce4c"), "actxs-q_02.jpg", new Guid("2eaaba04-80ff-43a6-a746-a74a91c4c1e2"), 0 },
                    { new Guid("d5c65162-7591-48c1-9198-daca156bce5c"), "elbjgb_02.jpg", new Guid("2eaaba04-80ff-43a6-a746-a74a91c4c1e3"), 0 },
                    { new Guid("d5c65162-7591-48c1-9198-daca156bce6c"), "elbjgb-h2_01.jpg", new Guid("2eaaba04-80ff-43a6-a746-a74a91c4c1e3"), 0 },
                    { new Guid("d5c65162-7591-48c1-9198-daca156bce7c"), "elbjgb-h1_01.jpg", new Guid("2eaaba04-80ff-43a6-a746-a74a91c4c1e3"), 0 },
                    { new Guid("d5c65162-7591-48c1-9198-daca156bce8c"), "actxs-e_02_1_1.jpg", new Guid("2eaaba04-80ff-43a6-a746-a74a91c4c1e3"), 0 },
                    { new Guid("d5c65162-7591-48c1-9198-daca156bce9c"), "actxs-q_02.jpg", new Guid("2eaaba04-80ff-43a6-a746-a74a91c4c1e3"), 0 },
                    { new Guid("d5c65162-7591-48c1-9198-daca157bce0c"), "elbjgb_02.jpg", new Guid("2eaaba04-80ff-43a6-a746-a74a91c4c1e4"), 0 },
                    { new Guid("d5c65162-7591-48c1-9198-daca157bce1c"), "elbjgb-h2_01.jpg", new Guid("2eaaba04-80ff-43a6-a746-a74a91c4c1e4"), 0 },
                    { new Guid("d5c65162-7591-48c1-9198-daca157bce2c"), "elbjgb-h1_01.jpg", new Guid("2eaaba04-80ff-43a6-a746-a74a91c4c1e4"), 0 },
                    { new Guid("d5c65162-7591-48c1-9198-daca157bce3c"), "actxs-e_02_1_1.jpg", new Guid("2eaaba04-80ff-43a6-a746-a74a91c4c1e4"), 0 },
                    { new Guid("d5c65162-7591-48c1-9198-daca157bce4c"), "actxs-q_02.jpg", new Guid("2eaaba04-80ff-43a6-a746-a74a91c4c1e4"), 0 },
                    { new Guid("d5c65162-7591-48c1-9198-daca157bce5c"), "elbjgb_02.jpg", new Guid("2eaaba04-80ff-43a6-a746-a74a91c4c1e5"), 0 },
                    { new Guid("d5c65162-7591-48c1-9198-daca157bce6c"), "elbjgb-h2_01.jpg", new Guid("2eaaba04-80ff-43a6-a746-a74a91c4c1e5"), 0 },
                    { new Guid("d5c65162-7591-48c1-9198-daca157bce7c"), "elbjgb-h1_01.jpg", new Guid("2eaaba04-80ff-43a6-a746-a74a91c4c1e5"), 0 },
                    { new Guid("d5c65162-7591-48c1-9198-daca157bce8c"), "actxs-e_02_1_1.jpg", new Guid("2eaaba04-80ff-43a6-a746-a74a91c4c1e5"), 0 },
                    { new Guid("d5c65162-7591-48c1-9198-daca157bce9c"), "actxs-q_02.jpg", new Guid("2eaaba04-80ff-43a6-a746-a74a91c4c1e5"), 0 },
                    { new Guid("d5c65162-7591-48c1-9198-daca158bce0c"), "elbjgb_02.jpg", new Guid("2eaaba04-80ff-43a6-a746-a74a91c4c1e6"), 0 },
                    { new Guid("d5c65162-7591-48c1-9198-daca158bce1c"), "elbjgb-h2_01.jpg", new Guid("2eaaba04-80ff-43a6-a746-a74a91c4c1e6"), 0 },
                    { new Guid("d5c65162-7591-48c1-9198-daca158bce2c"), "elbjgb-h1_01.jpg", new Guid("2eaaba04-80ff-43a6-a746-a74a91c4c1e6"), 0 },
                    { new Guid("d5c65162-7591-48c1-9198-daca158bce3c"), "actxs-e_02_1_1.jpg", new Guid("2eaaba04-80ff-43a6-a746-a74a91c4c1e6"), 0 },
                    { new Guid("d5c65162-7591-48c1-9198-daca158bce4c"), "actxs-q_02.jpg", new Guid("2eaaba04-80ff-43a6-a746-a74a91c4c1e6"), 0 },
                    { new Guid("d5c65162-7591-48c1-9198-daca158bce5c"), "elbjgb_02.jpg", new Guid("2eaaba04-80ff-43a6-a746-a74a91c4c1e7"), 0 },
                    { new Guid("d5c65162-7591-48c1-9198-daca158bce6c"), "elbjgb-h2_01.jpg", new Guid("2eaaba04-80ff-43a6-a746-a74a91c4c1e7"), 0 },
                    { new Guid("d5c65162-7591-48c1-9198-daca158bce7c"), "elbjgb-h1_01.jpg", new Guid("2eaaba04-80ff-43a6-a746-a74a91c4c1e7"), 0 }
                });

            migrationBuilder.InsertData(
                table: "ProductImages",
                columns: new[] { "Id", "Name", "ProductDetailId", "Status" },
                values: new object[,]
                {
                    { new Guid("d5c65162-7591-48c1-9198-daca158bce8c"), "actxs-e_02_1_1.jpg", new Guid("2eaaba04-80ff-43a6-a746-a74a91c4c1e7"), 0 },
                    { new Guid("d5c65162-7591-48c1-9198-daca158bce9c"), "actxs-q_02.jpg", new Guid("2eaaba04-80ff-43a6-a746-a74a91c4c1e7"), 0 },
                    { new Guid("d5c65162-7591-48c1-9198-daca159bce2c"), "elbjgb-h1_01.jpg", new Guid("2eaaba04-80ff-43a6-a746-a74a91c4c1e8"), 0 },
                    { new Guid("d5c65162-7591-48c1-9198-daca159bce3c"), "actxs-e_02_1_1.jpg", new Guid("2eaaba04-80ff-43a6-a746-a74a91c4c1e8"), 0 },
                    { new Guid("d5c65162-7591-48c1-9198-daca159bce4c"), "actxs-q_02.jpg", new Guid("2eaaba04-80ff-43a6-a746-a74a91c4c1e8"), 0 },
                    { new Guid("d5c65162-7591-48c1-9198-daca159bce5c"), "elbjgb_02.jpg", new Guid("2eaaba04-80ff-43a6-a746-a74a91c4c1e9"), 0 },
                    { new Guid("d5c65162-7591-48c1-9198-daca159bce6c"), "elbjgb-h2_01.jpg", new Guid("2eaaba04-80ff-43a6-a746-a74a91c4c1e9"), 0 },
                    { new Guid("d5c65162-7591-48c1-9198-daca159bce7c"), "elbjgb-h1_01.jpg", new Guid("2eaaba04-80ff-43a6-a746-a74a91c4c1e9"), 0 },
                    { new Guid("d5c65162-7591-48c1-9198-daca159bce8c"), "actxs-e_02_1_1.jpg", new Guid("2eaaba04-80ff-43a6-a746-a74a91c4c1e9"), 0 },
                    { new Guid("d5c65162-7591-48c1-9198-daca159bce9c"), "actxs-q_02.jpg", new Guid("2eaaba04-80ff-43a6-a746-a74a91c4c1e9"), 0 },
                    { new Guid("d5c65162-7591-48c1-9198-daca160bce0c"), "elbjgb_02.jpg", new Guid("2eaaba04-80ff-43a6-a746-a74a91c4c2e0"), 0 },
                    { new Guid("d5c65162-7591-48c1-9198-daca160bce1c"), "elbjgb-h2_01.jpg", new Guid("2eaaba04-80ff-43a6-a746-a74a91c4c2e0"), 0 },
                    { new Guid("d5c65162-7591-48c1-9198-daca160bce2c"), "elbjgb-h1_01.jpg", new Guid("2eaaba04-80ff-43a6-a746-a74a91c4c2e0"), 0 },
                    { new Guid("d5c65162-7591-48c1-9198-daca160bce3c"), "actxs-e_02_1_1.jpg", new Guid("2eaaba04-80ff-43a6-a746-a74a91c4c2e0"), 0 },
                    { new Guid("d5c65162-7591-48c1-9198-daca160bce4c"), "actxs-q_02.jpg", new Guid("2eaaba04-80ff-43a6-a746-a74a91c4c2e0"), 0 },
                    { new Guid("d5c65162-7591-48c1-9198-daca160bce5c"), "elbjgb_02.jpg", new Guid("2eaaba04-80ff-43a6-a746-a74a91c4c2e1"), 0 },
                    { new Guid("d5c65162-7591-48c1-9198-daca160bce6c"), "elbjgb-h2_01.jpg", new Guid("2eaaba04-80ff-43a6-a746-a74a91c4c2e1"), 0 },
                    { new Guid("d5c65162-7591-48c1-9198-daca160bce7c"), "elbjgb-h1_01.jpg", new Guid("2eaaba04-80ff-43a6-a746-a74a91c4c2e1"), 0 },
                    { new Guid("d5c65162-7591-48c1-9198-daca160bce8c"), "actxs-e_02_1_1.jpg", new Guid("2eaaba04-80ff-43a6-a746-a74a91c4c2e1"), 0 },
                    { new Guid("d5c65162-7591-48c1-9198-daca160bce9c"), "actxs-q_02.jpg", new Guid("2eaaba04-80ff-43a6-a746-a74a91c4c2e1"), 0 },
                    { new Guid("d5c65162-7591-48c1-9198-daca161bce0c"), "elbjgb_02.jpg", new Guid("2eaaba04-80ff-43a6-a746-a74a91c4c2e2"), 0 },
                    { new Guid("d5c65162-7591-48c1-9198-daca161bce1c"), "elbjgb-h2_01.jpg", new Guid("2eaaba04-80ff-43a6-a746-a74a91c4c2e2"), 0 },
                    { new Guid("d5c65162-7591-48c1-9198-daca161bce2c"), "elbjgb-h1_01.jpg", new Guid("2eaaba04-80ff-43a6-a746-a74a91c4c2e2"), 0 },
                    { new Guid("d5c65162-7591-48c1-9198-daca161bce3c"), "actxs-e_02_1_1.jpg", new Guid("2eaaba04-80ff-43a6-a746-a74a91c4c2e2"), 0 },
                    { new Guid("d5c65162-7591-48c1-9198-daca161bce4c"), "actxs-q_02.jpg", new Guid("2eaaba04-80ff-43a6-a746-a74a91c4c2e2"), 0 },
                    { new Guid("d5c65162-7591-48c1-9198-daca161bce5c"), "elbjgb_02.jpg", new Guid("2eaaba04-80ff-43a6-a746-a74a91c4c2e3"), 0 },
                    { new Guid("d5c65162-7591-48c1-9198-daca161bce6c"), "elbjgb-h2_01.jpg", new Guid("2eaaba04-80ff-43a6-a746-a74a91c4c2e3"), 0 },
                    { new Guid("d5c65162-7591-48c1-9198-daca161bce7c"), "elbjgb-h1_01.jpg", new Guid("2eaaba04-80ff-43a6-a746-a74a91c4c2e3"), 0 },
                    { new Guid("d5c65162-7591-48c1-9198-daca161bce8c"), "actxs-e_02_1_1.jpg", new Guid("2eaaba04-80ff-43a6-a746-a74a91c4c2e3"), 0 },
                    { new Guid("d5c65162-7591-48c1-9198-daca161bce9c"), "actxs-q_02.jpg", new Guid("2eaaba04-80ff-43a6-a746-a74a91c4c2e3"), 0 },
                    { new Guid("d5c65162-7591-48c1-9198-daca162bce0c"), "elbjgb_02.jpg", new Guid("2eaaba04-80ff-43a6-a746-a74a91c4c2e4"), 0 },
                    { new Guid("d5c65162-7591-48c1-9198-daca162bce1c"), "elbjgb-h2_01.jpg", new Guid("2eaaba04-80ff-43a6-a746-a74a91c4c2e4"), 0 },
                    { new Guid("d5c65162-7591-48c1-9198-daca162bce2c"), "elbjgb-h1_01.jpg", new Guid("2eaaba04-80ff-43a6-a746-a74a91c4c2e4"), 0 },
                    { new Guid("d5c65162-7591-48c1-9198-daca162bce3c"), "actxs-e_02_1_1.jpg", new Guid("2eaaba04-80ff-43a6-a746-a74a91c4c2e4"), 0 },
                    { new Guid("d5c65162-7591-48c1-9198-daca162bce4c"), "actxs-q_02.jpg", new Guid("2eaaba04-80ff-43a6-a746-a74a91c4c2e4"), 0 },
                    { new Guid("d5c65162-7591-48c1-9198-daca162bce5c"), "elbjgb_02.jpg", new Guid("2eaaba04-80ff-43a6-a746-a74a91c4c2e5"), 0 },
                    { new Guid("d5c65162-7591-48c1-9198-daca162bce6c"), "elbjgb-h2_01.jpg", new Guid("2eaaba04-80ff-43a6-a746-a74a91c4c2e5"), 0 },
                    { new Guid("d5c65162-7591-48c1-9198-daca162bce7c"), "elbjgb-h1_01.jpg", new Guid("2eaaba04-80ff-43a6-a746-a74a91c4c2e5"), 0 },
                    { new Guid("d5c65162-7591-48c1-9198-daca162bce8c"), "actxs-e_02_1_1.jpg", new Guid("2eaaba04-80ff-43a6-a746-a74a91c4c2e5"), 0 },
                    { new Guid("d5c65162-7591-48c1-9198-daca162bce9c"), "actxs-q_02.jpg", new Guid("2eaaba04-80ff-43a6-a746-a74a91c4c2e5"), 0 },
                    { new Guid("d5c65162-7591-48c1-9198-daca163bce0c"), "elbjgb_02.jpg", new Guid("2eaaba04-80ff-43a6-a746-a74a91c4c2e6"), 0 },
                    { new Guid("d5c65162-7591-48c1-9198-daca163bce1c"), "elbjgb-h2_01.jpg", new Guid("2eaaba04-80ff-43a6-a746-a74a91c4c2e6"), 0 }
                });

            migrationBuilder.InsertData(
                table: "ProductImages",
                columns: new[] { "Id", "Name", "ProductDetailId", "Status" },
                values: new object[,]
                {
                    { new Guid("d5c65162-7591-48c1-9198-daca163bce2c"), "elbjgb-h1_01.jpg", new Guid("2eaaba04-80ff-43a6-a746-a74a91c4c2e6"), 0 },
                    { new Guid("d5c65162-7591-48c1-9198-daca163bce3c"), "actxs-e_02_1_1.jpg", new Guid("2eaaba04-80ff-43a6-a746-a74a91c4c2e6"), 0 },
                    { new Guid("d5c65162-7591-48c1-9198-daca163bce4c"), "actxs-q_02.jpg", new Guid("2eaaba04-80ff-43a6-a746-a74a91c4c2e6"), 0 },
                    { new Guid("d5c65162-7591-48c1-9198-daca163bce5c"), "elbjgb_02.jpg", new Guid("2eaaba04-80ff-43a6-a746-a74a91c4c2e7"), 0 },
                    { new Guid("d5c65162-7591-48c1-9198-daca163bce6c"), "elbjgb-h2_01.jpg", new Guid("2eaaba04-80ff-43a6-a746-a74a91c4c2e7"), 0 },
                    { new Guid("d5c65162-7591-48c1-9198-daca163bce7c"), "elbjgb-h1_01.jpg", new Guid("2eaaba04-80ff-43a6-a746-a74a91c4c2e7"), 0 },
                    { new Guid("d5c65162-7591-48c1-9198-daca163bce8c"), "actxs-e_02_1_1.jpg", new Guid("2eaaba04-80ff-43a6-a746-a74a91c4c2e7"), 0 },
                    { new Guid("d5c65162-7591-48c1-9198-daca163bce9c"), "actxs-q_02.jpg", new Guid("2eaaba04-80ff-43a6-a746-a74a91c4c2e7"), 0 },
                    { new Guid("d5c65162-7591-48c1-9198-daca164bce0c"), "elbjgb_02.jpg", new Guid("2eaaba04-80ff-43a6-a746-a74a91c4c2e8"), 0 },
                    { new Guid("d5c65162-7591-48c1-9198-daca164bce1c"), "elbjgb-h2_01.jpg", new Guid("2eaaba04-80ff-43a6-a746-a74a91c4c2e8"), 0 },
                    { new Guid("d5c65162-7591-48c1-9198-daca164bce2c"), "elbjgb-h1_01.jpg", new Guid("2eaaba04-80ff-43a6-a746-a74a91c4c2e8"), 0 },
                    { new Guid("d5c65162-7591-48c1-9198-daca164bce3c"), "actxs-e_02_1_1.jpg", new Guid("2eaaba04-80ff-43a6-a746-a74a91c4c2e8"), 0 },
                    { new Guid("d5c65162-7591-48c1-9198-daca164bce4c"), "actxs-q_02.jpg", new Guid("2eaaba04-80ff-43a6-a746-a74a91c4c2e8"), 0 },
                    { new Guid("d5c65162-7591-48c1-9198-daca164bce5c"), "elbjgb_02.jpg", new Guid("2eaaba04-80ff-43a6-a746-a74a91c4c2e9"), 0 },
                    { new Guid("d5c65162-7591-48c1-9198-daca164bce6c"), "elbjgb-h2_01.jpg", new Guid("2eaaba04-80ff-43a6-a746-a74a91c4c2e9"), 0 },
                    { new Guid("d5c65162-7591-48c1-9198-daca164bce7c"), "elbjgb-h1_01.jpg", new Guid("2eaaba04-80ff-43a6-a746-a74a91c4c2e9"), 0 },
                    { new Guid("d5c65162-7591-48c1-9198-daca164bce8c"), "actxs-e_02_1_1.jpg", new Guid("2eaaba04-80ff-43a6-a746-a74a91c4c2e9"), 0 },
                    { new Guid("d5c65162-7591-48c1-9198-daca164bce9c"), "actxs-q_02.jpg", new Guid("2eaaba04-80ff-43a6-a746-a74a91c4c2e9"), 0 },
                    { new Guid("d5c65162-7591-48c1-9198-daca165bce0c"), "elbjgb_02.jpg", new Guid("2eaaba04-80ff-43a6-a746-a74a91c4c3e0"), 0 },
                    { new Guid("d5c65162-7591-48c1-9198-daca165bce1c"), "elbjgb-h2_01.jpg", new Guid("2eaaba04-80ff-43a6-a746-a74a91c4c3e0"), 0 },
                    { new Guid("d5c65162-7591-48c1-9198-daca165bce2c"), "elbjgb-h1_01.jpg", new Guid("2eaaba04-80ff-43a6-a746-a74a91c4c3e0"), 0 },
                    { new Guid("d5c65162-7591-48c1-9198-daca165bce3c"), "actxs-e_02_1_1.jpg", new Guid("2eaaba04-80ff-43a6-a746-a74a91c4c3e0"), 0 },
                    { new Guid("d5c65162-7591-48c1-9198-daca165bce4c"), "actxs-q_02.jpg", new Guid("2eaaba04-80ff-43a6-a746-a74a91c4c3e0"), 0 },
                    { new Guid("d5c65162-7591-48c1-9198-daca165bce5c"), "elbjgb_02.jpg", new Guid("2eaaba04-80ff-43a6-a746-a74a91c4c3e1"), 0 },
                    { new Guid("d5c65162-7591-48c1-9198-daca165bce6c"), "elbjgb-h2_01.jpg", new Guid("2eaaba04-80ff-43a6-a746-a74a91c4c3e1"), 0 },
                    { new Guid("d5c65162-7591-48c1-9198-daca165bce7c"), "elbjgb-h1_01.jpg", new Guid("2eaaba04-80ff-43a6-a746-a74a91c4c3e1"), 0 },
                    { new Guid("d5c65162-7591-48c1-9198-daca165bce8c"), "actxs-e_02_1_1.jpg", new Guid("2eaaba04-80ff-43a6-a746-a74a91c4c3e1"), 0 },
                    { new Guid("d5c65162-7591-48c1-9198-daca165bce9c"), "actxs-q_02.jpg", new Guid("2eaaba04-80ff-43a6-a746-a74a91c4c3e1"), 0 },
                    { new Guid("d5c65162-7591-48c1-9198-daca166bce0c"), "elbjgb_02.jpg", new Guid("2eaaba04-80ff-43a6-a746-a74a91c4c3e2"), 0 },
                    { new Guid("d5c65162-7591-48c1-9198-daca166bce1c"), "elbjgb-h2_01.jpg", new Guid("2eaaba04-80ff-43a6-a746-a74a91c4c3e2"), 0 },
                    { new Guid("d5c65162-7591-48c1-9198-daca166bce2c"), "elbjgb-h1_01.jpg", new Guid("2eaaba04-80ff-43a6-a746-a74a91c4c3e2"), 0 },
                    { new Guid("d5c65162-7591-48c1-9198-daca166bce3c"), "actxs-e_02_1_1.jpg", new Guid("2eaaba04-80ff-43a6-a746-a74a91c4c3e2"), 0 },
                    { new Guid("d5c65162-7591-48c1-9198-daca166bce4c"), "actxs-q_02.jpg", new Guid("2eaaba04-80ff-43a6-a746-a74a91c4c3e2"), 0 },
                    { new Guid("d5c65162-7591-48c1-9198-daca166bce5c"), "elbjgb_02.jpg", new Guid("2eaaba04-80ff-43a6-a746-a74a91c4c3e3"), 0 },
                    { new Guid("d5c65162-7591-48c1-9198-daca166bce6c"), "elbjgb-h2_01.jpg", new Guid("2eaaba04-80ff-43a6-a746-a74a91c4c3e3"), 0 },
                    { new Guid("d5c65162-7591-48c1-9198-daca166bce7c"), "elbjgb-h1_01.jpg", new Guid("2eaaba04-80ff-43a6-a746-a74a91c4c3e3"), 0 },
                    { new Guid("d5c65162-7591-48c1-9198-daca166bce8c"), "actxs-e_02_1_1.jpg", new Guid("2eaaba04-80ff-43a6-a746-a74a91c4c3e3"), 0 },
                    { new Guid("d5c65162-7591-48c1-9198-daca166bce9c"), "actxs-q_02.jpg", new Guid("2eaaba04-80ff-43a6-a746-a74a91c4c3e3"), 0 },
                    { new Guid("d5c65162-7591-48c1-9198-daca167bce0c"), "elbjgb_02.jpg", new Guid("2eaaba04-80ff-43a6-a746-a74a91c4c3e4"), 0 },
                    { new Guid("d5c65162-7591-48c1-9198-daca167bce1c"), "elbjgb-h2_01.jpg", new Guid("2eaaba04-80ff-43a6-a746-a74a91c4c3e4"), 0 },
                    { new Guid("d5c65162-7591-48c1-9198-daca167bce2c"), "elbjgb-h1_01.jpg", new Guid("2eaaba04-80ff-43a6-a746-a74a91c4c3e4"), 0 },
                    { new Guid("d5c65162-7591-48c1-9198-daca167bce3c"), "actxs-e_02_1_1.jpg", new Guid("2eaaba04-80ff-43a6-a746-a74a91c4c3e4"), 0 }
                });

            migrationBuilder.InsertData(
                table: "ProductImages",
                columns: new[] { "Id", "Name", "ProductDetailId", "Status" },
                values: new object[,]
                {
                    { new Guid("d5c65162-7591-48c1-9198-daca167bce4c"), "actxs-q_02.jpg", new Guid("2eaaba04-80ff-43a6-a746-a74a91c4c3e4"), 0 },
                    { new Guid("d5c65162-7591-48c1-9198-daca167bce5c"), "elbjgb_02.jpg", new Guid("2eaaba04-80ff-43a6-a746-a74a91c4c3e5"), 0 },
                    { new Guid("d5c65162-7591-48c1-9198-daca167bce6c"), "elbjgb-h2_01.jpg", new Guid("2eaaba04-80ff-43a6-a746-a74a91c4c3e5"), 0 },
                    { new Guid("d5c65162-7591-48c1-9198-daca167bce7c"), "elbjgb-h1_01.jpg", new Guid("2eaaba04-80ff-43a6-a746-a74a91c4c3e5"), 0 },
                    { new Guid("d5c65162-7591-48c1-9198-daca167bce8c"), "actxs-e_02_1_1.jpg", new Guid("2eaaba04-80ff-43a6-a746-a74a91c4c3e5"), 0 },
                    { new Guid("d5c65162-7591-48c1-9198-daca167bce9c"), "actxs-q_02.jpg", new Guid("2eaaba04-80ff-43a6-a746-a74a91c4c3e5"), 0 },
                    { new Guid("d5c65162-7591-48c1-9198-daca168bce0c"), "elbjgb_02.jpg", new Guid("2eaaba04-80ff-43a6-a746-a74a91c4c3e6"), 0 },
                    { new Guid("d5c65162-7591-48c1-9198-daca168bce1c"), "elbjgb-h2_01.jpg", new Guid("2eaaba04-80ff-43a6-a746-a74a91c4c3e6"), 0 },
                    { new Guid("d5c65162-7591-48c1-9198-daca168bce2c"), "elbjgb-h1_01.jpg", new Guid("2eaaba04-80ff-43a6-a746-a74a91c4c3e6"), 0 },
                    { new Guid("d5c65162-7591-48c1-9198-daca168bce3c"), "actxs-e_02_1_1.jpg", new Guid("2eaaba04-80ff-43a6-a746-a74a91c4c3e6"), 0 },
                    { new Guid("d5c65162-7591-48c1-9198-daca168bce4c"), "actxs-q_02.jpg", new Guid("2eaaba04-80ff-43a6-a746-a74a91c4c3e6"), 0 },
                    { new Guid("d5c65162-7591-48c1-9198-daca168bce5c"), "elbjgb_02.jpg", new Guid("2eaaba04-80ff-43a6-a746-a74a91c4c3e7"), 0 },
                    { new Guid("d5c65162-7591-48c1-9198-daca168bce6c"), "elbjgb-h2_01.jpg", new Guid("2eaaba04-80ff-43a6-a746-a74a91c4c3e7"), 0 },
                    { new Guid("d5c65162-7591-48c1-9198-daca168bce7c"), "elbjgb-h1_01.jpg", new Guid("2eaaba04-80ff-43a6-a746-a74a91c4c3e7"), 0 },
                    { new Guid("d5c65162-7591-48c1-9198-daca168bce8c"), "actxs-e_02_1_1.jpg", new Guid("2eaaba04-80ff-43a6-a746-a74a91c4c3e7"), 0 },
                    { new Guid("d5c65162-7591-48c1-9198-daca168bce9c"), "actxs-q_02.jpg", new Guid("2eaaba04-80ff-43a6-a746-a74a91c4c3e7"), 0 },
                    { new Guid("d5c65162-7591-48c1-9198-daca169bce0c"), "elbjgb_02.jpg", new Guid("2eaaba04-80ff-43a6-a746-a74a91c4c3e8"), 0 },
                    { new Guid("d5c65162-7591-48c1-9198-daca169bce1c"), "elbjgb-h2_01.jpg", new Guid("2eaaba04-80ff-43a6-a746-a74a91c4c3e8"), 0 },
                    { new Guid("d5c65162-7591-48c1-9198-daca169bce2c"), "elbjgb-h1_01.jpg", new Guid("2eaaba04-80ff-43a6-a746-a74a91c4c3e8"), 0 },
                    { new Guid("d5c65162-7591-48c1-9198-daca169bce3c"), "actxs-e_02_1_1.jpg", new Guid("2eaaba04-80ff-43a6-a746-a74a91c4c3e8"), 0 },
                    { new Guid("d5c65162-7591-48c1-9198-daca169bce4c"), "actxs-q_02.jpg", new Guid("2eaaba04-80ff-43a6-a746-a74a91c4c3e8"), 0 },
                    { new Guid("d5c65162-7591-48c1-9198-daca169bce5c"), "elbjgb_02.jpg", new Guid("2eaaba04-80ff-43a6-a746-a74a91c4c3e9"), 0 },
                    { new Guid("d5c65162-7591-48c1-9198-daca169bce6c"), "elbjgb-h2_01.jpg", new Guid("2eaaba04-80ff-43a6-a746-a74a91c4c3e9"), 0 },
                    { new Guid("d5c65162-7591-48c1-9198-daca169bce7c"), "elbjgb-h1_01.jpg", new Guid("2eaaba04-80ff-43a6-a746-a74a91c4c3e9"), 0 },
                    { new Guid("d5c65162-7591-48c1-9198-daca169bce8c"), "actxs-e_02_1_1.jpg", new Guid("2eaaba04-80ff-43a6-a746-a74a91c4c3e9"), 0 },
                    { new Guid("d5c65162-7591-48c1-9198-daca169bce9c"), "actxs-q_02.jpg", new Guid("2eaaba04-80ff-43a6-a746-a74a91c4c3e9"), 0 },
                    { new Guid("d5c65162-7591-48c1-9198-daca170bce0c"), "elbjgb_02.jpg", new Guid("2eaaba04-80ff-43a6-a746-a74a91c5c0e0"), 0 },
                    { new Guid("d5c65162-7591-48c1-9198-daca170bce1c"), "elbjgb-h2_01.jpg", new Guid("2eaaba04-80ff-43a6-a746-a74a91c5c0e0"), 0 },
                    { new Guid("d5c65162-7591-48c1-9198-daca170bce2c"), "elbjgb-h1_01.jpg", new Guid("2eaaba04-80ff-43a6-a746-a74a91c5c0e0"), 0 },
                    { new Guid("d5c65162-7591-48c1-9198-daca170bce3c"), "actxs-e_02_1_1.jpg", new Guid("2eaaba04-80ff-43a6-a746-a74a91c5c0e0"), 0 },
                    { new Guid("d5c65162-7591-48c1-9198-daca170bce4c"), "actxs-q_02.jpg", new Guid("2eaaba04-80ff-43a6-a746-a74a91c5c0e0"), 0 },
                    { new Guid("d5c65162-7591-48c1-9198-daca170bce5c"), "elbjgb_02.jpg", new Guid("2eaaba04-80ff-43a6-a746-a74a91c5c0e1"), 0 },
                    { new Guid("d5c65162-7591-48c1-9198-daca170bce6c"), "elbjgb-h2_01.jpg", new Guid("2eaaba04-80ff-43a6-a746-a74a91c5c0e1"), 0 },
                    { new Guid("d5c65162-7591-48c1-9198-daca170bce7c"), "elbjgb-h1_01.jpg", new Guid("2eaaba04-80ff-43a6-a746-a74a91c5c0e1"), 0 },
                    { new Guid("d5c65162-7591-48c1-9198-daca170bce8c"), "actxs-e_02_1_1.jpg", new Guid("2eaaba04-80ff-43a6-a746-a74a91c5c0e1"), 0 },
                    { new Guid("d5c65162-7591-48c1-9198-daca170bce9c"), "actxs-q_02.jpg", new Guid("2eaaba04-80ff-43a6-a746-a74a91c5c0e1"), 0 },
                    { new Guid("d5c65162-7591-48c1-9198-daca171bce0c"), "elbjgb_02.jpg", new Guid("2eaaba04-80ff-43a6-a746-a74a91c5c0e2"), 0 },
                    { new Guid("d5c65162-7591-48c1-9198-daca171bce1c"), "elbjgb-h2_01.jpg", new Guid("2eaaba04-80ff-43a6-a746-a74a91c5c0e2"), 0 },
                    { new Guid("d5c65162-7591-48c1-9198-daca171bce2c"), "elbjgb-h1_01.jpg", new Guid("2eaaba04-80ff-43a6-a746-a74a91c5c0e2"), 0 },
                    { new Guid("d5c65162-7591-48c1-9198-daca171bce3c"), "actxs-e_02_1_1.jpg", new Guid("2eaaba04-80ff-43a6-a746-a74a91c5c0e2"), 0 },
                    { new Guid("d5c65162-7591-48c1-9198-daca171bce4c"), "actxs-q_02.jpg", new Guid("2eaaba04-80ff-43a6-a746-a74a91c5c0e2"), 0 },
                    { new Guid("d5c65162-7591-48c1-9198-daca171bce5c"), "elbjgb_02.jpg", new Guid("2eaaba04-80ff-43a6-a746-a74a91c5c0e3"), 0 }
                });

            migrationBuilder.InsertData(
                table: "ProductImages",
                columns: new[] { "Id", "Name", "ProductDetailId", "Status" },
                values: new object[,]
                {
                    { new Guid("d5c65162-7591-48c1-9198-daca171bce6c"), "elbjgb-h2_01.jpg", new Guid("2eaaba04-80ff-43a6-a746-a74a91c5c0e3"), 0 },
                    { new Guid("d5c65162-7591-48c1-9198-daca171bce7c"), "elbjgb-h1_01.jpg", new Guid("2eaaba04-80ff-43a6-a746-a74a91c5c0e3"), 0 },
                    { new Guid("d5c65162-7591-48c1-9198-daca171bce8c"), "actxs-e_02_1_1.jpg", new Guid("2eaaba04-80ff-43a6-a746-a74a91c5c0e3"), 0 },
                    { new Guid("d5c65162-7591-48c1-9198-daca171bce9c"), "actxs-q_02.jpg", new Guid("2eaaba04-80ff-43a6-a746-a74a91c5c0e3"), 0 },
                    { new Guid("d5c65162-7591-48c1-9198-daca172bce0c"), "elbjgb_02.jpg", new Guid("2eaaba04-80ff-43a6-a746-a74a91c5c0e4"), 0 },
                    { new Guid("d5c65162-7591-48c1-9198-daca172bce1c"), "elbjgb-h2_01.jpg", new Guid("2eaaba04-80ff-43a6-a746-a74a91c5c0e4"), 0 },
                    { new Guid("d5c65162-7591-48c1-9198-daca172bce2c"), "elbjgb-h1_01.jpg", new Guid("2eaaba04-80ff-43a6-a746-a74a91c5c0e4"), 0 },
                    { new Guid("d5c65162-7591-48c1-9198-daca172bce3c"), "actxs-e_02_1_1.jpg", new Guid("2eaaba04-80ff-43a6-a746-a74a91c5c0e4"), 0 },
                    { new Guid("d5c65162-7591-48c1-9198-daca172bce4c"), "actxs-q_02.jpg", new Guid("2eaaba04-80ff-43a6-a746-a74a91c5c0e4"), 0 },
                    { new Guid("d5c65162-7591-48c1-9198-daca172bce5c"), "elbjgb_02.jpg", new Guid("2eaaba04-80ff-43a6-a746-a74a91c5c0e5"), 0 },
                    { new Guid("d5c65162-7591-48c1-9198-daca172bce6c"), "elbjgb-h2_01.jpg", new Guid("2eaaba04-80ff-43a6-a746-a74a91c5c0e5"), 0 },
                    { new Guid("d5c65162-7591-48c1-9198-daca172bce7c"), "elbjgb-h1_01.jpg", new Guid("2eaaba04-80ff-43a6-a746-a74a91c5c0e5"), 0 },
                    { new Guid("d5c65162-7591-48c1-9198-daca172bce8c"), "actxs-e_02_1_1.jpg", new Guid("2eaaba04-80ff-43a6-a746-a74a91c5c0e5"), 0 },
                    { new Guid("d5c65162-7591-48c1-9198-daca172bce9c"), "actxs-q_02.jpg", new Guid("2eaaba04-80ff-43a6-a746-a74a91c5c0e5"), 0 },
                    { new Guid("d5c65162-7591-48c1-9198-daca173bce0c"), "elbjgb_02.jpg", new Guid("2eaaba04-80ff-43a6-a746-a74a91c5c0e6"), 0 },
                    { new Guid("d5c65162-7591-48c1-9198-daca173bce1c"), "elbjgb-h2_01.jpg", new Guid("2eaaba04-80ff-43a6-a746-a74a91c5c0e6"), 0 },
                    { new Guid("d5c65162-7591-48c1-9198-daca173bce2c"), "elbjgb-h1_01.jpg", new Guid("2eaaba04-80ff-43a6-a746-a74a91c5c0e6"), 0 },
                    { new Guid("d5c65162-7591-48c1-9198-daca173bce3c"), "actxs-e_02_1_1.jpg", new Guid("2eaaba04-80ff-43a6-a746-a74a91c5c0e6"), 0 },
                    { new Guid("d5c65162-7591-48c1-9198-daca173bce4c"), "actxs-q_02.jpg", new Guid("2eaaba04-80ff-43a6-a746-a74a91c5c0e6"), 0 },
                    { new Guid("d5c65162-7591-48c1-9198-daca173bce5c"), "elbjgb_02.jpg", new Guid("2eaaba04-80ff-43a6-a746-a74a91c5c0e7"), 0 },
                    { new Guid("d5c65162-7591-48c1-9198-daca173bce6c"), "elbjgb-h2_01.jpg", new Guid("2eaaba04-80ff-43a6-a746-a74a91c5c0e7"), 0 },
                    { new Guid("d5c65162-7591-48c1-9198-daca173bce7c"), "elbjgb-h1_01.jpg", new Guid("2eaaba04-80ff-43a6-a746-a74a91c5c0e7"), 0 },
                    { new Guid("d5c65162-7591-48c1-9198-daca173bce8c"), "actxs-q_02.jpg", new Guid("2eaaba04-80ff-43a6-a746-a74a91c5c0e7"), 0 },
                    { new Guid("d5c65162-7591-48c1-9198-daca173bce9c"), "elbjgb_02.jpg", new Guid("2eaaba04-80ff-43a6-a746-a74a91c5c0e8"), 0 },
                    { new Guid("d5c65162-7591-48c1-9198-daca174bce0c"), "elbjgb-h2_01.jpg", new Guid("2eaaba04-80ff-43a6-a746-a74a91c5c0e8"), 0 },
                    { new Guid("d5c65162-7591-48c1-9198-daca174bce1c"), "elbjgb-h1_01.jpg", new Guid("2eaaba04-80ff-43a6-a746-a74a91c5c0e8"), 0 },
                    { new Guid("d5c65162-7591-48c1-9198-daca174bce2c"), "actxs-e_02_1_1.jpg", new Guid("2eaaba04-80ff-43a6-a746-a74a91c5c0e8"), 0 },
                    { new Guid("d5c65162-7591-48c1-9198-daca174bce3c"), "actxs-q_02.jpg", new Guid("2eaaba04-80ff-43a6-a746-a74a91c5c0e8"), 0 },
                    { new Guid("d5c65162-7591-48c1-9198-daca174bce4c"), "elbjgb_02.jpg", new Guid("2eaaba04-80ff-43a6-a746-a74a91c5c0e9"), 0 },
                    { new Guid("d5c65162-7591-48c1-9198-daca174bce5c"), "elbjgb-h2_01.jpg", new Guid("2eaaba04-80ff-43a6-a746-a74a91c5c0e9"), 0 },
                    { new Guid("d5c65162-7591-48c1-9198-daca174bce6c"), "elbjgb-h1_01.jpg", new Guid("2eaaba04-80ff-43a6-a746-a74a91c5c0e9"), 0 },
                    { new Guid("d5c65162-7591-48c1-9198-daca174bce7c"), "actxs-e_02_1_1.jpg", new Guid("2eaaba04-80ff-43a6-a746-a74a91c5c0e9"), 0 },
                    { new Guid("d5c65162-7591-48c1-9198-daca174bce8c"), "actxs-q_02.jpg", new Guid("2eaaba04-80ff-43a6-a746-a74a91c5c0e9"), 0 },
                    { new Guid("d5c65162-7591-48c1-9198-daca174bce9c"), "elbjgb_02.jpg", new Guid("2eaaba04-80ff-43a6-a746-a74a91c5c1e0"), 0 },
                    { new Guid("d5c65162-7591-48c1-9198-daca175bce0c"), "elbjgb-h2_01.jpg", new Guid("2eaaba04-80ff-43a6-a746-a74a91c5c1e0"), 0 },
                    { new Guid("d5c65162-7591-48c1-9198-daca175bce1c"), "elbjgb-h1_01.jpg", new Guid("2eaaba04-80ff-43a6-a746-a74a91c5c1e0"), 0 },
                    { new Guid("d5c65162-7591-48c1-9198-daca175bce2c"), "actxs-e_02_1_1.jpg", new Guid("2eaaba04-80ff-43a6-a746-a74a91c5c1e0"), 0 },
                    { new Guid("d5c65162-7591-48c1-9198-daca175bce3c"), "actxs-q_02.jpg", new Guid("2eaaba04-80ff-43a6-a746-a74a91c5c1e0"), 0 },
                    { new Guid("d5c65162-7591-48c1-9198-daca175bce4c"), "elbjgb_02.jpg", new Guid("2eaaba04-80ff-43a6-a746-a74a91c5c1e1"), 0 },
                    { new Guid("d5c65162-7591-48c1-9198-daca175bce5c"), "elbjgb-h2_01.jpg", new Guid("2eaaba04-80ff-43a6-a746-a74a91c5c1e1"), 0 },
                    { new Guid("d5c65162-7591-48c1-9198-daca175bce6c"), "elbjgb-h1_01.jpg", new Guid("2eaaba04-80ff-43a6-a746-a74a91c5c1e1"), 0 },
                    { new Guid("d5c65162-7591-48c1-9198-daca175bce7c"), "actxs-e_02_1_1.jpg", new Guid("2eaaba04-80ff-43a6-a746-a74a91c5c1e1"), 0 }
                });

            migrationBuilder.InsertData(
                table: "ProductImages",
                columns: new[] { "Id", "Name", "ProductDetailId", "Status" },
                values: new object[,]
                {
                    { new Guid("d5c65162-7591-48c1-9198-daca175bce8c"), "actxs-q_02.jpg", new Guid("2eaaba04-80ff-43a6-a746-a74a91c5c1e1"), 0 },
                    { new Guid("d5c65162-7591-48c1-9198-daca175bce9c"), "elbjgb_02.jpg", new Guid("2eaaba04-80ff-43a6-a746-a74a91c5c1e2"), 0 },
                    { new Guid("d5c65162-7591-48c1-9198-daca176bce0c"), "elbjgb-h2_01.jpg", new Guid("2eaaba04-80ff-43a6-a746-a74a91c5c1e2"), 0 },
                    { new Guid("d5c65162-7591-48c1-9198-daca176bce1c"), "elbjgb-h1_01.jpg", new Guid("2eaaba04-80ff-43a6-a746-a74a91c5c1e2"), 0 },
                    { new Guid("d5c65162-7591-48c1-9198-daca176bce2c"), "actxs-e_02_1_1.jpg", new Guid("2eaaba04-80ff-43a6-a746-a74a91c5c1e2"), 0 },
                    { new Guid("d5c65162-7591-48c1-9198-daca176bce3c"), "actxs-q_02.jpg", new Guid("2eaaba04-80ff-43a6-a746-a74a91c5c1e2"), 0 },
                    { new Guid("d5c65162-7591-48c1-9198-daca176bce4c"), "elbjgb_02.jpg", new Guid("2eaaba04-80ff-43a6-a746-a74a91c5c1e3"), 0 },
                    { new Guid("d5c65162-7591-48c1-9198-daca176bce5c"), "elbjgb-h2_01.jpg", new Guid("2eaaba04-80ff-43a6-a746-a74a91c5c1e3"), 0 },
                    { new Guid("d5c65162-7591-48c1-9198-daca176bce6c"), "elbjgb-h1_01.jpg", new Guid("2eaaba04-80ff-43a6-a746-a74a91c5c1e3"), 0 },
                    { new Guid("d5c65162-7591-48c1-9198-daca176bce7c"), "actxs-e_02_1_1.jpg", new Guid("2eaaba04-80ff-43a6-a746-a74a91c5c1e3"), 0 },
                    { new Guid("d5c65162-7591-48c1-9198-daca176bce8c"), "actxs-q_02.jpg", new Guid("2eaaba04-80ff-43a6-a746-a74a91c5c1e3"), 0 },
                    { new Guid("d5c65162-7591-48c1-9198-daca176bce9c"), "elbjgb_02.jpg", new Guid("2eaaba04-80ff-43a6-a746-a74a91c5c1e4"), 0 },
                    { new Guid("d5c65162-7591-48c1-9198-daca177bce0c"), "elbjgb-h2_01.jpg", new Guid("2eaaba04-80ff-43a6-a746-a74a91c5c1e4"), 0 },
                    { new Guid("d5c65162-7591-48c1-9198-daca177bce1c"), "elbjgb-h1_01.jpg", new Guid("2eaaba04-80ff-43a6-a746-a74a91c5c1e4"), 0 },
                    { new Guid("d5c65162-7591-48c1-9198-daca177bce2c"), "actxs-e_02_1_1.jpg", new Guid("2eaaba04-80ff-43a6-a746-a74a91c5c1e4"), 0 },
                    { new Guid("d5c65162-7591-48c1-9198-daca177bce3c"), "actxs-q_02.jpg", new Guid("2eaaba04-80ff-43a6-a746-a74a91c5c1e4"), 0 },
                    { new Guid("d5c65162-7591-48c1-9198-daca177bce4c"), "elbjgb_02.jpg", new Guid("2eaaba04-80ff-43a6-a746-a74a91c5c1e5"), 0 },
                    { new Guid("d5c65162-7591-48c1-9198-daca177bce5c"), "elbjgb-h2_01.jpg", new Guid("2eaaba04-80ff-43a6-a746-a74a91c5c1e5"), 0 },
                    { new Guid("d5c65162-7591-48c1-9198-daca177bce6c"), "elbjgb-h1_01.jpg", new Guid("2eaaba04-80ff-43a6-a746-a74a91c5c1e5"), 0 },
                    { new Guid("d5c65162-7591-48c1-9198-daca177bce7c"), "actxs-e_02_1_1.jpg", new Guid("2eaaba04-80ff-43a6-a746-a74a91c5c1e5"), 0 },
                    { new Guid("d5c65162-7591-48c1-9198-daca177bce8c"), "actxs-q_02.jpg", new Guid("2eaaba04-80ff-43a6-a746-a74a91c5c1e5"), 0 },
                    { new Guid("d5c65162-7591-48c1-9198-daca177bce9c"), "elbjgb_02.jpg", new Guid("2eaaba04-80ff-43a6-a746-a74a91c5c1e6"), 0 },
                    { new Guid("d5c65162-7591-48c1-9198-daca178bce0c"), "elbjgb-h2_01.jpg", new Guid("2eaaba04-80ff-43a6-a746-a74a91c5c1e6"), 0 },
                    { new Guid("d5c65162-7591-48c1-9198-daca178bce1c"), "elbjgb-h1_01.jpg", new Guid("2eaaba04-80ff-43a6-a746-a74a91c5c1e6"), 0 },
                    { new Guid("d5c65162-7591-48c1-9198-daca178bce2c"), "actxs-e_02_1_1.jpg", new Guid("2eaaba04-80ff-43a6-a746-a74a91c5c1e6"), 0 },
                    { new Guid("d5c65162-7591-48c1-9198-daca178bce3c"), "actxs-q_02.jpg", new Guid("2eaaba04-80ff-43a6-a746-a74a91c5c1e6"), 0 },
                    { new Guid("d5c65162-7591-48c1-9198-daca178bce4c"), "elbjgb_02.jpg", new Guid("2eaaba04-80ff-43a6-a746-a74a91c5c1e7"), 0 },
                    { new Guid("d5c65162-7591-48c1-9198-daca178bce5c"), "elbjgb-h2_01.jpg", new Guid("2eaaba04-80ff-43a6-a746-a74a91c5c1e7"), 0 },
                    { new Guid("d5c65162-7591-48c1-9198-daca178bce6c"), "elbjgb-h1_01.jpg", new Guid("2eaaba04-80ff-43a6-a746-a74a91c5c1e7"), 0 },
                    { new Guid("d5c65162-7591-48c1-9198-daca178bce7c"), "actxs-e_02_1_1.jpg", new Guid("2eaaba04-80ff-43a6-a746-a74a91c5c1e7"), 0 },
                    { new Guid("d5c65162-7591-48c1-9198-daca178bce8c"), "actxs-q_02.jpg", new Guid("2eaaba04-80ff-43a6-a746-a74a91c5c1e7"), 0 },
                    { new Guid("d5c65162-7591-48c1-9198-daca178bce9c"), "elbjgb_02.jpg", new Guid("2eaaba04-80ff-43a6-a746-a74a91c5c1e8"), 0 },
                    { new Guid("d5c65162-7591-48c1-9198-daca179bce0c"), "elbjgb-h2_01.jpg", new Guid("2eaaba04-80ff-43a6-a746-a74a91c5c1e8"), 0 },
                    { new Guid("d5c65162-7591-48c1-9198-daca179bce1c"), "elbjgb-h1_01.jpg", new Guid("2eaaba04-80ff-43a6-a746-a74a91c5c1e8"), 0 },
                    { new Guid("d5c65162-7591-48c1-9198-daca179bce2c"), "actxs-e_02_1_1.jpg", new Guid("2eaaba04-80ff-43a6-a746-a74a91c5c1e8"), 0 },
                    { new Guid("d5c65162-7591-48c1-9198-daca179bce3c"), "actxs-q_02.jpg", new Guid("2eaaba04-80ff-43a6-a746-a74a91c5c1e8"), 0 },
                    { new Guid("d5c65162-7591-48c1-9198-daca179bce4c"), "elbjgb_02.jpg", new Guid("2eaaba04-80ff-43a6-a746-a74a91c5c1e9"), 0 },
                    { new Guid("d5c65162-7591-48c1-9198-daca179bce5c"), "elbjgb-h2_01.jpg", new Guid("2eaaba04-80ff-43a6-a746-a74a91c5c1e9"), 0 },
                    { new Guid("d5c65162-7591-48c1-9198-daca179bce6c"), "elbjgb-h1_01.jpg", new Guid("2eaaba04-80ff-43a6-a746-a74a91c5c1e9"), 0 },
                    { new Guid("d5c65162-7591-48c1-9198-daca179bce7c"), "actxs-e_02_1_1.jpg", new Guid("2eaaba04-80ff-43a6-a746-a74a91c5c1e9"), 0 },
                    { new Guid("d5c65162-7591-48c1-9198-daca179bce8c"), "actxs-q_02.jpg", new Guid("2eaaba04-80ff-43a6-a746-a74a91c5c1e9"), 0 },
                    { new Guid("d5c65162-7591-48c1-9198-daca179bce9c"), "elbjgb_02.jpg", new Guid("2eaaba04-80ff-43a6-a746-a74a91c5c2e0"), 0 }
                });

            migrationBuilder.InsertData(
                table: "ProductImages",
                columns: new[] { "Id", "Name", "ProductDetailId", "Status" },
                values: new object[,]
                {
                    { new Guid("d5c65162-7591-48c1-9198-daca180bce0c"), "elbjgb-h2_01.jpg", new Guid("2eaaba04-80ff-43a6-a746-a74a91c5c2e0"), 0 },
                    { new Guid("d5c65162-7591-48c1-9198-daca180bce1c"), "elbjgb-h1_01.jpg", new Guid("2eaaba04-80ff-43a6-a746-a74a91c5c2e0"), 0 },
                    { new Guid("d5c65162-7591-48c1-9198-daca180bce2c"), "actxs-e_02_1_1.jpg", new Guid("2eaaba04-80ff-43a6-a746-a74a91c5c2e0"), 0 },
                    { new Guid("d5c65162-7591-48c1-9198-daca180bce3c"), "actxs-q_02.jpg", new Guid("2eaaba04-80ff-43a6-a746-a74a91c5c2e0"), 0 },
                    { new Guid("d5c65162-7591-48c1-9198-daca180bce4c"), "elbjgb_02.jpg", new Guid("2eaaba04-80ff-43a6-a746-a74a91c5c2e1"), 0 },
                    { new Guid("d5c65162-7591-48c1-9198-daca180bce5c"), "elbjgb-h2_01.jpg", new Guid("2eaaba04-80ff-43a6-a746-a74a91c5c2e1"), 0 },
                    { new Guid("d5c65162-7591-48c1-9198-daca180bce6c"), "elbjgb-h1_01.jpg", new Guid("2eaaba04-80ff-43a6-a746-a74a91c5c2e1"), 0 },
                    { new Guid("d5c65162-7591-48c1-9198-daca180bce7c"), "actxs-e_02_1_1.jpg", new Guid("2eaaba04-80ff-43a6-a746-a74a91c5c2e1"), 0 },
                    { new Guid("d5c65162-7591-48c1-9198-daca180bce8c"), "actxs-q_02.jpg", new Guid("2eaaba04-80ff-43a6-a746-a74a91c5c2e1"), 0 },
                    { new Guid("d5c65162-7591-48c1-9198-daca180bce9c"), "elbjgb_02.jpg", new Guid("2eaaba04-80ff-43a6-a746-a74a91c5c2e2"), 0 },
                    { new Guid("d5c65162-7591-48c1-9198-daca181bce0c"), "elbjgb-h2_01.jpg", new Guid("2eaaba04-80ff-43a6-a746-a74a91c5c2e2"), 0 },
                    { new Guid("d5c65162-7591-48c1-9198-daca181bce1c"), "elbjgb-h1_01.jpg", new Guid("2eaaba04-80ff-43a6-a746-a74a91c5c2e2"), 0 },
                    { new Guid("d5c65162-7591-48c1-9198-daca181bce2c"), "actxs-e_02_1_1.jpg", new Guid("2eaaba04-80ff-43a6-a746-a74a91c5c2e2"), 0 },
                    { new Guid("d5c65162-7591-48c1-9198-daca181bce3c"), "actxs-q_02.jpg", new Guid("2eaaba04-80ff-43a6-a746-a74a91c5c2e2"), 0 },
                    { new Guid("d5c65162-7591-48c1-9198-daca181bce4c"), "elbjgb_02.jpg", new Guid("2eaaba04-80ff-43a6-a746-a74a91c5c2e3"), 0 },
                    { new Guid("d5c65162-7591-48c1-9198-daca181bce5c"), "elbjgb-h2_01.jpg", new Guid("2eaaba04-80ff-43a6-a746-a74a91c5c2e3"), 0 },
                    { new Guid("d5c65162-7591-48c1-9198-daca181bce6c"), "elbjgb-h1_01.jpg", new Guid("2eaaba04-80ff-43a6-a746-a74a91c5c2e3"), 0 },
                    { new Guid("d5c65162-7591-48c1-9198-daca181bce7c"), "actxs-e_02_1_1.jpg", new Guid("2eaaba04-80ff-43a6-a746-a74a91c5c2e3"), 0 },
                    { new Guid("d5c65162-7591-48c1-9198-daca181bce8c"), "actxs-q_02.jpg", new Guid("2eaaba04-80ff-43a6-a746-a74a91c5c2e3"), 0 },
                    { new Guid("d5c65162-7591-48c1-9198-daca181bce9c"), "elbjgb_02.jpg", new Guid("2eaaba04-80ff-43a6-a746-a74a91c5c2e4"), 0 },
                    { new Guid("d5c65162-7591-48c1-9198-daca182bce0c"), "elbjgb-h2_01.jpg", new Guid("2eaaba04-80ff-43a6-a746-a74a91c5c2e4"), 0 },
                    { new Guid("d5c65162-7591-48c1-9198-daca182bce1c"), "elbjgb-h1_01.jpg", new Guid("2eaaba04-80ff-43a6-a746-a74a91c5c2e4"), 0 },
                    { new Guid("d5c65162-7591-48c1-9198-daca182bce2c"), "actxs-e_02_1_1.jpg", new Guid("2eaaba04-80ff-43a6-a746-a74a91c5c2e4"), 0 },
                    { new Guid("d5c65162-7591-48c1-9198-daca182bce3c"), "actxs-q_02.jpg", new Guid("2eaaba04-80ff-43a6-a746-a74a91c5c2e4"), 0 },
                    { new Guid("d5c65162-7591-48c1-9198-daca182bce4c"), "elbjgb_02.jpg", new Guid("2eaaba04-80ff-43a6-a746-a74a91c5c2e5"), 0 },
                    { new Guid("d5c65162-7591-48c1-9198-daca182bce5c"), "elbjgb-h2_01.jpg", new Guid("2eaaba04-80ff-43a6-a746-a74a91c5c2e5"), 0 },
                    { new Guid("d5c65162-7591-48c1-9198-daca182bce6c"), "elbjgb-h1_01.jpg", new Guid("2eaaba04-80ff-43a6-a746-a74a91c5c2e5"), 0 },
                    { new Guid("d5c65162-7591-48c1-9198-daca182bce7c"), "actxs-e_02_1_1.jpg", new Guid("2eaaba04-80ff-43a6-a746-a74a91c5c2e5"), 0 },
                    { new Guid("d5c65162-7591-48c1-9198-daca182bce8c"), "actxs-q_02.jpg", new Guid("2eaaba04-80ff-43a6-a746-a74a91c5c2e5"), 0 },
                    { new Guid("d5c65162-7591-48c1-9198-daca182bce9c"), "elbjgb_02.jpg", new Guid("2eaaba04-80ff-43a6-a746-a74a91c5c2e6"), 0 },
                    { new Guid("d5c65162-7591-48c1-9198-daca183bce0c"), "elbjgb-h2_01.jpg", new Guid("2eaaba04-80ff-43a6-a746-a74a91c5c2e6"), 0 },
                    { new Guid("d5c65162-7591-48c1-9198-daca183bce1c"), "elbjgb-h1_01.jpg", new Guid("2eaaba04-80ff-43a6-a746-a74a91c5c2e6"), 0 },
                    { new Guid("d5c65162-7591-48c1-9198-daca183bce2c"), "actxs-e_02_1_1.jpg", new Guid("2eaaba04-80ff-43a6-a746-a74a91c5c2e6"), 0 },
                    { new Guid("d5c65162-7591-48c1-9198-daca183bce3c"), "actxs-q_02.jpg", new Guid("2eaaba04-80ff-43a6-a746-a74a91c5c2e6"), 0 },
                    { new Guid("d5c65162-7591-48c1-9198-daca183bce4c"), "elbjgb_02.jpg", new Guid("2eaaba04-80ff-43a6-a746-a74a91c5c2e7"), 0 },
                    { new Guid("d5c65162-7591-48c1-9198-daca183bce5c"), "elbjgb-h2_01.jpg", new Guid("2eaaba04-80ff-43a6-a746-a74a91c5c2e7"), 0 },
                    { new Guid("d5c65162-7591-48c1-9198-daca183bce6c"), "elbjgb-h1_01.jpg", new Guid("2eaaba04-80ff-43a6-a746-a74a91c5c2e7"), 0 },
                    { new Guid("d5c65162-7591-48c1-9198-daca183bce7c"), "actxs-e_02_1_1.jpg", new Guid("2eaaba04-80ff-43a6-a746-a74a91c5c2e7"), 0 },
                    { new Guid("d5c65162-7591-48c1-9198-daca183bce8c"), "actxs-q_02.jpg", new Guid("2eaaba04-80ff-43a6-a746-a74a91c5c2e7"), 0 },
                    { new Guid("d5c65162-7591-48c1-9198-daca183bce9c"), "elbjgb_02.jpg", new Guid("2eaaba04-80ff-43a6-a746-a74a91c5c2e8"), 0 },
                    { new Guid("d5c65162-7591-48c1-9198-daca184bce0c"), "elbjgb-h2_01.jpg", new Guid("2eaaba04-80ff-43a6-a746-a74a91c5c2e8"), 0 },
                    { new Guid("d5c65162-7591-48c1-9198-daca184bce1c"), "elbjgb-h1_01.jpg", new Guid("2eaaba04-80ff-43a6-a746-a74a91c5c2e8"), 0 }
                });

            migrationBuilder.InsertData(
                table: "ProductImages",
                columns: new[] { "Id", "Name", "ProductDetailId", "Status" },
                values: new object[,]
                {
                    { new Guid("d5c65162-7591-48c1-9198-daca184bce2c"), "actxs-e_02_1_1.jpg", new Guid("2eaaba04-80ff-43a6-a746-a74a91c5c2e8"), 0 },
                    { new Guid("d5c65162-7591-48c1-9198-daca184bce3c"), "actxs-q_02.jpg", new Guid("2eaaba04-80ff-43a6-a746-a74a91c5c2e8"), 0 },
                    { new Guid("d5c65162-7591-48c1-9198-daca184bce4c"), "elbjgb_02.jpg", new Guid("2eaaba04-80ff-43a6-a746-a74a91c5c2e9"), 0 },
                    { new Guid("d5c65162-7591-48c1-9198-daca184bce5c"), "elbjgb-h2_01.jpg", new Guid("2eaaba04-80ff-43a6-a746-a74a91c5c2e9"), 0 },
                    { new Guid("d5c65162-7591-48c1-9198-daca184bce6c"), "elbjgb-h1_01.jpg", new Guid("2eaaba04-80ff-43a6-a746-a74a91c5c2e9"), 0 },
                    { new Guid("d5c65162-7591-48c1-9198-daca184bce7c"), "actxs-e_02_1_1.jpg", new Guid("2eaaba04-80ff-43a6-a746-a74a91c5c2e9"), 0 },
                    { new Guid("d5c65162-7591-48c1-9198-daca184bce8c"), "actxs-q_02.jpg", new Guid("2eaaba04-80ff-43a6-a746-a74a91c5c2e9"), 0 },
                    { new Guid("d5c65162-7591-48c1-9198-daca184bce9c"), "elbjgb_02.jpg", new Guid("2eaaba04-80ff-43a6-a746-a74a91c5c3e0"), 0 },
                    { new Guid("d5c65162-7591-48c1-9198-daca185bce0c"), "elbjgb-h2_01.jpg", new Guid("2eaaba04-80ff-43a6-a746-a74a91c5c3e0"), 0 },
                    { new Guid("d5c65162-7591-48c1-9198-daca185bce1c"), "elbjgb-h1_01.jpg", new Guid("2eaaba04-80ff-43a6-a746-a74a91c5c3e0"), 0 },
                    { new Guid("d5c65162-7591-48c1-9198-daca185bce2c"), "actxs-e_02_1_1.jpg", new Guid("2eaaba04-80ff-43a6-a746-a74a91c5c3e0"), 0 },
                    { new Guid("d5c65162-7591-48c1-9198-daca185bce3c"), "actxs-q_02.jpg", new Guid("2eaaba04-80ff-43a6-a746-a74a91c5c3e0"), 0 },
                    { new Guid("d5c65162-7591-48c1-9198-daca185bce4c"), "elbjgb_02.jpg", new Guid("2eaaba04-80ff-43a6-a746-a74a91c5c3e1"), 0 },
                    { new Guid("d5c65162-7591-48c1-9198-daca185bce5c"), "elbjgb-h2_01.jpg", new Guid("2eaaba04-80ff-43a6-a746-a74a91c5c3e1"), 0 },
                    { new Guid("d5c65162-7591-48c1-9198-daca185bce6c"), "elbjgb-h1_01.jpg", new Guid("2eaaba04-80ff-43a6-a746-a74a91c5c3e1"), 0 },
                    { new Guid("d5c65162-7591-48c1-9198-daca185bce7c"), "actxs-e_02_1_1.jpg", new Guid("2eaaba04-80ff-43a6-a746-a74a91c5c3e1"), 0 },
                    { new Guid("d5c65162-7591-48c1-9198-daca185bce8c"), "actxs-q_02.jpg", new Guid("2eaaba04-80ff-43a6-a746-a74a91c5c3e1"), 0 },
                    { new Guid("d5c65162-7591-48c1-9198-daca185bce9c"), "elbjgb_02.jpg", new Guid("2eaaba04-80ff-43a6-a746-a74a91c5c3e2"), 0 },
                    { new Guid("d5c65162-7591-48c1-9198-daca186bce0c"), "elbjgb-h2_01.jpg", new Guid("2eaaba04-80ff-43a6-a746-a74a91c5c3e2"), 0 },
                    { new Guid("d5c65162-7591-48c1-9198-daca186bce1c"), "elbjgb-h1_01.jpg", new Guid("2eaaba04-80ff-43a6-a746-a74a91c5c3e2"), 0 },
                    { new Guid("d5c65162-7591-48c1-9198-daca186bce2c"), "actxs-e_02_1_1.jpg", new Guid("2eaaba04-80ff-43a6-a746-a74a91c5c3e2"), 0 },
                    { new Guid("d5c65162-7591-48c1-9198-daca186bce3c"), "actxs-q_02.jpg", new Guid("2eaaba04-80ff-43a6-a746-a74a91c5c3e2"), 0 },
                    { new Guid("d5c65162-7591-48c1-9198-daca186bce4c"), "elbjgb_02.jpg", new Guid("2eaaba04-80ff-43a6-a746-a74a91c5c3e3"), 0 },
                    { new Guid("d5c65162-7591-48c1-9198-daca186bce5c"), "elbjgb-h2_01.jpg", new Guid("2eaaba04-80ff-43a6-a746-a74a91c5c3e3"), 0 },
                    { new Guid("d5c65162-7591-48c1-9198-daca186bce6c"), "elbjgb-h1_01.jpg", new Guid("2eaaba04-80ff-43a6-a746-a74a91c5c3e3"), 0 },
                    { new Guid("d5c65162-7591-48c1-9198-daca186bce7c"), "actxs-e_02_1_1.jpg", new Guid("2eaaba04-80ff-43a6-a746-a74a91c5c3e3"), 0 },
                    { new Guid("d5c65162-7591-48c1-9198-daca186bce8c"), "actxs-q_02.jpg", new Guid("2eaaba04-80ff-43a6-a746-a74a91c5c3e3"), 0 },
                    { new Guid("d5c65162-7591-48c1-9198-daca186bce9c"), "elbjgb_02.jpg", new Guid("2eaaba04-80ff-43a6-a746-a74a91c5c3e4"), 0 },
                    { new Guid("d5c65162-7591-48c1-9198-daca187bce0c"), "elbjgb-h2_01.jpg", new Guid("2eaaba04-80ff-43a6-a746-a74a91c5c3e4"), 0 },
                    { new Guid("d5c65162-7591-48c1-9198-daca187bce1c"), "elbjgb-h1_01.jpg", new Guid("2eaaba04-80ff-43a6-a746-a74a91c5c3e4"), 0 },
                    { new Guid("d5c65162-7591-48c1-9198-daca187bce2c"), "actxs-e_02_1_1.jpg", new Guid("2eaaba04-80ff-43a6-a746-a74a91c5c3e4"), 0 },
                    { new Guid("d5c65162-7591-48c1-9198-daca187bce3c"), "actxs-q_02.jpg", new Guid("2eaaba04-80ff-43a6-a746-a74a91c5c3e4"), 0 },
                    { new Guid("d5c65162-7591-48c1-9198-daca187bce4c"), "elbjgb_02.jpg", new Guid("2eaaba04-80ff-43a6-a746-a74a91c5c3e5"), 0 },
                    { new Guid("d5c65162-7591-48c1-9198-daca187bce5c"), "elbjgb-h2_01.jpg", new Guid("2eaaba04-80ff-43a6-a746-a74a91c5c3e5"), 0 },
                    { new Guid("d5c65162-7591-48c1-9198-daca187bce6c"), "elbjgb-h1_01.jpg", new Guid("2eaaba04-80ff-43a6-a746-a74a91c5c3e5"), 0 },
                    { new Guid("d5c65162-7591-48c1-9198-daca187bce7c"), "actxs-e_02_1_1.jpg", new Guid("2eaaba04-80ff-43a6-a746-a74a91c5c3e5"), 0 },
                    { new Guid("d5c65162-7591-48c1-9198-daca187bce8c"), "actxs-q_02.jpg", new Guid("2eaaba04-80ff-43a6-a746-a74a91c5c3e5"), 0 },
                    { new Guid("d5c65162-7591-48c1-9198-daca187bce9c"), "elbjgb_02.jpg", new Guid("2eaaba04-80ff-43a6-a746-a74a91c5c3e6"), 0 },
                    { new Guid("d5c65162-7591-48c1-9198-daca188bce0c"), "elbjgb-h2_01.jpg", new Guid("2eaaba04-80ff-43a6-a746-a74a91c5c3e6"), 0 },
                    { new Guid("d5c65162-7591-48c1-9198-daca188bce1c"), "elbjgb-h1_01.jpg", new Guid("2eaaba04-80ff-43a6-a746-a74a91c5c3e6"), 0 },
                    { new Guid("d5c65162-7591-48c1-9198-daca188bce2c"), "actxs-e_02_1_1.jpg", new Guid("2eaaba04-80ff-43a6-a746-a74a91c5c3e6"), 0 },
                    { new Guid("d5c65162-7591-48c1-9198-daca188bce3c"), "actxs-q_02.jpg", new Guid("2eaaba04-80ff-43a6-a746-a74a91c5c3e6"), 0 }
                });

            migrationBuilder.InsertData(
                table: "ProductImages",
                columns: new[] { "Id", "Name", "ProductDetailId", "Status" },
                values: new object[,]
                {
                    { new Guid("d5c65162-7591-48c1-9198-daca188bce4c"), "elbjgb_02.jpg", new Guid("2eaaba04-80ff-43a6-a746-a74a91c5c3e7"), 0 },
                    { new Guid("d5c65162-7591-48c1-9198-daca188bce5c"), "elbjgb-h2_01.jpg", new Guid("2eaaba04-80ff-43a6-a746-a74a91c5c3e7"), 0 },
                    { new Guid("d5c65162-7591-48c1-9198-daca188bce6c"), "elbjgb-h1_01.jpg", new Guid("2eaaba04-80ff-43a6-a746-a74a91c5c3e7"), 0 },
                    { new Guid("d5c65162-7591-48c1-9198-daca188bce7c"), "actxs-e_02_1_1.jpg", new Guid("2eaaba04-80ff-43a6-a746-a74a91c5c3e7"), 0 },
                    { new Guid("d5c65162-7591-48c1-9198-daca188bce8c"), "actxs-q_02.jpg", new Guid("2eaaba04-80ff-43a6-a746-a74a91c5c3e7"), 0 },
                    { new Guid("d5c65162-7591-48c1-9198-daca188bce9c"), "elbjgb_02.jpg", new Guid("2eaaba04-80ff-43a6-a746-a74a91c5c3e8"), 0 },
                    { new Guid("d5c65162-7591-48c1-9198-daca189bce0c"), "elbjgb-h2_01.jpg", new Guid("2eaaba04-80ff-43a6-a746-a74a91c5c3e8"), 0 },
                    { new Guid("d5c65162-7591-48c1-9198-daca189bce1c"), "elbjgb-h1_01.jpg", new Guid("2eaaba04-80ff-43a6-a746-a74a91c5c3e8"), 0 },
                    { new Guid("d5c65162-7591-48c1-9198-daca189bce2c"), "actxs-e_02_1_1.jpg", new Guid("2eaaba04-80ff-43a6-a746-a74a91c5c3e8"), 0 },
                    { new Guid("d5c65162-7591-48c1-9198-daca189bce3c"), "actxs-q_02.jpg", new Guid("2eaaba04-80ff-43a6-a746-a74a91c5c3e8"), 0 },
                    { new Guid("d5c65162-7591-48c1-9198-daca189bce4c"), "elbjgb_02.jpg", new Guid("2eaaba04-80ff-43a6-a746-a74a91c5c3e9"), 0 },
                    { new Guid("d5c65162-7591-48c1-9198-daca189bce5c"), "elbjgb-h2_01.jpg", new Guid("2eaaba04-80ff-43a6-a746-a74a91c5c3e9"), 0 },
                    { new Guid("d5c65162-7591-48c1-9198-daca189bce6c"), "elbjgb-h1_01.jpg", new Guid("2eaaba04-80ff-43a6-a746-a74a91c5c3e9"), 0 },
                    { new Guid("d5c65162-7591-48c1-9198-daca189bce7c"), "actxs-e_02_1_1.jpg", new Guid("2eaaba04-80ff-43a6-a746-a74a91c5c3e9"), 0 },
                    { new Guid("d5c65162-7591-48c1-9198-daca189bce8c"), "actxs-q_02.jpg", new Guid("2eaaba04-80ff-43a6-a746-a74a91c5c3e9"), 0 },
                    { new Guid("d5c65162-7591-48c1-9198-daca189bce9c"), "elbjgb_02.jpg", new Guid("2eaaba04-80ff-43a6-a746-a74a91c6c0e0"), 0 },
                    { new Guid("d5c65162-7591-48c1-9198-daca190bce0c"), "elbjgb-h2_01.jpg", new Guid("2eaaba04-80ff-43a6-a746-a74a91c6c0e0"), 0 },
                    { new Guid("d5c65162-7591-48c1-9198-daca190bce1c"), "elbjgb-h1_01.jpg", new Guid("2eaaba04-80ff-43a6-a746-a74a91c6c0e0"), 0 },
                    { new Guid("d5c65162-7591-48c1-9198-daca190bce2c"), "actxs-e_02_1_1.jpg", new Guid("2eaaba04-80ff-43a6-a746-a74a91c6c0e0"), 0 },
                    { new Guid("d5c65162-7591-48c1-9198-daca190bce3c"), "actxs-q_02.jpg", new Guid("2eaaba04-80ff-43a6-a746-a74a91c6c0e0"), 0 },
                    { new Guid("d5c65162-7591-48c1-9198-daca190bce4c"), "elbjgb_02.jpg", new Guid("2eaaba04-80ff-43a6-a746-a74a91c6c0e1"), 0 },
                    { new Guid("d5c65162-7591-48c1-9198-daca190bce5c"), "elbjgb-h2_01.jpg", new Guid("2eaaba04-80ff-43a6-a746-a74a91c6c0e1"), 0 },
                    { new Guid("d5c65162-7591-48c1-9198-daca190bce6c"), "elbjgb-h1_01.jpg", new Guid("2eaaba04-80ff-43a6-a746-a74a91c6c0e1"), 0 },
                    { new Guid("d5c65162-7591-48c1-9198-daca190bce7c"), "actxs-e_02_1_1.jpg", new Guid("2eaaba04-80ff-43a6-a746-a74a91c6c0e1"), 0 },
                    { new Guid("d5c65162-7591-48c1-9198-daca190bce8c"), "actxs-q_02.jpg", new Guid("2eaaba04-80ff-43a6-a746-a74a91c6c0e1"), 0 },
                    { new Guid("d5c65162-7591-48c1-9198-daca190bce9c"), "elbjgb_02.jpg", new Guid("2eaaba04-80ff-43a6-a746-a74a91c6c0e2"), 0 },
                    { new Guid("d5c65162-7591-48c1-9198-daca191bce0c"), "elbjgb-h2_01.jpg", new Guid("2eaaba04-80ff-43a6-a746-a74a91c6c0e2"), 0 },
                    { new Guid("d5c65162-7591-48c1-9198-daca191bce1c"), "elbjgb-h1_01.jpg", new Guid("2eaaba04-80ff-43a6-a746-a74a91c6c0e2"), 0 },
                    { new Guid("d5c65162-7591-48c1-9198-daca191bce2c"), "actxs-e_02_1_1.jpg", new Guid("2eaaba04-80ff-43a6-a746-a74a91c6c0e2"), 0 },
                    { new Guid("d5c65162-7591-48c1-9198-daca191bce3c"), "actxs-q_02.jpg", new Guid("2eaaba04-80ff-43a6-a746-a74a91c6c0e2"), 0 },
                    { new Guid("d5c65162-7591-48c1-9198-daca191bce4c"), "elbjgb_02.jpg", new Guid("2eaaba04-80ff-43a6-a746-a74a91c6c0e3"), 0 },
                    { new Guid("d5c65162-7591-48c1-9198-daca191bce5c"), "elbjgb-h2_01.jpg", new Guid("2eaaba04-80ff-43a6-a746-a74a91c6c0e3"), 0 },
                    { new Guid("d5c65162-7591-48c1-9198-daca191bce6c"), "elbjgb-h1_01.jpg", new Guid("2eaaba04-80ff-43a6-a746-a74a91c6c0e3"), 0 },
                    { new Guid("d5c65162-7591-48c1-9198-daca191bce7c"), "actxs-e_02_1_1.jpg", new Guid("2eaaba04-80ff-43a6-a746-a74a91c6c0e3"), 0 },
                    { new Guid("d5c65162-7591-48c1-9198-daca191bce8c"), "actxs-q_02.jpg", new Guid("2eaaba04-80ff-43a6-a746-a74a91c6c0e3"), 0 },
                    { new Guid("d5c65162-7591-48c1-9198-daca191bce9c"), "elbjgb_02.jpg", new Guid("2eaaba04-80ff-43a6-a746-a74a91c6c0e4"), 0 },
                    { new Guid("d5c65162-7591-48c1-9198-daca192bce0c"), "elbjgb-h2_01.jpg", new Guid("2eaaba04-80ff-43a6-a746-a74a91c6c0e4"), 0 },
                    { new Guid("d5c65162-7591-48c1-9198-daca192bce1c"), "elbjgb-h1_01.jpg", new Guid("2eaaba04-80ff-43a6-a746-a74a91c6c0e4"), 0 },
                    { new Guid("d5c65162-7591-48c1-9198-daca192bce2c"), "actxs-e_02_1_1.jpg", new Guid("2eaaba04-80ff-43a6-a746-a74a91c6c0e4"), 0 },
                    { new Guid("d5c65162-7591-48c1-9198-daca192bce3c"), "actxs-q_02.jpg", new Guid("2eaaba04-80ff-43a6-a746-a74a91c6c0e4"), 0 },
                    { new Guid("d5c65162-7591-48c1-9198-daca192bce4c"), "elbjgb_02.jpg", new Guid("2eaaba04-80ff-43a6-a746-a74a91c6c0e5"), 0 },
                    { new Guid("d5c65162-7591-48c1-9198-daca192bce5c"), "elbjgb-h2_01.jpg", new Guid("2eaaba04-80ff-43a6-a746-a74a91c6c0e5"), 0 }
                });

            migrationBuilder.InsertData(
                table: "ProductImages",
                columns: new[] { "Id", "Name", "ProductDetailId", "Status" },
                values: new object[,]
                {
                    { new Guid("d5c65162-7591-48c1-9198-daca192bce6c"), "elbjgb-h1_01.jpg", new Guid("2eaaba04-80ff-43a6-a746-a74a91c6c0e5"), 0 },
                    { new Guid("d5c65162-7591-48c1-9198-daca192bce7c"), "actxs-e_02_1_1.jpg", new Guid("2eaaba04-80ff-43a6-a746-a74a91c6c0e5"), 0 },
                    { new Guid("d5c65162-7591-48c1-9198-daca192bce8c"), "actxs-q_02.jpg", new Guid("2eaaba04-80ff-43a6-a746-a74a91c6c0e5"), 0 },
                    { new Guid("d5c65162-7591-48c1-9198-daca192bce9c"), "elbjgb_02.jpg", new Guid("2eaaba04-80ff-43a6-a746-a74a91c6c0e6"), 0 },
                    { new Guid("d5c65162-7591-48c1-9198-daca193bce0c"), "elbjgb-h2_01.jpg", new Guid("2eaaba04-80ff-43a6-a746-a74a91c6c0e6"), 0 },
                    { new Guid("d5c65162-7591-48c1-9198-daca193bce1c"), "elbjgb-h1_01.jpg", new Guid("2eaaba04-80ff-43a6-a746-a74a91c6c0e6"), 0 },
                    { new Guid("d5c65162-7591-48c1-9198-daca193bce2c"), "actxs-e_02_1_1.jpg", new Guid("2eaaba04-80ff-43a6-a746-a74a91c6c0e6"), 0 },
                    { new Guid("d5c65162-7591-48c1-9198-daca193bce3c"), "actxs-q_02.jpg", new Guid("2eaaba04-80ff-43a6-a746-a74a91c6c0e6"), 0 },
                    { new Guid("d5c65162-7591-48c1-9198-daca193bce4c"), "elbjgb_02.jpg", new Guid("2eaaba04-80ff-43a6-a746-a74a91c6c0e7"), 0 },
                    { new Guid("d5c65162-7591-48c1-9198-daca193bce5c"), "elbjgb-h2_01.jpg", new Guid("2eaaba04-80ff-43a6-a746-a74a91c6c0e7"), 0 },
                    { new Guid("d5c65162-7591-48c1-9198-daca193bce6c"), "elbjgb-h1_01.jpg", new Guid("2eaaba04-80ff-43a6-a746-a74a91c6c0e7"), 0 },
                    { new Guid("d5c65162-7591-48c1-9198-daca193bce7c"), "actxs-e_02_1_1.jpg", new Guid("2eaaba04-80ff-43a6-a746-a74a91c6c0e7"), 0 },
                    { new Guid("d5c65162-7591-48c1-9198-daca193bce8c"), "actxs-q_02.jpg", new Guid("2eaaba04-80ff-43a6-a746-a74a91c6c0e7"), 0 },
                    { new Guid("d5c65162-7591-48c1-9198-daca193bce9c"), "elbjgb_02.jpg", new Guid("2eaaba04-80ff-43a6-a746-a74a91c6c0e8"), 0 },
                    { new Guid("d5c65162-7591-48c1-9198-daca194bce0c"), "elbjgb-h2_01.jpg", new Guid("2eaaba04-80ff-43a6-a746-a74a91c6c0e8"), 0 },
                    { new Guid("d5c65162-7591-48c1-9198-daca194bce1c"), "elbjgb-h1_01.jpg", new Guid("2eaaba04-80ff-43a6-a746-a74a91c6c0e8"), 0 },
                    { new Guid("d5c65162-7591-48c1-9198-daca194bce2c"), "actxs-e_02_1_1.jpg", new Guid("2eaaba04-80ff-43a6-a746-a74a91c6c0e8"), 0 },
                    { new Guid("d5c65162-7591-48c1-9198-daca194bce3c"), "elbjgb_02.jpg", new Guid("2eaaba04-80ff-43a6-a746-a74a91c6c0e9"), 0 },
                    { new Guid("d5c65162-7591-48c1-9198-daca194bce4c"), "elbjgb-h2_01.jpg", new Guid("2eaaba04-80ff-43a6-a746-a74a91c6c0e9"), 0 },
                    { new Guid("d5c65162-7591-48c1-9198-daca194bce5c"), "elbjgb-h1_01.jpg", new Guid("2eaaba04-80ff-43a6-a746-a74a91c6c0e9"), 0 },
                    { new Guid("d5c65162-7591-48c1-9198-daca194bce6c"), "actxs-e_02_1_1.jpg", new Guid("2eaaba04-80ff-43a6-a746-a74a91c6c0e9"), 0 },
                    { new Guid("d5c65162-7591-48c1-9198-daca194bce7c"), "actxs-q_02.jpg", new Guid("2eaaba04-80ff-43a6-a746-a74a91c6c0e9"), 0 },
                    { new Guid("d5c65162-7591-48c1-9198-daca194bce8c"), "elbjgb_02.jpg", new Guid("2eaaba04-80ff-43a6-a746-a74a91c6c1e0"), 0 },
                    { new Guid("d5c65162-7591-48c1-9198-daca194bce9c"), "elbjgb-h2_01.jpg", new Guid("2eaaba04-80ff-43a6-a746-a74a91c6c1e0"), 0 },
                    { new Guid("d5c65162-7591-48c1-9198-daca195bce0c"), "elbjgb-h1_01.jpg", new Guid("2eaaba04-80ff-43a6-a746-a74a91c6c1e0"), 0 },
                    { new Guid("d5c65162-7591-48c1-9198-daca195bce1c"), "actxs-e_02_1_1.jpg", new Guid("2eaaba04-80ff-43a6-a746-a74a91c6c1e0"), 0 },
                    { new Guid("d5c65162-7591-48c1-9198-daca195bce2c"), "actxs-q_02.jpg", new Guid("2eaaba04-80ff-43a6-a746-a74a91c6c1e0"), 0 },
                    { new Guid("d5c65162-7591-48c1-9198-daca195bce3c"), "elbjgb_02.jpg", new Guid("2eaaba04-80ff-43a6-a746-a74a91c6c1e1"), 0 },
                    { new Guid("d5c65162-7591-48c1-9198-daca195bce4c"), "elbjgb-h2_01.jpg", new Guid("2eaaba04-80ff-43a6-a746-a74a91c6c1e1"), 0 },
                    { new Guid("d5c65162-7591-48c1-9198-daca195bce5c"), "elbjgb-h1_01.jpg", new Guid("2eaaba04-80ff-43a6-a746-a74a91c6c1e1"), 0 },
                    { new Guid("d5c65162-7591-48c1-9198-daca195bce6c"), "actxs-e_02_1_1.jpg", new Guid("2eaaba04-80ff-43a6-a746-a74a91c6c1e1"), 0 },
                    { new Guid("d5c65162-7591-48c1-9198-daca195bce7c"), "actxs-q_02.jpg", new Guid("2eaaba04-80ff-43a6-a746-a74a91c6c1e1"), 0 },
                    { new Guid("d5c65162-7591-48c1-9198-daca195bce8c"), "elbjgb_02.jpg", new Guid("2eaaba04-80ff-43a6-a746-a74a91c6c1e2"), 0 },
                    { new Guid("d5c65162-7591-48c1-9198-daca195bce9c"), "elbjgb-h2_01.jpg", new Guid("2eaaba04-80ff-43a6-a746-a74a91c6c1e2"), 0 },
                    { new Guid("d5c65162-7591-48c1-9198-daca196bce0c"), "elbjgb-h1_01.jpg", new Guid("2eaaba04-80ff-43a6-a746-a74a91c6c1e2"), 0 },
                    { new Guid("d5c65162-7591-48c1-9198-daca196bce1c"), "actxs-e_02_1_1.jpg", new Guid("2eaaba04-80ff-43a6-a746-a74a91c6c1e2"), 0 },
                    { new Guid("d5c65162-7591-48c1-9198-daca196bce2c"), "actxs-q_02.jpg", new Guid("2eaaba04-80ff-43a6-a746-a74a91c6c1e2"), 0 },
                    { new Guid("d5c65162-7591-48c1-9198-daca196bce3c"), "elbjgb_02.jpg", new Guid("2eaaba04-80ff-43a6-a746-a74a91c6c1e3"), 0 },
                    { new Guid("d5c65162-7591-48c1-9198-daca196bce4c"), "elbjgb-h2_01.jpg", new Guid("2eaaba04-80ff-43a6-a746-a74a91c6c1e3"), 0 },
                    { new Guid("d5c65162-7591-48c1-9198-daca196bce5c"), "elbjgb-h1_01.jpg", new Guid("2eaaba04-80ff-43a6-a746-a74a91c6c1e3"), 0 },
                    { new Guid("d5c65162-7591-48c1-9198-daca196bce6c"), "actxs-e_02_1_1.jpg", new Guid("2eaaba04-80ff-43a6-a746-a74a91c6c1e3"), 0 },
                    { new Guid("d5c65162-7591-48c1-9198-daca196bce7c"), "actxs-q_02.jpg", new Guid("2eaaba04-80ff-43a6-a746-a74a91c6c1e3"), 0 }
                });

            migrationBuilder.InsertData(
                table: "ProductImages",
                columns: new[] { "Id", "Name", "ProductDetailId", "Status" },
                values: new object[,]
                {
                    { new Guid("d5c65162-7591-48c1-9198-daca196bce8c"), "elbjgb_02.jpg", new Guid("2eaaba04-80ff-43a6-a746-a74a91c6c1e4"), 0 },
                    { new Guid("d5c65162-7591-48c1-9198-daca196bce9c"), "elbjgb-h2_01.jpg", new Guid("2eaaba04-80ff-43a6-a746-a74a91c6c1e4"), 0 },
                    { new Guid("d5c65162-7591-48c1-9198-daca197bce0c"), "elbjgb-h1_01.jpg", new Guid("2eaaba04-80ff-43a6-a746-a74a91c6c1e4"), 0 },
                    { new Guid("d5c65162-7591-48c1-9198-daca197bce1c"), "actxs-e_02_1_1.jpg", new Guid("2eaaba04-80ff-43a6-a746-a74a91c6c1e4"), 0 },
                    { new Guid("d5c65162-7591-48c1-9198-daca197bce2c"), "actxs-q_02.jpg", new Guid("2eaaba04-80ff-43a6-a746-a74a91c6c1e4"), 0 },
                    { new Guid("d5c65162-7591-48c1-9198-daca197bce3c"), "elbjgb_02.jpg", new Guid("2eaaba04-80ff-43a6-a746-a74a91c6c1e5"), 0 },
                    { new Guid("d5c65162-7591-48c1-9198-daca197bce4c"), "elbjgb-h2_01.jpg", new Guid("2eaaba04-80ff-43a6-a746-a74a91c6c1e5"), 0 },
                    { new Guid("d5c65162-7591-48c1-9198-daca197bce5c"), "elbjgb-h1_01.jpg", new Guid("2eaaba04-80ff-43a6-a746-a74a91c6c1e5"), 0 },
                    { new Guid("d5c65162-7591-48c1-9198-daca197bce6c"), "actxs-e_02_1_1.jpg", new Guid("2eaaba04-80ff-43a6-a746-a74a91c6c1e5"), 0 },
                    { new Guid("d5c65162-7591-48c1-9198-daca197bce7c"), "actxs-q_02.jpg", new Guid("2eaaba04-80ff-43a6-a746-a74a91c6c1e5"), 0 },
                    { new Guid("d5c65162-7591-48c1-9198-daca197bce8c"), "elbjgb_02.jpg", new Guid("2eaaba04-80ff-43a6-a746-a74a91c6c1e6"), 0 },
                    { new Guid("d5c65162-7591-48c1-9198-daca197bce9c"), "elbjgb-h2_01.jpg", new Guid("2eaaba04-80ff-43a6-a746-a74a91c6c1e6"), 0 },
                    { new Guid("d5c65162-7591-48c1-9198-daca198bce0c"), "elbjgb-h1_01.jpg", new Guid("2eaaba04-80ff-43a6-a746-a74a91c6c1e6"), 0 },
                    { new Guid("d5c65162-7591-48c1-9198-daca198bce1c"), "actxs-e_02_1_1.jpg", new Guid("2eaaba04-80ff-43a6-a746-a74a91c6c1e6"), 0 },
                    { new Guid("d5c65162-7591-48c1-9198-daca198bce2c"), "actxs-q_02.jpg", new Guid("2eaaba04-80ff-43a6-a746-a74a91c6c1e6"), 0 },
                    { new Guid("d5c65162-7591-48c1-9198-daca198bce3c"), "elbjgb_02.jpg", new Guid("2eaaba04-80ff-43a6-a746-a74a91c6c1e7"), 0 },
                    { new Guid("d5c65162-7591-48c1-9198-daca198bce4c"), "elbjgb-h2_01.jpg", new Guid("2eaaba04-80ff-43a6-a746-a74a91c6c1e7"), 0 },
                    { new Guid("d5c65162-7591-48c1-9198-daca198bce5c"), "elbjgb-h1_01.jpg", new Guid("2eaaba04-80ff-43a6-a746-a74a91c6c1e7"), 0 },
                    { new Guid("d5c65162-7591-48c1-9198-daca198bce6c"), "actxs-e_02_1_1.jpg", new Guid("2eaaba04-80ff-43a6-a746-a74a91c6c1e7"), 0 },
                    { new Guid("d5c65162-7591-48c1-9198-daca198bce7c"), "actxs-q_02.jpg", new Guid("2eaaba04-80ff-43a6-a746-a74a91c6c1e7"), 0 },
                    { new Guid("d5c65162-7591-48c1-9198-daca198bce8c"), "elbjgb_02.jpg", new Guid("2eaaba04-80ff-43a6-a746-a74a91c6c1e8"), 0 },
                    { new Guid("d5c65162-7591-48c1-9198-daca198bce9c"), "elbjgb-h2_01.jpg", new Guid("2eaaba04-80ff-43a6-a746-a74a91c6c1e8"), 0 },
                    { new Guid("d5c65162-7591-48c1-9198-daca199bce0c"), "elbjgb-h1_01.jpg", new Guid("2eaaba04-80ff-43a6-a746-a74a91c6c1e8"), 0 },
                    { new Guid("d5c65162-7591-48c1-9198-daca199bce1c"), "actxs-e_02_1_1.jpg", new Guid("2eaaba04-80ff-43a6-a746-a74a91c6c1e8"), 0 },
                    { new Guid("d5c65162-7591-48c1-9198-daca199bce2c"), "actxs-q_02.jpg", new Guid("2eaaba04-80ff-43a6-a746-a74a91c6c1e8"), 0 },
                    { new Guid("d5c65162-7591-48c1-9198-daca199bce3c"), "elbjgb_02.jpg", new Guid("2eaaba04-80ff-43a6-a746-a74a91c6c1e9"), 0 },
                    { new Guid("d5c65162-7591-48c1-9198-daca199bce4c"), "elbjgb-h2_01.jpg", new Guid("2eaaba04-80ff-43a6-a746-a74a91c6c1e9"), 0 },
                    { new Guid("d5c65162-7591-48c1-9198-daca199bce5c"), "elbjgb-h1_01.jpg", new Guid("2eaaba04-80ff-43a6-a746-a74a91c6c1e9"), 0 },
                    { new Guid("d5c65162-7591-48c1-9198-daca199bce6c"), "actxs-e_02_1_1.jpg", new Guid("2eaaba04-80ff-43a6-a746-a74a91c6c1e9"), 0 },
                    { new Guid("d5c65162-7591-48c1-9198-daca199bce7c"), "actxs-q_02.jpg", new Guid("2eaaba04-80ff-43a6-a746-a74a91c6c1e9"), 0 },
                    { new Guid("d5c65162-7591-48c1-9198-daca199bce8c"), "elbjgb_02.jpg", new Guid("2eaaba04-80ff-43a6-a746-a74a91c6c2e0"), 0 },
                    { new Guid("d5c65162-7591-48c1-9198-daca199bce9c"), "elbjgb-h2_01.jpg", new Guid("2eaaba04-80ff-43a6-a746-a74a91c6c2e0"), 0 },
                    { new Guid("d5c65162-7591-48c1-9198-daca200bce0c"), "elbjgb-h1_01.jpg", new Guid("2eaaba04-80ff-43a6-a746-a74a91c6c2e0"), 0 },
                    { new Guid("d5c65162-7591-48c1-9198-daca200bce1c"), "actxs-e_02_1_1.jpg", new Guid("2eaaba04-80ff-43a6-a746-a74a91c6c2e0"), 0 },
                    { new Guid("d5c65162-7591-48c1-9198-daca200bce2c"), "actxs-q_02.jpg", new Guid("2eaaba04-80ff-43a6-a746-a74a91c6c2e0"), 0 },
                    { new Guid("d5c65162-7591-48c1-9198-daca200bce3c"), "elbjgb_02.jpg", new Guid("2eaaba04-80ff-43a6-a746-a74a91c6c2e1"), 0 },
                    { new Guid("d5c65162-7591-48c1-9198-daca200bce4c"), "elbjgb-h2_01.jpg", new Guid("2eaaba04-80ff-43a6-a746-a74a91c6c2e1"), 0 },
                    { new Guid("d5c65162-7591-48c1-9198-daca200bce5c"), "elbjgb-h1_01.jpg", new Guid("2eaaba04-80ff-43a6-a746-a74a91c6c2e1"), 0 },
                    { new Guid("d5c65162-7591-48c1-9198-daca200bce6c"), "actxs-e_02_1_1.jpg", new Guid("2eaaba04-80ff-43a6-a746-a74a91c6c2e1"), 0 },
                    { new Guid("d5c65162-7591-48c1-9198-daca200bce7c"), "actxs-q_02.jpg", new Guid("2eaaba04-80ff-43a6-a746-a74a91c6c2e1"), 0 },
                    { new Guid("d5c65162-7591-48c1-9198-daca200bce8c"), "elbjgb_02.jpg", new Guid("2eaaba04-80ff-43a6-a746-a74a91c6c2e2"), 0 },
                    { new Guid("d5c65162-7591-48c1-9198-daca200bce9c"), "elbjgb-h2_01.jpg", new Guid("2eaaba04-80ff-43a6-a746-a74a91c6c2e2"), 0 }
                });

            migrationBuilder.InsertData(
                table: "ProductImages",
                columns: new[] { "Id", "Name", "ProductDetailId", "Status" },
                values: new object[,]
                {
                    { new Guid("d5c65162-7591-48c1-9198-daca201bce0c"), "elbjgb-h1_01.jpg", new Guid("2eaaba04-80ff-43a6-a746-a74a91c6c2e2"), 0 },
                    { new Guid("d5c65162-7591-48c1-9198-daca201bce1c"), "actxs-e_02_1_1.jpg", new Guid("2eaaba04-80ff-43a6-a746-a74a91c6c2e2"), 0 },
                    { new Guid("d5c65162-7591-48c1-9198-daca201bce2c"), "actxs-q_02.jpg", new Guid("2eaaba04-80ff-43a6-a746-a74a91c6c2e2"), 0 },
                    { new Guid("d5c65162-7591-48c1-9198-daca201bce3c"), "elbjgb_02.jpg", new Guid("2eaaba04-80ff-43a6-a746-a74a91c6c2e3"), 0 },
                    { new Guid("d5c65162-7591-48c1-9198-daca201bce4c"), "elbjgb-h2_01.jpg", new Guid("2eaaba04-80ff-43a6-a746-a74a91c6c2e3"), 0 },
                    { new Guid("d5c65162-7591-48c1-9198-daca201bce5c"), "elbjgb-h1_01.jpg", new Guid("2eaaba04-80ff-43a6-a746-a74a91c6c2e3"), 0 },
                    { new Guid("d5c65162-7591-48c1-9198-daca201bce6c"), "actxs-e_02_1_1.jpg", new Guid("2eaaba04-80ff-43a6-a746-a74a91c6c2e3"), 0 },
                    { new Guid("d5c65162-7591-48c1-9198-daca201bce7c"), "actxs-q_02.jpg", new Guid("2eaaba04-80ff-43a6-a746-a74a91c6c2e3"), 0 },
                    { new Guid("d5c65162-7591-48c1-9198-daca201bce8c"), "elbjgb_02.jpg", new Guid("2eaaba04-80ff-43a6-a746-a74a91c6c2e4"), 0 },
                    { new Guid("d5c65162-7591-48c1-9198-daca201bce9c"), "elbjgb-h2_01.jpg", new Guid("2eaaba04-80ff-43a6-a746-a74a91c6c2e4"), 0 },
                    { new Guid("d5c65162-7591-48c1-9198-daca202bce0c"), "elbjgb-h1_01.jpg", new Guid("2eaaba04-80ff-43a6-a746-a74a91c6c2e4"), 0 },
                    { new Guid("d5c65162-7591-48c1-9198-daca202bce1c"), "actxs-e_02_1_1.jpg", new Guid("2eaaba04-80ff-43a6-a746-a74a91c6c2e4"), 0 },
                    { new Guid("d5c65162-7591-48c1-9198-daca202bce2c"), "actxs-q_02.jpg", new Guid("2eaaba04-80ff-43a6-a746-a74a91c6c2e4"), 0 },
                    { new Guid("d5c65162-7591-48c1-9198-daca202bce3c"), "elbjgb_02.jpg", new Guid("2eaaba04-80ff-43a6-a746-a74a91c6c2e5"), 0 },
                    { new Guid("d5c65162-7591-48c1-9198-daca202bce4c"), "elbjgb-h2_01.jpg", new Guid("2eaaba04-80ff-43a6-a746-a74a91c6c2e5"), 0 },
                    { new Guid("d5c65162-7591-48c1-9198-daca202bce5c"), "elbjgb-h1_01.jpg", new Guid("2eaaba04-80ff-43a6-a746-a74a91c6c2e5"), 0 },
                    { new Guid("d5c65162-7591-48c1-9198-daca202bce6c"), "actxs-e_02_1_1.jpg", new Guid("2eaaba04-80ff-43a6-a746-a74a91c6c2e5"), 0 },
                    { new Guid("d5c65162-7591-48c1-9198-daca202bce7c"), "actxs-q_02.jpg", new Guid("2eaaba04-80ff-43a6-a746-a74a91c6c2e5"), 0 },
                    { new Guid("d5c65162-7591-48c1-9198-daca202bce8c"), "elbjgb_02.jpg", new Guid("2eaaba04-80ff-43a6-a746-a74a91c6c2e6"), 0 },
                    { new Guid("d5c65162-7591-48c1-9198-daca202bce9c"), "elbjgb-h2_01.jpg", new Guid("2eaaba04-80ff-43a6-a746-a74a91c6c2e6"), 0 },
                    { new Guid("d5c65162-7591-48c1-9198-daca203bce0c"), "elbjgb-h1_01.jpg", new Guid("2eaaba04-80ff-43a6-a746-a74a91c6c2e6"), 0 },
                    { new Guid("d5c65162-7591-48c1-9198-daca203bce1c"), "actxs-e_02_1_1.jpg", new Guid("2eaaba04-80ff-43a6-a746-a74a91c6c2e6"), 0 },
                    { new Guid("d5c65162-7591-48c1-9198-daca203bce2c"), "actxs-q_02.jpg", new Guid("2eaaba04-80ff-43a6-a746-a74a91c6c2e6"), 0 },
                    { new Guid("d5c65162-7591-48c1-9198-daca203bce3c"), "elbjgb_02.jpg", new Guid("2eaaba04-80ff-43a6-a746-a74a91c6c2e7"), 0 },
                    { new Guid("d5c65162-7591-48c1-9198-daca203bce4c"), "elbjgb-h2_01.jpg", new Guid("2eaaba04-80ff-43a6-a746-a74a91c6c2e7"), 0 },
                    { new Guid("d5c65162-7591-48c1-9198-daca203bce5c"), "elbjgb-h1_01.jpg", new Guid("2eaaba04-80ff-43a6-a746-a74a91c6c2e7"), 0 },
                    { new Guid("d5c65162-7591-48c1-9198-daca203bce6c"), "actxs-e_02_1_1.jpg", new Guid("2eaaba04-80ff-43a6-a746-a74a91c6c2e7"), 0 },
                    { new Guid("d5c65162-7591-48c1-9198-daca203bce7c"), "actxs-q_02.jpg", new Guid("2eaaba04-80ff-43a6-a746-a74a91c6c2e7"), 0 },
                    { new Guid("d5c65162-7591-48c1-9198-daca203bce8c"), "elbjgb_02.jpg", new Guid("2eaaba04-80ff-43a6-a746-a74a91c6c2e8"), 0 },
                    { new Guid("d5c65162-7591-48c1-9198-daca203bce9c"), "elbjgb-h2_01.jpg", new Guid("2eaaba04-80ff-43a6-a746-a74a91c6c2e8"), 0 },
                    { new Guid("d5c65162-7591-48c1-9198-daca204bce0c"), "elbjgb-h1_01.jpg", new Guid("2eaaba04-80ff-43a6-a746-a74a91c6c2e8"), 0 },
                    { new Guid("d5c65162-7591-48c1-9198-daca204bce1c"), "actxs-e_02_1_1.jpg", new Guid("2eaaba04-80ff-43a6-a746-a74a91c6c2e8"), 0 },
                    { new Guid("d5c65162-7591-48c1-9198-daca204bce2c"), "actxs-q_02.jpg", new Guid("2eaaba04-80ff-43a6-a746-a74a91c6c2e8"), 0 },
                    { new Guid("d5c65162-7591-48c1-9198-daca204bce3c"), "elbjgb_02.jpg", new Guid("2eaaba04-80ff-43a6-a746-a74a91c6c2e9"), 0 },
                    { new Guid("d5c65162-7591-48c1-9198-daca204bce4c"), "elbjgb-h2_01.jpg", new Guid("2eaaba04-80ff-43a6-a746-a74a91c6c2e9"), 0 },
                    { new Guid("d5c65162-7591-48c1-9198-daca204bce5c"), "elbjgb-h1_01.jpg", new Guid("2eaaba04-80ff-43a6-a746-a74a91c6c2e9"), 0 },
                    { new Guid("d5c65162-7591-48c1-9198-daca204bce6c"), "actxs-e_02_1_1.jpg", new Guid("2eaaba04-80ff-43a6-a746-a74a91c6c2e9"), 0 },
                    { new Guid("d5c65162-7591-48c1-9198-daca204bce7c"), "actxs-q_02.jpg", new Guid("2eaaba04-80ff-43a6-a746-a74a91c6c2e9"), 0 },
                    { new Guid("d5c65162-7591-48c1-9198-daca204bce8c"), "elbjgb_02.jpg", new Guid("2eaaba04-80ff-43a6-a746-a74a91c6c3e0"), 0 },
                    { new Guid("d5c65162-7591-48c1-9198-daca204bce9c"), "elbjgb-h2_01.jpg", new Guid("2eaaba04-80ff-43a6-a746-a74a91c6c3e0"), 0 },
                    { new Guid("d5c65162-7591-48c1-9198-daca205bce0c"), "elbjgb-h1_01.jpg", new Guid("2eaaba04-80ff-43a6-a746-a74a91c6c3e0"), 0 },
                    { new Guid("d5c65162-7591-48c1-9198-daca205bce1c"), "actxs-e_02_1_1.jpg", new Guid("2eaaba04-80ff-43a6-a746-a74a91c6c3e0"), 0 }
                });

            migrationBuilder.InsertData(
                table: "ProductImages",
                columns: new[] { "Id", "Name", "ProductDetailId", "Status" },
                values: new object[,]
                {
                    { new Guid("d5c65162-7591-48c1-9198-daca205bce2c"), "actxs-q_02.jpg", new Guid("2eaaba04-80ff-43a6-a746-a74a91c6c3e0"), 0 },
                    { new Guid("d5c65162-7591-48c1-9198-daca205bce3c"), "elbjgb_02.jpg", new Guid("2eaaba04-80ff-43a6-a746-a74a91c6c3e1"), 0 },
                    { new Guid("d5c65162-7591-48c1-9198-daca205bce4c"), "elbjgb-h2_01.jpg", new Guid("2eaaba04-80ff-43a6-a746-a74a91c6c3e1"), 0 },
                    { new Guid("d5c65162-7591-48c1-9198-daca205bce5c"), "elbjgb-h1_01.jpg", new Guid("2eaaba04-80ff-43a6-a746-a74a91c6c3e1"), 0 },
                    { new Guid("d5c65162-7591-48c1-9198-daca205bce6c"), "actxs-e_02_1_1.jpg", new Guid("2eaaba04-80ff-43a6-a746-a74a91c6c3e1"), 0 },
                    { new Guid("d5c65162-7591-48c1-9198-daca205bce7c"), "actxs-q_02.jpg", new Guid("2eaaba04-80ff-43a6-a746-a74a91c6c3e1"), 0 },
                    { new Guid("d5c65162-7591-48c1-9198-daca205bce8c"), "elbjgb_02.jpg", new Guid("2eaaba04-80ff-43a6-a746-a74a91c6c3e2"), 0 },
                    { new Guid("d5c65162-7591-48c1-9198-daca205bce9c"), "elbjgb-h2_01.jpg", new Guid("2eaaba04-80ff-43a6-a746-a74a91c6c3e2"), 0 },
                    { new Guid("d5c65162-7591-48c1-9198-daca206bce0c"), "elbjgb-h1_01.jpg", new Guid("2eaaba04-80ff-43a6-a746-a74a91c6c3e2"), 0 },
                    { new Guid("d5c65162-7591-48c1-9198-daca206bce1c"), "actxs-e_02_1_1.jpg", new Guid("2eaaba04-80ff-43a6-a746-a74a91c6c3e2"), 0 },
                    { new Guid("d5c65162-7591-48c1-9198-daca206bce2c"), "actxs-q_02.jpg", new Guid("2eaaba04-80ff-43a6-a746-a74a91c6c3e2"), 0 },
                    { new Guid("d5c65162-7591-48c1-9198-daca206bce3c"), "elbjgb_02.jpg", new Guid("2eaaba04-80ff-43a6-a746-a74a91c6c3e3"), 0 },
                    { new Guid("d5c65162-7591-48c1-9198-daca206bce4c"), "elbjgb-h2_01.jpg", new Guid("2eaaba04-80ff-43a6-a746-a74a91c6c3e3"), 0 },
                    { new Guid("d5c65162-7591-48c1-9198-daca206bce5c"), "elbjgb-h1_01.jpg", new Guid("2eaaba04-80ff-43a6-a746-a74a91c6c3e3"), 0 },
                    { new Guid("d5c65162-7591-48c1-9198-daca206bce6c"), "actxs-e_02_1_1.jpg", new Guid("2eaaba04-80ff-43a6-a746-a74a91c6c3e3"), 0 },
                    { new Guid("d5c65162-7591-48c1-9198-daca206bce7c"), "actxs-q_02.jpg", new Guid("2eaaba04-80ff-43a6-a746-a74a91c6c3e3"), 0 },
                    { new Guid("d5c65162-7591-48c1-9198-daca206bce8c"), "elbjgb_02.jpg", new Guid("2eaaba04-80ff-43a6-a746-a74a91c6c3e4"), 0 },
                    { new Guid("d5c65162-7591-48c1-9198-daca206bce9c"), "elbjgb-h2_01.jpg", new Guid("2eaaba04-80ff-43a6-a746-a74a91c6c3e4"), 0 },
                    { new Guid("d5c65162-7591-48c1-9198-daca207bce0c"), "elbjgb-h1_01.jpg", new Guid("2eaaba04-80ff-43a6-a746-a74a91c6c3e4"), 0 },
                    { new Guid("d5c65162-7591-48c1-9198-daca207bce1c"), "actxs-e_02_1_1.jpg", new Guid("2eaaba04-80ff-43a6-a746-a74a91c6c3e4"), 0 },
                    { new Guid("d5c65162-7591-48c1-9198-daca207bce2c"), "actxs-q_02.jpg", new Guid("2eaaba04-80ff-43a6-a746-a74a91c6c3e4"), 0 },
                    { new Guid("d5c65162-7591-48c1-9198-daca207bce3c"), "elbjgb_02.jpg", new Guid("2eaaba04-80ff-43a6-a746-a74a91c6c3e5"), 0 },
                    { new Guid("d5c65162-7591-48c1-9198-daca207bce4c"), "elbjgb-h2_01.jpg", new Guid("2eaaba04-80ff-43a6-a746-a74a91c6c3e5"), 0 },
                    { new Guid("d5c65162-7591-48c1-9198-daca207bce5c"), "elbjgb-h1_01.jpg", new Guid("2eaaba04-80ff-43a6-a746-a74a91c6c3e5"), 0 },
                    { new Guid("d5c65162-7591-48c1-9198-daca207bce6c"), "actxs-e_02_1_1.jpg", new Guid("2eaaba04-80ff-43a6-a746-a74a91c6c3e5"), 0 },
                    { new Guid("d5c65162-7591-48c1-9198-daca207bce7c"), "actxs-q_02.jpg", new Guid("2eaaba04-80ff-43a6-a746-a74a91c6c3e5"), 0 },
                    { new Guid("d5c65162-7591-48c1-9198-daca207bce8c"), "elbjgb_02.jpg", new Guid("2eaaba04-80ff-43a6-a746-a74a91c6c3e6"), 0 },
                    { new Guid("d5c65162-7591-48c1-9198-daca207bce9c"), "elbjgb-h2_01.jpg", new Guid("2eaaba04-80ff-43a6-a746-a74a91c6c3e6"), 0 },
                    { new Guid("d5c65162-7591-48c1-9198-daca208bce0c"), "elbjgb-h1_01.jpg", new Guid("2eaaba04-80ff-43a6-a746-a74a91c6c3e6"), 0 },
                    { new Guid("d5c65162-7591-48c1-9198-daca208bce1c"), "actxs-e_02_1_1.jpg", new Guid("2eaaba04-80ff-43a6-a746-a74a91c6c3e6"), 0 },
                    { new Guid("d5c65162-7591-48c1-9198-daca208bce2c"), "actxs-q_02.jpg", new Guid("2eaaba04-80ff-43a6-a746-a74a91c6c3e6"), 0 },
                    { new Guid("d5c65162-7591-48c1-9198-daca208bce3c"), "elbjgb_02.jpg", new Guid("2eaaba04-80ff-43a6-a746-a74a91c6c3e7"), 0 },
                    { new Guid("d5c65162-7591-48c1-9198-daca208bce4c"), "elbjgb-h2_01.jpg", new Guid("2eaaba04-80ff-43a6-a746-a74a91c6c3e7"), 0 },
                    { new Guid("d5c65162-7591-48c1-9198-daca208bce5c"), "elbjgb-h1_01.jpg", new Guid("2eaaba04-80ff-43a6-a746-a74a91c6c3e7"), 0 },
                    { new Guid("d5c65162-7591-48c1-9198-daca208bce6c"), "actxs-e_02_1_1.jpg", new Guid("2eaaba04-80ff-43a6-a746-a74a91c6c3e7"), 0 },
                    { new Guid("d5c65162-7591-48c1-9198-daca208bce7c"), "actxs-q_02.jpg", new Guid("2eaaba04-80ff-43a6-a746-a74a91c6c3e7"), 0 },
                    { new Guid("d5c65162-7591-48c1-9198-daca208bce8c"), "elbjgb_02.jpg", new Guid("2eaaba04-80ff-43a6-a746-a74a91c6c3e8"), 0 },
                    { new Guid("d5c65162-7591-48c1-9198-daca208bce9c"), "elbjgb-h2_01.jpg", new Guid("2eaaba04-80ff-43a6-a746-a74a91c6c3e8"), 0 },
                    { new Guid("d5c65162-7591-48c1-9198-daca209bce0c"), "elbjgb-h1_01.jpg", new Guid("2eaaba04-80ff-43a6-a746-a74a91c6c3e8"), 0 },
                    { new Guid("d5c65162-7591-48c1-9198-daca209bce1c"), "actxs-e_02_1_1.jpg", new Guid("2eaaba04-80ff-43a6-a746-a74a91c6c3e8"), 0 },
                    { new Guid("d5c65162-7591-48c1-9198-daca209bce2c"), "actxs-q_02.jpg", new Guid("2eaaba04-80ff-43a6-a746-a74a91c6c3e8"), 0 },
                    { new Guid("d5c65162-7591-48c1-9198-daca209bce3c"), "elbjgb_02.jpg", new Guid("2eaaba04-80ff-43a6-a746-a74a91c6c3e9"), 0 }
                });

            migrationBuilder.InsertData(
                table: "ProductImages",
                columns: new[] { "Id", "Name", "ProductDetailId", "Status" },
                values: new object[,]
                {
                    { new Guid("d5c65162-7591-48c1-9198-daca209bce4c"), "elbjgb-h2_01.jpg", new Guid("2eaaba04-80ff-43a6-a746-a74a91c6c3e9"), 0 },
                    { new Guid("d5c65162-7591-48c1-9198-daca209bce5c"), "elbjgb-h1_01.jpg", new Guid("2eaaba04-80ff-43a6-a746-a74a91c6c3e9"), 0 },
                    { new Guid("d5c65162-7591-48c1-9198-daca209bce6c"), "actxs-e_02_1_1.jpg", new Guid("2eaaba04-80ff-43a6-a746-a74a91c6c3e9"), 0 },
                    { new Guid("d5c65162-7591-48c1-9198-daca209bce7c"), "actxs-q_02.jpg", new Guid("2eaaba04-80ff-43a6-a746-a74a91c6c3e9"), 0 },
                    { new Guid("d5c65162-7591-48c1-9198-daca209bce8c"), "elbjgb_02.jpg", new Guid("2eaaba04-80ff-43a6-a746-a74a91c7c0e0"), 0 },
                    { new Guid("d5c65162-7591-48c1-9198-daca209bce9c"), "elbjgb-h2_01.jpg", new Guid("2eaaba04-80ff-43a6-a746-a74a91c7c0e0"), 0 },
                    { new Guid("d5c65162-7591-48c1-9198-daca210bce0c"), "elbjgb-h1_01.jpg", new Guid("2eaaba04-80ff-43a6-a746-a74a91c7c0e0"), 0 },
                    { new Guid("d5c65162-7591-48c1-9198-daca210bce1c"), "actxs-e_02_1_1.jpg", new Guid("2eaaba04-80ff-43a6-a746-a74a91c7c0e0"), 0 },
                    { new Guid("d5c65162-7591-48c1-9198-daca210bce2c"), "actxs-q_02.jpg", new Guid("2eaaba04-80ff-43a6-a746-a74a91c7c0e0"), 0 },
                    { new Guid("d5c65162-7591-48c1-9198-daca210bce3c"), "elbjgb_02.jpg", new Guid("2eaaba04-80ff-43a6-a746-a74a91c7c0e1"), 0 },
                    { new Guid("d5c65162-7591-48c1-9198-daca210bce4c"), "elbjgb-h2_01.jpg", new Guid("2eaaba04-80ff-43a6-a746-a74a91c7c0e1"), 0 },
                    { new Guid("d5c65162-7591-48c1-9198-daca210bce5c"), "elbjgb-h1_01.jpg", new Guid("2eaaba04-80ff-43a6-a746-a74a91c7c0e1"), 0 },
                    { new Guid("d5c65162-7591-48c1-9198-daca210bce6c"), "actxs-e_02_1_1.jpg", new Guid("2eaaba04-80ff-43a6-a746-a74a91c7c0e1"), 0 },
                    { new Guid("d5c65162-7591-48c1-9198-daca210bce7c"), "actxs-q_02.jpg", new Guid("2eaaba04-80ff-43a6-a746-a74a91c7c0e1"), 0 },
                    { new Guid("d5c65162-7591-48c1-9198-daca210bce8c"), "elbjgb_02.jpg", new Guid("2eaaba04-80ff-43a6-a746-a74a91c7c0e2"), 0 },
                    { new Guid("d5c65162-7591-48c1-9198-daca210bce9c"), "elbjgb-h2_01.jpg", new Guid("2eaaba04-80ff-43a6-a746-a74a91c7c0e2"), 0 },
                    { new Guid("d5c65162-7591-48c1-9198-daca211bce0c"), "elbjgb-h1_01.jpg", new Guid("2eaaba04-80ff-43a6-a746-a74a91c7c0e2"), 0 },
                    { new Guid("d5c65162-7591-48c1-9198-daca211bce1c"), "actxs-e_02_1_1.jpg", new Guid("2eaaba04-80ff-43a6-a746-a74a91c7c0e2"), 0 },
                    { new Guid("d5c65162-7591-48c1-9198-daca211bce2c"), "actxs-q_02.jpg", new Guid("2eaaba04-80ff-43a6-a746-a74a91c7c0e2"), 0 },
                    { new Guid("d5c65162-7591-48c1-9198-daca211bce3c"), "elbjgb_02.jpg", new Guid("2eaaba04-80ff-43a6-a746-a74a91c7c0e3"), 0 },
                    { new Guid("d5c65162-7591-48c1-9198-daca211bce4c"), "elbjgb-h2_01.jpg", new Guid("2eaaba04-80ff-43a6-a746-a74a91c7c0e3"), 0 },
                    { new Guid("d5c65162-7591-48c1-9198-daca211bce5c"), "elbjgb-h1_01.jpg", new Guid("2eaaba04-80ff-43a6-a746-a74a91c7c0e3"), 0 },
                    { new Guid("d5c65162-7591-48c1-9198-daca211bce6c"), "actxs-e_02_1_1.jpg", new Guid("2eaaba04-80ff-43a6-a746-a74a91c7c0e3"), 0 },
                    { new Guid("d5c65162-7591-48c1-9198-daca211bce7c"), "actxs-q_02.jpg", new Guid("2eaaba04-80ff-43a6-a746-a74a91c7c0e3"), 0 },
                    { new Guid("d5c65162-7591-48c1-9198-daca211bce8c"), "elbjgb_02.jpg", new Guid("2eaaba04-80ff-43a6-a746-a74a91c7c0e4"), 0 },
                    { new Guid("d5c65162-7591-48c1-9198-daca211bce9c"), "elbjgb-h2_01.jpg", new Guid("2eaaba04-80ff-43a6-a746-a74a91c7c0e4"), 0 },
                    { new Guid("d5c65162-7591-48c1-9198-daca212bce0c"), "elbjgb-h1_01.jpg", new Guid("2eaaba04-80ff-43a6-a746-a74a91c7c0e4"), 0 },
                    { new Guid("d5c65162-7591-48c1-9198-daca212bce1c"), "actxs-e_02_1_1.jpg", new Guid("2eaaba04-80ff-43a6-a746-a74a91c7c0e4"), 0 },
                    { new Guid("d5c65162-7591-48c1-9198-daca212bce2c"), "actxs-q_02.jpg", new Guid("2eaaba04-80ff-43a6-a746-a74a91c7c0e4"), 0 },
                    { new Guid("d5c65162-7591-48c1-9198-daca212bce3c"), "elbjgb_02.jpg", new Guid("2eaaba04-80ff-43a6-a746-a74a91c7c0e5"), 0 },
                    { new Guid("d5c65162-7591-48c1-9198-daca212bce4c"), "elbjgb-h2_01.jpg", new Guid("2eaaba04-80ff-43a6-a746-a74a91c7c0e5"), 0 },
                    { new Guid("d5c65162-7591-48c1-9198-daca212bce5c"), "elbjgb-h1_01.jpg", new Guid("2eaaba04-80ff-43a6-a746-a74a91c7c0e5"), 0 },
                    { new Guid("d5c65162-7591-48c1-9198-daca212bce6c"), "actxs-e_02_1_1.jpg", new Guid("2eaaba04-80ff-43a6-a746-a74a91c7c0e5"), 0 },
                    { new Guid("d5c65162-7591-48c1-9198-daca212bce7c"), "actxs-q_02.jpg", new Guid("2eaaba04-80ff-43a6-a746-a74a91c7c0e5"), 0 },
                    { new Guid("d5c65162-7591-48c1-9198-daca212bce8c"), "elbjgb_02.jpg", new Guid("2eaaba04-80ff-43a6-a746-a74a91c7c0e6"), 0 },
                    { new Guid("d5c65162-7591-48c1-9198-daca212bce9c"), "elbjgb-h2_01.jpg", new Guid("2eaaba04-80ff-43a6-a746-a74a91c7c0e6"), 0 },
                    { new Guid("d5c65162-7591-48c1-9198-daca213bce0c"), "elbjgb-h1_01.jpg", new Guid("2eaaba04-80ff-43a6-a746-a74a91c7c0e8"), 0 },
                    { new Guid("d5c65162-7591-48c1-9198-daca213bce1c"), "actxs-e_02_1_1.jpg", new Guid("2eaaba04-80ff-43a6-a746-a74a91c7c0e8"), 0 },
                    { new Guid("d5c65162-7591-48c1-9198-daca213bce2c"), "actxs-q_02.jpg", new Guid("2eaaba04-80ff-43a6-a746-a74a91c7c0e8"), 0 },
                    { new Guid("d5c65162-7591-48c1-9198-daca213bce3c"), "elbjgb_02.jpg", new Guid("2eaaba04-80ff-43a6-a746-a74a91c7c0e9"), 0 },
                    { new Guid("d5c65162-7591-48c1-9198-daca213bce4c"), "elbjgb-h2_01.jpg", new Guid("2eaaba04-80ff-43a6-a746-a74a91c7c0e9"), 0 },
                    { new Guid("d5c65162-7591-48c1-9198-daca213bce5c"), "elbjgb-h1_01.jpg", new Guid("2eaaba04-80ff-43a6-a746-a74a91c7c0e9"), 0 }
                });

            migrationBuilder.InsertData(
                table: "ProductImages",
                columns: new[] { "Id", "Name", "ProductDetailId", "Status" },
                values: new object[,]
                {
                    { new Guid("d5c65162-7591-48c1-9198-daca213bce6c"), "actxs-e_02_1_1.jpg", new Guid("2eaaba04-80ff-43a6-a746-a74a91c7c0e9"), 0 },
                    { new Guid("d5c65162-7591-48c1-9198-daca213bce7c"), "actxs-q_02.jpg", new Guid("2eaaba04-80ff-43a6-a746-a74a91c7c0e9"), 0 },
                    { new Guid("d5c65162-7591-48c1-9198-daca213bce8c"), "elbjgb_02.jpg", new Guid("2eaaba04-80ff-43a6-a746-a74a91c7c1e0"), 0 },
                    { new Guid("d5c65162-7591-48c1-9198-daca213bce9c"), "elbjgb-h2_01.jpg", new Guid("2eaaba04-80ff-43a6-a746-a74a91c7c1e0"), 0 },
                    { new Guid("d5c65162-7591-48c1-9198-daca214bce0c"), "elbjgb-h1_01.jpg", new Guid("2eaaba04-80ff-43a6-a746-a74a91c7c1e0"), 0 },
                    { new Guid("d5c65162-7591-48c1-9198-daca214bce1c"), "actxs-e_02_1_1.jpg", new Guid("2eaaba04-80ff-43a6-a746-a74a91c7c1e0"), 0 },
                    { new Guid("d5c65162-7591-48c1-9198-daca214bce2c"), "actxs-q_02.jpg", new Guid("2eaaba04-80ff-43a6-a746-a74a91c7c1e0"), 0 },
                    { new Guid("d5c65162-7591-48c1-9198-daca214bce3c"), "elbjgb_02.jpg", new Guid("2eaaba04-80ff-43a6-a746-a74a91c7c1e1"), 0 },
                    { new Guid("d5c65162-7591-48c1-9198-daca214bce4c"), "elbjgb-h2_01.jpg", new Guid("2eaaba04-80ff-43a6-a746-a74a91c7c1e1"), 0 },
                    { new Guid("d5c65162-7591-48c1-9198-daca214bce5c"), "elbjgb-h1_01.jpg", new Guid("2eaaba04-80ff-43a6-a746-a74a91c7c1e1"), 0 },
                    { new Guid("d5c65162-7591-48c1-9198-daca214bce6c"), "actxs-e_02_1_1.jpg", new Guid("2eaaba04-80ff-43a6-a746-a74a91c7c1e1"), 0 },
                    { new Guid("d5c65162-7591-48c1-9198-daca214bce7c"), "actxs-q_02.jpg", new Guid("2eaaba04-80ff-43a6-a746-a74a91c7c1e1"), 0 },
                    { new Guid("d5c65162-7591-48c1-9198-daca214bce8c"), "elbjgb_02.jpg", new Guid("2eaaba04-80ff-43a6-a746-a74a91c7c1e2"), 0 },
                    { new Guid("d5c65162-7591-48c1-9198-daca214bce9c"), "elbjgb-h2_01.jpg", new Guid("2eaaba04-80ff-43a6-a746-a74a91c7c1e2"), 0 },
                    { new Guid("d5c65162-7591-48c1-9198-daca215bce0c"), "elbjgb-h1_01.jpg", new Guid("2eaaba04-80ff-43a6-a746-a74a91c7c1e2"), 0 },
                    { new Guid("d5c65162-7591-48c1-9198-daca215bce1c"), "actxs-e_02_1_1.jpg", new Guid("2eaaba04-80ff-43a6-a746-a74a91c7c1e2"), 0 },
                    { new Guid("d5c65162-7591-48c1-9198-daca215bce2c"), "actxs-q_02.jpg", new Guid("2eaaba04-80ff-43a6-a746-a74a91c7c1e2"), 0 },
                    { new Guid("d5c65162-7591-48c1-9198-daca215bce3c"), "elbjgb_02.jpg", new Guid("2eaaba04-80ff-43a6-a746-a74a91c7c1e3"), 0 },
                    { new Guid("d5c65162-7591-48c1-9198-daca215bce4c"), "elbjgb-h2_01.jpg", new Guid("2eaaba04-80ff-43a6-a746-a74a91c7c1e3"), 0 },
                    { new Guid("d5c65162-7591-48c1-9198-daca215bce5c"), "elbjgb-h1_01.jpg", new Guid("2eaaba04-80ff-43a6-a746-a74a91c7c1e3"), 0 },
                    { new Guid("d5c65162-7591-48c1-9198-daca215bce6c"), "actxs-e_02_1_1.jpg", new Guid("2eaaba04-80ff-43a6-a746-a74a91c7c1e3"), 0 },
                    { new Guid("d5c65162-7591-48c1-9198-daca215bce7c"), "actxs-q_02.jpg", new Guid("2eaaba04-80ff-43a6-a746-a74a91c7c1e3"), 0 },
                    { new Guid("d5c65162-7591-48c1-9198-daca215bce8c"), "elbjgb_02.jpg", new Guid("2eaaba04-80ff-43a6-a746-a74a91c7c1e4"), 0 },
                    { new Guid("d5c65162-7591-48c1-9198-daca215bce9c"), "elbjgb-h2_01.jpg", new Guid("2eaaba04-80ff-43a6-a746-a74a91c7c1e4"), 0 },
                    { new Guid("d5c65162-7591-48c1-9198-daca216bce0c"), "elbjgb-h1_01.jpg", new Guid("2eaaba04-80ff-43a6-a746-a74a91c7c1e4"), 0 },
                    { new Guid("d5c65162-7591-48c1-9198-daca216bce1c"), "actxs-e_02_1_1.jpg", new Guid("2eaaba04-80ff-43a6-a746-a74a91c7c1e4"), 0 },
                    { new Guid("d5c65162-7591-48c1-9198-daca216bce2c"), "actxs-q_02.jpg", new Guid("2eaaba04-80ff-43a6-a746-a74a91c7c1e4"), 0 },
                    { new Guid("d5c65162-7591-48c1-9198-daca216bce3c"), "elbjgb_02.jpg", new Guid("2eaaba04-80ff-43a6-a746-a74a91c7c1e5"), 0 },
                    { new Guid("d5c65162-7591-48c1-9198-daca216bce4c"), "elbjgb-h2_01.jpg", new Guid("2eaaba04-80ff-43a6-a746-a74a91c7c1e5"), 0 },
                    { new Guid("d5c65162-7591-48c1-9198-daca216bce5c"), "elbjgb-h1_01.jpg", new Guid("2eaaba04-80ff-43a6-a746-a74a91c7c1e5"), 0 },
                    { new Guid("d5c65162-7591-48c1-9198-daca216bce6c"), "actxs-e_02_1_1.jpg", new Guid("2eaaba04-80ff-43a6-a746-a74a91c7c1e5"), 0 },
                    { new Guid("d5c65162-7591-48c1-9198-daca216bce7c"), "actxs-q_02.jpg", new Guid("2eaaba04-80ff-43a6-a746-a74a91c7c1e5"), 0 },
                    { new Guid("d5c65162-7591-48c1-9198-daca216bce8c"), "elbjgb_02.jpg", new Guid("2eaaba04-80ff-43a6-a746-a74a91c7c1e6"), 0 },
                    { new Guid("d5c65162-7591-48c1-9198-daca216bce9c"), "elbjgb-h2_01.jpg", new Guid("2eaaba04-80ff-43a6-a746-a74a91c7c1e6"), 0 },
                    { new Guid("d5c65162-7591-48c1-9198-daca217bce0c"), "elbjgb-h1_01.jpg", new Guid("2eaaba04-80ff-43a6-a746-a74a91c7c1e6"), 0 },
                    { new Guid("d5c65162-7591-48c1-9198-daca217bce1c"), "actxs-e_02_1_1.jpg", new Guid("2eaaba04-80ff-43a6-a746-a74a91c7c1e6"), 0 },
                    { new Guid("d5c65162-7591-48c1-9198-daca217bce2c"), "actxs-q_02.jpg", new Guid("2eaaba04-80ff-43a6-a746-a74a91c7c1e6"), 0 },
                    { new Guid("d5c65162-7591-48c1-9198-daca217bce3c"), "elbjgb_02.jpg", new Guid("2eaaba04-80ff-43a6-a746-a74a91c7c1e7"), 0 },
                    { new Guid("d5c65162-7591-48c1-9198-daca217bce4c"), "elbjgb-h2_01.jpg", new Guid("2eaaba04-80ff-43a6-a746-a74a91c7c1e7"), 0 },
                    { new Guid("d5c65162-7591-48c1-9198-daca217bce5c"), "elbjgb-h1_01.jpg", new Guid("2eaaba04-80ff-43a6-a746-a74a91c7c1e7"), 0 },
                    { new Guid("d5c65162-7591-48c1-9198-daca217bce6c"), "actxs-e_02_1_1.jpg", new Guid("2eaaba04-80ff-43a6-a746-a74a91c7c1e7"), 0 },
                    { new Guid("d5c65162-7591-48c1-9198-daca217bce7c"), "actxs-q_02.jpg", new Guid("2eaaba04-80ff-43a6-a746-a74a91c7c1e7"), 0 }
                });

            migrationBuilder.InsertData(
                table: "ProductImages",
                columns: new[] { "Id", "Name", "ProductDetailId", "Status" },
                values: new object[,]
                {
                    { new Guid("d5c65162-7591-48c1-9198-daca217bce8c"), "elbjgb_02.jpg", new Guid("2eaaba04-80ff-43a6-a746-a74a91c7c1e8"), 0 },
                    { new Guid("d5c65162-7591-48c1-9198-daca217bce9c"), "elbjgb-h2_01.jpg", new Guid("2eaaba04-80ff-43a6-a746-a74a91c7c1e8"), 0 },
                    { new Guid("d5c65162-7591-48c1-9198-daca218bce0c"), "elbjgb-h1_01.jpg", new Guid("2eaaba04-80ff-43a6-a746-a74a91c7c1e8"), 0 },
                    { new Guid("d5c65162-7591-48c1-9198-daca218bce1c"), "actxs-e_02_1_1.jpg", new Guid("2eaaba04-80ff-43a6-a746-a74a91c7c1e8"), 0 },
                    { new Guid("d5c65162-7591-48c1-9198-daca218bce2c"), "actxs-q_02.jpg", new Guid("2eaaba04-80ff-43a6-a746-a74a91c7c1e8"), 0 },
                    { new Guid("d5c65162-7591-48c1-9198-daca218bce3c"), "elbjgb_02.jpg", new Guid("2eaaba04-80ff-43a6-a746-a74a91c7c1e9"), 0 },
                    { new Guid("d5c65162-7591-48c1-9198-daca218bce4c"), "elbjgb-h2_01.jpg", new Guid("2eaaba04-80ff-43a6-a746-a74a91c7c1e9"), 0 },
                    { new Guid("d5c65162-7591-48c1-9198-daca218bce5c"), "elbjgb-h1_01.jpg", new Guid("2eaaba04-80ff-43a6-a746-a74a91c7c1e9"), 0 },
                    { new Guid("d5c65162-7591-48c1-9198-daca218bce6c"), "actxs-e_02_1_1.jpg", new Guid("2eaaba04-80ff-43a6-a746-a74a91c7c1e9"), 0 },
                    { new Guid("d5c65162-7591-48c1-9198-daca218bce7c"), "actxs-q_02.jpg", new Guid("2eaaba04-80ff-43a6-a746-a74a91c7c1e9"), 0 },
                    { new Guid("d5c65162-7591-48c1-9198-daca218bce8c"), "elbjgb_02.jpg", new Guid("2eaaba04-80ff-43a6-a746-a74a91c7c2e0"), 0 },
                    { new Guid("d5c65162-7591-48c1-9198-daca218bce9c"), "elbjgb-h2_01.jpg", new Guid("2eaaba04-80ff-43a6-a746-a74a91c7c2e0"), 0 },
                    { new Guid("d5c65162-7591-48c1-9198-daca219bce0c"), "elbjgb-h1_01.jpg", new Guid("2eaaba04-80ff-43a6-a746-a74a91c7c2e0"), 0 },
                    { new Guid("d5c65162-7591-48c1-9198-daca219bce1c"), "actxs-e_02_1_1.jpg", new Guid("2eaaba04-80ff-43a6-a746-a74a91c7c2e0"), 0 },
                    { new Guid("d5c65162-7591-48c1-9198-daca219bce2c"), "actxs-q_02.jpg", new Guid("2eaaba04-80ff-43a6-a746-a74a91c7c2e0"), 0 },
                    { new Guid("d5c65162-7591-48c1-9198-daca219bce3c"), "elbjgb_02.jpg", new Guid("2eaaba04-80ff-43a6-a746-a74a91c7c2e1"), 0 },
                    { new Guid("d5c65162-7591-48c1-9198-daca219bce4c"), "elbjgb-h2_01.jpg", new Guid("2eaaba04-80ff-43a6-a746-a74a91c7c2e1"), 0 },
                    { new Guid("d5c65162-7591-48c1-9198-daca219bce5c"), "elbjgb-h1_01.jpg", new Guid("2eaaba04-80ff-43a6-a746-a74a91c7c2e1"), 0 },
                    { new Guid("d5c65162-7591-48c1-9198-daca219bce6c"), "actxs-e_02_1_1.jpg", new Guid("2eaaba04-80ff-43a6-a746-a74a91c7c2e1"), 0 },
                    { new Guid("d5c65162-7591-48c1-9198-daca219bce7c"), "actxs-q_02.jpg", new Guid("2eaaba04-80ff-43a6-a746-a74a91c7c2e1"), 0 },
                    { new Guid("d5c65162-7591-48c1-9198-daca219bce8c"), "elbjgb_02.jpg", new Guid("2eaaba04-80ff-43a6-a746-a74a91c7c2e2"), 0 },
                    { new Guid("d5c65162-7591-48c1-9198-daca219bce9c"), "elbjgb-h2_01.jpg", new Guid("2eaaba04-80ff-43a6-a746-a74a91c7c2e2"), 0 },
                    { new Guid("d5c65162-7591-48c1-9198-daca220bce0c"), "elbjgb-h1_01.jpg", new Guid("2eaaba04-80ff-43a6-a746-a74a91c7c2e2"), 0 },
                    { new Guid("d5c65162-7591-48c1-9198-daca220bce1c"), "actxs-e_02_1_1.jpg", new Guid("2eaaba04-80ff-43a6-a746-a74a91c7c2e2"), 0 },
                    { new Guid("d5c65162-7591-48c1-9198-daca220bce2c"), "actxs-q_02.jpg", new Guid("2eaaba04-80ff-43a6-a746-a74a91c7c2e2"), 0 },
                    { new Guid("d5c65162-7591-48c1-9198-daca220bce3c"), "elbjgb_02.jpg", new Guid("2eaaba04-80ff-43a6-a746-a74a91c7c2e3"), 0 },
                    { new Guid("d5c65162-7591-48c1-9198-daca220bce4c"), "elbjgb-h2_01.jpg", new Guid("2eaaba04-80ff-43a6-a746-a74a91c7c2e3"), 0 },
                    { new Guid("d5c65162-7591-48c1-9198-daca220bce5c"), "elbjgb-h1_01.jpg", new Guid("2eaaba04-80ff-43a6-a746-a74a91c7c2e3"), 0 },
                    { new Guid("d5c65162-7591-48c1-9198-daca220bce6c"), "actxs-e_02_1_1.jpg", new Guid("2eaaba04-80ff-43a6-a746-a74a91c7c2e3"), 0 },
                    { new Guid("d5c65162-7591-48c1-9198-daca220bce7c"), "actxs-q_02.jpg", new Guid("2eaaba04-80ff-43a6-a746-a74a91c7c2e3"), 0 },
                    { new Guid("d5c65162-7591-48c1-9198-daca220bce8c"), "elbjgb_02.jpg", new Guid("2eaaba04-80ff-43a6-a746-a74a91c7c2e4"), 0 },
                    { new Guid("d5c65162-7591-48c1-9198-daca220bce9c"), "elbjgb-h2_01.jpg", new Guid("2eaaba04-80ff-43a6-a746-a74a91c7c2e4"), 0 },
                    { new Guid("d5c65162-7591-48c1-9198-daca221bce0c"), "elbjgb-h1_01.jpg", new Guid("2eaaba04-80ff-43a6-a746-a74a91c7c2e4"), 0 },
                    { new Guid("d5c65162-7591-48c1-9198-daca221bce1c"), "actxs-e_02_1_1.jpg", new Guid("2eaaba04-80ff-43a6-a746-a74a91c7c2e4"), 0 },
                    { new Guid("d5c65162-7591-48c1-9198-daca221bce2c"), "actxs-q_02.jpg", new Guid("2eaaba04-80ff-43a6-a746-a74a91c7c2e4"), 0 },
                    { new Guid("d5c65162-7591-48c1-9198-daca221bce3c"), "elbjgb_02.jpg", new Guid("2eaaba04-80ff-43a6-a746-a74a91c7c2e5"), 0 },
                    { new Guid("d5c65162-7591-48c1-9198-daca221bce4c"), "elbjgb-h2_01.jpg", new Guid("2eaaba04-80ff-43a6-a746-a74a91c7c2e5"), 0 },
                    { new Guid("d5c65162-7591-48c1-9198-daca221bce5c"), "elbjgb-h1_01.jpg", new Guid("2eaaba04-80ff-43a6-a746-a74a91c7c2e5"), 0 },
                    { new Guid("d5c65162-7591-48c1-9198-daca221bce6c"), "actxs-e_02_1_1.jpg", new Guid("2eaaba04-80ff-43a6-a746-a74a91c7c2e5"), 0 },
                    { new Guid("d5c65162-7591-48c1-9198-daca221bce7c"), "actxs-q_02.jpg", new Guid("2eaaba04-80ff-43a6-a746-a74a91c7c2e5"), 0 },
                    { new Guid("d5c65162-7591-48c1-9198-daca221bce8c"), "elbjgb_02.jpg", new Guid("2eaaba04-80ff-43a6-a746-a74a91c7c2e6"), 0 },
                    { new Guid("d5c65162-7591-48c1-9198-daca221bce9c"), "elbjgb-h2_01.jpg", new Guid("2eaaba04-80ff-43a6-a746-a74a91c7c2e6"), 0 }
                });

            migrationBuilder.InsertData(
                table: "ProductImages",
                columns: new[] { "Id", "Name", "ProductDetailId", "Status" },
                values: new object[,]
                {
                    { new Guid("d5c65162-7591-48c1-9198-daca222bce0c"), "elbjgb-h1_01.jpg", new Guid("2eaaba04-80ff-43a6-a746-a74a91c7c2e6"), 0 },
                    { new Guid("d5c65162-7591-48c1-9198-daca222bce1c"), "actxs-e_02_1_1.jpg", new Guid("2eaaba04-80ff-43a6-a746-a74a91c7c2e6"), 0 },
                    { new Guid("d5c65162-7591-48c1-9198-daca222bce2c"), "actxs-q_02.jpg", new Guid("2eaaba04-80ff-43a6-a746-a74a91c7c2e6"), 0 },
                    { new Guid("d5c65162-7591-48c1-9198-daca222bce3c"), "elbjgb_02.jpg", new Guid("2eaaba04-80ff-43a6-a746-a74a91c7c2e7"), 0 },
                    { new Guid("d5c65162-7591-48c1-9198-daca222bce4c"), "elbjgb-h2_01.jpg", new Guid("2eaaba04-80ff-43a6-a746-a74a91c7c2e7"), 0 },
                    { new Guid("d5c65162-7591-48c1-9198-daca222bce5c"), "elbjgb-h1_01.jpg", new Guid("2eaaba04-80ff-43a6-a746-a74a91c7c2e7"), 0 },
                    { new Guid("d5c65162-7591-48c1-9198-daca222bce6c"), "actxs-e_02_1_1.jpg", new Guid("2eaaba04-80ff-43a6-a746-a74a91c7c2e7"), 0 },
                    { new Guid("d5c65162-7591-48c1-9198-daca222bce7c"), "actxs-q_02.jpg", new Guid("2eaaba04-80ff-43a6-a746-a74a91c7c2e7"), 0 },
                    { new Guid("d5c65162-7591-48c1-9198-daca222bce8c"), "elbjgb_02.jpg", new Guid("2eaaba04-80ff-43a6-a746-a74a91c7c2e8"), 0 },
                    { new Guid("d5c65162-7591-48c1-9198-daca222bce9c"), "elbjgb-h2_01.jpg", new Guid("2eaaba04-80ff-43a6-a746-a74a91c7c2e8"), 0 },
                    { new Guid("d5c65162-7591-48c1-9198-daca223bce0c"), "elbjgb-h1_01.jpg", new Guid("2eaaba04-80ff-43a6-a746-a74a91c7c2e8"), 0 },
                    { new Guid("d5c65162-7591-48c1-9198-daca223bce1c"), "actxs-e_02_1_1.jpg", new Guid("2eaaba04-80ff-43a6-a746-a74a91c7c2e8"), 0 },
                    { new Guid("d5c65162-7591-48c1-9198-daca223bce2c"), "actxs-q_02.jpg", new Guid("2eaaba04-80ff-43a6-a746-a74a91c7c2e8"), 0 },
                    { new Guid("d5c65162-7591-48c1-9198-daca223bce3c"), "elbjgb_02.jpg", new Guid("2eaaba04-80ff-43a6-a746-a74a91c7c2e9"), 0 },
                    { new Guid("d5c65162-7591-48c1-9198-daca223bce4c"), "elbjgb-h2_01.jpg", new Guid("2eaaba04-80ff-43a6-a746-a74a91c7c2e9"), 0 },
                    { new Guid("d5c65162-7591-48c1-9198-daca223bce5c"), "elbjgb-h1_01.jpg", new Guid("2eaaba04-80ff-43a6-a746-a74a91c7c2e9"), 0 },
                    { new Guid("d5c65162-7591-48c1-9198-daca223bce6c"), "actxs-e_02_1_1.jpg", new Guid("2eaaba04-80ff-43a6-a746-a74a91c7c2e9"), 0 },
                    { new Guid("d5c65162-7591-48c1-9198-daca223bce7c"), "actxs-q_02.jpg", new Guid("2eaaba04-80ff-43a6-a746-a74a91c7c2e9"), 0 },
                    { new Guid("d5c65162-7591-48c1-9198-daca223bce8c"), "elbjgb_02.jpg", new Guid("2eaaba04-80ff-43a6-a746-a74a91c7c3e0"), 0 },
                    { new Guid("d5c65162-7591-48c1-9198-daca223bce9c"), "elbjgb-h2_01.jpg", new Guid("2eaaba04-80ff-43a6-a746-a74a91c7c3e0"), 0 },
                    { new Guid("d5c65162-7591-48c1-9198-daca224bce0c"), "elbjgb-h1_01.jpg", new Guid("2eaaba04-80ff-43a6-a746-a74a91c7c3e0"), 0 },
                    { new Guid("d5c65162-7591-48c1-9198-daca224bce1c"), "actxs-e_02_1_1.jpg", new Guid("2eaaba04-80ff-43a6-a746-a74a91c7c3e0"), 0 },
                    { new Guid("d5c65162-7591-48c1-9198-daca224bce2c"), "actxs-q_02.jpg", new Guid("2eaaba04-80ff-43a6-a746-a74a91c7c3e0"), 0 },
                    { new Guid("d5c65162-7591-48c1-9198-daca224bce3c"), "elbjgb_02.jpg", new Guid("2eaaba04-80ff-43a6-a746-a74a91c7c3e1"), 0 },
                    { new Guid("d5c65162-7591-48c1-9198-daca224bce4c"), "elbjgb-h2_01.jpg", new Guid("2eaaba04-80ff-43a6-a746-a74a91c7c3e1"), 0 },
                    { new Guid("d5c65162-7591-48c1-9198-daca224bce5c"), "elbjgb-h1_01.jpg", new Guid("2eaaba04-80ff-43a6-a746-a74a91c7c3e1"), 0 },
                    { new Guid("d5c65162-7591-48c1-9198-daca224bce6c"), "actxs-e_02_1_1.jpg", new Guid("2eaaba04-80ff-43a6-a746-a74a91c7c3e1"), 0 },
                    { new Guid("d5c65162-7591-48c1-9198-daca224bce7c"), "actxs-q_02.jpg", new Guid("2eaaba04-80ff-43a6-a746-a74a91c7c3e1"), 0 },
                    { new Guid("d5c65162-7591-48c1-9198-daca224bce8c"), "elbjgb_02.jpg", new Guid("2eaaba04-80ff-43a6-a746-a74a91c7c3e2"), 0 },
                    { new Guid("d5c65162-7591-48c1-9198-daca224bce9c"), "elbjgb-h2_01.jpg", new Guid("2eaaba04-80ff-43a6-a746-a74a91c7c3e2"), 0 },
                    { new Guid("d5c65162-7591-48c1-9198-daca255bce0c"), "elbjgb-h1_01.jpg", new Guid("2eaaba04-80ff-43a6-a746-a74a91c7c3e2"), 0 },
                    { new Guid("d5c65162-7591-48c1-9198-daca255bce1c"), "actxs-e_02_1_1.jpg", new Guid("2eaaba04-80ff-43a6-a746-a74a91c7c3e2"), 0 },
                    { new Guid("d5c65162-7591-48c1-9198-daca255bce2c"), "actxs-q_02.jpg", new Guid("2eaaba04-80ff-43a6-a746-a74a91c7c3e2"), 0 },
                    { new Guid("d5c65162-7591-48c1-9198-daca255bce3c"), "elbjgb_02.jpg", new Guid("2eaaba04-80ff-43a6-a746-a74a91c7c3e3"), 0 },
                    { new Guid("d5c65162-7591-48c1-9198-daca255bce4c"), "elbjgb-h2_01.jpg", new Guid("2eaaba04-80ff-43a6-a746-a74a91c7c3e3"), 0 },
                    { new Guid("d5c65162-7591-48c1-9198-daca255bce5c"), "elbjgb-h1_01.jpg", new Guid("2eaaba04-80ff-43a6-a746-a74a91c7c3e3"), 0 },
                    { new Guid("d5c65162-7591-48c1-9198-daca255bce6c"), "actxs-e_02_1_1.jpg", new Guid("2eaaba04-80ff-43a6-a746-a74a91c7c3e3"), 0 },
                    { new Guid("d5c65162-7591-48c1-9198-daca255bce7c"), "actxs-q_02.jpg", new Guid("2eaaba04-80ff-43a6-a746-a74a91c7c3e3"), 0 },
                    { new Guid("d5c65162-7591-48c1-9198-daca255bce8c"), "elbjgb_02.jpg", new Guid("2eaaba04-80ff-43a6-a746-a74a91c7c3e4"), 0 },
                    { new Guid("d5c65162-7591-48c1-9198-daca255bce9c"), "elbjgb-h2_01.jpg", new Guid("2eaaba04-80ff-43a6-a746-a74a91c7c3e4"), 0 },
                    { new Guid("d5c65162-7591-48c1-9198-daca256bce0c"), "elbjgb-h1_01.jpg", new Guid("2eaaba04-80ff-43a6-a746-a74a91c7c3e4"), 0 },
                    { new Guid("d5c65162-7591-48c1-9198-daca256bce1c"), "actxs-e_02_1_1.jpg", new Guid("2eaaba04-80ff-43a6-a746-a74a91c7c3e4"), 0 }
                });

            migrationBuilder.InsertData(
                table: "ProductImages",
                columns: new[] { "Id", "Name", "ProductDetailId", "Status" },
                values: new object[,]
                {
                    { new Guid("d5c65162-7591-48c1-9198-daca256bce2c"), "actxs-q_02.jpg", new Guid("2eaaba04-80ff-43a6-a746-a74a91c7c3e4"), 0 },
                    { new Guid("d5c65162-7591-48c1-9198-daca256bce3c"), "elbjgb_02.jpg", new Guid("2eaaba04-80ff-43a6-a746-a74a91c7c3e5"), 0 },
                    { new Guid("d5c65162-7591-48c1-9198-daca256bce4c"), "elbjgb-h2_01.jpg", new Guid("2eaaba04-80ff-43a6-a746-a74a91c7c3e5"), 0 },
                    { new Guid("d5c65162-7591-48c1-9198-daca256bce5c"), "elbjgb-h1_01.jpg", new Guid("2eaaba04-80ff-43a6-a746-a74a91c7c3e5"), 0 },
                    { new Guid("d5c65162-7591-48c1-9198-daca256bce6c"), "actxs-e_02_1_1.jpg", new Guid("2eaaba04-80ff-43a6-a746-a74a91c7c3e5"), 0 },
                    { new Guid("d5c65162-7591-48c1-9198-daca256bce7c"), "actxs-q_02.jpg", new Guid("2eaaba04-80ff-43a6-a746-a74a91c7c3e5"), 0 },
                    { new Guid("d5c65162-7591-48c1-9198-daca256bce8c"), "elbjgb_02.jpg", new Guid("2eaaba04-80ff-43a6-a746-a74a91c7c3e6"), 0 },
                    { new Guid("d5c65162-7591-48c1-9198-daca256bce9c"), "elbjgb-h2_01.jpg", new Guid("2eaaba04-80ff-43a6-a746-a74a91c7c3e6"), 0 },
                    { new Guid("d5c65162-7591-48c1-9198-daca257bce0c"), "elbjgb-h1_01.jpg", new Guid("2eaaba04-80ff-43a6-a746-a74a91c7c3e6"), 0 },
                    { new Guid("d5c65162-7591-48c1-9198-daca257bce1c"), "actxs-e_02_1_1.jpg", new Guid("2eaaba04-80ff-43a6-a746-a74a91c7c3e6"), 0 },
                    { new Guid("d5c65162-7591-48c1-9198-daca257bce2c"), "actxs-q_02.jpg", new Guid("2eaaba04-80ff-43a6-a746-a74a91c7c3e6"), 0 },
                    { new Guid("d5c65162-7591-48c1-9198-daca257bce3c"), "elbjgb_02.jpg", new Guid("2eaaba04-80ff-43a6-a746-a74a91c7c3e7"), 0 },
                    { new Guid("d5c65162-7591-48c1-9198-daca257bce4c"), "elbjgb-h2_01.jpg", new Guid("2eaaba04-80ff-43a6-a746-a74a91c7c3e7"), 0 },
                    { new Guid("d5c65162-7591-48c1-9198-daca257bce5c"), "elbjgb-h1_01.jpg", new Guid("2eaaba04-80ff-43a6-a746-a74a91c7c3e7"), 0 },
                    { new Guid("d5c65162-7591-48c1-9198-daca257bce6c"), "actxs-e_02_1_1.jpg", new Guid("2eaaba04-80ff-43a6-a746-a74a91c7c3e7"), 0 },
                    { new Guid("d5c65162-7591-48c1-9198-daca257bce7c"), "actxs-q_02.jpg", new Guid("2eaaba04-80ff-43a6-a746-a74a91c7c3e7"), 0 },
                    { new Guid("d5c65162-7591-48c1-9198-daca257bce8c"), "elbjgb_02.jpg", new Guid("2eaaba04-80ff-43a6-a746-a74a91c7c3e8"), 0 },
                    { new Guid("d5c65162-7591-48c1-9198-daca257bce9c"), "elbjgb-h2_01.jpg", new Guid("2eaaba04-80ff-43a6-a746-a74a91c7c3e8"), 0 },
                    { new Guid("d5c65162-7591-48c1-9198-daca258bce0c"), "elbjgb-h1_01.jpg", new Guid("2eaaba04-80ff-43a6-a746-a74a91c7c3e8"), 0 },
                    { new Guid("d5c65162-7591-48c1-9198-daca258bce1c"), "actxs-e_02_1_1.jpg", new Guid("2eaaba04-80ff-43a6-a746-a74a91c7c3e8"), 0 },
                    { new Guid("d5c65162-7591-48c1-9198-daca258bce2c"), "actxs-q_02.jpg", new Guid("2eaaba04-80ff-43a6-a746-a74a91c7c3e8"), 0 },
                    { new Guid("d5c65162-7591-48c1-9198-daca258bce3c"), "elbjgb_02.jpg", new Guid("2eaaba04-80ff-43a6-a746-a74a91c7c3e9"), 0 },
                    { new Guid("d5c65162-7591-48c1-9198-daca258bce4c"), "elbjgb-h2_01.jpg", new Guid("2eaaba04-80ff-43a6-a746-a74a91c7c3e9"), 0 },
                    { new Guid("d5c65162-7591-48c1-9198-daca258bce5c"), "elbjgb-h1_01.jpg", new Guid("2eaaba04-80ff-43a6-a746-a74a91c7c3e9"), 0 },
                    { new Guid("d5c65162-7591-48c1-9198-daca258bce6c"), "actxs-e_02_1_1.jpg", new Guid("2eaaba04-80ff-43a6-a746-a74a91c7c3e9"), 0 },
                    { new Guid("d5c65162-7591-48c1-9198-daca258bce7c"), "actxs-q_02.jpg", new Guid("2eaaba04-80ff-43a6-a746-a74a91c7c3e9"), 0 },
                    { new Guid("d5c65162-7591-48c1-9198-daca998bce0c"), "elbjgb-h1_01.jpg", new Guid("2eaaba04-80ff-43a6-a746-a74a91c7c0e6"), 0 },
                    { new Guid("d5c65162-7591-48c1-9198-daca998bce1c"), "actxs-e_02_1_1.jpg", new Guid("2eaaba04-80ff-43a6-a746-a74a91c7c0e6"), 0 },
                    { new Guid("d5c65162-7591-48c1-9198-daca998bce2c"), "actxs-q_02.jpg", new Guid("2eaaba04-80ff-43a6-a746-a74a91c7c0e6"), 0 },
                    { new Guid("d5c65162-7591-48c1-9198-daca998bce3c"), "elbjgb_02.jpg", new Guid("2eaaba04-80ff-43a6-a746-a74a91c7c0e7"), 0 },
                    { new Guid("d5c65162-7591-48c1-9198-daca998bce4c"), "elbjgb-h2_01.jpg", new Guid("2eaaba04-80ff-43a6-a746-a74a91c7c0e7"), 0 },
                    { new Guid("d5c65162-7591-48c1-9198-daca998bce5c"), "elbjgb-h1_01.jpg", new Guid("2eaaba04-80ff-43a6-a746-a74a91c7c0e7"), 0 },
                    { new Guid("d5c65162-7591-48c1-9198-daca998bce6c"), "actxs-e_02_1_1.jpg", new Guid("2eaaba04-80ff-43a6-a746-a74a91c7c0e7"), 0 },
                    { new Guid("d5c65162-7591-48c1-9198-daca998bce7c"), "actxs-q_02.jpg", new Guid("2eaaba04-80ff-43a6-a746-a74a91c7c0e7"), 0 },
                    { new Guid("d5c65162-7591-48c1-9198-daca998bce8c"), "elbjgb_02.jpg", new Guid("2eaaba04-80ff-43a6-a746-a74a91c7c0e8"), 0 },
                    { new Guid("d5c65162-7591-48c1-9198-daca998bce9c"), "elbjgb-h2_01.jpg", new Guid("2eaaba04-80ff-43a6-a746-a74a91c7c0e8"), 0 },
                    { new Guid("d5c65162-7591-48c1-9198-daca999bce2c"), "actxs-q_02.jpg", new Guid("2eaaba04-80ff-43a6-a746-a74a91c6c0e8"), 0 },
                    { new Guid("d5c65162-7591-48c1-9198-daca999bce8c"), "actxs-e_02_1_1.jpg", new Guid("2eaaba04-80ff-43a6-a746-a74a91c5c0e7"), 0 },
                    { new Guid("e666f8b0-0d76-400e-bdb0-ca85a9ba65d4"), "1.png", new Guid("84a7b7bd-0490-4cf1-9499-1d9fe88580c4"), 0 }
                });

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
                name: "IX_Posts_EmployeeId",
                table: "Posts",
                column: "EmployeeId");

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
                name: "IX_Products_BrandID",
                table: "Products",
                column: "BrandID");

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
                name: "Posts");

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
                name: "Brands");

            migrationBuilder.DropTable(
                name: "Categories");

            migrationBuilder.DropTable(
                name: "Ranks");
        }
    }
}
