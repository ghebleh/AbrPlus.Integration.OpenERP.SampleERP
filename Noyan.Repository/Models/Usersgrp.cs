using System;
using System.Collections.Generic;

namespace Noyan.Repository.Models;

public partial class Usersgrp
{
    public string IdGrp { get; set; } = null!;

    public string IdUser { get; set; } = null!;

    public DateTime? UpdatedAt { get; set; }

    public virtual User IdGrpNavigation { get; set; } = null!;

    public virtual User IdUserNavigation { get; set; } = null!;
}
