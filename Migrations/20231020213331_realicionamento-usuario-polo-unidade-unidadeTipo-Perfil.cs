using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FichaOnline.Migrations
{
    /// <inheritdoc />
    public partial class realicionamentousuariopolounidadeunidadeTipoPerfil : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "TBUSUARIO");

            migrationBuilder.CreateTable(
                name: "TBPOLO",
                columns: table => new
                {
                    PoloId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PoloNome = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PoloStatus = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PoloIncPor = table.Column<int>(type: "int", nullable: false),
                    PoloIncEm = table.Column<DateTime>(type: "datetime2", nullable: false),
                    PoloAltPor = table.Column<int>(type: "int", nullable: true),
                    PoloAltEm = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TBPOLO", x => x.PoloId);
                });

            migrationBuilder.CreateTable(
                name: "TBUNIDADETIPOS",
                columns: table => new
                {
                    UnidadeTpoId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UnidadeTpoDsc = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UnidadeSgl = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UnidadeTipo = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UnidadeTpoIncPor = table.Column<int>(type: "int", nullable: false),
                    UnidadeTpoIncEm = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UnidadeTpoAltPor = table.Column<int>(type: "int", nullable: true),
                    UnidadeTpoAltEm = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TBUNIDADETIPOS", x => x.UnidadeTpoId);
                });

            migrationBuilder.CreateTable(
                name: "TBUNIDADES",
                columns: table => new
                {
                    UnidadeId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UnidadeCod = table.Column<int>(type: "int", nullable: false),
                    UnidadeDesc = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UnidadeStatus = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UnidadeEmail = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UnidadeDDD = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UnidadeFone = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UnidadeCEP = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UnidadeEndNmr = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UnidadeEndLog = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UnidadeEndComp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UnidadeIncPor = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UnidadeIncEm = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UnidadeAltPor = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UnidadeAltEm = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UnidadesTpoId = table.Column<int>(type: "int", nullable: false),
                    PoloId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TBUNIDADES", x => x.UnidadeId);
                    table.ForeignKey(
                        name: "FK_TBUNIDADES_TBPOLO_PoloId",
                        column: x => x.PoloId,
                        principalTable: "TBPOLO",
                        principalColumn: "PoloId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_TBUNIDADES_TBUNIDADETIPOS_UnidadesTpoId",
                        column: x => x.UnidadesTpoId,
                        principalTable: "TBUNIDADETIPOS",
                        principalColumn: "UnidadeTpoId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "TBUSUARIOS",
                columns: table => new
                {
                    UsuarioId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UsuarioNome = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UsuarioSenha = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UsuarioSenhaTemp = table.Column<int>(type: "int", nullable: false),
                    UsuarioEmail = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UsuarioCpf = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UsuarioStatus = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UsuarioIncPor = table.Column<int>(type: "int", nullable: false),
                    UsuarioIncEm = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UsuarioAltPor = table.Column<int>(type: "int", nullable: true),
                    UsuarioAltEm = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UsuarioEmailTran = table.Column<short>(type: "smallint", nullable: false),
                    PerfilAcessoId = table.Column<int>(type: "int", nullable: false),
                    UnidadeId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TBUSUARIOS", x => x.UsuarioId);
                    table.ForeignKey(
                        name: "FK_TBUSUARIOS_TBPERFILACESSO_PerfilAcessoId",
                        column: x => x.PerfilAcessoId,
                        principalTable: "TBPERFILACESSO",
                        principalColumn: "PerfilAcessoId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_TBUSUARIOS_TBUNIDADES_UnidadeId",
                        column: x => x.UnidadeId,
                        principalTable: "TBUNIDADES",
                        principalColumn: "UnidadeId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_TBUNIDADES_PoloId",
                table: "TBUNIDADES",
                column: "PoloId");

            migrationBuilder.CreateIndex(
                name: "IX_TBUNIDADES_UnidadesTpoId",
                table: "TBUNIDADES",
                column: "UnidadesTpoId");

            migrationBuilder.CreateIndex(
                name: "IX_TBUSUARIOS_PerfilAcessoId",
                table: "TBUSUARIOS",
                column: "PerfilAcessoId");

            migrationBuilder.CreateIndex(
                name: "IX_TBUSUARIOS_UnidadeId",
                table: "TBUSUARIOS",
                column: "UnidadeId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "TBUSUARIOS");

            migrationBuilder.DropTable(
                name: "TBUNIDADES");

            migrationBuilder.DropTable(
                name: "TBPOLO");

            migrationBuilder.DropTable(
                name: "TBUNIDADETIPOS");

            migrationBuilder.CreateTable(
                name: "TBUSUARIO",
                columns: table => new
                {
                    UsuarioId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PerfilAcessoId = table.Column<int>(type: "int", nullable: false),
                    UsuarioAltEm = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UsuarioAltPor = table.Column<int>(type: "int", nullable: true),
                    UsuarioCpf = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UsuarioEmail = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UsuarioEmailTran = table.Column<short>(type: "smallint", nullable: false),
                    UsuarioIncEm = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UsuarioIncPor = table.Column<int>(type: "int", nullable: false),
                    UsuarioNome = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UsuarioSenha = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UsuarioSenhaTemp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UsuarioStatus = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TBUSUARIO", x => x.UsuarioId);
                    table.ForeignKey(
                        name: "FK_TBUSUARIO_TBPERFILACESSO_PerfilAcessoId",
                        column: x => x.PerfilAcessoId,
                        principalTable: "TBPERFILACESSO",
                        principalColumn: "PerfilAcessoId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_TBUSUARIO_PerfilAcessoId",
                table: "TBUSUARIO",
                column: "PerfilAcessoId");
        }
    }
}
