using RevenueRecognition.Shared.Abstractions.Exceptions;

namespace RevenueRecognition.Domain.Exceptions.DiscountExceptions;

public class InvalidDiscountCodeFormatException(string discountCode) : RevenueRecognitionException($"DiscountCode: '{discountCode}' has invalid format")
{
    
}