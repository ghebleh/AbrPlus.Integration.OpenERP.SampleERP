using System;
using System.Collections.Generic;

namespace Noyan.Repository.Models;

public partial class Vwsebeton
{
    public int IdBeton { get; set; }

    public int? IdBranch { get; set; }

    public short? IdBrngrp { get; set; }

    public int? IdPeriod { get; set; }

    public int IdForm { get; set; }

    public int BetonNo { get; set; }

    public string Date { get; set; } = null!;

    public string Time { get; set; } = null!;

    public byte ShiftNo { get; set; }

    public string Datetahvil { get; set; } = null!;

    public int? CtmHsb { get; set; }

    public int? CtmHsbd { get; set; }

    public int? BtnHsb { get; set; }

    public int? BtnHsbd { get; set; }

    public decimal BtnSefar { get; set; }

    public decimal OrdMeter { get; set; }

    public decimal MazMeter { get; set; }

    public decimal BtnMeter { get; set; }

    public decimal BtnFi { get; set; }

    public bool BtnKharid { get; set; }

    public short BtnAyar { get; set; }

    public int? SmnHsbd { get; set; }

    public int? MogHsbd { get; set; }

    public string TempWater { get; set; } = null!;

    public string TempBeton { get; set; } = null!;

    public string TempMohit { get; set; } = null!;

    public string Eslamp { get; set; } = null!;

    public string Maghsad { get; set; } = null!;

    public int? MsfHsbd { get; set; }

    public decimal BzrMab { get; set; }

    public int? BzrHsb { get; set; }

    public int? BzrHsbd { get; set; }

    public int? KhrHsb { get; set; }

    public int? KhrHsbd { get; set; }

    public bool KhrComp { get; set; }

    public decimal KhrMeter { get; set; }

    public int KhrFi { get; set; }

    public int? TkhHsb { get; set; }

    public int? TkhHsbd { get; set; }

    public int? TktHsbd { get; set; }

    public string TkhDesc { get; set; } = null!;

    public decimal TkhMeter { get; set; }

    public int TkhFi { get; set; }

    public decimal TkhMab { get; set; }

    public bool TkmCalc { get; set; }

    public int TkmFi { get; set; }

    public decimal TkhMin { get; set; }

    public decimal TkaMab { get; set; }

    public string TkaDesc { get; set; } = null!;

    public decimal TknMab { get; set; }

    public decimal TknctmMab { get; set; }

    public decimal TkndarMab { get; set; }

    public int? TknHsb { get; set; }

    public int? TknHsbd { get; set; }

    public byte PmpbesTyp { get; set; }

    public int PmpbesFi { get; set; }

    public decimal PmpbesMab { get; set; }

    public bool PmpbesTkm { get; set; }

    public int PmpbesTkf { get; set; }

    public decimal PmpbesMin { get; set; }

    public decimal PmpbesTka { get; set; }

    public int? MixHsb { get; set; }

    public int? MixHsbd { get; set; }

    public int? MntHsbd { get; set; }

    public string DrvName { get; set; } = null!;

    public int KryFi { get; set; }

    public decimal KryMab { get; set; }

    public string MashinNo { get; set; } = null!;

    public bool KrtMode { get; set; }

    public int KrtFi { get; set; }

    public decimal KrtMeter { get; set; }

    public decimal KrtMab { get; set; }

    public decimal FullMeter { get; set; }

    public decimal KraMab { get; set; }

    public string KraDesc { get; set; } = null!;

    public decimal KryMabtot { get; set; }

    public byte MixbesTyp { get; set; }

    public int MixbesFi { get; set; }

    public decimal MixbesMab { get; set; }

    public decimal MixbesKtt { get; set; }

    public bool MixbesKrt { get; set; }

    public int MixbesKtf { get; set; }

    public decimal MixbesKtm { get; set; }

    public decimal MixbesFul { get; set; }

    public decimal MixbesKra { get; set; }

    public decimal MixbesMbt { get; set; }

    public decimal KrnMab { get; set; }

    public int KrnzarMab { get; set; }

    public decimal KrnctmMab { get; set; }

    public decimal KrndarMab { get; set; }

    public int? KrnHsb { get; set; }

    public int? KrnHsbd { get; set; }

    public decimal Vazn1 { get; set; }

    public int Vazn1Row { get; set; }

    public string Vazn1Date { get; set; } = null!;

    public string Vazn1Time { get; set; } = null!;

    public decimal Vazn2 { get; set; }

    public int Vazn2Row { get; set; }

    public string Vazn2Date { get; set; } = null!;

    public string Vazn2Time { get; set; } = null!;

    public decimal Vazn { get; set; }

    public decimal VaznMakh { get; set; }

    public bool VaznpkPrn { get; set; }

    public string Comment { get; set; } = null!;

    public string MasoolK { get; set; } = null!;

    public string TahvilG { get; set; } = null!;

    public string KharidNo { get; set; } = null!;

    public byte Kharidtype { get; set; }

    public decimal SimanV { get; set; }

    public string SimanM { get; set; } = null!;

    public decimal ShenV { get; set; }

    public string ShenM { get; set; } = null!;

    public decimal MasehV { get; set; }

    public string MasehM { get; set; } = null!;

    public decimal WaterV { get; set; }

    public int? BchHsbd { get; set; }

    public int? SimanAnb { get; set; }

    public int? ShenAnb { get; set; }

    public int? MasehAnb { get; set; }

    public string Afz1Name { get; set; } = null!;

    public decimal Afz1Vazn { get; set; }

    public string Afz1Karkh { get; set; } = null!;

    public string Afz1Code { get; set; } = null!;

    public string Afz2Name { get; set; } = null!;

    public decimal Afz2Vazn { get; set; }

    public string Afz2Karkh { get; set; } = null!;

    public string Afz2Code { get; set; } = null!;

    public decimal Looleh { get; set; }

    public string Eskelet { get; set; } = null!;

    public string Mogheiat { get; set; } = null!;

    public bool Manualend { get; set; }

    public bool Naghes { get; set; }

    public bool Cancel { get; set; }

    public bool NewEdit { get; set; }

    public string Mobileno { get; set; } = null!;

    public bool Sendsms { get; set; }

    public int? IdSms { get; set; }

    public string IndtDa { get; set; } = null!;

    public string IndtTi { get; set; } = null!;

    public string IndtUser { get; set; } = null!;

    public string NaMsf { get; set; } = null!;

    public string NaSmn { get; set; } = null!;

    public string NaMog { get; set; } = null!;

    public string NaTkt { get; set; } = null!;

    public string MntName { get; set; } = null!;

    public string BchName { get; set; } = null!;

    public string? BtnName { get; set; }

    public string? CtmCode { get; set; }

    public string? CtmName { get; set; }

    public string? MixCode { get; set; }

    public string? MixName { get; set; }

    public string? TkhCode { get; set; }

    public string? TkhName { get; set; }
}
