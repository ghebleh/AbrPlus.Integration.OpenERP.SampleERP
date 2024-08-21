using System;
using System.Collections.Generic;

namespace Noyan.Repository.Models;

public partial class Sechequeformitem
{
    public int IdChqfrm { get; set; }

    public byte IdCITyp { get; set; }

    public bool Visible { get; set; }

    public short Width { get; set; }

    public short Height { get; set; }

    public short Left { get; set; }

    public short Top { get; set; }

    public string Fontname { get; set; } = null!;

    public byte Fontsize { get; set; }

    public bool Fontbold { get; set; }

    public bool Fontitalic { get; set; }

    public bool Fontunder { get; set; }

    public byte Lines { get; set; }

    public bool Right2left { get; set; }

    public virtual Sechequeitemstype IdCITypNavigation { get; set; } = null!;

    public virtual Sechequeform IdChqfrmNavigation { get; set; } = null!;
}
