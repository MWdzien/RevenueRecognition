using RevenueRecognition.Shared.Abstractions.Exceptions;

namespace RevenueRecognition.Domain.Exceptions.PaymentExceptions;

public class PaymentAmountNotValidException() : RevenueRecognitionException($"Payment amount has to be more than 0")
{
    
}