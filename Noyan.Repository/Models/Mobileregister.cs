using System;
using System.Collections.Generic;

namespace Noyan.Repository.Models;

public partial class Mobileregister
{
    public short IdPhone { get; set; }

    public bool Active { get; set; }

    public string Phoneno { get; set; } = null!;

    public string Imei { get; set; } = null!;

    public string Simserial { get; set; } = null!;

    public string Kry { get; set; } = null!;
}
