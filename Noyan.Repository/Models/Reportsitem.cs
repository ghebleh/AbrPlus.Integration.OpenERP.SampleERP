using System;
using System.Collections.Generic;

namespace Noyan.Repository.Models;

public partial class Reportsitem
{
    public int IdRptitm { get; set; }

    public byte Kind { get; set; }

    public string Type { get; set; } = null!;

    public string Length { get; set; } = null!;

    public string Name { get; set; } = null!;

    public string Descrip { get; set; } = null!;

    public int Tartib { get; set; }

    public bool Force { get; set; }

    public bool Repeat { get; set; }

    public byte Inputtype { get; set; }

    public bool Right2left { get; set; }

    public byte Maxcount { get; set; }

    public string Default { get; set; } = null!;

    public bool Fullaccess { get; set; }

    public string Help { get; set; } = null!;

    public virtual ICollection<Reportsitemsdetail> Reportsitemsdetails { get; set; } = new List<Reportsitemsdetail>();
}
