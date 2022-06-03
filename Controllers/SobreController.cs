using Microsoft.AspNetCore.Mvc;

namespace Pingou.Controllers
{
    public class SobreController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}