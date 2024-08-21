using System;
using System.Collections.Generic;

namespace Noyan.Repository.Models;

public partial class Level
{
    public string IdUser { get; set; } = null!;

    public string Id { get; set; } = null!;

    public byte Sys { get; set; }

    public DateTime? UpdatedAt { get; set; }

    public virtual User IdUserNavigation { get; set; } = null!;
}
