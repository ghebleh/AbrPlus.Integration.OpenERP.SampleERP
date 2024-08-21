using System;
using System.Collections.Generic;

namespace Noyan.Repository.Models;

public partial class Persondetail
{
    public int IdPrsdtl { get; set; }

    public int IdPrs { get; set; }

    public byte IdPdtltyp { get; set; }

    public int Tartib { get; set; }

    public string Value { get; set; } = null!;

    public string Comment { get; set; } = null!;

    public string RegUser { get; set; } = null!;

    public string RegDate { get; set; } = null!;

    public string RegTime { get; set; } = null!;

    public virtual Persondetailtype IdPdtltypNavigation { get; set; } = null!;

    public virtual Person IdPrsNavigation { get; set; } = null!;

    public virtual User RegUserNavigation { get; set; } = null!;
}
