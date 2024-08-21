using System;
using System.Collections.Generic;

namespace Noyan.Repository.Models;

public partial class Seformuser
{
    public int? IdForm { get; set; }

    public string IdUser { get; set; } = null!;

    public bool View { get; set; }

    public bool Add { get; set; }

    public bool Edit { get; set; }

    public bool Delete { get; set; }

    public bool Print { get; set; }

    public bool View1 { get; set; }

    public bool Add1 { get; set; }

    public bool Edit1 { get; set; }

    public bool Delete1 { get; set; }

    public bool Print1 { get; set; }

    public short? IdFrmgrp { get; set; }

    public short? IdPermis { get; set; }

    public virtual Seform? IdFormNavigation { get; set; }

    public virtual Seformsgroup? IdFrmgrpNavigation { get; set; }

    public virtual Sepermission? IdPermisNavigation { get; set; }

    public virtual User IdUserNavigation { get; set; } = null!;
}
