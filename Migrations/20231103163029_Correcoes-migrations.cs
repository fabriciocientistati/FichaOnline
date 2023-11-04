using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FichaOnline.Migrations
{
    /// <inheritdoc />
    public partial class Correcoesmigrations : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_TBCATEGORIAOPCOES_TBCATEGORIAOPCRESP_TBFichaCategoriaOpcRespFichaCatOpcRespId",
                table: "TBCATEGORIAOPCOES");

            migrationBuilder.DropIndex(
                name: "IX_TBCATEGORIAOPCOES_TBFichaCategoriaOpcRespFichaCatOpcRespId",
                table: "TBCATEGORIAOPCOES");

            migrationBuilder.DropColumn(
                name: "CatOpcChecked",
                table: "TBCATEGORIAOPCOES");

            migrationBuilder.DropColumn(
                name: "TBFichaCategoriaOpcRespFichaCatOpcRespId",
                table: "TBCATEGORIAOPCOES");

            migrationBuilder.AddColumn<int>(
                name: "CatOpcRespCatOpcCatOpcId",
                table: "TBCATEGORIAOPCRESP",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_TBCATEGORIAOPCRESP_CatOpcRespCatOpcCatOpcId",
                table: "TBCATEGORIAOPCRESP",
                column: "CatOpcRespCatOpcCatOpcId");

            migrationBuilder.AddForeignKey(
                name: "FK_TBCATEGORIAOPCRESP_TBCATEGORIAOPCOES_CatOpcRespCatOpcCatOpcId",
                table: "TBCATEGORIAOPCRESP",
                column: "CatOpcRespCatOpcCatOpcId",
                principalTable: "TBCATEGORIAOPCOES",
                principalColumn: "CatOpcId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_TBCATEGORIAOPCRESP_TBCATEGORIAOPCOES_CatOpcRespCatOpcCatOpcId",
                table: "TBCATEGORIAOPCRESP");

            migrationBuilder.DropIndex(
                name: "IX_TBCATEGORIAOPCRESP_CatOpcRespCatOpcCatOpcId",
                table: "TBCATEGORIAOPCRESP");

            migrationBuilder.DropColumn(
                name: "CatOpcRespCatOpcCatOpcId",
                table: "TBCATEGORIAOPCRESP");

            migrationBuilder.AddColumn<bool>(
                name: "CatOpcChecked",
                table: "TBCATEGORIAOPCOES",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<int>(
                name: "TBFichaCategoriaOpcRespFichaCatOpcRespId",
                table: "TBCATEGORIAOPCOES",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_TBCATEGORIAOPCOES_TBFichaCategoriaOpcRespFichaCatOpcRespId",
                table: "TBCATEGORIAOPCOES",
                column: "TBFichaCategoriaOpcRespFichaCatOpcRespId");

            migrationBuilder.AddForeignKey(
                name: "FK_TBCATEGORIAOPCOES_TBCATEGORIAOPCRESP_TBFichaCategoriaOpcRespFichaCatOpcRespId",
                table: "TBCATEGORIAOPCOES",
                column: "TBFichaCategoriaOpcRespFichaCatOpcRespId",
                principalTable: "TBCATEGORIAOPCRESP",
                principalColumn: "FichaCatOpcRespId");
        }
    }
}
