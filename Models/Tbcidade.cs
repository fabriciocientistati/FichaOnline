
#nullable disable
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace FichaOnline.Models;

public partial class TBCidade
{
    public TBCidade() 
    {
        CidIncEm = DateTime.Now;
    }

    public TBCidade(int cidId, string cidNom, long? cidCodIbge, int? cidTipo, int? cidIdDistrito, string cidNomDistrito, int cidIncPor, DateTime cidIncEm, int? cidAltPor, DateTime? cidAltEm, int estId, TBEstado cidEstado, List<TBBairro> cidadeBairros) : this()
    {
        CidId = cidId;
        CidNom = cidNom;
        CidCodIbge = cidCodIbge;
        CidTipo = cidTipo;
        CidIdDistrito = cidIdDistrito;
        CidNomDistrito = cidNomDistrito;
        CidIncPor = cidIncPor;
        CidIncEm = cidIncEm;
        CidAltPor = cidAltPor;
        CidAltEm = cidAltEm;
        EstId = estId;
        CidEstado = cidEstado;
        CidadeBairros = cidadeBairros;
    }

    [Key]
    public int CidId { get; set; }

    public string CidNom { get; set; }

    public long? CidCodIbge { get; set; }

    public int? CidTipo { get; set; }

    public int? CidIdDistrito { get; set; }

    public string CidNomDistrito { get; set; }

    public int CidIncPor { get; set; }

    public DateTime CidIncEm { get; set; } = DateTime.Now;

    public int? CidAltPor { get; set; }

    public DateTime? CidAltEm { get; set; }

    public int EstId { get; set; }

    public TBEstado CidEstado { get; set; }

    public List<TBBairro> CidadeBairros { get; set; }
}