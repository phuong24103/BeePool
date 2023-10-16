using Datn_Api.IServices;
using Datn_Shared.ViewModels.AccountViewModels;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Datn_Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LoginEmployeeController : ControllerBase
    {
        private readonly ILoginEmployeeService _loginService;
        public LoginEmployeeController(ILoginEmployeeService loginService)
        {
            _loginService = loginService;
        }
        [HttpPost]
        public async Task<IActionResult> Login(Login loginEmployee)
        {
            var result = await _loginService.LoginAsync(loginEmployee);
            if (result.IsSuccess)
            {
                return Ok(result.Token);
            }
            return StatusCode(result.StatusCode, result.Message);
        }
    }
}
