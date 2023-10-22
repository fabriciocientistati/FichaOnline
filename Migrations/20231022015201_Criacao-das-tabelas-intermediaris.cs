using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FichaOnline.Migrations
{
    /// <inheritdoc />
    public partial class Criacaodastabelasintermediaris : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "TBPOLOUNIDADES",
                columns: table => new
                {
                    UnidadeId = table.Column<int>(type: "int", nullable: false),
                    PoloId = table.Column<int>(type: "int", nullable: false),
                    PoloUnidId = table.Column<int>(type: "int", nullable: false),
                    PoloUnidTipo = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PoloUnidIncPor = table.Column<int>(type: "int", nullable: false),
                    PoloUnidIncEm = table.Column<DateTime>(type: "datetime2", nullable: false),
                    PoloUnidAltPor = table.Column<int>(type: "int", nullable: true),
                    PoloUnidAltEm = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TBPOLOUNIDADES", x => new { x.PoloId, x.UnidadeId });
                    table.ForeignKey(
                        name: "FK_TBPOLOUNIDADES_TBPOLO_PoloId",
                        column: x => x.PoloId,
                        principalTable: "TBPOLO",
                        principalColumn: "PoloId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_TBPOLOUNIDADES_TBUNIDADES_UnidadeId",
                        column: x => x.UnidadeId,
                        principalTable: "TBUNIDADES",
                        principalColumn: "UnidadeId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_TBPOLOUNIDADES_UnidadeId",
                table: "TBPOLOUNIDADES",
                column: "UnidadeId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "TBPOLOUNIDADES");
        }
    }
}
