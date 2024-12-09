using POS.Domain.Abstractions;

namespace POS.Domain.Purchases;

public static class PurchaseErrors
{
    public static Error NotFound(int purchaseId)
    {
        return new Error(
            Code: "Purchase.NotFound",
            Description: $"The specified Purchase with the Id: {purchaseId} Was Not Found.",
            ErrorType: Error.Type.NotFound
        );
    }

    public static Error AlreadyReceived(int purchaseId)
    {
        return new Error(
            Code: "Purchase.AlreadyReceived",
            Description: $"The specified Purchase with the Id: {purchaseId} is alredy received.",
            ErrorType: Error.Type.Domain
        );
    }
}
