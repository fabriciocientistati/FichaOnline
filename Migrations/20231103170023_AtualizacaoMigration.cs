using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FichaOnline.Migrations
{
    /// <inheritdoc />
    public partial class AtualizacaoMigration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_TBCATEGORIAOPCRESP_TBFICHA_CatOpcRespFichaFichaId",
                table: "TBCATEGORIAOPCRESP");

            migrationBuilder.AlterColumn<int>(
                name: "CatOpcRespFichaFichaId",
                table: "TBCATEGORIAOPCRESP",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddForeignKey(
                name: "FK_TBCATEGORIAOPCRESP_TBFICHA_CatOpcRespFichaFichaId",
                table: "TBCATEGORIAOPCRESP",
                column: "CatOpcRespFichaFichaId",
                principalTable: "TBFICHA",
                principalColumn: "FichaId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_TBCATEGORIAOPCRESP_TBFICHA_CatOpcRespFichaFichaId",
                table: "TBCATEGORIAOPCRESP");

            migrationBuilder.AlterColumn<int>(
                name: "CatOpcRespFichaFichaId",
                table: "TBCATEGORIAOPCRESP",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

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
