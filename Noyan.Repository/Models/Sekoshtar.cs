using System;
using System.Collections.Generic;

namespace Noyan.Repository.Models;

public partial class Sekoshtar
{
    public int IdKoshtar { get; set; }

    public bool Closed { get; set; }

    public int IdForm { get; set; }

    public int? IdMordar { get; set; }

    public int? IdCtm { get; set; }

    public int? IdDrv { get; set; }

    public int? IdManteg { get; set; }

    public int? IdAmani { get; set; }

    public int? IdKamion { get; set; }

    public string KamionNo { get; set; } = null!;

    public bool Amani { get; set; }

    public int B1fRadif { get; set; }

    public string B1fDate { get; set; } = null!;

    public string B1fTime { get; set; } = null!;

    public decimal B1fVazn { get; set; }

    public int B1eRadif { get; set; }

    public string B1eDate { get; set; } = null!;

    public string B1eTime { get; set; } = null!;

    public decimal B1eVazn { get; set; }

    public int B2fRadif { get; set; }

    public string B2fDate { get; set; } = null!;

    public string B2fTime { get; set; } = null!;

    public decimal B2fVazn { get; set; }

    public int B2eRadif { get; set; }

    public string B2eDate { get; set; } = null!;

    public string B2eTime { get; set; } = null!;

    public decimal B2eVazn { get; set; }

    public int B3fRadif { get; set; }

    public string B3fDate { get; set; } = null!;

    public string B3fTime { get; set; } = null!;

    public decimal B3fVazn { get; set; }

    public int B3eRadif { get; set; }

    public string B3eDate { get; set; } = null!;

    public string B3eTime { get; set; } = null!;

    public decimal B3eVazn { get; set; }

    public decimal B3Oft { get; set; }

    public decimal B3Sookht { get; set; }

    public decimal B3Anaam { get; set; }

    public short Sabad1 { get; set; }

    public short Sabad1In { get; set; }

    public short Sabad2 { get; set; }

    public short Sabad2In { get; set; }

    public short Sabad3 { get; set; }

    public short Sabad3In { get; set; }

    public short Sabad4 { get; set; }

    public short Sabad4In { get; set; }

    public short Sabad5 { get; set; }

    public short Sabad5In { get; set; }

    public int Count { get; set; }

    public int TalafCnt { get; set; }

    public int ZayeCnt { get; set; }

    public int ZayenCnt { get; set; }

    public decimal TalafVazn { get; set; }

    public decimal ZayeVazn { get; set; }

    public decimal ZayenVazn { get; set; }

    public string StartDa { get; set; } = null!;

    public string StartTi { get; set; } = null!;

    public string EndDa { get; set; } = null!;

    public string EndTi { get; set; } = null!;

    public string Sharh { get; set; } = null!;

    public string IndtDa { get; set; } = null!;

    public string IndtTi { get; set; } = null!;

    public string IndtUser { get; set; } = null!;

    public string VorodDa { get; set; } = null!;

    public string VorodTi { get; set; } = null!;

    public string KhorojDa { get; set; } = null!;

    public string KhorojTi { get; set; } = null!;

    public string Date { get; set; } = null!;

    public int? IdToyor { get; set; }

    public byte IdOk { get; set; }

    public int? IdPeriod { get; set; }

    public int KoshtarNo { get; set; }

    public decimal Masafat { get; set; }

    public int? IdBranch { get; set; }

    public short? IdBrngrp { get; set; }

    public virtual Sehesabgroupdetail? IdAmaniNavigation { get; set; }

    public virtual Sebranch? IdBranchNavigation { get; set; }

    public virtual Sebranchgroup? IdBrngrpNavigation { get; set; }

    public virtual Sehesabgroupdetail? IdCtmNavigation { get; set; }

    public virtual Sehesabgroupdetail? IdDrvNavigation { get; set; }

    public virtual Seform IdFormNavigation { get; set; } = null!;

    public virtual Sehesabgroupdetail? IdKamionNavigation { get; set; }

    public virtual Sehesabgroupdetail? IdMantegNavigation { get; set; }

    public virtual Sehesabgroupdetail? IdMordarNavigation { get; set; }

    public virtual Seok IdOkNavigation { get; set; } = null!;

    public virtual Seperiod? IdPeriodNavigation { get; set; }

    public virtual Sehesabgroupdetail? IdToyorNavigation { get; set; }

    public virtual ICollection<Seanboth> Seanboths { get; set; } = new List<Seanboth>();

    public virtual ICollection<Sefactor> Sefactors { get; set; } = new List<Sefactor>();

    public virtual ICollection<Sehvlrsd> Sehvlrsds { get; set; } = new List<Sehvlrsd>();
}
