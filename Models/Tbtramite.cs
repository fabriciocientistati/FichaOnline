#nullable disable
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace FichaOnline.Models;

public partial class TBTramite  
{
    [Key]
    public int TramiteId { get; set; }

    public int PerfilAcessoId { get; set; }

    public int FichaCatId { get; set; }

    public int TramiteAtual { get; set; }

    public int TramiteDestino { get; set; }

    public int TramiteIncPor { get; set; }

    public DateTime TramiteIncEm { get; set; }

    public TBCategoria TramiteCategoria { get; set; }

    public TBPerfilaAcesso PerfilAcesso { get; set; }
}