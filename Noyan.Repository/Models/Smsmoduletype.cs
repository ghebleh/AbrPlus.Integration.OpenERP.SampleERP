using System;
using System.Collections.Generic;

namespace Noyan.Repository.Models;

public partial class Smsmoduletype
{
    public short IdSmTyp { get; set; }

    public bool Active { get; set; }

    public byte Group { get; set; }

    public string Name { get; set; } = null!;

    public short Tartib { get; set; }

    public bool Alwayschk { get; set; }

    public bool Htime { get; set; }

    public bool Hmin { get; set; }

    public bool Hmax { get; set; }

    public bool Hno { get; set; }

    public string Nodescrip { get; set; } = null!;

    public bool Hmobileno { get; set; }

    public byte Expire { get; set; }

    public virtual ICollection<Smsmodule> Smsmodules { get; set; } = new List<Smsmodule>();
}
