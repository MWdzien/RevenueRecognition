using RevenueRecognition.Domain.Entities;
using RevenueRecognition.Domain.Exceptions;

namespace RevenueRecognition.Domain.ValueObjects.DiscountValueObjects;

public record DiscountOffer
{
    public string Value { get; set; }

    public DiscountOffer(string value)
    {
        if (String.IsNullOrEmpty(value))
            throw new EmptyAttributeException(nameof(Discount), nameof(DiscountOffer));
        
        Value = value;
    }
    
    public static implicit operator string(DiscountOffer offer) => offer.Value;
    public static implicit operator DiscountOffer(string offer) => new(offer);
}