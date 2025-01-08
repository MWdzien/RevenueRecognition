
using RevenueRecognition.Domain.Exceptions;

namespace RevenueRecognition.Domain.ValueObjects;

public record CustomerAddress
{
    public string Value { get; }

    public CustomerAddress(string value)
    {
        if (string.IsNullOrWhiteSpace(value))
        {
            throw new EmptyAttributeException("Customer", nameof(CustomerAddress));
        }

        Value = value;
    }

    public static implicit operator string(CustomerAddress address) => address.Value;
    public static implicit operator CustomerAddress(string address) => new(address);
}