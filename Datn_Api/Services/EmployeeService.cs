using Datn_Api.Data;
using Datn_Api.IServices;
using Datn_Shared.Models;
using Datn_Shared.ViewModels.AccountViewModels;
using Datn_Shared.ViewModels.EmployeeViewModels;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using System.Data;

namespace Datn_Api.Services
{
    public class EmployeeService : IEmployeeService
    {
        private readonly MyDbContext _context;
        private readonly UserManager<Employee> _employeeManager;

        public EmployeeService(MyDbContext context, UserManager<Employee> employeeManager)
        {
            _context = context;
            _employeeManager = employeeManager;
        }

        public async Task<bool> ChangeRole(Guid id)
        {
            try
            {
                IdentityUserRole<Guid> userRole = new IdentityUserRole<Guid>()
                {
                    UserId = id,
                    RoleId = new Guid("b108d866-eb13-46e3-b3d2-ecae4fbfe873"),
                };
                _context.UserRoles.Remove(userRole);
                await _context.SaveChangesAsync();

                IdentityUserRole<Guid> userRoles = new IdentityUserRole<Guid>()
                {
                    UserId = id,
                    RoleId = new Guid("b108d866-eb13-46e3-b3d2-ecae4fbfe872"),
                };

                await _context.UserRoles.AddAsync(userRoles);
                await _context.SaveChangesAsync();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public async Task<List<Employee>> GetAllEmployee()
        {
            return await _context.Employees.ToListAsync();
        }

        public async Task<List<Employee>> GetAllStaff()
        {
            var staff = await _context.UserRoles.Where(p => p.RoleId == new Guid("b108d866-eb13-46e3-b3d2-ecae4fbfe873")).ToListAsync();
            List<Employee> employee = new List<Employee>();
            foreach (var item in staff)
            {
                var employ = await _context.Employees.Where(p => p.Id == item.UserId).FirstOrDefaultAsync();
                employee.Add(employ);
            }
            return employee;
        }

        public async Task<Employee> GetEmployeebyId(Guid id)
        {
            return await _context.Employees.FirstOrDefaultAsync(c => c.Id == id);
        }

        public async Task<EmployeeView> GetEmployeebyName(string name)
        {
            EmployeeView employeeView = new EmployeeView();
            employeeView = await
                (from a in _context.Employees
                 select new EmployeeView()
                 {
                     Id = a.Id,
                     FullName = a.FullName,
                     UserName = a.UserName,
                     Gender = a.Gender,
                     DateOfBirth = a.DateOfBirth,
                     Address = a.Address,
                     PhoneNumber = a.PhoneNumber,
                     Email = a.Email,
                     Image = a.Image,
                     Twitter = a.Twitter,
                     Facebook = a.Facebook,
                     Instagram = a.Instagram,
                     Linkedin = a.Linkedin,
                 }).Where(p => p.UserName.ToLower().Contains(name.ToLower())).FirstAsync();
            return employeeView;
        }

        public async Task<Employee> GetEmployeebyNames(string name)
        {
            return await _context.Employees.Where(p => p.UserName.ToLower().Contains(name.ToLower())).FirstOrDefaultAsync();
        }

        public async Task<bool> UpdateImageEmployee(string userName, string image)
        {
            try
            {
                var n = await _employeeManager.FindByNameAsync(userName);
                if (n == null) return false;
                Employee employee1 = n;
                employee1.Image = image;
                _context.Employees.Update(employee1);
                await _context.SaveChangesAsync();
                return true;

            }
            catch (Exception)
            {

                return false;
            }
        }

        public async Task<Response> UpdatePasswordEmployee(string userName, UpdatePasswordEmployee employee)
        {
            try
            {
                var check = await _employeeManager.FindByNameAsync(userName);
                if (employee.NewPassword != employee.ConfirmNewPassword)
                {
                    return new Response()
                    {
                        IsSuccess = false,
                        StatusCode = 400,
                        Message = "Mật khẩu xác nhận không trùng khớp"
                    };
                }
                else if (check != null && await _employeeManager.CheckPasswordAsync(check, employee.CurrentPassword))
                {
                    await _employeeManager.ChangePasswordAsync(check, employee.CurrentPassword, employee.NewPassword);
                    return new Response()
                    {
                        IsSuccess = true,
                        StatusCode = 200,
                        Message = "Đổi mật khẩu thành công"
                    };
                }
                return new Response()
                {
                    IsSuccess = false,
                    StatusCode = 400,
                    Message = "Sai Mật khẩu"
                };
            }
            catch (Exception)
            {
                return new Response()
                {
                    IsSuccess = false,
                    StatusCode = 400,
                    Message = "Đổi mật khẩu thất bại"
                };
            }
        }

        public async Task<bool> UpdateProfileEmployee(string userName, UpdateProfileEmployee employee)
        {
            try
            {
                var n = await _employeeManager.FindByNameAsync(userName);
                if (n == null) return false;

                n.FullName = employee.FullName;
                n.Gender = employee.Gender;
                n.DateOfBirth = employee.DateOfBirth;
                n.Address = employee.Address;
                n.PhoneNumber = employee.PhoneNumber;
                n.Email = employee.Email;
                n.Twitter = employee.Twitter;
                n.Facebook = employee.Facebook;
                n.Instagram = employee.Instagram;
                n.Linkedin = employee.Linkedin;

                _context.Employees.Update(n);
                await _context.SaveChangesAsync();
                return true;

            }
            catch (Exception)
            {

                return false;
            }
        }

        public async Task<bool> UpdateStaff(string userName, UpdateStaff staff)
        {
            try
            {
                var n = await _employeeManager.FindByNameAsync(userName);
                if (n == null) return false;

                n.FullName = staff.FullName;
                n.Gender = staff.Gender;
                n.DateOfBirth = staff.DateOfBirth;
                n.Address = staff.Address;
                n.PhoneNumber = staff.PhoneNumber;
                n.Email = staff.Email;
                n.Image = staff.Image;
                n.Status = staff.Status;
                n.Twitter = staff.Twitter;
                n.Facebook = staff.Facebook;
                n.Instagram = staff.Instagram;
                n.Linkedin = staff.Linkedin;

                _context.Employees.Update(n);
                await _context.SaveChangesAsync();
                return true;

            }
            catch (Exception)
            {

                return false;
            }
        }
    }
}
