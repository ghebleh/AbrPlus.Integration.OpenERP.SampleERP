using System;
using System.Collections.Generic;

namespace Noyan.Repository.Models;

public partial class Sefactorscale
{
    public int IdFctscl { get; set; }

    public int? IdBranch { get; set; }

    public short? IdScl { get; set; }

    public bool Cancel { get; set; }

    public string Ip { get; set; } = null!;

    public byte Marketcode { get; set; }

    public byte Storecode { get; set; }

    public byte Devicecode { get; set; }

    public byte Vending { get; set; }

    public string Saletype { get; set; } = null!;

    public string Date { get; set; } = null!;

    public string Time { get; set; } = null!;

    public int FactSerno { get; set; }

    public short FactNo { get; set; }

    public byte RowNo { get; set; }

    public string Codekala { get; set; } = null!;

    public decimal Meghdar { get; set; }

    public int Fi { get; set; }

    public int Total { get; set; }

    public short CellNo { get; set; }

    public short IndexNo { get; set; }

    public byte? FactRows { get; set; }

    public int? FactTotal { get; set; }

    public decimal? FactMegh { get; set; }

    public string? IndtDa { get; set; }

    public string? IndtTi { get; set; }

    public virtual Sebranch? IdBranchNavigation { get; set; }

    public virtual Sescale? IdSclNavigation { get; set; }

    public virtual ICollection<Sefactordetail> Sefactordetails { get; set; } = new List<Sefactordetail>();
}
