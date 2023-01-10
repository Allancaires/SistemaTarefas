using Microsoft.EntityFrameworkCore;

namespace SistemaTarefas.Data
{
    public class SistemaTarefasDbContext : DbContext
    {
        public SistemaTarefasDbContext(DbContextOptions<SistemaTarefasDbContext> options)
        : base(options)
        {
        }

        public DbSet<Models.UsuarioModel>Usuarios {get; set;}
        public DbSet<Models.UsuarioModel>Tarefas {get; set;}

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }
    }
}