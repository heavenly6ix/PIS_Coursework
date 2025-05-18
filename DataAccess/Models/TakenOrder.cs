using System;
using System.Collections.Generic;

namespace DataAccess.Models;

public partial class TakenOrder
{
    public int IdTakenOrder { get; set; }

    public int? IdOrder { get; set; }

    public int? IdCourier { get; set; }

    public int? IdManager { get; set; }

    public string? Status { get; set; }

    public DateTime? CreatedDate { get; set; }

    public virtual Courier? IdCourierNavigation { get; set; }

    public virtual Order? IdOrderNavigation { get; set; }
}


