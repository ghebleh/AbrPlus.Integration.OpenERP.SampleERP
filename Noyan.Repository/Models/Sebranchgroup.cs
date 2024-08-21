using System;
using System.Collections.Generic;

namespace Noyan.Repository.Models;

public partial class Sebranchgroup
{
    public short IdBrngrp { get; set; }

    public string Name { get; set; } = null!;

    public short Tartib { get; set; }

    public virtual ICollection<Seanboth> Seanboths { get; set; } = new List<Seanboth>();

    public virtual ICollection<Sebarnameh> Sebarnamehs { get; set; } = new List<Sebarnameh>();

    public virtual ICollection<Sebeton> Sebetons { get; set; } = new List<Sebeton>();

    public virtual ICollection<Sebranch> Sebranches { get; set; } = new List<Sebranch>();

    public virtual ICollection<Sefactor> Sefactors { get; set; } = new List<Sefactor>();

    public virtual ICollection<Sehvlrsd> Sehvlrsds { get; set; } = new List<Sehvlrsd>();

    public virtual ICollection<Sekoshtar> Sekoshtars { get; set; } = new List<Sekoshtar>();

    public virtual ICollection<Seperiodbranch> Seperiodbranches { get; set; } = new List<Seperiodbranch>();

    public virtual ICollection<Sesanadlog> Sesanadlogs { get; set; } = new List<Sesanadlog>();

    public virtual ICollection<Sesanad> Sesanads { get; set; } = new List<Sesanad>();
}
