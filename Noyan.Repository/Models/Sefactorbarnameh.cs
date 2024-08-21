using System;
using System.Collections.Generic;

namespace Noyan.Repository.Models;

public partial class Sefactorbarnameh
{
    public int IdFactor { get; set; }

    public int IdBar { get; set; }

    public int Radif { get; set; }

    public virtual Sebarnameh IdBarNavigation { get; set; } = null!;

    public virtual Sefactor IdFactorNavigation { get; set; } = null!;
}
