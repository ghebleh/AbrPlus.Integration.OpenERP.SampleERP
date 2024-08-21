using System;
using System.Collections.Generic;

namespace Noyan.Repository.Models;

public partial class Seok
{
    public byte IdOk { get; set; }

    public string Name { get; set; } = null!;

    public byte Tartib { get; set; }

    public virtual ICollection<Seanboth> Seanboths { get; set; } = new List<Seanboth>();

    public virtual ICollection<Sebarnameh> Sebarnamehs { get; set; } = new List<Sebarnameh>();

    public virtual ICollection<Sebeton> Sebetons { get; set; } = new List<Sebeton>();

    public virtual ICollection<Sefactor> Sefactors { get; set; } = new List<Sefactor>();

    public virtual ICollection<Sehvlrsd> Sehvlrsds { get; set; } = new List<Sehvlrsd>();

    public virtual ICollection<Sekoshtar> Sekoshtars { get; set; } = new List<Sekoshtar>();

    public virtual ICollection<Sesanadrow> Sesanadrows { get; set; } = new List<Sesanadrow>();

    public virtual ICollection<Sesanad> Sesanads { get; set; } = new List<Sesanad>();
}
