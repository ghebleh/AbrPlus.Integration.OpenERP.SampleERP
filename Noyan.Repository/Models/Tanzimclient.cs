using System;
using System.Collections.Generic;

namespace Noyan.Repository.Models;

public partial class Tanzimclient
{
    public short? IdClt { get; set; }

    public int? IdCltgrp { get; set; }

    public string Id { get; set; } = null!;

    public string? C1 { get; set; }

    public string? C2 { get; set; }

    public string? C3 { get; set; }

    public virtual Client? IdCltNavigation { get; set; }

    public virtual Clientsgroup? IdCltgrpNavigation { get; set; }

    public virtual Tanzimclient1 IdNavigation { get; set; } = null!;
}
