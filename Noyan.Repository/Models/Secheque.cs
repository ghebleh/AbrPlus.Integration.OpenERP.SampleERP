using System;
using System.Collections.Generic;

namespace Noyan.Repository.Models;

public partial class Secheque
{
    public int IdChq { get; set; }

    public int IdChqpap { get; set; }

    public string Date { get; set; } = null!;

    public string Darvajh { get; set; } = null!;

    public decimal Mablagh { get; set; }

    public bool NohavaleK { get; set; }

    public bool Printed { get; set; }

    public string DaftarNo { get; set; } = null!;

    public string Melino { get; set; } = null!;

    public virtual Sechequepaper IdChqpapNavigation { get; set; } = null!;

    public virtual ICollection<Sesanadvajh> Sesanadvajhs { get; set; } = new List<Sesanadvajh>();
}
