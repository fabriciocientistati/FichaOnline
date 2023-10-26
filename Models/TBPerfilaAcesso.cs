#nullable disable
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace FichaOnline.Models;

public partial class TBPerfilaAcesso
{
    public TBPerfilaAcesso()
    {
        PerfilAcessoIncEm = DateTime.Now;
    }

    public TBPerfilaAcesso(int perfilAcessoId, string perfilAcessoDesc, short perfilAcessoNivel, int perfilAcessoIncPor, DateTime perfilAcessoIncEm, int? perfilAcessoAltPor, DateTime? perfilAcessoAltEm, List<TBUsuarios> usuarios) : this()
    {
        PerfilAcessoId = perfilAcessoId;
        PerfilAcessoDesc = perfilAcessoDesc;
        PerfilAcessoNivel = perfilAcessoNivel;
        PerfilAcessoIncPor = perfilAcessoIncPor;
        PerfilAcessoIncEm = perfilAcessoIncEm;
        PerfilAcessoAltPor = perfilAcessoAltPor;
        PerfilAcessoAltEm = perfilAcessoAltEm;
        Usuarios = usuarios;
    }

    [Key]
    public int PerfilAcessoId { get; set; }

    public string PerfilAcessoDesc { get; set; }

    public short PerfilAcessoNivel { get; set; }

    public int PerfilAcessoIncPor { get; set; }

    public DateTime PerfilAcessoIncEm { get; set; } = DateTime.Now;

    public int? PerfilAcessoAltPor { get; set; }

    public DateTime? PerfilAcessoAltEm { get; set; }

    public List<TBUsuarios> Usuarios { get; set; }
}