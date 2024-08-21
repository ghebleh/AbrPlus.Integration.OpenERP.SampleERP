using System;
using System.Collections.Generic;

namespace Noyan.Repository.Models;

public partial class Sefactorbazaryab
{
    public int IdFctbzr { get; set; }

    public int IdFactor { get; set; }

    public int HsbBzr { get; set; }

    public int? HsbdtlBzr { get; set; }

    public int? HsbTrf { get; set; }

    public int? HsbdtlTrf { get; set; }

    public byte Calctype { get; set; }

    public decimal Darsad { get; set; }

    public int Mablagh { get; set; }

    public string Comment { get; set; } = null!;

    public byte Tartib { get; set; }

    public bool Autoadd { get; set; }

    public string IndtUser { get; set; } = null!;

    public string IndtDa { get; set; } = null!;

    public string IndtTi { get; set; } = null!;

    public virtual Sehesab HsbBzrNavigation { get; set; } = null!;

    public virtual Sehesab? HsbTrfNavigation { get; set; }

    public virtual Sehesabgroupdetail? HsbdtlBzrNavigation { get; set; }

    public virtual Sehesabgroupdetail? HsbdtlTrfNavigation { get; set; }

    public virtual Sefactor IdFactorNavigation { get; set; } = null!;

    public virtual ICollection<Sesanadrow> Sesanadrows { get; set; } = new List<Sesanadrow>();
}
