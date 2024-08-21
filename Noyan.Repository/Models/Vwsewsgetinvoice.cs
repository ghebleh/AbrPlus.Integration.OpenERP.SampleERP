using System;
using System.Collections.Generic;

namespace Noyan.Repository.Models;

public partial class Vwsewsgetinvoice
{
    public string Date { get; set; } = null!;

    public int No { get; set; }

    public string CustomerId { get; set; } = null!;

    public decimal CustomerCode { get; set; }

    public string CustomerName { get; set; } = null!;

    public string ProductId { get; set; } = null!;

    public decimal ProductCode { get; set; }

    public string ProductName { get; set; } = null!;

    public decimal? Count { get; set; }

    public decimal? Price { get; set; }

    public decimal? Amount { get; set; }

    public decimal? Discount { get; set; }

    public decimal? AmountAfterDis { get; set; }

    public decimal? Tax { get; set; }

    public decimal? TotalAmount { get; set; }
}
