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

        public VagaModel Adicionar(VagaModel vaga)
        {
            _bancoContext.Vagas.Add(vaga);
            _bancoContext.SaveChanges();
            return vaga;
        }
    }
}
