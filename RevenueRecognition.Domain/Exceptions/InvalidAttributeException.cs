using RevenueRecognition.Shared.Abstractions.Exceptions;

namespace RevenueRecognition.Domain.Exceptions;

public class InvalidAttributeException(string attribute, string requirement) : RevenueRecognitionException($"{attribute} has to be {requirement}")
{
    
}