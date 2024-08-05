﻿using System;
using System.Collections.Generic;

namespace agadadotnet.Models;

public partial class Role
{
    public int RId { get; set; }

    public string Rname { get; set; } = null!;

    public virtual ICollection<User> Users { get; set; } = new List<User>();
}
