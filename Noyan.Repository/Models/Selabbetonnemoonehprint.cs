using System;
using System.Collections.Generic;

namespace Noyan.Repository.Models;

public partial class Selabbetonnemoonehprint
{
    public int IdNemprn { get; set; }

    public int IdNem { get; set; }

    public byte Printno { get; set; }

    public string Serialno { get; set; } = null!;

    public string Girandeh { get; set; } = null!;

    public string Tel { get; set; } = null!;

    public string? IndtUser { get; set; }

    public string IndtDa { get; set; } = null!;

    public string IndtTi { get; set; } = null!;

    public virtual Selabbetonnemooneh IdNemNavigation { get; set; } = null!;

    public virtual User? IndtUserNavigation { get; set; }
}
