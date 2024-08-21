using System;
using System.Collections.Generic;

namespace Noyan.Repository.Models;

public partial class Sekalaunit
{
    public int IdHsbdtl { get; set; }

    public short IdUnit { get; set; }

    public decimal? Zarib { get; set; }

    public byte Tartib { get; set; }

    public virtual Sehesabgroupdetail IdHsbdtlNavigation { get; set; } = null!;

    public virtual Seunit IdUnitNavigation { get; set; } = null!;

    public virtual ICollection<Seanbothdetail> Seanbothdetails { get; set; } = new List<Seanbothdetail>();

    public virtual ICollection<Sefactordetail> Sefactordetails { get; set; } = new List<Sefactordetail>();

    public virtual ICollection<Sehvlrsddetail> Sehvlrsddetails { get; set; } = new List<Sehvlrsddetail>();
}
