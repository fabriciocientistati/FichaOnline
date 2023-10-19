
#nullable disable
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace FichaOnline.Models;

public partial class Tbusuarioorgao
{
    [Key]

    public int UsuOrgId { get; set; }

    public int UsuarioId { get; set; }

    public int UsuOrgCod { get; set; }

    public string UsuOrgTipo { get; set; }

    public int UsuOrgIncPor { get; set; }

    public DateTime UsuOrgIncEm { get; set; } = DateTime.Now;

    public int? UsuOrgAltPor { get; set; }

    public DateTime? UsuOrgAltEm { get; set; }

    public virtual Tbusuario Usuario { get; set; }
}