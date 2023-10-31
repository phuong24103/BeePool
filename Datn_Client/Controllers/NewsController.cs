using Microsoft.AspNetCore.Mvc;

namespace Datn_Client.Controllers
{
    public class NewsController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
