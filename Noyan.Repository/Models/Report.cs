using System;
using System.Collections.Generic;

namespace Noyan.Repository.Models;

public partial class Report
{
    public int IdRpt { get; set; }

    public bool Active { get; set; }

    public short? IdRptgrp { get; set; }

    public string Name { get; set; } = null!;

    public string CreateDa { get; set; } = null!;

    public string LastuseDa { get; set; } = null!;

    public string? Query { get; set; }

    public bool Runfirst { get; set; }

    public bool NoshowEmp { get; set; }

    public bool NoshowPar { get; set; }

    public string? Detail { get; set; }

    public string? Other { get; set; }

    public string Sys { get; set; } = null!;

    public string Shortcut { get; set; } = null!;

    public string? FrxFile { get; set; }

    public string? FrtFile { get; set; }

    public string Version { get; set; } = null!;

    public string Smsto { get; set; } = null!;

    public string Smsdesc { get; set; } = null!;

    public string? Compile { get; set; }

    public byte Printtype { get; set; }

    public DateTime? UpdatedAt { get; set; }

    public virtual Reportsgroup? IdRptgrpNavigation { get; set; }
}
