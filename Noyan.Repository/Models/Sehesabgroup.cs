using System;
using System.Collections.Generic;

namespace Noyan.Repository.Models;

public partial class Sehesabgroup
{
    public short IdHsbgrp { get; set; }

    public short Tartib { get; set; }

    public byte IdActive { get; set; }

    public short IdHsbgtyp { get; set; }

    public string Name { get; set; } = null!;

    public byte Codelength { get; set; }

    public string Comment { get; set; } = null!;

    public short CoHsbgrp { get; set; }

    public string NameEn { get; set; } = null!;

    public int CodeFr { get; set; }

    public int CodeTo { get; set; }

    public virtual Active IdActiveNavigation { get; set; } = null!;

    public virtual Sehesabgrouptype IdHsbgtypNavigation { get; set; } = null!;

    public virtual ICollection<Seform> Seforms { get; set; } = new List<Seform>();

    public virtual ICollection<Seformshesab> Seformshesabs { get; set; } = new List<Seformshesab>();

    public virtual ICollection<Sehesabgroupdetail> Sehesabgroupdetails { get; set; } = new List<Sehesabgroupdetail>();

    public virtual ICollection<Sehesabgroupfield> Sehesabgroupfields { get; set; } = new List<Sehesabgroupfield>();

    public virtual ICollection<Sehesab> Sehesabs { get; set; } = new List<Sehesab>();
}
