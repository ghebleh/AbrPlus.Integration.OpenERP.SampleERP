using System;
using System.Collections.Generic;

namespace Noyan.Repository.Models;

public partial class Vwsehesab
{
    public int IdHsb { get; set; }

    public int? IdHsbdtl { get; set; }

    public bool IdActive { get; set; }

    public string IdsHsb { get; set; } = null!;

    public string CodeHsb { get; set; } = null!;

    public string NameHsb { get; set; } = null!;

    public string NaHsbgrp { get; set; } = null!;

    public byte LevelHsb { get; set; }

    public string NameComp { get; set; } = null!;

    public string CodeComp { get; set; } = null!;

    public string KeyStr { get; set; } = null!;

    public string ParentStr { get; set; } = null!;

    public string NameKol { get; set; } = null!;

    public decimal Code { get; set; }

    public string Name { get; set; } = null!;

    public short Undercount { get; set; }

    public byte Codelength { get; set; }

    public string? NaCtmtit { get; set; }

    public short? IdHsbgrp { get; set; }

    public int? ParentHsb { get; set; }

    public bool Enteghal { get; set; }

    public byte Type { get; set; }

    public byte Typemandeh { get; set; }

    public string NaBefore { get; set; } = null!;

    public string NaAfter { get; set; } = null!;

    public bool Aqsat { get; set; }

    public bool Forceaqsat { get; set; }

    public string IndtDa { get; set; } = null!;

    public string IndtTi { get; set; } = null!;

    public int? ParHsbdtl { get; set; }

    public string? StrKey { get; set; }

    public string? StrCode1 { get; set; }

    public string? StrCode2 { get; set; }

    public byte? IdCtmtit { get; set; }

    public string? Fname { get; set; }

    public string? Lname { get; set; }

    public byte? IdCtmtyp { get; set; }

    public string? Father { get; set; }

    public byte? IdSex { get; set; }

    public string? Birthdate { get; set; }

    public string? Birthshahr { get; set; }

    public string? Shanasno { get; set; }

    public string? Sodoordate { get; set; }

    public string? Sodoor { get; set; }

    public string? Eghtesadno { get; set; }

    public string? Melino { get; set; }

    public string? Address { get; set; }

    public string? Codepost { get; set; }

    public string? Tel { get; set; }

    public string? Mobile { get; set; }

    public decimal? Credit { get; set; }

    public byte? Credittype { get; set; }

    public byte? IdBank { get; set; }

    public string? Shobeh { get; set; }

    public byte? IdBnkhtyp { get; set; }

    public string? Hesabno { get; set; }

    public string? Hesabowner { get; set; }

    public string? Codekala { get; set; }

    public short? IdKalagrp { get; set; }

    public short? IdUnit { get; set; }

    public decimal? FiForosh { get; set; }

    public decimal? FiForosh1 { get; set; }

    public decimal? FiForosh2 { get; set; }

    public decimal? FiKharid { get; set; }

    public decimal? Sefaresh { get; set; }

    public bool? Iskaladate { get; set; }

    public bool? Iskalasril { get; set; }

    public bool? Darsad3 { get; set; }

    public decimal? Vazn { get; set; }

    public bool? Noanbar { get; set; }

    public byte? KalHsbtyp { get; set; }

    public int? KalHsb { get; set; }

    public int? KalHsbdtl { get; set; }

    public byte? PriceType { get; set; }

    public string? Comment { get; set; }

    public string? IdUser { get; set; }

    public string? Mahal { get; set; }

    public byte? Machinetyp { get; set; }

    public string? Vin { get; set; }

    public string? Shenase { get; set; }

    public string? Shobecode { get; set; }

    public decimal? FiForosh3 { get; set; }

    public virtual Sebank? IdBankNavigation { get; set; }

    public virtual Sebankhesabtype? IdBnkhtypNavigation { get; set; }

    public virtual Secustomertitle? IdCtmtitNavigation { get; set; }

    public virtual Persontype? IdCtmtypNavigation { get; set; }

    public virtual Sehesab IdHsbNavigation { get; set; } = null!;

    public virtual Sehesabgroupdetail? IdHsbdtlNavigation { get; set; }

    public virtual Sehesabgroup? IdHsbgrpNavigation { get; set; }

    public virtual Sekalagroup? IdKalagrpNavigation { get; set; }

    public virtual Sex? IdSexNavigation { get; set; }

    public virtual Seunit? IdUnitNavigation { get; set; }

    public virtual User? IdUserNavigation { get; set; }
}
