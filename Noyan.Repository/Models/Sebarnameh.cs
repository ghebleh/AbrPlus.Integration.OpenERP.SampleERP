using System;
using System.Collections.Generic;

namespace Noyan.Repository.Models;

public partial class Sebarnameh
{
    public int IdBar { get; set; }

    public int BarNo { get; set; }

    public int IdForm { get; set; }

    public string Date { get; set; } = null!;

    public string Time { get; set; } = null!;

    public string Maghsad { get; set; } = null!;

    public string MashinNo { get; set; } = null!;

    public int? IdMshtyp { get; set; }

    public int? CtmHsb { get; set; }

    public int? CtmHsbd { get; set; }

    public string CtmDesc { get; set; } = null!;

    public int? IdAnb { get; set; }

    public int? DrvHsb { get; set; }

    public int? DrvHsbd { get; set; }

    public string DrvDesc { get; set; } = null!;

    public decimal Vazn1 { get; set; }

    public decimal Vazn2 { get; set; }

    public decimal? Meghdar { get; set; }

    public int? KalHsb { get; set; }

    public int? KalHsbd { get; set; }

    public decimal KalFi { get; set; }

    public decimal KalMb1 { get; set; }

    public decimal KalTkhFi { get; set; }

    public decimal KalTkh { get; set; }

    public decimal KalAfzD { get; set; }

    public decimal KalAfz { get; set; }

    public decimal KalMb { get; set; }

    public int? BasHsb { get; set; }

    public int? BasHsbd { get; set; }

    public decimal BasFi { get; set; }

    public decimal BasMb1 { get; set; }

    public decimal BasTkhFi { get; set; }

    public decimal BasTkh { get; set; }

    public decimal BasAfzD { get; set; }

    public decimal BasAfz { get; set; }

    public decimal BasMb { get; set; }

    public int? KryHsb { get; set; }

    public int? KryHsbd { get; set; }

    public decimal KryFi { get; set; }

    public decimal KryMb1 { get; set; }

    public decimal KryTkhFi { get; set; }

    public decimal KryTkh { get; set; }

    public decimal KryAfzD { get; set; }

    public decimal KryAfz { get; set; }

    public decimal KryMb { get; set; }

    public decimal RndMb { get; set; }

    public int? RndHsb { get; set; }

    public int? RndHsbd { get; set; }

    public decimal Total { get; set; }

    public decimal DarMb { get; set; }

    public int? DarHsb { get; set; }

    public int? DarHsbd { get; set; }

    public bool Cancel { get; set; }

    public string IndtDa { get; set; } = null!;

    public string IndtTi { get; set; } = null!;

    public string IndtUser { get; set; } = null!;

    public byte IdOk { get; set; }

    public int? IdPeriod { get; set; }

    public string FactNo { get; set; } = null!;

    public int? TrfHsbd { get; set; }

    public decimal MeghdarM { get; set; }

    public byte DrvType { get; set; }

    public decimal DrvFi { get; set; }

    public decimal DrvMb1 { get; set; }

    public decimal DrvTkhFi { get; set; }

    public decimal DrvTkh { get; set; }

    public decimal DrvMb { get; set; }

    public int? KhrHsb { get; set; }

    public int? KhrHsbd { get; set; }

    public decimal KhrMegh { get; set; }

    public decimal KhrFi { get; set; }

    public decimal KhrMb1 { get; set; }

    public bool NewEdit { get; set; }

    public string Comment { get; set; } = null!;

    public bool MergeKb { get; set; }

    public bool MashinNoa { get; set; }

    public decimal PardMb { get; set; }

    public int? PardHsb { get; set; }

    public int? PardHsbd { get; set; }

    public bool Mosalah { get; set; }

    public bool Yakhbandan { get; set; }

    public bool Sayesh { get; set; }

    public string Narmi { get; set; } = null!;

    public string Fazakhali { get; set; } = null!;

    public string Rotoobat { get; set; } = null!;

    public string Shekastegi { get; set; } = null!;

    public int? IdBranch { get; set; }

    public short? IdBrngrp { get; set; }

    public decimal DrvAfzD { get; set; }

    public decimal DrvAfz { get; set; }

    public bool Usefornext { get; set; }

    public string Sangdane { get; set; } = null!;

    public virtual Sehesab? BasHsbNavigation { get; set; }

    public virtual Sehesabgroupdetail? BasHsbdNavigation { get; set; }

    public virtual Sehesab? CtmHsbNavigation { get; set; }

    public virtual Sehesabgroupdetail? CtmHsbdNavigation { get; set; }

    public virtual Sehesab? DarHsbNavigation { get; set; }

    public virtual Sehesabgroupdetail? DarHsbdNavigation { get; set; }

    public virtual Sehesab? DrvHsbNavigation { get; set; }

    public virtual Sehesabgroupdetail? DrvHsbdNavigation { get; set; }

    public virtual Sehesabgroupdetail? IdAnbNavigation { get; set; }

    public virtual Sebranch? IdBranchNavigation { get; set; }

    public virtual Sebranchgroup? IdBrngrpNavigation { get; set; }

    public virtual Seform IdFormNavigation { get; set; } = null!;

    public virtual Sehesabgroupdetail? IdMshtypNavigation { get; set; }

    public virtual Seok IdOkNavigation { get; set; } = null!;

    public virtual Seperiod? IdPeriodNavigation { get; set; }

    public virtual User IndtUserNavigation { get; set; } = null!;

    public virtual Sehesab? KalHsbNavigation { get; set; }

    public virtual Sehesabgroupdetail? KalHsbdNavigation { get; set; }

    public virtual Sehesab? KryHsbNavigation { get; set; }

    public virtual Sehesabgroupdetail? KryHsbdNavigation { get; set; }

    public virtual Sehesab? PardHsbNavigation { get; set; }

    public virtual Sehesabgroupdetail? PardHsbdNavigation { get; set; }

    public virtual Sehesab? RndHsbNavigation { get; set; }

    public virtual Sehesabgroupdetail? RndHsbdNavigation { get; set; }

    public virtual ICollection<Seanboth> Seanboths { get; set; } = new List<Seanboth>();

    public virtual ICollection<SebarnamehMarkaz> SebarnamehMarkazs { get; set; } = new List<SebarnamehMarkaz>();

    public virtual ICollection<Sefactor> Sefactors { get; set; } = new List<Sefactor>();

    public virtual ICollection<Sehvlrsd> Sehvlrsds { get; set; } = new List<Sehvlrsd>();

    public virtual ICollection<Sesanadrow> Sesanadrows { get; set; } = new List<Sesanadrow>();

    public virtual Sehesabgroupdetail? TrfHsbdNavigation { get; set; }
}
