using System;
using System.Collections.Generic;

namespace Noyan.Repository.Models;

public partial class Sehesabgrouptypeconvert
{
    public short IdHsbgT1 { get; set; }

    public short IdHsbgT2 { get; set; }

    public virtual Sehesabgrouptype IdHsbgT1Navigation { get; set; } = null!;

    public virtual Sehesabgrouptype IdHsbgT2Navigation { get; set; } = null!;
}
