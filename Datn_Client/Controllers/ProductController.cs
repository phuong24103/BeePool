using AspNetCore.PaginatedList;
using Datn_Api.Data;
using Datn_Shared.Models;
using Datn_Shared.ViewModels.ProductDetailViewModels;
using Datn_Shared.ViewModels.ProductViewModels;
using Datn_Shared.ViewModels.TipViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using System.Drawing.Printing;
using X.PagedList;

namespace Datn_Client.Controllers
{
    public class ProductController : Controller
    {
        private readonly HttpClient _httpClient;

        public ProductController(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        [HttpGet]
        public async Task<IActionResult> Index(int page = 1, int pageSize = 6)
        {
            var productsFromApi = await _httpClient.GetFromJsonAsync<List<ProductView>>("https://localhost:7033/api/Product/GetAll");
            var pagedList = new PagedList<ProductView>(productsFromApi, page, pageSize);
            return View("Index", pagedList);
        }

        [HttpGet]
        public async Task<IActionResult> Search(string Name, int page = 1, int pageSize = 6)
        {
            var productsFromApi = await _httpClient.GetFromJsonAsync<List<ProductView>>($"https://localhost:7033/api/Product/GetByName/{Name}");
            var pagedList = new PagedList<ProductView>(productsFromApi, page, pageSize);
            return View("Index", pagedList);
        }

        [HttpGet]
        public async Task<IActionResult> GetByCategory(string name, int page = 1, int pageSize = 6)
        {
            var productsFromApi = await _httpClient.GetFromJsonAsync<List<ProductView>>($"https://localhost:7033/api/Product/GetByCategory/{name}");
            var pagedList = new PagedList<ProductView>(productsFromApi, page, pageSize);
            return View("Index", pagedList);
        }

        [HttpGet]
        public async Task<IActionResult> GetByNameAZ(int page = 1, int pageSize = 6)
        {
            var productsFromApi = await _httpClient.GetFromJsonAsync<List<ProductView>>("https://localhost:7033/api/Product/GetByNameAZ");
            var pagedList = new PagedList<ProductView>(productsFromApi, page, pageSize);
            return View("Index", pagedList);
        }

        [HttpGet]
        public async Task<IActionResult> GetByNameZA(int page = 1, int pageSize = 6)
        {
            var productsFromApi = await _httpClient.GetFromJsonAsync<List<ProductView>>("https://localhost:7033/api/Product/GetByNameZA");
            var pagedList = new PagedList<ProductView>(productsFromApi, page, pageSize);
            return View("Index", pagedList);
        }

        [HttpGet]
        public async Task<IActionResult> GetByCreateDateOld(int page = 1, int pageSize = 6)
        {
            var productsFromApi = await _httpClient.GetFromJsonAsync<List<ProductView>>("https://localhost:7033/api/Product/GetByCreateDateOld");
            var pagedList = new PagedList<ProductView>(productsFromApi, page, pageSize);
            return View("Index", pagedList);
        }

        [HttpGet]
        public async Task<IActionResult> GetByCreateDateNew(int page = 1, int pageSize = 6)
        {
            var productsFromApi = await _httpClient.GetFromJsonAsync<List<ProductView>>("https://localhost:7033/api/Product/GetByCreateDateNew");
            var pagedList = new PagedList<ProductView>(productsFromApi, page, pageSize);
            return View("Index", pagedList);
        }

        [HttpGet]
        public async Task<IActionResult> GetByPriceMin(int page = 1, int pageSize = 6)
        {
            var productsFromApi = await _httpClient.GetFromJsonAsync<List<ProductView>>("https://localhost:7033/api/Product/GetByPriceMin");
            var pagedList = new PagedList<ProductView>(productsFromApi, page, pageSize);
            return View("Index", pagedList);
        }

        [HttpGet]
        public async Task<IActionResult> GetByPriceMax(int page = 1, int pageSize = 6)
        {
            var productsFromApi = await _httpClient.GetFromJsonAsync<List<ProductView>>("https://localhost:7033/api/Product/GetByPriceMax");
            var pagedList = new PagedList<ProductView>(productsFromApi, page, pageSize);
            return View("Index", pagedList);
        }

        [HttpGet]
        public async Task<IActionResult> GetByPrice2(int page = 1, int pageSize = 6)
        {
            var productsFromApi = await _httpClient.GetFromJsonAsync<List<ProductView>>("https://localhost:7033/api/Product/GetByPrice2");
            var pagedList = new PagedList<ProductView>(productsFromApi, page, pageSize);
            return View("Index", pagedList);
        }
    }
}