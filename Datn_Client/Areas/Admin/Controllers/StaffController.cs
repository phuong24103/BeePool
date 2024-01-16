using Datn_Shared.Models;
using Microsoft.AspNetCore.Mvc;
using System.Net.Http;

namespace Datn_Client.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class StaffController : Controller
    {
        private readonly HttpClient _httpClient;

        public StaffController(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public async Task<IActionResult> IndexAsync(Guid id)
        {
            var staffs = await _httpClient.GetFromJsonAsync<IEnumerable<Employee>>("https://localhost:7033/api/Employee/GetAllStaff");
            var staff = await _httpClient.GetFromJsonAsync<Employee>($"https://localhost:7033/api/Employee/GetById/{id}");
            List<Employee> c = new List<Employee>();
            c.Add(staff);
            ViewData["Employee"] = c;
            return View(staffs);
        }
        public async Task<IActionResult> Detail(Guid id)
        {
            return RedirectToAction("Index", new { id = id });
        }
        public async Task<IActionResult> Delete(Guid id)
        {
            await _httpClient.DeleteAsync($"https://localhost:7033/api/Employee/Delete/{id}");
            return RedirectToAction("Index");
        }
    }
}
