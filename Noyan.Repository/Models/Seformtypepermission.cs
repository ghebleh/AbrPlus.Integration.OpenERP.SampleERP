using System;
using System.Collections.Generic;

namespace Noyan.Repository.Models;

public partial class Seformtypepermission
{
    public short IdFormtyp { get; set; }

    public short IdPermis { get; set; }

    public bool Active { get; set; }

    public short Tartib { get; set; }

    public virtual Seformtype IdFormtypNavigation { get; set; } = null!;

    public virtual Sepermission IdPermisNavigation { get; set; } = null!;
}
