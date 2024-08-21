using System;
using System.Collections.Generic;

namespace Noyan.Repository.Models;

public partial class Setahlil
{
    public int IdThl { get; set; }

    public int Code { get; set; }

    public string Name { get; set; } = null!;

    public byte IdActive { get; set; }

    public string IndtDa { get; set; } = null!;

    public string IndtTi { get; set; } = null!;

    public virtual Active IdActiveNavigation { get; set; } = null!;
}
