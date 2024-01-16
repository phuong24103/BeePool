using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System.Security.Claims;
using System.Text;
using Datn_Shared.ViewModels.AccountViewModels;
using Datn_Shared.Models;
using System.IdentityModel.Tokens.Jwt;
using Datn_Shared.ViewModels.CartDetailViewModels;
using Shopping_Website.Services;

namespace Datn_Client.Controllers
{
    public class LoginController : Controller
    {
        private readonly HttpClient _httpClient;

        public LoginController(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public async Task<IActionResult> Login(Login loginCustomer)
        {
            // Send request POST to register API
            var response = await _httpClient.PostAsJsonAsync($"https://localhost:7033/api/LoginCustomer", loginCustomer);

            if (response.IsSuccessStatusCode)
            {
                var token = await response.Content.ReadAsStringAsync();

                var handler = new JwtSecurityTokenHandler();
                var jwt = handler.ReadJwtToken(token);

                var identity = new ClaimsIdentity(CookieAuthenticationDefaults.AuthenticationScheme);
                identity.AddClaim(new Claim(ClaimTypes.NameIdentifier, jwt.Claims.FirstOrDefault(u => u.Type == ClaimTypes.NameIdentifier).Value));

                var principal = new ClaimsPrincipal(identity);

                await HttpContext.SignInAsync(principal);

                var check = User.Identity.IsAuthenticated;

                var cartDetails = SessionServices<CartDetailView>.GetObjFromSession(HttpContext.Session, "CartDetail");
                if(cartDetails != null)
                {
                    var customer = await _httpClient.GetFromJsonAsync<Customer>($"https://localhost:7033/api/Customer/GetByName/{jwt.Claims.FirstOrDefault(u => u.Type == ClaimTypes.NameIdentifier).Value}");
                    await _httpClient.PostAsJsonAsync($"https://localhost:7033/api/CartDetail/CreateBySession/{customer.Id}", cartDetails);
                    cartDetails.Clear();
                    SessionServices<CartDetailView>.SetObjToSession(HttpContext.Session, "CartDetail", cartDetails);
                }

                return RedirectToAction("Index", "Home");
            }
            else
            {
                var messageLogin = await response.Content.ReadAsStringAsync();
                return RedirectToAction("Register", "Register", new { messageLogin });
            }
        }
        public async Task<IActionResult> Logout()
        {
            await HttpContext.SignOutAsync();
            return RedirectToAction("Index", "Home");
        }
    }
}