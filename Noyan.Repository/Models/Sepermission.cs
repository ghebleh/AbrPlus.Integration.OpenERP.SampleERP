using System;
using System.Collections.Generic;

namespace Noyan.Repository.Models;

public partial class Sepermission
{
    public short IdPermis { get; set; }

    public string Name { get; set; } = null!;

    public bool Active { get; set; }

    public short Tartib { get; set; }
}
