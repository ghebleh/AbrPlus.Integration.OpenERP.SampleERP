using System;
using System.Collections.Generic;

namespace Noyan.Repository.Models;

public partial class Persondetailtype
{
    public byte IdPdtltyp { get; set; }

    public string Name { get; set; } = null!;

    public string Type { get; set; } = null!;

    public short Length { get; set; }

    public string Inputmask { get; set; } = null!;

    public string Lang { get; set; } = null!;

    public byte Tartib { get; set; }

    public bool Active { get; set; }

    public virtual ICollection<Persondetail> Persondetails { get; set; } = new List<Persondetail>();
}
