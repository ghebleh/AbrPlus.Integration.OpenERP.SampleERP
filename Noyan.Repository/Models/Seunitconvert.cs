using System;
using System.Collections.Generic;

namespace Noyan.Repository.Models;

public partial class Seunitconvert
{
    public short Id { get; set; }

    public short IdUnit1 { get; set; }

    public decimal Zarib { get; set; }

    public short IdUnit2 { get; set; }

    public byte Tartib { get; set; }

    public virtual Seunit IdUnit1Navigation { get; set; } = null!;

    public virtual Seunit IdUnit2Navigation { get; set; } = null!;
}
