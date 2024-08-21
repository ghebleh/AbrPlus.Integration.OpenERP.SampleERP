using System;
using System.Collections.Generic;

namespace Noyan.Repository.Models;

public partial class Seperiod
{
    public int IdPeriod { get; set; }

    public byte IdActive { get; set; }

    public int Code { get; set; }

    public string Name { get; set; } = null!;

    public string Datestart { get; set; } = null!;

    public string Dateend { get; set; } = null!;

    public string IndtDa { get; set; } = null!;

    public string IndtTi { get; set; } = null!;

    public bool Integrated { get; set; }

    public decimal AfzoodehD { get; set; }

    public bool Fcttasvieh { get; set; }

    public byte Anbhsbtyp { get; set; }

    public byte Anbprctyp { get; set; }

    public bool SndSood { get; set; }

    public bool SndClose { get; set; }

    public string Anbchafrom { get; set; } = null!;

    public string Closeuntil { get; set; } = null!;

    public virtual Active IdActiveNavigation { get; set; } = null!;

    public virtual ICollection<Seanboth> Seanboths { get; set; } = new List<Seanboth>();

    public virtual ICollection<Sebarnameh> Sebarnamehs { get; set; } = new List<Sebarnameh>();

    public virtual ICollection<Sebeton> Sebetons { get; set; } = new List<Sebeton>();

    public virtual ICollection<Sefactor> Sefactors { get; set; } = new List<Sefactor>();

    public virtual ICollection<Sehvlrsd> Sehvlrsds { get; set; } = new List<Sehvlrsd>();

    public virtual ICollection<Sekoshtar> Sekoshtars { get; set; } = new List<Sekoshtar>();

    public virtual ICollection<Seperiodbranch> Seperiodbranches { get; set; } = new List<Seperiodbranch>();

    public virtual ICollection<Sesanadlog> Sesanadlogs { get; set; } = new List<Sesanadlog>();

    public virtual ICollection<Sesanad> Sesanads { get; set; } = new List<Sesanad>();
}
