using FichaOnline.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace FichaOnline.Mappings
{
    public class UsuarioMap : IEntityTypeConfiguration<Tbusuario>
    {
        public void Configure(EntityTypeBuilder<Tbusuario> builder)
        {
            builder.ToTable("TBUSUARIO");
        }
    }
}
