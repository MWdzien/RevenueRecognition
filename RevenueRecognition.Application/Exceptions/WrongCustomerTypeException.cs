using RevenueRecognition.Shared.Abstractions.Exceptions;
using RevenueRecognition.Shared.Enums;

namespace RevenueRecognition.Application.Exceptions;

public class WrongCustomerTypeException(CustomerType customerType, string email) : RevenueRecognitionException($"customer with email {email} is not {customerType}")
{
    
}