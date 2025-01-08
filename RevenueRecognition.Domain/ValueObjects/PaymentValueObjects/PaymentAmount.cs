using RevenueRecognition.Domain.Exceptions;

namespace RevenueRecognition.Domain.ValueObjects.PaymentValueObjects;

public record PaymentAmount
{
    public decimal Value { get; set; }

    public PaymentAmount(decimal value)
    {
        if (value <= 0)
            throw new InvalidAttributeException(nameof(PaymentAmount), "a positive number");
        
        Value = value;
    }
    
    public static implicit operator decimal(PaymentAmount amount) => amount.Value;
    public static implicit operator PaymentAmount(decimal amount) => new(amount);
}