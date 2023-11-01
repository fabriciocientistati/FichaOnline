#nullable disable
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace FichaOnline.Models;

public partial class TBCategoria
{
    public TBCategoria()
    {
        CatIncEm = DateTime.Now;
    }
    public TBCategoria(int catId, string catDesc, string catSts, int catIncPor, DateTime catIncEm, int? catAltPor, DateTime? catAltEm, List<TBFicha> categoriaFicha, List<TBCategoriaOpcoes> categoriaCategoriaOpcoes) : this()
    {
        CatId = catId;
        CatDesc = catDesc;
        CatSts = catSts;
        CatIncPor = catIncPor;
        CatIncEm = catIncEm;
        CatAltPor = catAltPor;
        CatAltEm = catAltEm;
        CategoriaFicha = categoriaFicha;
        CategoriaCategoriaOpcoes = categoriaCategoriaOpcoes;
    }

    [Key]
    public int CatId { get; set; }

    public string CatDesc { get; set; }

    public string CatSts { get; set; }

    public int CatIncPor { get; set; }

    public DateTime CatIncEm { get; set; } = DateTime.Now;

    public int? CatAltPor { get; set; }

    public DateTime? CatAltEm { get; set; } = DateTime.Now;

    public List<TBFicha> CategoriaFicha { get; set; }

    public List<TBCategoriaOpcoes> CategoriaCategoriaOpcoes { get; set; }
}