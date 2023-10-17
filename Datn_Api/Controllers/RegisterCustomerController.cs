using Datn_Api.IServices;
using Datn_Shared.ViewModels.AccountViewModels;
using Datn_Shared.ViewModels.CartViewModels;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Datn_Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RegisterCustomerController : ControllerBase
    {
        private readonly IRegisterCustomerService _registerService;

        public RegisterCustomerController(IRegisterCustomerService registerService)
        {
            _registerService = registerService;
        }

        [HttpPost]
        public async Task<IActionResult> Register(Register registerCustomer)
        {
            var result = await _registerService.RegisterAsync(registerCustomer);
            return StatusCode(result.StatusCode, result.Message);
        }
    }
}
