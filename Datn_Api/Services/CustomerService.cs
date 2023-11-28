using Datn_Api.Data;
using Datn_Api.IServices;
using Datn_Shared.Models;
using Datn_Shared.ViewModels.AccountViewModels;
using Datn_Shared.ViewModels.CustomerViewModels;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using System;

namespace Datn_Api.Services
{
    public class CustomerService : ICustomerService
    {
        private readonly MyDbContext _context;
        private readonly UserManager<Customer> _customerManager;

        public CustomerService(MyDbContext context, UserManager<Customer> customerManager)
        {
            _context = context;
            _customerManager = customerManager;
        }

        public async Task<List<Customer>> GetAllCustomer()
        {
            return await _context.Customers.ToListAsync();
        }

        public async Task<CustomerView> GetCustomerByNameWithViewModel(string name)
        {
            CustomerView customerView = new CustomerView();
            customerView = await
                (from a in _context.Customers
                 join b in _context.Ranks on a.RankId equals b.Id
                 join c in _context.Carts on a.Id equals c.CustomerId
                 select new CustomerView()
                 {
                     Customer = a,
                     Rank = b,
                     Cart = c,
                 }).Where(p => p.Customer.UserName.ToLower().Contains(name.ToLower())).FirstAsync();
            return customerView;
        }

        public async Task<Customer> GetCustomerbyId(Guid id)
        {
            return await _context.Customers.FirstOrDefaultAsync(c => c.Id == id);
        }

        public async Task<Customer> GetCustomerbyName(string name)
        {
            return await _context.Customers.Where(p => p.UserName.ToLower().Contains(name.ToLower())).FirstOrDefaultAsync();
        }

        public async Task<bool> UpdateCustomer(Guid id, Customer customer)
        {
            var n = _context.Customers.Find(id);
            if (n == null) return false;
            n.RankId = customer.RankId;
            try
            {
                _context.Customers.Update(customer);
                await _context.SaveChangesAsync();
                return true;

            }
            catch (Exception)
            {

                return false;
            }
        }

        public async Task<bool> UpdateImageCustomer(string userName, string image)
        {
            try
            {
                var n = await _customerManager.FindByNameAsync(userName);
                if (n == null) return false;
                Customer customer = n;
                customer.Image = image;
                _context.Customers.Update(customer);
                await _context.SaveChangesAsync();
                return true;

            }
            catch (Exception)
            {

                return false;
            }
        }

        public async Task<Response> UpdatePasswordCustomer(string userName, UpdatePasswordCustomer customer)
        {
            try
            {
                var check = await _customerManager.FindByNameAsync(userName);
                if (customer.NewPassword != customer.ConfirmNewPassword)
                {
                    return new Response()
                    {
                        IsSuccess = false,
                        StatusCode = 400,
                        Message = "Mật khẩu xác nhận không trùng khớp"
                    };
                }
                else if (check != null && await _customerManager.CheckPasswordAsync(check, customer.CurrentPassword))
                {
                    await _customerManager.ChangePasswordAsync(check, customer.CurrentPassword, customer.NewPassword);
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

        public async Task<bool> UpdateProfileCustomer(string userName, UpdateProfileCustomer customer)
        {
            try
            {
                var n = await _customerManager.FindByNameAsync(userName);
                if (n == null) return false;

                Customer customer1 = n;
                customer1.FullName = customer.FullName;
                customer1.Gender = customer.Gender;
                customer1.DateOfBirth = customer.DateOfBirth;
                customer1.Address = customer.Address;
                customer1.PhoneNumber = customer.PhoneNumber;
                customer1.Email = customer.Email;

                _context.Customers.Update(customer1);
                await _context.SaveChangesAsync();
                return true;

            }
            catch (Exception)
            {

                return false;
            }
        }
        
        
        public async Task<bool> UpdatePointCustomer(Guid id, Customer customer)
        {
            try
            {
                var n = _context.Customers.Find(id);
                if (n == null) return false;
                n.Point = customer.Point;
                if(customer.Point >= 12000)
                {
                    n.RankId = Guid.Parse("a77f8ae9-af3d-4288-bbf3-8f77776f9236");
                }
                else if(customer.Point >= 8000)
                {
                    n.RankId = Guid.Parse("a77f8ae9-af3d-4288-bbf3-8f77776f9235");
                }
                else if (customer.Point >= 5000)
                {
                    n.RankId = Guid.Parse("a77f8ae9-af3d-4288-bbf3-8f77776f9234");
                }
                else if (customer.Point >= 2000)
                {
                    n.RankId = Guid.Parse("a77f8ae9-af3d-4288-bbf3-8f77776f9233");
                }
                else if (customer.Point >= 1000)
                {
                    n.RankId = Guid.Parse("a77f8ae9-af3d-4288-bbf3-8f77776f9232");
                }

                _context.Customers.Update(n);
                await _context.SaveChangesAsync();
                return true;

            }
            catch (Exception)
            {
                return false;
            }
        }

        public async Task<int> GetTotalCustomer()
        {
            var customers = await _context.Customers.ToListAsync();
            if (customers != null)
            {
                return customers.Count;
            }
            return 0;
        }

        public async Task<int> GetTotalCustomerFilter(string date)
        {
            var customers = await _context.Customers.ToListAsync();
            if (customers != null)
            {
                if (date == "today" || date == "thisMonth" || date == "thisYear")
                {
                    int total = 0;
                    foreach (var customer in customers)
                    {
                        if (date == "today")
                        {
                            if (customer.CreateDate.DayOfYear == DateTime.Now.DayOfYear)
                            {
                                total++;
                            }
                        }
                        else if (date == "thisYear")
                        {
                            if (customer.CreateDate.Year == DateTime.Now.Year)
                            {
                                total++;
                            }
                        }
                        else if (date == "thisMonth")
                        {
                            if (customer.CreateDate.Year == DateTime.Now.Year && customer.CreateDate.Month == DateTime.Now.Month)
                            {
                                total++;
                            }
                        }
                    }
                    return total;
                }
                return customers.Count;
            }
            return 0;
        }

        public async Task<string> GetReportTotalCustomer()
        {
            var customers = await _context.Customers.ToListAsync();
            if (customers != null)
            {
                string customer = "";
                List<Customer> total = new List<Customer>();
                for (int i = 0; i < customers.Count; i++)
                {
                    if (customers[i].FullName != null)
                    {
                        /*if (customers[i].CreateDate.DayOfYear == DateTime.Now.AddHours(-i).DayOfYear)
                        {*/
                            total.Add(customers[i]);
                        /*}*/
                    }
                    customer += total.Count;
                    total.Clear();
                    if (i > 1)
                    {
                        customer += ", ";
                    }
                }
                return customer;
            }
            return "";
        }
    }
}
