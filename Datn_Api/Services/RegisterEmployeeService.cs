using Datn_Api.Data;
using Datn_Api.IServices;
using Datn_Shared.Models;
using Datn_Shared.ViewModels.AccountViewModels;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;

namespace Datn_Api.Services
{
    public class RegisterEmployeeService : IRegisterEmployeeService
    {
        private readonly MyDbContext _context;
        private readonly UserManager<Employee> _employeeManager;
        private readonly RoleManager<IdentityRole<Guid>> _roleManager;

        public RegisterEmployeeService(MyDbContext context, UserManager<Employee> employeeManager, RoleManager<IdentityRole<Guid>> roleManager)
        {
            _context = context;
            _employeeManager = employeeManager;
            _roleManager = roleManager;
        }

        public async Task<Response> RegisterAsync(Register registerEmployee, string role)
        {
            // Check employee is exists or not
            if (await _employeeManager.FindByEmailAsync(registerEmployee.Email) != null)
            {
                return new Response
                {
                    IsSuccess = false,
                    StatusCode = 400,
                    Message = "Email này đã tồn tại!"
                };
            }
            else if (await _employeeManager.FindByNameAsync(registerEmployee.Username) != null)
            {
                return new Response
                {
                    IsSuccess = false,
                    StatusCode = 400,
                    Message = "Tên người dùng này đã tồn tại!"
                };
            }

            // Check password is matching with confirm password or not
            if (registerEmployee.Password != registerEmployee.ConfirmPassword)
            {
                return new Response
                {
                    IsSuccess = false,
                    StatusCode = 400,
                    Message = "Mật khẩu này không khớp với mật khẩu xác nhận!"
                };
            }

            // Create an identity employee
            Employee identityEmployee = new()
            {
                Id = Guid.NewGuid(),
                UserName = registerEmployee.Username,
                Email = registerEmployee.Email,
                PhoneNumber = registerEmployee.PhoneNumber,
                Gender = Convert.ToInt32(registerEmployee.Gender),
                DateOfBirth = Convert.ToDateTime(registerEmployee.DateOfBirth),
                Address = registerEmployee.Address,
                CreateDate = DateTime.Now,
                Status = 0
            };

            // Check if roles is exists or not
            if (await _roleManager.RoleExistsAsync(role))
            {
                // Add employee to the database          
                var result = await _employeeManager.CreateAsync(identityEmployee, registerEmployee.Password);

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

                // Add role to the employee
                //await _employeeManager.AddToRoleAsync(identityEmployee, role);

                var roles = await _context.Roles.FirstOrDefaultAsync(p => p.Name == role);

                IdentityUserRole<Guid> userRole = new IdentityUserRole<Guid>()
                {
                    UserId = identityEmployee.Id,
                    RoleId = roles.Id,
                };

                await _context.UserRoles.AddAsync(userRole);
                await _context.SaveChangesAsync();

                return new Response
                {
                    IsSuccess = true,
                    StatusCode = 201,
                    Message = "Đăng ký thành công!"
                };
            }
            else
            {
                return new Response
                {
                    IsSuccess = false,
                    StatusCode = 404,
                    Message = "Vai trò này không tồn tại!"
                };
            }
        }
    }
}
