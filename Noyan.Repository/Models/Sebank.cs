using System;
using System.Collections.Generic;

namespace Noyan.Repository.Models;

public partial class Sebank
{
    public byte IdBank { get; set; }

    public string Name { get; set; } = null!;

    public int Tartib { get; set; }

    public virtual ICollection<Sechequepaper> Sechequepapers { get; set; } = new List<Sechequepaper>();

    public virtual ICollection<Sehesabgroupdetail> Sehesabgroupdetails { get; set; } = new List<Sehesabgroupdetail>();

    public virtual ICollection<Sehesabparametersdetail> Sehesabparametersdetails { get; set; } = new List<Sehesabparametersdetail>();

    public virtual ICollection<Semarkazdetail> Semarkazdetails { get; set; } = new List<Semarkazdetail>();
}
