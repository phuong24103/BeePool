using Datn_Shared.Models;

namespace Datn_Api.IServices
{
	public interface ICustomerService
	{
		public Task<List<Customer>> GetAllCustomer();
		public Task<Customer> GetCustomerbyId(Guid id);
		public Task<bool> UpdateCustomer(Guid id, Customer customer);
	}
}
