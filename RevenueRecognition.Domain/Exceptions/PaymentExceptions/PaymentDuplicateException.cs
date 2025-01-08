using RevenueRecognition.Domain.ValueObjects;
using RevenueRecognition.Shared.Abstractions.Exceptions;

namespace RevenueRecognition.Domain.Exceptions.PaymentExceptions;

public class PaymentDuplicateException(ContractId contractId, DateTime date, decimal amount) : RevenueRecognitionException($"Contract with ID: '{contractId}' has already saved payment: {date}_{amount}")
{
    
}