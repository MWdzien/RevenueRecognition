using RevenueRecognition.Domain.Exceptions;

namespace RevenueRecognition.Domain.ValueObjects;

public record CustomerName
{
    public string Value { get; }

    public CustomerName(string value)
    {
        if (string.IsNullOrWhiteSpace(value))
        {
            throw new EmptyAttributeException("Customer", nameof(CustomerName));
        }

        Value = value;
    }

    public static implicit operator string(CustomerName name) => name.Value;
    public static implicit operator CustomerName(string lastName) => new(lastName);
}