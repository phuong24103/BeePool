using Datn_Shared.ViewModels.AccountViewModels;
using Datn_Shared.ViewModels.PostViewModels;
using Microsoft.AspNetCore.Mvc;
using X.PagedList;

namespace Datn_Client.Controllers
{
    public class NewsController : Controller
    {
        private readonly HttpClient _httpClient;

        public NewsController(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        [HttpGet]
        public async Task<IActionResult> Index(int page = 1, int pageSize = 6)
        {
            var postsFromApi = await _httpClient.GetFromJsonAsync<List<PostView>>("https://localhost:7033/api/Post/GetAll");
            var pagedList = new PagedList<PostView>(postsFromApi, page, pageSize);
            return View("Index", pagedList);
        }

        [HttpGet]
        public async Task<IActionResult> Detail(Guid id)
        {
            var posts = await _httpClient.GetFromJsonAsync<List<PostView>>("https://localhost:7033/api/Post/GetAll");
            ViewBag.Posts = posts.Take(5).ToList();
            var postFromApi = await _httpClient.GetFromJsonAsync<PostView>($"https://localhost:7033/api/Post/GetById/{id}");
            return View(postFromApi);
        }
    }
}
