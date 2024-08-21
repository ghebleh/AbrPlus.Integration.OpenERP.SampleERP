using System;
using System.Collections.Generic;

namespace Noyan.Repository.Models;

public partial class Seunit
{
    public short IdUnit { get; set; }

    public string Name { get; set; } = null!;

    public short Tartib { get; set; }

    public byte Decimal { get; set; }

    public short? IdStdunt { get; set; }

    public virtual ICollection<Sehesabgroupdetail> Sehesabgroupdetails { get; set; } = new List<Sehesabgroupdetail>();

    public virtual ICollection<Sekalaunit> Sekalaunits { get; set; } = new List<Sekalaunit>();

    public virtual ICollection<Sescale> Sescales { get; set; } = new List<Sescale>();

    public virtual ICollection<Seunitconvert> SeunitconvertIdUnit1Navigations { get; set; } = new List<Seunitconvert>();

    public virtual ICollection<Seunitconvert> SeunitconvertIdUnit2Navigations { get; set; } = new List<Seunitconvert>();
}
