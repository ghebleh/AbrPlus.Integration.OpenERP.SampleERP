using System;
using System.Collections.Generic;

namespace Noyan.Repository.Models;

public partial class Vwtotalconfig
{
    public string Id { get; set; } = null!;

    public string Config { get; set; } = null!;

    public string? C1 { get; set; }

    public string? C1Type { get; set; }

    public string? C2 { get; set; }

    public string? C2Type { get; set; }

    public string? C3 { get; set; }

    public string? C3Type { get; set; }

    public string? DefaultC1 { get; set; }

    public string? DefaultC1Type { get; set; }

    public string? DefaultC2 { get; set; }

    public string? DefaultC2Type { get; set; }

    public string? DefaultC3 { get; set; }

    public string? DefaultC3Type { get; set; }

    public DateTime? UpdatedAt { get; set; }
}
