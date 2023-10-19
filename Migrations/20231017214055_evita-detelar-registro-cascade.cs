using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FichaOnline.Migrations
{
    /// <inheritdoc />
    public partial class evitadetelarregistrocascade : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_TBUSUARIO_TBPERFILACESSO_PerfilAcessoId",
                table: "TBUSUARIO");

            migrationBuilder.AddForeignKey(
                name: "FK_TBUSUARIO_TBPERFILACESSO_PerfilAcessoId",
                table: "TBUSUARIO",
                column: "PerfilAcessoId",
                principalTable: "TBPERFILACESSO",
                principalColumn: "PerfilAcessoId",
                onDelete: ReferentialAction.Restrict);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_TBUSUARIO_TBPERFILACESSO_PerfilAcessoId",
                table: "TBUSUARIO");

            migrationBuilder.AddForeignKey(
                name: "FK_TBUSUARIO_TBPERFILACESSO_PerfilAcessoId",
                table: "TBUSUARIO",
                column: "PerfilAcessoId",
                principalTable: "TBPERFILACESSO",
                principalColumn: "PerfilAcessoId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
