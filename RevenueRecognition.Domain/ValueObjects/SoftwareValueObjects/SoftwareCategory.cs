using RevenueRecognition.Domain.Entities;
using RevenueRecognition.Domain.Exceptions;

namespace RevenueRecognition.Domain.ValueObjects.SoftwareValueObjects;

public record SoftwareCategory
{
    public string Value { get; set; }

    public SoftwareCategory(string value)
    {
        if (String.IsNullOrEmpty(value))
            throw new EmptyAttributeException(nameof(Software), nameof(SoftwareCategory));
        
        Value = value;
    }
    
    public static implicit operator string(SoftwareCategory category) => category.Value;
    public static implicit operator SoftwareCategory(string category) => new(category);
}