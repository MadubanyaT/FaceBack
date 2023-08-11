using Microsoft.AspNetCore.Mvc;

namespace FaceBack.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
