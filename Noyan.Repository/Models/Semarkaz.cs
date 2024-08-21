using System;
using System.Collections.Generic;

namespace Noyan.Repository.Models;

public partial class Semarkaz
{
    public short IdMkz { get; set; }

    public short Tartib { get; set; }

    public byte IdActive { get; set; }

    public byte IdMkztyp { get; set; }

    public string Name { get; set; } = null!;

    public short? Fieldnum { get; set; }

    public byte Codelength { get; set; }

    public byte Ashar { get; set; }

    public string Zamantype { get; set; } = null!;

    public string Comment { get; set; } = null!;

    public short CoMkz { get; set; }

    public virtual Active IdActiveNavigation { get; set; } = null!;

    public virtual Semarkaztype IdMkztypNavigation { get; set; } = null!;

    public virtual ICollection<Semarkazdetail> Semarkazdetails { get; set; } = new List<Semarkazdetail>();

    public virtual ICollection<Semarkazfield> Semarkazfields { get; set; } = new List<Semarkazfield>();
}
