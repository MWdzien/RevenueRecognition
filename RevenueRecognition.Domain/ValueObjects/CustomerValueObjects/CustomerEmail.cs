using RevenueRecognition.Domain.Exceptions;
using RevenueRecognition.Domain.Exceptions.CustomerExceptions;

namespace RevenueRecognition.Domain.ValueObjects;

public record CustomerEmail
{
    public string Value { get; }

    public CustomerEmail(string value)
    {
        if (string.IsNullOrWhiteSpace(value))
        {
            throw new EmptyAttributeException("Customer", nameof(CustomerEmail));
        }

        // should be using regex, but wanted to make it look simpler
        if (!value.Contains('@') || !value.Contains('.'))
        {
            throw new InvalidCustomerAttributeException(nameof(CustomerEmail), "email has to contain '@' and '.' symbols");
        }

        Value = value;
    }
    
    public static implicit operator string(CustomerEmail email) => email.Value;
    public static implicit operator CustomerEmail(string email) => new(email);
}