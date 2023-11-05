namespace FichaOnline.Models
{
    public class ViewModel
    {
        public required TBFicha TBFicha { get; set; }
        public required List<TBCategoriaOpcoes> ListCategoriaOpcoes { get; set; }
        public required List<int> ItemSelecionadoIds { get; set; }
    }
}
