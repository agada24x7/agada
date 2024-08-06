using System;
using System.Collections.Generic;

namespace agadadotnet.Models;

public partial class User
{
    public int UId { get; set; }

    public string? Fname { get; set; }

    public string? Lname { get; set; }

    public string? Email { get; set; }

    public string? Contact { get; set; }

    public int? AId { get; set; }

    public string? Address { get; set; }

    public int? RId { get; set; }

    public sbyte? Status { get; set; }

    public string? Username { get; set; }

    public string? Password { get; set; }

    public virtual Area? AIdNavigation { get; set; }

    public virtual Role? RIdNavigation { get; set; }

    public virtual ICollection<Shop>? Shops { get; set; } = new List<Shop>();

    public virtual ICollection<Role>? roles { get; set; } = new List<Role>();
}
