using System;
using System.Collections.Generic;

namespace Noyan.Repository.Models;

public partial class Seperioduser
{
    public int IdPeriod { get; set; }

    public string IdUser { get; set; } = null!;

    public short? IdPermis { get; set; }

    public virtual Seperiod IdPeriodNavigation { get; set; } = null!;

    public virtual Sepermission? IdPermisNavigation { get; set; }

    public virtual User IdUserNavigation { get; set; } = null!;
}
