using System;
using System.Collections.Generic;

namespace BaiThucHanh2.Models;

public partial class PurchaseInvoiceItem
{
    public int PurchaseInvoiceId { get; set; }

    public int IngredientId { get; set; }

    public int Quantity { get; set; }

    public decimal UnitPrice { get; set; }

    public DateTime? CreatedAt { get; set; }

    public DateTime? UpdatedAt { get; set; }

    public int? CreatedBy { get; set; }

    public int? UpdatedBy { get; set; }

    public DateTime? DeletedAt { get; set; }

    public virtual Ingredient Ingredient { get; set; } = null!;

    public virtual PurchaseInvoice PurchaseInvoice { get; set; } = null!;
}
