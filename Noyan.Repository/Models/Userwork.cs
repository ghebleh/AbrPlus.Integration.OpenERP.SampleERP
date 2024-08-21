using System;
using System.Collections.Generic;

namespace Noyan.Repository.Models;

public partial class Userwork
{
    public string IdUser { get; set; } = null!;

    public string Work { get; set; } = null!;

    public string Date { get; set; } = null!;

    public string Time { get; set; } = null!;

    public string? Comment { get; set; }

    public short Sys { get; set; }

    public string Hostname { get; set; } = null!;

    public virtual User IdUserNavigation { get; set; } = null!;
}
