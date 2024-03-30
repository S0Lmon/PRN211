using System;
using System.Collections.Generic;

namespace BusinessObjects.Models;

public partial class Bill
{
    public int BillId { get; set; }

    public int OrderId { get; set; }

    public DateTime CheckInDate { get; set; }

    public DateTime? CheckOutDate { get; set; }

    public decimal TotalPrice { get; set; }

    public virtual Order Order { get; set; } = null!;
}
