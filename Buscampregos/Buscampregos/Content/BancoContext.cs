using Buscampregos.Models;
using Microsoft.EntityFrameworkCore;

namespace Buscampregos.Content
{
    public class BancoContext : DbContext
    {
        public BancoContext(DbContextOptions<BancoContext> options) : base(options)
        {
        }

        public DbSet<VagaModel> Vagas { get; set; }
    }
}
