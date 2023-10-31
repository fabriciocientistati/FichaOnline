//using System.ComponentModel.DataAnnotations;

//namespace FichaOnline.Models
//{
//    public class TBCategoriaOpcoes
//    {
//        public TBCategoriaOpcoes() 
//        {
//            CatOpcIncEm = DateTime.Now;
//        }
//        public TBCategoriaOpcoes(int catOpcId, int catId, string catOpcDesc, int catOpcIncPor, DateTime catOpcIncEm, int? catOpcAltPor, DateTime? catOpcAltEm, TBCategoria categoria) : this()
//        {
//            CatOpcId = catOpcId;
//            CatId = catId;
//            CatOpcDesc = catOpcDesc;
//            CatOpcIncPor = catOpcIncPor;
//            CatOpcIncEm = catOpcIncEm;
//            CatOpcAltPor = catOpcAltPor;
//            CatOpcAltEm = catOpcAltEm;
//            Categoria = categoria;
//        }

//        [Key]
//        public int CatOpcId { get; set; }
//        public int CatId { get; set; } 
//        public required string CatOpcDesc {  get; set; }
//        public int CatOpcIncPor {  get; set; }
//        public DateTime CatOpcIncEm { get; set; } = DateTime.Now;
//        public int? CatOpcAltPor { get; set; }
//        public DateTime? CatOpcAltEm { get; set; } = DateTime.Now;
//        public required TBCategoria Categoria {  get; set; }    
//    }
//}
