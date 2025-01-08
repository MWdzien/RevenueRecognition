using RevenueRecognition.Domain.Entities;
using RevenueRecognition.Domain.Exceptions;

namespace RevenueRecognition.Domain.ValueObjects.DiscountValueObjects;

public record DiscountName
{
    public string Value { get; set; }

    public DiscountName(string value)
    {
        if (String.IsNullOrEmpty(value))
            throw new EmptyAttributeException(nameof(Discount), nameof(DiscountName));
        
        Value = value;
    }
    
    public static implicit operator string(DiscountName name) => name.Value;
    public static implicit operator DiscountName(string name) => new(name);
}