using System;
using System.Collections.Generic;

namespace Noyan.Repository.Models;

public partial class Sechequestate
{
    public byte IdChqstat { get; set; }

    public string Name { get; set; } = null!;

    public byte Tartib { get; set; }

    public virtual ICollection<Sesanadvajh> Sesanadvajhs { get; set; } = new List<Sesanadvajh>();
}
