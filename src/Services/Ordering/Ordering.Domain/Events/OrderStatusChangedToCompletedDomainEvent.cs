namespace Microsoft.eShopOnContainers.Services.Ordering.Domain.Events;

/// <summary>
/// Event used when the order stock items are confirmed
/// </summary>
public class OrderStatusChangedToCompletedDomainEvent
    : INotification
{
    public int OrderId { get; }

    public OrderStatusChangedToCompletedDomainEvent(int orderId)
        => OrderId = orderId;
}
