#nullable disable
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace FichaOnline.Models;

public partial class TBCategoria
{
    [Key]
    public int CatId { get; set; }

    public string CatDesc { get; set; }

    public string CatSts { get; set; }

    public int CatIncPor { get; set; }

    public DateTime CatIncEm { get; set; } = DateTime.Now;

    public int? CatAltPor { get; set; }

    public DateTime? CatAltEm { get; set; } = DateTime.Now;

    public TBCategoriaOpcoes CategoriaOpcoes { get; set; }
    public List<TBFicha> CategoriaFicha { get; set; }

}