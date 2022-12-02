using Buscampregos.Models;
using Buscampregos.Repositorio;
using Microsoft.AspNetCore.Mvc;

namespace Buscampregos.Controllers
{
    public class VagaController : Controller
    {
        private readonly IVagaRepositorio _vagaRepositorio;

        public VagaController(IVagaRepositorio vagaRepositorio)
        {
            _vagaRepositorio = vagaRepositorio;
        }

        public IActionResult Index()
        {
            List<VagaModel> vagas = _vagaRepositorio.TodosRegistros();

            return View(vagas);
        }

        public IActionResult Criar()
        {
            return View();
        }

        public IActionResult Editar()
        {
            return View();
        }

        public IActionResult Apagar()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Criar(VagaModel vaga)
        {
            _vagaRepositorio.Adicionar(vaga);
            return RedirectToAction("Index");
        }
    }
}
