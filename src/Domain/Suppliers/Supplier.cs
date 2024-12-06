using POS.Domain.Abstractions;
using POS.Domain.Shared;

namespace POS.Domain.Suppliers;

public class Supplier : Entity<int>
{
    public int CompanyId { get; set; }
    public ContactPerson? ContactPerson { get; set; }
    public Address? Address { get; set; }
    public virtual Company? Company { get; }
    private Supplier() { }
}
