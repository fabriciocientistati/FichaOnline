using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FichaOnline.Migrations
{
    /// <inheritdoc />
    public partial class RelacionamentoFichas : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "TBALUNO",
                columns: table => new
                {
                    AluId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AluNom = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AluNomSoc = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AluDtaNasc = table.Column<DateTime>(type: "datetime2", nullable: false),
                    AluCpf = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AluSexo = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AluFiliacao1 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AluFiliacao2 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AluFiliacao3 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AluIdinep = table.Column<int>(type: "int", nullable: true),
                    AluRaca = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AluEndLog = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AluEndNmrLog = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AluEndCmpLog = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AluEndBairro = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AluEndCep = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AluTelResDdd = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AluTelRes = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AluTelCelDdd = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AluTelCel = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AluTelConDdd = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AluTelCon = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AluObs = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AluStatus = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AluIncPor = table.Column<int>(type: "int", nullable: false),
                    AluIncEm = table.Column<DateTime>(type: "datetime2", nullable: false),
                    AluAltPor = table.Column<int>(type: "int", nullable: true),
                    AluAltEm = table.Column<DateTime>(type: "datetime2", nullable: true),
                    BairroId = table.Column<int>(type: "int", nullable: true),
                    GedAluCod = table.Column<int>(type: "int", nullable: false),
                    AlunoBairroBairroId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TBALUNO", x => x.AluId);
                    table.ForeignKey(
                        name: "FK_TBALUNO_TBAIRRO_AlunoBairroBairroId",
                        column: x => x.AlunoBairroBairroId,
                        principalTable: "TBAIRRO",
                        principalColumn: "BairroId");
                });

            migrationBuilder.CreateTable(
                name: "TBCATEGORIA",
                columns: table => new
                {
                    CatId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CatDesc = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CatSts = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CatIncPor = table.Column<int>(type: "int", nullable: false),
                    CatIncEm = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CatAltPor = table.Column<int>(type: "int", nullable: true),
                    CatAltEm = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TBCATEGORIA", x => x.CatId);
                });

            migrationBuilder.CreateTable(
                name: "TBCATEGORIAOPCOES",
                columns: table => new
                {
                    CatOpcId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CatId = table.Column<int>(type: "int", nullable: false),
                    CatOpcDesc = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CatOpcIncPor = table.Column<int>(type: "int", nullable: false),
                    CatOpcIncEm = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CatOpcAltPor = table.Column<int>(type: "int", nullable: true),
                    CatOpcAltEm = table.Column<DateTime>(type: "datetime2", nullable: true),
                    CategoriaCatId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TBCATEGORIAOPCOES", x => x.CatOpcId);
                    table.ForeignKey(
                        name: "FK_TBCATEGORIAOPCOES_TBCATEGORIA_CategoriaCatId",
                        column: x => x.CategoriaCatId,
                        principalTable: "TBCATEGORIA",
                        principalColumn: "CatId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "TBFICHA",
                columns: table => new
                {
                    FichaId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FichaCatId = table.Column<int>(type: "int", nullable: false),
                    FichaStsId = table.Column<int>(type: "int", nullable: false),
                    FichaAtualUnidadeId = table.Column<int>(type: "int", nullable: false),
                    FichaNova = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AluId = table.Column<int>(type: "int", nullable: false),
                    FichaEscOrigemUnidadeId = table.Column<int>(type: "int", nullable: false),
                    FichaDtaIni = table.Column<DateTime>(type: "datetime2", nullable: false),
                    FichaDtaFim = table.Column<DateTime>(type: "datetime2", nullable: true),
                    FichaIncPor = table.Column<int>(type: "int", nullable: false),
                    FichaIncEm = table.Column<DateTime>(type: "datetime2", nullable: false),
                    FichaAltPor = table.Column<int>(type: "int", nullable: true),
                    FichaAltEm = table.Column<DateTime>(type: "datetime2", nullable: true),
                    FichaAlunoAluId = table.Column<int>(type: "int", nullable: true),
                    FichaCategoriaCatId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TBFICHA", x => x.FichaId);
                    table.ForeignKey(
                        name: "FK_TBFICHA_TBALUNO_FichaAlunoAluId",
                        column: x => x.FichaAlunoAluId,
                        principalTable: "TBALUNO",
                        principalColumn: "AluId");
                    table.ForeignKey(
                        name: "FK_TBFICHA_TBCATEGORIA_FichaCategoriaCatId",
                        column: x => x.FichaCategoriaCatId,
                        principalTable: "TBCATEGORIA",
                        principalColumn: "CatId");
                    table.ForeignKey(
                        name: "FK_TBFICHA_TBUNIDADES_FichaEscOrigemUnidadeId",
                        column: x => x.FichaEscOrigemUnidadeId,
                        principalTable: "TBUNIDADES",
                        principalColumn: "UnidadeId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "TBCATEGORIAOPCRESP",
                columns: table => new
                {
                    FichaCatOpcRespId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CatOpcId = table.Column<int>(type: "int", nullable: false),
                    FichaId = table.Column<int>(type: "int", nullable: false),
                    FichaCatOpcResIncPor = table.Column<int>(type: "int", nullable: false),
                    FichaCatOpcIncEm = table.Column<DateTime>(type: "datetime2", nullable: false),
                    FichaCatOpcRespAltPor = table.Column<int>(type: "int", nullable: true),
                    FichaCatOpcRespAltEm = table.Column<DateTime>(type: "datetime2", nullable: true),
                    CatOpcRespFichaFichaId = table.Column<int>(type: "int", nullable: false),
                    CatOpcRespCatOpcCatOpcId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TBCATEGORIAOPCRESP", x => x.FichaCatOpcRespId);
                    table.ForeignKey(
                        name: "FK_TBCATEGORIAOPCRESP_TBCATEGORIAOPCOES_CatOpcRespCatOpcCatOpcId",
                        column: x => x.CatOpcRespCatOpcCatOpcId,
                        principalTable: "TBCATEGORIAOPCOES",
                        principalColumn: "CatOpcId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_TBCATEGORIAOPCRESP_TBFICHA_CatOpcRespFichaFichaId",
                        column: x => x.CatOpcRespFichaFichaId,
                        principalTable: "TBFICHA",
                        principalColumn: "FichaId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "TBFichaProvidenciasResp",
                columns: table => new
                {
                    FichaProvRespId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FichaId = table.Column<int>(type: "int", nullable: false),
                    FichaProvRespIncPor = table.Column<int>(type: "int", nullable: false),
                    FichaProvRespIncEm = table.Column<DateTime>(type: "datetime2", nullable: false),
                    FichaProvRespAltPor = table.Column<int>(type: "int", nullable: true),
                    FichaprovRespAltEm = table.Column<DateTime>(type: "datetime2", nullable: true),
                    FichaDtaComunicRespons = table.Column<DateTime>(type: "datetime2", nullable: true),
                    FichaMeioComunic = table.Column<int>(type: "int", nullable: true),
                    FichaPorQuemUsuariorId = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    FichaPraQuemUsuariorId = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    FichaProcedimentoUnidade = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    FichaRecebidoEm = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FichaDataTramitacao = table.Column<DateTime>(type: "datetime2", nullable: true),
                    FichaDefineRetorno = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TBFichaProvidenciasResp", x => x.FichaProvRespId);
                    table.ForeignKey(
                        name: "FK_TBFichaProvidenciasResp_TBFICHA_FichaId",
                        column: x => x.FichaId,
                        principalTable: "TBFICHA",
                        principalColumn: "FichaId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_TBALUNO_AlunoBairroBairroId",
                table: "TBALUNO",
                column: "AlunoBairroBairroId");

            migrationBuilder.CreateIndex(
                name: "IX_TBCATEGORIAOPCOES_CategoriaCatId",
                table: "TBCATEGORIAOPCOES",
                column: "CategoriaCatId");

            migrationBuilder.CreateIndex(
                name: "IX_TBCATEGORIAOPCRESP_CatOpcRespCatOpcCatOpcId",
                table: "TBCATEGORIAOPCRESP",
                column: "CatOpcRespCatOpcCatOpcId");

            migrationBuilder.CreateIndex(
                name: "IX_TBCATEGORIAOPCRESP_CatOpcRespFichaFichaId",
                table: "TBCATEGORIAOPCRESP",
                column: "CatOpcRespFichaFichaId");

            migrationBuilder.CreateIndex(
                name: "IX_TBFICHA_FichaAlunoAluId",
                table: "TBFICHA",
                column: "FichaAlunoAluId");

            migrationBuilder.CreateIndex(
                name: "IX_TBFICHA_FichaCategoriaCatId",
                table: "TBFICHA",
                column: "FichaCategoriaCatId");

            migrationBuilder.CreateIndex(
                name: "IX_TBFICHA_FichaEscOrigemUnidadeId",
                table: "TBFICHA",
                column: "FichaEscOrigemUnidadeId");

            migrationBuilder.CreateIndex(
                name: "IX_TBFichaProvidenciasResp_FichaId",
                table: "TBFichaProvidenciasResp",
                column: "FichaId",
                unique: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "TBCATEGORIAOPCRESP");

            migrationBuilder.DropTable(
                name: "TBFichaProvidenciasResp");

            migrationBuilder.DropTable(
                name: "TBCATEGORIAOPCOES");

            migrationBuilder.DropTable(
                name: "TBFICHA");

            migrationBuilder.DropTable(
                name: "TBALUNO");

            migrationBuilder.DropTable(
                name: "TBCATEGORIA");
        }
    }
}
