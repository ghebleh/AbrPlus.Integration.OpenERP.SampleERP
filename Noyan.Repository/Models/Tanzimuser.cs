using System;
using System.Collections.Generic;

namespace Noyan.Repository.Models;

public partial class Tanzimuser
{
    public string IdUser { get; set; } = null!;

    public string Id { get; set; } = null!;

    public string? C1 { get; set; }

    public string? C2 { get; set; }

    public string? C3 { get; set; }

    public DateTime? UpdatedAt { get; set; }

    public virtual Tanzimuser1 IdNavigation { get; set; } = null!;

    public virtual User IdUserNavigation { get; set; } = null!;
}
