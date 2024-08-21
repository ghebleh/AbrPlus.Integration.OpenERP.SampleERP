using System;
using System.Collections.Generic;

namespace Noyan.Repository.Models;

public partial class Advancefindcolumn
{
    public int IdFndcol { get; set; }

    public byte IdFnd { get; set; }

    public string Title { get; set; } = null!;

    public short Tartib { get; set; }

    public string Field { get; set; } = null!;

    public string Fieldid { get; set; } = null!;

    public string Type { get; set; } = null!;

    public string Width { get; set; } = null!;

    public string Width1 { get; set; } = null!;

    public bool Searchable { get; set; }

    public byte Tblsrctype { get; set; }

    public string Tblsource { get; set; } = null!;

    public bool Tblonlylst { get; set; }

    public string? Tblsrcid { get; set; }

    public string Tblsource1 { get; set; } = null!;

    public virtual Advancefind IdFndNavigation { get; set; } = null!;
}
