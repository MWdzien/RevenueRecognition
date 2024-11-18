using RevenueRecognition.Shared.Abstractions.Exceptions;

namespace RevenueRecognition.Application.Exceptions;

public class CustomerAlreadyExistsException(string attributeName, string value) : RevenueRecognitionException($"customer with {attributeName}: '{value}' already exists")
{
    
}