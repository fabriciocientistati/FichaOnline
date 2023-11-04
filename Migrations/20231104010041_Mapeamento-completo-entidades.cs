using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FichaOnline.Migrations
{
    /// <inheritdoc />
    public partial class Mapeamentocompletoentidades : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_TBALUNO_TBBAIRRO_AlunoBairroBairroId",
                table: "TBALUNO");

            migrationBuilder.DropForeignKey(
                name: "FK_TBCATEGORIAOPCOES_TBCATEGORIA_CategoriaCatId",
                table: "TBCATEGORIAOPCOES");

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
                name: "IX_TBALUNO_AlunoBairroBairroId",
                table: "TBALUNO");

            migrationBuilder.DropColumn(
                name: "CatOpcRespCatOpcCatOpcId",
                table: "TBCATEGORIAOPCRESP");

            migrationBuilder.DropColumn(
                name: "AlunoBairroBairroId",
                table: "TBALUNO");

            migrationBuilder.AlterColumn<int>(
                name: "CatOpcRespFichaFichaId",
                table: "TBCATEGORIAOPCRESP",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "CategoriaCatId",
                table: "TBCATEGORIAOPCOES",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_TBCATEGORIAOPCRESP_CatOpcId",
                table: "TBCATEGORIAOPCRESP",
                column: "CatOpcId");

            migrationBuilder.CreateIndex(
                name: "IX_TBALUNO_BairroId",
                table: "TBALUNO",
                column: "BairroId");

            migrationBuilder.AddForeignKey(
                name: "FK_TBALUNO_TBBAIRRO_BairroId",
                table: "TBALUNO",
                column: "BairroId",
                principalTable: "TBBAIRRO",
                principalColumn: "BairroId");

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

            migrationBuilder.AddForeignKey(
                name: "FK_TBCATEGORIAOPCRESP_TBFICHA_CatOpcRespFichaFichaId",
                table: "TBCATEGORIAOPCRESP",
                column: "CatOpcRespFichaFichaId",
                principalTable: "TBFICHA",
                principalColumn: "FichaId",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_TBALUNO_TBBAIRRO_BairroId",
                table: "TBALUNO");

            migrationBuilder.DropForeignKey(
                name: "FK_TBCATEGORIAOPCOES_TBCATEGORIA_CategoriaCatId",
                table: "TBCATEGORIAOPCOES");

            migrationBuilder.DropForeignKey(
                name: "FK_TBCATEGORIAOPCRESP_TBCATEGORIAOPCOES_CatOpcId",
                table: "TBCATEGORIAOPCRESP");

            migrationBuilder.DropForeignKey(
                name: "FK_TBCATEGORIAOPCRESP_TBFICHA_CatOpcRespFichaFichaId",
                table: "TBCATEGORIAOPCRESP");

            migrationBuilder.DropIndex(
                name: "IX_TBCATEGORIAOPCRESP_CatOpcId",
                table: "TBCATEGORIAOPCRESP");

            migrationBuilder.DropIndex(
                name: "IX_TBALUNO_BairroId",
                table: "TBALUNO");

            migrationBuilder.AlterColumn<int>(
                name: "CatOpcRespFichaFichaId",
                table: "TBCATEGORIAOPCRESP",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddColumn<int>(
                name: "CatOpcRespCatOpcCatOpcId",
                table: "TBCATEGORIAOPCRESP",
                type: "int",
                nullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "CategoriaCatId",
                table: "TBCATEGORIAOPCOES",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddColumn<int>(
                name: "AlunoBairroBairroId",
                table: "TBALUNO",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_TBCATEGORIAOPCRESP_CatOpcRespCatOpcCatOpcId",
                table: "TBCATEGORIAOPCRESP",
                column: "CatOpcRespCatOpcCatOpcId");

            migrationBuilder.CreateIndex(
                name: "IX_TBALUNO_AlunoBairroBairroId",
                table: "TBALUNO",
                column: "AlunoBairroBairroId");

            migrationBuilder.AddForeignKey(
                name: "FK_TBALUNO_TBBAIRRO_AlunoBairroBairroId",
                table: "TBALUNO",
                column: "AlunoBairroBairroId",
                principalTable: "TBBAIRRO",
                principalColumn: "BairroId");

            migrationBuilder.AddForeignKey(
                name: "FK_TBCATEGORIAOPCOES_TBCATEGORIA_CategoriaCatId",
                table: "TBCATEGORIAOPCOES",
                column: "CategoriaCatId",
                principalTable: "TBCATEGORIA",
                principalColumn: "CatId");

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
                principalColumn: "FichaId");
        }
    }
}
