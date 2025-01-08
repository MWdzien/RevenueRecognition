using System.Collections;
using RevenueRecognition.Domain.Enums;
using RevenueRecognition.Domain.Exceptions.PaymentExceptions;
using RevenueRecognition.Domain.ValueObjects;

namespace RevenueRecognition.Domain.Entities;

public class Contract
{
    public ContractId ContractId { get; private set; }
    private DateTime _startDate;
    private DateTime _endDate;
    private TimeSpan _contractPeriod;
    public ContractStatus ContractStatus;

    private readonly List<Payment> _payments = new();
    public Customer Customer;
    public Software Software;
    public Subscription Subscription;

    internal Contract(DateTime startDate, DateTime endDate, Customer customer, Software software, Subscription subscription, List<Payment> payments)
    {
        _startDate = startDate;
        _endDate = endDate;
        Customer = customer;
        Software = software;
        Subscription = subscription;
        _payments = payments;
        _contractPeriod = _endDate - _startDate;
    }

    public Contract(DateTime startDate, DateTime endDate, Customer customer, Software software, Subscription subscription)
    {
        _startDate = startDate;
        _endDate = endDate;
        Customer = customer;
        Software = software;
        Subscription = subscription;
        _contractPeriod = _endDate - _startDate;
        
    }


    public void AddPayment(Payment payment)
    {
        var alreadyExists = _payments.Any(p => p.Date == payment.Date && p.Amount == payment.Amount);

        if (alreadyExists)
            throw new PaymentDuplicateException(ContractId, payment.Date, payment.Amount);
        
        _payments.Add(payment);
    }
}