using System;
using System.Collections.Generic;

namespace Noyan.Repository.Models;

public partial class Seperiodpermission
{
    public short IdPermis { get; set; }

    public bool Active { get; set; }

    public short Tartib { get; set; }

    public virtual Sepermission IdPermisNavigation { get; set; } = null!;
}
