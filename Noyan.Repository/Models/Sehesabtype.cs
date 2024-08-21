using System;
using System.Collections.Generic;

namespace Noyan.Repository.Models;

public partial class Sehesabtype
{
    public byte IdHsbtyp { get; set; }

    public string Name { get; set; } = null!;

    public byte Tartib { get; set; }

    public virtual ICollection<Sehesab> SehesabTypeNavigations { get; set; } = new List<Sehesab>();

    public virtual ICollection<Sehesab> SehesabTypemandehNavigations { get; set; } = new List<Sehesab>();
}
