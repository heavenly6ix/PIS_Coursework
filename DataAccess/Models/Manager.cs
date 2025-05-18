using System;
using System.Collections.Generic;

namespace DataAccess.Models;

public partial class Manager
{
    public int IdManager { get; set; }

    public string? Login { get; set; }

    public string? FullName { get; set; }

    public string? PhoneNumber { get; set; }

    public string? DeliveryAdress { get; set; }

    public string? HashPassword { get; set; }

    public virtual ICollection<Order> Orders { get; set; } = new List<Order>();
}
