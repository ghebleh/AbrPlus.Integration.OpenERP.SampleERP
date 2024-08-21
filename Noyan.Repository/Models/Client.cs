using System;
using System.Collections.Generic;

namespace Noyan.Repository.Models;

public partial class Client
{
    public short IdClt { get; set; }

    public string Name { get; set; } = null!;

    public short Tartib { get; set; }
}
