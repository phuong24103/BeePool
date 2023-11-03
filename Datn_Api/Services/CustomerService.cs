using Datn_Api.Data;
using Datn_Api.IServices;
using Datn_Shared.Models;
using Datn_Shared.ViewModels.CartViewModels;
using Datn_Shared.ViewModels.CustomerViewModels;
using Datn_Shared.ViewModels.EmployeeViewModels;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using System.Xml.Linq;

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
    }
}
