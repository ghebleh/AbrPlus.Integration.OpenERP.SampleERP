using System;
using System.Collections.Generic;

namespace Noyan.Repository.Models;

public partial class Sehesabgrouptype
{
    public short IdHsbgtyp { get; set; }

    public string Name { get; set; } = null!;

    public short Tartib { get; set; }

    public virtual ICollection<Sehesabgroup> Sehesabgroups { get; set; } = new List<Sehesabgroup>();
}
