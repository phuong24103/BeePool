using Datn_Api.IServices;
using Datn_Shared.ViewModels.AccountViewModels;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Datn_Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LoginCustomerController : ControllerBase
    {
        private readonly ILoginCustomerService _loginService;
        public LoginCustomerController(ILoginCustomerService loginService)
        {
            _loginService = loginService;
        }
        [HttpPost]
        public async Task<IActionResult> Login(Login loginCustomer)
        {
            var result = await _loginService.LoginAsync(loginCustomer);
            if (result.IsSuccess)
            {
                return Ok(result.Token);
            }
            return StatusCode(result.StatusCode, result.Message);
        }
    }
}
