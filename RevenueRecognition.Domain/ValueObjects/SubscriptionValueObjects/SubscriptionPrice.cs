using RevenueRecognition.Domain.Exceptions;

namespace RevenueRecognition.Domain.ValueObjects.SubscriptionValueObjects;

public record SubscriptionPrice
{
    public decimal Value { get; set; }

    public SubscriptionPrice(decimal value)
    {
        if (value < 0)
            throw new InvalidAttributeException(nameof(SubscriptionPrice), "a positive number");
        
        Value = value;
    }
    public static implicit operator decimal(SubscriptionPrice price) => price.Value;
    public static implicit operator SubscriptionPrice(decimal price) => new(price);
}