using RevenueRecognition.Domain.Enums;
using RevenueRecognition.Domain.Exceptions.SubscriptionExceptions;
using RevenueRecognition.Domain.ValueObjects.DiscountValueObjects;
using RevenueRecognition.Domain.ValueObjects.SubscriptionValueObjects;

namespace RevenueRecognition.Domain.Entities;

public class Subscription
{
    public SubscriptionId SubscriptionId { get; set; }
    public SubscriptionPrice Price { get; set; }
    public SubscriptionRenewalPeriod RenewalPeriod { get; set; }
    public SubscriptionStatus Status { get; set; }

    public readonly List<Discount> Discounts = new();

    public Subscription(SubscriptionPrice price, SubscriptionRenewalPeriod renewalPeriod, SubscriptionStatus status, List<Discount> discounts)
    {
        Price = price;
        RenewalPeriod = renewalPeriod;
        Status = status;
        Discounts = discounts;
    }

    public Subscription(SubscriptionPrice price, SubscriptionRenewalPeriod renewalPeriod, SubscriptionStatus status)
    {
        Price = price;
        RenewalPeriod = renewalPeriod;
        Status = status;
    }

    public void AddDiscount(Discount discount)
    {
        if (Discounts.Count > 2)
            throw new SubscriptionDiscountAmountException();
        
        
    }
}