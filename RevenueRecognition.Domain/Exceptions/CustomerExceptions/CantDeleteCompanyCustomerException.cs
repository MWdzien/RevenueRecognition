using RevenueRecognition.Shared.Abstractions.Exceptions;

namespace RevenueRecognition.Domain.Exceptions;

public class CantDeleteCompanyCustomerException() : RevenueRecognitionException("company customer can not be deleted")
{
    
}