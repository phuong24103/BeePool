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
                    { new Guid("a51f7c3c-a8e7-4c0a-aeea-b6fc70492b15"), "Chờ xác nhận" },
                    { new Guid("a51f7c3c-a8e7-4c0a-aeea-b6fc70492bf5"), "Đã xác nhận" },
                    { new Guid("b392b872-712a-41a7-8542-83fb58249c23"), "Đang lấy hàng" }
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
                    { new Guid("357267e8-d162-4844-a660-661f46933d07"), new DateTime(2023, 11, 25, 13, 53, 11, 237, DateTimeKind.Local).AddTicks(5215), "Cơ ba băng", 0, new DateTime(2023, 11, 25, 13, 53, 11, 237, DateTimeKind.Local).AddTicks(5224) }
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
                    { new Guid("b108d866-eb13-46e3-b3d2-ecae4fbfe872"), "b667527e-750b-4d0f-940e-e48cdf58d4d9", "Quản lý", "QUẢN LÝ" },
                    { new Guid("b108d866-eb13-46e3-b3d2-ecae4fbfe873"), "2e8a5d5b-530e-4bc8-8e9e-6b1fc19b156b", "Nhân viên", "NHÂN VIÊN" }
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
                    { new Guid("cc37720a-7e89-463a-9510-1936e6761d04"), "Đen", 1, "Gỗ", "Kamui Clear Black - Super Soft", 28.300000000000001, 1, 0 },
                    { new Guid("cc37720a-7e89-463a-9510-1936e6761d14"), "Xanh", 2, "Gỗ", "Kamui Clear Black - Soft", 28.300000000000001, 2, 0 },
                    { new Guid("cc37720a-7e89-463a-9510-1936e6761d24"), "Xanh", 2, "Gỗ", "Kamui Clear Black - Medium", 28.300000000000001, 2, 0 },
                    { new Guid("cc37720a-7e89-463a-9510-1936e6761d34"), "Xanh", 2, "Gỗ", "Kamui Clear Black - Hard", 28.300000000000001, 2, 0 },
                    { new Guid("cc37720a-7e89-463a-9510-1936e6761d44"), "Xanh", 2, "Gỗ", "Kamui Black - Hard", 26.800000000000001, 2, 0 },
                    { new Guid("cc37720a-7e89-463a-9510-1936e6761d54"), "Xanh", 2, "Gỗ", "Kamui Black - Medium", 26.800000000000001, 2, 0 },
                    { new Guid("cc37720a-7e89-463a-9510-1936e6761d64"), "Xanh", 2, "Gỗ", "Kamui Black - Soft", 26.800000000000001, 2, 0 },
                    { new Guid("cc37720a-7e89-463a-9510-1936e6761d74"), "Xanh", 2, "Gỗ", "Kamui Black  - Super Soft", 26.800000000000001, 2, 0 },
                    { new Guid("cc37720a-7e89-463a-9510-1936e6761d84"), "Xanh", 2, "Gỗ", "Kamui Original Clear Super Soft", 24.800000000000001, 2, 0 },
                    { new Guid("cc37720a-7e89-463a-9510-1936e6761d94"), "Xanh", 2, "Gỗ", "Kamui Original Clear Soft", 24.800000000000001, 2, 0 }
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
                    { new Guid("1e510dc9-e8fd-40fc-ac14-19e701736531"), "Giải carom 3 băng Veghel World Cup 2023 kết thúc khuya ngày 28/10 mới đây chứng kiến màn lên ngôi rất thuyết phục của Dick Jaspers. Với phong độ ấn tượng, siêu sao người Hà Lan chỉ mất đúng 12 lượt cơ để đánh bại cơ thủ số 1 nước Đức Martin Horn với cách biệt 50-22 để giành chức vô địch.\r\n\r\nNgay sau khi giải đấu kết thúc, Liên đoàn carom 3 băng thế giới (UMB) đã cập nhật điểm số và công bố bảng xếp hạng thế giới mới với rất nhiều bất ngờ thú vị. Trong đó, điểm nhấn lớn nhất là việc “thần đồng” 25 tuổi người Hàn Quốc Cho Myung Woo bất ngờ leo lên ngôi số 1 thế giới.\r\n\r\nMặc dù dừng bước ở vòng 16 và giữ nguyên số điểm là 258 điểm, Cho Myung Woo lại chiếm lấy vị trí đỉnh BXH của Marco Zanetti khi siêu sao người Ý sớm bị loại từ vòng bảng, qua đó chỉ còn 257 điểm, thua đúng 1 điểm trước Cho Myung Woo khiến ông rơi xuống vị trí thứ 2.\r\n\r\nMột trong những nguyên nhân khiến Marco Zanetti bị loại sớm và mất ngôi số 1 đến từ trận thua sốc trước Chiêm Hồng Thái. Cụ thể ở lượt trận mở màn vòng bảng, tài năng 24 tuổi của Việt Nam đã thể hiện phong độ xuất thần để đánh bại siêu sao người Ý với tỉ số 40-25 sau 20 lượt cơ.\r\n\r\nTiếp đà hưng phấn, Hồng Thái đã một mạch tiến vào đến tứ kết và trở thành cơ thủ Việt Nam lọt vào sâu nhất tại giải đấu này. Với màn thể hiện ấn tượng, Hồng Thái đã thăng tiến 9 bậc từ hạng 30 lên hạng 21 thế giới với 123 điểm.\r\n\r\n2 cơ thủ khác của Việt Nam là Trần Thanh Lực (từ hạng 35 lên hạng 29 thế giới) và Nguyễn Trần Thanh Tự (từ hạng 62 lên 56 thế giới) cũng có sự thăng tiến nhẹ khi vượt qua vòng loại để góp mặt ở vòng chính. Ngoài ra, Trần Quyết Chiến (hạng 5 thế giới) và Bao Phương Vinh (hạng 11 thế giới) giữ nguyên thứ hạng của mình.\r\n\r\nMặt khác, trong top 10 thế giới có thêm chút thay đổi khi Eddy Merckx tăng 2 bậc lên hạng 6 thế giới, đẩy Sameh Sidhom xuống hạng 7. Với khoảng cách về điểm số là rất ít, BXH được dự báo sẽ biến động rất mạnh ở chặng World Cup tiếp theo sẽ diễn ra tại Hàn Quốc vào đầu tháng 11 tới đây.", new DateTime(2023, 11, 25, 13, 53, 11, 237, DateTimeKind.Local).AddTicks(6851), "(Tin thể thao, tin bi-a) Những kết quả bất ngờ tại giải carom 3 băng Veghel World Cup 2023 đã khiến bảng xếp hạng carom 3 băng thế giới có nhiều sự thay đổi thú vị.", new Guid("40b601c0-2c08-449f-a41e-7564648f2c87"), "slidenews1.jpg", 0, "Nóng bảng xếp hạng bi-a thế giới: Hồng Thái “bay cao”, “thần đồng” Hàn Quốc lên số 1", new DateTime(2023, 11, 25, 13, 53, 11, 237, DateTimeKind.Local).AddTicks(6853) },
                    { new Guid("1e510dc9-e8fd-40fc-ac14-19e701736532"), "Hanoi Pool Open Championship 2023 đã kết thúc tại Hà Nội vào 15/10 nhưng dư âm về sự kiện này vẫn đang kéo dài. Giải đấu pool quốc tế lần đầu tiên tổ chức tại Thủ đô giúp khán giả Việt Nam tới gần hơn với những cơ thủ hàng đầu thế giới, hay huyền thoại lừng danh thế giới, các tay cơ chủ nhà cũng có dịp thi đấu, cọ xát với đối thủ lớn.\r\n\r\nĐáng tiếc, không có tay cơ nào của Việt Nam đi tiếp sau vòng knock-out, dù vậy những Anh Tuấn, Đức Thiện, Thành Kiên..., đặc biệt là Đỗ Khải tạo dấu ấn đậm nét với khán giả và bạn bè quốc tế.\r\n\r\nVới phong cách thi đấu phóng khoáng và có phần \"hoang dã\", Đỗ Khải là cái tên gây sốt nhất tại Hanoi Open. Tay cơ \"Khải tóc dài\" có thêm biệt danh \"Quý ông người Pháp\" sau khi trao nụ hôn lên tay của CEO Matchroom Multi Sports, bà Emily Frazer.\r\n\r\nNhờ lối thi đấu mang đậm tính giải trí, Đỗ Khải đã được thi đấu trận giao lưu với huyền thoại Efren Reyes, cơ thủ 69 tuổi, được mệnh danh \"Phù thủy\" bi-a tới từ Philippines.\r\n\r\nNhưng chưa hết, \"Khải tóc dài\" còn được cơ thủ số 1 bi-a pool (do Matchroom xếp hạng) Francisco Sanchez Ruiz \"mời gia nhập\" đội tuyển châu Âu.\r\n\r\nMosconi Cup 2023 diễn ra từ 6 tới 9/12 tại Anh, Team Europe (đội bi-a châu Âu) đã xác định được 3/5 cái tên bao gồm Sanchez Ruiz, David Alcaide và Jayson Shaw. 2/5 suất còn lại là suất wildcard (suất đặc cách) và sẽ được lựa chọn tùy ý theo quyết định riêng của từng đội tuyển.\r\n\r\nTrong phần bình luận mới đây, cơ thủ người Tây Ban Nha Sanchez Ruiz đã nhắc tới tên của Đỗ Khải, anh này mong muốn cơ thủ Việt Nam sẽ là thành viên nhận 1 trong suất còn lại của tuyển châu Âu.\r\n\r\nRõ ràng đây chỉ là bình luận vui vẻ của cơ thủ Ruiz, dù có biệt danh là \"Quý ông người Pháp\" nhưng Đỗ Khải mang quốc tịch Việt Nam vì thế anh không thể chơi cho đội tuyển châu Âu ở giải đồng đội sắp tới.\r\n\r\nTất nhiên chuyện gì cũng có thể xảy ra. Nếu Mosconi Cup 2023 có màn thi đấu giao lưu dành cho khách mời như ở Hanoi Open vừa qua, thì rất có khả năng Đỗ Khải sẽ trở thành khách mời đặc biệt.", new DateTime(2023, 11, 25, 13, 53, 11, 237, DateTimeKind.Local).AddTicks(6857), "(Tin thể thao, tin bi-a) Francisco Sanchez Ruiz nhắn nhủ lời đặc biệt tới cơ thủ Đỗ Khải của Việt Nam.", new Guid("40b601c0-2c08-449f-a41e-7564648f2c87"), "post2.jpg", 0, "Cơ thủ bi-a số 1 thế giới tiến cử \"Khải tóc dài\" thi đấu cho tuyển châu Âu", new DateTime(2023, 11, 25, 13, 53, 11, 237, DateTimeKind.Local).AddTicks(6857) },
                    { new Guid("1e510dc9-e8fd-40fc-ac14-19e701736533"), "Sau giải bi-a quốc tế diễn ra ở Hà Nội, lúc này làng bi-a pool đang hướng sự tập trung vào giải vô địch 10 bi nữ thế giới 2023 diễn ra tại Áo từ 18 tới 22/10.\r\n\r\nTrải những trận đấu vòng loại, ban tổ chức đã xác định được 16 cái tên giành vé vào 1/8 thi đấu vào tối 20/10. Gương mặt nhận được nhiều sự quan tâm nhất có lẽ là Pan Xiaoting (Phan Hiểu Đình), VĐV \"tài sắc vẹn toàn\" đến từ Trung Quốc.\r\n\r\nỞ vòng loại, mỹ nhân 41 tuổi trải qua nhiều trận đấu căng thẳng, trong đó phải kể tới màn \"ngược dòng\" thắng Chihiro Kawahara 7-6, trước đó cơ thủ Nhật Bản dẫn trước Hiểu Đình tới 5-0.\r\n\r\nTại vòng đấu dành cho 16 cơ thủ, mỹ nhân Trung Quốc chạm trán Allison Fisher. Đây là trận đấu của hai phong cách đối lập, nếu như Fisher mang phong cách tomboy thì Hiểu Đình là mỹ nhân yểu điệu, duyên dáng của làng billiard thế giới.\r\n\r\nFisher tỏ ra vượt trội hơn, cô đã dẫn tỷ số ván 4-1 sau 5 ván đầu tiên, trong khi Pan Xiaoting dù rất nỗ lực cũng chỉ đủ rút ngắn cách biệt xuống còn 2 điểm. Fisher thắng chung cuộc với tỷ số 9-6.", new DateTime(2023, 11, 25, 13, 53, 11, 237, DateTimeKind.Local).AddTicks(6861), "(Tin thể thao, tin bi-a) Nữ thần bi-a Trung Quốc vừa có màn \"ngược dòng\" ấn tượng trước đối thủ Nhật Bản.", new Guid("40b601c0-2c08-449f-a41e-7564648f2c87"), "post3.jpg", 0, "\"Nữ thần\" bi-a Trung Quốc đua tài, khoe sắc ở giải vô địch thế giới 2023", new DateTime(2023, 11, 25, 13, 53, 11, 237, DateTimeKind.Local).AddTicks(6861) },
                    { new Guid("1e510dc9-e8fd-40fc-ac14-19e701736534"), "Hanoi Open Pool Championship 2023 tổ chức tại Hà Nội từ 10 tới 15/10 tại Hà Nội mang tới cho khán giả Việt Nam quá nhiều kỷ niệm đáng nhớ. Ở sự kiện bi-a quốc tế tầm cỡ lần đầu tiên diễn ra tại Việt Nam, quy tụ những cơ thủ hàng đầu thế giới, cơ cấu giải thưởng lớn và có cả sự xuất hiện của \"Phù thủy\" Efren Reyes (Philippines).\r\n\r\nNhững siêu sao hàng đầu bi-a pool thế giới như Shane Van Boening, Francisco Sanchez Ruiz, Fedor Gorst, Jayson Shaw... đã trình diễn những đường cơ làm hài lòng những khán giả khó tính nhất. Bên cạnh đó, huyền thoại bi-a được cả thế giới ngưỡng mộ Reyes có hai trận đấu giao lưu mãn nhãn với Anh Tuấn và Đỗ Khải. \r\n\r\nSau trận đấu giao lưu với cơ thủ Anh Tuấn vào tối 14/10, sức hút từ cơ thủ 69 tuổi Philippines đã khiến ban tổ chức tạo thêm màn so cơ không có trong kế hoạch với Đỗ Khải, hay còn gọi là \"Khải tóc dài\", vào chiều 15/10.\r\n\r\nSự kết hợp giữa \"Phù thủy\" Reyes và ngôi sao có khả năng \"phù phép bi chủ\" Đỗ Khải đã tạo ra màn so tài mang nặng tính giải trí. Không chỉ khán giả, trong trận đấu nhiều lần huyền thoại Reyes cũng phải cười phá lên vì những động tác uốn éo như nhảy cùng trái bóng của Đỗ Khải. Reyes thắng 7-4 trước Đỗ Khải và ông sẽ mang theo rất nhiều kỷ niệm về Đỗ Khải, người hâm mộ và không khí cổ vũ tuyệt vời tại Hà Nội. \r\n\r\nKhép lại màn so cơ của Reyes và Đỗ Khải, trận chung kết được chờ đợi nhất giữa Jayson Shaw (Anh) và Albin Ouschan (Áo) mang tới cuộc rượt đuổi tỷ số nghẹt thở. \r\n\r\nLà một trong những cơ thủ chơi ổn định nhất, Shaw cơ thủ có biệt danh \"Mắt đại bàng\" bất ngờ để Albin dẫn 0-4. Chơi tập trung gỡ 3-4, nhưng rồi Shaw tiếp tục bị dẫn trước 6-10.\r\n\r\nBản lĩnh của Shaw được phát huy, \"Mắt đại bàng\" thi đấu cực tốt để vươn lên dẫn trước 12-11. Chỉ cần 1 ván nữa là thắng nhưng cơ thủ người Anh chơi ẩu, đánh lắc lỗ 1 bi ở ván 24, tạo điều kiện cho đối thủ Áo gỡ hòa 12-12.\r\n\r\nVận may cuối cùng ngoảnh mặt với Albin, ở tình huống phá bàn, bi chủ đã rơi xuống lỗ. Được đặt bóng ở vị trí thuận lợi, \"Mắt đại bàng\" tận dụng tốt cơ hội để khép lại trận đấu với tỷ số 13-12, qua đó bước lên ngôi vô địch Hanoi Open Pool Championship 2023. \r\n\r\nShaw nhận cúp và phần thưởng 30.000 USD (733 triệu đồng) cho chức vô địch, á quân Albin nhận 15.000  USD (366 triệu đồng), 2 cơ thủ đồng hạng ba cùng nhận 9.500 USD (232 triệu đồng).", new DateTime(2023, 11, 25, 13, 53, 11, 237, DateTimeKind.Local).AddTicks(6864), "(Tin thể thao, tin bi-a) Ngày cuối cùng Hanoi Open Pool Championship để lại nhiều ấn tượng khó quên với khán giả hâm mộ billiards (bi-a) trong nước và thế giới.", new Guid("40b601c0-2c08-449f-a41e-7564648f2c87"), "post4.jpg", 0, "Reyes đánh bại \"Khải tóc dài\", Jayson Shaw vô địch nghẹt thở giải bi-a ở Hà Nội", new DateTime(2023, 11, 25, 13, 53, 11, 237, DateTimeKind.Local).AddTicks(6865) },
                    { new Guid("1e510dc9-e8fd-40fc-ac14-19e701736535"), "Hanoi Open Pool Championship 2023, giải bi-a quốc tế tầm cỡ đầu tiên được tổ chức tại Hà Nội từ 10 tới 15/10 dần bước vào những trận đấu cuối cùng. Không chỉ có những cơ thủ hàng đầu tới tranh tài, sự kiện còn \"nóng\" hơn khi huyền thoại 69 tuổi, Efren Reyes xuất hiện vào chiều 14/10.\r\n\r\nTới tham dự giải với tư cách khách mời danh dự, \"Phù thủy\" Philippines tham gia trận đấu biểu diễn với tay cơ số 2 pool Việt Nam Nguyễn Anh Tuấn. Những trận đấu tại vòng knock-out Hanoi Open, cộng với hiệu ứng từ Reyes giúp Cung thể thao Điền kinh trong nhà Mỹ Đình trở nên nhộn nhịp. \r\n\r\nNgay khi xuất hiện, huyền thoại Reyes đã được người hâm mộ vây quanh, ông rất cảm kích trước tình cảm của khán giả dành cho mình. \r\n\r\nNhư để tri ân người xem, ngay ở cơ đánh dạo bàn khởi động đầu tiên, người đàn ông Philippines đã thực hiện pha \"dọn bàn\" đẹp mắt. Toàn bộ 9 bi được \"Phù thủy\" đưa xuống lỗ, đặc biệt nhất là bóng số 9. Dù đó là cơ đánh thẳng tắp để ăn bi số 9, nhưng Reyes đã đưa trái bóng này đi 4 băng trước khi rơi vào lỗ góc. Tình huống khiến nhiều người có mặt rất phấn khích. \r\n\r\nKhi bước vào trận đấu biểu diễn, giao lưu với Nguyễn Anh Tuấn (hạng 107 thế giới theo bảng xếp hạng Matchroom), huyền thoại Philippines vẫn thể hiện được nhiều cơ đánh tốt nhưng \"Tkon\" xuất sắc hơn. \r\n\r\nVới thể thức đánh \"chạm 10\", Reyes và Anh Tuấn tạo ra tỷ số rượt đuổi hấp dẫn, cuối cùng thì tài năng và sức trẻ giúp cơ thủ Việt Nam vượt qua huyền thoại Philippines 10-7. \r\n\r\nDĩ nhiên kết quả này không quá quan trọng, sau trận đấu cơ thủ Anh Tuấn tiến tới xin chữ ký của huyền thoại Reyes và anh thổ lộ \"thầy cũng mệt rồi nên thi đấu không được như ý\". \r\n\r\nCơ thủ Reyes, 69 tuổi, từng vô địch thế giới pool 9 bi năm 1999 và pool 8 bi năm 2004. Reyes không chỉ nổi tiếng bởi những danh hiệu, ông được cả thế giới biết tới thông qua những trận \"đánh độ\" tại quê nhà và phô diễn các đường cơ huyền ảo. \r\n\r\nKhán giả không sai khi đặt cho Reyes biệt danh \"Phù thủy\", người đàn ông sở hữu cả \"kho tàng\" những cú đánh chẳng thể tìm thấy trong sách giáo khoa nào cả.", new DateTime(2023, 11, 25, 13, 53, 11, 237, DateTimeKind.Local).AddTicks(6867), "(Tin thể thao, tin bi-a) Thêm một lần góp mặt tại các sự kiện bi-a tổ chức ở Việt Nam, \"Phù thủy\" Reyes tri ân khán giả bằng pha đi cơ đáng nhớ.", new Guid("40b601c0-2c08-449f-a41e-7564648f2c87"), "post5.jpg", 0, "\"Phù thủy bi-a\" Reyes tri ân khán giả Việt bằng cơ 4 băng kinh điển", new DateTime(2023, 11, 25, 13, 53, 11, 237, DateTimeKind.Local).AddTicks(6868) },
                    { new Guid("1e510dc9-e8fd-40fc-ac14-19e701736536"), "Shane Van Boening, cơ thủ sinh năm 1983 người Mỹ là một trong số những VĐV đặc biệt nhất của làng bi-a thế giới. Anh bị khiếm thính từ nhỏ, bi-a đã giúp cơ thủ phát huy tài năng để tự tin bước ra ngoài trở thành ngôi sao hàng đầu bi-a.\r\n\r\nĐược xem như một trong số cơ thủ bi-a Mỹ giỏi nhất và từng vươn tới số 1 thế giới năm 2020, Boening nổi tiếng với nhiều cơ đánh nhanh, mạnh, chính xác. Ở một giải bi-a pool 9 bi vào năm 2022, cơ thủ Boeing \"dọn bàn\" chỉ sau 72 giây.\r\n\r\nVào tháng trước Boening cũng góp mặt tại sự kiện bi-a tại Hà Nội, dù không giành được chức vô địch nhưng cơ thủ người Mỹ để lại nhiều ấn tượng đẹp với người hâm mộ.\r\n\r\nTrong 2 tuần liên tiếp vừa qua, cơ thủ 40 tuổi đăng quang tại giải Vô địch 8 bi thế giới 2023, rồi lên ngôi Bigfoot 10 bi International Open 2023 tại Mỹ.\r\n\r\nVới phong độ rất tốt sau khi giành chức vô địch 10 bi Bigfoot, Boening chỉ mất đúng 1 tiếng 25 phút để đánh bại cơ thủ người Philippines, Joven Bustamante với tỷ số 10-0 tại sự kiện 9 bi International Open 2023 diễn ra ở Mỹ.\r\n\r\nĐể thắng trắng 1 trận đấu bi-a là điều không phải dễ dàng, và Boening đã làm được điều đáng kinh ngạc này. Tỷ số cũng cho thấy khả năng phá bóng rồi \"dọn bàn\" gần như hoàn hảo của cơ thủ 40 tuổi. Suốt trận đấu Bustamante chẳng khác nào khán giả xem Boening đi cơ.", new DateTime(2023, 11, 24, 13, 53, 11, 237, DateTimeKind.Local).AddTicks(6871), "(Tin thể thao, tin bi-a) Thi đấu với tâm lý vững vàng và gần như \"không cảm xúc\", cơ thủ người Mỹ hạ tay cơ Philippines 10-0.", new Guid("40b601c0-2c08-449f-a41e-7564648f2c87"), "post6.jpg", 0, "Cơ thủ chơi bi-a kiểu robot, hạ đối thủ 10-0 mặt vẫn lạnh tanh", new DateTime(2023, 11, 24, 13, 53, 11, 237, DateTimeKind.Local).AddTicks(6876) }
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "AvailableQuantity", "CategoryID", "CreateDate", "Description", "Likes", "Name", "Pin", "Producer", "Rings", "Sold", "Status", "Wrap" },
                values: new object[,]
                {
                    { new Guid("cc37720a-7e89-463a-9510-1936e6761d8a"), 1000, new Guid("357267e8-d162-4844-a660-661f46933d03"), new DateTime(2023, 9, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), "Giới thiệu Cue Predator Sneaky Pete, nơi sự khéo léo kết hợp sự sang trọng. Lớp hoàn thiện mờ Purpleheart thể hiện phong cách đặc biệt của nó, với tám điểm màu xanh lam, vàng và đen quyến rũ. Màu xanh bóng mượt với lớp bọc vải lanh Ailen màu trắng tạo thêm nét đẳng cấp và tăng cường khả năng cầm nắm của bạn. Nâng cao trò chơi của bạn với độ chính xác và sự khéo léo của tín hiệu Predator Sneaky Pete.", 1000, "Predator Purpleheart 8-Point Sneaky Pete With Wrap", "Uniloc Quick Release", "PRESP8PW_", "None", 500, 0, "Blue and White Irish Linen" },
                    { new Guid("cc37720a-7e89-463a-9510-1936e6761d8b"), 2000, new Guid("357267e8-d162-4844-a660-661f46933d04"), new DateTime(2023, 9, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), "Description", 1000, "Mezz ZZ37 Pool Cue", "Mezz United Joint", "Lucasi", "Silver Rings", 500, 0, "Black Irish Linen" },
                    { new Guid("cc37720a-7e89-463a-9510-1936e6761d8c"), 2000, new Guid("357267e8-d162-4844-a660-661f46933d05"), new DateTime(2023, 9, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), "Description", 1000, "Summit SUML17 Pool Cue", "Mezz United Joint", "Lucasi", "Silver Rings", 500, 0, "Black Irish Linen" },
                    { new Guid("cc37720a-7e89-463a-9510-2936e6761d8a"), 2000, new Guid("357267e8-d162-4844-a660-661f46933d06"), new DateTime(2023, 9, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), "Description", 1000, "Katana KAT19 Pool Cue", "Mezz United Joint", "Lucasi", "Silver Rings", 500, 0, "Black Irish Linen" },
                    { new Guid("cc37720a-7e89-463a-9510-3936e6761d8b"), 2000, new Guid("357267e8-d162-4844-a660-661f46933d07"), new DateTime(2023, 9, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), "Description", 1000, "Summit SUML13 Pool Cue", "Mezz United Joint", "Lucasi", "Silver Rings", 500, 0, "Black Irish Linen" },
                    { new Guid("cc37720a-7e89-463a-9510-4936e6761d8c"), 1000, new Guid("357267e8-d162-4844-a660-661f46933d03"), new DateTime(2023, 9, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), "Giới thiệu Cue Predator Sneaky Pete, nơi sự khéo léo kết hợp sự sang trọng. Lớp hoàn thiện mờ Purpleheart thể hiện phong cách đặc biệt của nó, với tám điểm màu xanh lam, vàng và đen quyến rũ. Màu xanh bóng mượt với lớp bọc vải lanh Ailen màu trắng tạo thêm nét đẳng cấp và tăng cường khả năng cầm nắm của bạn. Nâng cao trò chơi của bạn với độ chính xác và sự khéo léo của tín hiệu Predator Sneaky Pete.", 1000, "Cuetec AVID Proof CT326NW Pool Cue", "Uniloc Quick Release", "PRESP8PW_", "None", 500, 0, "Blue and White Irish Linen" },
                    { new Guid("cc37720a-7e89-463a-9510-5936e6761d8a"), 2000, new Guid("357267e8-d162-4844-a660-661f46933d04"), new DateTime(2023, 9, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), "Description", 1000, "Cuetec AVID Proof CT326LTC Pool Cue", "Mezz United Joint", "Lucasi", "Silver Rings", 500, 0, "Black Irish Linen" },
                    { new Guid("cc37720a-7e89-463a-9510-6936e6761d8b"), 2000, new Guid("357267e8-d162-4844-a660-661f46933d05"), new DateTime(2023, 9, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), "Description", 1000, "Meucci Casino MECAS10 Pool Cue", "Mezz United Joint", "Lucasi", "Silver Rings", 500, 0, "Black Irish Linen" },
                    { new Guid("cc37720a-7e89-463a-9510-7936e6761d8c"), 2000, new Guid("357267e8-d162-4844-a660-661f46933d03"), new DateTime(2023, 9, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), "Description", 1000, "Bull Carbon BCSP2 Silver Split Cue W/", "Mezz United Joint", "Lucasi", "Silver Rings", 500, 0, "Black Irish Linen" },
                    { new Guid("cc37720a-7e89-463a-9510-8936e6761d8a"), 2000, new Guid("357267e8-d162-4844-a660-661f46933d04"), new DateTime(2023, 9, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), "Description", 1000, "Balabushka GBT Era Cue", "Mezz United Joint", "Lucasi", "Silver Rings", 500, 0, "Black Irish Linen" }
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
                    { new Guid("84a7b7bd-0490-4cf1-9499-1d9fe88580c0"), new DateTime(2023, 9, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "Description", 1500.0, 2000.0, new Guid("cc37720a-7e89-463a-9510-8936e6761d8a"), 1, new Guid("cc37720a-7e89-463a-9510-1936e6761d73"), 0, new Guid("cc37720a-7e89-463a-9510-1936e6761d74"), new Guid("cc37720a-7e89-463a-9510-1936e6761d75") },
                    { new Guid("84a7b7bd-0490-4cf1-9499-1d9fe88580c3"), new DateTime(2023, 9, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "Description", 1500.0, 2000.0, new Guid("cc37720a-7e89-463a-9510-1936e6761d8c"), 1, new Guid("cc37720a-7e89-463a-9510-1936e6761d73"), 0, new Guid("cc37720a-7e89-463a-9510-1936e6761d74"), new Guid("cc37720a-7e89-463a-9510-1936e6761d75") },
                    { new Guid("84a7b7bd-0490-4cf1-9499-1d9fe88580c4"), new DateTime(2023, 9, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "Description", 1500.0, 2000.0, new Guid("cc37720a-7e89-463a-9510-2936e6761d8a"), 1, new Guid("cc37720a-7e89-463a-9510-1936e6761d73"), 0, new Guid("cc37720a-7e89-463a-9510-1936e6761d74"), new Guid("cc37720a-7e89-463a-9510-1936e6761d75") },
                    { new Guid("84a7b7bd-0490-4cf1-9499-1d9fe88580c5"), new DateTime(2023, 9, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "Description", 1500.0, 2000.0, new Guid("cc37720a-7e89-463a-9510-3936e6761d8b"), 1, new Guid("cc37720a-7e89-463a-9510-1936e6761d73"), 0, new Guid("cc37720a-7e89-463a-9510-1936e6761d74"), new Guid("cc37720a-7e89-463a-9510-1936e6761d75") }
                });

            migrationBuilder.InsertData(
                table: "ProductDetails",
                columns: new[] { "Id", "CreateDate", "Description", "ImportPrice", "Price", "ProductID", "Quantity", "ShaftId", "Status", "TipId", "WeightId" },
                values: new object[,]
                {
                    { new Guid("84a7b7bd-0490-4cf1-9499-1d9fe88580c6"), new DateTime(2023, 9, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "Description", 1500.0, 2000.0, new Guid("cc37720a-7e89-463a-9510-4936e6761d8c"), 1, new Guid("cc37720a-7e89-463a-9510-1936e6761d73"), 0, new Guid("cc37720a-7e89-463a-9510-1936e6761d74"), new Guid("cc37720a-7e89-463a-9510-1936e6761d75") },
                    { new Guid("84a7b7bd-0490-4cf1-9499-1d9fe88580c7"), new DateTime(2023, 9, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "Description", 1500.0, 2000.0, new Guid("cc37720a-7e89-463a-9510-5936e6761d8a"), 1, new Guid("cc37720a-7e89-463a-9510-1936e6761d73"), 0, new Guid("cc37720a-7e89-463a-9510-1936e6761d74"), new Guid("cc37720a-7e89-463a-9510-1936e6761d75") },
                    { new Guid("84a7b7bd-0490-4cf1-9499-1d9fe88580c8"), new DateTime(2023, 9, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "Description", 1500.0, 2000.0, new Guid("cc37720a-7e89-463a-9510-6936e6761d8b"), 1, new Guid("cc37720a-7e89-463a-9510-1936e6761d73"), 0, new Guid("cc37720a-7e89-463a-9510-1936e6761d74"), new Guid("cc37720a-7e89-463a-9510-1936e6761d75") },
                    { new Guid("84a7b7bd-0490-4cf1-9499-1d9fe88580c9"), new DateTime(2023, 9, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "Description", 1500.0, 2000.0, new Guid("cc37720a-7e89-463a-9510-7936e6761d8c"), 1, new Guid("cc37720a-7e89-463a-9510-1936e6761d73"), 0, new Guid("cc37720a-7e89-463a-9510-1936e6761d74"), new Guid("cc37720a-7e89-463a-9510-1936e6761d75") },
                    { new Guid("979a227c-41b7-4644-8ab1-e1c8d092f79f"), new DateTime(2023, 9, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "Description", 1500.0, 2000.0, new Guid("cc37720a-7e89-463a-9510-1936e6761d8b"), 1, new Guid("cc37720a-7e89-463a-9510-1936e6761d73"), 0, new Guid("cc37720a-7e89-463a-9510-1936e6761d74"), new Guid("cc37720a-7e89-463a-9510-1936e6761d75") }
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
                    { new Guid("8f95d2d6-c3d3-4749-be89-97e220d62e78"), new Guid("a51f7c3c-a8e7-4c0a-aeea-b6fc70492b13"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1450.0, new Guid("979a227c-41b7-4644-8ab1-e1c8d092f79f"), 1 },
                    { new Guid("8f95d2d6-c3d3-4749-be89-97e220d62e79"), new Guid("a51f7c3c-a8e7-4c0a-aeea-b6fc70492bf3"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1500.0, new Guid("1eaaba04-80ff-43a6-a746-a74a91c4c0e3"), 1 }
                });

            migrationBuilder.InsertData(
                table: "CartDetails",
                columns: new[] { "Id", "CustomerId", "Price", "ProductDetailId", "Quantity" },
                values: new object[] { new Guid("357267e8-d162-4844-a660-661f46933d02"), new Guid("a77f8ae9-af3d-4288-bbf3-8f77776f9231"), 2000.0, new Guid("979a227c-41b7-4644-8ab1-e1c8d092f79f"), 1 });

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
                    { new Guid("e666f8b0-0d76-400e-bdb0-ca85a9ba65d1"), "1.png", new Guid("979a227c-41b7-4644-8ab1-e1c8d092f79f"), 0 },
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
                name: "Categories");

            migrationBuilder.DropTable(
                name: "Ranks");
        }
    }
}
