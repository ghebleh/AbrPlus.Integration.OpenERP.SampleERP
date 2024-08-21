using System;
using System.Collections.Generic;

namespace Noyan.Repository.Models;

public partial class Sefactorbeton
{
    public int IdFactor { get; set; }

    public int IdBeton { get; set; }

    public int Radif { get; set; }

    public virtual Sebeton IdBetonNavigation { get; set; } = null!;

    public virtual Sefactor IdFactorNavigation { get; set; } = null!;
}
