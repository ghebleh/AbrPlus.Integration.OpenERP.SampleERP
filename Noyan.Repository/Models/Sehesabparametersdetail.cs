using System;
using System.Collections.Generic;

namespace Noyan.Repository.Models;

public partial class Sehesabparametersdetail
{
    public int IdHpardtl { get; set; }

    public short IdHpar { get; set; }

    public byte IdActive { get; set; }

    public int Code { get; set; }

    public byte? IdCtmtit { get; set; }

    public string Name { get; set; } = null!;

    public byte? IdCtmtyp { get; set; }

    public string Father { get; set; } = null!;

    public byte? IdSex { get; set; }

    public string Birthdate { get; set; } = null!;

    public string Birthshahr { get; set; } = null!;

    public string Shanasno { get; set; } = null!;

    public string Sodoordate { get; set; } = null!;

    public string Sodoor { get; set; } = null!;

    public string Melino { get; set; } = null!;

    public string Address { get; set; } = null!;

    public string Tel { get; set; } = null!;

    public decimal Credit { get; set; }

    public byte? IdBank { get; set; }

    public string Shobeh { get; set; } = null!;

    public byte? IdBnkhtyp { get; set; }

    public string Hesabno { get; set; } = null!;

    public string IndtDa { get; set; } = null!;

    public string IndtTi { get; set; } = null!;

    public string? Para1 { get; set; }

    public string? Para2 { get; set; }

    public string? Para3 { get; set; }

    public string? Para4 { get; set; }

    public string? Para5 { get; set; }

    public string? Para6 { get; set; }

    public string? Para7 { get; set; }

    public string? Para8 { get; set; }

    public string? Para9 { get; set; }

    public string? Para10 { get; set; }

    public string? Para11 { get; set; }

    public string? Para12 { get; set; }

    public string? Para13 { get; set; }

    public string? Para14 { get; set; }

    public string? Para15 { get; set; }

    public string? Para16 { get; set; }

    public string? Para17 { get; set; }

    public string? Para18 { get; set; }

    public string? Para19 { get; set; }

    public string? Para20 { get; set; }

    public string? Para21 { get; set; }

    public string? Para22 { get; set; }

    public string? Para23 { get; set; }

    public string? Para24 { get; set; }

    public string? Para25 { get; set; }

    public string? Para26 { get; set; }

    public string? Para27 { get; set; }

    public string? Para28 { get; set; }

    public string? Para29 { get; set; }

    public string? Para30 { get; set; }

    public string? Para31 { get; set; }

    public string? Para32 { get; set; }

    public string? Para33 { get; set; }

    public string? Para34 { get; set; }

    public string? Para35 { get; set; }

    public string? Para36 { get; set; }

    public string? Para37 { get; set; }

    public string? Para38 { get; set; }

    public string? Para39 { get; set; }

    public string? Para40 { get; set; }

    public string? Para41 { get; set; }

    public string? Para42 { get; set; }

    public string? Para43 { get; set; }

    public string? Para44 { get; set; }

    public string? Para45 { get; set; }

    public string? Para46 { get; set; }

    public string? Para47 { get; set; }

    public string? Para48 { get; set; }

    public string? Para49 { get; set; }

    public string? Para50 { get; set; }

    public virtual Active IdActiveNavigation { get; set; } = null!;

    public virtual Sebank? IdBankNavigation { get; set; }

    public virtual Sebankhesabtype? IdBnkhtypNavigation { get; set; }

    public virtual Secustomertitle? IdCtmtitNavigation { get; set; }

    public virtual Persontype? IdCtmtypNavigation { get; set; }

    public virtual Sehesabparameter IdHparNavigation { get; set; } = null!;

    public virtual Sex? IdSexNavigation { get; set; }

    public virtual ICollection<Sehesab> SehesabIdHpar10Navigations { get; set; } = new List<Sehesab>();

    public virtual ICollection<Sehesab> SehesabIdHpar11Navigations { get; set; } = new List<Sehesab>();

    public virtual ICollection<Sehesab> SehesabIdHpar12Navigations { get; set; } = new List<Sehesab>();

    public virtual ICollection<Sehesab> SehesabIdHpar13Navigations { get; set; } = new List<Sehesab>();

    public virtual ICollection<Sehesab> SehesabIdHpar14Navigations { get; set; } = new List<Sehesab>();

    public virtual ICollection<Sehesab> SehesabIdHpar15Navigations { get; set; } = new List<Sehesab>();

    public virtual ICollection<Sehesab> SehesabIdHpar16Navigations { get; set; } = new List<Sehesab>();

    public virtual ICollection<Sehesab> SehesabIdHpar17Navigations { get; set; } = new List<Sehesab>();

    public virtual ICollection<Sehesab> SehesabIdHpar18Navigations { get; set; } = new List<Sehesab>();

    public virtual ICollection<Sehesab> SehesabIdHpar19Navigations { get; set; } = new List<Sehesab>();

    public virtual ICollection<Sehesab> SehesabIdHpar1Navigations { get; set; } = new List<Sehesab>();

    public virtual ICollection<Sehesab> SehesabIdHpar20Navigations { get; set; } = new List<Sehesab>();

    public virtual ICollection<Sehesab> SehesabIdHpar21Navigations { get; set; } = new List<Sehesab>();

    public virtual ICollection<Sehesab> SehesabIdHpar22Navigations { get; set; } = new List<Sehesab>();

    public virtual ICollection<Sehesab> SehesabIdHpar23Navigations { get; set; } = new List<Sehesab>();

    public virtual ICollection<Sehesab> SehesabIdHpar24Navigations { get; set; } = new List<Sehesab>();

    public virtual ICollection<Sehesab> SehesabIdHpar25Navigations { get; set; } = new List<Sehesab>();

    public virtual ICollection<Sehesab> SehesabIdHpar26Navigations { get; set; } = new List<Sehesab>();

    public virtual ICollection<Sehesab> SehesabIdHpar27Navigations { get; set; } = new List<Sehesab>();

    public virtual ICollection<Sehesab> SehesabIdHpar28Navigations { get; set; } = new List<Sehesab>();

    public virtual ICollection<Sehesab> SehesabIdHpar29Navigations { get; set; } = new List<Sehesab>();

    public virtual ICollection<Sehesab> SehesabIdHpar2Navigations { get; set; } = new List<Sehesab>();

    public virtual ICollection<Sehesab> SehesabIdHpar30Navigations { get; set; } = new List<Sehesab>();

    public virtual ICollection<Sehesab> SehesabIdHpar31Navigations { get; set; } = new List<Sehesab>();

    public virtual ICollection<Sehesab> SehesabIdHpar32Navigations { get; set; } = new List<Sehesab>();

    public virtual ICollection<Sehesab> SehesabIdHpar33Navigations { get; set; } = new List<Sehesab>();

    public virtual ICollection<Sehesab> SehesabIdHpar34Navigations { get; set; } = new List<Sehesab>();

    public virtual ICollection<Sehesab> SehesabIdHpar35Navigations { get; set; } = new List<Sehesab>();

    public virtual ICollection<Sehesab> SehesabIdHpar36Navigations { get; set; } = new List<Sehesab>();

    public virtual ICollection<Sehesab> SehesabIdHpar37Navigations { get; set; } = new List<Sehesab>();

    public virtual ICollection<Sehesab> SehesabIdHpar38Navigations { get; set; } = new List<Sehesab>();

    public virtual ICollection<Sehesab> SehesabIdHpar39Navigations { get; set; } = new List<Sehesab>();

    public virtual ICollection<Sehesab> SehesabIdHpar3Navigations { get; set; } = new List<Sehesab>();

    public virtual ICollection<Sehesab> SehesabIdHpar40Navigations { get; set; } = new List<Sehesab>();

    public virtual ICollection<Sehesab> SehesabIdHpar41Navigations { get; set; } = new List<Sehesab>();

    public virtual ICollection<Sehesab> SehesabIdHpar42Navigations { get; set; } = new List<Sehesab>();

    public virtual ICollection<Sehesab> SehesabIdHpar43Navigations { get; set; } = new List<Sehesab>();

    public virtual ICollection<Sehesab> SehesabIdHpar44Navigations { get; set; } = new List<Sehesab>();

    public virtual ICollection<Sehesab> SehesabIdHpar45Navigations { get; set; } = new List<Sehesab>();

    public virtual ICollection<Sehesab> SehesabIdHpar46Navigations { get; set; } = new List<Sehesab>();

    public virtual ICollection<Sehesab> SehesabIdHpar47Navigations { get; set; } = new List<Sehesab>();

    public virtual ICollection<Sehesab> SehesabIdHpar48Navigations { get; set; } = new List<Sehesab>();

    public virtual ICollection<Sehesab> SehesabIdHpar49Navigations { get; set; } = new List<Sehesab>();

    public virtual ICollection<Sehesab> SehesabIdHpar4Navigations { get; set; } = new List<Sehesab>();

    public virtual ICollection<Sehesab> SehesabIdHpar50Navigations { get; set; } = new List<Sehesab>();

    public virtual ICollection<Sehesab> SehesabIdHpar5Navigations { get; set; } = new List<Sehesab>();

    public virtual ICollection<Sehesab> SehesabIdHpar6Navigations { get; set; } = new List<Sehesab>();

    public virtual ICollection<Sehesab> SehesabIdHpar7Navigations { get; set; } = new List<Sehesab>();

    public virtual ICollection<Sehesab> SehesabIdHpar8Navigations { get; set; } = new List<Sehesab>();

    public virtual ICollection<Sehesab> SehesabIdHpar9Navigations { get; set; } = new List<Sehesab>();

    public virtual ICollection<Sehesabgroupdetail> SehesabgroupdetailIdHpar10Navigations { get; set; } = new List<Sehesabgroupdetail>();

    public virtual ICollection<Sehesabgroupdetail> SehesabgroupdetailIdHpar11Navigations { get; set; } = new List<Sehesabgroupdetail>();

    public virtual ICollection<Sehesabgroupdetail> SehesabgroupdetailIdHpar12Navigations { get; set; } = new List<Sehesabgroupdetail>();

    public virtual ICollection<Sehesabgroupdetail> SehesabgroupdetailIdHpar13Navigations { get; set; } = new List<Sehesabgroupdetail>();

    public virtual ICollection<Sehesabgroupdetail> SehesabgroupdetailIdHpar14Navigations { get; set; } = new List<Sehesabgroupdetail>();

    public virtual ICollection<Sehesabgroupdetail> SehesabgroupdetailIdHpar15Navigations { get; set; } = new List<Sehesabgroupdetail>();

    public virtual ICollection<Sehesabgroupdetail> SehesabgroupdetailIdHpar16Navigations { get; set; } = new List<Sehesabgroupdetail>();

    public virtual ICollection<Sehesabgroupdetail> SehesabgroupdetailIdHpar17Navigations { get; set; } = new List<Sehesabgroupdetail>();

    public virtual ICollection<Sehesabgroupdetail> SehesabgroupdetailIdHpar18Navigations { get; set; } = new List<Sehesabgroupdetail>();

    public virtual ICollection<Sehesabgroupdetail> SehesabgroupdetailIdHpar19Navigations { get; set; } = new List<Sehesabgroupdetail>();

    public virtual ICollection<Sehesabgroupdetail> SehesabgroupdetailIdHpar1Navigations { get; set; } = new List<Sehesabgroupdetail>();

    public virtual ICollection<Sehesabgroupdetail> SehesabgroupdetailIdHpar20Navigations { get; set; } = new List<Sehesabgroupdetail>();

    public virtual ICollection<Sehesabgroupdetail> SehesabgroupdetailIdHpar21Navigations { get; set; } = new List<Sehesabgroupdetail>();

    public virtual ICollection<Sehesabgroupdetail> SehesabgroupdetailIdHpar22Navigations { get; set; } = new List<Sehesabgroupdetail>();

    public virtual ICollection<Sehesabgroupdetail> SehesabgroupdetailIdHpar23Navigations { get; set; } = new List<Sehesabgroupdetail>();

    public virtual ICollection<Sehesabgroupdetail> SehesabgroupdetailIdHpar24Navigations { get; set; } = new List<Sehesabgroupdetail>();

    public virtual ICollection<Sehesabgroupdetail> SehesabgroupdetailIdHpar25Navigations { get; set; } = new List<Sehesabgroupdetail>();

    public virtual ICollection<Sehesabgroupdetail> SehesabgroupdetailIdHpar26Navigations { get; set; } = new List<Sehesabgroupdetail>();

    public virtual ICollection<Sehesabgroupdetail> SehesabgroupdetailIdHpar27Navigations { get; set; } = new List<Sehesabgroupdetail>();

    public virtual ICollection<Sehesabgroupdetail> SehesabgroupdetailIdHpar28Navigations { get; set; } = new List<Sehesabgroupdetail>();

    public virtual ICollection<Sehesabgroupdetail> SehesabgroupdetailIdHpar29Navigations { get; set; } = new List<Sehesabgroupdetail>();

    public virtual ICollection<Sehesabgroupdetail> SehesabgroupdetailIdHpar2Navigations { get; set; } = new List<Sehesabgroupdetail>();

    public virtual ICollection<Sehesabgroupdetail> SehesabgroupdetailIdHpar30Navigations { get; set; } = new List<Sehesabgroupdetail>();

    public virtual ICollection<Sehesabgroupdetail> SehesabgroupdetailIdHpar31Navigations { get; set; } = new List<Sehesabgroupdetail>();

    public virtual ICollection<Sehesabgroupdetail> SehesabgroupdetailIdHpar32Navigations { get; set; } = new List<Sehesabgroupdetail>();

    public virtual ICollection<Sehesabgroupdetail> SehesabgroupdetailIdHpar33Navigations { get; set; } = new List<Sehesabgroupdetail>();

    public virtual ICollection<Sehesabgroupdetail> SehesabgroupdetailIdHpar34Navigations { get; set; } = new List<Sehesabgroupdetail>();

    public virtual ICollection<Sehesabgroupdetail> SehesabgroupdetailIdHpar35Navigations { get; set; } = new List<Sehesabgroupdetail>();

    public virtual ICollection<Sehesabgroupdetail> SehesabgroupdetailIdHpar36Navigations { get; set; } = new List<Sehesabgroupdetail>();

    public virtual ICollection<Sehesabgroupdetail> SehesabgroupdetailIdHpar37Navigations { get; set; } = new List<Sehesabgroupdetail>();

    public virtual ICollection<Sehesabgroupdetail> SehesabgroupdetailIdHpar38Navigations { get; set; } = new List<Sehesabgroupdetail>();

    public virtual ICollection<Sehesabgroupdetail> SehesabgroupdetailIdHpar39Navigations { get; set; } = new List<Sehesabgroupdetail>();

    public virtual ICollection<Sehesabgroupdetail> SehesabgroupdetailIdHpar3Navigations { get; set; } = new List<Sehesabgroupdetail>();

    public virtual ICollection<Sehesabgroupdetail> SehesabgroupdetailIdHpar40Navigations { get; set; } = new List<Sehesabgroupdetail>();

    public virtual ICollection<Sehesabgroupdetail> SehesabgroupdetailIdHpar41Navigations { get; set; } = new List<Sehesabgroupdetail>();

    public virtual ICollection<Sehesabgroupdetail> SehesabgroupdetailIdHpar42Navigations { get; set; } = new List<Sehesabgroupdetail>();

    public virtual ICollection<Sehesabgroupdetail> SehesabgroupdetailIdHpar43Navigations { get; set; } = new List<Sehesabgroupdetail>();

    public virtual ICollection<Sehesabgroupdetail> SehesabgroupdetailIdHpar44Navigations { get; set; } = new List<Sehesabgroupdetail>();

    public virtual ICollection<Sehesabgroupdetail> SehesabgroupdetailIdHpar45Navigations { get; set; } = new List<Sehesabgroupdetail>();

    public virtual ICollection<Sehesabgroupdetail> SehesabgroupdetailIdHpar46Navigations { get; set; } = new List<Sehesabgroupdetail>();

    public virtual ICollection<Sehesabgroupdetail> SehesabgroupdetailIdHpar47Navigations { get; set; } = new List<Sehesabgroupdetail>();

    public virtual ICollection<Sehesabgroupdetail> SehesabgroupdetailIdHpar48Navigations { get; set; } = new List<Sehesabgroupdetail>();

    public virtual ICollection<Sehesabgroupdetail> SehesabgroupdetailIdHpar49Navigations { get; set; } = new List<Sehesabgroupdetail>();

    public virtual ICollection<Sehesabgroupdetail> SehesabgroupdetailIdHpar4Navigations { get; set; } = new List<Sehesabgroupdetail>();

    public virtual ICollection<Sehesabgroupdetail> SehesabgroupdetailIdHpar50Navigations { get; set; } = new List<Sehesabgroupdetail>();

    public virtual ICollection<Sehesabgroupdetail> SehesabgroupdetailIdHpar5Navigations { get; set; } = new List<Sehesabgroupdetail>();

    public virtual ICollection<Sehesabgroupdetail> SehesabgroupdetailIdHpar6Navigations { get; set; } = new List<Sehesabgroupdetail>();

    public virtual ICollection<Sehesabgroupdetail> SehesabgroupdetailIdHpar7Navigations { get; set; } = new List<Sehesabgroupdetail>();

    public virtual ICollection<Sehesabgroupdetail> SehesabgroupdetailIdHpar8Navigations { get; set; } = new List<Sehesabgroupdetail>();

    public virtual ICollection<Sehesabgroupdetail> SehesabgroupdetailIdHpar9Navigations { get; set; } = new List<Sehesabgroupdetail>();
}
