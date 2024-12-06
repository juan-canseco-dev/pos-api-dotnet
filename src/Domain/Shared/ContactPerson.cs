using POS.Domain.Abstractions;

namespace POS.Domain.Shared;

public class ContactPerson : ValueObject
{
    public string Fullname { get; }
    public string Phone { get; }

    // Required EF Core
    private ContactPerson()
    {
        Fullname = default!;
        Phone = default!;
    }

    public ContactPerson(string fullname, string phone)
    {
        Fullname = fullname;
        Phone = phone;
    }

    protected override IEnumerable<object> GetEqualityComponents()
    {
        yield return Fullname;
        yield return Phone;
    }
}