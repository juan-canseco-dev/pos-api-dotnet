

using POS.Domain.Abstractions;

namespace POS.Domain.Products;

public static class ProductErrors
{
    public static Error NotFound(int productId)
    {
        return new Error(
            Code: "Product.NotFound",
            Description: $"The specified Product with the Id: {productId} Was Not Found.",
            ErrorType: Error.Type.NotFound
        );
    }

    public static Error NegativeProfit = new(
        Code: "Product.Price.NegativeProfit",
        Description: "Sale Price Must Be Greater Than Purchase Price.",
        ErrorType: Error.Type.NotFound
    );

}
