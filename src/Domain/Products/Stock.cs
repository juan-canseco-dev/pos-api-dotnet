
using POS.Domain.Abstractions;

namespace POS.Domain.Products;

public class Stock : Entity<int>
{
    public int ProductId { get; }
    public int Quantity { get; private set; }

    public Result Add(int quantity)
    {
        if (quantity < 1)
        {
            return Result.Failure(StockErrors.QuantityNegativeOrZero);
        }

        var newQuantity = Quantity + quantity;
        Quantity = newQuantity;

        return Result.Success();
    }


    public Result Remove(int quantity)
    {
        if (quantity < 1)
        {
            return Result.Failure(StockErrors.QuantityNegativeOrZero);
        }

        if (quantity > Quantity)
        {
            return Result.Failure(StockErrors.InvalidOperation(quantity, this));
        }

        var newQuantity = Quantity - quantity;
        Quantity = newQuantity;

        return Result.Success();
    }

    public Stock()
    {
        ProductId = 0;
        Quantity = 0;
    }
}
