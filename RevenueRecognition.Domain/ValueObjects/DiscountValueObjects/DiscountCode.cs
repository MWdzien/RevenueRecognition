using System.Text.RegularExpressions;
using RevenueRecognition.Domain.Exceptions;
using RevenueRecognition.Domain.Exceptions.DiscountExceptions;

namespace RevenueRecognition.Domain.ValueObjects.DiscountValueObjects;

public record DiscountCode
{
    public string Value { get; set; }

    public DiscountCode(string value)
    {
        if (String.IsNullOrWhiteSpace(value))
            throw new EmptyAttributeException("Discount", nameof(DiscountCode));

        if (!Regex.IsMatch(value, @"^[A-Z]{4}[0-9]{2}"))
            throw new InvalidAttributeException(nameof(DiscountCode), "in specified format");
        
        Value = value;
    }
    
    public static implicit operator string(DiscountCode code) => code.Value;
    public static implicit operator DiscountCode(string code) => new(code);

}