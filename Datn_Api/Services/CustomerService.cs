using Datn_Api.Data;
using Datn_Api.IServices;
using Datn_Shared.Models;
using Microsoft.EntityFrameworkCore;

namespace Datn_Api.Services
{
	public class CustomerService : ICustomerService
	{
		private readonly MyDbContext _context;

		public CustomerService(MyDbContext context)
		{
			_context = context;
		}

		public async Task<List<Customer>> GetAllCustomer()
		{
			return await _context.Customers.ToListAsync();
		}

		public async Task<Customer> GetCustomerbyId(Guid id)
		{
			return await _context.Customers.FirstOrDefaultAsync(c => c.Id == id);
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
	}
}
