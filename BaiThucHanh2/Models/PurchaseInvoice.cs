using System;
using System.Collections.Generic;

namespace BaiThucHanh2.Models;

public partial class PurchaseInvoice
{
    public int Id { get; set; }

    public decimal TotalPrice { get; set; }

    public int BranchId { get; set; }

    public int SupplierId { get; set; }

    public int EmployeeId { get; set; }

    public DateTime? CreatedAt { get; set; }

    public DateTime? UpdatedAt { get; set; }

    public int? CreatedBy { get; set; }

    public int? UpdatedBy { get; set; }

    public DateTime? DeletedAt { get; set; }

    public virtual Branch Branch { get; set; } = null!;

    public virtual Employee Employee { get; set; } = null!;

    public virtual ICollection<PurchaseInvoiceItem> PurchaseInvoiceItems { get; set; } = new List<PurchaseInvoiceItem>();

    public virtual Supplier Supplier { get; set; } = null!;
}
