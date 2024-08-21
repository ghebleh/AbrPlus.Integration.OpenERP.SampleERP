using System;
using System.Collections.Generic;

namespace Noyan.Repository.Models;

public partial class Smsmodule
{
    public int IdSmsmdl { get; set; }

    public bool Active { get; set; }

    public short IdSmTyp { get; set; }

    public string? Time { get; set; }

    public decimal? Min { get; set; }

    public decimal? Max { get; set; }

    public decimal? No { get; set; }

    public virtual Smsmoduletype IdSmTypNavigation { get; set; } = null!;

    public virtual ICollection<Sm> Sms { get; set; } = new List<Sm>();

    public virtual ICollection<Smsmoduleno> Smsmodulenos { get; set; } = new List<Smsmoduleno>();
}
