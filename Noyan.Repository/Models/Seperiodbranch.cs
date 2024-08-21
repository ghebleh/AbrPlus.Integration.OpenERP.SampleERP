using System;
using System.Collections.Generic;

namespace Noyan.Repository.Models;

public partial class Seperiodbranch
{
    public int IdPeriod { get; set; }

    public int IdBranch { get; set; }

    public short? IdBrngrp { get; set; }

    public bool SndSood { get; set; }

    public bool SndClose { get; set; }

    public string Anbchafrom { get; set; } = null!;

    public int IdPrdbrn { get; set; }

    public virtual Sebranch IdBranchNavigation { get; set; } = null!;

    public virtual Sebranchgroup? IdBrngrpNavigation { get; set; }

    public virtual Seperiod IdPeriodNavigation { get; set; } = null!;
}
