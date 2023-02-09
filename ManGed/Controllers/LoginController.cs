using Microsoft.AspNetCore.Mvc;

namespace ManGed.Controllers
{
    public class LoginController : Controller
    {
        //GET: Login
        public IActionResult Index()
        {
            return View();
        }
    }
}
