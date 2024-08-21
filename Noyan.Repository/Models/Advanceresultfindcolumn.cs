using System;
using System.Collections.Generic;

namespace Noyan.Repository.Models;

public partial class Advanceresultfindcolumn
{
    public short IdFndres { get; set; }

    public int IdFndcol { get; set; }

    public short Tartib { get; set; }

    public virtual Advancefindcolumn IdFndcolNavigation { get; set; } = null!;

    public virtual Advanceresultfind IdFndresNavigation { get; set; } = null!;
}
