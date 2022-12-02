using Buscampregos.Content;
using Buscampregos.Models;

namespace Buscampregos.Repositorio
{
    public class VagaRepositorio : IVagaRepositorio
    {
        private readonly BancoContext _bancoContext;

        public VagaRepositorio(BancoContext bancoContext)
        {
            _bancoContext = bancoContext;
        }

        public List<VagaModel> TodosRegistros()
        {
            return _bancoContext.Vagas.ToList();
        }

        public VagaModel Adicionar(VagaModel vaga)
        {
            _bancoContext.Vagas.Add(vaga);
            _bancoContext.SaveChanges();
            return vaga;
        }
    }
}
