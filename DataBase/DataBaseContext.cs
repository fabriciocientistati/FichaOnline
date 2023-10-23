using FichaOnline.Mappings;
using FichaOnline.Models;
using Microsoft.EntityFrameworkCore;

namespace FichaOnline.Data
{
    public class DataBaseContext : DbContext
    {
        public DataBaseContext(DbContextOptions options): base(options) { }

        public DbSet<TBUsuarios> TBUSUARIOS { get; set; }
        public DbSet<TBPerfilacesso> TBPERFILACESSO { get; set; }
        public DbSet<TBUnidades> TBUNIDADES { get; set; }
        public DbSet<TBUnidadeTipos> TBUNIDADETIPOS { get; set; }
        public DbSet<TBPolo> TBPOLO { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<TBPerfilacesso>()
                .HasKey(x => x.PerfilAcessoId);

            modelBuilder.Entity<TBUnidades>()
                .HasKey(x => x.UnidadeId);

            modelBuilder.Entity<TBUsuarios>()
                .HasKey(x => x.UsuarioId);

            modelBuilder.Entity<TBPolo>()
                .HasKey(x => x.PoloId);

            modelBuilder.Entity<TBUnidadeTipos>()
                .HasKey(x => x.UnidadeTpoId);

            modelBuilder.Entity<TBUnidades>()
                .HasMany(un => un.UnidadeUsuarios)
                .WithOne(u => u.Unidades)
                .HasForeignKey(u => u.UnidadeId);

            modelBuilder.Entity<TBPolo>()
                .HasMany(p => p.UnidadePolos)
                .WithOne(un => un.Polo)
                .HasForeignKey(un => un.PoloId);

            modelBuilder.Entity<TBUnidadeTipos>()
                .HasMany(ut => ut.UnidadeUnidadeTipos)
                .WithOne(un => un.TiposUnidade)
                .HasForeignKey(un => un.UnidadesTpoId);
        }
    }
}
