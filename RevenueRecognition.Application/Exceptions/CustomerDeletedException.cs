using RevenueRecognition.Shared.Abstractions.Exceptions;

namespace RevenueRecognition.Application.Exceptions;

public class CustomerDeletedException(string email) : RevenueRecognitionException($"Customer with email {email} has been deleted")
{
    
}