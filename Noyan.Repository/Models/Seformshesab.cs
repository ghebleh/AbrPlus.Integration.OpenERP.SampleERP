using System;
using System.Collections.Generic;

namespace Noyan.Repository.Models;

public partial class Seformshesab
{
    public int IdFrmhsb { get; set; }

    public int IdForm { get; set; }

    public int ParType { get; set; }

    public int? IdHsb { get; set; }

    public short? IdHsbgrp { get; set; }

    public byte Undertype { get; set; }

    public string WhereC { get; set; } = null!;

    public string OrderC { get; set; } = null!;

    public short Tartib { get; set; }

    public int? IdHsbdtl { get; set; }

    public string MabFormul { get; set; } = null!;

    public string CommRadif { get; set; } = null!;

    public byte CommPrint { get; set; }

    public bool Ask { get; set; }

    public short Roundtype { get; set; }

    public byte Roundtype1 { get; set; }

    public byte Roweffect { get; set; }

    public virtual Seform IdFormNavigation { get; set; } = null!;

    public virtual Sehesab? IdHsbNavigation { get; set; }

    public virtual Sehesabgroupdetail? IdHsbdtlNavigation { get; set; }

    public virtual Sehesabgroup? IdHsbgrpNavigation { get; set; }
}
