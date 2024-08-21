using System;
using System.Collections.Generic;

namespace Noyan.Repository.Models;

public partial class Sehesab
{
    public int IdHsb { get; set; }

    public short? IdHsbgrp { get; set; }

    public decimal? Code { get; set; }

    public string? Name { get; set; }

    public int? ParentHsb { get; set; }

    public byte IdActive { get; set; }

    public bool Enteghal { get; set; }

    public byte Type { get; set; }

    public byte Typemandeh { get; set; }

    public string NaBefore { get; set; } = null!;

    public string NaAfter { get; set; } = null!;

    public string IndtDa { get; set; } = null!;

    public string IndtTi { get; set; } = null!;

    public int? IdHpar1 { get; set; }

    public int? IdHpar2 { get; set; }

    public int? IdHpar3 { get; set; }

    public int? IdHpar4 { get; set; }

    public int? IdHpar5 { get; set; }

    public int? IdHpar6 { get; set; }

    public int? IdHpar7 { get; set; }

    public int? IdHpar8 { get; set; }

    public int? IdHpar9 { get; set; }

    public int? IdHpar10 { get; set; }

    public int? IdHpar11 { get; set; }

    public int? IdHpar12 { get; set; }

    public int? IdHpar13 { get; set; }

    public int? IdHpar14 { get; set; }

    public int? IdHpar15 { get; set; }

    public int? IdHpar16 { get; set; }

    public int? IdHpar17 { get; set; }

    public int? IdHpar18 { get; set; }

    public int? IdHpar19 { get; set; }

    public int? IdHpar20 { get; set; }

    public int? IdHpar21 { get; set; }

    public int? IdHpar22 { get; set; }

    public int? IdHpar23 { get; set; }

    public int? IdHpar24 { get; set; }

    public int? IdHpar25 { get; set; }

    public int? IdHpar26 { get; set; }

    public int? IdHpar27 { get; set; }

    public int? IdHpar28 { get; set; }

    public int? IdHpar29 { get; set; }

    public int? IdHpar30 { get; set; }

    public int? IdHpar31 { get; set; }

    public int? IdHpar32 { get; set; }

    public int? IdHpar33 { get; set; }

    public int? IdHpar34 { get; set; }

    public int? IdHpar35 { get; set; }

    public int? IdHpar36 { get; set; }

    public int? IdHpar37 { get; set; }

    public int? IdHpar38 { get; set; }

    public int? IdHpar39 { get; set; }

    public int? IdHpar40 { get; set; }

    public int? IdHpar41 { get; set; }

    public int? IdHpar42 { get; set; }

    public int? IdHpar43 { get; set; }

    public int? IdHpar44 { get; set; }

    public int? IdHpar45 { get; set; }

    public int? IdHpar46 { get; set; }

    public int? IdHpar47 { get; set; }

    public int? IdHpar48 { get; set; }

    public int? IdHpar49 { get; set; }

    public int? IdHpar50 { get; set; }

    public string? VaHpar501 { get; set; }

    public string? VaHpar502 { get; set; }

    public string? VaHpar503 { get; set; }

    public string? VaHpar504 { get; set; }

    public string? VaHpar505 { get; set; }

    public string? VaHpar506 { get; set; }

    public string? VaHpar507 { get; set; }

    public string? VaHpar508 { get; set; }

    public string? VaHpar509 { get; set; }

    public string? VaHpar510 { get; set; }

    public string? VaHpar511 { get; set; }

    public string? VaHpar512 { get; set; }

    public string? VaHpar513 { get; set; }

    public string? VaHpar514 { get; set; }

    public string? VaHpar515 { get; set; }

    public string? VaHpar516 { get; set; }

    public string? VaHpar517 { get; set; }

    public string? VaHpar518 { get; set; }

    public string? VaHpar519 { get; set; }

    public string? VaHpar520 { get; set; }

    public string? VaHpar521 { get; set; }

    public string? VaHpar522 { get; set; }

    public string? VaHpar523 { get; set; }

    public string? VaHpar524 { get; set; }

    public string? VaHpar525 { get; set; }

    public string? VaHpar526 { get; set; }

    public string? VaHpar527 { get; set; }

    public string? VaHpar528 { get; set; }

    public string? VaHpar529 { get; set; }

    public string? VaHpar530 { get; set; }

    public string? VaHpar531 { get; set; }

    public string? VaHpar532 { get; set; }

    public string? VaHpar533 { get; set; }

    public string? VaHpar534 { get; set; }

    public string? VaHpar535 { get; set; }

    public string? VaHpar536 { get; set; }

    public string? VaHpar537 { get; set; }

    public string? VaHpar538 { get; set; }

    public string? VaHpar539 { get; set; }

    public string? VaHpar540 { get; set; }

    public string? VaHpar541 { get; set; }

    public string? VaHpar542 { get; set; }

    public string? VaHpar543 { get; set; }

    public string? VaHpar544 { get; set; }

    public string? VaHpar545 { get; set; }

    public string? VaHpar546 { get; set; }

    public string? VaHpar547 { get; set; }

    public string? VaHpar548 { get; set; }

    public string? VaHpar549 { get; set; }

    public string? VaHpar550 { get; set; }

    public string KeyStr { get; set; } = null!;

    public string CodeHsb { get; set; } = null!;

    public string NameComp { get; set; } = null!;

    public bool Aqsat { get; set; }

    public bool Forceaqsat { get; set; }

    public int? IdHsbd { get; set; }

    public virtual Active IdActiveNavigation { get; set; } = null!;

    public virtual Sehesabparametersdetail? IdHpar10Navigation { get; set; }

    public virtual Sehesabparametersdetail? IdHpar11Navigation { get; set; }

    public virtual Sehesabparametersdetail? IdHpar12Navigation { get; set; }

    public virtual Sehesabparametersdetail? IdHpar13Navigation { get; set; }

    public virtual Sehesabparametersdetail? IdHpar14Navigation { get; set; }

    public virtual Sehesabparametersdetail? IdHpar15Navigation { get; set; }

    public virtual Sehesabparametersdetail? IdHpar16Navigation { get; set; }

    public virtual Sehesabparametersdetail? IdHpar17Navigation { get; set; }

    public virtual Sehesabparametersdetail? IdHpar18Navigation { get; set; }

    public virtual Sehesabparametersdetail? IdHpar19Navigation { get; set; }

    public virtual Sehesabparametersdetail? IdHpar1Navigation { get; set; }

    public virtual Sehesabparametersdetail? IdHpar20Navigation { get; set; }

    public virtual Sehesabparametersdetail? IdHpar21Navigation { get; set; }

    public virtual Sehesabparametersdetail? IdHpar22Navigation { get; set; }

    public virtual Sehesabparametersdetail? IdHpar23Navigation { get; set; }

    public virtual Sehesabparametersdetail? IdHpar24Navigation { get; set; }

    public virtual Sehesabparametersdetail? IdHpar25Navigation { get; set; }

    public virtual Sehesabparametersdetail? IdHpar26Navigation { get; set; }

    public virtual Sehesabparametersdetail? IdHpar27Navigation { get; set; }

    public virtual Sehesabparametersdetail? IdHpar28Navigation { get; set; }

    public virtual Sehesabparametersdetail? IdHpar29Navigation { get; set; }

    public virtual Sehesabparametersdetail? IdHpar2Navigation { get; set; }

    public virtual Sehesabparametersdetail? IdHpar30Navigation { get; set; }

    public virtual Sehesabparametersdetail? IdHpar31Navigation { get; set; }

    public virtual Sehesabparametersdetail? IdHpar32Navigation { get; set; }

    public virtual Sehesabparametersdetail? IdHpar33Navigation { get; set; }

    public virtual Sehesabparametersdetail? IdHpar34Navigation { get; set; }

    public virtual Sehesabparametersdetail? IdHpar35Navigation { get; set; }

    public virtual Sehesabparametersdetail? IdHpar36Navigation { get; set; }

    public virtual Sehesabparametersdetail? IdHpar37Navigation { get; set; }

    public virtual Sehesabparametersdetail? IdHpar38Navigation { get; set; }

    public virtual Sehesabparametersdetail? IdHpar39Navigation { get; set; }

    public virtual Sehesabparametersdetail? IdHpar3Navigation { get; set; }

    public virtual Sehesabparametersdetail? IdHpar40Navigation { get; set; }

    public virtual Sehesabparametersdetail? IdHpar41Navigation { get; set; }

    public virtual Sehesabparametersdetail? IdHpar42Navigation { get; set; }

    public virtual Sehesabparametersdetail? IdHpar43Navigation { get; set; }

    public virtual Sehesabparametersdetail? IdHpar44Navigation { get; set; }

    public virtual Sehesabparametersdetail? IdHpar45Navigation { get; set; }

    public virtual Sehesabparametersdetail? IdHpar46Navigation { get; set; }

    public virtual Sehesabparametersdetail? IdHpar47Navigation { get; set; }

    public virtual Sehesabparametersdetail? IdHpar48Navigation { get; set; }

    public virtual Sehesabparametersdetail? IdHpar49Navigation { get; set; }

    public virtual Sehesabparametersdetail? IdHpar4Navigation { get; set; }

    public virtual Sehesabparametersdetail? IdHpar50Navigation { get; set; }

    public virtual Sehesabparametersdetail? IdHpar5Navigation { get; set; }

    public virtual Sehesabparametersdetail? IdHpar6Navigation { get; set; }

    public virtual Sehesabparametersdetail? IdHpar7Navigation { get; set; }

    public virtual Sehesabparametersdetail? IdHpar8Navigation { get; set; }

    public virtual Sehesabparametersdetail? IdHpar9Navigation { get; set; }

    public virtual Sehesabgroupdetail? IdHsbdNavigation { get; set; }

    public virtual Sehesabgroup? IdHsbgrpNavigation { get; set; }

    public virtual ICollection<Sehesab> InverseParentHsbNavigation { get; set; } = new List<Sehesab>();

    public virtual Sehesab? ParentHsbNavigation { get; set; }

    public virtual ICollection<Seanbothdetail> Seanbothdetails { get; set; } = new List<Seanbothdetail>();

    public virtual ICollection<Seanboth> Seanboths { get; set; } = new List<Seanboth>();

    public virtual ICollection<Seaqsat> Seaqsats { get; set; } = new List<Seaqsat>();

    public virtual ICollection<Sebarnameh> SebarnamehBasHsbNavigations { get; set; } = new List<Sebarnameh>();

    public virtual ICollection<Sebarnameh> SebarnamehCtmHsbNavigations { get; set; } = new List<Sebarnameh>();

    public virtual ICollection<Sebarnameh> SebarnamehDarHsbNavigations { get; set; } = new List<Sebarnameh>();

    public virtual ICollection<Sebarnameh> SebarnamehDrvHsbNavigations { get; set; } = new List<Sebarnameh>();

    public virtual ICollection<Sebarnameh> SebarnamehKalHsbNavigations { get; set; } = new List<Sebarnameh>();

    public virtual ICollection<Sebarnameh> SebarnamehKryHsbNavigations { get; set; } = new List<Sebarnameh>();

    public virtual ICollection<Sebarnameh> SebarnamehPardHsbNavigations { get; set; } = new List<Sebarnameh>();

    public virtual ICollection<Sebarnameh> SebarnamehRndHsbNavigations { get; set; } = new List<Sebarnameh>();

    public virtual ICollection<Sebeton> SebetonBtnHsbNavigations { get; set; } = new List<Sebeton>();

    public virtual ICollection<Sebeton> SebetonBzrHsbNavigations { get; set; } = new List<Sebeton>();

    public virtual ICollection<Sebeton> SebetonCtmHsbNavigations { get; set; } = new List<Sebeton>();

    public virtual ICollection<Sebeton> SebetonKhrHsbNavigations { get; set; } = new List<Sebeton>();

    public virtual ICollection<Sebeton> SebetonKrnHsbNavigations { get; set; } = new List<Sebeton>();

    public virtual ICollection<Sebeton> SebetonMixHsbNavigations { get; set; } = new List<Sebeton>();

    public virtual ICollection<Sebeton> SebetonTkhHsbNavigations { get; set; } = new List<Sebeton>();

    public virtual ICollection<Sebeton> SebetonTknHsbNavigations { get; set; } = new List<Sebeton>();

    public virtual ICollection<Secollectiondetail> Secollectiondetails { get; set; } = new List<Secollectiondetail>();

    public virtual ICollection<Sefactor> SefactorHsbBzrNavigations { get; set; } = new List<Sefactor>();

    public virtual ICollection<Sefactor> SefactorHsbCtmNavigations { get; set; } = new List<Sefactor>();

    public virtual ICollection<Sefactor> SefactorHsbToNavigations { get; set; } = new List<Sefactor>();

    public virtual ICollection<Sefactorbazaryab> SefactorbazaryabHsbBzrNavigations { get; set; } = new List<Sefactorbazaryab>();

    public virtual ICollection<Sefactorbazaryab> SefactorbazaryabHsbTrfNavigations { get; set; } = new List<Sefactorbazaryab>();

    public virtual ICollection<Sefactordetail> Sefactordetails { get; set; } = new List<Sefactordetail>();

    public virtual ICollection<Seformshesab> Seformshesabs { get; set; } = new List<Seformshesab>();

    public virtual ICollection<Sehesabgroupdetail> Sehesabgroupdetails { get; set; } = new List<Sehesabgroupdetail>();

    public virtual ICollection<Sehvlrsddetail> Sehvlrsddetails { get; set; } = new List<Sehvlrsddetail>();

    public virtual ICollection<Sehvlrsd> Sehvlrsds { get; set; } = new List<Sehvlrsd>();

    public virtual ICollection<Selabbetonnemooneh> Selabbetonnemoonehs { get; set; } = new List<Selabbetonnemooneh>();

    public virtual ICollection<Sesanadrow> Sesanadrows { get; set; } = new List<Sesanadrow>();

    public virtual Sehesabtype TypeNavigation { get; set; } = null!;

    public virtual Sehesabtype TypemandehNavigation { get; set; } = null!;
}
