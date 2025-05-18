using System;
using System.Collections.Generic;

namespace DataAccess.Models;

public partial class Courier
{
    public int IdCourier { get; set; }

    public string? Login { get; set; }

    public string? FullName { get; set; }

    public string? PhoneNumber { get; set; }

    public string? HashPassword { get; set; }

    public virtual ICollection<CompletedOrder> CompletedOrders { get; set; } = new List<CompletedOrder>();

    public virtual ICollection<TakenOrder> TakenOrders { get; set; } = new List<TakenOrder>();
}
