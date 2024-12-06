using POS.Domain.Abstractions;

namespace POS.Domain.Suppliers;

public static class CompanyErrors
{
    public static Error NotFound(int companyId)
    {
        return new Error(
            Code: "CompanyError.NotFound",
            Description: $"The specified Company with the Id: {companyId} Was Not Found.",
            ErrorType: Error.Type.NotFound
        );
    }

    public static Error PhoneNumberAlreadyExists(string phone)
    {
        return new Error(
            Code: "Company.Phone",
            Description: $"The specified Phone number: {phone} has already been used by another user.",
            ErrorType: Error.Type.Domain
        );
    }

}
