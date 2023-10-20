using FichaOnline.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace FichaOnline.Mappings
{
    public class UsuarioMap : IEntityTypeConfiguration<Tbusuarios>
    {
        public void Configure(EntityTypeBuilder<Tbusuarios> builder)
        {
            builder.ToTable("TBUsuario");
        }
    }
}
