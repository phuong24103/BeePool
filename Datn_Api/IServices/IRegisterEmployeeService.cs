using Datn_Shared.ViewModels.AccountViewModels;

namespace Datn_Api.IServices
{
    public interface IRegisterEmployeeService
    {
        public Task<Response> RegisterAsync(Register registerEmployee, string role);
    }
}
