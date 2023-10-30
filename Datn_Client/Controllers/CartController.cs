using Datn_Shared.Models;
using Datn_Shared.ViewModels.CartDetailViewModels;
using Datn_Shared.ViewModels.CartViewModels;
using Datn_Shared.ViewModels.ProductDetailViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Shopping_Website.Services;
using System.Net.Http.Json;
using System.Security.Claims;

namespace Datn_Client.Controllers
{
    public class CartController : Controller
    {
        private readonly HttpClient _httpClient;
        public CartController(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public async Task<IActionResult> Index()
        {
            var userName = User.FindFirstValue(ClaimTypes.NameIdentifier);
            var role = User.FindFirstValue(ClaimTypes.Role);
            if (userName != null && role == null)
            {
                var customer = await _httpClient.GetFromJsonAsync<Customer>($"https://localhost:7033/api/Customer/GetByName/{userName}");
                var result = await _httpClient.GetFromJsonAsync<List<CartDetailView>>($"https://localhost:7033/api/CartDetail/GetByCustomerId/{customer.Id}");
                return View(result);
            }
            else
            {
                var result = SessionServices<CartDetailView>.GetObjFromSession(HttpContext.Session, "CartDetail");
                return View(result);
            }
        }

        [HttpPost]
        public async Task<IActionResult> Create([FromForm] CreateCartDetailFE cartDetailFE)
        {
            var userName = User.FindFirstValue(ClaimTypes.NameIdentifier);
            var role = User.FindFirstValue(ClaimTypes.Role);
            if (userName != null && role == null)
            {
                var customer = await _httpClient.GetFromJsonAsync<Customer>($"https://localhost:7033/api/Customer/GetByName/{userName}");
                CreateCartDetail cartDetail = new CreateCartDetail()
                {
                    CustomerId = customer.Id,
                    ProductDetailId = cartDetailFE.Id,
                    Quantity = cartDetailFE.Quantity,
                };
                await _httpClient.PostAsJsonAsync($"https://localhost:7033/api/CartDetail/Create", cartDetail);
            }
            else
            {
                var cartDetails = SessionServices<CartDetailView>.GetObjFromSession(HttpContext.Session, "CartDetail");
                var product = await _httpClient.GetFromJsonAsync<ProductDetail>($"https://localhost:7033/api/ProductDetail/GetById/{cartDetailFE.Id}");

                if (SessionServices<CartDetailView>.CheckExistCartDetail(cartDetailFE.Id, cartDetails))
                {
                    var a = cartDetails.FirstOrDefault(p => p.ProductDetailId == cartDetailFE.Id);
                    if (a != null)
                    {
                        CartDetailView cartDetail = new CartDetailView()
                        {
                            Id = a.Id,
                            ProductDetailId = a.ProductDetailId,
                            Name = a.Name,
                            Quantity = a.Quantity,
                            Price = a.Price,
                            ProductPrice = a.ProductPrice,
                            TotalMoney = a.TotalMoney,
                            ProductDetail = a.ProductDetail,
                        };
                        var b = cartDetails.Find(p => p.Id == cartDetail.Id);
                        var c = cartDetails.FirstOrDefault();
                        cartDetails.Remove(b);
                        cartDetail.Quantity++;
                        cartDetail.Price += product.Price * cartDetailFE.Quantity;
                        if (cartDetails.Count > 0)
                        {
                            c.TotalMoney += product.Price * cartDetailFE.Quantity;
                            cartDetails.FirstOrDefault().TotalMoney = c.TotalMoney;
                        }
                        else
                        {
                            cartDetail.TotalMoney += product.Price * cartDetailFE.Quantity;
                        }
                        cartDetails.Add(cartDetail);
                        SessionServices<CartDetailView>.SetObjToSession(HttpContext.Session, "CartDetail", cartDetails);
                    }
                    else
                    {
                        return RedirectToAction("Error", "Shared");
                    }
                }
                else//Nếu sản phẩm chưa tồn tại trong giỏ hàng thì thêm như bình thường
                {
                    CartDetailView cartDetail = new CartDetailView()
                    {
                        Id = Guid.NewGuid(),
                        ProductDetailId = cartDetailFE.Id,
                        Name = product.Product.Name,
                        Quantity = cartDetailFE.Quantity,
                        Price = product.Price * cartDetailFE.Quantity,
                        ProductPrice = product.Price,
                        ProductDetail = product,
                    };
                    if (cartDetails.Count > 0)
                    {
                        var c = cartDetails.FirstOrDefault();
                        c.TotalMoney += product.Price * cartDetailFE.Quantity;
                        cartDetails.FirstOrDefault().TotalMoney = c.TotalMoney;
                    }
                    else
                    {
                        cartDetail.TotalMoney = product.Price * cartDetailFE.Quantity;
                    }
                    cartDetails.Add(cartDetail);
                    SessionServices<CartDetailView>.SetObjToSession(HttpContext.Session, "CartDetail", cartDetails);
                }
            }
            await _httpClient.PutAsJsonAsync<ProductDetail>($"https://localhost:7033/api/ProductDetail/ResetQuantity/{cartDetailFE.Id}", null);
            return RedirectToAction("Index");
        }

        [Route("[action]/{id:Guid}")]
        public async Task<IActionResult> CreateOne(Guid id)
        {
            var userName = User.FindFirstValue(ClaimTypes.NameIdentifier);
            var role = User.FindFirstValue(ClaimTypes.Role);
            if (userName != null && role == null)
            {
                var customer = await _httpClient.GetFromJsonAsync<Customer>($"https://localhost:7033/api/Customer/GetByName/{userName}");
                var product = await _httpClient.GetFromJsonAsync<ProductDetail>($"https://localhost:7033/api/ProductDetail/GetById/{id}");
                CreateCartDetail cartDetail = new CreateCartDetail()
                {
                    CustomerId = customer.Id,
                    ProductDetailId = product.Id,
                    Quantity = 1,
                };
                await _httpClient.PostAsJsonAsync($"https://localhost:7033/api/CartDetail/Create", cartDetail);
            }
            else
            {
                var cartDetails = SessionServices<CartDetailView>.GetObjFromSession(HttpContext.Session, "CartDetail");
                var product = await _httpClient.GetFromJsonAsync<ProductDetail>($"https://localhost:7033/api/ProductDetail/GetById/{id}");

                if (SessionServices<CartDetailView>.CheckExistCartDetail(id, cartDetails))
                {
                    var a = cartDetails.FirstOrDefault(p => p.ProductDetailId == id);
                    if (a != null)
                    {
                        CartDetailView cartDetail = new CartDetailView()
                        {
                            Id = a.Id,
                            ProductDetailId = a.ProductDetailId,
                            Name = a.Name,
                            Quantity = a.Quantity,
                            Price = a.Price,
                            ProductPrice = a.ProductPrice,
                            TotalMoney = a.TotalMoney,
                            ProductDetail = a.ProductDetail,
                        };
                        var b = cartDetails.Find(p => p.Id == cartDetail.Id);
                        var c = cartDetails.FirstOrDefault();
                        cartDetails.Remove(b);
                        cartDetail.Quantity++;
                        cartDetail.Price += product.Price;
                        if (cartDetails.Count > 0)
                        {
                            c.TotalMoney += product.Price;
                            cartDetails.FirstOrDefault().TotalMoney = c.TotalMoney;
                        }
                        else
                        {
                            cartDetail.TotalMoney += product.Price;
                        }
                        cartDetails.Add(cartDetail);
                        SessionServices<CartDetailView>.SetObjToSession(HttpContext.Session, "CartDetail", cartDetails);
                    }
                    else
                    {
                        return RedirectToAction("Error", "Shared");
                    }
                }
                else//Nếu sản phẩm chưa tồn tại trong giỏ hàng thì thêm như bình thường
                {
                    CartDetailView cartDetail = new CartDetailView()
                    {
                        Id = Guid.NewGuid(),
                        ProductDetailId = id,
                        Name = product.Product.Name,
                        Quantity = 1,
                        Price = product.Price,
                        ProductPrice = product.Price,
                        ProductDetail = product
                    };
                    if (cartDetails.Count > 0)
                    {
                        var c = cartDetails.FirstOrDefault();
                        c.TotalMoney += product.Price;
                        cartDetails.FirstOrDefault().TotalMoney = c.TotalMoney;
                    }
                    else
                    {
                        cartDetail.TotalMoney = product.Price;
                    }
                    cartDetails.Add(cartDetail);
                    SessionServices<CartDetailView>.SetObjToSession(HttpContext.Session, "CartDetail", cartDetails);
                }
            }
            await _httpClient.PutAsJsonAsync<ProductDetail>($"https://localhost:7033/api/ProductDetail/ResetQuantity/{id}", null);
            return RedirectToAction("Index");
        }

        [Route("[action]/{id:Guid}")]
        public async Task<IActionResult> Delete(Guid id)
        {
            var userName = User.FindFirstValue(ClaimTypes.NameIdentifier);
            var role = User.FindFirstValue(ClaimTypes.Role);
            if (userName != null && role == null)
            {
                await _httpClient.DeleteAsync($"https://localhost:7033/api/CartDetail/Delete/{id}");
            }
            else
            {
                var cartDetails = SessionServices<CartDetailView>.GetObjFromSession(HttpContext.Session, "CartDetail");
                var c = cartDetails.FirstOrDefault();
                var cartDetail = cartDetails.FirstOrDefault(p => p.Id == id);
                cartDetails.Remove(cartDetail);
                if (cartDetails.Count > 0)
                {
                    c.TotalMoney -= cartDetail.Price;
                    cartDetails.FirstOrDefault().TotalMoney = c.TotalMoney;
                }
                SessionServices<CartDetailView>.SetObjToSession(HttpContext.Session, "CartDetail", cartDetails);
            }
            return RedirectToAction("Index");
        }

        [Route("[action]")]
        public async Task<IActionResult> DeleteAll()
        {
            var userName = User.FindFirstValue(ClaimTypes.NameIdentifier);
            var role = User.FindFirstValue(ClaimTypes.Role);
            if (userName != null && role == null)
            {
                var customer = await _httpClient.GetFromJsonAsync<Customer>($"https://localhost:7033/api/Customer/GetByName/{userName}");
                await _httpClient.DeleteAsync($"https://localhost:7033/api/CartDetail/DeleteAll/{customer.Id}");
            }
            else
            {
                var cartDetails = SessionServices<CartDetailView>.GetObjFromSession(HttpContext.Session, "CartDetail");
                cartDetails.Clear();
                SessionServices<CartDetailView>.SetObjToSession(HttpContext.Session, "CartDetail", cartDetails);
            }
            return RedirectToAction("Index");
        }

        public async Task<IActionResult> Increase(Guid id)
        {
            var userName = User.FindFirstValue(ClaimTypes.NameIdentifier);
            var role = User.FindFirstValue(ClaimTypes.Role);
            if (userName != null && role == null)
            {
                await _httpClient.PutAsJsonAsync<CartDetail>($"https://localhost:7033/api/CartDetail/Increase/{id}", null);
            }
            else
            {
                var cartDetails = SessionServices<CartDetailView>.GetObjFromSession(HttpContext.Session, "CartDetail");
                var cartDetail = cartDetails.FirstOrDefault(p => p.Id == id);
                var c = cartDetail;
                var d = cartDetails.FirstOrDefault();
                cartDetails.Remove(cartDetail);
                c.Quantity++;
                c.Price += cartDetail.ProductPrice;
                if (cartDetails.Count > 0)
                {
                    d.TotalMoney += cartDetail.ProductPrice;
                    cartDetails.FirstOrDefault().TotalMoney = d.TotalMoney;
                }
                else
                {
                    c.TotalMoney += cartDetail.ProductPrice;
                }
                cartDetails.Add(c);
                SessionServices<CartDetailView>.SetObjToSession(HttpContext.Session, "CartDetail", cartDetails);
            }
            return RedirectToAction("Index");
        }

        public async Task<IActionResult> Reduce(Guid id)
        {
            var userName = User.FindFirstValue(ClaimTypes.NameIdentifier);
            var role = User.FindFirstValue(ClaimTypes.Role);
            if (userName != null && role == null)
            {
                await _httpClient.PutAsJsonAsync<CartDetail>($"https://localhost:7033/api/CartDetail/Reduce/{id}", null);
            }
            else
            {
                var cartDetails = SessionServices<CartDetailView>.GetObjFromSession(HttpContext.Session, "CartDetail");
                var cartDetail = cartDetails.FirstOrDefault(p => p.Id == id);
                var d = cartDetails.FirstOrDefault();
                cartDetails.Remove(cartDetail);
                if (cartDetail.Quantity > 1)
                {
                    cartDetail.Quantity--;
                    cartDetail.Price -= cartDetail.ProductPrice;
                    if (cartDetails.Count > 0)
                    {
                        d.TotalMoney -= cartDetail.ProductPrice;
                        cartDetails.FirstOrDefault().TotalMoney = d.TotalMoney;
                    }
                    else
                    {
                        cartDetail.TotalMoney -= cartDetail.ProductPrice;
                    }
                    cartDetails.Add(cartDetail);
                }
                else
                {
                    d.TotalMoney -= cartDetail.ProductPrice;
                    cartDetails.FirstOrDefault().TotalMoney = d.TotalMoney;
                }
                SessionServices<CartDetailView>.SetObjToSession(HttpContext.Session, "CartDetail", cartDetails);
            }
            return RedirectToAction("Index");
        }
    }
}