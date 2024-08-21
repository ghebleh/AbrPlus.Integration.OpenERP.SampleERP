using System;
using System.Collections.Generic;

namespace Noyan.Repository.Models;

public partial class Seformsrelation
{
    public int IdFrmrel { get; set; }

    public int IdFormM { get; set; }

    public int IdForm { get; set; }

    public byte CtmBedtyp { get; set; }

    public byte CtmBestyp { get; set; }

    public short Tartib { get; set; }

    public virtual Seform IdFormMNavigation { get; set; } = null!;

    public virtual Seform IdFormNavigation { get; set; } = null!;
}
