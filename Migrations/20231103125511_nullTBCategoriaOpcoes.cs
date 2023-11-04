using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FichaOnline.Migrations
{
    /// <inheritdoc />
    public partial class nullTBCategoriaOpcoes : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_TBCATEGORIAOPCOES_TBCATEGORIA_CategoriaCatId",
                table: "TBCATEGORIAOPCOES");

            migrationBuilder.AlterColumn<int>(
                name: "CategoriaCatId",
                table: "TBCATEGORIAOPCOES",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddForeignKey(
                name: "FK_TBCATEGORIAOPCOES_TBCATEGORIA_CategoriaCatId",
                table: "TBCATEGORIAOPCOES",
                column: "CategoriaCatId",
                principalTable: "TBCATEGORIA",
                principalColumn: "CatId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_TBCATEGORIAOPCOES_TBCATEGORIA_CategoriaCatId",
                table: "TBCATEGORIAOPCOES");

            migrationBuilder.AlterColumn<int>(
                name: "CategoriaCatId",
                table: "TBCATEGORIAOPCOES",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_TBCATEGORIAOPCOES_TBCATEGORIA_CategoriaCatId",
                table: "TBCATEGORIAOPCOES",
                column: "CategoriaCatId",
                principalTable: "TBCATEGORIA",
                principalColumn: "CatId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
