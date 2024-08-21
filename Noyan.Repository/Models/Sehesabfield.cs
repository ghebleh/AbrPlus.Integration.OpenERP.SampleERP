using System;
using System.Collections.Generic;

namespace Noyan.Repository.Models;

public partial class Sehesabfield
{
    public int IdHsb { get; set; }

    public short IdHpar { get; set; }

    public short Tartib { get; set; }

    public virtual Sehesabparameter IdHparNavigation { get; set; } = null!;

    public virtual Sehesab IdHsbNavigation { get; set; } = null!;
}
