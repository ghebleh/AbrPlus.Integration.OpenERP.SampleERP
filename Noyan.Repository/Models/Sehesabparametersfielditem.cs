using System;
using System.Collections.Generic;

namespace Noyan.Repository.Models;

public partial class Sehesabparametersfielditem
{
    public int Id { get; set; }

    public byte IdActive { get; set; }

    public int IdHparfld { get; set; }

    public byte Typeitem { get; set; }

    public string Valueitem { get; set; } = null!;

    public short Tartib { get; set; }

    public virtual Active IdActiveNavigation { get; set; } = null!;

    public virtual Sehesabparametersfield IdHparfldNavigation { get; set; } = null!;
}
