using System;
using System.Collections.Generic;

namespace Noyan.Repository.Models;

public partial class Seforooshtype
{
    public byte IdFshtyp { get; set; }

    public string Name { get; set; } = null!;

    public bool Active { get; set; }

    public virtual ICollection<Sefactor> Sefactors { get; set; } = new List<Sefactor>();
}
