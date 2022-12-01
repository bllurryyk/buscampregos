using Microsoft.AspNetCore.Mvc;

namespace Buscampregos.Controllers
{
    public class Bookmark : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
