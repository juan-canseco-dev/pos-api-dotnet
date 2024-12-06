using POS.Domain.Abstractions;
using POS.Domain.Shared;

namespace POS.Domain.Suppliers;

public static class AgentErrors
{
    public static Error NotFound(int agentId)
    {
        return new Error(
            Code: "Agent.NotFound",
            Description: $"The specified Agent with the Id: {agentId} Was Not Found.",
            ErrorType: Error.Type.NotFound
        );
    }

    public static Error ContactPersonPhoneAlreadyExists(ContactPerson contactPerson)
    {
        return new Error(
            Code: "Agent.ContactPerson.Phone.AlreadyExists",
            Description: $"The specified ContactPerson.Phone: {contactPerson}  has already been used by another user.",
            ErrorType: Error.Type.Domain
        );
    }
}
