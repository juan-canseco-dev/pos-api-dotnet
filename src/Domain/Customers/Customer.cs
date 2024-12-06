using POS.Domain.Abstractions;
using POS.Domain.Shared;

namespace POS.Domain.Customers;

public class Customer : Entity<int>
{
    public string? IdentificationCode { get; set; }
    public ContactPerson? ContactPerson { get; set; }
    public Address? Address { get; set; }

    private Customer() {}
}


