using Microsoft.AspNetCore.Mvc;

namespace Aseguradora.Controllers
{
    public class ventasController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
