using RevenueRecognition.Shared.Abstractions.Exceptions;

namespace RevenueRecognition.Domain.Exceptions.CustomerExceptions;

public class InvalidCustomerAttributeException(string attribute, string message) : RevenueRecognitionException($"{attribute} is invalid: {message}")
{
    
}