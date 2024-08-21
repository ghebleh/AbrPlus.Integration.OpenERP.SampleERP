using System;
using System.Collections.Generic;

namespace Noyan.Repository.Models;

public partial class Seanbothdetail
{
    public int IdAoDtl { get; set; }

    public int IdAnboth { get; set; }

    public byte Detailtype { get; set; }

    public int Radif { get; set; }

    public string RadifS { get; set; } = null!;

    public int? IdAnb { get; set; }

    public byte? IdIoTyp { get; set; }

    public int? HsbKal { get; set; }

    public int? HsbdtlKal { get; set; }

    public string DateKal { get; set; } = null!;

    public string SerialKal { get; set; } = null!;

    public int? HsbdtlPlt { get; set; }

    public decimal CountTot { get; set; }

    public decimal CountPlt { get; set; }

    public decimal Vazn1 { get; set; }

    public int Vazn1Row { get; set; }

    public string Vazn1Date { get; set; } = null!;

    public string Vazn1Time { get; set; } = null!;

    public decimal Vazn2 { get; set; }

    public int Vazn2Row { get; set; }

    public string Vazn2Date { get; set; } = null!;

    public string Vazn2Time { get; set; } = null!;

    public decimal Count { get; set; }

    public decimal Fi { get; set; }

    public decimal? CountR { get; set; }

    public short? IdUnitR { get; set; }

    public decimal? FiR { get; set; }

    public decimal Total1 { get; set; }

    public decimal Takhfif { get; set; }

    public decimal Total2 { get; set; }

    public decimal AfzoodehD { get; set; }

    public decimal Afzoodeh { get; set; }

    public decimal Total { get; set; }

    public string CommRadif { get; set; } = null!;

    public byte CommPrint { get; set; }

    public string Serial { get; set; } = null!;

    public decimal CountM { get; set; }

    public bool AnbShfDtl { get; set; }

    public byte Noprint { get; set; }

    public byte MergeRow { get; set; }

    public bool MergedPrn { get; set; }

    public short MergeSnd { get; set; }

    public bool Noprintunt { get; set; }

    public bool Autoadd { get; set; }

    public bool Autotoulid { get; set; }

    public bool Autobar { get; set; }

    public string MabFormul { get; set; } = null!;

    public short Roundtype { get; set; }

    public byte Roundtype1 { get; set; }

    public byte Roweffect { get; set; }

    public bool Cancelfct { get; set; }

    public decimal DarsadMab { get; set; }

    public virtual Sehesab? HsbKalNavigation { get; set; }

    public virtual Sehesabgroupdetail? HsbdtlKalNavigation { get; set; }

    public virtual Sehesabgroupdetail? HsbdtlPltNavigation { get; set; }

    public virtual Sehesabgroupdetail? IdAnbNavigation { get; set; }

    public virtual Seanboth IdAnbothNavigation { get; set; } = null!;

    public virtual Seiotype? IdIoTypNavigation { get; set; }

    public virtual Sekalaunit? Sekalaunit { get; set; }
}
