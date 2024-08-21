using System;
using System.Collections.Generic;

namespace Noyan.Repository.Models;

public partial class Madrak
{
    public byte IdMadrak { get; set; }

    public string Name { get; set; } = null!;

    public string Tartib { get; set; } = null!;

    public byte? IdEdulvl { get; set; }

    public virtual Educationlevel? IdEdulvlNavigation { get; set; }
}
