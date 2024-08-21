using System;
using System.Collections.Generic;

namespace Noyan.Repository.Models;

public partial class User
{
    public string Id { get; set; } = null!;

    public string? Code { get; set; }

    public string? Name { get; set; }

    public string? Karbar { get; set; }

    public string? Password { get; set; }

    public string? Passchk1 { get; set; }

    public string? Passchk2 { get; set; }

    public bool Active { get; set; }

    public string? Comment { get; set; }

    public string Username { get; set; } = null!;

    public string Karbarname { get; set; } = null!;

    public string Mobileno { get; set; } = null!;

    public byte Sex { get; set; }

    public DateTime? UpdatedAt { get; set; }

    public string? Melino { get; set; }

    public string Melino1 { get; set; } = null!;

    public virtual ICollection<Advanceresultfindused> Advanceresultfinduseds { get; set; } = new List<Advanceresultfindused>();

    public virtual ICollection<Person> People { get; set; } = new List<Person>();

    public virtual ICollection<Persondetail> Persondetails { get; set; } = new List<Persondetail>();

    public virtual ICollection<Seaqsat> Seaqsats { get; set; } = new List<Seaqsat>();

    public virtual ICollection<Sebarnameh> Sebarnamehs { get; set; } = new List<Sebarnameh>();

    public virtual ICollection<Sehesabgroupdetail> Sehesabgroupdetails { get; set; } = new List<Sehesabgroupdetail>();

    public virtual ICollection<Selabbetonazmooneh> Selabbetonazmoonehs { get; set; } = new List<Selabbetonazmooneh>();

    public virtual ICollection<Selabbetonnemoonehprint> Selabbetonnemoonehprints { get; set; } = new List<Selabbetonnemoonehprint>();

    public virtual ICollection<Selabbetonnemooneh> Selabbetonnemoonehs { get; set; } = new List<Selabbetonnemooneh>();

    public virtual ICollection<Sesanadrow> SesanadrowEditUserNavigations { get; set; } = new List<Sesanadrow>();

    public virtual ICollection<Sesanadrow> SesanadrowIndtUserNavigations { get; set; } = new List<Sesanadrow>();

    public virtual ICollection<Tanzimuser> Tanzimusers { get; set; } = new List<Tanzimuser>();
}
