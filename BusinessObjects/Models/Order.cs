using System;
using System.Collections.Generic;

namespace BusinessObjects.Models;

public partial class Order
{
    public int OrderId { get; set; }

    public DateTime OrderTime { get; set; }

    public decimal TotalPrice { get; set; }

    public int AmountOfPeople { get; set; }

    public int? CustomerId { get; set; }

    public int UserId { get; set; }

    public int TableId { get; set; }

    public string Status { get; set; } = null!;

    public virtual ICollection<Bill> Bills { get; set; } = new List<Bill>();

    public virtual Customer? Customer { get; set; } = null;

    public virtual ICollection<OrderDetail> OrderDetails { get; set; } = new List<OrderDetail>();

    public virtual Table Table { get; set; } = null!;

    public virtual User User { get; set; } = null!;
}
