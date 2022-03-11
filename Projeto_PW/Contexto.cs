using Microsoft.EntityFrameworkCore;
using Projeto_PW.Entidades;

namespace Projeto_PW
{
    public class Contexto : DbContext
    {
        public Contexto(DbContextOptions<Contexto> option) : base(option) { }

        public DbSet<Usuario> USUARIOS { get; set; }
    }
}
