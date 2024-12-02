using RevenueRecognition.Domain.ValueObjects;
using RevenueRecognition.Shared.Abstractions.Domain;

namespace RevenueRecognition.Domain.Entities;

public abstract class Customer
{
    public CustomerId CustomerId { get; protected set; } // = Guid.NewGuid();
    
    protected CustomerEmail Email { get; set; }
    protected CustomerAddress Address { get; set; }
    protected CustomerPhoneNumber PhoneNumber { get; set; }
    protected bool IsDeleted;

    protected Customer()
    {
    }

    public abstract void MarkAsDeleted();
    
    


}