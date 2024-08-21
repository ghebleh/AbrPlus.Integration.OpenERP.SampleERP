using System;
using System.Collections.Generic;

namespace Noyan.Repository.Models;

public partial class Camera
{
    public byte IdCam { get; set; }

    public string Name { get; set; } = null!;

    public short Tartib { get; set; }

    public string Ipaddress { get; set; } = null!;

    public string Username { get; set; } = null!;

    public string Password { get; set; } = null!;
}
