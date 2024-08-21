using System;
using System.Collections.Generic;

namespace Noyan.Repository.Models;

public partial class SebarnamehMarkaz
{
    public int IdBar { get; set; }

    public byte Itemno { get; set; }

    public int? IdMkzd1 { get; set; }

    public int? IdMkzd2 { get; set; }

    public int? IdMkzd3 { get; set; }

    public int? IdMkzd4 { get; set; }

    public int? IdMkzd5 { get; set; }

    public int? IdMkzd6 { get; set; }

    public int? IdMkzd7 { get; set; }

    public int? IdMkzd8 { get; set; }

    public int? IdMkzd9 { get; set; }

    public int? IdMkzd10 { get; set; }

    public int? IdMkzd11 { get; set; }

    public int? IdMkzd12 { get; set; }

    public int? IdMkzd13 { get; set; }

    public int? IdMkzd14 { get; set; }

    public int? IdMkzd15 { get; set; }

    public int? IdMkzd16 { get; set; }

    public int? IdMkzd17 { get; set; }

    public int? IdMkzd18 { get; set; }

    public int? IdMkzd19 { get; set; }

    public int? IdMkzd20 { get; set; }

    public virtual Sebarnameh IdBarNavigation { get; set; } = null!;

    public virtual Semarkazdetail? IdMkzd10Navigation { get; set; }

    public virtual Semarkazdetail? IdMkzd11Navigation { get; set; }

    public virtual Semarkazdetail? IdMkzd12Navigation { get; set; }

    public virtual Semarkazdetail? IdMkzd13Navigation { get; set; }

    public virtual Semarkazdetail? IdMkzd14Navigation { get; set; }

    public virtual Semarkazdetail? IdMkzd15Navigation { get; set; }

    public virtual Semarkazdetail? IdMkzd16Navigation { get; set; }

    public virtual Semarkazdetail? IdMkzd17Navigation { get; set; }

    public virtual Semarkazdetail? IdMkzd18Navigation { get; set; }

    public virtual Semarkazdetail? IdMkzd19Navigation { get; set; }

    public virtual Semarkazdetail? IdMkzd1Navigation { get; set; }

    public virtual Semarkazdetail? IdMkzd20Navigation { get; set; }

    public virtual Semarkazdetail? IdMkzd2Navigation { get; set; }

    public virtual Semarkazdetail? IdMkzd3Navigation { get; set; }

    public virtual Semarkazdetail? IdMkzd4Navigation { get; set; }

    public virtual Semarkazdetail? IdMkzd5Navigation { get; set; }

    public virtual Semarkazdetail? IdMkzd6Navigation { get; set; }

    public virtual Semarkazdetail? IdMkzd7Navigation { get; set; }

    public virtual Semarkazdetail? IdMkzd8Navigation { get; set; }

    public virtual Semarkazdetail? IdMkzd9Navigation { get; set; }
}
