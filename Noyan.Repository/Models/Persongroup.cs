using System;
using System.Collections.Generic;

namespace Noyan.Repository.Models;

public partial class Persongroup
{
    public short IdPrsgrp { get; set; }

    public string Name { get; set; } = null!;

    public short Tartib { get; set; }

    public virtual ICollection<Person> People { get; set; } = new List<Person>();

    public virtual ICollection<Persongroupdetail> Persongroupdetails { get; set; } = new List<Persongroupdetail>();
}
