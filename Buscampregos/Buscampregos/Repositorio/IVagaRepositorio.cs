using Buscampregos.Models;

namespace Buscampregos.Repositorio
{
    public interface IVagaRepositorio
    {
        List<VagaModel> TodosRegistros();
        VagaModel Adicionar(VagaModel vaga);
    }
}
