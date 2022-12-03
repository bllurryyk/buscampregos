using Buscampregos.Models;

namespace Buscampregos.Repositorio
{
    public interface IUsuarioRepositorio
    {
        List<UsuarioModel> TodosRegistros();
        UsuarioModel Adicionar(UsuarioModel usuario);
    }
}
