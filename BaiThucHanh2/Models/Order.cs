using System;
using System.Collections.Generic;

namespace BaiThucHanh2.Models;

public partial class Order
{
    public int Id { get; set; }

    public decimal TotalPrice { get; set; }

    public string Status { get; set; } = null!;

    public int BranchId { get; set; }

    public int NumberOrder { get; set; }

    public int PaymentMethodId { get; set; }

    public DateTime? CreatedAt { get; set; }

    public DateTime? UpdatedAt { get; set; }

    public int? CreatedBy { get; set; }

    public int? UpdatedBy { get; set; }

    public DateTime? DeletedAt { get; set; }

    public virtual Branch Branch { get; set; } = null!;

    public virtual ICollection<OrderItem> OrderItems { get; set; } = new List<OrderItem>();

    public virtual PaymentMethod PaymentMethod { get; set; } = null!;
}
