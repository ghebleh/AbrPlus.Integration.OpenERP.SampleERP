using System;
using System.Collections.Generic;

namespace Noyan.Repository.Models;

public partial class Sefactordetailpallet
{
    public int IdFctplt { get; set; }

    public int IdFctdtl { get; set; }

    public int? HsbdtlPlt { get; set; }

    public int Count { get; set; }

    public decimal Vazn { get; set; }

    public decimal Vazntotal { get; set; }

    public int Radif { get; set; }

    public virtual Sehesabgroupdetail? HsbdtlPltNavigation { get; set; }

    public virtual Sefactordetail IdFctdtlNavigation { get; set; } = null!;
}
