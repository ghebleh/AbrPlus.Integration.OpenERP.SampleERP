using System;
using System.Collections.Generic;

namespace Noyan.Repository.Models;

public partial class Seform
{
    public int IdForm { get; set; }

    public byte IdActive { get; set; }

    public int Code { get; set; }

    public string Name { get; set; } = null!;

    public short IdFrmgrp { get; set; }

    public short? IdFormtyp { get; set; }

    public byte? IdVajhtyp { get; set; }

    public byte Darpar { get; set; }

    public byte? BedbesChq { get; set; }

    public bool BedbesSam { get; set; }

    public bool FirstChq { get; set; }

    public byte? Chequestat { get; set; }

    public string TitleBed { get; set; } = null!;

    public string TitleBes { get; set; } = null!;

    public short? HsbgrpPlt { get; set; }

    public bool Koshtar { get; set; }

    public bool Beton { get; set; }

    public bool KoshAmani { get; set; }

    public bool KoshClose { get; set; }

    public bool? AutoSanad { get; set; }

    public byte Printtype { get; set; }

    public string? FrxFile { get; set; }

    public string? FrtFile { get; set; }

    public int? IdFrmRel { get; set; }

    public string CommPub { get; set; } = null!;

    public string CommPrv { get; set; } = null!;

    public string Prnnos1 { get; set; } = null!;

    public string Prnnos2 { get; set; } = null!;

    public string Prnnos3 { get; set; } = null!;

    public string Prnnos4 { get; set; } = null!;

    public bool PrnMandeh { get; set; }

    public string PrnFixrow { get; set; } = null!;

    public bool PrnSumcnt { get; set; }

    public string PrnDesc1 { get; set; } = null!;

    public string PrnInfo1 { get; set; } = null!;

    public string? FrxFile1 { get; set; }

    public string? FrtFile1 { get; set; }

    public string PrnDesc2 { get; set; } = null!;

    public string PrnInfo2 { get; set; } = null!;

    public string? FrxFile2 { get; set; }

    public string? FrtFile2 { get; set; }

    public string PrnDesc3 { get; set; } = null!;

    public string PrnInfo3 { get; set; } = null!;

    public string? FrxFile3 { get; set; }

    public string? FrtFile3 { get; set; }

    public string PrnDesc4 { get; set; } = null!;

    public string PrnInfo4 { get; set; } = null!;

    public string? FrxFile4 { get; set; }

    public string? FrtFile4 { get; set; }

    public bool Forfactor { get; set; }

    public bool Showvazn { get; set; }

    public bool Zerorows { get; set; }

    public byte Transfer { get; set; }

    public bool Vaseteh { get; set; }

    public bool Vaznsecure { get; set; }

    public string? KrymixDar { get; set; }

    public string? KrymixHaz { get; set; }

    public string? KrypmpDar { get; set; }

    public string? KrypmpHaz { get; set; }

    public string? AnamixDar { get; set; }

    public string? AnamixHaz { get; set; }

    public string? AnapmpDar { get; set; }

    public string? AnapmpHaz { get; set; }

    public string? AnbCtm { get; set; }

    public bool Sndedgham { get; set; }

    public bool Ghabzsame { get; set; }

    public bool Openbarcod { get; set; }

    public bool Forceser { get; set; }

    public bool MergeKb { get; set; }

    public bool Barnameh { get; set; }

    public byte TaxFcttyp { get; set; }

    public byte TaxFcttas { get; set; }

    public bool AutoFact { get; set; }

    public virtual Sehesabgroup? HsbgrpPltNavigation { get; set; }

    public virtual Active IdActiveNavigation { get; set; } = null!;

    public virtual Seformtype? IdFormtypNavigation { get; set; }

    public virtual Seform? IdFrmRelNavigation { get; set; }

    public virtual Seformsgroup IdFrmgrpNavigation { get; set; } = null!;

    public virtual Sesanadvajhtype? IdVajhtypNavigation { get; set; }

    public virtual ICollection<Seform> InverseIdFrmRelNavigation { get; set; } = new List<Seform>();

    public virtual ICollection<Seanboth> Seanboths { get; set; } = new List<Seanboth>();

    public virtual ICollection<Seaqsat> Seaqsats { get; set; } = new List<Seaqsat>();

    public virtual ICollection<Sebarnameh> Sebarnamehs { get; set; } = new List<Sebarnameh>();

    public virtual ICollection<Sebeton> Sebetons { get; set; } = new List<Sebeton>();

    public virtual ICollection<Sefactor> Sefactors { get; set; } = new List<Sefactor>();

    public virtual ICollection<Seformshesab> Seformshesabs { get; set; } = new List<Seformshesab>();

    public virtual ICollection<Seformsrelation> SeformsrelationIdFormMNavigations { get; set; } = new List<Seformsrelation>();

    public virtual ICollection<Seformsrelation> SeformsrelationIdFormNavigations { get; set; } = new List<Seformsrelation>();

    public virtual ICollection<Sehvlrsd> Sehvlrsds { get; set; } = new List<Sehvlrsd>();

    public virtual ICollection<Sekoshtar> Sekoshtars { get; set; } = new List<Sekoshtar>();

    public virtual ICollection<Selabbetonnemooneh> Selabbetonnemoonehs { get; set; } = new List<Selabbetonnemooneh>();

    public virtual ICollection<Sesanadrow> Sesanadrows { get; set; } = new List<Sesanadrow>();

    public virtual ICollection<Sesanad> Sesanads { get; set; } = new List<Sesanad>();
}
