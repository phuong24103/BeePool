using Microsoft.AspNetCore.Mvc;
using Datn_Shared.Models;
using Humanizer;
/*using Datn_Api.Migrations;*/
using Datn_Shared.ViewModels.BrandViewModels;

namespace Datn_Client.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class BrandController : Controller
    {
        private readonly HttpClient _httpClient;
        public BrandController(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }
        public async Task<IActionResult> Index(Guid id , string date)
        {
            if (id == Guid.Empty)
            {
                if (date == "today")
                {
                    var brand = await _httpClient.GetFromJsonAsync<IEnumerable<Brand>>("https://localhost:7033/api/Brand/GetAll");
                    IEnumerable<Brand> b = brand.Where(p => (p.DateCreated.DayOfYear == DateTime.Now.DayOfYear));
                    ViewBag.DateBrand = date;
                    return View(b);
                }
                else if (date == "thisMonth")
                {
                    var brand = await _httpClient.GetFromJsonAsync<IEnumerable<Brand>>("https://localhost:7033/api/Brand/GetAll");
                    IEnumerable<Brand> c = brand.Where(p => (p.DateCreated.Month == DateTime.Now.Month && p.DateCreated.Year == DateTime.Now.Year));
                    ViewBag.DateBrand = date;
                    return View(c);
                }
                else if (date == "thisYear")
                {
                    var brand = await _httpClient.GetFromJsonAsync<IEnumerable<Brand>>("https://localhost:7033/api/Brand/GetAll");
                    IEnumerable<Brand> c = brand.Where(p => (p.DateCreated.Year == DateTime.Now.Year));
                    ViewBag.DateBrand = date;
                    return View(c);
                }
                else
                {
                    var brand = await _httpClient.GetFromJsonAsync<IEnumerable<Brand>>("https://localhost:7033/api/Brand/GetAll");
                    return View(brand);
                }
            }
            else
            {
                var brands = await _httpClient.GetFromJsonAsync<IEnumerable<Brand>>("https://localhost:7033/api/Brand/GetAll");
                var brand = await _httpClient.GetFromJsonAsync<Brand>($"https://localhost:7033/api/Brand/GetById/{id}");
                List<Brand> c = new List<Brand>();
                c.Add(brand);
                ViewData["Brand"] = c;
                return View(brands);
            }
        }
        public async Task<IActionResult> Detail(Guid id)
        {
            return RedirectToAction("Index", new { id = id });
        }
        public async Task<IActionResult> Filter(string date)
        {
            return RedirectToAction("Index", new { date = date });
        }
        public async Task<IActionResult> Create(CreateBrand createBrand)
        {
            await _httpClient.PostAsJsonAsync($"https://localhost:7033/api/Brand/Create", createBrand);
            return RedirectToAction("Index");
        }
        public async Task<IActionResult> Update(Guid id, UpdateBrand  brand)
        {
            await _httpClient.PutAsJsonAsync($"https://localhost:7033/api/Brand/Update/{id}", brand);
            return RedirectToAction("Index");
        }
        public async Task<IActionResult> Delete(Guid id)
        {
            await _httpClient.DeleteAsync($"https://localhost:7033/api/Brand/Delete/{id}");
            return RedirectToAction("Index");
        }
    }
    }
