using Microsoft.AspNetCore.Mvc;

namespace Buscampregos.Controllers
{
    public class Sobre : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
