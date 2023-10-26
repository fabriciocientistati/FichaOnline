using FichaOnline.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace FichaOnline.Mappings
{
    public class PerfilAcessoMap : IEntityTypeConfiguration<TBPerfilaAcesso>
    {
        public void Configure(EntityTypeBuilder<TBPerfilaAcesso> builder)
        {
            builder.ToTable("TBPERFILACESSO");
        }
    }
}
