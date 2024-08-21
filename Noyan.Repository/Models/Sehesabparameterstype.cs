using System;
using System.Collections.Generic;

namespace Noyan.Repository.Models;

public partial class Sehesabparameterstype
{
    public byte IdHpartyp { get; set; }

    public string Name { get; set; } = null!;

    public byte Tartib { get; set; }

    public virtual ICollection<Sehesabparameter> Sehesabparameters { get; set; } = new List<Sehesabparameter>();
}
