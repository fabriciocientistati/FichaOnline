using System.ComponentModel.DataAnnotations;

namespace FichaOnline.Models
{
    public class TBFichaCategoriaOpcResp
    {
        [Key]
        public int FichaCatOpcRespId { get; set; }
        public int FichaCatOpcResIncPor {  get; set; }
        public DateTime FichaCatOpcIncEm { get; set; } = DateTime.Now;
        public int? FichaCatOpcRespAltPor { get; set; }
        public DateTime? FichaCatOpcRespAltEm { get; set; } = DateTime.Now;
        
        public TBFicha CatOpcRespFicha { get; set; }
    }
}
