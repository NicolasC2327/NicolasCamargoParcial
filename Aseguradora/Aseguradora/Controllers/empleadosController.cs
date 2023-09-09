using Microsoft.AspNetCore.Mvc;

namespace Aseguradora.Controllers
{
    public class empleadosController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
