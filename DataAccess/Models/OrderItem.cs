using System;
using System.Collections.Generic;

namespace DataAccess.Models;

public partial class OrderItem
{
    public int IdOrderItem { get; set; }
    public int IdOrder { get; set; }

    public int IdProduct { get; set; }

    public int? CountProduct { get; set; }

    public virtual Order IdOrderNavigation { get; set; } = null!;

    public virtual Stock IdProductNavigation { get; set; } = null!;
}
