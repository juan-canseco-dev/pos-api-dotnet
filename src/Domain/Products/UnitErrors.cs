using POS.Domain.Abstractions;

namespace POS.Domain.Products;

public static class UnitErrors
{
    public static Error NotFound(int unitId)
    {
        return new Error(
            Code: "Unit.NotFound",
            Description: $"The specified Unit with the Id: {unitId} Was Not Found.",
            ErrorType: Error.Type.NotFound
        );
    }
}
