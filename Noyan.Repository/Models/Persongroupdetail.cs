using System;
using System.Collections.Generic;

namespace Noyan.Repository.Models;

public partial class Persongroupdetail
{
    public int IdPrs { get; set; }

    public short IdPrsgrp { get; set; }

    public byte Tartib { get; set; }

    public virtual Person IdPrsNavigation { get; set; } = null!;

    public virtual Persongroup IdPrsgrpNavigation { get; set; } = null!;
}
