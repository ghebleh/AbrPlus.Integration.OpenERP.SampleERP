using System;
using System.Collections.Generic;

namespace Noyan.Repository.Models;

public partial class Table
{
    public short IdTbl { get; set; }

    public string Name { get; set; } = null!;

    public DateTime? UpdatedAt { get; set; }
}
