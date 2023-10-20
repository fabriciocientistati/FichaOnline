#nullable disable
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace FichaOnline.Models;

public partial class Tbperfilacesso
{
    public Tbperfilacesso()
    {
        PerfilAcessoIncEm = DateTime.Now;
    }

    public Tbperfilacesso(int perfilAcessoId, string perfilAcessoDesc, short perfilAcessoNivel, int perfilAcessoIncPor, DateTime perfilAcessoIncEm, int? perfilAcessoAltPor, DateTime? perfilAcessoAltEm, List<Tbusuarios> usuarios) : this()
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
    public DateTime? PerfilAcessoAltEm { get; set; } = DateTime.Now;
    public List<Tbusuarios> Usuarios { get; set; }
}