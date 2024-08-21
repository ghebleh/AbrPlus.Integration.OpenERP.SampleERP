using System;
using System.Collections.Generic;

namespace Noyan.Repository.Models;

public partial class Selabbetonnemooneh
{
    public int IdNem { get; set; }

    public int IdForm { get; set; }

    public int? IdBeton { get; set; }

    public string Date { get; set; } = null!;

    public int? IdNemtem { get; set; }

    public int Prnvaziat { get; set; }

    public string? IndtUser { get; set; }

    public string IndtDate { get; set; } = null!;

    public string IndtTime { get; set; } = null!;

    public byte Type { get; set; }

    public int? BetonNo { get; set; }

    public int? CtmHsb { get; set; }

    public int? CtmHsbd { get; set; }

    public string? BtnDate { get; set; }

    public string? BtnTime { get; set; }

    public decimal? BtnMeter { get; set; }

    public short? BtnAyar { get; set; }

    public int? MsfHsbd { get; set; }

    public int? SmnHsbd { get; set; }

    public int? MogHsbd { get; set; }

    public string? TempWater { get; set; }

    public string? TempBeton { get; set; }

    public string? TempMohit { get; set; }

    public string? Eslamp { get; set; }

    public string? Maghsad { get; set; }

    public decimal? SimanV { get; set; }

    public string? SimanM { get; set; }

    public decimal? ShenV { get; set; }

    public string? ShenM { get; set; }

    public decimal? MasehV { get; set; }

    public string? MasehM { get; set; }

    public decimal? WaterV { get; set; }

    public string? Afz1Name { get; set; }

    public decimal? Afz1Vazn { get; set; }

    public string? Afz1Karkh { get; set; }

    public string? Afz1Code { get; set; }

    public string? Afz2Name { get; set; }

    public decimal? Afz2Vazn { get; set; }

    public string? Afz2Karkh { get; set; }

    public string? Afz2Code { get; set; }

    public string? Eskelet { get; set; }

    public int? PosHsbdtl { get; set; }

    public string? PosDesc { get; set; }

    public string? NaImage { get; set; }

    public decimal? ProjArea { get; set; }

    public byte? Floorcount { get; set; }

    public string? Contractor { get; set; }

    public string Malek { get; set; } = null!;

    public string Pelak { get; set; } = null!;

    public string Nazer { get; set; } = null!;

    public string Manteghe { get; set; } = null!;

    public string Parvane { get; set; } = null!;

    public string Mobilebo { get; set; } = null!;

    public bool Sendsms { get; set; }

    public int? IdSms { get; set; }

    public string Descrip { get; set; } = null!;

    public virtual Sehesab? CtmHsbNavigation { get; set; }

    public virtual Sehesabgroupdetail? CtmHsbdNavigation { get; set; }

    public virtual Sebeton? IdBetonNavigation { get; set; }

    public virtual Seform IdFormNavigation { get; set; } = null!;

    public virtual Selabbetontemplate? IdNemtemNavigation { get; set; }

    public virtual Sm? IdSmsNavigation { get; set; }

    public virtual User? IndtUserNavigation { get; set; }

    public virtual Sehesabgroupdetail? MogHsbdNavigation { get; set; }

    public virtual Sehesabgroupdetail? MsfHsbdNavigation { get; set; }

    public virtual Sehesabgroupdetail? PosHsbdtlNavigation { get; set; }

    public virtual ICollection<Selabbetonazmooneh> Selabbetonazmoonehs { get; set; } = new List<Selabbetonazmooneh>();

    public virtual ICollection<Selabbetonnemoonehprint> Selabbetonnemoonehprints { get; set; } = new List<Selabbetonnemoonehprint>();

    public virtual Sehesabgroupdetail? SmnHsbdNavigation { get; set; }
}
