using POS.Domain.Abstractions;

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

    public static Error PhoneNumberAlreadyExists(string phone)
    {
        return new Error(
            Code: "Supplier.Phone.AlreadyExists",
            Description: $"The specified Phone number: {phone} has already been used by another user.",
            ErrorType: Error.Type.Domain
        );
    }

}
