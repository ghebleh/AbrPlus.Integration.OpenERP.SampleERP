using System;
using System.Collections.Generic;

namespace Noyan.Repository.Models;

public partial class Tanzimtotal
{
    public string Id { get; set; } = null!;

    public string Tanzim { get; set; } = null!;

    public string? C1 { get; set; }

    public string? C2 { get; set; }

    public string? C3 { get; set; }

    public string? DefaultC1 { get; set; }

    public string? DefaultC2 { get; set; }

    public string? DefaultC3 { get; set; }

    public DateTime? UpdatedAt { get; set; }
}
