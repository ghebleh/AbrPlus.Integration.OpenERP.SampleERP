using System;
using System.Collections.Generic;

namespace Noyan.Repository.Models;

public partial class Message
{
    public int IdMsg { get; set; }

    public int MsgCode { get; set; }

    public string MsgText { get; set; } = null!;

    public string MsgTitle { get; set; } = null!;

    public string MsgIcon { get; set; } = null!;

    public string? MsgKeys { get; set; }

    public string? Defaultkey { get; set; }

    public string? Ignorekeys { get; set; }

    public short? MsgLeft { get; set; }

    public short? MsgTop { get; set; }

    public short? Alignment { get; set; }

    public string? TextHelp { get; set; }

    public string? TitleHelp { get; set; }

    public string? IconHelp { get; set; }

    public short? LeftHelp { get; set; }

    public short? TopHelp { get; set; }

    public short? AlignHelp { get; set; }

    public string CharSeper { get; set; } = null!;

    public int Timeout { get; set; }

    public int Timedelay { get; set; }

    public bool Isquestion { get; set; }
}
