using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FichaOnline.Migrations
{
    /// <inheritdoc />
    public partial class CriaçãoMapeamentoCategoriaFicha : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_TBFICHA_TBCATEGORIA_FichaCategoriaCatId",
                table: "TBFICHA");

            migrationBuilder.DropIndex(
                name: "IX_TBFICHA_FichaCategoriaCatId",
                table: "TBFICHA");

            migrationBuilder.DropColumn(
                name: "FichaCategoriaCatId",
                table: "TBFICHA");

            migrationBuilder.CreateIndex(
                name: "IX_TBFICHA_FichaCatId",
                table: "TBFICHA",
                column: "FichaCatId");

            migrationBuilder.AddForeignKey(
                name: "FK_TBFICHA_TBCATEGORIA_FichaCatId",
                table: "TBFICHA",
                column: "FichaCatId",
                principalTable: "TBCATEGORIA",
                principalColumn: "CatId",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_TBFICHA_TBCATEGORIA_FichaCatId",
                table: "TBFICHA");

            migrationBuilder.DropIndex(
                name: "IX_TBFICHA_FichaCatId",
                table: "TBFICHA");

            migrationBuilder.AddColumn<int>(
                name: "FichaCategoriaCatId",
                table: "TBFICHA",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_TBFICHA_FichaCategoriaCatId",
                table: "TBFICHA",
                column: "FichaCategoriaCatId");

            migrationBuilder.AddForeignKey(
                name: "FK_TBFICHA_TBCATEGORIA_FichaCategoriaCatId",
                table: "TBFICHA",
                column: "FichaCategoriaCatId",
                principalTable: "TBCATEGORIA",
                principalColumn: "CatId");
        }
    }
}
