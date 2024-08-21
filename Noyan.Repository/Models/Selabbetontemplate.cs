using System;
using System.Collections.Generic;

namespace Noyan.Repository.Models;

public partial class Selabbetontemplate
{
    public int IdNemtem { get; set; }

    public string Name { get; set; } = null!;

    public string Detail { get; set; } = null!;

    public byte Tahvildays { get; set; }

    public bool Default { get; set; }

    public virtual ICollection<Selabbetonnemooneh> Selabbetonnemoonehs { get; set; } = new List<Selabbetonnemooneh>();
}
