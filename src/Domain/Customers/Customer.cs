using POS.Domain.Shared;

namespace POS.Domain.Customers;

public class Customer
{
    public string? IdentificationCode { get; set; }
    public ContactPerson? ContactPerson { get; set; }
    public Address? Address { get; set; }

    private Customer() {}
}


