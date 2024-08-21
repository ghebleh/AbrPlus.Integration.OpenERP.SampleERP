using System;
using System.Collections.Generic;

namespace Noyan.Repository.Models;

public partial class Sex
{
    public byte IdSex { get; set; }

    public string Name { get; set; } = null!;

    public byte Tartib { get; set; }

    public virtual ICollection<Person> People { get; set; } = new List<Person>();

    public virtual ICollection<Sehesabgroupdetail> Sehesabgroupdetails { get; set; } = new List<Sehesabgroupdetail>();

    public virtual ICollection<Sehesabparametersdetail> Sehesabparametersdetails { get; set; } = new List<Sehesabparametersdetail>();

    public virtual ICollection<Semarkazdetail> Semarkazdetails { get; set; } = new List<Semarkazdetail>();
}
