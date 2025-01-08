using RevenueRecognition.Domain.Exceptions;

namespace RevenueRecognition.Domain.ValueObjects.SoftwareValueObjects;

public record SoftwareName
{
    public string Value { get; set; }

    public SoftwareName(string value)
    {
        if (String.IsNullOrEmpty(value))
            throw new EmptyAttributeException("Software", nameof(SoftwareName));
        
        Value = value;
    }
    
    public static implicit operator string(SoftwareName name) => name.Value;
    public static implicit operator SoftwareName(string name) => new(name);
}