using System;
using System.Collections.Generic;

namespace Noyan.Repository.Models;

public partial class Sebranch
{
    public int IdBranch { get; set; }

    public byte IdActive { get; set; }

    public int Code { get; set; }

    public string Name { get; set; } = null!;

    public short? IdBrngrp { get; set; }

    public int? IdBrnrel { get; set; }

    public string IndtDa { get; set; } = null!;

    public string IndtTi { get; set; } = null!;

    public bool TaxSend { get; set; }

    public virtual Active IdActiveNavigation { get; set; } = null!;

    public virtual Sebranchgroup? IdBrngrpNavigation { get; set; }

    public virtual Sebranch? IdBrnrelNavigation { get; set; }

    public virtual ICollection<Sebranch> InverseIdBrnrelNavigation { get; set; } = new List<Sebranch>();

    public virtual ICollection<Seanboth> Seanboths { get; set; } = new List<Seanboth>();

    public virtual ICollection<Sebarnameh> Sebarnamehs { get; set; } = new List<Sebarnameh>();

    public virtual ICollection<Sebeton> Sebetons { get; set; } = new List<Sebeton>();

    public virtual ICollection<Sefactor> Sefactors { get; set; } = new List<Sefactor>();

    public virtual ICollection<Sefactorscale> Sefactorscales { get; set; } = new List<Sefactorscale>();

    public virtual ICollection<Sehvlrsd> SehvlrsdIdBranchNavigations { get; set; } = new List<Sehvlrsd>();

    public virtual ICollection<Sehvlrsd> SehvlrsdIdBrnTrnNavigations { get; set; } = new List<Sehvlrsd>();

    public virtual ICollection<Sekoshtar> Sekoshtars { get; set; } = new List<Sekoshtar>();

    public virtual ICollection<Seperiodbranch> Seperiodbranches { get; set; } = new List<Seperiodbranch>();

    public virtual ICollection<Sesanadlog> Sesanadlogs { get; set; } = new List<Sesanadlog>();

    public virtual ICollection<Sesanad> Sesanads { get; set; } = new List<Sesanad>();

    public virtual ICollection<Sescale> Sescales { get; set; } = new List<Sescale>();
}
