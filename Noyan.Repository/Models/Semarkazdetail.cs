using System;
using System.Collections.Generic;

namespace Noyan.Repository.Models;

public partial class Semarkazdetail
{
    public int IdMkzdtl { get; set; }

    public short IdMkz { get; set; }

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

    public int? ParMkzdtl { get; set; }

    public string StrKey { get; set; } = null!;

    public string StrCode1 { get; set; } = null!;

    public string StrCode2 { get; set; } = null!;

    public virtual Active IdActiveNavigation { get; set; } = null!;

    public virtual Sebank? IdBankNavigation { get; set; }

    public virtual Sebankhesabtype? IdBnkhtypNavigation { get; set; }

    public virtual Secustomertitle? IdCtmtitNavigation { get; set; }

    public virtual Persontype? IdCtmtypNavigation { get; set; }

    public virtual Semarkaz IdMkzNavigation { get; set; } = null!;

    public virtual Sex? IdSexNavigation { get; set; }

    public virtual ICollection<Semarkazdetail> InverseParMkzdtlNavigation { get; set; } = new List<Semarkazdetail>();

    public virtual Semarkazdetail? ParMkzdtlNavigation { get; set; }

    public virtual ICollection<Seaqsat> SeaqsatIdMkzd10Navigations { get; set; } = new List<Seaqsat>();

    public virtual ICollection<Seaqsat> SeaqsatIdMkzd11Navigations { get; set; } = new List<Seaqsat>();

    public virtual ICollection<Seaqsat> SeaqsatIdMkzd12Navigations { get; set; } = new List<Seaqsat>();

    public virtual ICollection<Seaqsat> SeaqsatIdMkzd13Navigations { get; set; } = new List<Seaqsat>();

    public virtual ICollection<Seaqsat> SeaqsatIdMkzd14Navigations { get; set; } = new List<Seaqsat>();

    public virtual ICollection<Seaqsat> SeaqsatIdMkzd15Navigations { get; set; } = new List<Seaqsat>();

    public virtual ICollection<Seaqsat> SeaqsatIdMkzd16Navigations { get; set; } = new List<Seaqsat>();

    public virtual ICollection<Seaqsat> SeaqsatIdMkzd17Navigations { get; set; } = new List<Seaqsat>();

    public virtual ICollection<Seaqsat> SeaqsatIdMkzd18Navigations { get; set; } = new List<Seaqsat>();

    public virtual ICollection<Seaqsat> SeaqsatIdMkzd19Navigations { get; set; } = new List<Seaqsat>();

    public virtual ICollection<Seaqsat> SeaqsatIdMkzd1Navigations { get; set; } = new List<Seaqsat>();

    public virtual ICollection<Seaqsat> SeaqsatIdMkzd20Navigations { get; set; } = new List<Seaqsat>();

    public virtual ICollection<Seaqsat> SeaqsatIdMkzd2Navigations { get; set; } = new List<Seaqsat>();

    public virtual ICollection<Seaqsat> SeaqsatIdMkzd3Navigations { get; set; } = new List<Seaqsat>();

    public virtual ICollection<Seaqsat> SeaqsatIdMkzd4Navigations { get; set; } = new List<Seaqsat>();

    public virtual ICollection<Seaqsat> SeaqsatIdMkzd5Navigations { get; set; } = new List<Seaqsat>();

    public virtual ICollection<Seaqsat> SeaqsatIdMkzd6Navigations { get; set; } = new List<Seaqsat>();

    public virtual ICollection<Seaqsat> SeaqsatIdMkzd7Navigations { get; set; } = new List<Seaqsat>();

    public virtual ICollection<Seaqsat> SeaqsatIdMkzd8Navigations { get; set; } = new List<Seaqsat>();

    public virtual ICollection<Seaqsat> SeaqsatIdMkzd9Navigations { get; set; } = new List<Seaqsat>();

    public virtual ICollection<SebarnamehMarkaz> SebarnamehMarkazIdMkzd10Navigations { get; set; } = new List<SebarnamehMarkaz>();

    public virtual ICollection<SebarnamehMarkaz> SebarnamehMarkazIdMkzd11Navigations { get; set; } = new List<SebarnamehMarkaz>();

    public virtual ICollection<SebarnamehMarkaz> SebarnamehMarkazIdMkzd12Navigations { get; set; } = new List<SebarnamehMarkaz>();

    public virtual ICollection<SebarnamehMarkaz> SebarnamehMarkazIdMkzd13Navigations { get; set; } = new List<SebarnamehMarkaz>();

    public virtual ICollection<SebarnamehMarkaz> SebarnamehMarkazIdMkzd14Navigations { get; set; } = new List<SebarnamehMarkaz>();

    public virtual ICollection<SebarnamehMarkaz> SebarnamehMarkazIdMkzd15Navigations { get; set; } = new List<SebarnamehMarkaz>();

    public virtual ICollection<SebarnamehMarkaz> SebarnamehMarkazIdMkzd16Navigations { get; set; } = new List<SebarnamehMarkaz>();

    public virtual ICollection<SebarnamehMarkaz> SebarnamehMarkazIdMkzd17Navigations { get; set; } = new List<SebarnamehMarkaz>();

    public virtual ICollection<SebarnamehMarkaz> SebarnamehMarkazIdMkzd18Navigations { get; set; } = new List<SebarnamehMarkaz>();

    public virtual ICollection<SebarnamehMarkaz> SebarnamehMarkazIdMkzd19Navigations { get; set; } = new List<SebarnamehMarkaz>();

    public virtual ICollection<SebarnamehMarkaz> SebarnamehMarkazIdMkzd1Navigations { get; set; } = new List<SebarnamehMarkaz>();

    public virtual ICollection<SebarnamehMarkaz> SebarnamehMarkazIdMkzd20Navigations { get; set; } = new List<SebarnamehMarkaz>();

    public virtual ICollection<SebarnamehMarkaz> SebarnamehMarkazIdMkzd2Navigations { get; set; } = new List<SebarnamehMarkaz>();

    public virtual ICollection<SebarnamehMarkaz> SebarnamehMarkazIdMkzd3Navigations { get; set; } = new List<SebarnamehMarkaz>();

    public virtual ICollection<SebarnamehMarkaz> SebarnamehMarkazIdMkzd4Navigations { get; set; } = new List<SebarnamehMarkaz>();

    public virtual ICollection<SebarnamehMarkaz> SebarnamehMarkazIdMkzd5Navigations { get; set; } = new List<SebarnamehMarkaz>();

    public virtual ICollection<SebarnamehMarkaz> SebarnamehMarkazIdMkzd6Navigations { get; set; } = new List<SebarnamehMarkaz>();

    public virtual ICollection<SebarnamehMarkaz> SebarnamehMarkazIdMkzd7Navigations { get; set; } = new List<SebarnamehMarkaz>();

    public virtual ICollection<SebarnamehMarkaz> SebarnamehMarkazIdMkzd8Navigations { get; set; } = new List<SebarnamehMarkaz>();

    public virtual ICollection<SebarnamehMarkaz> SebarnamehMarkazIdMkzd9Navigations { get; set; } = new List<SebarnamehMarkaz>();

    public virtual ICollection<Sesanadrow> SesanadrowIdMkzd10Navigations { get; set; } = new List<Sesanadrow>();

    public virtual ICollection<Sesanadrow> SesanadrowIdMkzd11Navigations { get; set; } = new List<Sesanadrow>();

    public virtual ICollection<Sesanadrow> SesanadrowIdMkzd12Navigations { get; set; } = new List<Sesanadrow>();

    public virtual ICollection<Sesanadrow> SesanadrowIdMkzd13Navigations { get; set; } = new List<Sesanadrow>();

    public virtual ICollection<Sesanadrow> SesanadrowIdMkzd14Navigations { get; set; } = new List<Sesanadrow>();

    public virtual ICollection<Sesanadrow> SesanadrowIdMkzd15Navigations { get; set; } = new List<Sesanadrow>();

    public virtual ICollection<Sesanadrow> SesanadrowIdMkzd16Navigations { get; set; } = new List<Sesanadrow>();

    public virtual ICollection<Sesanadrow> SesanadrowIdMkzd17Navigations { get; set; } = new List<Sesanadrow>();

    public virtual ICollection<Sesanadrow> SesanadrowIdMkzd18Navigations { get; set; } = new List<Sesanadrow>();

    public virtual ICollection<Sesanadrow> SesanadrowIdMkzd19Navigations { get; set; } = new List<Sesanadrow>();

    public virtual ICollection<Sesanadrow> SesanadrowIdMkzd1Navigations { get; set; } = new List<Sesanadrow>();

    public virtual ICollection<Sesanadrow> SesanadrowIdMkzd20Navigations { get; set; } = new List<Sesanadrow>();

    public virtual ICollection<Sesanadrow> SesanadrowIdMkzd2Navigations { get; set; } = new List<Sesanadrow>();

    public virtual ICollection<Sesanadrow> SesanadrowIdMkzd3Navigations { get; set; } = new List<Sesanadrow>();

    public virtual ICollection<Sesanadrow> SesanadrowIdMkzd4Navigations { get; set; } = new List<Sesanadrow>();

    public virtual ICollection<Sesanadrow> SesanadrowIdMkzd5Navigations { get; set; } = new List<Sesanadrow>();

    public virtual ICollection<Sesanadrow> SesanadrowIdMkzd6Navigations { get; set; } = new List<Sesanadrow>();

    public virtual ICollection<Sesanadrow> SesanadrowIdMkzd7Navigations { get; set; } = new List<Sesanadrow>();

    public virtual ICollection<Sesanadrow> SesanadrowIdMkzd8Navigations { get; set; } = new List<Sesanadrow>();

    public virtual ICollection<Sesanadrow> SesanadrowIdMkzd9Navigations { get; set; } = new List<Sesanadrow>();
}
