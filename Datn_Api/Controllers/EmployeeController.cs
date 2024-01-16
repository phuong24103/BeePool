using Datn_Api.IServices;
using Datn_Shared.Models;
using Datn_Shared.ViewModels.CustomerViewModels;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json.Linq;
using Newtonsoft.Json;
using Datn_Shared.ViewModels.EmployeeViewModels;

namespace Datn_Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeeController : ControllerBase
    {
        private readonly IEmployeeService _employeeService;

        public EmployeeController(IEmployeeService employeeService)
        {
            _employeeService = employeeService;
        }

        [HttpGet]
        [Route("GetAll")]
        public async Task<IActionResult> GetAllEmployee()
        {
            var customer = await _employeeService.GetAllEmployee();
            return Ok(customer);
        }

        [HttpGet]
        [Route("GetAllStaff")]
        public async Task<IActionResult> GetAllStaff()
        {
            var customer = await _employeeService.GetAllStaff();
            return Ok(customer);
        }

        [HttpGet]
        [Route("GetById/{id:Guid}")]
        public async Task<IActionResult> GetEmployeebyId(Guid id)
        {
            var customer = await _employeeService.GetEmployeebyId(id);
            return Ok(customer);
        }

        [HttpGet]
        [Route("GetByNames/{name}")]
        public async Task<IActionResult> GetEmployeebyNames(string name)
        {
            var customer = await _employeeService.GetEmployeebyNames(name);
            return Ok(customer);
        }

        [HttpGet]
        [Route("GetByName/{name}")]
        public async Task<IActionResult> GetEmployeebyName(string name)
        {
            var customer = await _employeeService.GetEmployeebyName(name);
            return Ok(customer);
        }

        [HttpPut]
        [Route("UpdatePassword/{userName}")]
        public async Task<IActionResult> UpdatePasswordEmployee(string userName, UpdatePasswordEmployee employee)
        {
            var result = await _employeeService.UpdatePasswordEmployee(userName, employee);
            if (result.IsSuccess)
            {
                return Ok(result.Token);
            }
            return StatusCode(result.StatusCode, result.Message);
        }

        [HttpPut]
        [Route("UpdateProfile/{userName}")]
        public async Task<IActionResult> UpdateProfileEmployee(string userName, UpdateProfileEmployee employee)
        {
            await _employeeService.UpdateProfileEmployee(userName, employee);
            return Ok(employee);
        }

        [HttpPut]
        [Route("UpdateImage/{userName}/{image}")]
        public async Task<IActionResult> UpdateImageEmployee(string userName, string image)
        {
            await _employeeService.UpdateImageEmployee(userName, image);
            return Ok(image);
        }
    }
}
