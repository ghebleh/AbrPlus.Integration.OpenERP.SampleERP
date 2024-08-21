using System;
using System.Collections.Generic;

namespace Noyan.Repository.Models;

public partial class Reportsgroup
{
    public short IdRptgrp { get; set; }

    public string Name { get; set; } = null!;

    public string Sys { get; set; } = null!;

    public short Tartib { get; set; }

    public DateTime? UpdatedAt { get; set; }

    public virtual ICollection<Report> Reports { get; set; } = new List<Report>();
}
