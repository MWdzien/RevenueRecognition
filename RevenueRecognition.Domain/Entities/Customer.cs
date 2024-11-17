using RevenueRecognition.Domain.ValueObjects;
using RevenueRecognition.Shared.Abstractions.Domain;

namespace RevenueRecognition.Domain.Entities;

public abstract class Customer
{
    // im treating email as the customerId (every client should have a unique email)
    public CustomerEmail Email { get; protected set; }

    protected CustomerAddress Address { get; set; }
    protected CustomerPhoneNumber PhoneNumber { get; set; }
    protected bool IsDeleted;

    public abstract void MarkAsDeleted();


}