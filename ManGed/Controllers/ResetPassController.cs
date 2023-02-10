using Microsoft.AspNetCore.Mvc;

namespace ManGed.Controllers
{
    public class HomeController1 : Controller
    {
        public IActionResult ResetPass()
        {
            return View();
        }
    }
}
