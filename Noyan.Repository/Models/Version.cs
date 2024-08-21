using System;
using System.Collections.Generic;

namespace Noyan.Repository.Models;

public partial class Version
{
    public string VersionD { get; set; } = null!;

    public string VersionT { get; set; } = null!;

    public int Updatespid { get; set; }

    public string Bim1Sess { get; set; } = null!;

    public string Bim1Token { get; set; } = null!;
}
