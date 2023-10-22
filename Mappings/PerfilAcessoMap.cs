using FichaOnline.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace FichaOnline.Mappings
{
    public class PerfilAcessoMap : IEntityTypeConfiguration<TBPerfilacesso>
    {
        public void Configure(EntityTypeBuilder<TBPerfilacesso> builder)
        {
            builder.ToTable("TBPERFILACESSO");
        }
    }
}
