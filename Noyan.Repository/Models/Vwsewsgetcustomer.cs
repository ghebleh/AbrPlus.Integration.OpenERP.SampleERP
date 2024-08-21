using System;
using System.Collections.Generic;

namespace Noyan.Repository.Models;

public partial class Vwsewsgetcustomer
{
    public string Id { get; set; } = null!;

    public byte? Type { get; set; }

    public decimal Code { get; set; }

    public string Name { get; set; } = null!;

    public string? NationalNo { get; set; }

    public string? Address { get; set; }

    public string? Tel { get; set; }

    public string? Mobile { get; set; }

    public string? BirthDate { get; set; }
}
