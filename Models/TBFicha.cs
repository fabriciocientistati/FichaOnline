#nullable disable
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace FichaOnline.Models;

public partial class TBFicha
{
    [Key]
    public int FichaId { get; set; }

    public int FichaCatId { get; set; }

    public int FichaStsId { get; set; }

    public int FichaAtualUnidadeId { get; set; }

    public string FichaNova { get; set; }

    public int AluId { get; set; }

    public int FichaEscUnidadeId { get; set; }

    public DateTime FichaDtaIni { get; set; }

    public DateTime? FichaDtaFim { get; set; }

    public int FichaIncPor { get; set; }

    public DateTime FichaIncEm { get; set; } = DateTime.Now;

    public int? FichaAltPor { get; set; }

    public DateTime? FichaAltEm { get; set; }

    public string FichaOrgTipo { get; set; }

    //public virtual Tbaluno Alu { get; set; }

    public virtual Tbescola Esc { get; set; }

    public virtual Tbfichacategoria FichaCat { get; set; }
}