using Datn_Shared.Models;
using Datn_Shared.ViewModels.CategoryViewModels;
using Datn_Shared.ViewModels.CustomerViewModels;
using Datn_Shared.ViewModels.PostViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Hosting;
using System.Security.Claims;

namespace Datn_Client.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class PostController : Controller
    {
        private readonly HttpClient _httpClient;
        public PostController(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public async Task<IActionResult> Index(Guid id, string date)
        {
            var userName = User.FindFirstValue(ClaimTypes.NameIdentifier);
            var role = User.FindFirstValue(ClaimTypes.Role);
            if (userName != null && role != null)
            {

                if (id == Guid.Empty)
                {
                    if (date == "today")
                    {
                        var posts = await _httpClient.GetFromJsonAsync<IEnumerable<PostView>>("https://localhost:7033/api/Post/GetAll");
                        IEnumerable<PostView> c = posts.Where(p => (p.CreatedDate.DayOfYear == DateTime.Now.DayOfYear) || (p.UpdatedDate.DayOfYear == DateTime.Now.DayOfYear));
                        ViewBag.DatePost = date;
                        return View(c);
                    }
                    else if (date == "thisMonth")
                    {
                        var posts = await _httpClient.GetFromJsonAsync<IEnumerable<PostView>>("https://localhost:7033/api/Post/GetAll");
                        IEnumerable<PostView> c = posts.Where(p => (p.CreatedDate.Month == DateTime.Now.Month && p.CreatedDate.Year == DateTime.Now.Year) || (p.UpdatedDate.Month == DateTime.Now.Month && p.UpdatedDate.Year == DateTime.Now.Year));
                        ViewBag.DatePost = date;
                        return View(c);
                    }
                    else if (date == "thisYear")
                    {
                        var posts = await _httpClient.GetFromJsonAsync<IEnumerable<PostView>>("https://localhost:7033/api/Post/GetAll");
                        IEnumerable<PostView> c = posts.Where(p => (p.CreatedDate.Year == DateTime.Now.Year) || (p.UpdatedDate.Year == DateTime.Now.Year));
                        ViewBag.DatePost = date;
                        return View(c);
                    }
                    else
                    {
                        var posts = await _httpClient.GetFromJsonAsync<IEnumerable<PostView>>("https://localhost:7033/api/Post/GetAll");
                        return View(posts);
                    }
                }
                else
                {
                    var posts = await _httpClient.GetFromJsonAsync<IEnumerable<PostView>>("https://localhost:7033/api/Post/GetAll");
                    var post = await _httpClient.GetFromJsonAsync<PostView>($"https://localhost:7033/api/Post/GetById/{id}");
                    List<PostView> p = new List<PostView>();
                    p.Add(post);
                    ViewData["Post"] = p;
                    return View(posts);
                }
            }
            return RedirectToAction("Login", "Login", new { areas = "Admin" });
        }
        public async Task<IActionResult> Detail(Guid id)
        {
            return RedirectToAction("Index", new { id = id });
        }
        public async Task<IActionResult> Filter(string date)
        {
            return RedirectToAction("Index", new { date = date });
        }
        public async Task<IActionResult> Create(CreatePost post, IFormFile imageFile)
        {
            var userName = User.FindFirstValue(ClaimTypes.NameIdentifier);
            var role = User.FindFirstValue(ClaimTypes.Role);
            if (userName != null && role != null)
            {
                var employee = await _httpClient.GetFromJsonAsync<Employee>($"https://localhost:7033/api/Employee/GetByNames/{userName}");
                post.EmployeeId = employee.Id;
                if (imageFile != null && imageFile.Length > 0)
                {
                    string image = Guid.NewGuid().ToString() + "_" + imageFile.FileName;
                    var path = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot", "images", "posts", image);
                    using (var stream = new FileStream(path, FileMode.Create))
                    {
                        await imageFile.CopyToAsync(stream);
                    }
                    post.Image = image;

                }
                await _httpClient.PostAsJsonAsync($"https://localhost:7033/api/Post/Create", post);
            }
            return RedirectToAction("Index");
        }
        public async Task<IActionResult> Update(Guid id, UpdatePost post, IFormFile imageFile)
        {
            var userName = User.FindFirstValue(ClaimTypes.NameIdentifier);
            var role = User.FindFirstValue(ClaimTypes.Role);
            if (userName != null && role != null)
            {
                if (imageFile != null && imageFile.Length > 0)
                {
                    string image = Guid.NewGuid().ToString() + "_" + imageFile.FileName;
                    var path = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot", "images", "posts", image);
                    using (var stream = new FileStream(path, FileMode.Create))
                    {
                        await imageFile.CopyToAsync(stream);
                    }
                    post.Image = image;
                }
                else
                {
                    var p = await _httpClient.GetFromJsonAsync<PostView>($"https://localhost:7033/api/Post/GetById/{id}");
                    post.Image = p.Image;
                }
                await _httpClient.PutAsJsonAsync($"https://localhost:7033/api/Post/Update/{id}", post);
            }
            return RedirectToAction("Index");
        }
        public async Task<IActionResult> Delete(Guid id)
        {
            await _httpClient.DeleteAsync($"https://localhost:7033/api/Post/Delete/{id}");
            return RedirectToAction("Index");
        }
    }
}
