using POS.Domain.Abstractions;
using POS.Domain.Shared;

namespace POS.Domain.Suppliers;

public static class SupplierErrors
{
    public static Error NotFound(int supplierId)
    {
        return new Error(
            Code: "Supplier.NotFound",
            Description: $"The specified Supplier with the Id: {supplierId} Was Not Found.",
            ErrorType: Error.Type.NotFound
        );
    }

    public static Error ContactPersonPhoneAlreadyExists(ContactPerson contactPerson)
    {
        return new Error(
            Code: "Supplier.ContactPerson.Phone.AlreadyExists",
            Description: $"The specified ContactPerson.Phone: {contactPerson}  has already been used by another user.",
            ErrorType: Error.Type.Domain
        );
    }
}
