using System;
using System.Collections.Generic;

namespace Noyan.Repository.Models;

public partial class Sehesabuser
{
    public int? IdHsb { get; set; }

    public string IdUser { get; set; } = null!;

    public short? IdPermis { get; set; }

    public int? IdHsbdtl { get; set; }

    public virtual Sehesab? IdHsbNavigation { get; set; }

    public virtual Sehesabgroupdetail? IdHsbdtlNavigation { get; set; }

    public virtual Sepermission? IdPermisNavigation { get; set; }

    public virtual User IdUserNavigation { get; set; } = null!;
}
