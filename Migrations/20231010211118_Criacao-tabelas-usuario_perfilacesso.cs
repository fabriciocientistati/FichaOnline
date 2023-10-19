using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FichaOnline.Migrations
{
    /// <inheritdoc />
    public partial class Criacaotabelasusuario : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "TBPERFILACESSO",
                columns: table => new
                {
                    PerfilAcessoId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PerfilAcessoDesc = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PerfilAcessoNivel = table.Column<short>(type: "smallint", nullable: false),
                    PerfilAcessoIncPor = table.Column<int>(type: "int", nullable: false),
                    PerfilAcessoIncEm = table.Column<DateTime>(type: "datetime2", nullable: false),
                    PerfilAcessoAltPor = table.Column<int>(type: "int", nullable: true),
                    PerfilAcessoAltEm = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TBPERFILACESSO", x => x.PerfilAcessoId);
                });

            migrationBuilder.CreateTable(
                name: "TBUSUARIO",
                columns: table => new
                {
                    UsuarioId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UsuarioNome = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UsuarioSenha = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UsuarioSenhaTemp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UsuarioEmail = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UsuarioCpf = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UsuarioStatus = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UsuarioIncPor = table.Column<int>(type: "int", nullable: false),
                    UsuarioIncEm = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UsuarioAltPor = table.Column<int>(type: "int", nullable: true),
                    UsuarioAltEm = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UsuarioEmailTran = table.Column<short>(type: "smallint", nullable: false),
                    PerfilAcessoId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TBUSUARIO", x => x.UsuarioId);
                    table.ForeignKey(
                        name: "FK_TBUSUARIO_TBPERFILACESSO_PerfilAcessoId",
                        column: x => x.PerfilAcessoId,
                        principalTable: "TBPERFILACESSO",
                        principalColumn: "PerfilAcessoId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_TBUSUARIO_PerfilAcessoId",
                table: "TBUSUARIO",
                column: "PerfilAcessoId",
                unique: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "TBUSUARIO");

            migrationBuilder.DropTable(
                name: "TBPERFILACESSO");
        }
    }
}
