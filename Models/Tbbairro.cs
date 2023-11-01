#nullable disable
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace FichaOnline.Models;

public partial class TBBairro
{
    public TBBairro() 
    {
        BairroIncEm = DateTime.Now;
    }
    public TBBairro(int bairroId, string bairroNome, int bairroIncPor, int? bairroAltPor, int cidadeId, TBCidade bairroCidade, DateTime bairroIncEm, DateTime? bairroAltEm, List<TBAluno> bairroAlunos) : this()
    {
        BairroId = bairroId;
        BairroNome = bairroNome;
        BairroIncPor = bairroIncPor;
        BairroAltPor = bairroAltPor;
        CidadeId = cidadeId;
        BairroCidade = bairroCidade;
        BairroIncEm = bairroIncEm;
        BairroAltEm = bairroAltEm;
        BairroAlunos = bairroAlunos;
    }

    [Key]
    public int BairroId { get; set; }

    public string BairroNome { get; set; }

    public int BairroIncPor { get; set; }

    public int? BairroAltPor { get; set; }

    public int CidadeId { get; set; }

    public TBCidade BairroCidade { get; set; }

    public DateTime BairroIncEm { get; set; } = DateTime.Now;

    public DateTime? BairroAltEm { get; set; }
    public List<TBAluno> BairroAlunos { get; set; }
}