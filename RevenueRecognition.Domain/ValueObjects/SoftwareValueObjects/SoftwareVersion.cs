using System.Text.RegularExpressions;
using RevenueRecognition.Domain.Entities;
using RevenueRecognition.Domain.Exceptions;

namespace RevenueRecognition.Domain.ValueObjects.SoftwareValueObjects;

public record SoftwareVersion
{
    public string Value { get; set; }

    public SoftwareVersion(string value)
    {
        if (String.IsNullOrEmpty(value))
            throw new EmptyAttributeException(nameof(Software), nameof(SoftwareVersion));

        if (Regex.IsMatch(value, @".\..\.."))
            throw new InvalidAttributeException(nameof(SoftwareVersion), "in the format of 'x.x.x'");
        
        Value = value;
    }
    
    public static implicit operator string(SoftwareVersion version) => version.Value;
    public static implicit operator SoftwareVersion(string version) => new(version);
}