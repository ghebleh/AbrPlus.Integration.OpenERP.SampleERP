using System;
using System.Collections.Generic;

namespace Noyan.Repository.Models;

public partial class Sesanadrow
{
    public int IdSanad { get; set; }

    public short IdRow { get; set; }

    public short RowNo { get; set; }

    public int? IdHsb { get; set; }

    public int? IdHsbdtl { get; set; }

    public decimal Mablagh { get; set; }

    public string Sharh { get; set; } = null!;

    public byte IdOk { get; set; }

    public int? IdForm { get; set; }

    public int? LinkNo { get; set; }

    public int? IdForosh { get; set; }

    public int? IdFactor { get; set; }

    public string? VaMkz501 { get; set; }

    public string? VaMkz502 { get; set; }

    public string? VaMkz503 { get; set; }

    public string? VaMkz504 { get; set; }

    public string? VaMkz505 { get; set; }

    public string? VaMkz506 { get; set; }

    public string? VaMkz507 { get; set; }

    public string? VaMkz508 { get; set; }

    public string? VaMkz509 { get; set; }

    public string? VaMkz510 { get; set; }

    public string? VaMkz511 { get; set; }

    public string? VaMkz512 { get; set; }

    public string? VaMkz513 { get; set; }

    public string? VaMkz514 { get; set; }

    public string? VaMkz515 { get; set; }

    public string? VaMkz516 { get; set; }

    public string? VaMkz517 { get; set; }

    public string? VaMkz518 { get; set; }

    public string? VaMkz519 { get; set; }

    public string? VaMkz520 { get; set; }

    public string? VaMkz521 { get; set; }

    public string? VaMkz522 { get; set; }

    public string? VaMkz523 { get; set; }

    public string? VaMkz524 { get; set; }

    public string? VaMkz525 { get; set; }

    public string? VaMkz526 { get; set; }

    public string? VaMkz527 { get; set; }

    public string? VaMkz528 { get; set; }

    public string? VaMkz529 { get; set; }

    public string? VaMkz530 { get; set; }

    public string? VaMkz531 { get; set; }

    public string? VaMkz532 { get; set; }

    public string? VaMkz533 { get; set; }

    public string? VaMkz534 { get; set; }

    public string? VaMkz535 { get; set; }

    public string? VaMkz536 { get; set; }

    public string? VaMkz537 { get; set; }

    public string? VaMkz538 { get; set; }

    public string? VaMkz539 { get; set; }

    public string? VaMkz540 { get; set; }

    public string? VaMkz541 { get; set; }

    public string? VaMkz542 { get; set; }

    public string? VaMkz543 { get; set; }

    public string? VaMkz544 { get; set; }

    public string? VaMkz545 { get; set; }

    public string? VaMkz546 { get; set; }

    public string? VaMkz547 { get; set; }

    public string? VaMkz548 { get; set; }

    public string? VaMkz549 { get; set; }

    public string? VaMkz550 { get; set; }

    public int? IdHvlrsd { get; set; }

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

    public int? IdQstdtl { get; set; }

    public string? IndtUser { get; set; }

    public string? IndtDa { get; set; }

    public string? IndtTi { get; set; }

    public int? IdFctrel { get; set; }

    public int? IdFctbzr { get; set; }

    public bool Sabt { get; set; }

    public int? IdQst { get; set; }

    public string? EditUser { get; set; }

    public string? EditDa { get; set; }

    public string? EditTi { get; set; }

    public virtual User? EditUserNavigation { get; set; }

    public virtual Sefactor? IdFactorNavigation { get; set; }

    public virtual Sefactorbazaryab? IdFctbzrNavigation { get; set; }

    public virtual Sefactorsanadrel? IdFctrelNavigation { get; set; }

    public virtual Seform? IdFormNavigation { get; set; }

    public virtual Sebarnameh? IdForoshNavigation { get; set; }

    public virtual Sehesab? IdHsbNavigation { get; set; }

    public virtual Sehesabgroupdetail? IdHsbdtlNavigation { get; set; }

    public virtual Sehvlrsd? IdHvlrsdNavigation { get; set; }

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

    public virtual Seok IdOkNavigation { get; set; } = null!;

    public virtual Seaqsat? IdQstNavigation { get; set; }

    public virtual Seaqsatdetail? IdQstdtlNavigation { get; set; }

    public virtual Sesanad IdSanadNavigation { get; set; } = null!;

    public virtual User? IndtUserNavigation { get; set; }

    public virtual ICollection<Sefactorsanadrel> Sefactorsanadrels { get; set; } = new List<Sefactorsanadrel>();

    public virtual Sesanadvajh? Sesanadvajh { get; set; }
}
