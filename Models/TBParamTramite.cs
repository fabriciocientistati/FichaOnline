#nullable disable
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace FichaOnline.Models;

public partial class TBParamTramite
{
    public TBParamTramite() =>
        ParamTramiteIncEm = DateTime.Now;

    public TBParamTramite(int paramTramiteId, int perfilAcessoId, int catId, int paramTramiteOrigem, int paramTramiteDestino, int paramTramiteIncPor, DateTime paramTramiteIncEm, TBCategoria paramTramiteCategoria, TBPerfilaAcesso paramPerfilAcesso) : this()
    {
        ParamTramiteId = paramTramiteId;
        PerfilAcessoId = perfilAcessoId;
        CatId = catId;
        ParamTramiteOrigem = paramTramiteOrigem;
        ParamTramiteDestino = paramTramiteDestino;
        ParamTramiteIncPor = paramTramiteIncPor;
        ParamTramiteIncEm = paramTramiteIncEm;
        ParamTramiteCategoria = paramTramiteCategoria;
        ParamPerfilAcesso = paramPerfilAcesso;
    }

    [Key]
    public int ParamTramiteId { get; set; }

    public int PerfilAcessoId { get; set; }

    public int CatId { get; set; }

    public int ParamTramiteOrigem { get; set; }

    public int ParamTramiteDestino { get; set; }

    public int ParamTramiteIncPor { get; set; }

    public DateTime ParamTramiteIncEm { get; set; } = DateTime.Now;

    public TBCategoria ParamTramiteCategoria { get; set; }

    public TBPerfilaAcesso ParamPerfilAcesso { get; set; }
}