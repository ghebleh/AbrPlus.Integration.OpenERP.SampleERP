using System;
using System.Collections.Generic;

namespace Noyan.Repository.Models;

public partial class Reporttablesinfo
{
    public string Tablename { get; set; } = null!;

    public string Columnname { get; set; } = null!;

    public string Descrip { get; set; } = null!;
}
