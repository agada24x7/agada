using System;
using System.Collections.Generic;

namespace agadadotnet.Models;

public partial class Shop
{
    public int ShId { get; set; }

    public string Shname { get; set; } = null!;

    public string? RegNo { get; set; }

    public string? LicenseNo { get; set; }

    public int? UId { get; set; }

    public int? AId { get; set; }

    public string? Address { get; set; }

    public virtual Area? AIdNavigation { get; set; }

    public virtual User? UIdNavigation { get; set; }
}
