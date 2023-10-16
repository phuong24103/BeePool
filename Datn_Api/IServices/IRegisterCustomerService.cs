using Datn_Shared.ViewModels.AccountViewModels;

namespace Datn_Api.IServices
{
    public interface IRegisterCustomerService
    {
        public Task<Response> RegisterAsync(Register registerCustomer);
    }
}
