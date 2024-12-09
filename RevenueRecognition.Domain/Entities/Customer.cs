using RevenueRecognition.Domain.ValueObjects;
using RevenueRecognition.Shared.Abstractions.Domain;

namespace RevenueRecognition.Domain.Entities;

public abstract class Customer
{
    
    
    public CustomerEmail Email { get; set; }
    protected CustomerAddress Address { get; set; }
    protected CustomerPhoneNumber PhoneNumber { get; set; }
    

    protected Customer()
    {
    }

    public abstract void MarkAsDeleted();
    
    


}