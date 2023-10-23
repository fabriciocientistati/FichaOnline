#nullable disable
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace FichaOnline.Models;

public partial class TBEstado
{
    public TBEstado() 
    {
        EstIncEm = DateTime.Now;
    }

    public TBEstado(int estId, string estSgl, string estNom, int estIncPor, DateTime? estIncEm, int? estAltPor, DateTime? estAltEm, List<TBCidade> estadoCidades) : this()
    {
        EstId = estId;
        EstSgl = estSgl;
        EstNom = estNom;
        EstIncPor = estIncPor;
        EstIncEm = estIncEm;
        EstAltPor = estAltPor;
        EstAltEm = estAltEm;
        EstadoCidades = estadoCidades;
    }

    [Key]
    public int EstId { get; set; }

    public string EstSgl { get; set; }

    public string EstNom { get; set; }

    public int EstIncPor { get; set; }

    public DateTime? EstIncEm { get; set; } = DateTime.Now;

    public int? EstAltPor { get; set; }

    public DateTime? EstAltEm { get; set; }
    public List<TBCidade> EstadoCidades { get; set; }
}