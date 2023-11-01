using System.ComponentModel.DataAnnotations;

namespace FichaOnline.Models
{
    public class TBFichaProvidenciasResp
    {
        public TBFichaProvidenciasResp()
        {
            FichaProvRespIncEm = DateTime.Now;
        }
        public TBFichaProvidenciasResp(int fichaProvRespId, int fichaId, int fichaProvRespIncPor, DateTime fichaProvRespIncEm, int? fichaProvRespAltPor, DateTime? fichaprovRespAltEm, DateTime? fichaDtaComunicRespons, int? fichaMeioComunic, string fichaPorQuemUsuariorId, string fichaPraQuemUsuariorId, string fichaProcedimentoUnidade, string? fichaRecebidoEm, DateTime? fichaDataTramitacao, string? fichaDefineRetorno, TBFicha fichaProvFicha) : this()
        {
            FichaProvRespId = fichaProvRespId;
            FichaId = fichaId;
            FichaProvRespIncPor = fichaProvRespIncPor;
            FichaProvRespIncEm = fichaProvRespIncEm;
            FichaProvRespAltPor = fichaProvRespAltPor;
            FichaprovRespAltEm = fichaprovRespAltEm;
            FichaDtaComunicRespons = fichaDtaComunicRespons;
            FichaMeioComunic = fichaMeioComunic;
            FichaPorQuemUsuariorId = fichaPorQuemUsuariorId;
            FichaPraQuemUsuariorId = fichaPraQuemUsuariorId;
            FichaProcedimentoUnidade = fichaProcedimentoUnidade;
            FichaRecebidoEm = fichaRecebidoEm;
            FichaDataTramitacao = fichaDataTramitacao;
            FichaDefineRetorno = fichaDefineRetorno;
            FichaProvFicha = fichaProvFicha;
        }

        [Key]
        public int FichaProvRespId { get; set; }
        public int FichaId { get; set; }
        public int FichaProvRespIncPor { get; set; }
        public DateTime FichaProvRespIncEm { get; set; } = DateTime.Now;
        public int? FichaProvRespAltPor { get; set; }
        public DateTime? FichaprovRespAltEm { get; set; }
        public DateTime? FichaDtaComunicRespons { get; set; }
        public int? FichaMeioComunic { get; set; }
        public required string FichaPorQuemUsuariorId { get; set; }
        public required string FichaPraQuemUsuariorId { get; set; }
        public required string FichaProcedimentoUnidade { get; set; }
        public string? FichaRecebidoEm { get; set; }
        public DateTime? FichaDataTramitacao { get; set; }
        public string? FichaDefineRetorno { get; set; }
        public required TBFicha FichaProvFicha { get; set; }
    }
}
