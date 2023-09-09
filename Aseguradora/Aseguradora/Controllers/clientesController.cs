using Microsoft.AspNetCore.Mvc;

namespace Aseguradora.Controllers
{
    public class clientesController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
