using RevenueRecognition.Shared.Abstractions.Exceptions;

namespace RevenueRecognition.Domain.Exceptions.CustomerExceptions;

public class CustomerContractAlreadyExistsException(string email, string softwareName) : RevenueRecognitionException($"Customer with email: {email} already has an active contract for software: {softwareName}")
{
    
}