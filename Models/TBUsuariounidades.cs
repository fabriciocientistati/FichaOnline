
#nullable disable
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace FichaOnline.Models;

public partial class TBUsuariounidades
{
    public TBUsuariounidades()
    {
        UsuUnidIncEm = DateTime.Now;
    }

    public TBUsuariounidades(int usuUnidId, int usuarioId, int unidadeId, string usuUnidTipo, int usuUnidIncPor, DateTime usuUnidIncEm, int? usuUnidAltPor, DateTime? usuUnidAltEm, TBUsuarios usuario, TBUnidades unidade) : this()
    {
        UsuUnidId = usuUnidId;
        UsuarioId = usuarioId;
        UnidadeId = unidadeId;
        UsuUnidTipo = usuUnidTipo;
        UsuUnidIncPor = usuUnidIncPor;
        UsuUnidIncEm = usuUnidIncEm;
        UsuUnidAltPor = usuUnidAltPor;
        UsuUnidAltEm = usuUnidAltEm;
        Usuario = usuario;
        Unidade = unidade;
    }

    [Key]
    public int UsuUnidId { get; set; }
    public string UsuUnidTipo { get; set; }
    public int UsuUnidIncPor { get; set; }
    public DateTime UsuUnidIncEm { get; set; } = DateTime.Now;
    public int? UsuUnidAltPor { get; set; }
    public DateTime? UsuUnidAltEm { get; set; } = DateTime.Now;
    public int UsuarioId { get; set; }
    public int UnidadeId { get; set; }
    public TBUsuarios Usuario { get; set; }
    public TBUnidades Unidade { get; set; }
}