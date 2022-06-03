using Microsoft.AspNetCore.Mvc;

namespace Pingou.Controllers
{
    public class ErrorController : Controller
    {
        public IActionResult Erro401()
        {
            return View();
        }
    }
}