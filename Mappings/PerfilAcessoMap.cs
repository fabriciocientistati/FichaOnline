using FichaOnline.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace FichaOnline.Mappings
{
    public class PerfilAcessoMap : IEntityTypeConfiguration<Tbperfilacesso>
    {
        public void Configure(EntityTypeBuilder<Tbperfilacesso> builder)
        {
            builder.ToTable("TBPERFILACESSO");
        }
    }
}
