using POS.Domain.Abstractions;
using POS.Domain.Purchases.Events;
using POS.Domain.Suppliers;

namespace POS.Domain.Purchases;

public class Purchase : Entity<int>
{
    private readonly List<PurchaseItem> _items = new();
    public int SupplierId { get; private set; }
    public int AgentId { get; private set; }
    public decimal Total { get; private set; }
    public virtual IReadOnlyCollection<PurchaseItem> Items => _items.AsReadOnly();
    public PurchaseStatus Status { get; private set; } = PurchaseStatus.Pending;
    public virtual Supplier? Supplier { get; }
    public virtual Agent? Agent { get; }

    private void UpdateTotal() => Total = _items.Sum(i => i.Total);

    private Purchase() { }

    public Purchase(int supplierId, List<PurchaseItem> items)
    {
        SupplierId = supplierId;
        _items.AddRange(items);
        UpdateTotal();
        RaiseDomainEvent(new PurchasePlacedDomainEvent(Id));
    }

    public Result Update(List<PurchaseItem> items)
    {
        if (Status == PurchaseStatus.Received)
            return Result.Failure(PurchaseErrors.AlreadyReceived(Id));

        Dictionary<int, int> productsWithQuantities = Items
            .ToDictionary(item => item.ProductId, item => item.Quantity);

        Dictionary<int, int> modifiedProductsWithQuantities = items
            .ToDictionary(item => item.ProductId, item => item.Quantity);

        _items.Clear();
        _items.AddRange(items);

        RaiseDomainEvent(new PurchaseModifiedDomainEvent(Id, productsWithQuantities, modifiedProductsWithQuantities));

        return Result.Success();
    }

    public Result Receive()
    {
        if (Status == PurchaseStatus.Received)
            return Result.Failure(PurchaseErrors.AlreadyReceived(Id));

        RaiseDomainEvent(new PurchaseReceivedDomainEvent(Id));

        Status = PurchaseStatus.Received;
        return Result.Success();
    }
}
