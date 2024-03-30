using System;
using System.Collections.Generic;

namespace BusinessObjects.Models;

public partial class Food
{
    public int FoodId { get; set; }

    public int CategoryId { get; set; }

    public decimal Price { get; set; }

    public string FoodName { get; set; } = null!;

    public string? Image { get; set; }

    public bool Status { get; set; }

    public virtual Category Category { get; set; } = null!;

    public virtual ICollection<OrderDetail> OrderDetails { get; set; } = new List<OrderDetail>();

    public override string ToString()
    {
        return FoodName; // Định rõ cách hiển thị của đối tượng trong ComboBox
    }
}
