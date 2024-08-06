using System;
using System.Collections.Generic;

namespace agadadotnet.Models;

public partial class City
{
    public int CId { get; set; }

    public string Cname { get; set; } = null!;

    public virtual ICollection<Area> Areas { get; set; } = new List<Area>();
}
