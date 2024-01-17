using Datn_Shared.Models;
using Datn_Shared.ViewModels.PostViewModels;
using Datn_Shared.ViewModels.ProductDetailViewModels;
using Datn_Shared.ViewModels.ProductImageViewModels;
using Microsoft.AspNetCore.Mvc;
using System.Security.Claims;
using System.Web;

namespace Datn_Client.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class ProductImageController : Controller
    {
        private readonly HttpClient _httpClient;
        public ProductImageController(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }
        public async Task<IActionResult> Index(Guid id)
        {
            var userName = User.FindFirstValue(ClaimTypes.NameIdentifier);
            var role = User.FindFirstValue(ClaimTypes.Role);
            if (userName != null && role != null)
            {
                var images = await _httpClient.GetFromJsonAsync<IEnumerable<ProductImage>>("https://localhost:7033/api/ProductImage/GetAll");
                if (id != Guid.Empty)
                {
                    var image = await _httpClient.GetFromJsonAsync<ProductImage>($"https://localhost:7033/api/ProductImage/GetById/{id}");

                    List<ProductImage> i = new List<ProductImage>();
                    i.Add(image);
                    ViewData["Image"] = i;
                }

                return View(images);
            }
            return RedirectToAction("Login", "Login", new { areas = "Admin" });
        }
        public async Task<IActionResult> Detail(Guid id)
        {
            return RedirectToAction("Index", new { id = id });
        }
        public async Task<IActionResult> Create(List<IFormFile> imageFile)
        {
            CreateProductImage i = new CreateProductImage();
            foreach (var item in imageFile)
            {
                if (item != null && item.Length > 0)
                {
                    string images = Guid.NewGuid().ToString() + "_" + item.FileName;
                    var path = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot", "images", "products", images);
                    using (var stream = new FileStream(path, FileMode.Create))
                    {
                        await item.CopyToAsync(stream);
                    }

                    i.Name = images;

                }
                i.Status = 0;
                i.ProductDetailId = ViewBag.ProductDetailId;
                await _httpClient.PostAsJsonAsync($"https://localhost:7033/api/ProductImage/Create", i);
            }
            return RedirectToAction("Index");
        }
        public async Task<IActionResult> Update(Guid id, UpdateProductImage i, IFormFile imageFile)
        {

            if (imageFile != null && imageFile.Length > 0)
            {
                string image = Guid.NewGuid().ToString() + "_" + imageFile.FileName;
                var path = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot", "images", "posts", image);
                using (var stream = new FileStream(path, FileMode.Create))
                {
                    await imageFile.CopyToAsync(stream);
                }
            }
            else
            {
                var p = await _httpClient.GetFromJsonAsync<ProductImage>($"https://localhost:7033/api/ProductImage/GetById/{id}");
                return View(p);
            }
            await _httpClient.PutAsJsonAsync($"https://localhost:7033/api/ProductImage/Update/{id}", i);
            return RedirectToAction("Index");
        }
        public async Task<IActionResult> Delete(Guid id)
        {
            await _httpClient.DeleteAsync($"https://localhost:7033/api/ProductImage/Delete/{id}");
            return RedirectToAction("Index");
        }
    }
}
