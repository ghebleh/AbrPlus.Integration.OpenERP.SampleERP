using System;
using System.Collections.Generic;

namespace Noyan.Repository.Models;

public partial class Educationlevel
{
    public byte IdEdulvl { get; set; }

    public string Code { get; set; } = null!;

    public string Value { get; set; } = null!;

    public string Termnology { get; set; } = null!;

    public virtual ICollection<Madrak> Madraks { get; set; } = new List<Madrak>();
}
