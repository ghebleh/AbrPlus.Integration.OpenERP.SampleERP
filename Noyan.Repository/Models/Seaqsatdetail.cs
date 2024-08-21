using System;
using System.Collections.Generic;

namespace Noyan.Repository.Models;

public partial class Seaqsatdetail
{
    public int IdQstdtl { get; set; }

    public int IdQst { get; set; }

    public short Radif { get; set; }

    public string Date { get; set; } = null!;

    public decimal Mablagh { get; set; }

    public string CommRadif { get; set; } = null!;

    public virtual Seaqsat IdQstNavigation { get; set; } = null!;

    public virtual ICollection<Sesanadrow> Sesanadrows { get; set; } = new List<Sesanadrow>();
}
