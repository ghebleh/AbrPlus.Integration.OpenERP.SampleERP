using System;
using System.Collections.Generic;

namespace Noyan.Repository.Models;

public partial class Seanboth
{
    public int IdAnboth { get; set; }

    public int? IdBranch { get; set; }

    public short? IdBrngrp { get; set; }

    public int? IdPeriod { get; set; }

    public int IdForm { get; set; }

    public short RoozRadif { get; set; }

    public int AnbothNo { get; set; }

    public string Date { get; set; } = null!;

    public string DateroozS { get; set; } = null!;

    public int? IdAoRel { get; set; }

    public int? IdHrRel { get; set; }

    public string FactNo { get; set; } = null!;

    public int? HsbdtlTrf { get; set; }

    public int? HsbCtm { get; set; }

    public int? HsbdtlCtm { get; set; }

    public string HsbctmDes { get; set; } = null!;

    public string Todate { get; set; } = null!;

    public int? IdKoshtar { get; set; }

    public string Comment { get; set; } = null!;

    public string Sharhsanad { get; set; } = null!;

    public int? IdFactor { get; set; }

    public int? IdBar { get; set; }

    public string Dahandeh { get; set; } = null!;

    public string Girandeh { get; set; } = null!;

    public int? HsbdtlDrv { get; set; }

    public string MachineNo { get; set; } = null!;

    public decimal CountM { get; set; }

    public decimal Vazn34 { get; set; }

    public decimal Vazn3 { get; set; }

    public int Vazn3Row { get; set; }

    public string Vazn3Date { get; set; } = null!;

    public string Vazn3Time { get; set; } = null!;

    public decimal Vazn4 { get; set; }

    public int Vazn4Row { get; set; }

    public string Vazn4Date { get; set; } = null!;

    public string Vazn4Time { get; set; } = null!;

    public string BarNo { get; set; } = null!;

    public string Sharh { get; set; } = null!;

    public bool Sabt { get; set; }

    public bool Tshbymegh { get; set; }

    public string IndtDa { get; set; } = null!;

    public string IndtTi { get; set; } = null!;

    public string IndtUser { get; set; } = null!;

    public byte IdOk { get; set; }

    public bool AutoEf { get; set; }

    public virtual Sehesab? HsbCtmNavigation { get; set; }

    public virtual Sehesabgroupdetail? HsbdtlCtmNavigation { get; set; }

    public virtual Sehesabgroupdetail? HsbdtlDrvNavigation { get; set; }

    public virtual Sehesabgroupdetail? HsbdtlTrfNavigation { get; set; }

    public virtual Seanboth? IdAoRelNavigation { get; set; }

    public virtual Sebarnameh? IdBarNavigation { get; set; }

    public virtual Sebranch? IdBranchNavigation { get; set; }

    public virtual Sebranchgroup? IdBrngrpNavigation { get; set; }

    public virtual Sefactor? IdFactorNavigation { get; set; }

    public virtual Seform IdFormNavigation { get; set; } = null!;

    public virtual Sehvlrsd? IdHrRelNavigation { get; set; }

    public virtual Sekoshtar? IdKoshtarNavigation { get; set; }

    public virtual Seok IdOkNavigation { get; set; } = null!;

    public virtual Seperiod? IdPeriodNavigation { get; set; }

    public virtual ICollection<Seanboth> InverseIdAoRelNavigation { get; set; } = new List<Seanboth>();

    public virtual ICollection<Seanbothdetail> Seanbothdetails { get; set; } = new List<Seanbothdetail>();

    public virtual ICollection<Sehvlrsd> Sehvlrsds { get; set; } = new List<Sehvlrsd>();
}
