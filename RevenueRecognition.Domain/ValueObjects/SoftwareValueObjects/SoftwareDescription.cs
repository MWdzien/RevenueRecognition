using RevenueRecognition.Domain.Entities;
using RevenueRecognition.Domain.Exceptions;

namespace RevenueRecognition.Domain.ValueObjects.SoftwareValueObjects;

public record SoftwareDescription
{
    public string Value { get; set; }

    public SoftwareDescription(string value)
    {
        if (String.IsNullOrEmpty(value))
            throw new EmptyAttributeException(nameof(Software), nameof(SoftwareDescription));
        
        Value = value;
    }
    
    public static implicit operator string(SoftwareDescription description) => description.Value;
    public static implicit operator SoftwareDescription(string description) => new(description);
}