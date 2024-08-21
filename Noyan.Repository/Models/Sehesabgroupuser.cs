using System;
using System.Collections.Generic;

namespace Noyan.Repository.Models;

public partial class Sehesabgroupuser
{
    public short? IdHsbgrp { get; set; }

    public string IdUser { get; set; } = null!;

    public short? IdPermis { get; set; }

    public virtual Sehesabgroup? IdHsbgrpNavigation { get; set; }

    public virtual Sepermission? IdPermisNavigation { get; set; }

    public virtual User IdUserNavigation { get; set; } = null!;
}
