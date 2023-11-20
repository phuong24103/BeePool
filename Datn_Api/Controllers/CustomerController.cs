using Datn_Api.IServices;
using Datn_Shared.Models;
using Datn_Shared.ViewModels.CartViewModels;
using Datn_Shared.ViewModels.CustomerViewModels;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json.Linq;
using Newtonsoft.Json;
using Datn_Api.Services;
using Datn_Shared.ViewModels.EmployeeViewModels;

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
        [Route("GetAll")]
        public async Task<IActionResult> GetAllCustomer()
		{
			var customer = await _customerService.GetAllCustomer();
			return Ok(customer);
		}

        [HttpGet]
        [Route("GetById/{id:Guid}")]
        public async Task<IActionResult> GetCustomerbyId(Guid id)
		{
			var customer = await _customerService.GetCustomerbyId(id);
			return Ok(customer);
		}

		[HttpGet]
		[Route("GetByName/{name}")]
		public async Task<IActionResult> GetCustomerbyName(string name)
		{
			var customer = await _customerService.GetCustomerbyName(name);
			return Ok(customer);
		}

		[HttpGet]
		[Route("GetByNameWithViewModel/{name}")]
		public async Task<IActionResult> GetCustomerByNameWithViewModel(string name)
		{
			var customer = await _customerService.GetCustomerByNameWithViewModel(name);
            JsonSerializerSettings settings = new JsonSerializerSettings
            {
                PreserveReferencesHandling = PreserveReferencesHandling.Objects
            };
            string json = JsonConvert.SerializeObject(customer, settings);
            JToken parsedJson = JToken.Parse(json);
            string formattedJson = parsedJson.ToString(Newtonsoft.Json.Formatting.Indented);
            return Ok(formattedJson);
		}

        [HttpPut]
        [Route("Update/{id:Guid}")]
        public async Task<ActionResult<CustomerView>> UpdateCustomer(Guid id, Customer customer)
		{
			await _customerService.UpdateCustomer(id, customer);
			return Ok(customer);
        }

        [HttpPut]
        [Route("UpdatePassword/{userName}")]
        public async Task<IActionResult> UpdatePasswordCustomer(string userName, UpdatePasswordCustomer customer)
        {
            var result = await _customerService.UpdatePasswordCustomer(userName, customer);
            if (result.IsSuccess)
            {
                return Ok(result.Token);
            }
            return StatusCode(result.StatusCode, result.Message);
        }

        [HttpPut]
        [Route("UpdateProfile/{userName}")]
        public async Task<IActionResult> UpdateProfileCustomer(string userName, UpdateProfileCustomer customer)
        {
            await _customerService.UpdateProfileCustomer(userName, customer);
            return Ok(customer);
        }

        [HttpPut]
        [Route("UpdateImage/{userName}/{image}")]
        public async Task<IActionResult> UpdateImageCustomer(string userName, string image)
        {
            await _customerService.UpdateImageCustomer(userName, image);
            return Ok(image);
        }

        [HttpGet]
        [Route("GetTotalCustomer")]
        public async Task<IActionResult> GetTotalCustomer()
        {
            var sales = await _customerService.GetTotalCustomer();
            return Ok(sales);
        }

        [HttpGet]
        [Route("GetTotalCustomer/{date}")]
        public async Task<IActionResult> GetTotalCustomerFilter(string date)
        {
            var sales = await _customerService.GetTotalCustomerFilter(date);
            return Ok(sales);
        }

        [HttpGet]
        [Route("GetReportTotalCustomer")]
        public async Task<IActionResult> GetReportTotalCustomer()
        {
            var customers = await _customerService.GetReportTotalCustomer();
            return Ok(customers);
        }
    }
}
