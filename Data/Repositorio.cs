using FichaOnline.Models;

namespace FichaOnline.Data
{
    public class Repositorio
    {
        public static IReadOnlyList<TBCategoriaOpcoes> Opcoes()
        {
            return new List<TBCategoriaOpcoes>
            {
                new TBCategoriaOpcoes
                {
                    CatId = 1,
                    CatOpcDesc = "TESTE",
                    CatOpcIncPor = 1,
                    CatOpcIncEm = DateTime.Now
                },
                new TBCategoriaOpcoes
                {
                    CatId = 2,
                    CatOpcDesc = "TESTE 2",
                    CatOpcIncPor = 2,
                    CatOpcIncEm = DateTime.Now
                }
            };
        }
    }
}
