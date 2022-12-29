using Microsoft.AspNetCore.Mvc;

namespace ChatAndFileShare.Controllers
{
    public class ChatController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
