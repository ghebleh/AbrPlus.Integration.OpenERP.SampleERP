using System;
using System.Collections.Generic;

namespace Noyan.Repository.Models;

public partial class Nation
{
    public byte IdNation { get; set; }

    public string Name { get; set; } = null!;

    public short Tartib { get; set; }

    public short? IdNatIso { get; set; }

    public DateTime? UpdatedAt { get; set; }

    public virtual Nationality? IdNatIsoNavigation { get; set; }
}
