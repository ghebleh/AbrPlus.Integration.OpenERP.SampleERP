using System;
using System.Collections.Generic;

namespace Noyan.Repository.Models;

public partial class Sekalagroup
{
    public short IdKalagrp { get; set; }

    public string Name { get; set; } = null!;

    public short Tartib { get; set; }

    public virtual ICollection<Sehesabgroupdetail> Sehesabgroupdetails { get; set; } = new List<Sehesabgroupdetail>();
}
