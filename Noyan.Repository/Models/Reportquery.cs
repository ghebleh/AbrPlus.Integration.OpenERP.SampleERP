using System;
using System.Collections.Generic;

namespace Noyan.Repository.Models;

public partial class Reportquery
{
    public byte Id { get; set; }

    public string CompQuery { get; set; } = null!;
}
