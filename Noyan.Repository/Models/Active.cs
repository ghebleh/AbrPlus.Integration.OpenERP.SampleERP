using System;
using System.Collections.Generic;

namespace Noyan.Repository.Models;

public partial class Active
{
    public byte IdActive { get; set; }

    public string Name { get; set; } = null!;

    public byte Tartib { get; set; }

    public virtual ICollection<Person> People { get; set; } = new List<Person>();

    public virtual ICollection<Sebranch> Sebranches { get; set; } = new List<Sebranch>();

    public virtual ICollection<Secollection> Secollections { get; set; } = new List<Secollection>();

    public virtual ICollection<Seform> Seforms { get; set; } = new List<Seform>();

    public virtual ICollection<Sehesabgroupdetail> Sehesabgroupdetails { get; set; } = new List<Sehesabgroupdetail>();

    public virtual ICollection<Sehesabgroup> Sehesabgroups { get; set; } = new List<Sehesabgroup>();

    public virtual ICollection<Sehesabparameter> Sehesabparameters { get; set; } = new List<Sehesabparameter>();

    public virtual ICollection<Sehesabparametersdetail> Sehesabparametersdetails { get; set; } = new List<Sehesabparametersdetail>();

    public virtual ICollection<Sehesabparametersfielditem> Sehesabparametersfielditems { get; set; } = new List<Sehesabparametersfielditem>();

    public virtual ICollection<Sehesabparametersfield> Sehesabparametersfields { get; set; } = new List<Sehesabparametersfield>();

    public virtual ICollection<Sehesab> Sehesabs { get; set; } = new List<Sehesab>();

    public virtual ICollection<Semarkazdetail> Semarkazdetails { get; set; } = new List<Semarkazdetail>();

    public virtual ICollection<Semarkazfielditem> Semarkazfielditems { get; set; } = new List<Semarkazfielditem>();

    public virtual ICollection<Semarkazfield> Semarkazfields { get; set; } = new List<Semarkazfield>();

    public virtual ICollection<Semarkaz> Semarkazs { get; set; } = new List<Semarkaz>();

    public virtual ICollection<Seperiod> Seperiods { get; set; } = new List<Seperiod>();

    public virtual ICollection<Sescalemodel> Sescalemodels { get; set; } = new List<Sescalemodel>();

    public virtual ICollection<Sescale> Sescales { get; set; } = new List<Sescale>();

    public virtual ICollection<Setahlil> Setahlils { get; set; } = new List<Setahlil>();
}
