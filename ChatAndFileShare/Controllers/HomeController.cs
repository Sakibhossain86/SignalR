using Microsoft.AspNetCore.Mvc;

namespace ChatAndFileShare.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
