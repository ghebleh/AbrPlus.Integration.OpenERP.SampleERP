using System;
using System.Collections.Generic;

namespace Noyan.Repository.Models;

public partial class Vwsefactorsanadrel
{
    public int IdFctrel { get; set; }

    public int IdFactor { get; set; }

    public int? IdSanad { get; set; }

    public short? IdRow { get; set; }

    public decimal Mablagh { get; set; }

    public decimal MabSanad { get; set; }

    public string Date { get; set; } = null!;

    public string? Datecash { get; set; }

    public string IndtUser { get; set; } = null!;

    public string IndtDa { get; set; } = null!;

    public string IndtTi { get; set; } = null!;
}
