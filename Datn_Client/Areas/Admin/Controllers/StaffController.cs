using Datn_Shared.Models;
using Datn_Shared.ViewModels.CategoryViewModels;
using Datn_Shared.ViewModels.EmployeeViewModels;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System.Net.Http;
using System.Net.Http.Json;
using System.Security.Claims;

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

        public async Task<IActionResult> IndexAsync(Guid id, string date)
        {
            var userName = User.FindFirstValue(ClaimTypes.NameIdentifier);
            var role = User.FindFirstValue(ClaimTypes.Role);
            if (userName != null && role != null)
            {
                var staffs = await _httpClient.GetFromJsonAsync<IEnumerable<Employee>>("https://localhost:7033/api/Employee/GetAllStaff");
                if (id == Guid.Empty)
                {
                    if (date == "today")
                    {
                        IEnumerable<Employee> c = staffs.Where(p => p.CreateDate.DayOfYear == DateTime.Now.DayOfYear);
                        ViewBag.DateEmployee = date;
                        return View(c);
                    }
                    else if (date == "thisMonth")
                    {
                        IEnumerable<Employee> c = staffs.Where(p => p.CreateDate.Month == DateTime.Now.Month && p.CreateDate.Year == DateTime.Now.Year);
                        ViewBag.DateEmployee = date;
                        return View(c);
                    }
                    else if (date == "thisYear")
                    {
                        IEnumerable<Employee> c = staffs.Where(p => p.CreateDate.Year == DateTime.Now.Year);
                        ViewBag.DateEmployee = date;
                        return View(c);
                    }
                }
                else
                {
                    var staff = await _httpClient.GetFromJsonAsync<Employee>($"https://localhost:7033/api/Employee/GetById/{id}");
                    List<Employee> c = new List<Employee>();
                    c.Add(staff);
                    ViewData["Employee"] = c;
                }
                return View(staffs);
            }
            return RedirectToAction("Login", "Login", new { areas = "Admin"});
        }
        public async Task<IActionResult> Detail(Guid id)
        {
            return RedirectToAction("Index", new { id = id });
        }
        public async Task<IActionResult> Filter(string date)
        {
            return RedirectToAction("Index", new { date = date });
        }
        public async Task<IActionResult> Update(Guid id, UpdateStaff staff)
        {
            var staffs = await _httpClient.GetFromJsonAsync<Employee>($"https://localhost:7033/api/Employee/GetById/{id}");
            await _httpClient.PutAsJsonAsync($"https://localhost:7033/api/Employee/UpdateStaff/{staffs.UserName}", staff);
            return RedirectToAction("Index");
        }
        public async Task<IActionResult> Delete(Guid id)
        {
            await _httpClient.DeleteAsync($"https://localhost:7033/api/Employee/Delete/{id}");
            return RedirectToAction("Index");
        }
        public async Task<IActionResult> ChangeRole(Guid id)
        {
            await _httpClient.PutAsJsonAsync<IdentityUserRole<Guid>>($"https://localhost:7033/api/Employee/ChangeRole/{id}", null);
            return RedirectToAction("Index");
        }
    }
}
