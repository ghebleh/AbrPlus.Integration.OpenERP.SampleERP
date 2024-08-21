using System;
using System.Collections.Generic;

namespace Noyan.Repository.Models;

public partial class Sechequeform
{
    public int IdChqfrm { get; set; }

    public string Name { get; set; } = null!;

    public int Tartib { get; set; }

    public byte Gridline { get; set; }

    public string Picture { get; set; } = null!;

    public short PicWidth { get; set; }

    public short PicHeight { get; set; }

    public short PicLeft { get; set; }

    public short PicTop { get; set; }

    public string Orient { get; set; } = null!;

    public virtual ICollection<Sechequepaper> Sechequepapers { get; set; } = new List<Sechequepaper>();
}
