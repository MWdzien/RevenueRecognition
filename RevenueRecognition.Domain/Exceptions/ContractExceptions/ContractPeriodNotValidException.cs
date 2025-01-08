using RevenueRecognition.Shared.Abstractions.Exceptions;

namespace RevenueRecognition.Domain.Exceptions.ContractExceptions;

public class ContractPeriodNotValidException() : RevenueRecognitionException($"Contracts timespan has to be between 3 and 30 days long")
{
    
}