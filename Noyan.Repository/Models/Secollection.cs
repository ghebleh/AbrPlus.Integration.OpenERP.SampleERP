using System;
using System.Collections.Generic;

namespace Noyan.Repository.Models;

public partial class Secollection
{
    public int IdCol { get; set; }

    public int Code { get; set; }

    public string Name { get; set; } = null!;

    public byte IdActive { get; set; }

    public string IndtDa { get; set; } = null!;

    public string IndtTi { get; set; } = null!;

    public virtual Active IdActiveNavigation { get; set; } = null!;

    public virtual ICollection<Secollectiondetail> Secollectiondetails { get; set; } = new List<Secollectiondetail>();
}
