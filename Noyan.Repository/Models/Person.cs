using System;
using System.Collections.Generic;

namespace Noyan.Repository.Models;

public partial class Person
{
    public int IdPrs { get; set; }

    public byte IdActive { get; set; }

    public int Code { get; set; }

    public string Name { get; set; } = null!;

    public byte? IdPrstyp { get; set; }

    public short? IdPrsgrp { get; set; }

    public byte? IdOstan { get; set; }

    public byte? IdSex { get; set; }

    public string Descrip { get; set; } = null!;

    public string RegUser { get; set; } = null!;

    public string RegDate { get; set; } = null!;

    public string RegTime { get; set; } = null!;

    public string NameRel { get; set; } = null!;

    public string Softinfo { get; set; } = null!;

    public string Groups { get; set; } = null!;

    public string Alias { get; set; } = null!;

    public int Malicode { get; set; }

    public byte Ctmtype { get; set; }

    public int CtmNo { get; set; }

    public bool Hamahangi { get; set; }

    public virtual Active IdActiveNavigation { get; set; } = null!;

    public virtual Ostan? IdOstanNavigation { get; set; }

    public virtual Persongroup? IdPrsgrpNavigation { get; set; }

    public virtual Persontype? IdPrstypNavigation { get; set; }

    public virtual Sex? IdSexNavigation { get; set; }

    public virtual ICollection<Persondetail> Persondetails { get; set; } = new List<Persondetail>();

    public virtual ICollection<Persongroupdetail> Persongroupdetails { get; set; } = new List<Persongroupdetail>();

    public virtual User RegUserNavigation { get; set; } = null!;
}
