using System;
using System.Collections.Generic;

namespace Noyan.Repository.Models;

public partial class Semarkaztype
{
    public byte IdMkztyp { get; set; }

    public string Name { get; set; } = null!;

    public byte Tartib { get; set; }

    public virtual ICollection<Semarkaz> Semarkazs { get; set; } = new List<Semarkaz>();
}
