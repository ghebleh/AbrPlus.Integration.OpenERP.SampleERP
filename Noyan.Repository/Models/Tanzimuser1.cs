using System;
using System.Collections.Generic;

namespace Noyan.Repository.Models;

public partial class Tanzimuser1
{
    public string Id { get; set; } = null!;

    public string Tanzim { get; set; } = null!;

    public string? C1 { get; set; }

    public string? C2 { get; set; }

    public string? C3 { get; set; }

    public virtual ICollection<Tanzimuser> Tanzimusers { get; set; } = new List<Tanzimuser>();
}
