using System;
using System.Collections.Generic;

namespace Noyan.Repository.Models;

public partial class Sqlprocess
{
    public int Spid { get; set; }

    public string Exittime { get; set; } = null!;

    public string Exitcomm { get; set; } = null!;

    public bool Exitcommsh { get; set; }

    public string Comment { get; set; } = null!;
}
