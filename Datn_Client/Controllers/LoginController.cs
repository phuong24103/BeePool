using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System.Security.Claims;
using System.Text;
using Datn_Shared.ViewModels.AccountViewModels;
using Datn_Shared.Models;
using System.IdentityModel.Tokens.Jwt;

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

                return RedirectToAction("Index", "Home");
            }
            else
            {
                ViewBag.Message = await response.Content.ReadAsStringAsync();
                return RedirectToAction("Register", "Register");
            }
        }
        public async Task<IActionResult> Logout()
        {
            await HttpContext.SignOutAsync();
            return RedirectToAction("Index", "Home");
        }
    }
}