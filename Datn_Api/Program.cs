using Datn_Api.Data;
using Datn_Api.IServices;
using Datn_Api.Services;
using Datn_Shared.Models;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.IdentityModel.Tokens;
using System.Text;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddDbContext<MyDbContext>(options =>
{
    options.UseSqlServer(builder.Configuration.GetConnectionString("MyCS"));
});

builder.Services.AddIdentityCore<Customer>()
    .AddEntityFrameworkStores<MyDbContext>();

builder.Services.AddIdentity<Employee, IdentityRole<Guid>>()
    .AddEntityFrameworkStores<MyDbContext>()/*.AddDefaultTokenProviders()*/;

builder.Services.AddAuthentication(options =>
{
    options.DefaultAuthenticateScheme = JwtBearerDefaults.AuthenticationScheme;
    options.DefaultChallengeScheme = JwtBearerDefaults.AuthenticationScheme;
    options.DefaultScheme = JwtBearerDefaults.AuthenticationScheme;
}).AddJwtBearer(options =>
{
    options.RequireHttpsMetadata = false;
    options.SaveToken = true;
    options.TokenValidationParameters = new TokenValidationParameters()
    {
        ValidateIssuer = true,
        ValidateAudience = true,
        ValidAudience = builder.Configuration["JWT:Audience"],
        ValidIssuer = builder.Configuration["JWT:Issuer"],
        IssuerSigningKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(builder.Configuration["JWT:SecretKey"]))
    };
});

builder.Services.Configure<IdentityOptions>(options => {
    // Thi?t l?p v? Password
    options.Password.RequireDigit = false; // Không b?t ph?i có s?
    options.Password.RequireLowercase = false; // Không b?t ph?i có ch? th??ng
    options.Password.RequireNonAlphanumeric = false; // Không b?t ký t? ??c bi?t
    options.Password.RequireUppercase = false; // Không b?t bu?c ch? in
    options.Password.RequiredLength = 6; // S? ký t? t?i thi?u c?a password
    options.Password.RequiredUniqueChars = 1; // S? ký t? riêng bi?t

    // C?u hình Lockout - khóa user
    options.Lockout.DefaultLockoutTimeSpan = TimeSpan.FromMinutes(5); // Khóa 5 phút
    options.Lockout.MaxFailedAccessAttempts = 5; // Th?t b?i 5 l? thì khóa
    options.Lockout.AllowedForNewUsers = true;

    // C?u hình v? User.
    options.User.AllowedUserNameCharacters = // các ký t? ??t tên user
        "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789-._@+";
    options.User.RequireUniqueEmail = true;  // Email là duy nh?t

});

builder.Services.AddScoped<ITipService, TipService>();
builder.Services.AddScoped<IShaftService, ShaftService>();
builder.Services.AddScoped<IWeightService, WeightService>();
builder.Services.AddScoped<IProductImageService, ProductImageService>();
builder.Services.AddScoped<IProductDetailService, ProductDetailService>();
builder.Services.AddScoped<IProductService, ProductService>();
builder.Services.AddScoped<ICategoryService, CategoryService>();
builder.Services.AddScoped<IRankService, RankService>();
builder.Services.AddScoped<IBillStatusService, BillStatusService>();
builder.Services.AddScoped<IPaymentService, PaymentService>();
builder.Services.AddScoped<IVoucherService, VoucherService>();
builder.Services.AddScoped<IBillService, BillService>();
builder.Services.AddScoped<IBillDetailService, BillDetailService>();
builder.Services.AddScoped<IUserVoucherService, UserVoucherService>();
builder.Services.AddScoped<ILoginEmployeeService, LoginEmployeeService>();
builder.Services.AddScoped<IRegisterEmployeeService, RegisterEmployeeService>();
builder.Services.AddScoped<ILoginCustomerService, LoginCustomerService>();
builder.Services.AddScoped<IRegisterCustomerService, RegisterCustomerService>();
builder.Services.AddScoped<ICustomerService, CustomerService>();
builder.Services.AddScoped<ICartService, CartService>();
builder.Services.AddScoped<ICartDetailService, CartDetailService>();
builder.Services.AddScoped<IWishListService, WishListService>();

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();


var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();
app.UseAuthentication();

app.UseAuthorization();

app.MapControllers();

app.Run();