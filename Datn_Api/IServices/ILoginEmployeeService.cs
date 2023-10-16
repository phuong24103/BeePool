using Datn_Shared.ViewModels.AccountViewModels;

namespace Datn_Api.IServices
{
    public interface ILoginEmployeeService
    {
        public Task<Response> LoginAsync(Login loginEmployee);
    }
}
