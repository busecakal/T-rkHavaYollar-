using Microsoft.AspNetCore.Mvc;

namespace TürkHavaYolları
{
    public class LoginController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
