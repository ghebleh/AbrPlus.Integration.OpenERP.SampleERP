using System;
using System.Collections.Generic;

namespace Noyan.Repository.Models;

public partial class Sefactorrel
{
    public int? IdFactor { get; set; }

    public int? IdFactorr { get; set; }

    public string? IndtUser { get; set; }

    public string? Date { get; set; }

    public string? Time { get; set; }

    public virtual Sefactor? IdFactorNavigation { get; set; }

    public virtual Sefactor? IdFactorrNavigation { get; set; }

    public virtual User? IndtUserNavigation { get; set; }
}
