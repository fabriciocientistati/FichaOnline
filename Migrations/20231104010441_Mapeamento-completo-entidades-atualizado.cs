using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FichaOnline.Migrations
{
    /// <inheritdoc />
    public partial class Mapeamentocompletoentidadesatualizado : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_TBCATEGORIAOPCOES_TBCATEGORIA_CategoriaCatId",
                table: "TBCATEGORIAOPCOES");

            migrationBuilder.DropForeignKey(
                name: "FK_TBCATEGORIAOPCRESP_TBCATEGORIAOPCOES_CatOpcId",
                table: "TBCATEGORIAOPCRESP");

            migrationBuilder.DropIndex(
                name: "IX_TBCATEGORIAOPCRESP_CatOpcId",
                table: "TBCATEGORIAOPCRESP");

            migrationBuilder.DropIndex(
                name: "IX_TBCATEGORIAOPCOES_CategoriaCatId",
                table: "TBCATEGORIAOPCOES");

            migrationBuilder.DropColumn(
                name: "CategoriaCatId",
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

            migrationBuilder.CreateIndex(
                name: "IX_TBCATEGORIAOPCOES_CatId",
                table: "TBCATEGORIAOPCOES",
                column: "CatId");

            migrationBuilder.AddForeignKey(
                name: "FK_TBCATEGORIAOPCOES_TBCATEGORIA_CatId",
                table: "TBCATEGORIAOPCOES",
                column: "CatId",
                principalTable: "TBCATEGORIA",
                principalColumn: "CatId",
                onDelete: ReferentialAction.Cascade);

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
                name: "FK_TBCATEGORIAOPCOES_TBCATEGORIA_CatId",
                table: "TBCATEGORIAOPCOES");

            migrationBuilder.DropForeignKey(
                name: "FK_TBCATEGORIAOPCRESP_TBCATEGORIAOPCOES_CatOpcRespCatOpcCatOpcId",
                table: "TBCATEGORIAOPCRESP");

            migrationBuilder.DropIndex(
                name: "IX_TBCATEGORIAOPCRESP_CatOpcRespCatOpcCatOpcId",
                table: "TBCATEGORIAOPCRESP");

            migrationBuilder.DropIndex(
                name: "IX_TBCATEGORIAOPCOES_CatId",
                table: "TBCATEGORIAOPCOES");

            migrationBuilder.DropColumn(
                name: "CatOpcRespCatOpcCatOpcId",
                table: "TBCATEGORIAOPCRESP");

            migrationBuilder.AddColumn<int>(
                name: "CategoriaCatId",
                table: "TBCATEGORIAOPCOES",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_TBCATEGORIAOPCRESP_CatOpcId",
                table: "TBCATEGORIAOPCRESP",
                column: "CatOpcId");

            migrationBuilder.CreateIndex(
                name: "IX_TBCATEGORIAOPCOES_CategoriaCatId",
                table: "TBCATEGORIAOPCOES",
                column: "CategoriaCatId");

            migrationBuilder.AddForeignKey(
                name: "FK_TBCATEGORIAOPCOES_TBCATEGORIA_CategoriaCatId",
                table: "TBCATEGORIAOPCOES",
                column: "CategoriaCatId",
                principalTable: "TBCATEGORIA",
                principalColumn: "CatId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_TBCATEGORIAOPCRESP_TBCATEGORIAOPCOES_CatOpcId",
                table: "TBCATEGORIAOPCRESP",
                column: "CatOpcId",
                principalTable: "TBCATEGORIAOPCOES",
                principalColumn: "CatOpcId",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
