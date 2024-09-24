using Microsoft.EntityFrameworkCore;
using WebAPI_back_end.Data.Map;
using WebAPI_back_end.Models;


namespace WebAPI_back_end.Data
{
    public class SistemaTarefasDBContext : DbContext
    {
        public SistemaTarefasDBContext(DbContextOptions<SistemaTarefasDBContext> options)
            : base(options) 
        {
            
        }

        public DbSet<UsuarioModel> Usuarios { get; set; }
        

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new UsuarioMap());
            
            base.OnModelCreating(modelBuilder);
        }
    }
}
