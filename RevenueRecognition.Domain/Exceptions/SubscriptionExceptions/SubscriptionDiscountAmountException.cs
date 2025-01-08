using RevenueRecognition.Domain.ValueObjects.SubscriptionValueObjects;
using RevenueRecognition.Shared.Abstractions.Exceptions;

namespace RevenueRecognition.Domain.Exceptions.SubscriptionExceptions;

public class SubscriptionDiscountAmountException()
    : RevenueRecognitionException($"Subscriptions can not have more than 2 discounts")
{
    
}