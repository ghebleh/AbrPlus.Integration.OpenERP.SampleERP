using System;
using System.Collections.Generic;

namespace Noyan.Repository.Models;

public partial class Secollectiondetail
{
    public int IdColdtl { get; set; }

    public int IdCol { get; set; }

    public int? IdHsb { get; set; }

    public int? IdHsbdtl { get; set; }

    public byte Undertype { get; set; }

    public short Tartib { get; set; }

    public virtual Secollection IdColNavigation { get; set; } = null!;

    public virtual Sehesab? IdHsbNavigation { get; set; }

    public virtual Sehesabgroupdetail? IdHsbdtlNavigation { get; set; }
}
