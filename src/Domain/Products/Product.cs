using POS.Domain.Abstractions;
using POS.Domain.Suppliers;

namespace POS.Domain.Products;

public class Product : Entity<int>
{

    public int SupplierId { get; set; }
    public int CategoryId { get; set; }
    public int UnitId { get; set; }
    public string? Name { get; set; }
    public decimal PurchasePrice { get; private set; }
    public decimal SalePrice { get; private set; }

    public virtual Supplier? Supplier { get; }
    public virtual Category? Category { get; }
    public virtual Unit? Unit { get; }
    public virtual Stock? Stock { get; }

    private Product() { }

    private Product(
        int supplierId, 
        int categoryId, 
        int unitId, 
        string? name, 
        decimal purchasePrice, 
        decimal salePrice
    )
    {
        SupplierId = supplierId;
        CategoryId = categoryId;
        UnitId = unitId;
        Name = name;
        PurchasePrice = purchasePrice;
        SalePrice = salePrice;
        Stock = new Stock();
    }

    public static Result<Product> Create(
        int supplierId,
        int categoryId,
        int unitId,
        string? name,
        decimal purchasePrice,
        decimal salePrice)
    {
        if (salePrice <= purchasePrice)
        {
            return Result.Failure<Product>(ProductErrors.NegativeProfit);
        }

        var product = new Product(
            supplierId,
            categoryId,
            unitId,
            name,
            purchasePrice,
            salePrice
        );

        return Result.Success(product);
    }

    public Result ChangePrice(decimal purchasePrice, decimal salePrice)
    {
        if (salePrice <= purchasePrice)
        {
            return Result.Failure<Product>(ProductErrors.NegativeProfit);
        }

        return Result.Success();
    }

}
