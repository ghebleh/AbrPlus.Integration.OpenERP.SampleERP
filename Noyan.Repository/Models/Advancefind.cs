using System;
using System.Collections.Generic;

namespace Noyan.Repository.Models;

public partial class Advancefind
{
    public byte IdFnd { get; set; }

    public string Name { get; set; } = null!;

    public virtual ICollection<Advancefindcolumn> Advancefindcolumns { get; set; } = new List<Advancefindcolumn>();

    public virtual ICollection<Advanceresultfind> Advanceresultfinds { get; set; } = new List<Advanceresultfind>();
}
