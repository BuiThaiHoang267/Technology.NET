using System;
using System.Collections.Generic;

namespace BaiThucHanh2.Models;

public partial class Employee
{
    public int Id { get; set; }

    public string Name { get; set; } = null!;

    public string? Location { get; set; }

    public string? Phone { get; set; }

    public string? Email { get; set; }

    public string? Cccd { get; set; }

    public DateTime? DateOfBirth { get; set; }

    public string? Description { get; set; }

    public int BranchId { get; set; }

    public int? PositionId { get; set; }

    public DateTime? CreatedAt { get; set; }

    public DateTime? UpdatedAt { get; set; }

    public int? CreatedBy { get; set; }

    public int? UpdatedBy { get; set; }

    public DateTime? DeletedAt { get; set; }

    public virtual Branch Branch { get; set; } = null!;

    public virtual Position? Position { get; set; }

    public virtual ICollection<PurchaseInvoice> PurchaseInvoices { get; set; } = new List<PurchaseInvoice>();
}
