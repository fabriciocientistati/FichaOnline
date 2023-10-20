//#nullable disable
//using System;
//using System.Collections.Generic;
//using System.ComponentModel.DataAnnotations;

//namespace FichaOnline.Models;

//public partial class TBPolounidades
//{
//    public TBPolounidades() 
//    {
//        PoloUnidIncEm = DateTime.Now;
//    }

//    public TBPolounidades(int poloUnidId, int poloId, string poloUnidTipo, int poloUnidIncPor, DateTime poloUnidIncEm, int? poloUnidAltPor, DateTime? poloUnidAltEm, TBUnidades unidade) : this()
//    {
//        PoloUnidId = poloUnidId;
//        PoloId = poloId;
//        PoloUnidTipo = poloUnidTipo;
//        PoloUnidIncPor = poloUnidIncPor;
//        PoloUnidIncEm = poloUnidIncEm;
//        PoloUnidAltPor = poloUnidAltPor;
//        PoloUnidAltEm = poloUnidAltEm;
//        Unidade = unidade;
//    }

//    [Key]
//    public int PoloUnidId { get; set; }
//    public string PoloUnidTipo { get; set; }
//    public int PoloUnidIncPor { get; set; }
//    public DateTime PoloUnidIncEm { get; set; } = DateTime.Now;
//    public int? PoloUnidAltPor { get; set; }
//    public DateTime? PoloUnidAltEm { get; set; } = DateTime.Now;
//    public int PoloId { get; set; }
//    public TBUnidades Unidade { get; set; }

//}