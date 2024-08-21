using System;
using System.Collections.Generic;

namespace Noyan.Repository.Models;

public partial class Sescale
{
    public short IdScl { get; set; }

    public int Code { get; set; }

    public string Name { get; set; } = null!;

    public int? IdBranch { get; set; }

    public short? IdSclmdl { get; set; }

    public short? IdUnit { get; set; }

    public byte? Currency { get; set; }

    public string? Ip { get; set; }

    public short? Port { get; set; }

    public short Tartib { get; set; }

    public byte IdActive { get; set; }

    public virtual Active IdActiveNavigation { get; set; } = null!;

    public virtual Sebranch? IdBranchNavigation { get; set; }

    public virtual Sescalemodel? IdSclmdlNavigation { get; set; }

    public virtual Seunit? IdUnitNavigation { get; set; }

    public virtual ICollection<Sefactorscale> Sefactorscales { get; set; } = new List<Sefactorscale>();
}
