using POS.Domain.Abstractions;

namespace POS.Domain.Products;

public static class StockErrors
{
    public static Error QuantityNegativeOrZero = new Error(
        Code: "Stock.Quantity.NegativeOrZero",
        Description: $"Quantity must be greater than zero.",
        ErrorType: Error.Type.Domain
     );

    public static Error InvalidOperation(int removeQuantity, Stock stock)
    {
        return new Error(
         Code: "Stock.InvalidOperation",
         Description: $"Invalid stock operation: Cannot remove {removeQuantity} units from inventory. Current stock quantity for ProductId {stock.ProductId}: {stock.Quantity}.",
         ErrorType: Error.Type.Domain
     );
    }

}
