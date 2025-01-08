using RevenueRecognition.Domain.Exceptions;

namespace RevenueRecognition.Domain.ValueObjects.SubscriptionValueObjects;

public record SubscriptionRenewalPeriod
{
    public int Value { get; set; }

    public SubscriptionRenewalPeriod(int value)
    {
        if (value is < 1 or > 24)
            throw new InvalidAttributeException(nameof(SubscriptionRenewalPeriod), "a number between 1 and 24");
        
        Value = value;
    }
    
    public static implicit operator int(SubscriptionRenewalPeriod period) => period.Value;
    public static implicit operator SubscriptionRenewalPeriod(int period) => new(period);
}