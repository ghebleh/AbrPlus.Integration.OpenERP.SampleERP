using System;
using System.Collections.Generic;

namespace Noyan.Repository.Models;

public partial class Sebranchuser
{
    public int IdBranch { get; set; }

    public string IdUser { get; set; } = null!;

    public short? IdPermis { get; set; }

    public virtual Sebranch IdBranchNavigation { get; set; } = null!;

    public virtual Sepermission? IdPermisNavigation { get; set; }

    public virtual User IdUserNavigation { get; set; } = null!;
}
