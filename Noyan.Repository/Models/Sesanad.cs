using System;
using System.Collections.Generic;

namespace Noyan.Repository.Models;

public partial class Sesanad
{
    public int IdSanad { get; set; }

    public int IdPeriod { get; set; }

    public int SanadNo { get; set; }

    public string Date { get; set; } = null!;

    public string Sharhtotal { get; set; } = null!;

    public int IdFormM { get; set; }

    public byte SndLevel { get; set; }

    public byte IdOk { get; set; }

    public bool AutoEf { get; set; }

    public int? IdBranch { get; set; }

    public short? IdBrngrp { get; set; }

    public virtual Sebranch? IdBranchNavigation { get; set; }

    public virtual Sebranchgroup? IdBrngrpNavigation { get; set; }

    public virtual Seform IdFormMNavigation { get; set; } = null!;

    public virtual Seok IdOkNavigation { get; set; } = null!;

    public virtual Seperiod IdPeriodNavigation { get; set; } = null!;

    public virtual ICollection<Sesanadrow> Sesanadrows { get; set; } = new List<Sesanadrow>();
}
