using System;
using System.Collections.Generic;

namespace Noyan.Repository.Models;

public partial class Seformtype
{
    public short IdFormtyp { get; set; }

    public string Name { get; set; } = null!;

    public short Tartib { get; set; }

    public string Repfile { get; set; } = null!;

    public string Relfiles { get; set; } = null!;

    public string Repfileinf { get; set; } = null!;

    public virtual ICollection<Seform> Seforms { get; set; } = new List<Seform>();
}
