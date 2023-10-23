#nullable disable
using FichaOnline.Helper;
using System.ComponentModel.DataAnnotations;

namespace FichaOnline.Models;

public partial class TBUsuarios
{
    public TBUsuarios() => 
        UsuarioIncEm = DateTime.Now;

    public TBUsuarios(int usuarioId, string usuarioNome, string usuarioSenha, int usuarioSenhaTemp, string usuarioEmail, string usuarioCpf, string usuarioStatus, int usuarioIncPor, DateTime usuarioIncEm, int? usuarioAltPor, DateTime? usuarioAltEm, short usuarioEmailTran, int perfilAcessoId, int unidadeId, TBPerfilacesso perfilAcesso, TBUnidades unidades) : this()
    {
        UsuarioId = usuarioId;
        UsuarioNome = usuarioNome;
        UsuarioSenha = usuarioSenha;
        UsuarioSenhaTemp = usuarioSenhaTemp;
        UsuarioEmail = usuarioEmail;
        UsuarioCpf = usuarioCpf;
        UsuarioStatus = usuarioStatus;
        UsuarioIncPor = usuarioIncPor;
        UsuarioIncEm = usuarioIncEm;
        UsuarioAltPor = usuarioAltPor;
        UsuarioAltEm = usuarioAltEm;
        UsuarioEmailTran = usuarioEmailTran;
        PerfilAcessoId = perfilAcessoId;
        UnidadeId = unidadeId;
        PerfilAcesso = perfilAcesso;
        Unidades = unidades;
    }

    [Key]
    public int UsuarioId { get; set; }

    public string UsuarioNome { get; set; }

    public string UsuarioSenha { get; set; }

    public int UsuarioSenhaTemp { get; set; }

    public string UsuarioEmail { get; set; }

    public string UsuarioCpf { get; set; }

    public string UsuarioStatus { get; set; }

    public int UsuarioIncPor { get; set; }

    public DateTime UsuarioIncEm { get; set; } = DateTime.Now;

    public int? UsuarioAltPor { get; set; }

    public DateTime? UsuarioAltEm { get; set; }

    public short UsuarioEmailTran { get; set; }

    public int PerfilAcessoId { get; set; }

    public int UnidadeId { get; set; }

    public TBPerfilacesso PerfilAcesso { get; set; }

    public TBUnidades Unidades { get; set; }


    public void SetSenhaHash()
    {
        UsuarioSenha = UsuarioSenha.GerarHash();
    }

    public bool SenhaValida(string senhaAtual)
    {
        return UsuarioSenha == senhaAtual.GerarHash();
    }

    public string GerarNovaSenha()
    {
        string novaSenha = Guid.NewGuid().ToString().Substring(0, 8);
        UsuarioSenha = novaSenha.GerarHash();
        return novaSenha;
    }

}