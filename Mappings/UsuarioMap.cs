using FichaOnline.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace FichaOnline.Mappings
{
    public class UsuarioMap : IEntityTypeConfiguration<TBUsuarios>
    {
        public void Configure(EntityTypeBuilder<TBUsuarios> builder)
        {
            builder.ToTable("TBUsuario");
        }
    }
}
