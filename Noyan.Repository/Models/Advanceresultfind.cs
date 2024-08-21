using System;
using System.Collections.Generic;

namespace Noyan.Repository.Models;

public partial class Advanceresultfind
{
    public short IdFndres { get; set; }

    public string Name { get; set; } = null!;

    public byte? IdFnd { get; set; }

    public byte Type { get; set; }

    public byte Tartib { get; set; }

    public string Fields { get; set; } = null!;

    public string Where { get; set; } = null!;

    public string Order { get; set; } = null!;

    public byte Fixedcols { get; set; }

    public string Execommand { get; set; } = null!;

    public string Returnval { get; set; } = null!;

    public string Idfields { get; set; } = null!;

    public virtual ICollection<Advanceresultfindused> Advanceresultfinduseds { get; set; } = new List<Advanceresultfindused>();

    public virtual Advancefind? IdFndNavigation { get; set; }
}
