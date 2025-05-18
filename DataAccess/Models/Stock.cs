using System;
using System.Collections.Generic;

namespace DataAccess.Models;

public partial class Stock
{
    public int IdProduct { get; set; }

    public string? NameProduct { get; set; }

    public string? TypeProduct { get; set; }

    public int? CountInStock { get; set; }

    public virtual ICollection<OrderItem> OrderItems { get; set; } = new List<OrderItem>();
}
