using System;
using System.Collections.Generic;

namespace Noyan.Repository.Models;

public partial class Seiotype
{
    public byte IdIoTyp { get; set; }

    public string Name { get; set; } = null!;

    public byte Tartib { get; set; }

    public byte Io { get; set; }

    public virtual ICollection<Seanbothdetail> Seanbothdetails { get; set; } = new List<Seanbothdetail>();

    public virtual ICollection<Sehvlrsddetail> Sehvlrsddetails { get; set; } = new List<Sehvlrsddetail>();
}
