using System;
using System.Collections.Generic;

namespace Noyan.Repository.Models;

public partial class Sehesablevel
{
    public byte IdHsblvl { get; set; }

    public string Name { get; set; } = null!;

    public byte Codelength { get; set; }

    public bool Kol { get; set; }
}
