using RevenueRecognition.Domain.Entities;
using RevenueRecognition.Domain.Exceptions;

namespace RevenueRecognition.Domain.ValueObjects.SoftwareValueObjects;

public record SoftwareId
{
    public Guid Value { get; set; }

    public SoftwareId(Guid value)
    {
        if (value == Guid.Empty)
            throw new EmptyAttributeException(nameof(Software), nameof(SoftwareId));
        
        Value = value;
    }
    
    
    public static implicit operator Guid(SoftwareId id) => id.Value;
    public static implicit operator SoftwareId(Guid id) => new(id);
}