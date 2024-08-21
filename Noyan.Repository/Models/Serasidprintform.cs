using System;
using System.Collections.Generic;

namespace Noyan.Repository.Models;

public partial class Serasidprintform
{
    public byte Id { get; set; }

    public string Name { get; set; } = null!;

    public bool Default { get; set; }

    public string Orgrepfile { get; set; } = null!;

    public string Relfiles { get; set; } = null!;

    public string? FrxFile { get; set; }

    public string? FrtFile { get; set; }
}
