using System;
using System.Collections.Generic;

namespace Noyan.Repository.Models;

public partial class Sekalaformul
{
    public int IdKalaM { get; set; }

    public int? IdKala { get; set; }

    public decimal Meghdar { get; set; }

    public short Tartib { get; set; }

    public short? IdKalagrp { get; set; }

    public virtual Sehesabgroupdetail IdKalaMNavigation { get; set; } = null!;

    public virtual Sehesabgroupdetail? IdKalaNavigation { get; set; }

    public virtual Sekalagroup? IdKalagrpNavigation { get; set; }
}
