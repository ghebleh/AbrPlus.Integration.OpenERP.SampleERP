using System;
using System.Collections.Generic;

namespace Noyan.Repository.Models;

public partial class Clientsgroup
{
    public int IdCltgrp { get; set; }

    public string Name { get; set; } = null!;

    public short Tartib { get; set; }
}
