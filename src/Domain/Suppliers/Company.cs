using POS.Domain.Abstractions;
using POS.Domain.Shared;

namespace POS.Domain.Suppliers;

public class Company : Entity<int>
{
    public string? Name { get; set; }
    public string? Phone { get; set; }
    public Address? Address { get; set; }
    private Company() { }
}
