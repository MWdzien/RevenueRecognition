using RevenueRecognition.Domain.Entities;
using RevenueRecognition.Domain.Exceptions;

namespace RevenueRecognition.Domain.ValueObjects.DiscountValueObjects;

public record DiscountRate
{
    public decimal Value { get; set; }

    public DiscountRate(decimal value)
    {
        if (value is <= 0 or > 1)
            throw new InvalidAttributeException(nameof(DiscountRate), "a number between 0 and 1");
        
        Value = value;
    }
    public static implicit operator decimal(DiscountRate rate) => rate.Value;
    public static implicit operator DiscountRate(decimal rate) => new(rate);
}