using System;
using System.Collections.Generic;

namespace Noyan.Repository.Models;

public partial class Sechequepaper
{
    public int IdChqpap { get; set; }

    public int? IdHsbdtl { get; set; }

    public int? GeldNo { get; set; }

    public byte? IdBank { get; set; }

    public string? Shobeh { get; set; }

    public string? Hesabno { get; set; }

    public string? Hesabowner { get; set; }

    public decimal ChequeNo { get; set; }

    public int? IdChqfrm { get; set; }

    public virtual Sebank? IdBankNavigation { get; set; }

    public virtual Sechequeform? IdChqfrmNavigation { get; set; }

    public virtual Sehesabgroupdetail? IdHsbdtlNavigation { get; set; }

    public virtual ICollection<Secheque> Secheques { get; set; } = new List<Secheque>();
}
