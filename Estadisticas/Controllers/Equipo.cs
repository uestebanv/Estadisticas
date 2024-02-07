using Microsoft.AspNetCore.Mvc;

namespace Estadisticas.Controllers
{
    public class Equipo : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
