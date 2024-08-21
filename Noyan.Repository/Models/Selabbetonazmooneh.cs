using System;
using System.Collections.Generic;

namespace Noyan.Repository.Models;

public partial class Selabbetonazmooneh
{
    public int IdAzm { get; set; }

    public int IdNem { get; set; }

    public int AzmNo { get; set; }

    public string Date { get; set; } = null!;

    public byte Days { get; set; }

    public int TchHsbd { get; set; }

    public int MhlHsbd { get; set; }

    public string Datesar { get; set; } = null!;

    public string Datetahvil { get; set; } = null!;

    public string? Dateanjam { get; set; }

    public byte Nemvaziat { get; set; }

    public byte Nemtype { get; set; }

    public string IndtUser { get; set; } = null!;

    public string IndtDate { get; set; } = null!;

    public string IndtTime { get; set; } = null!;

    public int? Tool { get; set; }

    public int? Arz { get; set; }

    public int? Ertefa { get; set; }

    public decimal BarArea { get; set; }

    public decimal Niroo { get; set; }

    public decimal Hajm { get; set; }

    public decimal BarSorat { get; set; }

    public decimal Vazn { get; set; }

    public decimal Moghavemat { get; set; }

    public bool Anjam { get; set; }

    public bool Toazmvaziat { get; set; }

    public int MdrHsbd { get; set; }

    public decimal VaznMakh { get; set; }

    public int? HosHsbd { get; set; }

    public decimal Calibzarib { get; set; }

    public string? NaImage { get; set; }

    public string Descrip { get; set; } = null!;

    public decimal? Zaribshape { get; set; }

    public virtual Sehesabgroupdetail? HosHsbdNavigation { get; set; }

    public virtual Selabbetonnemooneh IdNemNavigation { get; set; } = null!;

    public virtual User IndtUserNavigation { get; set; } = null!;

    public virtual Sehesabgroupdetail MdrHsbdNavigation { get; set; } = null!;

    public virtual Sehesabgroupdetail MhlHsbdNavigation { get; set; } = null!;

    public virtual Sehesabgroupdetail TchHsbdNavigation { get; set; } = null!;
}
