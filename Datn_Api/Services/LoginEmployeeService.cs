using Datn_Api.Data;
using Datn_Api.IServices;
using Datn_Shared.Models;
using Datn_Shared.ViewModels.AccountViewModels;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;

namespace Datn_Api.Services
{
    public class LoginEmployeeService : ILoginEmployeeService
    {
        private readonly MyDbContext _context;
        private readonly UserManager<Employee> _employeeManager;
        private readonly IConfiguration _configuration;

        public LoginEmployeeService(MyDbContext context, UserManager<Employee> employeeManager, IConfiguration configuration)
        {
            _context = context;
            _employeeManager = employeeManager;
            _configuration = configuration;
        }

        public async Task<Response> LoginAsync(Login loginEmployee)
        {
            // Check employee is exists
            var employee = await _employeeManager.FindByNameAsync(loginEmployee.Username);
            if (employee != null && await _employeeManager.CheckPasswordAsync(employee, loginEmployee.Password))
            {
                // Get list roles of employee
                var roles = await _context.UserRoles.FirstOrDefaultAsync(p => p.UserId == employee.Id);
                var r = await _context.Roles.FirstOrDefaultAsync(p => p.Id == roles.RoleId);
                //var roles = await _employeeManager.GetRolesAsync(employee);

                //Create JWT
                //Create list of claims
                List<Claim> claims = new List<Claim>()
                {
                    new Claim("Id", employee.Id.ToString()),
                    new Claim(ClaimTypes.NameIdentifier, employee.UserName.ToString()),
                    new Claim(ClaimTypes.Email, employee.Email.ToString()),
                    new Claim(ClaimTypes.Role, r.Name)
                };

                //Create JWT Token
                var key = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(_configuration["JWT:SecretKey"]));
                var signIn = new SigningCredentials(key, SecurityAlgorithms.HmacSha256);
                var token = new JwtSecurityToken(_configuration["JWT:Issuer"]
                    , _configuration["JWT:Audience"], claims, expires: DateTime.UtcNow.AddDays(1),
                    signingCredentials: signIn);

                return new Response()
                {
                    IsSuccess = true,
                    StatusCode = 200,
                    Message = "Đăng nhập thành công",
                    Token = new JwtSecurityTokenHandler().WriteToken(token)
                };
            }
            else
            {
                return new Response()
                {
                    IsSuccess = false,
                    StatusCode = 400,
                    Message = "Đăng nhập thất bại"
                };
            }
        }
    }
}
