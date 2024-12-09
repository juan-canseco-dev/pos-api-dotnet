using POS.Domain.Abstractions;

namespace POS.Domain.Purchases.Events;

public record PurchaseReceivedDomainEvent(int PurchaseId) : IDomainEvent;
