using RevenueRecognition.Shared.Abstractions.Exceptions;

namespace RevenueRecognition.Domain.Exceptions;

public class EmptyCustomerAttributeException(string attribute) : RevenueRecognitionException($"Customers '{attribute}' can not be empty")
{
    
}