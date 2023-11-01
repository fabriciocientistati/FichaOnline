using FichaOnline.Mappings;
using FichaOnline.Models;
using Microsoft.EntityFrameworkCore;

namespace FichaOnline.Data
{
    public class ContextoDb : DbContext
    {
        public ContextoDb(DbContextOptions options): base(options) { }

        public DbSet<TBUsuarios> TBUSUARIOS { get; set; }
        public DbSet<TBPerfilaAcesso> TBPERFILACESSO { get; set; }
        public DbSet<TBUnidades> TBUNIDADES { get; set; }
        public DbSet<TBUnidadeTipos> TBUNIDADETIPOS { get; set; }
        public DbSet<TBPolo> TBPOLO { get; set; }
        public DbSet<TBBairro> TBBAIRRO { get; set; }
        public DbSet<TBCidade> TBCIDADE { get; set; }
        public DbSet<TBEstado> TBESTADO { get; set; }
        public DbSet<TBFicha> TBFICHA { get; set; }
        public DbSet<TBAluno> TBALUNO { get; set; }
        public DbSet<TBCategoria> TBCATEGORIA { get; set; }
        public DbSet<TBCategoriaOpcoes> TBCATEGORIAOPCOES { get; set; }
        public DbSet<TBFichaCategoriaOpcResp> TBCATEGORIAOPCRESP { get; set; }
        public DbSet<TBFichaProvidenciasResp> TBFICHAPROVIDENCIASRESP { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<TBFicha>()
                .HasKey(x => x.FichaId);

            modelBuilder.Entity<TBAluno>()
                .HasKey(x => x.AluId);

            modelBuilder.Entity<TBCategoria>()
                .HasKey(x => x.CatId);

            modelBuilder.Entity<TBCategoriaOpcoes>()
                .HasKey(x => x.CatOpcId);

            modelBuilder.Entity<TBFichaCategoriaOpcResp>()
                .HasKey(x => x.FichaCatOpcRespId);

            modelBuilder.Entity<TBFichaProvidenciasResp>()
                .HasKey(x => x.FichaProvRespId);

            modelBuilder.Entity<TBPerfilaAcesso>()
                .HasKey(x => x.PerfilAcessoId);

            modelBuilder.Entity<TBUnidades>()
                .HasKey(x => x.UnidadeId);

            modelBuilder.Entity<TBUsuarios>()
                .HasKey(x => x.UsuarioId);

            modelBuilder.Entity<TBPolo>()
                .HasKey(x => x.PoloId);

            modelBuilder.Entity<TBUnidadeTipos>()
                .HasKey(x => x.UnidadeTpoId);

            modelBuilder.Entity<TBBairro>()
                .HasKey(x => x.BairroId);

            modelBuilder.Entity<TBCidade>()
                .HasKey(x => x.CidId);

            modelBuilder.Entity<TBEstado>()
                .HasKey(x => x.EstId);

            modelBuilder.Entity<TBFicha>()
                .HasOne(f => f.FichaFichaProv)
                .WithOne(fp => fp.FichaProvFicha)
                .HasForeignKey<TBFichaProvidenciasResp>(fp => fp.FichaId);

            modelBuilder.Entity<TBCidade>()
                .HasOne(cid => cid.CidEstado)
                .WithMany(est => est.EstadoCidades)
                .HasForeignKey(cid => cid.EstId);

            modelBuilder.Entity<TBBairro>()
                .HasOne(bai => bai.BairroCidade)
                .WithMany(cid => cid.CidadeBairros)
                .HasForeignKey(bai => bai.CidadeId);

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
