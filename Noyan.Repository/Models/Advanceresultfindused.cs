using System;
using System.Collections.Generic;

namespace Noyan.Repository.Models;

public partial class Advanceresultfindused
{
    public byte Type { get; set; }

    public string? IdUser { get; set; }

    public short IdFndres { get; set; }

    public int IdFndsav { get; set; }

    public string Descrip { get; set; } = null!;

    public string Condition { get; set; } = null!;

    public virtual Advanceresultfind IdFndresNavigation { get; set; } = null!;

    public virtual User? IdUserNavigation { get; set; }
}
