using POS.Domain.Abstractions;

namespace POS.Domain.Purchases.Events;

public record PurchasePlacedDomainEvent(int PurchaseId) : IDomainEvent;