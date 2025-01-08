using RevenueRecognition.Domain.Exceptions;
using RevenueRecognition.Domain.Exceptions.CustomerExceptions;

namespace RevenueRecognition.Domain.ValueObjects;

public record CustomerPhoneNumber
{
    public string Value { get; }

    public CustomerPhoneNumber(string value)
    {
        // im assuming the number should look like "+(dial number)(phone number)", i.e. "+48323454341" and be at least 8 digits long
        value = value.Replace("-", "").Replace(" ", "");
        
        if (string.IsNullOrWhiteSpace(value))
        {
            throw new EmptyAttributeException("Customer", nameof(CustomerPhoneNumber));
        }

        if (value.StartsWith("+") || value.Length < 9 || !value.Replace("+", "").All(char.IsDigit))
        {
            throw new InvalidCustomerAttributeException(nameof(CustomerPhoneNumber), "Phone number has to start with dial number and has to be at least 8 digits long");
        }

        Value = value;
    }

    public static implicit operator string(CustomerPhoneNumber phoneNumber) => phoneNumber.Value;
    public static implicit operator CustomerPhoneNumber(string phoneNumber) => new(phoneNumber);
    
}