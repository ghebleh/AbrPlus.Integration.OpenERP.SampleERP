using System;
using System.Collections.Generic;

namespace Noyan.Repository.Models;

public partial class Ostan
{
    public byte IdOstan { get; set; }

    public string Name { get; set; } = null!;

    public byte Tartib { get; set; }

    public virtual ICollection<Person> People { get; set; } = new List<Person>();
}
