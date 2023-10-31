using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FichaOnline.Migrations
{
    /// <inheritdoc />
    public partial class CorrecaomigrationTBEstadoTBCidadeTBBairro : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_TBAIRRO_TBCidades_CidadeId",
                table: "TBAIRRO");

            migrationBuilder.DropForeignKey(
                name: "FK_TBCidades_TBEstados_EstId",
                table: "TBCidades");

            migrationBuilder.DropPrimaryKey(
                name: "PK_TBEstados",
                table: "TBEstados");

            migrationBuilder.DropPrimaryKey(
                name: "PK_TBCidades",
                table: "TBCidades");

            migrationBuilder.RenameTable(
                name: "TBEstados",
                newName: "TBESTADO");

            migrationBuilder.RenameTable(
                name: "TBCidades",
                newName: "TBCIDADE");

            migrationBuilder.RenameIndex(
                name: "IX_TBCidades_EstId",
                table: "TBCIDADE",
                newName: "IX_TBCIDADE_EstId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_TBESTADO",
                table: "TBESTADO",
                column: "EstId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_TBCIDADE",
                table: "TBCIDADE",
                column: "CidId");

            migrationBuilder.AddForeignKey(
                name: "FK_TBAIRRO_TBCIDADE_CidadeId",
                table: "TBAIRRO",
                column: "CidadeId",
                principalTable: "TBCIDADE",
                principalColumn: "CidId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_TBCIDADE_TBESTADO_EstId",
                table: "TBCIDADE",
                column: "EstId",
                principalTable: "TBESTADO",
                principalColumn: "EstId",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_TBAIRRO_TBCIDADE_CidadeId",
                table: "TBAIRRO");

            migrationBuilder.DropForeignKey(
                name: "FK_TBCIDADE_TBESTADO_EstId",
                table: "TBCIDADE");

            migrationBuilder.DropPrimaryKey(
                name: "PK_TBESTADO",
                table: "TBESTADO");

            migrationBuilder.DropPrimaryKey(
                name: "PK_TBCIDADE",
                table: "TBCIDADE");

            migrationBuilder.RenameTable(
                name: "TBESTADO",
                newName: "TBEstados");

            migrationBuilder.RenameTable(
                name: "TBCIDADE",
                newName: "TBCidades");

            migrationBuilder.RenameIndex(
                name: "IX_TBCIDADE_EstId",
                table: "TBCidades",
                newName: "IX_TBCidades_EstId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_TBEstados",
                table: "TBEstados",
                column: "EstId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_TBCidades",
                table: "TBCidades",
                column: "CidId");

            migrationBuilder.AddForeignKey(
                name: "FK_TBAIRRO_TBCidades_CidadeId",
                table: "TBAIRRO",
                column: "CidadeId",
                principalTable: "TBCidades",
                principalColumn: "CidId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_TBCidades_TBEstados_EstId",
                table: "TBCidades",
                column: "EstId",
                principalTable: "TBEstados",
                principalColumn: "EstId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
