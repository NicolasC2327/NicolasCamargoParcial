using Microsoft.AspNetCore.Mvc;

namespace Aseguradora.Controllers
{
    public class segurosController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
