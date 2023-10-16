using Datn_Api.IServices;
using Datn_Shared.ViewModels.AccountViewModels;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Datn_Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RegisterEmployeeController : ControllerBase
    {
        private readonly IRegisterEmployeeService _registerService;
        public RegisterEmployeeController(IRegisterEmployeeService registerService)
        {
            _registerService = registerService;
        }
        [HttpPost]
        public async Task<IActionResult> Register(Register registerEmployee, string role)
        {
            var result = await _registerService.RegisterAsync(registerEmployee, role);
            return StatusCode(result.StatusCode, result.Message);
        }
    }
}
