using System;
using System.Collections.Generic;

namespace Noyan.Repository.Models;

public partial class Find
{
    public string IdUser { get; set; } = null!;

    public decimal Radif { get; set; }

    public string Finditem { get; set; } = null!;

    public virtual User IdUserNavigation { get; set; } = null!;
}
