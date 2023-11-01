#nullable disable
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace FichaOnline.Models;

public partial class TBAluno
{
    public TBAluno()
    {
        AluIncEm = DateTime.Now;
    }
    public TBAluno(int aluId, string aluNom, string aluNomSoc, DateTime aluDtaNasc, string aluCpf, string aluSexo, string aluFiliacao1, string aluFiliacao2, string aluFiliacao3, int? aluIdinep, string aluRaca, string aluEndLog, string aluEndNmrLog, string aluEndCmpLog, string aluEndBairro, string aluEndCep, string aluTelResDdd, string aluTelRes, string aluTelCelDdd, string aluTelCel, string aluTelConDdd, string aluTelCon, string aluObs, string aluStatus, int aluIncPor, DateTime aluIncEm, int? aluAltPor, DateTime? aluAltEm, int? bairroId, int gedAluCod, TBBairro alunoBairro, List<TBFicha> alunoFicha) : this()
    {
        AluId = aluId;
        AluNom = aluNom;
        AluNomSoc = aluNomSoc;
        AluDtaNasc = aluDtaNasc;
        AluCpf = aluCpf;
        AluSexo = aluSexo;
        AluFiliacao1 = aluFiliacao1;
        AluFiliacao2 = aluFiliacao2;
        AluFiliacao3 = aluFiliacao3;
        AluIdinep = aluIdinep;
        AluRaca = aluRaca;
        AluEndLog = aluEndLog;
        AluEndNmrLog = aluEndNmrLog;
        AluEndCmpLog = aluEndCmpLog;
        AluEndBairro = aluEndBairro;
        AluEndCep = aluEndCep;
        AluTelResDdd = aluTelResDdd;
        AluTelRes = aluTelRes;
        AluTelCelDdd = aluTelCelDdd;
        AluTelCel = aluTelCel;
        AluTelConDdd = aluTelConDdd;
        AluTelCon = aluTelCon;
        AluObs = aluObs;
        AluStatus = aluStatus;
        AluIncPor = aluIncPor;
        AluIncEm = aluIncEm;
        AluAltPor = aluAltPor;
        AluAltEm = aluAltEm;
        BairroId = bairroId;
        GedAluCod = gedAluCod;
        AlunoBairro = alunoBairro;
        AlunoFicha = alunoFicha;
    }

    [Key]
    public int AluId { get; set; }

    public string AluNom { get; set; }

    public string AluNomSoc { get; set; }

    public DateTime AluDtaNasc { get; set; }

    public string AluCpf { get; set; }

    public string AluSexo { get; set; }

    public string AluFiliacao1 { get; set; }

    public string AluFiliacao2 { get; set; }

    public string AluFiliacao3 { get; set; }

    public int? AluIdinep { get; set; }

    public string AluRaca { get; set; }

    public string AluEndLog { get; set; }

    public string AluEndNmrLog { get; set; }

    public string AluEndCmpLog { get; set; }

    public string AluEndBairro { get; set; }

    public string AluEndCep { get; set; }

    public string AluTelResDdd { get; set; }

    public string AluTelRes { get; set; }

    public string AluTelCelDdd { get; set; }

    public string AluTelCel { get; set; }

    public string AluTelConDdd { get; set; }

    public string AluTelCon { get; set; }

    public string AluObs { get; set; }

    public string AluStatus { get; set; }

    public int AluIncPor { get; set; }

    public DateTime AluIncEm { get; set; } = DateTime.Now;

    public int? AluAltPor { get; set; }

    public DateTime? AluAltEm { get; set; }

    public int? BairroId { get; set; }

    public int GedAluCod { get; set; }

    public TBBairro AlunoBairro { get; set; }

    public List<TBFicha> AlunoFicha { get; set; }
}