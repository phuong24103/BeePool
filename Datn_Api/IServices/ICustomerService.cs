using Datn_Shared.Models;
using Datn_Shared.ViewModels.CustomerViewModels;

namespace Datn_Api.IServices
{
	public interface ICustomerService
	{
		public Task<List<Customer>> GetAllCustomer();
		public Task<Customer> GetCustomerbyId(Guid id);
		public Task<Customer> GetCustomerbyName(string name);
		public Task<CustomerView> GetCustomerByNameWithViewModel(string name);
        public Task<bool> UpdateCustomer(Guid id, Customer customer);
        public Task<bool> UpdateImageCustomer(string userName, string image);
    }
}
