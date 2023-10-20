using FichaOnline.Mappings;
using FichaOnline.Models;
using Microsoft.EntityFrameworkCore;

namespace FichaOnline.Data
{
    public class DataBaseContext : DbContext
    {
        public DataBaseContext(DbContextOptions options): base(options) { }

        public DbSet<Tbusuarios> TBUSUARIOS { get; set; }
        public DbSet<Tbperfilacesso> TBPERFILACESSO { get; set; }
        public DbSet<TBUnidades> TBUNIDADES { get; set; }
        public DbSet<TBUnidadeTipos> TBUNIDADETIPOS { get; set; }
        public DbSet<TBPolo> TBPOLO { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Tbperfilacesso>()
                .HasKey(x => x.PerfilAcessoId);

            modelBuilder.Entity<TBUnidades>()
                .HasKey(x => x.UnidadeId);

            modelBuilder.Entity<Tbusuarios>()
                .HasKey(x => x.UsuarioId);

            modelBuilder.Entity<TBPolo>()
                .HasKey(x => x.PoloId);

            modelBuilder.Entity<TBUnidadeTipos>()
                .HasKey(x => x.UnidadeTpoId);

            modelBuilder.Entity<Tbperfilacesso>()
                .HasMany(p => p.Usuarios)
                .WithOne(u => u.PerfilAcesso)
                .HasForeignKey(u => u.PerfilAcessoId)
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<TBUnidades>()
                .HasMany(un => un.Usuarios)
                .WithOne(u => u.Unidades)
                .HasForeignKey(u => u.UnidadeId);

            modelBuilder.Entity<TBPolo>()
                .HasMany(p => p.Unidades)
                .WithOne(un => un.PolosAssociados)
                .HasForeignKey(un => un.PoloId);

            modelBuilder.Entity<TBUnidadeTipos>()
                .HasMany(ut => ut.Unidade)
                .WithOne(un => un.TiposUnidade)
                .HasForeignKey(un => un.UnidadesTpoId);
        }
    }
}
