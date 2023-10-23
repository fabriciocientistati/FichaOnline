#nullable disable
using System.ComponentModel.DataAnnotations;

namespace FichaOnline.Models
{
    public class TBUnidades
    {
        public TBUnidades() 
        { 
            UnidadeIncEm = DateTime.Now;
        }

        public TBUnidades(int unidadeId, int unidadeCod, string unidadeDesc, string unidadeStatus, string unidadeEmail, string unidadeDDD, string unidadeFone, string unidadeCEP, string unidadeEndNmr, string unidadeEndLog, string unidadeEndComp, int unidadeIncPor, DateTime unidadeIncEm, int? unidadeAltPor, DateTime? unidadeAltEm, int unidadesTpoId, int poloId, TBUnidadeTipos tiposUnidade, TBPolo polo, List<TBUsuarios> unidadeUsuarios) : this()
        {
            UnidadeId = unidadeId;
            UnidadeCod = unidadeCod;
            UnidadeDesc = unidadeDesc;
            UnidadeStatus = unidadeStatus;
            UnidadeEmail = unidadeEmail;
            UnidadeDDD = unidadeDDD;
            UnidadeFone = unidadeFone;
            UnidadeCEP = unidadeCEP;
            UnidadeEndNmr = unidadeEndNmr;
            UnidadeEndLog = unidadeEndLog;
            UnidadeEndComp = unidadeEndComp;
            UnidadeIncPor = unidadeIncPor;
            UnidadeIncEm = unidadeIncEm;
            UnidadeAltPor = unidadeAltPor;
            UnidadeAltEm = unidadeAltEm;
            UnidadesTpoId = unidadesTpoId;
            PoloId = poloId;
            TiposUnidade = tiposUnidade;
            Polo = polo;
            UnidadeUsuarios = unidadeUsuarios;
        }

        [Key]
        public int UnidadeId { get; set; }

        public int UnidadeCod { get; set; }

        public string UnidadeDesc { get; set; }

        public string UnidadeStatus { get; set; }

        public string UnidadeEmail { get; set; }

        public string UnidadeDDD { get; set; }

        public string UnidadeFone { get; set; }

        public string UnidadeCEP { get; set; }

        public string UnidadeEndNmr { get; set; }

        public string UnidadeEndLog { get; set; }

        public string UnidadeEndComp { get; set; }

        public int UnidadeIncPor { get; set; }

        public DateTime UnidadeIncEm { get; set; } = DateTime.Now;

        public int? UnidadeAltPor { get; set; }

        public DateTime? UnidadeAltEm { get;set; } 

        public int UnidadesTpoId { get; set; }

        public TBUnidadeTipos TiposUnidade { get; set; }

        public int PoloId { get; set; }

        public TBPolo Polo { get; set; }

        public List<TBUsuarios> UnidadeUsuarios { get; set; }
    }
}
