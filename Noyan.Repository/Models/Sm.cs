using System;
using System.Collections.Generic;

namespace Noyan.Repository.Models;

public partial class Sm
{
    public int IdSms { get; set; }

    public int? IdSmsmdl { get; set; }

    public byte WsType { get; set; }

    public string ToNo { get; set; } = null!;

    public string Descrip { get; set; } = null!;

    public string IndtDa { get; set; } = null!;

    public string IndtTi { get; set; } = null!;

    public bool Sent { get; set; }

    public string FromNo { get; set; } = null!;

    public string IdWs { get; set; } = null!;

    public string SentDa { get; set; } = null!;

    public string SentTi { get; set; } = null!;

    public string Computer { get; set; } = null!;

    public byte Expireday { get; set; }

    public short? Errorcode { get; set; }

    public virtual Smsmodule? IdSmsmdlNavigation { get; set; }

    public virtual ICollection<Sebeton> Sebetons { get; set; } = new List<Sebeton>();

    public virtual ICollection<Selabbetonnemooneh> Selabbetonnemoonehs { get; set; } = new List<Selabbetonnemooneh>();
}
