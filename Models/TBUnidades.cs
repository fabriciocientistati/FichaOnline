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
        public string UnidadeIncPor { get; set; }
        public DateTime UnidadeIncEm { get; set; } = DateTime.Now;
        public string? UnidadeAltPor { get; set; }
        public DateTime? UnidadeAltEm { get;set; } = DateTime.Now;
        public int UnidadesTpoId { get; set; }
        public int PoloId { get; set; }
        public TBUnidadeTipos TiposUnidade { get; set; }
        public TBPolo PolosAssociados { get; set; }
        public List<Tbusuarios> Usuarios { get; set; }
    }
}
