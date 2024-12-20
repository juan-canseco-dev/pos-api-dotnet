﻿using POS.Domain.Abstractions;
using POS.Domain.Shared;

namespace POS.Domain.Suppliers;

public class Agent : Entity<int>
{
    public int SupplierId { get; set; }
    public ContactPerson? ContactPerson { get; set; }
    public virtual Supplier? Supplier { get; }
    private Agent() { }
}
