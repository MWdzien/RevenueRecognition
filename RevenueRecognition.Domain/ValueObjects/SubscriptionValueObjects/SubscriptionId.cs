using RevenueRecognition.Domain.Entities;
using RevenueRecognition.Domain.Exceptions;

namespace RevenueRecognition.Domain.ValueObjects.SubscriptionValueObjects;

public record SubscriptionId
{
    public Guid Value { get; set; }

    public SubscriptionId(Guid value)
    {
        if (value == Guid.Empty)
            throw new EmptyAttributeException(nameof(Subscription), nameof(SubscriptionId));
        
        Value = value;
    }
    
    public static implicit operator Guid(SubscriptionId id) => id.Value;
    public static implicit operator SubscriptionId(Guid id) => new(id);
}