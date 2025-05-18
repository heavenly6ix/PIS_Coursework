using System;
using System.Collections.Generic;

namespace DataAccess.Models;

public partial class Order
{
    public int IdOrder { get; set; }

    public int? IdManager { get; set; }

    public bool IsCart { get; set; }

    public DateTime? CreatedDate { get; set; }

    public virtual ICollection<CompletedOrder> CompletedOrders { get; set; } = new List<CompletedOrder>();

    public virtual Manager? IdManagerNavigation { get; set; }

    public virtual ICollection<OrderItem> OrderItems { get; set; } = new List<OrderItem>();

    public virtual ICollection<TakenOrder> TakenOrders { get; set; } = new List<TakenOrder>();
}
