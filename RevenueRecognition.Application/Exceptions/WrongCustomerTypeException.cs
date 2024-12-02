using RevenueRecognition.Shared.Abstractions.Exceptions;
using RevenueRecognition.Shared.Enums;

namespace RevenueRecognition.Application.Exceptions;

public class WrongCustomerTypeException(CustomerType customerType, Guid customerId) : RevenueRecognitionException($"customer with ID {customerId} is not {customerType}")
{
    
}