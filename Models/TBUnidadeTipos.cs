#nullable disable
using System.ComponentModel.DataAnnotations;

namespace FichaOnline.Models
{
    public class TBUnidadeTipos
    {
        public TBUnidadeTipos() =>
            UnidadeTpoIncEm = DateTime.Now;

        public TBUnidadeTipos(int unidadeTpoId, string unidadeTpoDsc, string unidadeSgl, string unidadeTipo, int unidadeTpoIncPor, DateTime unidadeTpoIncEm, int? unidadeTpoAltPor, DateTime? unidadeTpoAltEm, List<TBUnidades> unidadeUnidadeTipos) : this()
        {
            UnidadeTpoId = unidadeTpoId;
            UnidadeTpoDsc = unidadeTpoDsc;
            UnidadeSgl = unidadeSgl;
            UnidadeTipo = unidadeTipo;
            UnidadeTpoIncPor = unidadeTpoIncPor;
            UnidadeTpoIncEm = unidadeTpoIncEm;
            UnidadeTpoAltPor = unidadeTpoAltPor;
            UnidadeTpoAltEm = unidadeTpoAltEm;
            UnidadeUnidadeTipos = unidadeUnidadeTipos;
        }

        [Key]
        public int UnidadeTpoId { get; set; }

        public string UnidadeTpoDsc { get; set; }

        public string UnidadeSgl { get; set; }

        public string UnidadeTipo { get; set; }

        public int UnidadeTpoIncPor { get; set; }

        public DateTime UnidadeTpoIncEm { get; set; } = DateTime.Now;

        public int? UnidadeTpoAltPor { get; set; }

        public DateTime? UnidadeTpoAltEm { get; set; }

        public List<TBUnidades> UnidadeUnidadeTipos { get; set; }
        
    }
}
