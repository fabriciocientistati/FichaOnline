using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FichaOnline.Migrations
{
    /// <inheritdoc />
    public partial class Criação_Relacionamento_Entity_001 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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
                name: "TBESTADO",
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
                    table.PrimaryKey("PK_TBESTADO", x => x.EstId);
                });

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
                name: "TBCIDADE",
                columns: table => new
                {
                    CidId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CidNom = table.Column<string>(type: "nvarchar(max)", nullable: true),
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
                    table.PrimaryKey("PK_TBCIDADE", x => x.CidId);
                    table.ForeignKey(
                        name: "FK_TBCIDADE_TBESTADO_EstId",
                        column: x => x.EstId,
                        principalTable: "TBESTADO",
                        principalColumn: "EstId",
                        onDelete: ReferentialAction.Cascade);
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
                    UnidadeIncPor = table.Column<int>(type: "int", nullable: false),
                    UnidadeIncEm = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UnidadeAltPor = table.Column<int>(type: "int", nullable: true),
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
                name: "TBBAIRRO",
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
                    table.PrimaryKey("PK_TBBAIRRO", x => x.BairroId);
                    table.ForeignKey(
                        name: "FK_TBBAIRRO_TBCIDADE_CidadeId",
                        column: x => x.CidadeId,
                        principalTable: "TBCIDADE",
                        principalColumn: "CidId",
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
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_TBUSUARIOS_TBUNIDADES_UnidadeId",
                        column: x => x.UnidadeId,
                        principalTable: "TBUNIDADES",
                        principalColumn: "UnidadeId",
                        onDelete: ReferentialAction.Cascade);
                });

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
                        name: "FK_TBALUNO_TBBAIRRO_AlunoBairroBairroId",
                        column: x => x.AlunoBairroBairroId,
                        principalTable: "TBBAIRRO",
                        principalColumn: "BairroId");
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
                name: "TBFICHAPROVIDENCIASRESP",
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
                    table.PrimaryKey("PK_TBFICHAPROVIDENCIASRESP", x => x.FichaProvRespId);
                    table.ForeignKey(
                        name: "FK_TBFICHAPROVIDENCIASRESP_TBFICHA_FichaId",
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
                name: "IX_TBBAIRRO_CidadeId",
                table: "TBBAIRRO",
                column: "CidadeId");

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
                name: "IX_TBCIDADE_EstId",
                table: "TBCIDADE",
                column: "EstId");

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
                name: "IX_TBFICHAPROVIDENCIASRESP_FichaId",
                table: "TBFICHAPROVIDENCIASRESP",
                column: "FichaId",
                unique: true);

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
                name: "TBCATEGORIAOPCRESP");

            migrationBuilder.DropTable(
                name: "TBFICHAPROVIDENCIASRESP");

            migrationBuilder.DropTable(
                name: "TBUSUARIOS");

            migrationBuilder.DropTable(
                name: "TBCATEGORIAOPCOES");

            migrationBuilder.DropTable(
                name: "TBFICHA");

            migrationBuilder.DropTable(
                name: "TBPERFILACESSO");

            migrationBuilder.DropTable(
                name: "TBALUNO");

            migrationBuilder.DropTable(
                name: "TBCATEGORIA");

            migrationBuilder.DropTable(
                name: "TBUNIDADES");

            migrationBuilder.DropTable(
                name: "TBBAIRRO");

            migrationBuilder.DropTable(
                name: "TBPOLO");

            migrationBuilder.DropTable(
                name: "TBUNIDADETIPOS");

            migrationBuilder.DropTable(
                name: "TBCIDADE");

            migrationBuilder.DropTable(
                name: "TBESTADO");
        }
    }
}
