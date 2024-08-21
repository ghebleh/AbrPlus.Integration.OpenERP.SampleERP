using System;
using System.Collections.Generic;

namespace Noyan.Repository.Models;

public partial class Smsmoduleno
{
    public int IdSmNo { get; set; }

    public bool Active { get; set; }

    public int IdSmsmdl { get; set; }

    public string Mobileno { get; set; } = null!;

    public virtual Smsmodule IdSmsmdlNavigation { get; set; } = null!;
}
