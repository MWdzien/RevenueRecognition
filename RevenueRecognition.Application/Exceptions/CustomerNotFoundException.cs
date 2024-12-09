using RevenueRecognition.Shared.Abstractions.Exceptions;

namespace RevenueRecognition.Application.Exceptions;

public class CustomerNotFoundException(string email) : RevenueRecognitionException($"customer with email {email} not found")
{
    
}