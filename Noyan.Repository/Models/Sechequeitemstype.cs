using System;
using System.Collections.Generic;

namespace Noyan.Repository.Models;

public partial class Sechequeitemstype
{
    public byte IdCITyp { get; set; }

    public string Name { get; set; } = null!;

    public byte Tartib { get; set; }
}
