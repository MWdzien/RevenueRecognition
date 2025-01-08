using RevenueRecognition.Domain.Enums;
using RevenueRecognition.Domain.Exceptions;
using RevenueRecognition.Domain.Exceptions.PaymentExceptions;
using RevenueRecognition.Domain.ValueObjects.PaymentValueObjects;

namespace RevenueRecognition.Domain.Entities;

public class Payment
{
    public PaymentAmount Amount { get; }
    public DateTime Date { get; }
    public PaymentStatus PaymentStatus { get; }

    public Payment(PaymentAmount amount, DateTime date, PaymentStatus paymentStatus)
    {
        Amount = amount;
        Date = date;
        PaymentStatus = paymentStatus;
    }
}