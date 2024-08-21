using System;
using System.Collections.Generic;

namespace Noyan.Repository.Models;

public partial class Seformsgroup
{
    public short IdFrmgrp { get; set; }

    public string Name { get; set; } = null!;

    public short Tartib { get; set; }

    public virtual ICollection<Seform> Seforms { get; set; } = new List<Seform>();
}
