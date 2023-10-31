using Microsoft.AspNetCore.Mvc;

namespace Datn_Client.Controllers
{
    public class CustomerController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}