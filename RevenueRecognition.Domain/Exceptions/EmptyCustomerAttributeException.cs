using RevenueRecognition.Shared.Abstractions.Exceptions;

namespace RevenueRecognition.Domain.Exceptions;

public class EmptyCustomerAttributeException(string attribute) : RevenueRecognitionException($"{attribute} can not be empty")
{
    
}