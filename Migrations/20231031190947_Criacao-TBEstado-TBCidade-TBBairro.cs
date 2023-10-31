using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FichaOnline.Migrations
{
    /// <inheritdoc />
    public partial class CriacaoTBEstadoTBCidadeTBBairro : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "TBEstados",
                columns: table => new
                {
                    EstId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    EstSgl = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    EstNom = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    EstIncPor = table.Column<int>(type: "int", nullable: false),
                    EstIncEm = table.Column<DateTime>(type: "datetime2", nullable: true),
                    EstAltPor = table.Column<int>(type: "int", nullable: true),
                    EstAltEm = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TBEstados", x => x.EstId);
                });

            migrationBuilder.CreateTable(
                name: "TBCidades",
                columns: table => new
                {
                    CidId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CidNom = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CidEstNom = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CidCodIbge = table.Column<long>(type: "bigint", nullable: true),
                    CidTipo = table.Column<int>(type: "int", nullable: true),
                    CidIdDistrito = table.Column<int>(type: "int", nullable: true),
                    CidNomDistrito = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CidIncPor = table.Column<int>(type: "int", nullable: false),
                    CidIncEm = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CidAltPor = table.Column<int>(type: "int", nullable: true),
                    CidAltEm = table.Column<DateTime>(type: "datetime2", nullable: true),
                    EstId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TBCidades", x => x.CidId);
                    table.ForeignKey(
                        name: "FK_TBCidades_TBEstados_EstId",
                        column: x => x.EstId,
                        principalTable: "TBEstados",
                        principalColumn: "EstId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "TBAIRRO",
                columns: table => new
                {
                    BairroId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    BairroNome = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    BairroIncPor = table.Column<int>(type: "int", nullable: false),
                    BairroAltPor = table.Column<int>(type: "int", nullable: true),
                    CidadeId = table.Column<int>(type: "int", nullable: false),
                    BairroIncEm = table.Column<DateTime>(type: "datetime2", nullable: false),
                    BairroAltEm = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TBAIRRO", x => x.BairroId);
                    table.ForeignKey(
                        name: "FK_TBAIRRO_TBCidades_CidadeId",
                        column: x => x.CidadeId,
                        principalTable: "TBCidades",
                        principalColumn: "CidId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_TBAIRRO_CidadeId",
                table: "TBAIRRO",
                column: "CidadeId");

            migrationBuilder.CreateIndex(
                name: "IX_TBCidades_EstId",
                table: "TBCidades",
                column: "EstId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "TBAIRRO");

            migrationBuilder.DropTable(
                name: "TBCidades");

            migrationBuilder.DropTable(
                name: "TBEstados");
        }
    }
}
