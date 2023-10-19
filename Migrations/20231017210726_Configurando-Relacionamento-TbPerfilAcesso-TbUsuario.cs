using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FichaOnline.Migrations
{
    /// <inheritdoc />
    public partial class ConfigurandoRelacionamentoTbPerfilAcessoTbUsuario : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_TBUSUARIO_PerfilAcessoId",
                table: "TBUSUARIO");

            migrationBuilder.CreateIndex(
                name: "IX_TBUSUARIO_PerfilAcessoId",
                table: "TBUSUARIO",
                column: "PerfilAcessoId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_TBUSUARIO_PerfilAcessoId",
                table: "TBUSUARIO");

            migrationBuilder.CreateIndex(
                name: "IX_TBUSUARIO_PerfilAcessoId",
                table: "TBUSUARIO",
                column: "PerfilAcessoId",
                unique: true);
        }
    }
}
