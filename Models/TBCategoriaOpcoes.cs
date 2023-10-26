using System.ComponentModel.DataAnnotations;

namespace FichaOnline.Models
{
    public class TBCategoriaOpcoes
    {
        [Key]
        public int CatOpcId { get; set; }
        public int CatId { get; set; } 
        public required string CatOpcDesc {  get; set; }
        public int CatOpcIncPor {  get; set; }
        public DateTime CatOpcIncEm { get; set; } = DateTime.Now;
        public int? CatOpcAltPor { get; set; }
        public DateTime? CatOpcAltEm { get; set; } = DateTime.Now;
        public required TBCategoria Categoria {  get; set; }    
    }
}
