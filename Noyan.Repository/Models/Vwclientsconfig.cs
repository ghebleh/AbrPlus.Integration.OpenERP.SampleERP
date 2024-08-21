using System;
using System.Collections.Generic;

namespace Noyan.Repository.Models;

public partial class Vwclientsconfig
{
    public short? IdClt { get; set; }

    public int? IdCltgrp { get; set; }

    public string Id { get; set; } = null!;

    public string Config { get; set; } = null!;

    public string? C1 { get; set; }

    public string? C1Type { get; set; }

    public string? C2 { get; set; }

    public string? C2Type { get; set; }

    public string? C3 { get; set; }

    public string? C3Type { get; set; }

    public string Source { get; set; } = null!;
}
