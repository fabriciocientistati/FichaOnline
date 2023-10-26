using System.ComponentModel.DataAnnotations;

namespace FichaOnline.Models
{
    public class TBFichaCategoriaOpcResp
    {
        [Key]
        public int FichaCatOpcRespId { get; set; }
        public int CatOpcId { get; set; }
        public int FichaId { get; set; }
        public int FichaCatOpcResIncPor {  get; set; }
        public DateTime FichaCatOpcIncEm { get; set; } = DateTime.Now;
        public int? FichaCatOpcRespAltPor { get; set; }
        public DateTime? FichaCatOpcRespAltEm { get; set; } = DateTime.Now;
        public required TBFicha CatOpcRespFicha { get; set; }
        public required TBCategoriaOpcoes CatOpcRespCatOpc {  get; set; }
    }
}
