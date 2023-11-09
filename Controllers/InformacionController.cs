using Microsoft.AspNetCore.Mvc;
using Portafolio_EncinasGuerrero.Models;
using Portafolio_EncinasGuerrero.Datos;
using System.Data.SqlTypes;
using System.Data.SqlClient;


namespace Portafolio_EncinasGuerrero.Controllers
{
    public class InformacionController : Controller
    {
        public IActionResult Index()
        {
            InformacionDatos datos = new InformacionDatos();
            List<InformacionModel> lista = datos.Listar();
            return View(lista);
        }
    }
}
