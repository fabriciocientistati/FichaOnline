using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FichaOnline.Migrations
{
    /// <inheritdoc />
    public partial class Mapeamentocompletoentidadesatualizado01 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_TBCATEGORIAOPCRESP_TBCATEGORIAOPCOES_CatOpcRespCatOpcCatOpcId",
                table: "TBCATEGORIAOPCRESP");

            migrationBuilder.DropForeignKey(
                name: "FK_TBCATEGORIAOPCRESP_TBFICHA_CatOpcRespFichaFichaId",
                table: "TBCATEGORIAOPCRESP");

            migrationBuilder.DropIndex(
                name: "IX_TBCATEGORIAOPCRESP_CatOpcRespCatOpcCatOpcId",
                table: "TBCATEGORIAOPCRESP");

            migrationBuilder.DropIndex(
                name: "IX_TBCATEGORIAOPCRESP_CatOpcRespFichaFichaId",
                table: "TBCATEGORIAOPCRESP");

            migrationBuilder.DropColumn(
                name: "CatOpcRespCatOpcCatOpcId",
                table: "TBCATEGORIAOPCRESP");

            migrationBuilder.DropColumn(
                name: "CatOpcRespFichaFichaId",
                table: "TBCATEGORIAOPCRESP");

            migrationBuilder.CreateIndex(
                name: "IX_TBCATEGORIAOPCRESP_CatOpcId",
                table: "TBCATEGORIAOPCRESP",
                column: "CatOpcId");

            migrationBuilder.CreateIndex(
                name: "IX_TBCATEGORIAOPCRESP_FichaId",
                table: "TBCATEGORIAOPCRESP",
                column: "FichaId");

            migrationBuilder.AddForeignKey(
                name: "FK_TBCATEGORIAOPCRESP_TBCATEGORIAOPCOES_CatOpcId",
                table: "TBCATEGORIAOPCRESP",
                column: "CatOpcId",
                principalTable: "TBCATEGORIAOPCOES",
                principalColumn: "CatOpcId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_TBCATEGORIAOPCRESP_TBFICHA_FichaId",
                table: "TBCATEGORIAOPCRESP",
                column: "FichaId",
                principalTable: "TBFICHA",
                principalColumn: "FichaId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_TBCATEGORIAOPCRESP_TBCATEGORIAOPCOES_CatOpcId",
                table: "TBCATEGORIAOPCRESP");

            migrationBuilder.DropForeignKey(
                name: "FK_TBCATEGORIAOPCRESP_TBFICHA_FichaId",
                table: "TBCATEGORIAOPCRESP");

            migrationBuilder.DropIndex(
                name: "IX_TBCATEGORIAOPCRESP_CatOpcId",
                table: "TBCATEGORIAOPCRESP");

            migrationBuilder.DropIndex(
                name: "IX_TBCATEGORIAOPCRESP_FichaId",
                table: "TBCATEGORIAOPCRESP");

            migrationBuilder.AddColumn<int>(
                name: "CatOpcRespCatOpcCatOpcId",
                table: "TBCATEGORIAOPCRESP",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "CatOpcRespFichaFichaId",
                table: "TBCATEGORIAOPCRESP",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_TBCATEGORIAOPCRESP_CatOpcRespCatOpcCatOpcId",
                table: "TBCATEGORIAOPCRESP",
                column: "CatOpcRespCatOpcCatOpcId");

            migrationBuilder.CreateIndex(
                name: "IX_TBCATEGORIAOPCRESP_CatOpcRespFichaFichaId",
                table: "TBCATEGORIAOPCRESP",
                column: "CatOpcRespFichaFichaId");

            migrationBuilder.AddForeignKey(
                name: "FK_TBCATEGORIAOPCRESP_TBCATEGORIAOPCOES_CatOpcRespCatOpcCatOpcId",
                table: "TBCATEGORIAOPCRESP",
                column: "CatOpcRespCatOpcCatOpcId",
                principalTable: "TBCATEGORIAOPCOES",
                principalColumn: "CatOpcId");

            migrationBuilder.AddForeignKey(
                name: "FK_TBCATEGORIAOPCRESP_TBFICHA_CatOpcRespFichaFichaId",
                table: "TBCATEGORIAOPCRESP",
                column: "CatOpcRespFichaFichaId",
                principalTable: "TBFICHA",
                principalColumn: "FichaId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
