/*using Datn_Api.Migrations;*/
using Datn_Shared.Models;
using Datn_Shared.ViewModels.ProductViewModels;
using Microsoft.AspNetCore.Mvc;
using X.PagedList;

namespace Datn_Client.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class ProductController : Controller
    {
        private readonly HttpClient _httpClient;

        public ProductController(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        [HttpGet]
        public async Task<IActionResult> Index(Guid id,string date)
        {
            var cate = await _httpClient.GetFromJsonAsync<List<Category>>("https://localhost:7033/api/Category/GetAll");
            ViewData["a"] = cate;
            if (id == Guid.Empty)
            {
                if (date == "today")
                {
                    var pro = await _httpClient.GetFromJsonAsync<IEnumerable<Product>>("https://localhost:7033/api/Product/GetAll");
                    IEnumerable<Product> b = pro.Where(p => (p.CreateDate.DayOfYear == DateTime.Now.DayOfYear));
                    ViewBag.DatePro = date;
                    return View(b);
                }
                else if (date == "thisMonth")
                {
                    var pro = await _httpClient.GetFromJsonAsync<IEnumerable<Product>>("https://localhost:7033/api/Product/GetAll");
                    IEnumerable<Product> c = pro.Where(p => (p.CreateDate.Month == DateTime.Now.Month && p.CreateDate.Year == DateTime.Now.Year));
                    ViewBag.DatePro = date;
                    return View(c);
                }
                else if (date == "thisYear")
                {
                    var pro = await _httpClient.GetFromJsonAsync<IEnumerable<Product>>("https://localhost:7033/api/Product/GetAll");
                    IEnumerable<Product> c = pro.Where(p => (p.CreateDate.Year == DateTime.Now.Year));
                    ViewBag.DatePro = date;
                    return View(c);
                }
                else {
                    var categories = await _httpClient.GetFromJsonAsync<IEnumerable<ProductView>>("https://localhost:7033/api/Product/GetAll");
                    return View(categories); }
            }
            else
            {
                var categories = await _httpClient.GetFromJsonAsync<IEnumerable<ProductView>>("https://localhost:7033/api/Product/GetAll");
                var category = await _httpClient.GetFromJsonAsync<ProductView>($"https://localhost:7033/api/Product/GetById/{id}");
                List<ProductView> c = new List<ProductView>();

                c.Add(category);
                ViewData["p"] = c;
                return View(categories);
            }
        }
        
        public async Task<IActionResult> Detail(Guid id)
        {
            return RedirectToAction("Index",new {id = id});
        }

        [HttpGet]
        public async Task<IActionResult> Search(string Name)
        {
            return View("Index", await _httpClient.GetFromJsonAsync<List<ProductView>>($"https://localhost:7033/api/Product/GetByName/{Name}"));
        }
        [HttpPost]
        public async Task<IActionResult> Create( CreateProduct createProduct)
        {
            await _httpClient.PostAsJsonAsync($"https://localhost:7033/api/Product/Create", createProduct);
            return RedirectToAction("Index");
        }
        public async Task<IActionResult> Filter(string date)
        {
            return RedirectToAction("Index", new { date = date });
        }
        public async Task<IActionResult> Delete(Guid id)
        {
            await _httpClient.DeleteAsync($"https://localhost:7033/api/Product/Delete/{id}");
            return RedirectToAction("Index");
        }

        public async Task<IActionResult> Update(Guid id, UpdateProduct updateProduct)
        {
            await _httpClient.PutAsJsonAsync($"https://localhost:7033/api/Product/Update/{id}", updateProduct);
            return RedirectToAction("Index");
        }
    }
}
