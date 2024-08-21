using System;
using System.Collections.Generic;

namespace Noyan.Repository.Models;

public partial class Reportsitemsdetail
{
    public int Id { get; set; }

    public int IdRptitm { get; set; }

    public string Descrip { get; set; } = null!;

    public string Value { get; set; } = null!;

    public int Tartib { get; set; }

    public virtual Reportsitem IdRptitmNavigation { get; set; } = null!;
}
