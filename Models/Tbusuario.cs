#nullable disable

using FichaOnline.Helper;
using System.ComponentModel.DataAnnotations;

namespace FichaOnline.Models;

public partial class Tbusuario
{
    public Tbusuario() => 
        UsuarioIncEm = DateTime.Now;

    public Tbusuario(int usuarioId, string usuarioNome, string usuarioSenha, string usuarioSenhaTemp, string usuarioEmail, string usuarioCpf, string usuarioStatus, int usuarioIncPor, DateTime usuarioIncEm, int? usuarioAltPor, DateTime? usuarioAltEm, short usuarioEmailTran, int perfilAcessoId, Tbperfilacesso perfilAcesso) : this()
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
        PerfilAcesso = perfilAcesso;
    }

    [Key]
    public int UsuarioId { get; set; }

    public string UsuarioNome { get; set; }

    public string UsuarioSenha { get; set; }

    public string UsuarioSenhaTemp { get; set; }

    public string UsuarioEmail { get; set; }

    public string UsuarioCpf { get; set; }

    public string UsuarioStatus { get; set; }

    public int UsuarioIncPor { get; set; }

    public DateTime UsuarioIncEm { get; set; } = DateTime.Now;

    public int? UsuarioAltPor { get; set; }

    public DateTime? UsuarioAltEm { get; set; } = DateTime.Now;

    public short UsuarioEmailTran { get; set; }

    public int PerfilAcessoId { get; set; }

    public Tbperfilacesso PerfilAcesso { get; set; }

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