using System;
using System.Collections.Generic;

namespace Noyan.Repository.Models;

public partial class Sefactor
{
    public int IdFactor { get; set; }

    public int IdForm { get; set; }

    public int FactorNo { get; set; }

    public string Date { get; set; } = null!;

    public byte? IdFshtyp { get; set; }

    public string FactNo { get; set; } = null!;

    public int? HsbCtm { get; set; }

    public int? HsbdtlCtm { get; set; }

    public string HsbctmDes { get; set; } = null!;

    public int? HsbdtlAnb { get; set; }

    public int? HsbTo { get; set; }

    public int? HsbdtlTo { get; set; }

    public string CommentTo { get; set; } = null!;

    public decimal Daryaft { get; set; }

    public string Tavasot { get; set; } = null!;

    public int? IdKoshtar { get; set; }

    public string Comment { get; set; } = null!;

    public bool Tasvieh { get; set; }

    public string IndtDa { get; set; } = null!;

    public string IndtTi { get; set; } = null!;

    public string IndtUser { get; set; } = null!;

    public byte BtnMerge1 { get; set; }

    public byte BtnMerge2 { get; set; }

    public byte BtnMerge3 { get; set; }

    public int BtnMerge4 { get; set; }

    public byte BtnAnamfi { get; set; }

    public int? HsbBzr { get; set; }

    public int? HsbdtlBzr { get; set; }

    public string Datetahvil { get; set; } = null!;

    public string Timetahvil { get; set; } = null!;

    public string Adrstahvil { get; set; } = null!;

    public byte IdOk { get; set; }

    public int? IdBar { get; set; }

    public string Sharhsanad { get; set; } = null!;

    public int? IdPeriod { get; set; }

    public bool Sabt { get; set; }

    public bool Sendsms { get; set; }

    public int? IdBranch { get; set; }

    public short? IdBrngrp { get; set; }

    public string? Posinfo { get; set; }

    public byte? TaxFcttyp { get; set; }

    public byte? TaxFcttas { get; set; }

    public byte? TaxStatus { get; set; }

    public string? TaxId { get; set; }

    public string? TaxBillno { get; set; }

    public string? TaxRefno { get; set; }

    public string? TaxErrno { get; set; }

    public string? TaxError { get; set; }

    public Guid? TaxUid { get; set; }

    public string Dateetebar { get; set; } = null!;

    public decimal? TaxNaghd { get; set; }

    public decimal? TaxNasiye { get; set; }

    public decimal? TaxAfzpay { get; set; }

    public DateTime? TaxSentat { get; set; }

    public virtual Sehesab? HsbBzrNavigation { get; set; }

    public virtual Sehesab? HsbCtmNavigation { get; set; }

    public virtual Sehesab? HsbToNavigation { get; set; }

    public virtual Sehesabgroupdetail? HsbdtlAnbNavigation { get; set; }

    public virtual Sehesabgroupdetail? HsbdtlBzrNavigation { get; set; }

    public virtual Sehesabgroupdetail? HsbdtlCtmNavigation { get; set; }

    public virtual Sehesabgroupdetail? HsbdtlToNavigation { get; set; }

    public virtual Sebarnameh? IdBarNavigation { get; set; }

    public virtual Sebranch? IdBranchNavigation { get; set; }

    public virtual Sebranchgroup? IdBrngrpNavigation { get; set; }

    public virtual Seform IdFormNavigation { get; set; } = null!;

    public virtual Seforooshtype? IdFshtypNavigation { get; set; }

    public virtual Sekoshtar? IdKoshtarNavigation { get; set; }

    public virtual Seok IdOkNavigation { get; set; } = null!;

    public virtual Seperiod? IdPeriodNavigation { get; set; }

    public virtual ICollection<Seanboth> Seanboths { get; set; } = new List<Seanboth>();

    public virtual ICollection<Sefactorbazaryab> Sefactorbazaryabs { get; set; } = new List<Sefactorbazaryab>();

    public virtual ICollection<Sefactordetail> Sefactordetails { get; set; } = new List<Sefactordetail>();

    public virtual ICollection<Sefactorsanadrel> Sefactorsanadrels { get; set; } = new List<Sefactorsanadrel>();

    public virtual ICollection<Sehvlrsd> Sehvlrsds { get; set; } = new List<Sehvlrsd>();

    public virtual ICollection<Sesanadrow> Sesanadrows { get; set; } = new List<Sesanadrow>();
}
