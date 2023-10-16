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
    public class LoginCustomerService : ILoginCustomerService
    {
        private readonly UserManager<Customer> _customerManager;
        private readonly IConfiguration _configuration;

        public LoginCustomerService(UserManager<Customer> customerManager, IConfiguration configuration)
        {
            _customerManager = customerManager;
            _configuration = configuration;
        }

        public async Task<Response> LoginAsync(Login loginCustomer)
        {
            // Check customer is exists
            var customer = await _customerManager.FindByNameAsync(loginCustomer.Username);
            if (customer != null && await _customerManager.CheckPasswordAsync(customer, loginCustomer.Password))
            {
                //Create JWT
                //Create list of claims
                var claims = new List<Claim>()
                {
                    new Claim("Id", customer.Id.ToString()),
                    new Claim(ClaimTypes.NameIdentifier, customer.UserName.ToString()),
                    new Claim(ClaimTypes.Email, customer.Email.ToString())
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
