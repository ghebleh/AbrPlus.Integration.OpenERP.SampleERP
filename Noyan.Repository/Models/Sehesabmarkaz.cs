using System;
using System.Collections.Generic;

namespace Noyan.Repository.Models;

public partial class Sehesabmarkaz
{
    public int IdHsb { get; set; }

    public short IdMkz { get; set; }

    public short Tartib { get; set; }

    public bool Force { get; set; }

    public bool Fromlast { get; set; }

    public virtual Sehesab IdHsbNavigation { get; set; } = null!;

    public virtual Semarkaz IdMkzNavigation { get; set; } = null!;
}
