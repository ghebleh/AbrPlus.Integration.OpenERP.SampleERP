using System;
using System.Collections.Generic;

namespace Noyan.Repository.Models;

public partial class Sesanadvajhtype
{
    public byte IdVajhtyp { get; set; }

    public string Name { get; set; } = null!;

    public byte Tartib { get; set; }

    public virtual ICollection<Seform> Seforms { get; set; } = new List<Seform>();

    public virtual ICollection<Sesanadvajh> Sesanadvajhs { get; set; } = new List<Sesanadvajh>();
}
