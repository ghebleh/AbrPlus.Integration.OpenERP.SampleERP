using System;
using System.Collections.Generic;

namespace Noyan.Repository.Models;

public partial class Sedatainputdetail
{
    public int IdInput { get; set; }

    public short IdHsbgIn { get; set; }

    public short IdHsbgOu { get; set; }

    public int Tartib { get; set; }

    public virtual Sehesabgroup IdHsbgInNavigation { get; set; } = null!;

    public virtual Sedatainput IdInputNavigation { get; set; } = null!;
}
