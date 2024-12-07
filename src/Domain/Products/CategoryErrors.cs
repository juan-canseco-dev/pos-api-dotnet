using POS.Domain.Abstractions;

namespace POS.Domain.Products;

public static class CategoryErrors
{
    public static Error NotFound(int categoryId)
    {
        return new Error(
            Code: "Category.NotFound",
            Description: $"The specified Category with the Id: {categoryId} Was Not Found.",
            ErrorType: Error.Type.NotFound
        );
    }
}
