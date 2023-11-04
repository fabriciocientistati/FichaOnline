namespace FichaOnline.Models
{
    public class FichaCategoriaViewModel
    {
        public TBFichaCategoriaOpcResp? TBFichaCategoriaOpcResp { get; set; }
        public List<TBCategoriaOpcoes>? CategoriaOpcoes { get; set; }
        public List<int>? CategoriaSelecionadaids { get; set; }

    }
}
