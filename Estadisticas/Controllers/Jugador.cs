using Microsoft.AspNetCore.Mvc;

namespace Estadisticas.Controllers
{
    public class Jugador : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
