using System;
using System.Collections.Generic;

namespace Noyan.Repository.Models;

public partial class Clientsgroupdetail
{
    public int IdCltgrp { get; set; }

    public short IdClt { get; set; }

    public short Tartib { get; set; }

    public virtual Client IdCltNavigation { get; set; } = null!;

    public virtual Clientsgroup IdCltgrpNavigation { get; set; } = null!;
}
