using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace FaceBack.Controllers
{
    public class AccountController : Controller
    {
        [HttpGet]
        public IActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Login(string values)
        {
            return View();
        }

        [HttpGet]
        public IActionResult CreateAccount()
        {
            return View();
        }

        [HttpPost]
        public IActionResult CreateAccount(string values)
        {
            return View();
        }

        [HttpGet]
        public IActionResult CreatePage() 
        {
            return View();
        }

        [HttpPost]
        public IActionResult CreatePage(string values)
        {
            return View();
        }

        [HttpGet]
		public IActionResult ForgotPassword()
		{
			return View();
		}

		[HttpPost]
		public IActionResult ForgotPassword(string values)
		{
			return View();
		}

		[Authorize]
        [HttpPost]
        public IActionResult Logout()
        {

            return View();
        }
    }
}
