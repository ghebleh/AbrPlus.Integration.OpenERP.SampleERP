using System;
using System.Collections.Generic;

namespace Noyan.Repository.Models;

public partial class Reportuser
{
    public int? IdRpt { get; set; }

    public string IdUser { get; set; } = null!;

    public bool Use { get; set; }

    public bool Print { get; set; }

    public short? IdRptgrp { get; set; }

    public bool Sms { get; set; }

    public DateTime? UpdatedAt { get; set; }

    public virtual Report? IdRptNavigation { get; set; }

    public virtual Reportsgroup? IdRptgrpNavigation { get; set; }

    public virtual User IdUserNavigation { get; set; } = null!;
}
