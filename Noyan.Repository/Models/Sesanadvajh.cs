using System;
using System.Collections.Generic;

namespace Noyan.Repository.Models;

public partial class Sesanadvajh
{
    public int IdSanad { get; set; }

    public short IdRow { get; set; }

    public byte IdVajhtyp { get; set; }

    public decimal? Mablagh { get; set; }

    public string Dahandeh { get; set; } = null!;

    public string Girandeh { get; set; } = null!;

    public int? IdChq { get; set; }

    public byte? IdChqstat { get; set; }

    public bool FirstChq { get; set; }

    public string VajhNo { get; set; } = null!;

    public string VajhDate { get; set; } = null!;

    public string VajhHsbno { get; set; } = null!;

    public string VajhHsbow { get; set; } = null!;

    public string VajhMaker { get; set; } = null!;

    public string Comment { get; set; } = null!;

    public virtual Secheque? IdChqNavigation { get; set; }

    public virtual Sechequestate? IdChqstatNavigation { get; set; }

    public virtual Sesanadvajhtype IdVajhtypNavigation { get; set; } = null!;

    public virtual Sesanadrow Sesanadrow { get; set; } = null!;
}
