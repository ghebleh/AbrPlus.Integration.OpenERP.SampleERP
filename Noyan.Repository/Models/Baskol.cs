using System;
using System.Collections.Generic;

namespace Noyan.Repository.Models;

public partial class Baskol
{
    public short IdBaskol { get; set; }

    public string Name { get; set; } = null!;

    public short Tartib { get; set; }

    public string Formul { get; set; } = null!;

    public byte SepChr { get; set; }

    public byte NegChr { get; set; }

    public string Ifstable { get; set; } = null!;

    public bool Reverse { get; set; }
}
