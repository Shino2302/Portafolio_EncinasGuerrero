using Microsoft.AspNetCore.Mvc;

namespace Portafolio_EncinasGuerrero.Controllers
{
    public class ProyectosController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
