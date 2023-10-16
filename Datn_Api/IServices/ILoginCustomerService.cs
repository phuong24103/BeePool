using Datn_Shared.ViewModels.AccountViewModels;

namespace Datn_Api.IServices
{
    public interface ILoginCustomerService
    {
        public Task<Response> LoginAsync(Login loginCustomer);
    }
}
