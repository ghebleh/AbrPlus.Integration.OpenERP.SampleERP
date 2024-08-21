using System;
using System.Collections.Generic;

namespace Noyan.Repository.Models;

public partial class Personrelation
{
    public int IdPrs1 { get; set; }

    public int IdPrs2 { get; set; }

    public string Comment { get; set; } = null!;

    public string RegUser { get; set; } = null!;

    public string RegDate { get; set; } = null!;

    public string RegTime { get; set; } = null!;

    public short Tartib { get; set; }

    public virtual Person IdPrs1Navigation { get; set; } = null!;

    public virtual Person IdPrs2Navigation { get; set; } = null!;

    public virtual User RegUserNavigation { get; set; } = null!;
}
