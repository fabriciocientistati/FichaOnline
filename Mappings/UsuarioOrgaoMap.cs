using FichaOnline.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace FichaOnline.Mappings
{
    public class UsuarioOrgaoMap : IEntityTypeConfiguration<Tbusuarioorgao>
    {
       public void Configure(EntityTypeBuilder<Tbusuarioorgao> builder)
        {
            builder.ToTable("TBUSUARIOORGAO");
        }
    }
}
