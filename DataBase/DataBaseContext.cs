using FichaOnline.Mappings;
using FichaOnline.Models;
using Microsoft.EntityFrameworkCore;

namespace FichaOnline.Data
{
    public class DataBaseContext : DbContext
    {
        public DataBaseContext(DbContextOptions options): base(options) { }

        public DbSet<Tbusuario> TBUSUARIO { get; set; }
        public DbSet<Tbperfilacesso> TBPERFILACESSO { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            modelBuilder.Entity<Tbperfilacesso>()
                .HasKey(p => p.PerfilAcessoId);

            modelBuilder.Entity<Tbusuario>()
                .HasKey(u => u.UsuarioId);

            // Configurando o relacionamento "um para muitos"
            modelBuilder.Entity<Tbperfilacesso>()
                .HasMany(p => p.Usuarios)
                .WithOne(u => u.PerfilAcesso)
                .HasForeignKey(u => u.PerfilAcessoId)
                .OnDelete(DeleteBehavior.Restrict);
        }
    }
}
