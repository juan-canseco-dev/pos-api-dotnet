using POS.Domain.Abstractions;
using POS.Domain.Shared;

namespace POS.Domain.Customers;

public static class CustomerErrors
{
    public static Error NotFound(int customerId)
    {
        return new Error(
            Code: "Customer.NotFound",
            Description: $"The specified Customer with the Id: {customerId} Was Not Found.",
            ErrorType: Error.Type.NotFound
        );
    }

    public static Error IdentificationCodeAlreadyExists(string identificationCode)
    {
        return new Error(
          Code: "Customer.IdentificationCodeAlreadyExists",
          Description: $"The specified IdentificationCode: {identificationCode} has already been used by another user.",
          ErrorType: Error.Type.Domain
      );
    }

    public static Error ContactPersonPhoneAlreadyExists(ContactPerson contactPerson)
    {
        return new Error(
            Code: "Customer.ContactPerson.Phone.AlreadyExists",
            Description: $"The specified ContactPerson.Phone: {contactPerson}  has already been used by another user.",
            ErrorType: Error.Type.Domain
        );
    }
}
