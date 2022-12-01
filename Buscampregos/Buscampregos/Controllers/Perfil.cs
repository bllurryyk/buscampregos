using Buscampregos.Models;
using Microsoft.AspNetCore.Mvc;

namespace Buscampregos.Controllers
{
    public class Perfil : Controller
    {
        public IActionResult Index()
        {
            HomeModel perfil = new HomeModel();

            perfil.NomeUser = "Tyler the creator";
            perfil.EmailUser = "aboyisagun@tyler.com";

            return View(perfil);
        }
    }
}
