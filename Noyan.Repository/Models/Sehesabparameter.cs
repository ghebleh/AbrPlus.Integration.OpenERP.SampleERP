using System;
using System.Collections.Generic;

namespace Noyan.Repository.Models;

public partial class Sehesabparameter
{
    public short IdHpar { get; set; }

    public short Tartib { get; set; }

    public byte IdActive { get; set; }

    public byte IdHpartyp { get; set; }

    public string Name { get; set; } = null!;

    public short? Fieldnum { get; set; }

    public byte Codelength { get; set; }

    public byte Ashar { get; set; }

    public string Zamantype { get; set; } = null!;

    public string Comment { get; set; } = null!;

    public virtual Active IdActiveNavigation { get; set; } = null!;

    public virtual Sehesabparameterstype IdHpartypNavigation { get; set; } = null!;

    public virtual ICollection<Sehesabgroupfield> Sehesabgroupfields { get; set; } = new List<Sehesabgroupfield>();

    public virtual ICollection<Sehesabparametersdetail> Sehesabparametersdetails { get; set; } = new List<Sehesabparametersdetail>();

    public virtual ICollection<Sehesabparametersfield> Sehesabparametersfields { get; set; } = new List<Sehesabparametersfield>();
}
