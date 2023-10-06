using Datn_Api.Data;
using Datn_Api.IServices;
using Datn_Api.Services;
using Datn_Shared.Models;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Tokens;
using System.Text;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

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
    options.Password.RequireDigit = false; // Kh�ng b?t ph?i c� s?
    options.Password.RequireLowercase = false; // Kh�ng b?t ph?i c� ch? th??ng
    options.Password.RequireNonAlphanumeric = false; // Kh�ng b?t k� t? ??c bi?t
    options.Password.RequireUppercase = false; // Kh�ng b?t bu?c ch? in
    options.Password.RequiredLength = 6; // S? k� t? t?i thi?u c?a password
    options.Password.RequiredUniqueChars = 1; // S? k� t? ri�ng bi?t

    // C?u h�nh Lockout - kh�a user
    options.Lockout.DefaultLockoutTimeSpan = TimeSpan.FromMinutes(5); // Kh�a 5 ph�t
    options.Lockout.MaxFailedAccessAttempts = 5; // Th?t b?i 5 l? th� kh�a
    options.Lockout.AllowedForNewUsers = true;

    // C?u h�nh v? User.
    options.User.AllowedUserNameCharacters = // c�c k� t? ??t t�n user
        "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789-._@+";
    options.User.RequireUniqueEmail = true;  // Email l� duy nh?t

    // C?u h�nh ??ng nh?p.
    options.SignIn.RequireConfirmedEmail = true;            // C?u h�nh x�c th?c ??a ch? email (email ph?i t?n t?i)
    options.SignIn.RequireConfirmedPhoneNumber = false;     // X�c th?c s? ?i?n tho?i

});

builder.Services.AddDbContext<MyDbContext>(options =>
{
    options.UseSqlServer(builder.Configuration.GetConnectionString("MyCS"));
});

builder.Services.AddScoped<ITipService, TipService>();
builder.Services.AddScoped<ICategoryService, CategoryService>();
builder.Services.AddScoped<IRankService, RankService>();
builder.Services.AddScoped<IBillStatusService, BillStatusService>();
builder.Services.AddScoped<IPaymentService, PaymentService>();
builder.Services.AddScoped<IVoucherService, VoucherService>();
builder.Services.AddScoped<IBillService, BillService>();

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