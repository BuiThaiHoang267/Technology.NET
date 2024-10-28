using System;
using System.Collections.Generic;

namespace SHOPTEST.Models;

public partial class Order
{
    public int Id { get; set; }

    public DateTime OrderDate { get; set; }

    public decimal TotalAmount { get; set; }

    public virtual ICollection<OrderDetail> OrderDetails { get; set; } = new List<OrderDetail>();
}
