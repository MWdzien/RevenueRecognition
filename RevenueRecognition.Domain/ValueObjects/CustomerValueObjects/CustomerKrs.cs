using RevenueRecognition.Domain.Exceptions;
using RevenueRecognition.Domain.Exceptions.CustomerExceptions;

namespace RevenueRecognition.Domain.ValueObjects;

public class CustomerKrs
{
    public string Value { get; set; }

    public CustomerKrs(string value)
    {
        if (string.IsNullOrWhiteSpace(value))
        {
            throw new EmptyAttributeException("Customer", nameof(CustomerKrs));
        }

        if (value.Length != 10 || !value.All(char.IsDigit))
        {
            throw new InvalidCustomerAttributeException(nameof(CustomerKrs), "KRS has to be 10 digits long");
        }

        Value = value;
    }

    public static implicit operator string(CustomerKrs krs) => krs.Value;
    public static implicit operator CustomerKrs(string krs) => new(krs);
}