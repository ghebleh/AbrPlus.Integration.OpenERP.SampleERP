using System;
using System.Collections.Generic;

namespace Noyan.Repository.Models;

public partial class Sehesabgroupfield
{
    public int IdHgrfld { get; set; }

    public short IdHsbgrp { get; set; }

    public short IdHpar { get; set; }

    public short Tartib { get; set; }

    public virtual Sehesabparameter IdHparNavigation { get; set; } = null!;

    public virtual Sehesabgroup IdHsbgrpNavigation { get; set; } = null!;
}
