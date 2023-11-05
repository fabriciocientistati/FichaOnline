using System.ComponentModel.DataAnnotations;

namespace FichaOnline.Models
{
    public class TBFichaCategoriaOpcResp
    {
        public TBFichaCategoriaOpcResp() =>
            FichaCatOpcIncEm = DateTime.Now;

        public TBFichaCategoriaOpcResp(int fichaCatOpcRespId, int? catOpcId, int? fichaId, int fichaCatOpcResIncPor, DateTime fichaCatOpcIncEm, int? fichaCatOpcRespAltPor, DateTime? fichaCatOpcRespAltEm, TBFicha? catOpcRespFicha, TBCategoriaOpcoes? catOpcRespCatOpc)
        {
            FichaCatOpcRespId = fichaCatOpcRespId;
            CatOpcId = catOpcId;
            FichaId = fichaId;
            FichaCatOpcResIncPor = fichaCatOpcResIncPor;
            FichaCatOpcIncEm = fichaCatOpcIncEm;
            FichaCatOpcRespAltPor = fichaCatOpcRespAltPor;
            FichaCatOpcRespAltEm = fichaCatOpcRespAltEm;
            CatOpcRespFicha = catOpcRespFicha;
            CatOpcRespCatOpc = catOpcRespCatOpc;
        }

        [Key]
        public int FichaCatOpcRespId { get; set; }
        public int? CatOpcId { get; set; }
        public int? FichaId { get; set; }
        public int FichaCatOpcResIncPor { get; set; }
        public DateTime FichaCatOpcIncEm { get; set; } = DateTime.Now;
        public int? FichaCatOpcRespAltPor { get; set; }
        public DateTime? FichaCatOpcRespAltEm { get; set; } 
        public TBFicha? CatOpcRespFicha { get; set; }
        public TBCategoriaOpcoes? CatOpcRespCatOpc { get; set; }
    }
}
