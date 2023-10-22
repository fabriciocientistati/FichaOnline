using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FichaOnline.Migrations
{
    /// <inheritdoc />
    public partial class Correçãoderelacionamentos : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_TBUSUARIOS_TBPERFILACESSO_PerfilAcessoId",
                table: "TBUSUARIOS");

            migrationBuilder.DropTable(
                name: "TBPOLOUNIDADES");

            migrationBuilder.AlterColumn<int>(
                name: "UnidadeIncPor",
                table: "TBUNIDADES",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "UnidadeAltPor",
                table: "TBUNIDADES",
                type: "int",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_TBUSUARIOS_TBPERFILACESSO_PerfilAcessoId",
                table: "TBUSUARIOS",
                column: "PerfilAcessoId",
                principalTable: "TBPERFILACESSO",
                principalColumn: "PerfilAcessoId",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_TBUSUARIOS_TBPERFILACESSO_PerfilAcessoId",
                table: "TBUSUARIOS");

            migrationBuilder.AlterColumn<string>(
                name: "UnidadeIncPor",
                table: "TBUNIDADES",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<string>(
                name: "UnidadeAltPor",
                table: "TBUNIDADES",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.CreateTable(
                name: "TBPOLOUNIDADES",
                columns: table => new
                {
                    PoloId = table.Column<int>(type: "int", nullable: false),
                    UnidadeId = table.Column<int>(type: "int", nullable: false),
                    PoloUnidAltEm = table.Column<DateTime>(type: "datetime2", nullable: true),
                    PoloUnidAltPor = table.Column<int>(type: "int", nullable: true),
                    PoloUnidId = table.Column<int>(type: "int", nullable: false),
                    PoloUnidIncEm = table.Column<DateTime>(type: "datetime2", nullable: false),
                    PoloUnidIncPor = table.Column<int>(type: "int", nullable: false),
                    PoloUnidTipo = table.Column<string>(type: "nvarchar(max)", nullable: true)
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

            migrationBuilder.AddForeignKey(
                name: "FK_TBUSUARIOS_TBPERFILACESSO_PerfilAcessoId",
                table: "TBUSUARIOS",
                column: "PerfilAcessoId",
                principalTable: "TBPERFILACESSO",
                principalColumn: "PerfilAcessoId",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
