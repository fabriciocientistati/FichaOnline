using System.ComponentModel.DataAnnotations;

namespace FichaOnline.Models
{
    public class TBFichaProvidenciasResp
    {
        [Key]
        public int FichaProvRespId { get; set; }
        public int FichaProvRespIncPor {  get; set; }
        public DateTime FichaProvRespIncEm { get; set; } = DateTime.Now;
        public int? FichaProvRespAltPor { get; set; } 
        public DateTime? FichaprovRespAltEm { get; set; } = DateTime.Now;
    }
}
