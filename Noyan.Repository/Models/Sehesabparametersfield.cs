using System;
using System.Collections.Generic;

namespace Noyan.Repository.Models;

public partial class Sehesabparametersfield
{
    public int IdHparfld { get; set; }

    public short IdHpar { get; set; }

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

    public virtual Sehesabparameter IdHparNavigation { get; set; } = null!;

    public virtual ICollection<Sehesabparametersfielditem> Sehesabparametersfielditems { get; set; } = new List<Sehesabparametersfielditem>();
}
