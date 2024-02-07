using Microsoft.AspNetCore.Mvc;

namespace Estadisticas.Controllers
{
    public class Liga : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
