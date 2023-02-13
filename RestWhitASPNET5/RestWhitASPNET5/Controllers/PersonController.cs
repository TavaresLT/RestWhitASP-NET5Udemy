using Microsoft.AspNetCore.Mvc;

namespace RestWhitASPNET5.Controllers
{
    public class PersonController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
