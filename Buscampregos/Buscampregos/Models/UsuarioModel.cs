using Buscampregos.Enums;

namespace Buscampregos.Models
{
    public class UsuarioModel
    {
        // Informações básicas de usuário
        public int Id { get; set; }

        public string Nome { get; set; }

        public string Login { get; set; }

        public string Email { get; set; }

        public string Senha { get; set; }

        public PerfilEnum Perfil { get; set; }

        // Informações do Currículo
        public string Idade { get; set; }
        public string Endereco { get; set; }
        public string Telefone { get; set; }
        public string Site { get; set; }
        public string Objetivo { get; set; }
        public string Educacao { get; set; }
        public string Experiencia { get; set; }
        public string Cursos { get; set; }

    }
}
