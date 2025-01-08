using RevenueRecognition.Shared.Abstractions.Exceptions;

namespace RevenueRecognition.Domain.Exceptions;

public class EmptyAttributeException(string className, string attribute) : RevenueRecognitionException($"{className}s '{attribute}' can not be empty")
{
    
}