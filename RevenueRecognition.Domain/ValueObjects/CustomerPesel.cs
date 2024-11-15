using RevenueRecognition.Domain.Exceptions;

namespace RevenueRecognition.Domain.ValueObjects;

public class CustomerPesel
{
    public string Value { get; }

    public CustomerPesel(string value)
    {
        if (string.IsNullOrWhiteSpace(value))
        {
            throw new EmptyCustomerAttributeException(nameof(CustomerPesel));
        }

        if (value.Length != 11 || !value.All(char.IsDigit))
        {
            throw new InvalidCustomerAttributeException(nameof(CustomerPesel), "Pesel has to be 11 digits long");
        }

        Value = value;
    }

    public static implicit operator string(CustomerPesel pesel) => pesel.Value;
    public static implicit operator CustomerPesel(string pesel) => new(pesel);
}