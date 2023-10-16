using Datn_Api.IServices;
using Datn_Shared.Models;
using Datn_Shared.ViewModels.CartViewModels;
using Datn_Shared.ViewModels.CustomerViewModels;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace Datn_Api.Controllers
{
	[Route("api/[controller]")]
	[ApiController]
	public class CustomerController : ControllerBase
	{
		private readonly ICustomerService _customerService;

		public CustomerController(ICustomerService customerService)
		{
			_customerService = customerService;
		}

		[HttpGet]
		public async Task<IActionResult> GetAllCustomer()
		{
			var customer = await _customerService.GetAllCustomer();
			return Ok(customer);
		}

		[HttpGet("{id:Guid}")]
		public async Task<IActionResult> GetCustomerbyId(Guid id)
		{
			var customer = await _customerService.GetCustomerbyId(id);
			return Ok(customer);
		}

		[HttpPut]
		public async Task<ActionResult<CustomerView>> UpdateCustomer(Guid id, Customer customer)
		{
			await _customerService.UpdateCustomer(id, customer);
			return Ok(customer);
		}
	}
}
