using System;
using System.Collections.Generic;

namespace Noyan.Repository.Models;

public partial class Semarkazfield
{
    public int IdMkzfld { get; set; }

    public short IdMkz { get; set; }

    public byte IdActive { get; set; }

    public int Fieldcode { get; set; }

    public string Fieldname { get; set; } = null!;

    public byte Fieldtype { get; set; }

    public byte Fieldnum { get; set; }

    public byte Ashar { get; set; }

    public string Zamantype { get; set; } = null!;

    public byte Inputtype { get; set; }

    public short Tartib { get; set; }

    public virtual Active IdActiveNavigation { get; set; } = null!;

    public virtual Semarkaz IdMkzNavigation { get; set; } = null!;

    public virtual ICollection<Semarkazfielditem> Semarkazfielditems { get; set; } = new List<Semarkazfielditem>();
}
