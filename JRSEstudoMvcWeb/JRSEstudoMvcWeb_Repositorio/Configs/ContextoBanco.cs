using JRSEstudoMvcWeb_Dominio.Usuarios;
using Microsoft.EntityFrameworkCore;

namespace JRSEstudoMvcWeb_Repositorio.Configs
{
    public class ContextoBanco : DbContext
    {
        public ContextoBanco(DbContextOptions<ContextoBanco> options) : base(options)
        {
            Database.EnsureCreated();
        }

        public DbSet<Usuario> Usuario { get; set; }
    }
}
