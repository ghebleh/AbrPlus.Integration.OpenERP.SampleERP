using System;
using System.Collections.Generic;

namespace Noyan.Repository.Models;

public partial class Sedataoutputdetail
{
    public int IdOutput { get; set; }

    public short IdHsbgrp { get; set; }

    public int Tartib { get; set; }

    public virtual Sehesabgroup IdHsbgrpNavigation { get; set; } = null!;

    public virtual Sedataoutput IdOutputNavigation { get; set; } = null!;
}
