using System;
using System.Collections.Generic;

namespace Noyan.Repository.Models;

public partial class Sesanadlog
{
    public int IdSanad { get; set; }

    public int IdPeriod { get; set; }

    public int SanadNo { get; set; }

    public int SndrowNo { get; set; }

    public string IndtDa { get; set; } = null!;

    public string IndtTi { get; set; } = null!;

    public string IndtUser { get; set; } = null!;

    public byte Type { get; set; }

    public string? Comment { get; set; }

    public int? IdBranch { get; set; }

    public short? IdBrngrp { get; set; }

    public virtual Sebranch? IdBranchNavigation { get; set; }

    public virtual Sebranchgroup? IdBrngrpNavigation { get; set; }

    public virtual Seperiod IdPeriodNavigation { get; set; } = null!;
}
