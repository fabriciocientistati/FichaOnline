#nullable disable
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace FichaOnline.Models;

public partial class TBPolo
{
    public TBPolo() =>
        PoloIncEm = DateTime.Now;

    public TBPolo(int poloId, string poloNome, string poloStatus, int poloIncPor, DateTime poloIncEm, int? poloAltPor, DateTime? poloAltEm, List<TBUnidades> unidadePolos) : this()
    {
        PoloId = poloId;
        PoloNome = poloNome;
        PoloStatus = poloStatus;
        PoloIncPor = poloIncPor;
        PoloIncEm = poloIncEm;
        PoloAltPor = poloAltPor;
        PoloAltEm = poloAltEm;
        UnidadePolos = unidadePolos;
    }

    [Key]
    public int PoloId { get; set; }

    public string PoloNome { get; set; }

    public string PoloStatus { get; set; }

    public int PoloIncPor { get; set; }

    public DateTime PoloIncEm { get; set; } = DateTime.Now;

    public int? PoloAltPor { get; set; }

    public DateTime? PoloAltEm { get; set; }

    public List<TBUnidades> UnidadePolos { get; set; }
}