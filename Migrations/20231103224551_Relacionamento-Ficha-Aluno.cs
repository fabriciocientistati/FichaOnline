using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FichaOnline.Migrations
{
    /// <inheritdoc />
    public partial class RelacionamentoFichaAluno : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_TBFICHA_TBALUNO_FichaAlunoAluId",
                table: "TBFICHA");

            migrationBuilder.DropIndex(
                name: "IX_TBFICHA_FichaAlunoAluId",
                table: "TBFICHA");

            migrationBuilder.DropColumn(
                name: "FichaAlunoAluId",
                table: "TBFICHA");

            migrationBuilder.CreateIndex(
                name: "IX_TBFICHA_AluId",
                table: "TBFICHA",
                column: "AluId");

            migrationBuilder.AddForeignKey(
                name: "FK_TBFICHA_TBALUNO_AluId",
                table: "TBFICHA",
                column: "AluId",
                principalTable: "TBALUNO",
                principalColumn: "AluId",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_TBFICHA_TBALUNO_AluId",
                table: "TBFICHA");

            migrationBuilder.DropIndex(
                name: "IX_TBFICHA_AluId",
                table: "TBFICHA");

            migrationBuilder.AddColumn<int>(
                name: "FichaAlunoAluId",
                table: "TBFICHA",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_TBFICHA_FichaAlunoAluId",
                table: "TBFICHA",
                column: "FichaAlunoAluId");

            migrationBuilder.AddForeignKey(
                name: "FK_TBFICHA_TBALUNO_FichaAlunoAluId",
                table: "TBFICHA",
                column: "FichaAlunoAluId",
                principalTable: "TBALUNO",
                principalColumn: "AluId");
        }
    }
}
