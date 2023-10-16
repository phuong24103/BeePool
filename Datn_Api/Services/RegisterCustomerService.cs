using Datn_Api.IServices;
using Datn_Shared.Models;
using Datn_Shared.ViewModels.AccountViewModels;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;

namespace Datn_Api.Services
{
    public class RegisterCustomerService : IRegisterCustomerService
    {
        private readonly UserManager<Customer> _customerManager;
        public RegisterCustomerService(UserManager<Customer> customerManager)
        {
            _customerManager = customerManager;
        }

        public async Task<Response> RegisterAsync(Register registerCustomer)
        {
            // Check customer is exists or not
            if (await _customerManager.FindByEmailAsync(registerCustomer.Email) != null)
            {
                return new Response
                {
                    IsSuccess = false,
                    StatusCode = 400,
                    Message = "Email này đã tồn tại!"
                };
            }
            else if (await _customerManager.FindByNameAsync(registerCustomer.Username) != null)
            {
                return new Response
                {
                    IsSuccess = false,
                    StatusCode = 400,
                    Message = "Tên người dùng này đã tồn tại!"
                };
            }

            // Check password is matching with confirm password or not
            if (registerCustomer.Password != registerCustomer.ConfirmPassword)
            {
                return new Response
                {
                    IsSuccess = false,
                    StatusCode = 400,
                    Message = "Mật khẩu này không khớp với mật khẩu xác nhận!"
                };
            }

            // Create an identity customer
            Customer identityCustomer = new()
            {
                Id = Guid.NewGuid(),
                UserName = registerCustomer.Username,
                Email = registerCustomer.Email,
                PhoneNumber = registerCustomer.PhoneNumber,
                Gender = Convert.ToInt32(registerCustomer.Gender),
                DateOfBirth = Convert.ToDateTime(registerCustomer.DateOfBirth),
                Address = registerCustomer.Address,
                CreateDate = DateTime.Now,
                Point = 0,
                Status = 0,
                RankId = Guid.Parse("a77f8ae9-af3d-4288-bbf3-8f77776f9000"),
            };

            // Add customer to the database
            var result = await _customerManager.CreateAsync(identityCustomer, registerCustomer.Password);

            // Check if register is fail
            if (!result.Succeeded)
            {
                return new Response
                {
                    IsSuccess = false,
                    StatusCode = 500,
                    Message = "Đăng ký không thành công, đã xảy ra lỗi!"
                };
            }

            return new Response
            {
                IsSuccess = true,
                StatusCode = 201,
                Message = "Đăng ký thành công!"
            };
        }
    }
}
