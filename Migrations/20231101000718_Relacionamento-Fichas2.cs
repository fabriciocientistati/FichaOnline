using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FichaOnline.Migrations
{
    /// <inheritdoc />
    public partial class RelacionamentoFichas2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_TBFichaProvidenciasResp_TBFICHA_FichaId",
                table: "TBFichaProvidenciasResp");

            migrationBuilder.DropPrimaryKey(
                name: "PK_TBFichaProvidenciasResp",
                table: "TBFichaProvidenciasResp");

            migrationBuilder.RenameTable(
                name: "TBFichaProvidenciasResp",
                newName: "TBFICHAPROVIDENCIASRESP");

            migrationBuilder.RenameIndex(
                name: "IX_TBFichaProvidenciasResp_FichaId",
                table: "TBFICHAPROVIDENCIASRESP",
                newName: "IX_TBFICHAPROVIDENCIASRESP_FichaId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_TBFICHAPROVIDENCIASRESP",
                table: "TBFICHAPROVIDENCIASRESP",
                column: "FichaProvRespId");

            migrationBuilder.AddForeignKey(
                name: "FK_TBFICHAPROVIDENCIASRESP_TBFICHA_FichaId",
                table: "TBFICHAPROVIDENCIASRESP",
                column: "FichaId",
                principalTable: "TBFICHA",
                principalColumn: "FichaId",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_TBFICHAPROVIDENCIASRESP_TBFICHA_FichaId",
                table: "TBFICHAPROVIDENCIASRESP");

            migrationBuilder.DropPrimaryKey(
                name: "PK_TBFICHAPROVIDENCIASRESP",
                table: "TBFICHAPROVIDENCIASRESP");

            migrationBuilder.RenameTable(
                name: "TBFICHAPROVIDENCIASRESP",
                newName: "TBFichaProvidenciasResp");

            migrationBuilder.RenameIndex(
                name: "IX_TBFICHAPROVIDENCIASRESP_FichaId",
                table: "TBFichaProvidenciasResp",
                newName: "IX_TBFichaProvidenciasResp_FichaId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_TBFichaProvidenciasResp",
                table: "TBFichaProvidenciasResp",
                column: "FichaProvRespId");

            migrationBuilder.AddForeignKey(
                name: "FK_TBFichaProvidenciasResp_TBFICHA_FichaId",
                table: "TBFichaProvidenciasResp",
                column: "FichaId",
                principalTable: "TBFICHA",
                principalColumn: "FichaId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
