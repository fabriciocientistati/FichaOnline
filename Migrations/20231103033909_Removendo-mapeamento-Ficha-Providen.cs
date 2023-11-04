using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FichaOnline.Migrations
{
    /// <inheritdoc />
    public partial class RemovendomapeamentoFichaProviden : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_TBFICHAPROVIDENCIASRESP_TBFICHA_FichaId",
                table: "TBFICHAPROVIDENCIASRESP");

            migrationBuilder.DropIndex(
                name: "IX_TBFICHAPROVIDENCIASRESP_FichaId",
                table: "TBFICHAPROVIDENCIASRESP");

            migrationBuilder.AddColumn<int>(
                name: "FichaProvFichaFichaId",
                table: "TBFICHAPROVIDENCIASRESP",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_TBFICHAPROVIDENCIASRESP_FichaProvFichaFichaId",
                table: "TBFICHAPROVIDENCIASRESP",
                column: "FichaProvFichaFichaId");

            migrationBuilder.AddForeignKey(
                name: "FK_TBFICHAPROVIDENCIASRESP_TBFICHA_FichaProvFichaFichaId",
                table: "TBFICHAPROVIDENCIASRESP",
                column: "FichaProvFichaFichaId",
                principalTable: "TBFICHA",
                principalColumn: "FichaId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_TBFICHAPROVIDENCIASRESP_TBFICHA_FichaProvFichaFichaId",
                table: "TBFICHAPROVIDENCIASRESP");

            migrationBuilder.DropIndex(
                name: "IX_TBFICHAPROVIDENCIASRESP_FichaProvFichaFichaId",
                table: "TBFICHAPROVIDENCIASRESP");

            migrationBuilder.DropColumn(
                name: "FichaProvFichaFichaId",
                table: "TBFICHAPROVIDENCIASRESP");

            migrationBuilder.CreateIndex(
                name: "IX_TBFICHAPROVIDENCIASRESP_FichaId",
                table: "TBFICHAPROVIDENCIASRESP",
                column: "FichaId");

            migrationBuilder.AddForeignKey(
                name: "FK_TBFICHAPROVIDENCIASRESP_TBFICHA_FichaId",
                table: "TBFICHAPROVIDENCIASRESP",
                column: "FichaId",
                principalTable: "TBFICHA",
                principalColumn: "FichaId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
