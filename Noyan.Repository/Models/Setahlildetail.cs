using System;
using System.Collections.Generic;

namespace Noyan.Repository.Models;

public partial class Setahlildetail
{
    public int IdThl { get; set; }

    public string Caption { get; set; } = null!;

    public string LatinName { get; set; } = null!;

    public byte OutType { get; set; }

    public byte Ashar { get; set; }

    public int? IdCol { get; set; }

    public byte ColType { get; set; }

    public byte Sign { get; set; }

    public int? IdThl1 { get; set; }

    public string Formul { get; set; } = null!;

    public short Tartib { get; set; }

    public virtual Secollection? IdColNavigation { get; set; }

    public virtual Setahlil? IdThl1Navigation { get; set; }

    public virtual Setahlil IdThlNavigation { get; set; } = null!;
}
