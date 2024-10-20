using System;
using System.Collections.Generic;

namespace BaiThucHanh2.Models;

public partial class Role
{
    public int Id { get; set; }

    public string Name { get; set; } = null!;

    public string? Description { get; set; }

    public DateTime? CreatedAt { get; set; }

    public DateTime? UpdatedAt { get; set; }

    public int? CreatedBy { get; set; }

    public int? UpdatedBy { get; set; }

    public DateTime? DeletedAt { get; set; }

    public string Code { get; set; } = null!;

    public virtual ICollection<User> Users { get; set; } = new List<User>();
}
