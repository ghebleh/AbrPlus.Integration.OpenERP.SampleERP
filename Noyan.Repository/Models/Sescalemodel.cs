using System;
using System.Collections.Generic;

namespace Noyan.Repository.Models;

public partial class Sescalemodel
{
    public short IdSclmdl { get; set; }

    public string Name { get; set; } = null!;

    public byte IdActive { get; set; }

    public virtual Active IdActiveNavigation { get; set; } = null!;

    public virtual ICollection<Sescale> Sescales { get; set; } = new List<Sescale>();
}
