using System;
using System.Collections.Generic;

namespace DataAccess.Models;

public partial class StockAdmin
{
    public int IdAdmin { get; set; }

    public string? Login { get; set; }

    public string? FullName { get; set; }

    public string? HashPassword { get; set; }
}
