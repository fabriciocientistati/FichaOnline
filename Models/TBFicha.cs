//#nullable disable
//using System;
//using System.Collections.Generic;
//using System.ComponentModel.DataAnnotations;

//namespace FichaOnline.Models;

//public partial class TBFicha
//{
//    public TBFicha()
//    {
//        FichaIncEm = DateTime.Now;
//    }
//    public TBFicha(int fichaId, int fichaCatId, int fichaStsId, int fichaAtualUnidadeId, string fichaNova, int aluId, int fichaEscOrigemUnidadeId, DateTime fichaDtaIni, DateTime? fichaDtaFim, int fichaIncPor, DateTime fichaIncEm, int? fichaAltPor, DateTime? fichaAltEm, TBAluno fichaAluno, TBUnidades fichaEscOrigemUnidade, TBFichaProvidenciasResp fichaFichaProv, TBCategoria fichaCategoria) : this()
//    {
//        FichaId = fichaId;
//        FichaCatId = fichaCatId;
//        FichaStsId = fichaStsId;
//        FichaAtualUnidadeId = fichaAtualUnidadeId;
//        FichaNova = fichaNova;
//        AluId = aluId;
//        FichaEscOrigemUnidadeId = fichaEscOrigemUnidadeId;
//        FichaDtaIni = fichaDtaIni;
//        FichaDtaFim = fichaDtaFim;
//        FichaIncPor = fichaIncPor;
//        FichaIncEm = fichaIncEm;
//        FichaAltPor = fichaAltPor;
//        FichaAltEm = fichaAltEm;
//        FichaAluno = fichaAluno;
//        FichaEscOrigemUnidade = fichaEscOrigemUnidade;
//        FichaFichaProv = fichaFichaProv;
//        FichaCategoria = fichaCategoria;
//    }

//    [Key]
//    public int FichaId { get; set; }

//    public int FichaCatId { get; set; }

//    public int FichaStsId { get; set; }

//    public int FichaAtualUnidadeId { get; set; }

//    public string FichaNova { get; set; }

//    public int AluId { get; set; }

//    public int FichaEscOrigemUnidadeId { get; set; }

//    public DateTime FichaDtaIni { get; set; }

//    public DateTime? FichaDtaFim { get; set; }

//    public int FichaIncPor { get; set; }

//    public DateTime FichaIncEm { get; set; } = DateTime.Now;

//    public int? FichaAltPor { get; set; }

//    public DateTime? FichaAltEm { get; set; }

//    public TBAluno FichaAluno { get; set; }

//    public TBUnidades FichaEscOrigemUnidade { get; set; }

//    public TBFichaProvidenciasResp FichaFichaProv { get; set; }

//    public TBCategoria FichaCategoria { get; set; }
//}