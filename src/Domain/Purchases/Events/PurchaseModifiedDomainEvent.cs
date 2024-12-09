using POS.Domain.Abstractions;

namespace POS.Domain.Purchases.Events;

public record PurchaseModifiedDomainEvent(
    int PurchaseId,
    Dictionary<int, int> ProductsWithQuantities,
    Dictionary<int, int> ModifiedProductsWithQuantities
) : IDomainEvent;