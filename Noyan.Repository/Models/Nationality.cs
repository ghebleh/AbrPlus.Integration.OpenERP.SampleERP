using System;
using System.Collections.Generic;

namespace Noyan.Repository.Models;

public partial class Nationality
{
    public short IdNatIso { get; set; }

    public string Code { get; set; } = null!;

    public string Value { get; set; } = null!;

    public string Termnology { get; set; } = null!;

    public virtual ICollection<Nation> Nations { get; set; } = new List<Nation>();
}
