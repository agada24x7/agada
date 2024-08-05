using System;
using System.Collections.Generic;

namespace agadadotnet.Models;

public partial class Area
{
    public int AId { get; set; }

    public string Aname { get; set; } = null!;

    public string? Pincode { get; set; }

    public int? CId { get; set; }

    public virtual City? CIdNavigation { get; set; }

    public virtual ICollection<Shop> Shops { get; set; } = new List<Shop>();

    public virtual ICollection<User> Users { get; set; } = new List<User>();
}
