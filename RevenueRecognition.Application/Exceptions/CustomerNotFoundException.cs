using RevenueRecognition.Shared.Abstractions.Exceptions;

namespace RevenueRecognition.Application.Exceptions;

public class CustomerNotFoundException(Guid customerId) : RevenueRecognitionException($"customer with ID {customerId} not found")
{
    
}